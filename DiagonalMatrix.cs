using System.Collections.Generic;

namespace Matrix
{
    internal class DiagonalMatrix<T> : Matrix<T>
    {     
        public DiagonalMatrix(T[] matrixArray, int size) : base (matrixArray, size)
        {
            MatrixArray = matrixArray;
            Size = size;
        }

        public override int this[int i, int j] // индексатор обеспечивает доступ к элементу массива, т о что из 2х индексов получается 1 индекс
        {
            get
            {
                if (i == j)
                {
                    return MatrixArray[i * Size + j];
                }
                else
                {
                    return 0;
                }                
            }
            set => MatrixArray[i * Size + j] = value;            
        }
    }
}
