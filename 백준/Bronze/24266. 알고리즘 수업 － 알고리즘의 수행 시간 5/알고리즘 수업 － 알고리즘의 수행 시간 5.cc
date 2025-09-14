#include <stdio.h>
#include <iostream>

using namespace std;

int main()
{
    long long n;        //n은 최대 50만, 50만*50만*50만 이므로 int로는안됨
    cin >> n;
    //for문3개, 입력 -> n*n*n
    //f(n) = n^3 = 최고차항 3
    cout << n*n*n << "\n";
    cout << 3;
}