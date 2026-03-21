using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{

    static List<int> array = new List<int>();
    static StringBuilder sb = new StringBuilder();
    static void Main()
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        for(int i=0; i< input[0]; i++)
        {
            array.Add(i + 1);
        }
        int[] result = new int[input[1]];
        Func( 0, 0,input[1], result);
        Console.WriteLine(sb.ToString());
    }

    static void Func(int index, int depth, int targetDepth, int[] result)
    {
        //index는 시작하는 숫자의 위치 1,2,3,4, 2,3,4, 3,4
        if (depth == targetDepth)
        {
            for (int i = 0; i < result.Length; i++)
            {
                sb.Append(result[i]);
                if (i < result.Length - 1)
                {
                    sb.Append(" ");
                }
            }
            sb.AppendLine();
            return;
        }

        for(int i=index; i< array.Count; i++)
        {
            result[depth] = array[i];
            Func(i + 1, depth + 1, targetDepth, result);
        }
    }
}