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
using System.Windows.Shapes;
using System.ComponentModel; // INotifyDataErrorInfo

// My namespaces
using LearnIT.Presenters;

namespace LearnIT.Views.Dialogs
{
    /// <summary>
    /// Interaction logic for AddDictionaryForm.xaml
    /// </summary>
    public partial class AddDictionaryForm : Window
    {        
        public AddDictionaryForm()
        {            
            InitializeComponent();
            DictionaryName dictionaryName = new DictionaryName();
            dictionaryAddGrid.DataContext = dictionaryName; // binding

        }

        private void addDictionaryBtn_Click(object sender, RoutedEventArgs e)
        {
            DictionaryName dictionaryName = (DictionaryName)dictionaryAddGrid.DataContext;
            if (!dictionaryName.errorFlag)
            {
                DictionaryLoader.CreateDictionary(textBoxDictionaryName.Text);                
                this.Close();
            }
        }
    }

    public class DictionaryName
    {
        public bool errorFlag;
        private string name;
        public DictionaryName()
        {
            errorFlag = false;
        }
        public string Name 
        {
            get { return name; }
            set
            {
                if (value.Equals("system"))
                {
                    errorFlag = true;
                    throw new ArgumentException("Error! This name is reserved. Choose another one.");
                }
                else
                {
                    errorFlag = false;
                    name = value;                   
                }
            }
        }
    }
}
