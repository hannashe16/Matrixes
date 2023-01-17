using System;
using System.Collections.Generic;

namespace Matrix
{
    internal class Program
    {       
        //static List<int> ListByCondition(int[] array, Func<int, bool> condition)
        //{
        //    List<int> outputList = new List<int>();
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (condition(array[i]))
        //        {
        //            outputList.Add(array[i]);
        //        }
        //    }
        //    return outputList;
        //}
   
        static void Main(string[] args)
        {
            int[] squareMatrixElements = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] diagonalMatrixElements = { 1, 0, 0, 0, 1, 0, 0, 0, 3 };

            int[] squareMatrixElements1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            try
            {
                SquareMatrix<int> squareMatrix1 = new SquareMatrix<int>(2);
                SquareMatrix<int> squareMatrix = new SquareMatrix<int>(squareMatrixElements, 3);

                squareMatrix1.Changed += DisplayMessageIfValueIsChanged; // вызываем обработчик события DisplayMessageIfValueIsChanged в событии Changed

                squareMatrix1[0, 0] = 133; // вызывается set часть индексатора
                squareMatrix1.Changed -= delegate (int oldValue, int newValue, int i, int j) // удаление регистрации события анонимным методом
                {
                    if (oldValue != newValue)
                    {
                        Console.WriteLine("Value was changed");
                    }
                };
                squareMatrix1[0, 1] = 2;
                squareMatrix1[1, 0] = 333; 
                squareMatrix1.Changed += (oldValue, newValue, i, j) =>  // применяем лямбда выражение для определения обработчика события
                {
                    if (oldValue != newValue)
                    {
                        Console.WriteLine("Value was changed");
                    }
                };
                squareMatrix1[1, 1] = 4;
                Console.WriteLine(squareMatrix1);
                int a00 = squareMatrix[0, 0]; // вызывается get часть индексатора
                int a01 = squareMatrix[0, 1];

                DiagonalMatrix<int> diagonalMatrix1 = new DiagonalMatrix<int>(2);
                DiagonalMatrix<int> diagonalMatrix = new DiagonalMatrix<int>(diagonalMatrixElements, 3);

                diagonalMatrix1[0, 0] = 11; //set               
                diagonalMatrix1[0, 1] = 111111111;
                diagonalMatrix1[1, 0] = 222222222;
                diagonalMatrix1[1, 1] = 12;
                Console.WriteLine(diagonalMatrix1);
                int b00 = diagonalMatrix1[0, 0]; //get
                int b01 = diagonalMatrix1[0, 1];
                int b10 = diagonalMatrix1[1, 0];
                int b11 = diagonalMatrix1[1, 1];
                Console.WriteLine(diagonalMatrix1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //List<int> resultList = new List<int>();
            //resultList = ListByCondition(squareMatrixElements1, data => data > 4);
        }

        public static void DisplayMessageIfValueIsChanged(int oldValue, int newValue, int i, int j) //обработчик события
        {
            if (oldValue != newValue)
            {
                Console.WriteLine("Value was changed"); 
            }           
        }
    }
}
