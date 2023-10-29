
namespace NET012
{
    /// <summary>
    /// Concrete type for diagonal matrix. Base class: Matrix
    /// </summary>
    /// <typeparam name="T">Type of matrix's elements</typeparam>
    public class DiagonalMatrix<T> : Matrix<T>
    {
        /// <summary>
        /// Event to notify element of matrix changing
        /// </summary>
        private event MatrixHandler? Notify;

        /// <summary>
        /// Indexer for matrix. Has two indexes
        /// </summary>
        /// <param name="i">Index for column</param>
        /// <param name="j">Index for row</param>
        /// <returns>Returns or changes element with current indexes</returns>
        /// <exception cref="ArgumentException">Exception for case of current index is out of matrix length</exception>
        public T this[int i, int j]
        {
            get
            {
                if (i <= 0 || i > LenghtMatrix - 1 || j <= 0 || j > LenghtMatrix - 1) // ask about condition realization
                    throw new ArgumentException("One of indexes is out of length of matrix");
                if (i != j) return default;
                else return MatrixValues[i];
            }

            set
            {
                if (i <= 0 || i > LenghtMatrix - 1 || j <= 0 || j > LenghtMatrix - 1)
                    throw new ArgumentException("One of indexes is out of length of matrix");
                if (i != j)
                    throw new ArgumentException("This element is not on the diagonal of diagonal matrix");
                if (!value.Equals(MatrixValues[i]))
                {
                    Notify?.Invoke(MatrixValues[j * LenghtMatrix + i], value, i, j);
                    MatrixValues[i] = value;
                }
            }
        }

        /// <summary>
        /// Creates instance of diagonal matrix
        /// </summary>
        /// <param name="matrix">List of T type values, which MatrixValues gets</param>
        /// <param name="length">Length of matrix, which LengthMatrix gets</param>
        /// <exception cref="ArgumentException"></exception>                                //ask
        public DiagonalMatrix(List<T> matrix, int length)
        {
            if (length <= 0)
                throw new ArgumentException("Matrix length is 0  or below 0");
            if (length != matrix.Count)
                throw new ArgumentException("length argument is invalid");

            MatrixValues = new List<T>(matrix);
            LenghtMatrix = length;
            Notify += Message; 
        }
    }
}
