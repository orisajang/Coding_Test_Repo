using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace baek11399
{
	class Program
    {
    	public static void Main(string[] args)
        {
        	int n = int.Parse(Console.ReadLine());
            List<int> timeList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            timeList.Sort();
            int[] sumArray = new int[n];
            int answer = 0;
            sumArray[0] = timeList[0];
            answer += sumArray[0];
            for(int i=1; i<n; i++)
            {
                sumArray[i] = sumArray[i-1] + timeList[i];
                answer += sumArray[i];
            }
            Console.WriteLine(answer);
        }
    }
}