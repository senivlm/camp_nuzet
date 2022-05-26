using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    public class Matrix
    {
        int [,] matrix;

        public Matrix()
        {

        }
        public Matrix(int[,] arr)
        {
            matrix = arr;
        }
        public  Matrix(int a, int b)
        {
            matrix = new int[a,b];
        }

        public void DiagonaleSnake()
        {
            if (matrix.GetLength(0)!= matrix.GetLength(1)) 
            { 
                Console.WriteLine("Matrix is not square"); 
            }
            int direction = 1; 
            int counter = 1;
            for (int line = 0; line < matrix.GetLength(1); line++)
            {
                if (line % 2 == 0)
                {
                    for (int y = 0; y <= line; y++)
                        matrix[y, line - y] = counter++;
                }
                else
                {
                    for (int x = line; x >= 0; x--)
                        matrix[x, line - x] = counter++;
                }
            }

            for (int stage = matrix.GetLength(1); stage <= (matrix.GetLength(1) - 1) * 2; stage++)
            {
                if (stage % 2 == 0)
                {
                    for (int y = stage - matrix.GetLength(0) + 1; y <= matrix.GetLength(1) - 1; y++)
                        matrix[y, stage - y] = counter++;
                }
                else
                {
                    for (int y = matrix.GetLength(1) - 1; y >= stage - matrix.GetLength(0) + 1; y--)
                        matrix[y, stage - y] = counter++;
                }
            }
        }
        
        public void ShowMatrix()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine();
            }
            
        }

       
    }
}
