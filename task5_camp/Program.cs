using System;
using System.IO;
namespace Vector
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("initShufle:");
            Vector vector = new Vector(10);
            vector.InitShufle();
            Console.WriteLine(vector);

            Console.WriteLine();
            Console.WriteLine("RandomInitialization:");

            Vector arr = new Vector(20);
            arr.RandomInitialization(1, 6);

            Console.WriteLine(arr);
            Console.WriteLine();
            Console.WriteLine("calculate freq (RandomInitialization array):");
            Pair[] pairs = arr.CalculateFreq();

            for (int i = 0; i < pairs.Length; i++)
            {
                Console.Write(pairs[i] + "\n");
            }
            Console.WriteLine();
            Console.WriteLine("LongestSequenseFind (RandomInitialization array):");

            arr.LongestSequenseFind();
            arr.LongestSequenseFind(1);
            Console.WriteLine();
            Console.WriteLine("Reverse (RandomInitialization array):");
            arr.Reverse();
            Console.WriteLine(arr);

            Console.WriteLine();
            Console.WriteLine("CheckForPalindrom (RandomInitialization array): ");
            bool palindrom = arr.CheckForPalindrom();
            Console.WriteLine(palindrom);

            Console.WriteLine();
            Matrix matrix = new Matrix(5, 5);
            matrix.DiagonaleSnake();
            Console.WriteLine("\tDiagnalSnake:");
            Console.WriteLine();
            matrix.ShowMatrix();
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("random array :");
            Vector v = new Vector(10);
            v.RandomInitialization(1, 20);
            Console.WriteLine(v);
            Console.WriteLine();
            v.HeapySort();
            Console.WriteLine("sorted random array: ");
            Console.WriteLine(v);
            Console.WriteLine();
            Console.WriteLine("array from file: ");
            Console.WriteLine();
            using (StreamReader reader = new StreamReader("1.txt"))
            {
                Matrix matrix1 = new Matrix(reader);
                matrix1.ShowMatrix();
            }

            Console.WriteLine();






        }
    }
}
