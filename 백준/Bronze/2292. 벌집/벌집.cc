#include <stdio.h>
#include <iostream>

using namespace std;

int main()
{
    //1, 6, 12, 18, 24
    //1, 7, 19, 37, 61
    
    //6씩 증가함.
    int A;
    cin >> A;
    
    //배수를 저장할것, 총합을 저장할것 2개
    int layer = 1;
    int total = 1;
    while(A > total)
    {
        total += layer * 6;
        layer++;
    }
    cout << layer;
    
    
}