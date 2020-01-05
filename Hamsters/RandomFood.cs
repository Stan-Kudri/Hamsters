using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamsters
{
    class RandomFood
    {       
        private static Random rnd = new Random();
        private static Food[] itemsfood = (Food[])Enum.GetValues(typeof(Food));
        public static Food FoodDays()
        {            
            return itemsfood[rnd.Next(0, itemsfood.Length)];
        }
    }
}
