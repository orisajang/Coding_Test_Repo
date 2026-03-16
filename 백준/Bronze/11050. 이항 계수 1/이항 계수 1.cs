using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApp
{
	class Program
    {
        static Dictionary<string, bool> stringDic = new Dictionary<string, bool>();
        static int answer = 0;
    	public static void Main(string[] args)
        {
        	int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //n개의 숫자중에서 k개를 고르는 문제
            //재귀를 통해서 k개가 골라졌으면 결과를 저장한다.
            Func(input[0], input[1], 0, new List<int>());
            Console.WriteLine(answer);
            
        }
        static void Func(int n, int k, int depth, List<int> element)
        {
            if(k == depth)
            {
                //딕셔너리에 이미 포함되어있는지 체크
                element.Sort();
                //string str = string.Join(",", element);
                StringBuilder sb = new StringBuilder();
                foreach(int item in element)
                {
                    sb.Append(item);
                }
                if (!stringDic.ContainsKey(sb.ToString()))
                {
                    answer++;
                    stringDic.Add(sb.ToString(), true);
                }
                return;
            }

            for(int i=1; i<= n; i++)
            {
                if(!element.Contains(i))
                {
                    List<int> elementBuf = new List<int>(element);
                    elementBuf.Add(i);
                    Func(n, k, depth + 1, elementBuf);
                }
            }
        }
    }
}