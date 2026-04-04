using System;
using System.Linq;
namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            //문자열 x가 존재할때 범위안에 특정 문자가 몇개 존재하는지 알고싶음.
            //정수형일때는 그냥 계속 더하기만 했으면 됬음
            //문자열이라면? 이차원 배열을 이용해서 특정 인덱스위치일때 알파벳이 몇개인지 저장을 해둔다. 
            //그런다음 뒤 - 앞을 하면됨,
            string input = Console.ReadLine();
            char[][] array = new char[input.Length][];
            for (int i = 0; i < input.Length; i++)
            {
                array[i] = new char[26];
                if (i > 0)
                {
                    for (int j = 0; j < 26; j++)
                    {
                        array[i][j] = array[i - 1][j];
                    }
                }
                int num = input[i] - 'a';
                array[i][num]++;
            }
            //이제 답을 구한다.
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] strArray = Console.ReadLine().Split(' ').ToArray();
                char ch = strArray[0][0];
                int startIndex = int.Parse(strArray[1]);
                int endIndex = int.Parse(strArray[2]);
                int num = ch - 'a';
                //갯수는?
                int result;
                if (startIndex == 0)
                {
                    result = array[endIndex][num];
                }
                else
                {
                    result = array[endIndex][num] - array[startIndex - 1][num];
                }

                Console.WriteLine(result);
            }
        }
    }
}