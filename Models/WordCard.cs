using System;
using System.Collections.Generic;
using System.ComponentModel; // INotify
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LearnIT.Models
{
    public enum WayOfTranslation
    {
        WordTranslation,
        TranslationWord
    }
    [Serializable]
    public class ExampleOfWordUsage
    {
        public string ExampleWithWord { get; set; }
        public string TranslatedExample { get; set; }
        public ExampleOfWordUsage()
        {
            ExampleWithWord = TranslatedExample = "";
        }
        public ExampleOfWordUsage(string example, string translation)
        {
            ExampleWithWord = example;
            TranslatedExample = translation;
        }
        public override string ToString()
        {
            return string.Format("{0} - {1}", ExampleWithWord, TranslatedExample);
        }
    }
    [Serializable]
    public class WordCard
    {
        private string word;
        public string Word {
            get
            {
                return word;
            }
            set
            {
                word = value;                          
            }
        }
        private string translation;
        public string Translation 
        {
            get { return translation; }
            set 
            {
                translation = value;
                        
            }
        }
        private ExampleOfWordUsage example;
        public ExampleOfWordUsage Example {
            get { return example; }
            set
            {
                example = value;                             
            }
        }

        private int timesAnsweredCorrectly;
        public int TimesAnsweredCorrectly
        {
            set
            {
                timesAnsweredCorrectly = value;
            }
            get
            {
                return timesAnsweredCorrectly;
            }
        }        

        public WordCard()
        {
            /*This is for XmlSerializer - it -requires default ctor*/
            word = "";
            translation = "";            
            example = new ExampleOfWordUsage("", "");
            timesAnsweredCorrectly = 0;
        }
        public WordCard(string word, string translation)
        {
            Word = word;
            Translation = translation;
            timesAnsweredCorrectly = 0;
            Example = new ExampleOfWordUsage("", ""); // empty strings if no examples           
        }
        public WordCard(string word, string translation, string example, string exampleTranslation)
        {
            Word = word;
            Translation = translation;
            Example = new ExampleOfWordUsage(example, exampleTranslation);
            timesAnsweredCorrectly = 0;
        }           

        public override string ToString()
        {            
            string result = String.Format("{0} - {1} ({2})", Word, Translation, Example);
            return result;
        }       
        
    }   
    
}
