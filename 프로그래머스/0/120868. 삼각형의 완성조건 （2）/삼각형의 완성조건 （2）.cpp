#include <string>
#include <vector>

using namespace std;

int findMax(int a, int b)
{
    return (a > b) ? a : b;
}

int solution(vector<int> sides) {
    int answer = 0;
    //for문으로 1부터 돌리고 3개의 값중에서 max 찾고 index지정, 나머지2개를 더하고 넘는지 확인
    int length = sides[0] + sides[1];
    for(int i=1; i<= length; i++)
    {
        vector<int> vec;
        vec.push_back(sides[0]);
        vec.push_back(sides[1]);
        vec.push_back(i);
        int max = findMax(findMax(sides[0],sides[1]),i);
        bool isFindMax = false;
        int sum = 0;
        for(int j=0; j<vec.size(); j++)
        {
            if(isFindMax == false && vec[j] == max){
                isFindMax = true;
                continue;
            }
            sum += vec[j];
        }
        if(sum > max) answer++;
    }
    
    return answer;
}