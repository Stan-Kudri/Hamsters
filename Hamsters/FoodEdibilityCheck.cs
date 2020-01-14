using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamsters
{
    class FoodEdibilityCheck
    {
        private Dictionary<Hamsters, int> dictionary = new Dictionary<Hamsters, int>() ; 
               

        public void TodayEatUp (Hamsters hamster)
        {
            dictionary[hamster] = 0;
        }

        public bool IsAlive(Hamsters hamster)
        {
            return dictionary[hamster] < 2;                
        }

        public void TodayHungry (Hamsters hamster)
        {
            dictionary[hamster]++;
        }

        public bool IsDie(Hamsters hamster)
        {
            return dictionary[hamster] == 2;
        }                     
    }
}
