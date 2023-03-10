using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Decoding.xaml
    /// </summary>
    public partial class Decoding : Window
    {
        public void LettersAlphabetByIndex(string alpha, TextBlock enterBlock, int[] mas)
        {
            for (int l = 0; l < mas.Length; l++)
            {
                for (int i = 0; i < alpha.Length; i++)
                {
                
                    if (i == mas[l])
                    {
                        enterBlock.Text += alpha[i];
                    }
                }
                    
            }
        }
        public Decoding()
        {
            InitializeComponent();
        }
    }
}
