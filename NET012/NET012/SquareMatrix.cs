namespace NET012
{
    /// <summary>
    /// Concrete type for square matrix. Base class: Matrix
    /// </summary>
    /// <typeparam name="T">Type of matrix's elements</typeparam>
    public class SquareMatrix<T> : Matrix<T> //ask about abstract class
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
                return MatrixValues[j * LenghtMatrix + i];
            }
            set
            {
                if (i <= 0 || i > LenghtMatrix - 1 || j <= 0 || j > LenghtMatrix - 1)
                    throw new ArgumentException("One of indexes is out of length of matrix");
                Notify?.Invoke(MatrixValues[j * LenghtMatrix + i], value, i, j);
                MatrixValues[j * LenghtMatrix + i] = value;
                //ask about usual methods, anon methods and lambdas in task
            }
        }

        /// <summary>
        /// Initializes object of current SquareMatrix type
        /// </summary>
        /// <param name="matrix">List of lists of T values, which MatrixValues gets</param>
        /// <param name="length">Number of columns and rows, which LenghtMatrix gets</param>
        /// <exception cref="ArgumentException"></exception>                                             //ask
        public SquareMatrix(List<List<T>> matrix, int length)
        {
            if (length != matrix.Count)
                throw new ArgumentException("length argument is invalid");

            if (length <= 0)
                throw new ArgumentException("Matrix length is 0  or below 0");

            for (int i = 0; i < matrix.Count; i++)
                if (matrix[i].Count != matrix.Count)
                    throw new ArgumentException("matrix is not square matrix");

            Notify += Message;
            MatrixValues = new List<T>();
            LenghtMatrix = length;

            for (int j = 0; j < matrix?.Count; j++)
               for (int i = 0; j < matrix[i]?.Count; i++)
                   MatrixValues?.Add(matrix[i][j]);
        }
    }
}