using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hamsters.Utilit;

namespace Hamsters
{
    /*
     *Сделать перечисления с днями недели, типом еды и цветом.
     * Нужно написать кла хомяка(имя-вес-возраст-цвет) и метод, который принимает животное с днем недели и возвращает еду которой нужно кормить хомяка.
     * Написать метод принимающий хомяка и еду и выводит в консоль что случилось с хомяком. */

    class Program
    {
        static void FeedHamster(FoodEdibilityCheck edibilityCheck)
        {
            var hamsters = new Hamsters[]
            {
                new Hamsters("Пупа", 400, 9, Color.pink),
                new Hamsters("Трула", 500, 10, Color.white),
            };            
            for (int i = 0; i < hamsters.Length; i++)
            {
                edibilityCheck.TodayEatUp(hamsters[i]);
                Console.WriteLine(hamsters[i].ToString());
            }
            foreach (DaysOfTheWeek deytimefood in Enum.GetValues(typeof(DaysOfTheWeek)))
            {
                Console.WriteLine($"день недели :{deytimefood.WeekRendering()}");
                foreach (var hamster in hamsters)
                {
                    if (edibilityCheck.IsAlive(hamster))
                    {
                        var food = RandomFood.FoodDays();
                        Console.WriteLine("Хомяку {0} дали {1}", hamster.Name, food.ToDisplayString());
                        if (IsEdibleFood(food))
                        {
                            edibilityCheck.TodayHungry(hamster);
                            if (edibilityCheck.IsDie(hamster))
                                Console.WriteLine($"{hamster.Name} умер");
                        }
                        else
                            edibilityCheck.TodayEatUp(hamster);
                    }
                }
            }
        }

        public static bool IsEdibleFood(Food food)
        {
            return (food == Food.candy) || (food == Food.meat);
        }

        static void Main(string[] args)
        {
            var edibilityCheck = new FoodEdibilityCheck();
            FeedHamster(edibilityCheck);
            Console.ReadLine();
        }
    }
}
