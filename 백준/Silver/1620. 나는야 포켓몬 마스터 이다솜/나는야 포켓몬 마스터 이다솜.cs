using System;
using System.Collections.Generic;
using System.Linq;

namespace back1620
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Dictionary<string,int> pokeMonIndex = new Dictionary<string,int>();
            Dictionary<string,string> pokeMonName = new Dictionary<string,string>();
            //0번째배열에는 입력 몇개인지 들어가있음
            for(int i=0; i<inputArray[0]; i++)
            {
                string str = Console.ReadLine();
                pokeMonIndex[str] = i+1;
                pokeMonName[(i+1).ToString()] = str;
            }
            //1번째에는 입력이 들어가있다
            for(int i=0; i<inputArray[1]; i++)
            {
                string str = Console.ReadLine();
                if(pokeMonIndex.ContainsKey(str))
                {
                    Console.WriteLine(pokeMonIndex[str]);
                }
                else if(pokeMonName.ContainsKey(str))
                {
                    Console.WriteLine(pokeMonName[str]);
                }
            }
        }
    }
}