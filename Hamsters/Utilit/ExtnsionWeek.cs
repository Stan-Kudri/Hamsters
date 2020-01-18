using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamsters.Utilit
{
    public static class ExtnsionWeek
    {
        public static string WeekRendering(this DaysOfTheWeek days)
        {
            switch (days)
            {
                case DaysOfTheWeek.monday:
                    return "понедельник";
                case DaysOfTheWeek.tuesday:
                    return "вторник";
                case DaysOfTheWeek.wednesday:
                    return "среда";
                case DaysOfTheWeek.thursday:
                    return "четверг";
                case DaysOfTheWeek.friday:
                    return "пятница";
                case DaysOfTheWeek.satrday:
                    return "суббота";
                case DaysOfTheWeek.sunday:
                    return "воскресенье";

            }
            return null;
        }
    }
}
