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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       // private string alpha = "abcdefghijklmnopqrstuvwxyz";
        private char[] newAlpha = new char[33];

        public string publicOldAlpha(TextBlock oldAlphabet, string alpha)
        {
            for (int i = 0; i < alpha.Length; i++)
            {
                oldAlphabet.Text += alpha[i] + " ";
            }
            return oldAlphabet.Text;
        }
        public string publicNewAlpha(TextBlock newAlphabet)
        {
            for (int i = 0; i < newAlpha.Length; i++)
            {
                newAlphabet.Text += newAlpha[i] + " ";
            }
            return newAlphabet.Text;
        }
        public string encrypt(string Message, string alpha)
        {
          string res = "";
          foreach (char ch in Message)
          {
            for (int i = 0; i < alpha.Length; i++)
              {
               if (ch == alpha[i])
               {
                res += newAlpha[i];
               break;
               }
            }
          }
         return res;
        }

       public string decrypt(string Message, string alpha)
        {
           string res = "";
           foreach (char ch in Message)
           {
                    for (int i = 0; i < newAlpha.Length; i++)
                    {
                        if (ch == newAlpha[i])
                        {
                            res += alpha[i];
                            break;
                        }
                    }
           }
        return res;
       }

        public void createNewAlpha(string keyWord, int key, string alpha) // создаёт новый алфавит с помощью ключа
        {
          bool findSame = false;
          key--;
          int beg = 0, current = key;
         // добавить ключевое слово в новый алфавит
          for (int i = key; i < keyWord.Length + key; i++)
            {
             for (int j = key; j < keyWord.Length + key; j++)
             {
               if (keyWord[i - key] == newAlpha[j])
               {
               findSame = true;
               break;
               }
             }

             if (!findSame)// если повторений нету, то буква добавляется в новый алфавит
            {
            newAlpha[current] = keyWord[i - key];
            current++;
            }
           findSame = false;
           }

                // добавить буквы после ключевого слова
                for (int i = 0; i < alpha.Length; i++)
                {
                    for (int j = 0; j < newAlpha.Length; j++)
                    {
                        if (alpha[i] == newAlpha[j])
                        {
                            findSame = true;
                            break;
                        }
                    }
                    if (!findSame)
                    {
                        newAlpha[current] = alpha[i];
                        current++;
                    }
                    findSame = false;
                    if (current == newAlpha.Length)
                    {
                        beg = i;
                        break;
                    }
                }

                // добавить буквы после ключевого слова
                current = 0;
                for (int i = beg; i < alpha.Length; i++)
                {
                    for (int j = 0; j < newAlpha.Length; j++)
                    {
                        if (alpha[i] == newAlpha[j])
                        {
                            findSame = true;
                            break;
                        }
                    }
                    if (!findSame)
                    {
                        newAlpha[current] = alpha[i];
                        current++;
                    }
                    findSame = false;
                }
            }




        public void Button_encrypted(object sender, RoutedEventArgs e)
        {
           
            /*            
                        string open = "", close = "";
                        Console.Write("Открытое сообщение: ");
                        open = Console.ReadLine().ToLower();
                        close = Caesar.encrypt(open);
                        Console.WriteLine();
                        Console.WriteLine("Шифрованное сообщение: " + close);
                        open = Caesar.decrypt(close);
                        Console.WriteLine();
                        Console.WriteLine("Расшифрованное сообщение: " + open);*/

            string keyWord = textKeyWord.Text.ToLower();
            int key = Convert.ToInt32(keyForNewAlfavet.Text);


            if(LanguagesEn.IsChecked == true)
            {
                string alpha = "abcdefghijklmnopqrstuvwxyz";
                createNewAlpha(keyWord, key, alpha);
                publicOldAlpha(oldAlphabet, alpha);
            }
            if (LanguagesRu.IsChecked == true)
            {
                string alpha = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
                createNewAlpha(keyWord, key, alpha);
                publicOldAlpha(oldAlphabet, alpha);
            }

            // createNewAlpha(keyWord, key, alpha);
            //publicOldAlpha(oldAlphabet);
            publicNewAlpha(newAlphabet);






        }

        private void Clean_Click(object sender, RoutedEventArgs e)
        {
            newAlphabet.Text = "";
            oldAlphabet.Text = "";
            textKeyWord.Text = "";
            keyForNewAlfavet.Text = "";
            encryptedWord.Text = "";

        }



        /*public void RadioButton_English_Checked(object sender, RoutedEventArgs e)
        {
            string alpha = "abcdefghijklmnopqrstuvwxyz";
        }

        private void RadioButton_Russian_Checked(object sender, RoutedEventArgs e)
        {
            string alpha = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        }*/
    }
}
