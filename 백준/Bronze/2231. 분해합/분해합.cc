#include <stdio.h>
#include <iostream>
#include <string.h>
using namespace std;
int main()
{
    int A;
    cin >> A;
    
    //분해합: N과 N을 이루는 각 자리수의 합
    //생성자: 분해합의 부모
    //198 -> 216 , 216이 198이 되려면?
    //216의 합 -> 9, 198의 합 -> 18, 2배?
    //199 -> 218 , 218이 199가 되려면?
    //218의 합 -> 11, 199의 합 -> 19, 
    //152 -> 160, 
    //160의 합 -> 7, 152의 합 -> 8
    // (n) = (n+a+b+c)
    //규칙을 찾기가 어렵다
    bool bFind = false;
    for(int i=1; i<=A; i++)
    {
        string str = to_string(i);
        int jariSum = 0;
        for(int j=0; j<str.length(); j++)
        {
            jariSum += (str[j] - '0');
        }
        int sum = i + jariSum;
        if(sum == A) 
        {
            cout << i;
            bFind = true;
            break;
        }
    }
    if(!bFind) cout << "0";
}