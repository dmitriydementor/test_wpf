using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace LearnIT.Models
{
    class MyDictionary : IList<WordCard> // ICollection, IEnumerable
    {
        private List<WordCard> dictionary = null;

        private string dictionaryName;

        private string activeUser;

        public string DictionaryName
        {
            get
            {
                return dictionaryName;
            }
        }

        public List<WordCard> Dictionary
        {
            get
            {
                return dictionary;
            }
        }

        public int Count {
            get
            {
                return dictionary.Count;
            }
        }

        #region Implementing IList
        int IList<WordCard>.IndexOf(WordCard item)
        {
            return dictionary.IndexOf(item);
        }

        void IList<WordCard>.Insert(int index, WordCard item)
        {
            dictionary.Insert(index, item);
        }

        void IList<WordCard>.RemoveAt(int index)
        {
            dictionary.RemoveAt(index);
        }

        WordCard IList<WordCard>.this[int index]
        {
            get
            {
                return dictionary[index];
            }
            set
            {
                dictionary[index] = value;
            }
        }

        void ICollection<WordCard>.Add(WordCard item)
        {
            dictionary.Add(item);
        }

        void ICollection<WordCard>.Clear()
        {
            dictionary.Clear();
        }

        bool ICollection<WordCard>.Contains(WordCard item)
        {
            return dictionary.Contains(item);
        }

        void ICollection<WordCard>.CopyTo(WordCard[] array, int arrayIndex)
        {
            dictionary.CopyTo(array, arrayIndex);
        }

        int ICollection<WordCard>.Count
        {
            get { return dictionary.Count; }
        }

        bool ICollection<WordCard>.IsReadOnly
        {
            get { return false; }
        }

        bool ICollection<WordCard>.Remove(WordCard item)
        {
            return dictionary.Remove(item);
        }

        IEnumerator<WordCard> IEnumerable<WordCard>.GetEnumerator()
        {
            return dictionary.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return dictionary.GetEnumerator();
        }
        #endregion

        public MyDictionary()
        {
            dictionary = new List<WordCard>();
            //Console.WriteLine("DCtor");
        }

        public void ChangeUser(string userName)
        {
            activeUser = userName;            
        }

        public MyDictionary(string dictionaryName, string user)
            : this()
        {
            this.dictionaryName = dictionaryName;
            activeUser = user;
            dictionary = new List<WordCard>();
            //LoadDictionaryFromXml(dictionaryName);
        }

        public void CreateDictionaryFile()
        {
            if (activeUser != null && dictionaryName != null)
            {
                UpdateDictionaryXml();
            }
        }



        public void LoadDictionaryFromXml(string dictName)
        {
            XmlSerializer xmlSer = new XmlSerializer(typeof(List<WordCard>));
            string path = @"data\users\" + activeUser + @"\" + dictName + @".xml";

            try
            {
                using (Stream fStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    dictionary = (List<WordCard>)xmlSer.Deserialize(fStream);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                //MessageBox.Show("Tryed to load system file. Please restart app");
                
                //throw new Exception("Tryed to load system file. Please restart app");
                
            }

        }

        public void AddWordCard(WordCard wc)
        {
            dictionary.Add(wc);
            UpdateDictionaryXml();
        }

        public void UpdateDictionaryXml()
        {
            XmlSerializer xmlSer = new XmlSerializer(typeof(List<WordCard>));
            string s = @"data\\users\\" + activeUser + @"\\" + dictionaryName + @".xml";
            string path = Path.GetFullPath(s);
            try // save dictionary in file
            {
                using (Stream fStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    xmlSer.Serialize(fStream, dictionary);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void EndWork()
        {
            if (dictionary != null)
            {
                dictionary.Clear();
            }
        }
    }
}
