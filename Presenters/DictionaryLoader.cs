using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;
// My namespaces
using LearnIT.Models;
using System.Xml;
using System.Xml.Linq;

namespace LearnIT.Presenters
{
    public class DictionaryNameAndAmount
    {  
        public string Name { get; set; }
        public int Size { get; set; }
        public DictionaryNameAndAmount(string name, int size)
	    {
            Name = name;
            Size = size;
	    }
        public DictionaryNameAndAmount()
        {
            Name = "";
            Size = 0;
        }
    }
    class DictionaryLoader
    {
        protected static MyDictionary activeDictionary = null;

        protected static string activeUser;

        protected static List<string> dictionaryNames;
        public static List<string> DictionaryNames {
            get { return dictionaryNames; }
            set { dictionaryNames = value; }
        }

        public static List<DictionaryNameAndAmount> metadata;

        public static string ActiveUser 
        {
            get { return activeUser; }
        }


        public static void Initialize()
        {
            DownloadDictionaryNames();            
            metadata = new List<DictionaryNameAndAmount>(); // info about dictionaries (amount of words)
            for (int i = 0; i < dictionaryNames.Count; i++)
            {
                SelectDictionary(dictionaryNames[i]);
                metadata.Add(new DictionaryNameAndAmount(dictionaryNames[i], activeDictionary.Count));
            }
            if (activeDictionary != null)
            {
                activeDictionary.EndWork();
            }
            SerializeMetadata(); // save dictionary metadata
        }

        public static void ClearAllResults()
        {
            if (activeDictionary != null)
            {
                foreach (WordCard wc in activeDictionary)
                {
                    wc.TimesAnsweredCorrectly = 0;
                }
                activeDictionary.UpdateDictionaryXml();
            }
            
        }

        public static void CreateDictionary(string name)
        {
            if (activeDictionary != null)
            {
                activeDictionary.EndWork();
            }            
            activeDictionary = new MyDictionary(name, activeUser);
            activeDictionary.CreateDictionaryFile();

            metadata.Add(new DictionaryNameAndAmount(name, 0));
            SerializeMetadata();
        }

        public static void DeleteDictionary(DictionaryNameAndAmount d)
        {
            int index = -1;
            foreach (DictionaryNameAndAmount item in metadata)
            {
                if (item.Name.Equals(d.Name) && item.Size == d.Size)
                {
                    index = metadata.IndexOf(item);
                }
            }
            if (index != -1) metadata.RemoveAt(index);           
            SerializeMetadata();
            string path = @"data\users\" + activeUser + @"\" + d.Name + @".xml";
            FileInfo file = new FileInfo(path);
            file.Delete();
        }

        protected static void SerializeMetadata()
        {
            XmlSerializer xmlSer = new XmlSerializer(typeof(List<DictionaryNameAndAmount>));            
            
            string s = @"data\users\" + activeUser + @"\system.xml";
            string path = Path.GetFullPath(s);
            try // save metadata in file
            {
                using (Stream fStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    xmlSer.Serialize(fStream, metadata);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        protected static void DeserializeMetadata()
        {
            XmlSerializer xmlSer = new XmlSerializer(typeof(List<DictionaryNameAndAmount>));
            string s = @"data\users\" + activeUser + @"\system.xml";
            string path = Path.GetFullPath(s);
            try // save metadata in file
            {
                using (Stream fStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    metadata = (List<DictionaryNameAndAmount>)xmlSer.Deserialize(fStream);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static bool AddWordCard(WordCard wc)
        {
            if (activeDictionary != null)
            {
                activeDictionary.AddWordCard(wc);
                int index = metadata.IndexOf(new DictionaryNameAndAmount(activeDictionary.DictionaryName, activeDictionary.Count));
                metadata[index].Size++;
                return true;
            }
            else return false;
        }

        public static MyDictionary ActiveDictionary
        {
            get
            {
                return activeDictionary;
            }
        }
        protected static void DownloadDictionaryNames()
        {
            if (activeUser != null)
            {
                string path = @"data\users\" + activeUser;
                DirectoryInfo usersDirectory = new DirectoryInfo(path);
                FileInfo[] dictionaries = usersDirectory.GetFiles();
                // get all file names exept settings.xml
                dictionaryNames = ((IEnumerable<string>)(from dicName in dictionaries where !string.Equals("settings.xml", dicName.Name) && !dicName.Name.Contains("system") select (dicName.Name.Replace(".xml", "")))).ToList();                
            }
        }

        public static void SelectUser(string userName)
        {
            activeUser = userName;
            Initialize();            
        }

        public static void SelectDictionary(string dictionaryName)
        {
            if (activeDictionary != null)
            {
                activeDictionary.EndWork();
                activeDictionary = new MyDictionary(dictionaryName, activeUser);
                activeDictionary.LoadDictionaryFromXml(dictionaryName);
            }
            else
            {
                activeDictionary = new MyDictionary(dictionaryName, activeUser);
                activeDictionary.LoadDictionaryFromXml(dictionaryName);
            }

        }
    }
}