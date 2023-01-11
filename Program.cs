using System;
using System.Collections.Generic;

namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] squareMatrixElements = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] diagonalMatrixElements = { 1, 0, 0, 0, 1, 0, 0, 0, 3 };
            try
            {               
                Matrix<int> squareMatrix = new Matrix<int>(squareMatrixElements, 3);
                squareMatrix[1, 2] = 6; // set
                int a00 = squareMatrix[0, 0]; // вызывается get часть индексатора
                int a01 = squareMatrix[0, 1];               
                DiagonalMatrix<int> diagonalMatrix = new DiagonalMatrix<int>(diagonalMatrixElements, 3);
                Console.WriteLine(diagonalMatrix);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }    
        }
    }
}
