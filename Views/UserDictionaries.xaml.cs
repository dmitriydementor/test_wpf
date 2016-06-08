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
using System.Xml.Serialization;

// My namespaces
using LearnIT.Models;
using LearnIT.Presenters;
using LearnIT.Views.Dialogs;
using LearnIT.Views.QuizPages;
using System.ComponentModel;



namespace LearnIT.Views
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class UserDictionaries : Page
    {
        XmlDataProvider xmlDataProvider = new XmlDataProvider();
        public UserDictionaries(string selectedUser) : this() // default ctor
        {            
            DictionaryLoader.SelectUser(selectedUser);
            LoadXmlWithDictionaryNames(selectedUser);       
        }

        private void LoadXmlWithDictionaryNames(string userName)
        {
            xmlDataProvider = this.TryFindResource("dictionaryNameProvider") as XmlDataProvider;
            if (xmlDataProvider != null)
            {
                string path = @"data/users/" + userName + @"/system.xml";
                XmlDocument doc = new XmlDocument();
                doc.Load(path);
                xmlDataProvider.Document = doc;
                xmlDataProvider.XPath = "/ArrayOfDictionaryNameAndAmount";                               
            }
        }        

        public UserDictionaries()
        {
            InitializeComponent();

            // Support for minwidth & minheight for page
            this.Loaded += delegate
            {
                Window window = Window.GetWindow(this);
                window.SetBinding(Window.MinHeightProperty, new Binding() { Source = this.MinHeight });
                window.SetBinding(Window.MinWidthProperty, new Binding() { Source = this.MinWidth });
            };                      
        }
        

        private void MenuFileExit_Click(object sender, RoutedEventArgs e)
        {            
            Application.Current.MainWindow.Close();
        }

        private void CreateDictionaryMenu_Click(object sender, RoutedEventArgs e)
        {
            AddDictionaryForm addDictForm = new AddDictionaryForm();
            addDictForm.Owner = Window.GetWindow(this);
            addDictForm.ShowDialog();

            xmlDataProvider.Refresh();
            string path = @"data/users/" + DictionaryLoader.ActiveUser + @"/system.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            xmlDataProvider.Document = doc;          
            
        }

        private void SwitchUserMenu_Click(object sender, RoutedEventArgs e)
        {
            if (DictionaryLoader.ActiveDictionary != null)
            {
                DictionaryLoader.DictionaryNames.Clear();
                DictionaryLoader.metadata.Clear();
            }
            NavigationService.Navigate(this.Parent);
        }

        private void StartLearningBtn_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxDictionaries.SelectedItem as XmlElement != null)
            {
                DictionaryNameAndAmount d = UnSerializeXmlElement<DictionaryNameAndAmount>(listBoxDictionaries.SelectedItem as XmlElement);
                DictionaryLoader.SelectDictionary(d.Name);

                QuizPage quiz = new QuizPage();
                this.AddLogicalChild(quiz);
                NavigationService.Navigate(quiz);
            }
            
        }        

        public static T UnSerializeXmlElement<T>(XmlElement xmlElement)
        {
            var serializer = new XmlSerializer(typeof(T));
            return (T)serializer.Deserialize(new XmlNodeReader(xmlElement));
            
        }        

        private void DeleteDictionaryMenu_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxDictionaries.SelectedItem as XmlElement != null)
            {
                DictionaryNameAndAmount d = UnSerializeXmlElement<DictionaryNameAndAmount>(listBoxDictionaries.SelectedItem as XmlElement);                
                DeleteConfirmation dialogConfirm = new DeleteConfirmation(d.Name);               
               
                dialogConfirm.Owner = Window.GetWindow(this);
                dialogConfirm.ShowDialog();
                if (dialogConfirm.GetResult()) DictionaryLoader.DeleteDictionary(d);
                
                string path = @"data/users/" + DictionaryLoader.ActiveUser + @"/system.xml";
                XmlDocument doc = new XmlDocument();
                doc.Load(path);
                xmlDataProvider.Document = doc;
            }
             
        }

        private void EditDictionaryMenu_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxDictionaries.SelectedItem as XmlElement != null)
            {
                DictionaryNameAndAmount d = UnSerializeXmlElement<DictionaryNameAndAmount>(listBoxDictionaries.SelectedItem as XmlElement);
                DictionaryLoader.SelectDictionary(d.Name);
                EditDictionaryPage editPage = new EditDictionaryPage(d.Name);
                this.AddLogicalChild(editPage);
                NavigationService.Navigate(editPage);
            }
            
        }

        private void ApplicationHelpBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Help)");
        }

        private void AboutBtn_Click(object sender, RoutedEventArgs e)
        {
            AboutWindow about = new AboutWindow();
            about.Show();
        }

        private void HelpBtn_Click(object sender, RoutedEventArgs e)
        {
            Help help = new Help();
            help.Show();
        }                 
    }   
}
