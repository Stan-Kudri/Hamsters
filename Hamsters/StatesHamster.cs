using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamsters
{
    class StatesHamster
    {
        public Hamsters Hamster { get; }
        public bool AteFood { get; set; }
        public bool LivingConditions { get; set; }

        public StatesHamster(Hamsters hamsters)
        {
            Hamster = hamsters;
            AteFood = true;
            LivingConditions = true;
        }

        public void TodayEatUp()
        {
            AteFood = true;
        }

        public void TodayEatDown()
        {
            AteFood = false;
        }

        public void EndOfLife()
        {
            LivingConditions = false;
        }
    }
}
