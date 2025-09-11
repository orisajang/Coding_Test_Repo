#include <string>
#include <vector>

using namespace std;

int solution(vector<int> number) {
    int answer = 0;
    int sum = 0;
    for(int i=0; i<number.size()-2; i++)
    {
        int num1 = number[i];
        for(int j= i+1; j< number.size()- 1; j++)
        {
            int num2 = number[j];
            for(int k=j+1; k < number.size(); k++)
            {
                int num3 = number[k];
                if(num1+num2+num3 == 0) answer++;
            }
        }
    }
    
    
    return answer;
}