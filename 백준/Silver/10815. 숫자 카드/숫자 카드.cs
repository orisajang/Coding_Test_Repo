using System;
using System.Collections.Generic;
using System.Text;

namespace baek10815
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            Dictionary<int,int> nNumberDic = new Dictionary<int,int>();
            foreach(int item in nArray)
            {
                if(!nNumberDic.ContainsKey(item)) {nNumberDic[item] = 1;}
                else{nNumberDic[item]++;}
            }
            
            int m = int.Parse(Console.ReadLine());
            int[] mArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            StringBuilder sb = new StringBuilder();
            for(int i=0; i< mArray.Length; i++)
            {
                if(nNumberDic.ContainsKey(mArray[i]))
                {
                    sb.Append(nNumberDic[mArray[i]].ToString());
                }
                else
                {
                    sb.Append("0");
                }
                //띄어쓰기
                if(i < mArray.Length-1)
                {
                    sb.Append(" ");
                }
            }
            Console.WriteLine(sb.ToString());
            
        }
    }
}