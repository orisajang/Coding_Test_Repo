using System;

namespace consoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //입력 받기
            int[] inputs = Array.ConvertAll(Console.ReadLine().Trim().Split(' '),int.Parse);
            int sum = 0;
            //숫자를 다 더해줌
            for(int i=0; i< inputs.Length; i++)
            {
                sum += inputs[i] * inputs[i];
            }
            int result = sum % 10;
            Console.WriteLine(result.ToString());
        }
    }
}