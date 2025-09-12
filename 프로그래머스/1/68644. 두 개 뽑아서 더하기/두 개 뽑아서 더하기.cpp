#include <string>
#include <vector>
#include <algorithm>
using namespace std;

vector<int> solution(vector<int> numbers) {
    vector<int> answer;
    //모든 sum을 array에 저장
    //정렬
    //중복 제거
    vector<int> sum;
    for(int i=0; i< numbers.size(); i++)
    {
        for(int j= i+1; j<numbers.size(); j++)
        {
            sum.push_back(numbers[i] + numbers[j]);
        }
    }
    sort(sum.begin(), sum.end());
    //중복 제거
    //처음에는 무조건넣음, 그다음부터 이전 위치와 같은지 비교
    for(int i=0; i<sum.size(); i++)
    {
        if(i==0) answer.push_back(sum[i]);
        else
        {
            if(sum[i] != sum[i-1]) answer.push_back(sum[i]);
        }
    }
    return answer;
}