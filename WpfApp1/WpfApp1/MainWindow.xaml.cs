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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private static string alpha = "abcdefghijklmnopqrstuvwxyz";
        // private static char[] newAlpha = new char[26];
        private static char[] newAlpha = new char[26];

        public static string publicOldAlpha(TextBlock oldAlphabet)
        {
             for (int i = 0; i < alpha.Length; i++)
             {
              oldAlphabet.Text += alpha[i] + " ";
             }
            return oldAlphabet.Text;
        }
        public static string publicNewAlpha(TextBlock newAlphabet)
        {
            for (int i = 0; i < newAlpha.Length; i++)
            {
                newAlphabet.Text += alpha[i] + " ";
            }
            return newAlphabet.Text;
        }
        public static string encrypt(string Message)
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

       public static string decrypt(string Message)
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

        public static void createNewAlpha(string keyWord, int key) // создаёт новый алфавит с помощью ключа
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

       /*public static string getNewAlpha()
        {
       string strNewAlpha = new string(newAlpha);
        return strNewAlpha;
        }*/
        


        public void Button_encrypted(object sender, RoutedEventArgs e)
        {
            /*            
                        Console.WriteLine("Шифрованный алфавит: " + Caesar.getNewAlpha());
                        Console.WriteLine();

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
            createNewAlpha(keyWord, key);
            publicOldAlpha(oldAlphabet);
            publicNewAlpha(newAlphabet);






        }
    }
}
