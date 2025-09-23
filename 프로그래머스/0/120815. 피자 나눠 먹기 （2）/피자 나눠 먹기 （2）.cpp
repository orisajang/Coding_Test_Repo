#include <string>
#include <vector>

using namespace std;

int solution(int n) {
    int answer = 0;
    
    for(int i=1; i<101; i++)
    {
        int num = i*6; //30이라면?
        if(num % n == 0) return i;
    }
    
    return answer;
}