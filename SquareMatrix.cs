using System;

namespace Matrix
{

    internal class SquareMatrix<T>
    {
        public delegate void ChangedHandler(T oldValue, T newValue, int i, int j);
        public event ChangedHandler Changed; // ивент типа делегата ChangedHandler
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
        
        public SquareMatrix(T[] matrixArray, int size) : this(size)
        {
            if (matrixArray.Length == size * size)
            {
                MatrixArray = matrixArray;
            }
            
            else 
            {
                throw new Exception ("Array is not square matrix array");
            }
            
            //Size = size;
        }

        public SquareMatrix(int size) 
        {
            MatrixArray = new T[size * size];
            Size = size;
        }

        public SquareMatrix() { }

        /// <summary>
        /// Exceptions: Indexes can not be negative
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public virtual T this[int i, int j] // индексатор обеспечивает доступ к элементу массива, т. о. что из 2х индексов получается 1 индекс
        {
            get => MatrixArray[i * Size + j];
            
            set 
            {
                if (i < 0 || j < 0)
                {
                    throw new Exception("Indexes can not be negative");
                }
                else 
                {                                       
                    MatrixArray[i * Size + j] = value;                   
                    Changed?.Invoke(MatrixArray[i * Size + j], value, i, j);
                }
            }           
        }      
    }
}
