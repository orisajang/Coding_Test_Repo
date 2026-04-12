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
			int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			
			//for문으로 max처리
			int max = int.MinValue;
			int current = 0;
			for(int i=0; i< inputArray.Length; i++)
			{
				current+= inputArray[i];
				if(current < inputArray[i])
				{
					current = inputArray[i];
				}
				if(max < current)
				{
					max = current;
				}
				
			}
			Console.WriteLine(max);
        }
    }
}