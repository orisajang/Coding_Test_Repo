using System;
namespace ConsoleApp
{
    class Program
    {
		static void Main(string[] args)
		{
			int[] inputs = Array.ConvertAll(Console.ReadLine().Trim().Split(" "), int.Parse);
			//분 설정
			bool isSub = false;
			inputs[1] -= 45;
			//시간 설정
			if(inputs[1] < 0)
			{
				inputs[1] += 60;
				inputs[0] -= 1;
				//0보다 작다면 23으로 설정
				if(inputs[0] < 0)
				{
					inputs[0] += 24;
				}
			}
			Console.WriteLine($"{inputs[0]} {inputs[1]}");
		}
    }
    
}