using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
// My namespaces
using LearnIT.Presenters;

namespace LearnIT
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        public App()
        {
            this.Startup += new StartupEventHandler(AppSturtUp);            
            this.Exit += new ExitEventHandler(AppExit);
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            System.Windows.Forms.Application.EnableVisualStyles(); // Enabling basic styles instead of old-fashioned win-xp
        }

        private void AppSturtUp(object sender, StartupEventArgs e)
        {
            UserProfileManager.Initialize();  // Initializing user profiles in UserProfileManager static class  
        }

        void AppExit(object sender, ExitEventArgs e)
        {
            if (DictionaryLoader.ActiveDictionary != null)
            {
                DictionaryLoader.ActiveDictionary.EndWork();
            }
            if (DictionaryLoader.DictionaryNames != null)
            {
                DictionaryLoader.DictionaryNames.Clear();
            }
            if (DictionaryLoader.metadata != null)
            {
                DictionaryLoader.metadata.Clear();
            }
            
            
        }
    }
}
