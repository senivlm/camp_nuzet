using System;

namespace task2_camp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diagolan Snake: ");
            Matrix matrix = new Matrix(6,6);
            matrix.DiagonaleSnake();
            matrix.ShowMatrix();

            Console.WriteLine();
            Console.WriteLine("Spiral Snake: ");
            Matrix matrix2 = new Matrix(4,4);
            matrix2.FillBySpiralSnake();
            matrix2.ShowMatrix();
            Console.WriteLine();
            Console.WriteLine("Vertical Snake: ");
            Matrix matrix3 = new Matrix(6,5);
            matrix3.FillByVerticalSnake();
            matrix3.ShowMatrix();

           
        }
    }
}
