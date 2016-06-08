using System;
using System.Collections.Generic;
using System.Diagnostics;
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
// My namespaces
using LearnIT.Models;
using LearnIT.Views.Dialogs;
using LearnIT.Presenters;

namespace LearnIT.Views
{
    /// <summary>
    /// Interaction logic for UserSelect.xaml
    /// </summary>
    public partial class UserSelect : Page
    {
        public UserSelect()
        {
            InitializeComponent();

            // Support for minwidth & minheight for page
            this.Loaded += delegate
            {
                Window window = Window.GetWindow(this);
                window.SetBinding(Window.MinHeightProperty, new Binding() { Source = this.MinHeight });
                window.SetBinding(Window.MinWidthProperty, new Binding() { Source = this.MinWidth });
            };

            
            
            List<String> userNames = UserProfileManager.UsersList;
            foreach (string userName in userNames)
            {
                usersListBox.Items.Add(userName);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {            
            string userChoice = usersListBox.SelectedItem as String;            
            if (usersListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please, select user or add a new one", "Nothing chosen");
            }
            else if (usersListBox.SelectedIndex == 0)
            {
                AddUserForm modal = new AddUserForm();
                modal.Owner = Window.GetWindow(this);
                modal.ShowDialog();
                UserProfileManager.UpdateUsersList();                
                foreach (string userName in UserProfileManager.UsersList)
                {
                    if (usersListBox.Items.Contains(userName) == false)
                    {
                        usersListBox.Items.Insert(1, userName);
                    }
                    
                }
            }
            else
            {                
                UserDictionaries dictionarySelect = new UserDictionaries(userChoice);
                this.AddLogicalChild(dictionarySelect);
                NavigationService.Navigate(dictionarySelect);                                               
            }
            
        }
    }
}
