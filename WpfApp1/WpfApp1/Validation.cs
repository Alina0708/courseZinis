using System;
using System.Collections.Generic;
using System.Text;
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

        public void OnlyNumbers()
        {

        }

        public void OnlyLettersRu()
        {

        }

        public void OnleLettersEn()
        {

        }

        

        

    }
}
