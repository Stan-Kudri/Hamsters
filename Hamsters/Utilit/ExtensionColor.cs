using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamsters.Utilit
{
    public static class ExtensionColor
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
    }
}
