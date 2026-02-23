using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace back1920
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Dictionary<int,bool> numExistDic = new Dictionary<int,bool>();
            foreach(int num in nArray)
            {
                if(!numExistDic.ContainsKey(num))
                {
                    numExistDic[num] = true;
                }
            }
            //m을 파악
            StringBuilder sb = new StringBuilder();
            int m = int.Parse(Console.ReadLine());
            int[] mArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            foreach(int num in mArray)
            {
                if(numExistDic.ContainsKey(num)){ sb.AppendLine("1");}
                else{sb.AppendLine("0");}
            }
            Console.WriteLine(sb.ToString());
        }
    }
}