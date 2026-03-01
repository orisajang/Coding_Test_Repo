using System;
using System.Collections.Generic;
using System.Text;
namespace baek4779
{
	class Program
    {
        static string func(string msg, int index)
        {
            //중앙 부분은 재귀로 안보내고, 길이가 1일때도 안보냄
            if (index == 1)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < msg.Length; i++)
                {
                    sb.Append(' ');
                }
                return sb.ToString();
            }
            if (msg.Length == 1) return msg;
            

            int length_div = msg.Length / 3;
            string[] strArray = new string[3];
            //3등분을 해서 각각 string 배열에 담아둠
            for(int i=0; i< strArray.Length; i++)
            {
                int startIdx = (i * length_div);
                strArray[i] = msg.Substring(startIdx, length_div);
            }
            //이걸 다시 재귀를 통해 처리한다 (3부분으로)
            return func(strArray[0], 0) + func(strArray[1], 1) + func(strArray[2], 2);
        }
    	public static void Main(string[] args)
        {
        	string n;
            while((n = Console.ReadLine()) != null)
            {
                int num = int.Parse(n);
                StringBuilder sb = new StringBuilder();
                string str;
                int pow = 1;
                //제곱 찾기
                for (int i = 0; i < num; i++)
                {
                    pow *= 3;
                }
                //문제 문자열 만들기
                for (int i = 0; i < pow; i++)
                {
                    sb.Append('-');
                }
                str = sb.ToString();

                if (str.Length == 1) Console.WriteLine('-');
                else
                {
                    string answer = func(str, 0);
                    Console.WriteLine(answer);
                }
            } 
            
        }
    }
}