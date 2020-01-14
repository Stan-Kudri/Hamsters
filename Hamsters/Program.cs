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
            var hamsters = new Hamsters[2];
            hamsters[0] = new Hamsters("Пупа", 400, 9, Color.pink);
            hamsters[1] = new Hamsters("Трула", 500, 10, Color.white);
            List<StatesHamster> statesHamsters = new List<StatesHamster>();
            for (int i = 0; i < hamsters.Length; i++)
            {
                statesHamsters.Add(new StatesHamster(hamsters[i]));
                Console.WriteLine(hamsters[i].ToString());
            }            
            foreach (DaysOfTheWeek deytimefood in Enum.GetValues(typeof(DaysOfTheWeek)))
            {
                Console.WriteLine($"день недели :{deytimefood.WeekRendering()}");
                foreach (var hamster in statesHamsters)
                {
                    if (hamster.LivingConditions)
                    {
                        var food = RandomFood.FoodDays();
                        Console.WriteLine("Хомяку {0} дали {1}", hamster.Hamster.Name, food.ToDisplayString());
                        if (IsEdibleFood(food))
                        {
                            if (!hamster.AteFood)
                            {
                                hamster.EndOfLife();
                                Console.WriteLine($"{hamster.Hamster.Name} умер");
                            }
                            hamster.TodayEatDown();
                        }
                        else
                            hamster.TodayEatUp();
                    }                   
                }
            }
            Console.ReadLine();
        }
    }
}
