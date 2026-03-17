using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApp
{
	class Program
    {
    	public static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //데이터 저장
            Dictionary<string,string> dic = new Dictionary<string,string>();
            for(int i=0; i< input[0]; i++)
            {
                string[] str = Console.ReadLine().Split(' ').ToArray();
                dic.Add(str[0],str[1]);
            }
            //데이터 탐색
            for(int i=0; i< input[1]; i++)
            {
                string msg = Console.ReadLine();
                Console.WriteLine(dic[msg]);
            }
        }
    }
}