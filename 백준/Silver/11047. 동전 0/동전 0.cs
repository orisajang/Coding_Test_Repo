using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace baek11047
{
	class Program
    {
    	public static void Main(string[] args)
        {
        	int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> coinList = new List<int>();
            for(int i=0; i< inputArray[0]; i++)
            {
                coinList.Add(int.Parse(Console.ReadLine()));
            }
            int answer = 0;
            int remainMoney = inputArray[1];
            for(int i = coinList.Count-1; i>= 0; i--)
            {
                if(remainMoney == 0) break;
                
                int divNum = coinList[i];
                if((remainMoney / divNum) >= 1)
                {
                    answer += (remainMoney / divNum);
                    remainMoney %= divNum;
                }
            }
            Console.WriteLine(answer);
        }
    }
}