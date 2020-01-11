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

        public FoodEdibilityCheck() { }

        public List<Hamsters> GetHamsters()
        {
            return dictionary.Select(s => s.Key).ToList();
        }

        public Dictionary<Hamsters,int> FirstDayOfTheHamster (Hamsters hamster)
        {
            dictionary[hamster] = 0;
            return dictionary;
        }

        public bool IsAlive(Hamsters hamster)
        {
            if (dictionary[hamster] < 2)
                return true;
            else
                return false;
        }

        public Dictionary<Hamsters,int> HamsterDidNotEat (Hamsters hamster)
        {
            dictionary[hamster]++;
            return dictionary;
        }

        public bool Died(Hamsters hamster)
        {
            if (dictionary[hamster] == 2)
                return true;
            else
                return false;
        }                     
    }
}
