using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp
{
	class Program
    {
        static List<int> array = new List<int>();
        static StringBuilder sb = new StringBuilder();
    	public static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for(int i=0; i< input[0]; i++)
            {
                array.Add(i+1);
            }
            Func(0,input[1],new int[input[1]]);
            
            Console.WriteLine(sb.ToString());
        }
        static void Func(int depth, int maxDepth, int[] result)
        {
            if(depth == maxDepth)
            {
                for(int i=0; i< result.Length; i++)
                {
                    sb.Append(result[i]);
                    if(i < result.Length-1)
                    {
                        sb.Append(' ');
                    }
                }
                sb.AppendLine();
                return;
            }
            //계산해준다
            for(int i=0; i< array.Count; i++)
            {
                result[depth] = array[i];
                Func(depth+1, maxDepth, result);
            }
            
        }
    }
}