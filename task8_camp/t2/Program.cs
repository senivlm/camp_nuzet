using System;
using System.IO;
namespace t2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          try
            {
                AttendanceStatistics as1 = new AttendanceStatistics("..\\..\\..\\visit.txt");
                Console.WriteLine(as1.GetAttendanceStatistics());
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("File is not found!");
            }
            catch(IOException)
            {
                Console.WriteLine("General exception!");
            }
        }
    }
}
