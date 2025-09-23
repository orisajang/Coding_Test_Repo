#include <string>
#include <vector>

using namespace std;

int gcd(int a,int b)
{
    while(b != 0)
    {
        int buf = a%b;
        a = b;
        b = buf;
    }
    return a;
}
int lcm(int a,int b)
{
    return a*b / gcd(a,b);
}

int solution(int n) {
    int answer = 0;
    int pan = 6; //한판에 6조각
    //1. 최소공배수로 처리
    answer = lcm(n,pan) / pan; // 1판 기준이므로 최소공배수에서 pan 을 또 나눔
    /*
    //2. 수동로직
    for(int i=1; i<101; i++)
    {
        int num = i*6; //30이라면?
        if(num % n == 0) return i;
    }
    */
    
    return answer;
}