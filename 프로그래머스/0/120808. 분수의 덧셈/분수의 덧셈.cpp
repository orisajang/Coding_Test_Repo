#include <string>
#include <vector>

using namespace std;

int gcd(int a , int b)
{
    while(b!= 0)
    {
        int buf = a%b;
        a= b;
        b = buf;
    }
    return a;
}

vector<int> solution(int numer1, int denom1, int numer2, int denom2) {
    vector<int> answer;
    //최소공배수를 사용한다
    int gcdNum = gcd(denom1, denom2); //최대공약수
    int lcmNum = denom1 * denom2 / gcdNum; //최소공배수
    
    int multiNum1 = lcmNum / denom1; // 2
    int multiNum2 = lcmNum / denom2; // 1
    
    int numerSum = (numer1 * multiNum1) + (numer2 * multiNum2);
    
    
    //분자와 분모가 나눠질수 있으므로
    int finalGcd = gcd(numerSum, lcmNum);
    numerSum /= finalGcd;
    lcmNum /= finalGcd;
    answer.push_back(numerSum);
    answer.push_back(lcmNum);
        
    return answer;
}