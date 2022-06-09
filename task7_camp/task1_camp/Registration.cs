using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1_camp
{
    internal class Registration
    {
        Dictionary<DateTime,string> _registrationsJournal;
        public Registration()
        {
            _registrationsJournal = new Dictionary<DateTime,string>();
        }

        public void AddToJournal(string s)
        {
            _registrationsJournal.Add(DateTime.Now, s);
            using (StreamWriter writer = new StreamWriter("..\\..\\..\\RegistrationsJournal.txt",true))
            {
                writer.WriteLine(DateTime.Now + "||" + s );
            }
        }

        public override string ToString()
        {
            string result = null;
            foreach (var item in _registrationsJournal)
                result = result + item.Key.ToString() + "||" + item.Value + '\n';
            return result;
        }

    }
}
