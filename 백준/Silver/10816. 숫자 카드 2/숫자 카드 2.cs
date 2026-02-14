using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace back10816
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            //입력부터
            int n = int.Parse(Console.ReadLine());
            Dictionary<int,int> haveCardCountDic = new Dictionary<int,int>();
            //플레이어가 가지고있는 카드의 갯수를 딕셔너리에 저장해둔다
            int[] inputArrayNum = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for(int i=0; i<n; i++)
            {
                int currentNum = inputArrayNum[i];
                if(!haveCardCountDic.ContainsKey(currentNum)) { haveCardCountDic[currentNum] = 1; }
                else    { haveCardCountDic[currentNum]++; }
            }
            //2. 해당 카드를 몇개 가지고있는지 출력하기 위해서
            int m = int.Parse(Console.ReadLine());
            int[] checkCardArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for(int i=0; i<m; i++)
            {
                int currentNumber = checkCardArray[i];
                //없으면 0출력, 있으면 해당 숫자 출력
                if(!haveCardCountDic.ContainsKey(currentNumber)) { sb.Append("0"); }
                else { sb.Append(haveCardCountDic[currentNumber]); }
                //다음숫자를 위해 1칸 공백출력
                if(i < m-1) {sb.Append(" ");}
            }
            //매번 콘솔출력하면 속도가 매우 느려서 sb로 묶은다음 출력한다고한다
            Console.WriteLine(sb.ToString());
        }
    }
}