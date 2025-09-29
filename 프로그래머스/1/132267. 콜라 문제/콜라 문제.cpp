#include <string>
#include <vector>

using namespace std;

int solution(int a, int b, int n) {
    int answer = 0;
    int count = n;
    while((count / a) !=0)
    { 
        int buf1 = (count / a)*b; 
        answer += buf1;  
        count = (count %a) +  buf1; 
    }
    
    return answer;
}