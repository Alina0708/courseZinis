using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace WpfApp1
{
    class NumericEnAndRu
    {
        public void NumericRu(TextBlock enterTextblock)
        {
            for(int i = 1; i < 9; i++)
            {
                enterTextblock.Text += i + "    ";
            }
        }
        public void NumericEn(TextBlock enterTextblock)
        {
            for (int i = 9; i <= 26; i++)
            {
                enterTextblock.Text += i + " ";
            }
        }
        public void NumericRu24(TextBlock enterTextblock)
        {
            for (int i =9; i <= 18; i++)
            {
                enterTextblock.Text += i + "  ";
            }
        }
        public void NumericRu33(TextBlock enterTextblock)
        {
            for (int i = 19; i <= 33; i++)
            {
                enterTextblock.Text += i + "  ";
            }
        }
    }
}
