using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task6_2
{
    internal class TextCreater
    {
        public string _path { get; private set; }

        public string[] _text;

        public TextCreater (string fileName)
        {
            _path = fileName;
        }

        public TextCreater():this(default)
        {

        }
        public void CreateSentanse()
        {
            StreamReader streamReader = new StreamReader(_path);
            _text = DeleteSpaces(streamReader.ReadToEnd().Trim(' ')).Split('.', '!', '?',';');
            if (_text[_text.Length - 1] == "")
            {
                Array.Resize(ref _text,_text.Length - 1);
            }
            for (int i = 0; i < _text.Length; i++)
            {
                _text[i] = _text[i].Trim();
            }
        }
        private string DeleteSpaces(string myString)
        {
            while (myString.Contains("\n"))
            {
                myString = myString.Replace("\n", "").Replace("\r", ""); ;
            }

            while (myString.Contains("  "))
            {
                myString = myString.Replace("  ", " ");
            }
            return myString;
        }
        public void TextToFile()
        {
            using (StreamWriter writer = new StreamWriter("..\\..\\..\\result.txt", true))
            {

                foreach (string sentanse in _text)
                {
                    writer.WriteLine(sentanse);
                }
            }
        }

        private string FindLongestWord(string sentanse)
        {
            string longestWord="";
            int counter=0;
            foreach(var symbol in sentanse.Split(' '))
            {
                if(symbol.Length>counter)
                {
                    longestWord = symbol;
                    counter=symbol.Length;
                }
            }
            return($"the longest word is {longestWord} ({counter} Symbols)");

        }

        private string FindShortesWord(string sentanse)
        {
            string shortesWord = sentanse.Split(' ')[0];
            int counter = sentanse.Split(' ')[0].Length;
            foreach (var symbol in sentanse.Split(' '))
            {
                if(symbol.Length<counter )
                {
                    shortesWord = symbol;
                    counter= symbol.Length;
                }
            }
            return ($"the shortes word is {shortesWord} ({counter} Symbols)");
        }

        public void ShowText()
        {
            foreach (var sentanse in _text)
            {
                Console.WriteLine(sentanse);
            }
        }

        public void LongestAndShortesInText()
        {
            int s = 0;
            foreach (var item in _text)
            {
                Console.WriteLine($" in {++s} sentanse: {FindLongestWord(item)}|| {FindShortesWord(item)}");
            }
        }



    }
}
