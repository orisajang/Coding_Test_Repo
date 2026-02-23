using System;
using System.Collections.Generic;
using System.Text;

namespace baek1259
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string s = Console.ReadLine();
                if(s == "0") break;
                
                StringBuilder sb = new StringBuilder();
                for(int i= s.Length-1; i>=0; i--)
                {
                    sb.Append(s[i]);
                }
                if(s == sb.ToString()) {Console.WriteLine("yes");}
                else {Console.WriteLine("no");}
            }
        }
    }
}