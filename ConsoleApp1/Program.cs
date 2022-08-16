using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /// <summary>
        /// Метод добавления в список радномных значений от мин до макс
        /// </summary>
        /// <param name="listValue"> Список для заполнения случайными значениями </param>
        /// <param name="minValue"> Минимальное значение </param>
        /// <param name="maxValue"> Максимальное значение </param>
        static void AddList(List<int> listValue, int minValue, int maxValue)
        {
            Random random = new Random();

            for (int i = 0; i < maxValue; i++)
            {
                listValue.Add(random.Next(minValue, maxValue));
            }

        }

        /// <summary>
        /// Метод удаления значений из списка, которые больше 25 и меньше 50
        /// </summary>
        /// <param name="listValue"> Список, заполненный случайными значениями </param>
        /// <value name ="newListInt"> новый список чисел, удовлетворяющих условию </value>>
        static List<int> RemoveValueInList(List<int> listValue)
        {
            List<int> newListInt = new List<int>();

            for (int i = 0; i < listValue.Count; i++)
            {
                if (listValue[i] < 25 || listValue[i] > 50)
                {
                    newListInt.Add(listValue[i]);
                }
            }

            listValue = newListInt;
            return listValue;
        }

        /// <summary>
        /// Метод вывода списка на экран
        /// </summary>
        /// <param name="listValue"> Список, заполненный случайными значениями </param>
        static void Print(List<int> listValue)
        {
            for (int i = 0; i < listValue.Count; i++)
            {
                Console.Write($"{listValue[i]} ");
            }
        }


        static void Main(string[] args)
        {
            List<int> ListIntValue = new List<int>();

            AddList(ListIntValue, 0, 100);

            Console.WriteLine();
            Console.WriteLine("Целые числа от 0 до 100:\n");
            Print(ListIntValue);

            Console.WriteLine();

            RemoveValueInList(ListIntValue);

            Console.WriteLine("\nУдалены числа больше 25 и меньше 50:\n");
            Print(ListIntValue);

            Console.ReadKey();
        }
    }
}
