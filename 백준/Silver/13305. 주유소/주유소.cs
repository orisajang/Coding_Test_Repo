using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] lineArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] costArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            long min = long.MaxValue;
            long result = 0;
            //현재값이 최소라면 그거로 계속 더하면됨.
            for(int i=0; i< costArray.Length-1; i++)
            {
                if(min > costArray[i])
                {
                    min = costArray[i];
                }
                result += (lineArray[i] * min);
            }
            Console.WriteLine(result);
        }
   
    }
}