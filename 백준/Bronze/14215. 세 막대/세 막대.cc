#include <stdio.h>
#include <iostream>
#include <algorithm>

using namespace std;

int main()
{
    int a,b,c;
    cin >>a>>b>>c;
    
    //삼각형 큰수1개가 나머지2개수의 합과 같으면 안된다.
    //크면 무조건 작은수로 고정시키기
    //41 + 16 = 57, 56이 됨;
    //57 + 56 = 113;
    int numMax = max(max(a,b),c);
    int diffsum = (a+b+c) - numMax;
    if(diffsum <= numMax)
    {
        numMax = diffsum-1;
    }
    cout << diffsum + numMax;
    
}