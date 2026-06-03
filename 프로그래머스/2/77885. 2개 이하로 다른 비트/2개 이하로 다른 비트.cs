using System;
using System.Text;
using System.Linq;

public class Solution {
    public long[] solution(long[] numbers) {
        long[] answer = new long[numbers.Length];
        
        //뒤에있는거를 바꾸면? 될듯?
        for(int i=0; i< numbers.Length; i++)
        {
            
            //2진수로 바꾸자
            long current = numbers[i];
            string str = Func(current);
            char[] ch = str.ToArray();
            bool isFind = false;
            for(int j=ch.Length-1; j >=0; j--)
            {
                //뒤에서부터 하면서그냥 처리하기
                if(ch[j] == '0')
                {
                    ch[j] = '1';
                    if(j != ch.Length -1)
                    {
                        ch[j+1] = '0';
                    }
                    isFind = true;
                    break;
                }
            }
            //못찾았으면 맨앞에 1하나 붙여야함
            if(!isFind)
            {
                ch[0] = '0';
                string strBuf = new string(ch);
                strBuf = '1' + strBuf;
                ch = strBuf.ToCharArray();
                isFind = true;
            }
            //ch를 다시 int형으로 바꾸기
            answer[i] = ChangeToInt(ch);
            
        }
        return answer;
    }
    private long ChangeToInt(char[] ch)
    {
        long index = 0;
        long sum = 0;
        for(int i=ch.Length-1; i >=0; i--)
        {
            //여기서 현재 인덱스를 그냥 계속 더하자
            if(index ==0)
            {
                index++;    
            }
            else
            {
                index *= 2;
            }
            if(ch[i] == '1')
            {
                sum += index;
            }
        }
        return sum;
    }
    
    private string Func(long num)
    {
        if(num==0) return "0";
        
        StringBuilder sb = new StringBuilder();
        while(num > 0)
        {
            sb.Append(num % 2);
            num /= 2;
        }
        return new string(sb.ToString().Reverse().ToArray());
    }
    
    
}