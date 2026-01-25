using System;
using System.Collections.Generic;

namespace baek10773
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>();
            int k = int.Parse(Console.ReadLine());
            for(int i=0; i< k; i++)
            {
                int num = int.Parse(Console.ReadLine());
                //0일경우 무조건 지운다는 정수 보장
                if(num == 0) st.Pop();
                else st.Push(num);
            }
            int sum = 0;
            while(st.Count != 0)
            {
                sum += st.Pop();
            }
            Console.WriteLine(sum);
        }
    }
}