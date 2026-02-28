using System;
using System.Collections.Generic;
using System.Linq;

namespace baek1764
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Dictionary<string,int> nameDic = new Dictionary<string,int>();
            int total = input[0] + input[1];
            for(int i=0; i<total; i++)
            {
                string name = Console.ReadLine();
                if(!nameDic.ContainsKey(name)) {nameDic[name] = 1;}
                else {nameDic[name]++; }                
            }
            List<string> nameList = new List<string>();
            foreach(string name in nameDic.Keys)
            {
                if(nameDic[name] == 2)
                {
                    nameList.Add(name);
                }
            }
            nameList.Sort();
            Console.WriteLine(nameList.Count);
            foreach(string name in nameList)
            {
                Console.WriteLine(name);
            }
        }
    }
}