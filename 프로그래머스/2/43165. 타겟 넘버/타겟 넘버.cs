using System;

public class Solution {
    int res = 0;
    public void jaegue(int[] numbers,int target, int index,int sum)
    {
        //만약에 index가 마지막 이었다면? 이때만 체크
        if(index >= numbers.Length)
        {
            if(sum == target) res++;
            return;
        }
        
        int num = numbers[index];
        //+와 - 번호를 보낸다. 그리고 마지막 에서 체크하도록
        jaegue(numbers,target,index+1, sum+num);
        jaegue(numbers,target,index+1, sum-num); 
    }
    
    public int solution(int[] numbers, int target) {
        int answer = 0;
        //numbers의 갯수에 따라서 +n인지 -n인지의 경우가 달라짐
        //즉, +n인경우와 -n인 경우를 마치 Tree형태 (BFS?)로 나누어서 마지막에 결과를 확인하면 됨
        //재귀함수를, numbers, 현재index로 보내고, index가 numbers의 길이 넘어섰으면 return하자.
        jaegue(numbers,target,0,0);
        
        return res;
    }
}