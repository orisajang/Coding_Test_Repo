using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace back11659
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputCountArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = inputCountArray[0];
            int m = inputCountArray[1];
            int[] inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] plusArray = new int[n + 1];
            //미리 더한값들을 만들어놓자
            for (int i = 1; i <= inputNumbers.Length; i++)
            {
                plusArray[i] = plusArray[i - 1] + inputNumbers[i-1];
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < m; i++)
            {
                int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int start = inputs[0];
                int end = inputs[1];
                if(start == end)
                {
                    sb.AppendLine((inputNumbers[start - 1]).ToString());
                }
                else
                {
                    sb.AppendLine((plusArray[end] - plusArray[start - 1]).ToString());
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}