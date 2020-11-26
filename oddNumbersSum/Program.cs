using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddNumbersSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayCount, oddNumbersSum = 0;

            Console.WriteLine("введите количество елементов масива: ");
            arrayCount = int.Parse(Console.ReadLine());
            

            int[] myArray;

            myArray = new int[arrayCount];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"\nВведите элемент масива под номерорм {i}: ");
                myArray[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < myArray.Length; i++)
            {
                
                if (myArray[i] % 2 == 0)
                {
                    oddNumbersSum += myArray[i];
                }
            }

            Console.WriteLine("\nСумма четных чисел массива: " + oddNumbersSum);

            Console.ReadLine();
        }
    }
}
