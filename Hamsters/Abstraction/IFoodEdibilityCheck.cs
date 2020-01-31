using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamsters.Abstraction
{
    interface IFoodEdibilityCheck
    {
        void TodayEatUp(Hamsters hamsters);
        bool IsAlive(Hamsters hamsters);
        void TodayHungry(Hamsters hamsters);
        bool IsDie(Hamsters hamsters);
    }
}
