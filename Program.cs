// Escriba un programa que lea el array:
// 4 7 1 3 5
// 2 0 6 9 7
// 3 1 2 6 4

// y lo escriba como

// 4 2 3
// 7 0 1
// 1 6 2
// 3 9 6
// 5 7 4

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayConversion
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,]
            {
                { 4, 7, 1, 3, 5 },
                { 2, 0, 6, 9, 7 },
                { 3, 1, 2, 6, 4 }
            };
            //print original matrix
            Console.WriteLine("Original matrix");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            //get the number of rows and columns of the original matrix
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            //create new matrix
            int[,] transposed = new int[columns, rows];

            //transform rows to columms
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    transposed[j, i] = matrix[i, j];
                }
            }

            // Print transposed matrix
            Console.WriteLine("\nTransposed matrix");

            // Iterate through the columns first, then the rows, to explore the matrix elements by columns
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(transposed[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}