using System;

class Program
{
    static int count = 1;
    static int Func(char[] msg,int left,int right)
    {
        //이 함수가 몇번 실행되었는지 return

        if (left >= right) return 0;

        if (msg[left] == msg[right])
        {
            count += 1;
            return Func(msg, left + 1, right - 1);
        }
        else
        {
            return 0;
        }
    }

    static bool Func2(char[]msg,int left, int right)
    {
        //msg는 앞뒤가 같은 문자열인지 확인
        if(left >= right)
        {
            return true;
        }
        if (msg[left] != msg[right])
        {
            return false && Func2(msg, left + 1, right - 1);
        }
        else
        {
            return true && Func2(msg, left + 1, right - 1);
        }
    }
    static void Main()
    {
        int T = int.Parse(Console.ReadLine());
        for (int i = 0; i < T; i++)
        {
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            bool isTrue = Func2(ch, 0, str.Length - 1);
            int num = isTrue == true ? 1 : 0;
            Console.Write(num + " ");
            Func(ch,0,str.Length-1);
            Console.WriteLine(count);
            count = 1;
        }
    }
}