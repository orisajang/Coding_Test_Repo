using System;
using System.Collections.Generic;
using System.Text;
namespace baek15649
{
	class Program
    {
        static List<int> array = new List<int>();
        static StringBuilder sb = new StringBuilder();
        static bool[] isVisited;
        
        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            for(int i=0; i< input[0]; i++)
            {
                array.Add(i + 1);
            }
            isVisited = new bool[input[0]];
            int[] result = new int[input[1]];
            Func(0, input[1], result);
            Console.WriteLine(sb.ToString());
        }

        static void Func(int depth, int maxDepth, int[] result)
        {
            if(depth == maxDepth)
            {
                for(int i=0; i < result.Length; i++)
                {
                    sb.Append(result[i]);
                    if(i < result.Length -1 )
                    {
                        sb.Append(' ');
                    }
                }
                sb.AppendLine();
                return;
            }
            //계산식
            for(int i=0; i< array.Count; i++)
            {
                if (isVisited[i]) continue;
                isVisited[i] = true;
                result[depth] = array[i];
                Func(depth + 1, maxDepth, result);

                //쓰고나서 할당 해제
                isVisited[i] = false;
            }
        }
    }
}