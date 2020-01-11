using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamsters
{
    public static class LocalizationUtil
    {
        public static string ColorRendering(this Color color)
        {
            switch (color)
            {
                case Color.red:
                    return "красный";
                case Color.pink:
                    return "розовый";
                case Color.blue:
                    return "голубой";
                case Color.white:
                    return "белый";
            }
            return null;
        }

        public static string WeekRendering(this DaysOfTheWeek days)
        {
            switch(days)
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

        public static string ToDisplayString(this Food food)
        {
            switch(food)
            {
                case Food.feed:
                    return "корм";
                case Food.corn:
                    return "зерно";
                case Food.meat:
                    return "мясо";
                case Food.vegetables:
                    return "овощи";
                case Food.candy:
                    return "конфеты";
            }
            return null;
        }
    }
}
