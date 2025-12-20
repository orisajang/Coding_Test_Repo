using System.Collections.Generic;
using System.Text;
public class Solution {
    public long solution(long n) {
        long answer = 0;
        //숫자를 나머지 연산을 통해 1개씩 빼온다?
        List<long> list = new List<long>();
        while(n != 0)
        {
            //나머지값으로 마지막 1자리 숫자를 가져옴
            long k = n%10;
            //리스트에 담는다
            list.Add(k);
            //n을 나눠서 숫자하나씩 빼준다
            n/= 10;
        }
        //정렬 (내림차순)
        list.Sort();
        list.Reverse();
        //answer에 넣어주기위해서 
        StringBuilder sb = new StringBuilder();
        for(int i=0; i< list.Count; i++)
        {
            sb.Append(list[i].ToString());
        }
        string str = sb.ToString();
        answer = long.Parse(str);
        
        return answer;
    }
}