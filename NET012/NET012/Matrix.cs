
namespace NET012
{
    /// <summary>
    /// Abstract type of square matrix. Base class for SquareMatrix ad DiagonalMatrix classes
    /// </summary>
    /// <typeparam name="T">Type of matrix's elements</typeparam>
    public abstract class Matrix<T>
    {
        /// <summary>
        /// Protected delegate for handling elemnts of matrix
        /// </summary>
        /// <param name="element">Value of element of matrix</param>
        /// <param name="value">New value of matrix element</param>
        /// <param name="i">Index of column of current element</param>
        /// <param name="j">Index of row of current element</param>
        protected delegate void MatrixHandler(T element, T value, int i, int j);
        /// <summary>
        /// List for keeping values of elements of matrix
        /// </summary>
        public List<T> MatrixValues;
        /// <summary>
        /// Number of rows and columns in current matrix
        /// </summary>
        public int LenghtMatrix;

        /// <summary>
        /// Creates abstract instance for abstract matrix and gives default values for all fields 
        /// </summary>
        public Matrix()
        {
            MatrixValues = null;
            LenghtMatrix = 0;
        }

        /// <summary>
        /// Notifying method of changig matrix element value
        /// </summary>
        /// <param name="element">Value of element of matrix</param>
        /// <param name="value">New value of matrix element</param>
        /// <param name="i">Index of column of current element</param>
        /// <param name="j">Index of row of current element</param>
        protected void Message(T element, T value, int i, int j)
        {
            Console.WriteLine($"\nOld value of element with indexes[{i},{j}]: {element}" +
                $"\nNew value of element with indexes [{i},{j}]: {element}\n");
        }
    }
}
