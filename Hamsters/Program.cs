using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamsters
{
    /*
     *Сделать перечисления с днями недели, типом еды и цветом.
     * Нужно написать кла хомяка(имя-вес-возраст-цвет) и метод, который принимает животное с днем недели и возвращает еду которой нужно кормить хомяка.
     * Написать метод принимающий хомяка и еду и выводит в консоль что случилось с хомяком. */
    
    class Program
    {
        public static bool IsEdibleFood(Food food)
        {
            return (food == Food.candy) || (food == Food.meat);
        }

        static void Main(string[] args)
        {
            var hamster = new Hamsters[2];
            hamster[0] = new Hamsters("Пупа", 400, 9, Color.pink);
            hamster[1] = new Hamsters("Трула", 500, 10, Color.white);
            /*var dictionary = new Dictionary<Hamsters, int>();*/
            var edibilityCheck = new FoodEdibilityCheck();            
            for (int i = 0; i < hamster.Length; i++)
            {
                edibilityCheck.TodayEatUp(hamster[i]);   
                Console.WriteLine(hamster[i].ToString());
            }            
            foreach (DaysOfTheWeek deytimefood in Enum.GetValues(typeof(DaysOfTheWeek)))
            {
                Console.WriteLine($"день недели :{deytimefood.WeekRendering()}");
                foreach (Hamsters hamsters in hamster)
                {
                    if(edibilityCheck.IsAlive(hamsters))
                    {
                        var food = RandomFood.FoodDays();
                        Console.WriteLine("Хомяку {0} дали {1}", hamsters.Name, food.ToDisplayString());
                        if (IsEdibleFood(food))
                        {
                            edibilityCheck.TodayHungry(hamsters);
                            if (edibilityCheck.IsDied(hamsters))
                                Console.WriteLine($"{hamsters.Name} умер");                            
                        }
                        else
                            edibilityCheck.TodayEatUp(hamsters);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
