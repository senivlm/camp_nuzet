using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_camp
{
    internal class Matrix
    {
        private int [,] matrix;

        public Matrix()
        {

        }

        public Matrix (int [,] matrix)
        {
            this.matrix = matrix;
        }

        public Matrix(int columns, int rows )
        {
            this.matrix = new int[columns, rows];
        }

        public void DiagonaleSnake()
        {
            if (matrix.GetLength(0) != matrix.GetLength(1))
            {
                Console.WriteLine("Matrix is not square");
            }
            
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

       
        public void FillBySpiralSnake()
        {
            int n = matrix.GetLength(0); ;                
            int m = matrix.GetLength(1);               
            
            int value = 1;
            int k = 0;
            int l = 0;
            int x = n * m + 1;
            while (true)
            {
                for (int i = k; i < m - k; i++)
                {
                    matrix[l, i] = value++;
                }
                if (value == x)
                {
                    break;
                }
                l++;
                for (int i = l; i < n - l; i++)
                {
                    matrix[i, m - k - 1] = value++;
                }
                if (value == x)
                {
                    break;
                }
                for (int i = m - k - 1; i >= k; i--)
                {
                    matrix[n - l, i] = value++;
                }
                if (value == x)
                {
                    break;
                }
                for (int i = n - l - 1; i >= l; i--)
                {
                    matrix[i, k] = value++;
                }
                if (value == x)
                {
                    break;
                }
                k++;
            }
        }

        public void FillByVerticalSnake()
        {
            int value = 1;
            
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if(i%2==0)
                {
                    for(int j =0; j<matrix.GetLength(0); j++ )
                    {
                        matrix[j,i] = value++;
                        
                    }
                }
                if (i%2!=0)
                {
                    for(int j = matrix.GetLength(0)-1; j>=0; j--)
                    {
                        matrix[j,i] = value++;
                        
                    }
                }
            }
        }

        public void ShowMatrix()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                ;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                   
                }
                
                Console.WriteLine("");
            }

        }
    }
}
