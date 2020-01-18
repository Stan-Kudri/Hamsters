using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hamsters.Utilit;

namespace Hamsters
{
    class Hamsters:IHamsterData
    {
        public string Name { get; }
        public int Weight { get; }
        public int Age { get; }
        public Color Color { get; }

        public Hamsters(string name, int weight, int age, Color color)
        {
            Name = name;
            Weight = weight;
            Age = age;
            Color = color;
        }

        public override string ToString()
        {
            return $"Хомяк с именем {Name} весит {Weight} грамм. Его возраст {Age} месяцев и он {Color.ColorRendering()}.";
        }
    }
}
