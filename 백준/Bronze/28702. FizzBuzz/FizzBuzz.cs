using System;
using System.Collections.Generic;

namespace back28702
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultNum = 0;
            for(int i=0; i< 3; i++)
            {
                string msg = Console.ReadLine();
                int num = 0;
                if(int.TryParse(msg,out num))
                {
                    resultNum += num + (3- i);
                    break;
                }
            }
            //현재 숫자는 startNum;
            if(resultNum %3 == 0 && resultNum % 5 == 0) Console.WriteLine("FizzBuzz");
            else if(resultNum %3 == 0 && resultNum % 5 != 0) Console.WriteLine("Fizz");
            else if(resultNum %3 != 0 && resultNum % 5 == 0) Console.WriteLine("Buzz");
            else if(resultNum %3 != 0 && resultNum % 5 != 0) Console.WriteLine(resultNum);
        }
    }
}