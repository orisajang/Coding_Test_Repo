using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApp
{
	class Program
    {
    	public static void Main(string[] args)
        {
            int[] input1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] input2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            int bunmo = input1[1] * input2[1];
            int bunza1 = input1[0] * input2[1];
            int bunza2 = input2[0] * input1[1];
            int bunzaSum = bunza1+bunza2;
            //최대공약수를 구해서 처리
            int num = GCD(bunzaSum,bunmo);

            Console.WriteLine($"{bunzaSum/num} {bunmo/num}");
            
        }
        private static int GCD(int a, int b)
        {
            while(b != 0)
            {
                int temp = a % b;
                a = b;
                b = temp;
            }
            return a;
        }
    }
}