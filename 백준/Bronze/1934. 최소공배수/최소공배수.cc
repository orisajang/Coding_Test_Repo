#include <stdio.h>
#include <iostream>

using namespace std;

int gcd(int a, int b)
{
    while(b != 0)
    {
        int buf = a%b;
        a = b;
        b = buf;
    }
    return a;
}

int main()
{
    //최소공배수 : A*B / 최대공약수;
    //최대공약수 : 유클리드호제법(둘중하나가 0이될때까지 처리)
    int T;
    cin >> T;
    for(int i=0; i<T; i++)
    {
        int A,B;
        cin >> A >> B;
        int answer = A*B / gcd(A,B);
        cout << answer << "\n";
    }
    
}