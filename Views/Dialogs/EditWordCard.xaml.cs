using LearnIT.Models;
using LearnIT.Presenters;
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

using System.Runtime.Serialization.Formatters.Binary; // for deep clone
using System.IO;

namespace LearnIT.Views.Dialogs
{
    /// <summary>
    /// Interaction logic for EditWordCard.xaml
    /// </summary>
    public partial class EditWordCard : Window
    {
        WordCard wordCard;
        WordCard oldWordCard;
        
        private int index;
        public EditWordCard()
        {
            InitializeComponent();
            wordCard = new WordCard();            
            editWordCardGrid.DataContext = wordCard;
        }      

        public EditWordCard(WordCard wc, int index)
        {
            InitializeComponent();

            wordCard = DeepClone(wc);
            oldWordCard = wc;
            editWordCardGrid.DataContext = wordCard;
            this.index = index;
        }

        private void SaveWordCardBtn_Click(object sender, RoutedEventArgs e)
        {
            if (oldWordCard == null) AddNewWordCard();
            else
            {                
                if (oldWordCard.GetHashCode() != wordCard.GetHashCode())
                {
                    DictionaryLoader.ActiveDictionary.Dictionary.RemoveAt(index);
                    DictionaryLoader.ActiveDictionary.Dictionary.Insert(index, wordCard);
                    DictionaryLoader.ActiveDictionary.UpdateDictionaryXml();
                }
            }
          
            this.Close();
        }

        private void AddNewWordCard()
        {
            DictionaryLoader.ActiveDictionary.Dictionary.Add(wordCard);
            DictionaryLoader.ActiveDictionary.UpdateDictionaryXml();
        }

        private void CancelEditingWordCardBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public static T DeepClone<T>(T obj)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Position = 0;

                return (T)formatter.Deserialize(ms);
            }
        }
    }
}
