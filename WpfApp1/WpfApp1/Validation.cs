using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp1
{
    class Validation
    {

        public void EmptyField(TextBox textbox)
        {
            if(string.IsNullOrEmpty(textbox.Text))
            {
             
                MessageBox.Show("Заполните поле", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                textbox.Background = Brushes.Red;
            }
        }

        public void NotEmptyField(TextBox textbox)
        {
                
                textbox.Background = Brushes.White;
          
        }

        public void OnlyNumbers(TextBox keyForNewAlfavet)
        {
            string input = keyForNewAlfavet.Text;
            if (!Regex.IsMatch(input, "^[0-9]*$"))
            {
                keyForNewAlfavet.Text = Regex.Replace(input, "[^0-9]", "");
                keyForNewAlfavet.CaretIndex = keyForNewAlfavet.Text.Length;
            }
        }

        public void OnlyLettersRu(TextBox LetterTextBox)
        {
            string input = LetterTextBox.Text;
            if (!Regex.IsMatch(input, "^[а-яА-Я]*$"))
            {
                LetterTextBox.Text = Regex.Replace(input, "[^а-яА-Я]", "");
                LetterTextBox.CaretIndex = LetterTextBox.Text.Length;
            }
        }

        public void OnleLettersEn(TextBox LetterTextBox)
        {
            string input = LetterTextBox.Text;
            if (!Regex.IsMatch(input, "^[a-zA-Z]*$"))
            {
                LetterTextBox.Text = Regex.Replace(input, "[^a-zA-Z]", "");
                LetterTextBox.CaretIndex = LetterTextBox.Text.Length;
            }
        }

        

        

    }
}
