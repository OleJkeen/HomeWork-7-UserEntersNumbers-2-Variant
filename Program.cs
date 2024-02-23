using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_7_User_Enters_Numbers_2_Variant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] userArray = new int[0];

            string userInput = "";
            string exitCommand = "exit";
            string sumCommand = "sum";

            Console.WriteLine("\nЧтобы посчитать сумму всех чисел введите: sum");
            Console.WriteLine("\nДля выхода из программы введите: exit");
            Console.WriteLine("\nВведите числа: ");


            while (userInput != exitCommand)
            {
                userInput = Console.ReadLine();

                if (userInput == exitCommand)
                {
                    break;
                }

                if (userInput == sumCommand)
                {
                    int sumNumbers = 0;

                    foreach (int num in userArray) 
                    {
                        sumNumbers += num;
                    }
                    Console.WriteLine($"Сумма чисел: {sumNumbers}");
                }
                else
                {
                    int userNumber = int.Parse(userInput);

                    int[] tempArray = new int[userArray.Length +1];

                    for (int i = 0; i < userArray.Length; i++)
                    {
                        tempArray[i] = userArray[i];
                    }

                    tempArray[tempArray.Length - 1] = userNumber;
                    userArray = tempArray;

                    Console.WriteLine($"Числа в массиве: {string.Join(", ", userArray)}");
                }

                Console.WriteLine("Введите новые числа: ");
            }

            Console.WriteLine("Программа завершена");
            Console.ReadLine();
        }
    }
}
