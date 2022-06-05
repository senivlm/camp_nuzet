using System;

namespace task6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          TextCreater textCreater = new TextCreater("..\\..\\..\\input.txt");
            textCreater.CreateSentanse();
            textCreater.ShowText();
            textCreater.LongestAndShortesInText();
            textCreater.TextToFile();
        }
    }
}
