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
using System.Xml;

using LearnIT.Presenters;
using LearnIT.Views.Dialogs;
using LearnIT.Models;
using System.Xml.Serialization;

namespace LearnIT.Views
{
    /// <summary>
    /// Interaction logic for EditDictionaryPage.xaml
    /// </summary>
    public partial class EditDictionaryPage : Page
    {
        XmlDataProvider wordsProvider;
        string dictionaryName;
        public EditDictionaryPage()
        {
            
        }

        public EditDictionaryPage(string dictionaryName)
        {
            InitializeComponent();

            // Support for minwidth & minheight for page
            this.Loaded += delegate
            {
                Window window = Window.GetWindow(this);
                window.SetBinding(Window.MinHeightProperty, new Binding() { Source = this.MinHeight });
                window.SetBinding(Window.MinWidthProperty, new Binding() { Source = this.MinWidth });
            };
            this.dictionaryName = dictionaryName;
            LoadXmlWithWordCards();
            
        }

        private void LoadXmlWithWordCards()
        {
            wordsProvider = this.TryFindResource("wordsProvider") as XmlDataProvider;
            if (wordsProvider != null)
            {
                string path = @"data/users/" + DictionaryLoader.ActiveUser + @"/" + dictionaryName + @".xml";
                XmlDocument doc = new XmlDocument();
                doc.Load(path);
                wordsProvider.Document = doc;
                wordsProvider.XPath = "/ArrayOfWordCard";
            }
        }

        private void BackToDictionariesListBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(this.Parent);
        }

        private void NewWordCardBtn_Click(object sender, RoutedEventArgs e)
        {                        
            EditWordCard editDialog = new EditWordCard();
            editDialog.Owner = Window.GetWindow(this);
            editDialog.ShowDialog();
            LoadXmlWithWordCards(); // update output
        }

        public static T UnSerializeXmlElement<T>(XmlElement xmlElement)
        {
            var serializer = new XmlSerializer(typeof(T));
            return (T)serializer.Deserialize(new XmlNodeReader(xmlElement));

        }

        private void EditWordCardBtn_Click(object sender, RoutedEventArgs e)
        {
            if (listViewWordCards.SelectedItem != null)
            {
                WordCard wc = UnSerializeXmlElement<WordCard>(listViewWordCards.SelectedItem as XmlElement);
                int index = listViewWordCards.SelectedIndex;
                EditWordCard editDialog = new EditWordCard(wc, index);
                editDialog.Owner = Window.GetWindow(this);
                editDialog.ShowDialog();
                LoadXmlWithWordCards(); // update output
            }            
        }

        private void DeleteWordCardBtn_Click(object sender, RoutedEventArgs e)
        {
            WordCard wc = UnSerializeXmlElement<WordCard>(listViewWordCards.SelectedItem as XmlElement);
            int index = listViewWordCards.SelectedIndex;
            
            DeleteConfirmation deleteDialog = new DeleteConfirmation(wc.Word);
            deleteDialog.Owner = Window.GetWindow(this);
            deleteDialog.ShowDialog();
            if (deleteDialog.GetResult())
            {
                DictionaryLoader.ActiveDictionary.Dictionary.RemoveAt(index);
                DictionaryLoader.ActiveDictionary.UpdateDictionaryXml();
                LoadXmlWithWordCards(); // update output
            }
            

        }

        private void ClearResultsBtn_Click(object sender, RoutedEventArgs e)
        {
            DictionaryLoader.ClearAllResults();
            LoadXmlWithWordCards();
        }
    }
}
