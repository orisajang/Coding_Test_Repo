using System;
using System.Collections.Generic;

namespace baek14425
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Dictionary<string,int> inputDic = new Dictionary<string,int>();
            int answer = 0;
            //입력 체크
            for(int i=0; i< input[0]; i++)
            {
                string str = Console.ReadLine();
                inputDic[str] = 1;
            }
            //존재하는지 체크
            for(int i=0; i< input[1]; i++)
            {
                string str = Console.ReadLine();
                if(inputDic.ContainsKey(str))
                {
                    answer++;
                }
            }
            Console.WriteLine(answer);
        }
    }
}