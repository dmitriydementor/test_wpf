using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using System.IO;
using System.Security.Cryptography;

// My namespaces
using LearnIT.Models;
using LearnIT.Presenters;
using System.Windows;


public enum PartOfGame
{
    MatchWords,
    TypeWords
}

namespace LearnIT.Presenters
{
    [Serializable]
    public class QuizProvider
    {
        public PartOfGame partOfGame;     

        
        public ObservableCollection<WordCard> selectedWordsList { get; set; }        
        public ObservableCollection<WordCard> separatedWordList { get; set; }

        public ObservableCollection<string> WordsList { get; set; }
        public ObservableCollection<string> TranslationList { get; set; }
        public int NumberOfIterations { get; set; }

        private int count;

        private int edge; // number in array where the type word quiz starts
        public QuizProvider()
        {
            count = 1;           
            partOfGame = PartOfGame.MatchWords;
            WordsList = new ObservableCollection<string>();
            TranslationList = new ObservableCollection<string>();
            ObservableCollection<WordCard> list = new ObservableCollection<WordCard>(DictionaryLoader.ActiveDictionary.Dictionary);
            if (list != null)
            {
                var querySelected = from wordCard in list where wordCard.TimesAnsweredCorrectly < 12 select wordCard;
                selectedWordsList = new ObservableCollection<WordCard>(((IEnumerable<WordCard>)querySelected).ToList());

                var querySeparated = from wordCard in list where wordCard.TimesAnsweredCorrectly >= 12 select wordCard;
                separatedWordList = new ObservableCollection<WordCard>(((IEnumerable<WordCard>)querySeparated).ToList());
            }
            if (selectedWordsList.Count <= 5) edge = -1;
            else if (selectedWordsList.Count > 5 && selectedWordsList.Count <= 12) edge = selectedWordsList.Count / 2;
            else edge = selectedWordsList.Count - 6;
            FillWordLists();            
        }

        public void MakeWordsXml()
        {
            XmlSerializer xmlSer = new XmlSerializer(typeof(ObservableCollection<string>));
            string path = @"data\tempWords.xml";            
            try // save dictionary in file
            {
                using (Stream fStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    xmlSer.Serialize(fStream, WordsList);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void MakeTranslationXml()
        {
            XmlSerializer xmlSer = new XmlSerializer(typeof(ObservableCollection<string>));
            string path = @"data\tempTranslation.xml";
            try // save dictionary in file
            {
                using (Stream fStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    xmlSer.Serialize(fStream, TranslationList);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void FillWordLists()
        {
            WordsList.Clear();
            TranslationList.Clear();
            for (; count <= selectedWordsList.Count; count++)
            {
                WordsList.Add(selectedWordsList[count-1].Word);
                TranslationList.Add(selectedWordsList[count-1].Translation);
                if (count == edge)
                {
                    partOfGame = PartOfGame.TypeWords;
                    count++;
                    break;
                }
                if (count % 5 == 0 && count != 0 && partOfGame == PartOfGame.MatchWords)
                {
                    count++;
                    break;
                }
            }                               
        }

        public void ShuffleWordLists()
        {
            WordsList.Shuffle(); // mix words
            TranslationList.Shuffle();
        }

        public bool ValidateWordPair(string Word, string Translation)
        {
            var query = from wordCard in selectedWordsList where wordCard.Word == Word && wordCard.Translation.Equals(Translation) select wordCard;
            WordCard wc = new WordCard();
            if (query.ToList().Count != 0)
            {
                wc = query.ToList()[0];
            }
            else return false;
            int index = DictionaryLoader.ActiveDictionary.Dictionary.IndexOf(wc);  //selectedWordsList.IndexOf(wc);
            if (index != -1)
            {
                DictionaryLoader.ActiveDictionary.Dictionary[index].TimesAnsweredCorrectly++; // increment correct answers
                DictionaryLoader.ActiveDictionary.UpdateDictionaryXml(); // save changes
                return true;
            }
            else return false;
        }


    }

    static class MyExtensions
    {
        private static Random rng = new Random();
        public static void Shuffle<T>(this IList<T> list)
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            int n = list.Count;
            while (n > 1)
            {
                byte[] box = new byte[1];
                do provider.GetBytes(box);
                while (!(box[0] < n * (Byte.MaxValue / n)));
                int k = (box[0] % n);
                n--;
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
