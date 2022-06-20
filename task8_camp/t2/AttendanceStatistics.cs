using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2
{
    public class AttendanceStatistics
    {// Лінки тут корисні. Молодець.
        List<Attendance> attendances;

        public AttendanceStatistics(string fileName)
        {
            attendances = new List<Attendance>();
            List<string> infos = FileReader.ReadFromFile(fileName);
            foreach (string str in infos)
            {
                List<string> splits = str.Split(' ').ToList();
                attendances.Add(new Attendance(splits[0], splits[1], splits[2]));
            }
        }

        private string GetPopularDayToAttendanceStatistics(List<Attendance> attendances)
        {
            var dayVisits = attendances.GroupBy(v => v.weekDay);
            int maxVisitCount = 0;
            string days = string.Empty;
            foreach (var dayVis in dayVisits)
            {
                if (dayVis.Count() > maxVisitCount)
                {
                    maxVisitCount = dayVis.Count();
                    days = dayVis.Key.ToString();
                }
                else if (dayVis.Count() == maxVisitCount)
                {
                    days += $", {dayVis.Key.ToString()}";
                }
            }
            return days;
        }
        string GetMostPopularTimeToAttendanceStatistics(List<Attendance> attendances)
        {
            string resultString = string.Empty;
            int maxCount = 0;
            for (int i = 0; i < 24; i++)
            {
                int count = attendances.Where(v => v.time.Hour == i).Count();
                if (count > maxCount)
                {
                    resultString = $" +-{i}h";
                    maxCount = count;
                }
                else if (count == maxCount)
                {
                    resultString += $" +- {i}h ";
                }
            }
            return resultString;
        }
        public string GetAttendanceStatistics()
        {
            string res = string.Empty;
            if (attendances.Count == 0)
            {
                return "No visits";
            }
            var ipVisits = attendances.GroupBy(v => v.IP);
            foreach (var ipVis in ipVisits)
            {
                res += $"IP adress: {ipVis.Key} made {ipVis.Count()} visits\n\r";
                res += $"The Most Popular Day -  { GetPopularDayToAttendanceStatistics(ipVis.ToList())}\n\r";
                res += $"The Most Popular Time {GetMostPopularTimeToAttendanceStatistics(ipVis.ToList())}\n\r\n\r";
            }
            return res;
        }

    }
}
