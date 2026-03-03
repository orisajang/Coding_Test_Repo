using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApp
{
	class Program
    {
    	public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for(int i=0; i<n; i++)
            {
                string[] str = Console.ReadLine().Split(' ').ToArray();
                sb.Append($"Case #{i+1}: ");
                for(int j=str.Length-1; j>=0; j--)
                {
                    sb.Append(str[j]);
                    if(j != 0)
                    {
                        sb.Append(" ");
                    }
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString());
        }
    }
}