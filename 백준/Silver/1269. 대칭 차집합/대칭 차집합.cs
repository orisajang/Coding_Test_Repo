using System;
using System.Collections.Generic;
using System.Linq;

namespace baek1269
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputCount = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] inputA = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] inputB = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            Dictionary<int,bool> elementA = new Dictionary<int,bool>();
            Dictionary<int,bool> elementB = new Dictionary<int,bool>();
            foreach(int num in inputA)
            {
                elementA[num] = true;
            }
            foreach(int num in inputB)
            {
                elementB[num] = true;
            }
            //서로 없는거 있는지 확인
            int answer = 0;
            foreach(int num in elementA.Keys)
            {
                if(!elementB.ContainsKey(num))
                {
                    answer++;
                }
            }
            foreach(int num in elementB.Keys)
            {
                if(!elementA.ContainsKey(num))
                {
                    answer++;
                }
            }
            Console.WriteLine(answer);
        }
    }
}