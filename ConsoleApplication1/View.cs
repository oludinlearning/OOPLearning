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
            bool exit = false;
            while (!exit) {
                string sSwitch;
                List<int> array;

                Console.WriteLine("Выберите вариант:");
                Console.WriteLine(" 1. Сгенерировать массив.");
                Console.WriteLine(" 2. Ввести данные массива.");
                Console.WriteLine(" Exit. Выйти из программы.");

                sSwitch = Console.ReadLine();
                sSwitch = sSwitch.ToLower();

                switch (sSwitch)
                {
                    case "1":
                        array = Presenter.GetArray();
                        Console.WriteLine("Элементы массива: ");
                        PrintArray(array);
                        TodoL1(array);
                        break;
                    case "2":
                        array = Presenter.SetArray();
                        PrintArray(array);
                        Console.WriteLine("Элементы отсортированного массива: ");
                        PrintArray(Presenter.SortArrayByParity(array, "even"));
                        break;
                    case "exit":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Введены неверные данные");
                        break;
                }
            }            
        }

        static void PrintArray(List<int> array) {            
            foreach (int element in array) {
                Console.WriteLine(element.ToString());
            }
            Console.ReadKey();
        }

        static string TodoL1(List<int> array)
        {
            string action;
            Console.WriteLine("Выберите действие:");
            Console.WriteLine(" 1. Отсортировать массив");
            Console.WriteLine(" 2. Удалить элементы массива");
            action = Console.ReadLine();

            switch (action) {
                case "1":
                    TodoSort(array);
                    break;
                case "2":
                    TodoDelete(array);
                    break;
            }

            return(action);
        }

        static void TodoSort(List<int> array)
        {
            string action;
            Console.WriteLine("Выберите действие:");
            Console.WriteLine(" 1. Отсортировать нечетные элементы");
            Console.WriteLine(" 2. Отсортировать четные элементы");
            action = Console.ReadLine();

            Console.WriteLine("Элементы отсортированного массива: ");

            switch (action)
            {
                case "1":                    
                    PrintArray(Presenter.SortArrayByParity(array, "even"));
                    break;
                case "2":
                    PrintArray(Presenter.SortArrayByParity(array, "odd"));
                    break;
            }
        }

        static void TodoDelete(List<int> array)
        {
            string action;
            Console.WriteLine("Выберите действие:");
            Console.WriteLine(" 1. Удалить первый четный элемент");
            Console.WriteLine(" 2. Удалить первый нечетный элемент");
            Console.WriteLine(" 3. Удалить первый отрицательный элемент");
            Console.WriteLine(" 4. Удалить элемент с заданным ключом");
            action = Console.ReadLine();

            Console.WriteLine("Элементы массива после удаления:");
            switch (action)
            {
                case "1":
                    PrintArray(Presenter.DeleteElement(array, "firsteven"));                    
                    break;
                case "2":
                    PrintArray(Presenter.DeleteElement(array, "firstodd"));
                    break;
                case "3":
                    PrintArray(Presenter.DeleteElement(array, "firstnegative"));
                    break;
                case "4":
                    PrintArray(Presenter.DeleteElement(array, "key"));
                    break;
            }

        }
    }
}