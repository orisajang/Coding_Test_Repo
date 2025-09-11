#include <iostream>
#include <stdio.h>
#include <string>
#include <vector>

using namespace std;

int solution(vector<int> d, int budget) {
    int answer = 0;
    
    //정렬하고, 앞에서부터 더한다음에, budget보다 크면 이전값을 넘김
    //1. 정렬 (수동 구현)
    for(int i=0; i<d.size() -1; i++)
    {
        for(int j=0; j<d.size()-1 -i; j++)
        {
            if(d[j] > d[j+1]) 
            {
                int buf = d[j];
                d[j] = d[j+1];
                d[j+1] = buf;
            }
        }
    }
    int sum = 0;
    for(int i=0; i< d.size(); i++)
    {   
        if(sum + d[i]  > budget) break;
        sum += d[i];
        answer++;
    }
    
    
    return answer;
}