using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamsters.Utilit
{
    public static class ExtensionFood
    {
        public static string ToDisplayString(this Food food)
        {
            switch (food)
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
