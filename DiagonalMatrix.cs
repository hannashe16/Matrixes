namespace Matrix
{
    internal class DiagonalMatrix<T> : SquareMatrix<T>
    {     
        public DiagonalMatrix(T[] matrixArray, int size) : base (matrixArray, size)
        {
            MatrixArray = matrixArray;
            Size = size;
        }

        public DiagonalMatrix(int size)// : base(size)
        {
            MatrixArray = new T[size];                                    
            Size = size;
        }

        public override T this[int i, int j] // индексатор обеспечивает доступ к элементу массива, т о что из 2х индексов получается 1 индекс
        {
            get
            {
                if (i == j)
                {
                    return MatrixArray[i];
                }
                else
                {
                    return default(T);
                }                
            }           
            set => MatrixArray[i] = value;          
        }
    }
}
