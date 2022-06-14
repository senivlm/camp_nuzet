using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2
{
    public  static class FileReader
    {
        public static List<string> ReadFromFile (string fileName)
        {
            List<string> fileList = new List<string>();
            using(StreamReader streamReader = new StreamReader(fileName))
            {
                while(streamReader.Peek()>0)
                {
                    fileList.Add(streamReader.ReadLine());
                }
            }
            return fileList;
        }
    }
}
