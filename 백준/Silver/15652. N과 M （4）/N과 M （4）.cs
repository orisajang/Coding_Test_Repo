using System;
using System.Collections.Generic;
using System.Text;
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
            Func(0,0,input[1], new int[input[1]]);
            Console.WriteLine(sb.ToString());
        }
        
        public static void Func(int index, int depth, int maxDepth, int[] result)
        {
            if(depth == maxDepth)
            {
                for(int i=0; i< result.Length; i++)
                {
                    sb.Append(result[i]);
                    if(i< result.Length-1)
                    {
                        sb.Append(' ');
                    }
                }
                sb.AppendLine();
                return;
            }
            //계산하기
            for(int i=index; i< array.Count; i++)
            {
                result[depth] = array[i];
                Func(i, depth+1, maxDepth, result);
            }
            
        }
        
        
    }
}