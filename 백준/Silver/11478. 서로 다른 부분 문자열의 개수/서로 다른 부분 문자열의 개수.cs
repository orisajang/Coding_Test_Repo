using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace baek11478
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = Console.ReadLine();
            Dictionary<string,int> strDic = new Dictionary<string,int>();
            int answer = 0;
            //문자열을 나눠야한다.
            for(int i=1; i<= msg.Length; i++)
            {
                StringBuilder sb= new StringBuilder();
                for(int j=0; j< msg.Length; j++)
                {
                    if(i + j > msg.Length) break;
                    
                    string str = msg.Substring(j,i);
                    if(!strDic.ContainsKey(str))
                    {
                        strDic[str] = 1;
                        answer++;
                    }
                }
            }
            Console.WriteLine(answer);
        }
    }
}