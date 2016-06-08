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

// My namespaces
using LearnIT.Presenters;

namespace LearnIT.Views.Dialogs
{
    /// <summary>
    /// Interaction logic for DeleteDictionaryConfirmation.xaml
    /// </summary>
    public partial class DeleteConfirmation : Window
    {
        
        DictionaryNameAndAmount dictionaryMetadata;
        private bool delete;
        private string p;
        public DeleteConfirmation()
        {
            InitializeComponent();
        }        

        public DeleteConfirmation(string p)
        {
            InitializeComponent();           
            stringWithDictionaryName.Text += p;
        }

        private void DeleteDictionaryBtn_Click(object sender, RoutedEventArgs e)
        {
            delete = true;            
            this.Close();
        }

        public bool GetResult()
        {
            return delete;
        }

        private void CancelDictionaryDeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            delete = false;
            this.Close();
        }
    }
}
