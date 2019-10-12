using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Learning
{
    class View
    {
        public static void ViewConsole() {
            Console.WriteLine("Выберите вариант:");
            Console.WriteLine(" 1. Сгенерировать массив.");
            Console.WriteLine(" 2. Ввести данные массива.");
            Console.WriteLine(" Exit. Выйти из программы.");
            string sSwitch = Console.ReadLine();
            List<int> array;

            switch (sSwitch)
            {
                case "1":
                    array = Presenter.GetArray();
                    Console.WriteLine("Элементы массива: ");
                    PrintArray(array);
                    Console.WriteLine("Элементы отсортированного массива: ");
                    PrintArray(Presenter.SortArrayByParity(array, "even"));
                    break;
                case "2":
                    array = Presenter.SetArray();
                    PrintArray(array);
                    Console.WriteLine("Элементы отсортированного массива: ");
                    PrintArray(Presenter.SortArrayByParity(array, "even"));
                    break;
                case "Exit":
                    break;
                default:
                    Console.WriteLine("Введены неверные данные");
                    break;
            }
        }

        static void PrintArray(List<int> array) {            
            foreach (int element in array) {
                Console.WriteLine(element.ToString());
            }
            Console.ReadKey();
        }
    }
}