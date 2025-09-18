#include <string>
#include <vector>

using namespace std;

int solution(int n) {
    int answer = 0;
    
    int multiNum = 1;
    int sum = 1;
    while(true)
    {
        //1*2*3*4*5 => 
        sum *= multiNum;
        if(sum == n)
        {
            break;
        }
        else if(sum > n)
        {
            multiNum -= 1;
            break;
        }
        multiNum++;
    }
    
    answer = multiNum;
    return answer;
}