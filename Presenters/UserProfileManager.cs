using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnIT.Presenters
{
    class UserProfileManager
    {
        private static List<string> usersList = new List<string>();

        public static List<string> UsersList
        {
            get
            {
                return usersList;
            }
        }       

        public static void Initialize()
        {
            DirectoryInfo dataDir = new DirectoryInfo("data");
            if (!dataDir.Exists) // check if program data doesn't exist
            {
                DirectoryInfo dictionariesDir = dataDir.CreateSubdirectory("users");
            }
            else
            {
                DirectoryInfo[] userDirectories = new DirectoryInfo(@"data\users").GetDirectories();
                IEnumerable<string> userNames = (IEnumerable<string>)from userFolder in userDirectories select userFolder.Name.ToString();
                usersList = userNames.ToList();
            }
        }     

        public static bool DeleteUserProfile(string userName)
        {
            if (usersList.Remove(userName)) // if such user name exists
            {
                string path = @"data\users\" + userName;
                DirectoryInfo userDirectory = new DirectoryInfo(path);
                userDirectory.Delete(true);
                return true;
            }
            else return false;
        }

        public static bool AddUser(string userName)
        {
            if (!usersList.Contains(userName))
            {
                usersList.Add(userName);
                string path = @"";
                char disrectorySeparator = Path.DirectorySeparatorChar;
                path = @"data" + disrectorySeparator + @"users" + disrectorySeparator + userName;
                try
                {
                    DirectoryInfo userDirectory = new DirectoryInfo(path);
                    userDirectory.Create();
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);                    
                }
                
                return true;
            }
            else return false;
        }

        public static void UpdateUsersList()
        {
            Initialize();
        }
    }
}
