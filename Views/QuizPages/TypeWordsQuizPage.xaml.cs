
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

using LearnIT.Presenters;


namespace LearnIT.Views.QuizPages
{
    /// <summary>
    /// Interaction logic for TypeWordsQuizPage.xaml
    /// </summary>
    public partial class TypeWordsQuizPage : Page
    {
        private QuizProvider quiz;
        private int count;


        public TypeWordsQuizPage()
        {
            InitializeComponent();
        }

        public TypeWordsQuizPage(QuizProvider quizProvider)
        {
            InitializeComponent();
            quiz = quizProvider;
            quiz.FillWordLists();
            quiz.ShuffleWordLists();
            count = 0;
            word.Text = quiz.WordsList[count];
        }

        private void NextWord()
        {
            count++;
            textBoxAnswer.Text = "";
            if (count < quiz.WordsList.Count) word.Text = quiz.WordsList[count];
            else
            {
                quiz.FillWordLists();

                if (quiz.WordsList.Count == 0)
                {                   
                    word.Text = "Game over";
                    textBoxAnswer.IsEnabled = false;
                    CheckAnswerBtn.IsEnabled = false;
                }
                else
                {
                    count = 0;
                    word.Text = quiz.WordsList[count];
                }
            } 

        }



        private void CheckAnswerBtn_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxAnswer.Text != null)
            {
                bool b = quiz.ValidateWordPair(word.Text, textBoxAnswer.Text);
                if (b)
                {
                    resultTextBlock.Text = "Good!";
                    Color color = (Color)ColorConverter.ConvertFromString("#FFA9F32C");
                    resultTextBlock.Foreground = new SolidColorBrush(color);
                    
                }
                else
                {
                    resultTextBlock.Text = "Bad!";
                    Color color = (Color)ColorConverter.ConvertFromString("#FFFF0080");
                    resultTextBlock.Foreground = new SolidColorBrush(color);
                    
                }
                NextWord();
            }
        }

        private void BackToDictionariesListBtn_Click(object sender, RoutedEventArgs e)
        {
            UserDictionaries dictWnd = new UserDictionaries(DictionaryLoader.ActiveUser);
            NavigationService.Navigate(dictWnd);
        }

        private void QuizHelpBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("God will help you!");
        }
    }
}
