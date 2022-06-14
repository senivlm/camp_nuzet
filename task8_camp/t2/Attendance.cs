using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2
{
    public class Attendance
    {
        public string IP { get; set; }

        public DateTime time { get; set; }

        public Week.DayOfWeek weekDay { get; set; }

        public Attendance()
        {

        }

        public Attendance(string ip , string time, string day)
        {
            try
            {
                this.IP = ip;
                this.time = Convert.ToDateTime(time);
                weekDay = (Week.DayOfWeek)Enum.Parse(typeof(Week.DayOfWeek), day);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Error!, unable to convert data");
            }
            catch(Exception ex)
            {
                Console.WriteLine("General exception");
            }
        }

        public override string ToString()
        {
            return String.Format($"{IP}  {time.ToShortTimeString()} {weekDay}");
        }
    }
}
