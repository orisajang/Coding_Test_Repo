using System;
using System.Collections.Generic;
using System.Text;

namespace baek1874
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>();
            List<char> ch = new List<char>();
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            int index = 1;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                while(true)
                {
                    if (st.Count > 0 && st.Peek() == num)
                    {
                        if (st.Peek() > num) break;
                        st.Pop();
                        //ch.Add('-');
                        sb.AppendLine("-");
                        break;
                    }
                    else
                    {
                        if (index > n) break;
                        st.Push(index);
                        index++;
                        //ch.Add('+');
                        sb.AppendLine("+");
                    }
                }
                
            }
            if (st.Count == 0)
            {
                Console.Write(sb);
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
    
}