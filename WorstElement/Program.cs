using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorstElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayCount;

            Console.WriteLine("введите количество елементов масива: ");
            arrayCount = int.Parse(Console.ReadLine());

            int[] myArray;

            myArray = new int[arrayCount];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"\nВведите элемент масива под номерорм {i}: ");
                myArray[i] = int.Parse(Console.ReadLine());

            }

            int minValue = myArray[0];

            for (int i = 0; i < myArray.Length; i++)
            {
                if (minValue > myArray[i])
                {
                    minValue = myArray[i];
                }
            }

            Console.WriteLine("\nНаименьшее значение массива = " + minValue);

            Console.ReadLine();
        }
    }
}
