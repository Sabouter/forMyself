﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
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

            Console.WriteLine("\nВывод масива ");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            

            Console.ReadLine();

        }
    }
}
