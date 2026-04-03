using System;
using System.Collections.Generic;
using System.Linq;

namespace baek1654
{
    class Program
    {
        static int[] lineData;
        static int[] input;
        static long result;
        static void Main(string[] args)
        {
            input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            lineData = new int[input[0]];
            for(int i=0; i< input[0]; i++)
            {
                lineData[i] = int.Parse(Console.ReadLine());
            }
            //재귀로 했더니 시간초과남. 그냥 while문으로 하자
            long left = 1;
            long right = lineData.Max();
            while(left <= right)
            {
                long middle = left + (right - left) / 2;
				//현재 middle값으로 몇개가 나오는지 확인
				long count = 0;
				for(int i=0; i< lineData.Length; i++)
				{
					count += (lineData[i] / middle);
				}
				if(count >= input[1])
				{
					if(result < middle)
					{
						result = middle;
					}
					//갯수가 더 많이나옴. 현재 middle수가 적다는거임
                    left = middle+1;
				}
				else
				{
                    right = middle-1;
				}
            }
            Console.WriteLine(result);
        }
    }
}