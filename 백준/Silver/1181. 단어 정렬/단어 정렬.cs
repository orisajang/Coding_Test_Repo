using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            //중복을 제거하면서 저장을 해야한다
            HashSet<string> hash = new HashSet<string>();
            for(int i=0; i< t; i++)
            {
                string str = Console.ReadLine();
                hash.Add(str);
            }
            List<string> strList = new List<string>();
            foreach(string str in hash)
            {
                strList.Add(str);
            }
            strList.Sort((a, b) => Func(a, b));
            
            foreach(string str in strList)
            {
                Console.WriteLine(str);
            }
        }
        private static int Func(string str1,string str2)
        {
            if(str1.Length < str2.Length)
            {
                return -1;
            }
            else if(str1.Length > str2.Length)
            {
                return 1;
            }
            //단어로 비교
            return str1.CompareTo(str2);
        }
    }
}
