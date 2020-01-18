using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamsters
{
    public interface IHamsterData
    {
        string Name { get; }
        int Weight { get; }
        int Age { get; }
        Color Color { get; }
    }
}
