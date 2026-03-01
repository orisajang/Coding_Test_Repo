using System;
using System.Collections.Generic;
using System.Text;
namespace baek15649
{
	class Program
    {
        static StringBuilder sb = new StringBuilder();
        static void func(List<int> used, List<int> numList, int depth)
        {
            //처음에 0이 들어온다. numList는 숫자들 1~3
            if(used.Count ==  depth)
            {
                for (int i = 0; i < used.Count; i++)
                {
                    sb.Append(used[i]);
                    if (i < used.Count - 1) sb.Append(' ');
                }
                sb.AppendLine();
                return;
            }

            //1이 들어있는상태, 2한다
            for(int i=0; i< numList.Count; i++)
            {
                if (used.Contains(numList[i])) continue;

                List<int> newUsed = new List<int>(used);
                newUsed.Add(numList[i]);
                func(newUsed,numList,depth);
            }
            
        }
    	public static void Main(string[] args)
        {
            //n개의 숫자. m개를 뽑는다
            //1이 n번돌면서 자신이 아닐때만 한번 출력
            List<int> usedList = new List<int>();
            List<int> numList = new List<int>();

            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for(int i=0; i< inputArray[0]; i++)
            {
                numList.Add(i + 1);
            }
            func(usedList, numList, inputArray[1]);
            Console.WriteLine(sb.ToString());
        }
    }
}