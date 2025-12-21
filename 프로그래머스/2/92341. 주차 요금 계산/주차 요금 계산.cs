using System;
using System.Collections.Generic;
public class Solution {
    Dictionary<string,string> enterTimeDic = new Dictionary<string,string>();
    Dictionary<string,int> nujukTimeDic = new Dictionary<string,int>();
    int carCount = 0;
    public int[] solution(int[] fees, string[] records) {
        
        //요금은 fees의 계산값만큼 다름
        //기본시간 180분까지는 괜찮고, 180분에서 10분넘어갈때마다 요금 부여
        //차량이 연속으로 들어온경우-> 시간을 계속 더해준다
        //차량이 들어오고 출차 내역이 없는경우 -> 최대시간 23:59분까지로 계산
        int basicfeeTime = fees[0]; //기본 시간
        int basicfeeMoney = fees[1]; //기본 요금
        int feeTime = fees[2]; // 단위 시간
        int feeMoney = fees[3]; //단위 요금
        
        //records -> 입차, 출차 시간, IN : 입차, OUT : 출차
        // 시간을 05:34 ,  22:34 이런식으로 계싼함 , Split로 :로 나누면 될듯?
        //시간부터 가져와보자 아 근데 시간이 힘들다. 시간은 24시, 분은 60초라.. 
        
        
        for(int i=0; i< records.Length; i++)
        {
            string[] recordSplit = records[i].Split(' ');
            //처음부터 recordSplit[0]의 시간을 분으로 나누었으면 좋았을듯
            
            //차량을 확인해서 IN이면 시간 저장, Out이면 
            //딕셔너리 2개 만들기 특정 차량의 누적시간, 특정 차량의 입차 시간, 출차했을때 0으로 초기화
            MoneyCalc(recordSplit[0],recordSplit[1],recordSplit[2],false);
        }
        int[] answer = new int[carCount];
        int answerIndex = 0;
        
        List<string> keys = new List<string>();
        foreach(var currentkey in enterTimeDic.Keys)
        {
            keys.Add(currentkey);
        }
        keys.Sort();
        for(int i=0; i< keys.Count; i++)
        {
            //입차내역만 있고 출차내역이 없는경우 처리
            if(enterTimeDic[keys[i]] != "")
            {
                //나가는 시간은 무조건 23:59
                string exitTime = "23:59";
                string key = keys[i];
                MoneyCalc(exitTime,key,"OUT",true);
                //Console.WriteLine($"{exitTime}, {currentkey}");
            }
            //하나하나씩 값을 채워준다
            //요금 계산 시작
            int totalMinute = nujukTimeDic[keys[i]];
            
            int totalfee = basicfeeMoney;
            if(basicfeeTime < totalMinute)
            {
                 totalfee += (((totalMinute- basicfeeTime) / feeTime) * feeMoney);
                if((totalMinute- basicfeeTime) % feeTime > 0) 
                {
                    totalfee += feeMoney;
                }
            }
            answer[answerIndex] = totalfee;
            answerIndex++;
        }
        
        return answer;
    }
    public void MoneyCalc(string strTime, string carNumber, string carState, bool isLast)
    {
        //입차 (값을 담기만 한다)
            if(carState == "IN")
            {
                if(!enterTimeDic.ContainsKey(carNumber)) carCount++;
                enterTimeDic[carNumber] = strTime;
            }
            else if(carState == "OUT") //출차
            {
                //enterTimeDic 딕셔너리에 담겨있는 값을 현재 시간과 비교해서 값을  nujukTimeDic에 넣기
                string beforeTime = enterTimeDic[carNumber];
                string afterTime = strTime;
                //시간 계산을 한다
                string[] beforeTimeSplit = beforeTime.Split(':');
                string[] afterTimeSplit = afterTime.Split(':');
                //분 게산부터 하자
                int beforeMinute = int.Parse(beforeTimeSplit[1]);
                int afterMinute = int.Parse(afterTimeSplit[1]);
                
                int subTime = 0;
                int subMinute = afterMinute - beforeMinute;
                //0보다 분이 작을경우 처리
                if(subMinute < 0)
                {
                    //시간에서 1빼주고 분단위 처리
                    subTime = 1;
                    subMinute = 60 + subMinute;
                }
                
                //시간 계산 시작
                int beforeSigan = int.Parse(beforeTimeSplit[0]);
                int afterSigan = int.Parse(afterTimeSplit[0]);
                //분에서 시간하나 처리 필요했는지 체크
                afterSigan -= subTime;
                int subSigan = afterSigan - beforeSigan;
                //최종 시간 =;
                int resultMinute = (subSigan * 60) + subMinute;
                //Console.WriteLine($"{carNumber} {resultMinute} {subTime}");
                if(!nujukTimeDic.ContainsKey(carNumber)) nujukTimeDic[carNumber] = resultMinute;
                else
                {
                    nujukTimeDic[carNumber]+= resultMinute;
                }
                //계산끝났으면 키 지움
                if(!isLast) enterTimeDic[carNumber] = "";
            }
    }
}