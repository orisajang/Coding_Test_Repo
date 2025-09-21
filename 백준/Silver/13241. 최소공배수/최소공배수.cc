#include <stdio.h>
#include <iostream>
using namespace std;

int gcd(int A, int B)
{
    while(B != 0)
    {
        int buf = A%B;
        A = B;
        B = buf;
    }
    return A;
}

int main()
{
    long long A,B;
    cin >> A >> B;
    cout << A*B / gcd(A,B);
}