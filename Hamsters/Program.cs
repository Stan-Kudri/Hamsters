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
        public static bool EdibleFood(Food food)
        {
            if ((food == Food.candy) || (food == Food.meat))
                return true;
            else
                return false;
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
                edibilityCheck.FirstDayOfTheHamster(hamster[i]);                
                /*dictionary[hamster[i]] = 0; 
                Console.WriteLine(hamster[i].ToString());*/
            }
            foreach (Hamsters kvp in edibilityCheck.GetHamsters())
            {
                Console.WriteLine(kvp);
            }
            foreach (DaysOfTheWeek deytimefood in Enum.GetValues(typeof(DaysOfTheWeek)))
            {
                Console.WriteLine($"день недели :{deytimefood.WeekRendering()}");
                foreach (Hamsters kvp in edibilityCheck.GetHamsters())
                {
                    if(edibilityCheck.IsAlive(kvp)==true)
                    {
                        var food = RandomFood.FoodDays();
                        Console.WriteLine("Хомяку {0} дали {1}", kvp.Name, food.FoodRendering());
                        if (EdibleFood(food) == true)
                        {
                            edibilityCheck.HamsterDidNotEat(kvp);
                            if (edibilityCheck.Died(kvp) == true)
                                Console.WriteLine($"{kvp.Name} умер");                            
                        }
                        else
                            edibilityCheck.FirstDayOfTheHamster(kvp);
                    }
                    /*if (dictionary[hamster[i]] < 2)
                    {
                        var food = RandomFood.FoodDays();
                        Console.WriteLine("Хомяку {0} дали {1}", hamster[i].Name, food.FoodRendering());
                        if ((food == Food.meat) || (food == Food.candy))
                        {
                            dictionary[hamster[i]]++;
                            if(dictionary[hamster[i]] == 2)
                                Console.WriteLine($"{hamster[i].Name} умер");
                        }
                        else
                            dictionary[hamster[i]] = 0;

                    }
                    */
                }
            }
            Console.ReadLine();
        }
    }
}
