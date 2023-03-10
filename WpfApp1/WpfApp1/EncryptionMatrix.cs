using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
//using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp1
{
    class EncryptionMatrix
    {
        public int[,,] matrix1 = new int[33, 2, 2] {
            { { 3, 2 }, { 4, 3 } },
            { { 4, 3 }, { 2, 2 } },
            { {6, 3 }, { 3, 2 } },
            { { 2, 4 }, { 2, 6 } },
            { { 5, 5 }, { 2, 3 } },
            { { 4, 2 }, { 1, 2 } },
            { { 8, 1 }, { 1, 1 } },
            { { 3, 1 }, { 1, 3 } },
            { { 5, 1 }, { 1, 2 } },
            { { 5, 1 }, { 2, 2 } }, //10
            { { 5, 2 }, { 2, 3 } },
            { { 5, 1 }, { 3, 3 } },
            { { 4, 1 }, { 7, 5 } },
            { { 4, 1 }, { 2, 4 } },
            { { 4, 1 }, { 1, 4 } },//15
            { { 5, 2 }, { 2, 4 } },
            { { 5, 1 }, { 3, 4 } },
            { {5, 1 }, { 7, 5 } },
            { { 5, 2 }, { 3, 5 } },
            { { 5, 1 }, { 5, 5 } },//20
            { { 8, 1 }, { 3, 3 } },
            { { 7, 2 }, { 3, 4 } },
            { { 6, 1 }, { 7, 5 } },
            { { 6, 2 }, { 3, 5 } },
            { { 6, 1 }, { 5, 5 } },//25
            { { 6, 2 }, { 2, 5 } },
            { { 6, 1 }, { 3, 5 } },
            { { 6, 1 }, { 2, 5 } },
            { { 6, 1 }, { 1, 5 } },
            { { 8, 1 }, { 2, 4 } }, //30
            { { 7, 2 }, { 2, 5 } },
            { { 8, 2 }, { 4, 5 } },
            { { 6, 1 }, { 3, 6 } },//33

        };

        public int[,,] matrix2 = new int[33, 2, 2] {
             { { 6, 7 }, { 5, 6 } },
            { { 2, 2 }, { 1, 2 } },
            { {3, 3 }, { 2, 3 } },
            { { 3, 1 }, { 2, 2 } },
            { { 4, 5 }, { 3, 5 } },
            { { 3, 3 }, { 1, 3 } },
            { { 4, 1 }, { 1, 2 } },
            { { 9, 1 }, { 1, 1 } },
            { { 2, 1 }, { 9, 9 } },
            { { 5, 1 }, { 5, 3 } }, //10
            { { 5, 3 }, { 3, 4 } },
            { { 5, 2 }, { 4, 4 } },
            { { 5, 3 }, { 4, 5 } },
            { { 5, 2 }, { 3, 4 } },
            { { 5, 1 }, { 5, 4 } },//15
            { { 5, 3 }, { 3, 5 } },
            { { 5, 2 }, { 4, 5 } },
            { {5, 3 }, { 4, 6 } },
            { { 6, 1 }, { 5, 4 } },
            { { 6, 2 }, { 8, 6 } },//20
            { { 5, 2 }, { 2, 5 } },
            { { 5, 1 }, { 3, 5 } },
            { { 6, 1 }, { 1, 4 } },
            { { 5, 1 }, { 1, 5 } },
            { { 7, 2 }, { 5, 5 } },//25
            { { 7, 3 }, { 3, 5 } },
            { { 7, 1 }, { 1, 4 } },
            { { 6, 2 }, { 4, 6 } },
            { { 7, 2 }, { 3, 5 } },
            { { 7, 1 }, { 5, 5 } }, //30
            { { 8, 1 }, { 1, 4 } },
            { { 8, 4 }, { 2, 5 } },
            { { 7, 1 }, { 2, 5 } },//33
        };

        public int[,,] matrix3 = new int[33, 2, 2] {
             { { 2, 3 }, { 1, 2 } },
            { { 3, 2 }, { 2, 2 } },
            { {4, 1 }, { 5, 2 } },
            { { 4, 2 }, { 4, 4 } },
            { { 5, 5 }, { 4, 5 } },
            { { 2, 1 }, { 2, 4 } },
            { { 3, 1 }, { 2, 3 } },
            { { 4, 2 }, { 2, 3 } },
            { { 4, 9 }, { 3, 9 } },
            { { 5, 2 }, { 5, 4 } }, //10
            { { 4, 1 }, { 5, 4 } },
            { { 6, 2 }, { 3, 3 } },
            { { 6, 1 }, { 5, 3 } },
            { { 7, 1 }, { 7, 3 } },
            { { 5, 2 }, { 5, 5 } },//15
            { { 5, 2 }, { 7, 6 } },
            { { 6, 1 }, { 1, 3 } },
            { {5, 2 }, { 6, 6 } },
            { { 5, 1 }, { 1, 4 } },
            { { 8, 2 }, { 2, 3 } },//20
            { { 7, 1 }, { 7, 4 } },
            { { 6, 2 }, { 7, 6 } },
            { { 4, 1 }, { 5, 7 } },
            { { 7, 2 }, { 2, 4 } },
            { { 8, 1 }, { 7, 4 } },//25
            { { 8, 3 }, { 2, 4 } },
            { { 8, 1 }, { 5, 4 } },
            { { 5, 1 }, { 7, 7 } },
            { { 8, 1 }, { 3, 4 } },
            { { 6, 2 }, { 3, 6 } }, //30
            { { 9, 1 }, { 5, 4 } },
            { { 6, 2 }, { 2, 6 } },
            { { 4, 1 }, { 3, 9 } },//33
        };

        public int[,,] matrix4 = new int[33, 2, 2] {
             { { 4, 3 }, { 5, 4 } },
            { { 5, 2 }, { 4, 2 } },
            { {5, 1 }, { 7, 2 } },
            { { 5, 1 }, { 1, 1 } },
            { { 6, 1 }, { 7, 2 } },
            { { 6, 6 }, { 5, 6 } },
            { { 5, 1 }, { 3, 2 } },
            { { 5, 1 }, { 7, 3 } },
            { { 4, 1 }, { 3, 3 } },
            { { 6, 2 }, { 4, 3 } }, //10
            { { 3, 1 }, { 1, 4 } },
            { { 6, 4 }, { 3, 4 } },
            { { 5, 1 }, { 2, 3 } },
            { { 7, 3 }, { 7, 5 } },
            { { 5, 3 }, { 5, 6 } },//15
            { { 7, 1 }, { 5, 3 } },
            { { 8, 3 }, { 5, 4 } },
            { {4, 1 }, { 2, 5 } },
            { { 4, 3 }, { 3, 7 } },
            { { 7, 1 }, { 1, 3 } },//20 ----
            { { 6, 3 }, { 5, 6 } },
            { { 6, 2 }, { 4, 5 } },
            { { 8, 1 }, { 1, 3 } },
            { { 4, 2 }, { 2, 7 } },
            { { 4, 1 }, { 3, 7 } },//25
            { { 4, 1 }, { 2, 7 } },
            { { 4, 3 }, { 3, 9 } },
            { { 8, 3 }, { 4, 5 } },
            { { 9, 1 }, { 7, 4 } },
            { { 5, 2 }, { 5, 8 } }, //30
            { { 8, 3 }, { 3, 5 } },
            { { 7, 1 }, { 3, 5 } },
            { { 5, 1 }, { 7, 8 } },//33
        };

        public int[,,] matrix5 = new int[33, 2, 2] {
             { { 5, 3 }, { 8, 5 } },
            { { 6, 2 }, { 5, 2 } },
            { {7, 2 }, { 2, 1 } },
            { { 6, 1 }, { 2, 1 } },
            { { 6, 5 }, { 5, 5 } },
            { { 7, 1 }, { 1, 1 } },
            { { 6, 1 }, { 5, 2 } },
            { { 6, 2 }, { 2, 2 } },
            { { 5, 2 }, { 3, 3 } },
            { { 4, 1 }, { 2, 3 } }, //10
            { { 6, 1 }, { 1, 2 } },
            { { 4, 5 }, { 4, 8 } },
            { { 4, 1 }, { 3, 4 } },
            { { 7, 4 }, { 7, 6 } },
            { { 7, 2 }, { 3, 3 } },//15
            { { 6, 1 }, { 2, 3 } },
            { { 9, 1 }, { 1, 2 } },
            { {7, 2 }, { 5, 4 } },
            { { 8, 1 }, { 5, 3 } },
            { { 9, 1 }, { 7, 3 } },//20 ----
            { { 5, 3 }, { 3, 6 } },
            { { 6, 4 }, { 2, 5 } },
            { { 9, 2 }, { 2, 3 } },
            { { 8, 2 }, { 4, 4 } },
            { { 9, 1 }, { 2, 3 } },//25
            { { 5, 3 }, { 3, 7 } },
            { { 5, 2 }, { 4, 7 } },
            { { 9, 2 }, { 4, 4 } },
            { { 6, 1 }, { 7, 6 } },
            { { 5, 5 }, { 2, 8 } }, //30
            { { 6, 1 }, { 5, 6 } },
            { { 4, 2 }, { 2, 9 } },
            { { 7, 3 }, { 3, 6 } },//33
        };


        public void printMatrix(TextBlock textblock, int[,,] matrix)
        {
            int flag = 0;//счетчик

            for (int i = 0; i < 32; i++)
            {


                for (int k = 0; k < 2; k++)
                {
                    textblock.Text += matrix[i, 0, k] + " ";
                    flag++;
                    if (flag == 2)
                    {
                        textblock.Text += "  ";//расстоянние между матрица (1 строка)
                        flag = 0;
                    }



                }
                // textblock.Text += "\n";
            }
            textblock.Text += "\n";

            for (int i = 0; i < 32; i++)
            {
                for (int j = 0; j < 1; j++)
                {

                    for (int k = 0; k < 2; k++)
                    {
                        textblock.Text += matrix[i, 1, k] + " ";
                        flag++;
                        if (flag == 2)
                        {
                            textblock.Text += "  ";//расстоянние между матрица (2 строка)
                            flag = 0;
                        }

                    }

                }
                // textblock.Text += "\n";
            }


        }


        public void Numeric(TextBlock textblock, TextBlock textblock2, TextBlock textblock3)
        {
            for (int i = 1; i <= 9; i++)
            {
                textblock.Text += i + "     ";
            }
            for (int i = 10; i <= 16; i++)
            {
                textblock2.Text += i + "   ";
            }
            for (int i = 17; i <= 33; i++)
            {
                textblock3.Text += i + "   ";
            }
        }


        public void SelectedMatrix(TextBox key, TextBlock conclusionMod, TextBlock wordEncriptMatrix, string numRes)//ключ поле с выводом модуля и поле с выводом зашифрованного сообщения
        {
            int newKey = Convert.ToInt32(key.Text);
            int numberMatrix = newKey % 5 + 1;
            conclusionMod.Text += "Находим выбранный массив матриц по формуле Key % 5 + 1, где key - ключ \n";
            conclusionMod.Text += newKey + " % 5 + 1 = " + numberMatrix + "\n";
            conclusionMod.Text += "Выбранный массив матриц под номером - " + numberMatrix + "\n";


            int[,,] matrix;

            switch (numberMatrix)
            {
                case 1:
                    matrix = matrix1; EncryptWordMatrix(wordEncriptMatrix, matrix1, numRes); break;
                case 2:
                    matrix = matrix2; EncryptWordMatrix(wordEncriptMatrix, matrix2, numRes); break;
                case 3:
                    matrix = matrix3; EncryptWordMatrix(wordEncriptMatrix, matrix3, numRes); break;

                case 4:
                    matrix = matrix4; EncryptWordMatrix(wordEncriptMatrix, matrix4, numRes); break;
                case 5:
                    matrix = matrix5; EncryptWordMatrix(wordEncriptMatrix, matrix5, numRes); break;


            }

        }


        public void EncryptWordMatrix(TextBlock encryptwordMatrix, int[,,] matrix, string numRes)
        {
            int flag = 0;//счетчик

            string[] numbersString = numRes.Split(' ');



            foreach (string number in numbersString)
            {
                if (number != "")
                {
                    //  MessageBox.Show(Convert.ToInt32(number) + "");
                    int first = Convert.ToInt32(number) - 1;


                    for (int k = 0; k < 2; k++)
                    {

                        encryptwordMatrix.Text += matrix[first, 0, k] + " ";
                        flag++;
                        if (flag == 2)
                        {
                            encryptwordMatrix.Text += "  ";//расстоянние между матрица (1 строка)
                            flag = 0;
                        }



                    }
                }




            }
            encryptwordMatrix.Text += "\n";


            foreach (string number2 in numbersString)
            {
                if (number2 != "")
                {
                    int second = Convert.ToInt32(number2) - 1;
                    for (int j = 0; j < 1; j++)
                    {

                        for (int k = 0; k < 2; k++)
                        {
                            encryptwordMatrix.Text += matrix[second, 1, k] + " ";
                            flag++;
                            if (flag == 2)
                            {
                                encryptwordMatrix.Text += "  ";//расстоянние между матрица (2 строка)
                                flag = 0;
                            }

                        }

                    }
                }
            }




        }


        //страница с выбранной матрицей
        public void SelectedIndexMatrix(TextBox key, string numRes, TextBlock MatrixChoice, TextBlock choiceIndex, TextBlock nameMatrix, TextBlock rowIndex)
        {

            int newKey = Convert.ToInt32(key.Text);
            int numberMatrix = newKey % 5 + 1;
            nameMatrix.Text = "Выбранный массив матриц под номером " + numberMatrix;
            rowIndex.Text = "Индексы зашифрованного сообщения \n" + numRes;


            switch (numberMatrix)
            {
                case 1:
                    printMatrix(MatrixChoice, matrix1); IndexMatrix(choiceIndex, matrix1, numRes); MatrixChoice.Background = Brushes.Bisque; break;
                case 2:
                    printMatrix(MatrixChoice, matrix2); IndexMatrix(choiceIndex, matrix2, numRes); MatrixChoice.Background = Brushes.PaleGreen; break;
                case 3:
                    printMatrix(MatrixChoice, matrix3); IndexMatrix(choiceIndex, matrix3, numRes); MatrixChoice.Background = Brushes.Thistle; break;
                case 4:
                    printMatrix(MatrixChoice, matrix4); IndexMatrix(choiceIndex, matrix4, numRes); MatrixChoice.Background = Brushes.LightBlue; break;
                case 5:
                    printMatrix(MatrixChoice, matrix5); IndexMatrix(choiceIndex, matrix5, numRes); MatrixChoice.Background = Brushes.Pink; break;

            }

        }





        //
        public void IndexMatrix(TextBlock choiceIndex, int[,,] matrix, string numRes)
        {
            int flag = 0;//счетчик

            string[] numbersString = numRes.Split(' ');



            foreach (string number in numbersString)
            {
                if (number != "")
                {
                    //  MessageBox.Show(Convert.ToInt32(number) + "");
                    int first = Convert.ToInt32(number) - 1;
                    choiceIndex.Text += (first+1) + " шифруется следующей матрицей: " + "\n";

                    for (int k = 0; k < 2; k++)
                    {

                        choiceIndex.Text += matrix[first, 0, k] + " ";
                        flag++;
                        if (flag == 2)
                        {
                            choiceIndex.Text += "  ";//расстоянние между матрица (1 строка)
                            flag = 0;
                        }



                    }
                    choiceIndex.Text += "\n";
                    for (int j = 0; j < 1; j++)
                    {

                        for (int k = 0; k < 2; k++)
                        {
                            choiceIndex.Text += matrix[first, 1, k] + " ";
                            flag++;
                            if (flag == 2)
                            {
                                choiceIndex.Text += "  ";//расстоянние между матрица (2 строка)
                                flag = 0;
                            }

                        }

                    }
                }
                choiceIndex.Text += "\n";
                choiceIndex.Text += "\n";


            }





        }

        //страница декодирования
        public int[,,] matrixIndex;
        public int[] mas;
        public void matrixEncryptWord(TextBlock matrixEncrypt, int[,,] matrix, string numRes)
        {

            // 6  12 10 5

            string[] numbersString = numRes.Split(' ');
            mas = new int[numbersString.Length];

            for (int j = 0; j < numbersString.Length; j++)
            {
                if (numbersString[j] != "")
                {
                   int first = Convert.ToInt32(numbersString[j]) - 1;

                    mas[j] = first;
                }
            }



                matrixIndex = new int[numbersString.Length - 1, 2, 2];

            for (int l = 0; l < numbersString.Length -1 ; l++)
            { 
                  for (int i = 0; i < 2; i++)
                  {
                       for (int k = 0; k < 2; k++)
                        {
                                matrixIndex[l, i, k] = matrix[mas[l], i, k];
                        }


                  }
                  

                
            }


        }

       


        public void printMatrixWord(TextBlock textblock, int[,,] matrix)
        {
            int flag = 0;//счетчик

            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int k = 0; k < 2; k++)
                {
                    textblock.Text += matrix[i, 0, k] + " ";
                    flag++;
                    if (flag == 2)
                    {
                        textblock.Text += "  ";//расстоянние между матрица (1 строка)
                        flag = 0;
                    }



                }
                // textblock.Text += "\n";
            }
            textblock.Text += "\n";

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < 1; j++)
                {

                    for (int k = 0; k < 2; k++)
                    {
                        textblock.Text += matrix[i, 1, k] + " ";
                        flag++;
                        if (flag == 2)
                        {
                            textblock.Text += "  ";//расстоянние между матрица (2 строка)
                            flag = 0;
                        }

                    }

                }
                // textblock.Text += "\n";
            }



        }

        public int[] mas1;
        public void DeterminateMatrix(TextBlock textblock1, int[,,] matrixIndex, TextBlock textblock2)
        {
             mas1 = new int[matrixIndex.GetLength(0)];
            for (int l = 0; l < matrixIndex.GetLength(0); l++)
            {
                        
                        int index = matrixIndex[l, 0, 0] * matrixIndex[l, 1, 1] - matrixIndex[l, 0, 1] * matrixIndex[l, 1, 0];
                        textblock1.Text += matrixIndex[l, 0, 0] + " * " + matrixIndex[l, 1, 1] + " - " + matrixIndex[l, 0, 1] + " * " + matrixIndex[l, 1, 0] + " = " + index + "\n";
                         mas1[l] = index - 1;
                        textblock2.Text += index + " ";
            }
        }







    }
}
    
