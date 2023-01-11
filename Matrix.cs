using System;
using System.Collections.Generic;

namespace Matrix
{
    internal class Matrix<T>
    {       
        public T[] MatrixArray { get; set; }
        int _size;
        /// <summary>
        /// Exceptions: Size is negative or equals 0, not allowed
        /// </summary>
        public int Size 
        { 
            get => _size;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Size is negative or equals 0, not allowed ");
                }
                else 
                {
                    _size = value;
                }
            }
        }      
        
        public Matrix(T[] matrixArray, int size) 
        {          
            MatrixArray = matrixArray;
            Size = size;
        }

        /// <summary>
        /// Exceptions: Indexes can not be negative
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public virtual int this[int i, int j] // индексатор обеспечивает доступ к элементу массива, т. о. что из 2х индексов получается 1 индекс
        {
            //get => MatrixArray[i * Size + j];
            get
            {
                var index = MatrixArray[i * Size + j];
                return index;
            }
            set 
            {
                if (i < 0 || j < 0)
                {
                    throw new Exception("Indexes can not be negative");
                }
                else 
                {
                    MatrixArray[i * Size + j] = value;
                }
            }           
        }
    }
}
