using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if((num % 4 == 0 &&
              num % 100 != 0) ||
              num % 400 == 0)
            {
                Console.Write("1");
            }
            else
            {
                Console.Write("0");
            }
        }
    }
}