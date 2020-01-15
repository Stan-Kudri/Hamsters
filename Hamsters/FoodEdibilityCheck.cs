using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamsters
{
    class HamsterLifeState
    {
        public Hamsters Hamster { get; set; }
        public int Livehamster { get; set; }

    }
    class FoodEdibilityCheck
    {
        private List<HamsterLifeState> list = new List <HamsterLifeState>();
        
        public int ListOfHamsters(Hamsters hamsters)
        {
            for(int i=0; i < list.Count; i++)           
                if(list[i].Hamster==hamsters)                
                    return i;            
            return -1;
        }

        public void TodayEatUp (Hamsters hamsters)
        {
            var index = ListOfHamsters(hamsters);
            if (index != -1)
                list[index].Livehamster = 0;
            else
                list.Add(new HamsterLifeState() { Hamster = hamsters, Livehamster = 0 });
        }

        public bool IsAlive(Hamsters hamsters)
        {
            var index = ListOfHamsters(hamsters);
            return list[index].Livehamster < 2;                
        }

        public void TodayHungry (Hamsters hamsters)
        {
            var index = ListOfHamsters(hamsters);
            list[index].Livehamster++;
        }

        public bool IsDie(Hamsters hamsters)
        {
            var index = ListOfHamsters(hamsters);
            return list[index].Livehamster == 2;
        }                     
    }
}
