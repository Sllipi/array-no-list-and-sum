using System;
using System.Collections.Generic;

namespace ConsoleApp4_9_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Задача:
Пользователь вводит числа, и программа их запоминает.
Как только пользователь введёт команду sum, программа выведет сумму всех веденных чисел.

Выход из программы должен происходить только в том случае, если пользователь введет команду exit.

Программа должна работать на основе расширения массива.

Внимание, нельзя использовать List<T> и Array.Resize");
            Console.WriteLine();
            byte numberOfColumns = 0;
            byte[] array = new byte[numberOfColumns];
            byte[] array2 = new byte[array.Length + 1];
            byte arraySum = 0;
            byte number = 0;
            bool arrayStart = true;

            while (arrayStart = true)
            {
                Console.WriteLine($"Выввели {number} чисел. \nВведите число, exit или sum: ");
                string Message = Console.ReadLine();

                if (Message != "sum" && Message != "exit")
                {
                    byte nomberRand = Convert.ToByte(Message);
                    numberOfColumns += 1;
                    array = new byte[numberOfColumns];

                    for (int i = 0; i < array2.Length; i++)
                    {
                        array[i] = array2[i];
                    }

                    array[numberOfColumns - 1] = nomberRand;
                    array2 = new byte[numberOfColumns];

                    for (int i = 0; i < array.Length; i++)
                    {
                        array2[i] = array[i];
                    }

                    array2[numberOfColumns - 1] = nomberRand;
                    number++;
                }
            

                else if (Message == "sum")
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        arraySum += array[i];
                    }
                    Console.WriteLine($"Сумма массива: {arraySum} \n");
                }


                else if (Message == "exit")
                {
                    arrayStart = false;
                    break;
                }

                else Console.WriteLine($"Нет такой команды ");

            }
        }
    }
}