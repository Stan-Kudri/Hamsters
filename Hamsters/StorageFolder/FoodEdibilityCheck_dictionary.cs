using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamsters.StorageFolder
{
    class FoodEdibilityCheck_dictionary
    {
        private Dictionary<Hamsters, int> dictionary = new Dictionary<Hamsters, int>();

        public void TodayEatUp(Hamsters hamsters)
        {
            dictionary[hamsters] = 0;
        }

        public bool IsAlive(Hamsters hamsters)
        {            
            return dictionary[hamsters] < 2;
        }

        public void TodayHungry(Hamsters hamsters)
        {
            dictionary[hamsters]++;
        }

        public bool IsDie(Hamsters hamsters)
        {
            return dictionary[hamsters] == 2;
        }
    }
}
