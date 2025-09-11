#include <string>
#include <vector>

using namespace std;

int gcd(int a, int b)
{
    while(b != 0)
    {
        int buf = a % b;
        a = b;
        b = buf;
    }
    return a;
}

int lcm(int a, int b)
{
    return a /gcd(a,b) * b ; 
}

vector<int> solution(int n, int m) {
    vector<int> answer;
    
    //최대공약수
    int numberGcd = gcd(n,m);
    answer.push_back(numberGcd);
    //최소공배수
    int gongBasu = lcm(n,m);
    answer.push_back(gongBasu);
    //함수 안쓰고 직접구현
    /*
    int max = n > m ? n:m;
    int limit = n*m;
    int gongBasu = 0;
    for(int i=max ; i<=limit; i++ )
    {
        if(i % n ==0 && i % m == 0) 
        {
            gongBasu = i;
            answer.push_back(gongBasu);
            break;
        }
    }
    */
    return answer;
}