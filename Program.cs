using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
      static  void FillArrayRandomNumbers(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(-100, 100) / 10;
                }
            }
        }

        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.Write("]");
                Console.WriteLine("");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("введите номер строки");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите номер столбца");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] numbers = new int[10, 10];
            FillArrayRandomNumbers(numbers);

            if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
            {
                Console.WriteLine("такого элемента нет");
            }
            else
            {
                Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n - 1, m - 1]}");
            }

            PrintArray(numbers);

            
        }
    }
}
