using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArrayHW1
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

            Console.WriteLine("\nВивід масиву ");

            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                    Console.WriteLine(myArray[i]);
            }
            
            Console.ReadLine();
        }
    }
}
