using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Security.Cryptography; // for mixing the lists

//My namespaces
using LearnIT.Presenters;
using System.Xml;
using System.Xml.Serialization;


namespace LearnIT.Views.QuizPages
{
    /// <summary>
    /// Interaction logic for QuizPage.xaml
    /// </summary>
    public partial class QuizPage : Page
    {
        private XmlDataProvider xmlWordsProvider;
        private XmlDataProvider xmlTranslationsProvider;                

        QuizProvider quiz = new QuizProvider();
        public QuizPage()
        {
            InitializeComponent();      
            NextPartOfQuiz();
        }

        public void NextPartOfQuiz()
        {
            quiz.ShuffleWordLists(); // mix words

            quiz.MakeWordsXml();
            quiz.MakeTranslationXml();
            LoadWordsXml();
            LoadTranslationsXml();
            if (quiz.WordsList.Count == 0)
            {
                resultTextBlock.Text = "Game over!";
            }
        }   
          

        private void FirstColumnSelected(object sender, SelectionChangedEventArgs e)
        {
            if (listBoxWords.SelectedItem!=null)
            {
                if (listBoxTranslations.SelectedItem != null)
                {
                    string word = UnSerializeXmlElement<string>(listBoxWords.SelectedItem as XmlElement);
                    string translation = UnSerializeXmlElement<string>(listBoxTranslations.SelectedItem as XmlElement);
                    bool validated = quiz.ValidateWordPair(word, translation);
                    if (validated)
                    {
                        NotificationGood();
                        
                        quiz.TranslationList.Remove(translation);
                        quiz.WordsList.Remove(word);
                        quiz.MakeTranslationXml();
                        quiz.MakeWordsXml();
                        LoadTranslationsXml();
                        LoadWordsXml();
                        CheckIfColumnsEmpty();
                    }
                    else NotificationBad();
                }                
            }            
        }

        private void NotificationBad()
        {
            resultTextBlock.Text = "Bad!";
            Color color = (Color)ColorConverter.ConvertFromString("#FFFF0202");
            resultTextBlock.Foreground = new SolidColorBrush(color);
        }

        private void NotificationGood()
        {
            resultTextBlock.Text = "Good!";
            Color color = (Color)ColorConverter.ConvertFromString("#FFA9F32C");
            resultTextBlock.Foreground = new SolidColorBrush(color);
        }

        
       

        private void SecondColumnSelected(object sender, SelectionChangedEventArgs e)
        {
            if (listBoxTranslations.SelectedItem != null)
            {
                if (listBoxWords.SelectedItem != null)
                {
                    string word = UnSerializeXmlElement<string>(listBoxWords.SelectedItem as XmlElement);
                    string translation = UnSerializeXmlElement<string>(listBoxTranslations.SelectedItem as XmlElement);
                    bool validated = quiz.ValidateWordPair(word, translation);
                    if (validated)
                    {
                        NotificationGood();
                        quiz.TranslationList.Remove(translation);
                        quiz.WordsList.Remove(word);
                        quiz.MakeTranslationXml();
                        quiz.MakeWordsXml();
                        LoadTranslationsXml();
                        LoadWordsXml();
                        if (!CheckToStartNextPart()) CheckIfColumnsEmpty();
                    }
                    else NotificationBad();
                }                
            }           
        }

        public bool CheckToStartNextPart()
        {
            if (quiz.partOfGame == PartOfGame.TypeWords && listBoxWords.Items.Count == 1)
            {
                TypeWordsQuizPage typeQuiz = new TypeWordsQuizPage(quiz);                
                NavigationService.Navigate(typeQuiz);
                return true;
            }
            else return false;
        }

        public void CheckIfColumnsEmpty()
        {
            
            if (quiz.WordsList.Count == 0 && quiz.TranslationList.Count == 0)
            {
                quiz.FillWordLists();
                quiz.ShuffleWordLists();
                NextPartOfQuiz();
            }
        }

        private void LoadWordsXml()
        {
            xmlWordsProvider = this.TryFindResource("xmlWordsProvider") as XmlDataProvider;
            if (xmlWordsProvider != null)
            {
                string path = @"data/tempWords.xml";
                XmlDocument doc = new XmlDocument();
                doc.Load(path);
                xmlWordsProvider.Document = doc;
                xmlWordsProvider.XPath = "/ArrayOfString";
            }           
        }

        private void LoadTranslationsXml()
        {
            xmlTranslationsProvider = this.TryFindResource("xmlTranslationsProvider") as XmlDataProvider;
            if (xmlTranslationsProvider != null)
            {
                string path = @"data/tempTranslation.xml";
                XmlDocument doc = new XmlDocument();
                doc.Load(path);
                xmlTranslationsProvider.Document = doc;
                xmlTranslationsProvider.XPath = "/ArrayOfString";
            }
        }

        public static T UnSerializeXmlElement<T>(XmlElement xmlElement)
        {
            var serializer = new XmlSerializer(typeof(T));
            return (T)serializer.Deserialize(new XmlNodeReader(xmlElement));
        }

        private void BackToDictionariesListBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(this.Parent);
        }

        private void QuizHelpBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("God will help you)");
        }
    }

    

}
