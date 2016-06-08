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
    /// Interaction logic for AddUserForm.xaml
    /// </summary>
    public partial class AddUserForm : Window
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string input = userNameInput.GetLineText(0);
            if (input == null)
            {
                MessageBox.Show("Please, enter a name", "Empty name");
            }            
            UserProfileManager.AddUser(input);           
            this.Close();

        }
    }
}
