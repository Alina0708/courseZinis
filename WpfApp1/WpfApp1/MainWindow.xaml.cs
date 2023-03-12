using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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


        EncryptionMatrix EncryptionMatrix = new EncryptionMatrix();
        NumericEnAndRu NumericEnAndRu = new NumericEnAndRu();
        Validation Validation = new Validation();

        private char[] newAlpha = new char[33];

        public string PublicOldAlpha(TextBlock oldAlphabet, string alpha)
        {
            for (int i = 0; i < alpha.Length; i++)
            {
                oldAlphabet.Text += alpha[i] + "  ";
            }
            return oldAlphabet.Text;
        }
        public string PublicNewAlpha(TextBlock newAlphabet)
        {
            for (int i = 0; i < newAlpha.Length; i++)
            {
                newAlphabet.Text += newAlpha[i] + "  ";
            }
            return newAlphabet.Text;
        }

        public string numRes = "";
        public string res = "";
        public string Encrypt(string Message, string alpha, TextBlock textBlock)
        {

            
          foreach (char ch in Message)
          {
            for (int i = 0; i < alpha.Length; i++)
              {
               if (ch == alpha[i])
               {
                res += newAlpha[i];
                textBlock.Text = res;
               break;
               }
            }
          }
            return res;
        }

        public string IndexEncryptWordCaesar(string res, string alpha, TextBlock textBlock1)
        {
            foreach (char l in res)
            {
                for (int k = 0; k < alpha.Length; k++)
                {
                    if (l == alpha[k])
                    {
                        numRes += k + 1 + " ";
                        textBlock1.Text = numRes;
                        break;
                    }

                }

            }
            return textBlock1.Text;
        }


      
        public void CreateNewAlpha(string keyWord, int key, string alpha) // создаёт новый алфавит с помощью ключа
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

        public void IndexBiNewAplhabet(TextBlock word, TextBlock conclusion, TextBlock end, string alpha, TextBlock wordEnd)
        {
            string decryptedWord = word.Text;
            foreach (char word1 in decryptedWord)
            {

                    for (int i = 0; i < newAlpha.Length; i++)
                    {
               
                       if (word1 == newAlpha[i])
                       {
                        conclusion.Text += i + 1 + " ";
                        end.Text +=  i + 1 + " - " + alpha[i] + "\n";
                        wordEnd.Text += alpha[i];
                       }
                    }

            }

        }

       

        public string Numbering(TextBlock field1, TextBlock field2)
        {
            for (int i = 1; i <= 9; i++)
            {
                field1.Text += i + "    ";
                field2.Text = field1.Text;
            }
            return field1.Text;
        }
        public string Numbering10(TextBlock field1, TextBlock field2, string numberingAlpha)
        {
            for (int i = 10; i < numberingAlpha.Length + 1; i++)
            {
                field1.Text += i + "  ";
                field2.Text = field1.Text;
            }
            return field1.Text;
        }
        public string Numbering10Ru(TextBlock field1, TextBlock field2)
        {
            for (int i = 10; i < 24 ; i++)
            {
                field1.Text += i + "  ";
                field2.Text = field1.Text;
            }
            return field1.Text;
        }
        public string NumberingRu( TextBlock field3, TextBlock field4, string numberingAlpha)
        {
          
            for (int i = 24; i < numberingAlpha.Length + 1; i++)
            {
                field3.Text += i + "   ";
                field4.Text = field3.Text;
            }
            

            return field3.Text;
        }


        public void Button_encrypted(object sender, RoutedEventArgs e)
        {
            if (encryptedWord.Text != "" && textKeyWord.Text != "" && keyForNewAlfavet.Text != "")
            {
             #region

                string keyWord = textKeyWord.Text.ToLower();
                string encryptWord = encryptedWord.Text.ToLower();
                int key = Convert.ToInt32(keyForNewAlfavet.Text);
               

                if (LanguagesEn.IsChecked == true)
                {
                    //CleanPage();
                    newAlpha = new char[26];
                    string alpha = "abcdefghijklmnopqrstuvwxyz";
                    CreateNewAlpha(keyWord, key, alpha);
                    PublicOldAlpha(oldAlphabet, alpha);
                    Numbering(numbering, numberingForNew);
                    Numbering10(numbering2, numberingForNew2, alpha);
                    Encrypt(encryptWord, alpha, test);
                    IndexEncryptWordCaesar(res, alpha, wordEncriptZezar);
                }
                if (LanguagesRu.IsChecked == true)
                {

                    //CleanPage();
                    newAlpha = new char[33];
                    string alpha = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
                    CreateNewAlpha(keyWord, key, alpha);
                    PublicOldAlpha(oldAlphabet, alpha);
                    Numbering(numbering, numberingForNew);
                    Numbering10Ru(numberingForRu, numberingForNew2Ru);
                    NumberingRu(numberingForNew3Ru, numberingForRu3, alpha);
                    Encrypt(encryptWord, alpha, test);
                    IndexEncryptWordCaesar(res, alpha, wordEncriptZezar);
                }

                PublicNewAlpha(newAlphabet);


                EncryptionMatrix.SelectedMatrix(keyForNewAlfavet, wordEncriptIndex, wordEncriptMatrix, numRes);
            

            #endregion
            }
            else
            {
                Button buttonEncrypt = new Button();
                buttonEncrypt.IsEnabled = false;
            }
            
        }

        private void Clean_Click(object sender, RoutedEventArgs e)
        {
            CleanPage();
        }

        public void CleanPage()
        {
            numRes = "";
            res = "";
            if (LanguagesEn.IsChecked == true)
            {
                newAlpha = new char[26];
            }
            if (LanguagesRu.IsChecked == true)
            {
                newAlpha = new char[33];
            }



            newAlphabet.Text = "";
            oldAlphabet.Text = "";
            textKeyWord.Text = "";
            keyForNewAlfavet.Text = "";
            encryptedWord.Text = "";
            numbering.Text = "";
            numbering2.Text = "";
            numberingForNew.Text = "";
            numberingForNew2.Text = "";
            numberingForRu.Text = "";
            numberingForNew2Ru.Text = "";
            numberingForNew3Ru.Text = "";
            numberingForRu3.Text = "";
            wordEncriptIndex.Text = "";
            wordEncriptZezar.Text = "";
            wordEncriptMatrix.Text = "";
            test.Text = "";



        }

        private void PageMatrixEncryption(object sender, RoutedEventArgs e)
        {
            MatrixEncryption MatrixEncryption = new MatrixEncryption();
            MatrixEncryption.Show();
            EncryptionMatrix.PrintMatrix(MatrixEncryption.TextBlockMatrix1, EncryptionMatrix.matrix1);
            EncryptionMatrix.PrintMatrix(MatrixEncryption.TextBlockMatrix2, EncryptionMatrix.matrix2);
            EncryptionMatrix.PrintMatrix(MatrixEncryption.TextBlockMatrix3, EncryptionMatrix.matrix3);
            EncryptionMatrix.PrintMatrix(MatrixEncryption.TextBlockMatrix4, EncryptionMatrix.matrix4);
            EncryptionMatrix.PrintMatrix(MatrixEncryption.TextBlockMatrix5, EncryptionMatrix.matrix5);


            EncryptionMatrix.Numeric(MatrixEncryption.numericMatrix9, MatrixEncryption.numericMatrix16, MatrixEncryption.numericMatrix33);
            EncryptionMatrix.Numeric(MatrixEncryption.numericMatrix9_2, MatrixEncryption.numericMatrix16_2, MatrixEncryption.numericMatrix33_2);
            EncryptionMatrix.Numeric(MatrixEncryption.numericMatrix9_3, MatrixEncryption.numericMatrix16_3, MatrixEncryption.numericMatrix33_3);
            EncryptionMatrix.Numeric(MatrixEncryption.numericMatrix9_4, MatrixEncryption.numericMatrix16_4, MatrixEncryption.numericMatrix33_4);
            EncryptionMatrix.Numeric(MatrixEncryption.numericMatrix9_5, MatrixEncryption.numericMatrix16_5, MatrixEncryption.numericMatrix33_5);

        }

        private void PageChoiceMatrix(object sender, RoutedEventArgs e)
        {

            ChoiceMatrix ChoiceMatrix = new ChoiceMatrix();
            ChoiceMatrix.Show();
            EncryptionMatrix.SelectedIndexMatrix(keyForNewAlfavet, numRes, ChoiceMatrix.MatrixChoice, ChoiceMatrix.choiceIndex, ChoiceMatrix.nameMatrix, ChoiceMatrix.rowIndex);
            EncryptionMatrix.Numeric(ChoiceMatrix.numericMatrix9, ChoiceMatrix.numericMatrix16, ChoiceMatrix.numericMatrix33);
        }

        private void PageDecrypted(object sender, RoutedEventArgs e)
        {
            Decoding Decoding = new Decoding();
            Decoding.Show();

            string keyWord = textKeyWord.Text.ToLower();
            int key = Convert.ToInt32(keyForNewAlfavet.Text);

            int newKey = Convert.ToInt32(keyForNewAlfavet.Text);
            int numberMatrix = newKey % 5 + 1;
            switch (numberMatrix)
            {
                case 1:
                    EncryptionMatrix.MatrixEncryptWord( EncryptionMatrix.matrix1, numRes); break;
                case 2:
                    EncryptionMatrix.MatrixEncryptWord( EncryptionMatrix.matrix2, numRes); break;
                case 3:
                    EncryptionMatrix.MatrixEncryptWord( EncryptionMatrix.matrix3, numRes); break;
                case 4:
                    EncryptionMatrix.MatrixEncryptWord( EncryptionMatrix.matrix4, numRes); break;
                case 5:
                    EncryptionMatrix.MatrixEncryptWord( EncryptionMatrix.matrix4, numRes); break;

            }
           
            EncryptionMatrix.PrintMatrixWord(Decoding.indexmatrixword, EncryptionMatrix.matrixIndex);
            EncryptionMatrix.DeterminateMatrix(Decoding.determinant, EncryptionMatrix.matrixIndex, Decoding.indexBlock);
            if (LanguagesEn.IsChecked == true)
            {
                newAlpha = new char[26];
                string alpha = "abcdefghijklmnopqrstuvwxyz";
                CreateNewAlpha(keyWord, key, alpha);
                Decoding.LettersAlphabetByIndex(alpha, Decoding.decryptWordCaesar, EncryptionMatrix.mas1);
                PublicOldAlpha(Decoding.oldAlphabet, alpha);
                NumericEnAndRu.NumericRu(Decoding.numbering);
                NumericEnAndRu.NumericEn(Decoding.numberingForRu);
                PublicNewAlpha(Decoding.NewAlphabet);

                NumericEnAndRu.NumericRu(Decoding.NewNumbering);
                NumericEnAndRu.NumericEn(Decoding.NewNumberingForRu);
                IndexBiNewAplhabet(Decoding.decryptWordCaesar, Decoding.indexByNewAlphabet, Decoding.word, alpha, Decoding.wordEnd);
               


            }
            if (LanguagesRu.IsChecked == true)
            {
                newAlpha = new char[33];
                string alpha = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
                CreateNewAlpha(keyWord, key, alpha);
                Decoding.LettersAlphabetByIndex(alpha, Decoding.decryptWordCaesar, EncryptionMatrix.mas1);
                PublicOldAlpha(Decoding.oldAlphabet, alpha);
                NumericEnAndRu.NumericRu(Decoding.numbering);
                NumericEnAndRu.NumericRu24(Decoding.numberingForRu_Copy);
                NumericEnAndRu.NumericRu33(Decoding.numberingForRu3);
                PublicNewAlpha(Decoding.NewAlphabet);

                NumericEnAndRu.NumericRu(Decoding.NewNumbering);
                NumericEnAndRu.NumericRu24(Decoding.NewNumberingForRu_Copy);
                NumericEnAndRu.NumericRu33(Decoding.NewNumberingForRu3);
                IndexBiNewAplhabet(Decoding.decryptWordCaesar, Decoding.indexByNewAlphabet, Decoding.word, alpha, Decoding.wordEnd);
              

            }

        }

        private void EncryptedWord_TextChanged(object sender, TextChangedEventArgs e)
        {
          
            Validation.NotEmptyField(encryptedWord);
           
        }
        private void EncryptedWord_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(encryptedWord.Text))
            {
                toolTip1.Content = "Заполните поле";
            }
        }

        private void TextKeyWord_TextChanged(object sender, TextChangedEventArgs e)
        {
           
            Validation.NotEmptyField(textKeyWord);
           
        }
        private void TextKeyWord_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(encryptedWord.Text))
            {
                toolTip2.Content = "Заполните поле";
            }
        }

        private void KeyForNewAlfavet_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            Validation.NotEmptyField(keyForNewAlfavet);
            Validation.OnlyNumbers(keyForNewAlfavet);
        }
        private void KeyForNewAlfavet_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(encryptedWord.Text))
            {
                toolTip3.Content = "Заполните поле";
            }
        }
    }
}
