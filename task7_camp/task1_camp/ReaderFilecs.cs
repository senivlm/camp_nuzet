using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1_camp
{
    internal class ReaderFile
    {
        private string _path;

        public string Path
        {
            get { return _path; }

            set
            {
                if (value != null)
                {
                    _path = value;
                }
            }
        }

        public ReaderFile( string path)
        {
            this._path = path;
        }

        public ReaderFile()
        {

        }

        public string ReadFromFile()
        {
            StreamReader reader;
            try
            {
                reader = new StreamReader(this._path);
                return reader.ReadToEnd();
            }
            catch(FileNotFoundException)
            {
                try
                {
                    reader  = new StreamReader("..\\..\\..\\"+this._path);
                    return reader.ReadToEnd();
                }
                catch(FileNotFoundException)
                {
                    return "File is not found...";
                }
                catch(IOException)
                {
                    return "General exception";
                }
            }
        }

        public override string ToString()
        {
            using (StreamReader sr = new StreamReader(Path))
                return sr.ReadToEnd();
        }

    }
}
