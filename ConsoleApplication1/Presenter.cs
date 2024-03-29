﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
namespace MVP_Learning
{
    class Presenter
    {
        public static List<int> GetArray()
        {
            return (GenerateArray());
        }

        public static List<int> SetArray()
        {
            return (GenerateArray("UserInput"));
        }

        private static List<int> GenerateArray()
        {
            List<int> array = new List<int>();
            Random number = new Random();

            for (int i = 0; i <= number.Next(5, 10); i++)
            {
                array.Add(number.Next(-100, 100));
            }
            return array;
        }

        private static List<int> GenerateArray(string arg)
        {

            List<int> array = new List<int>();
            if (arg == "UserInput") {
                Console.Write("Введите целые числа массива через пробел: ");
                array = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            } else if(arg == ""){
                Random number = new Random();

                for (int i = 0; i <= number.Next(5, 10); i++)
                {
                    array.Add(number.Next(0, 100));
                }
            }
            return array;
        }

        public static List<int> SortArrayByParity(List<int> array, string parity)
        {
            if (parity == "even")
            {
                int temp = 0;
                for (int i = 0; i < array.Count - 1; i++) {
                    if ((array[i] % 2 == 0 && array[i] != 0)) {
                        for (int j = i + 1; j < array.Count; j++)
                        {
                            if ((array[j] % 2 == 0 && array[j] != 0)&&(array[i] > array[j]))
                            {
                                temp = array[i];
                                array[i] = array[j];
                                array[j] = temp;
                            }
                        }
                    }
                }
            }
            else if (parity == "odd")
            {
                int temp = 0;
                for (int i = 0; i < array.Count - 1; i++)
                {
                    if ((array[i] % 2 == 0 && array[i] != 0))
                    {
                        for (int j = i + 1; j < array.Count; j++)
                        {
                            if ((array[j] % 2 == 0 && array[j] != 0) && (array[i] > array[j]))
                            {
                                temp = array[i];
                                array[i] = array[j];
                                array[j] = temp;
                            }
                        }
                    }
                }
            }
            else {                
            }
            return array;
        }

        public static List<int> DeleteElement(List<int> array, string arg) {
            bool found = false;
            int i = 0;
            int key;
            switch (arg) {
                case "firsteven":
                    while (!found && i < array.Count - 1)
                    {
                        if ((array[i] != 0) && (array[i] % 2 == 0))
                        {
                            found = true;
                            array.RemoveAt(i);
                        }
                        i++;
                    }
                    if (!found) {
                        Console.WriteLine("Четный элемент не найден.");
                    }
                    break;
                case "firstodd":
                    while (!found && i < array.Count - 1)
                    {
                        if ((array[i] != 0) && (array[i] % 2 == 1))
                        {
                            found = true;
                            array.RemoveAt(i);
                        }
                        i++;
                    }
                    if (!found)
                    {
                        Console.WriteLine("Нечетный элемент не найден.");
                    }
                    break;
                case "firstnegative":
                    while (!found && i<array.Count-1)
                    {
                        if (array[i] < 0)
                        {
                            found = true;
                            array.RemoveAt(i);
                        }
                        i++;
                    }
                    if (!found)
                    {
                        Console.WriteLine("Отрицательный элемент не найден.");
                    }
                    break;
                case "key":
                    Console.Write("Введите значение элемента, который нужно удалить: ");
                    key = Convert.ToInt32(Console.ReadLine());
                    while (!found && i < array.Count - 1)
                    {
                        if (array[i] == key)
                        {
                            found = true;
                            array.RemoveAt(i);
                        }
                        i++;
                    }
                    if (!found)
                    {
                        Console.WriteLine("Заданный элемент не найден.");
                    }
                    break;
                default:
                    Console.WriteLine("Вы не выбрали действие.");
                    break;
            }
            return array;
        }
    }
}
