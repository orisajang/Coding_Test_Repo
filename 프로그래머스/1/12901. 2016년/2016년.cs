public class Solution {
    public string solution(int a, int b) {
        string answer = "";
        int[] month = new int[]{31,29,31,30,31,30,31,31,30,31,30,31}; //월별 일수
        string[] day = new string[] {"THU","FRI","SAT","SUN","MON","TUE","WED"}; //목요일부터 시작
        //a월 b일을 알아내야함
        
        int addDays = 0; 
        for(int i=0; i< a-1; i++) //월마다 일수를 더함
        {
            addDays += month[i];
        }
        addDays += b; //남은 일수를 더함
        
        int div = addDays % day.Length; //일자를 알아냄
        answer = day[div]; 
        
        return answer;
    }
}