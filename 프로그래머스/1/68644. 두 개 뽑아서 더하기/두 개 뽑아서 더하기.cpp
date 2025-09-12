#include <string>
#include <vector>
#include <algorithm>
using namespace std;

vector<int> solution(vector<int> numbers) {
    vector<int> answer;
    //모든 sum을 array에 저장
    //정렬
    //중복 제거
    vector<int> sumArray;
    for(int i=0; i<numbers.size(); i++)
    {
        for(int j=i+1; j<numbers.size(); j++)
        {
            sumArray.push_back(numbers[i] + numbers[j]);
        }
    }
    sort(sumArray.begin(),sumArray.end());
    /*
    sumArray.erase(unique(sumArray.begin(),sumArray.end()),sumArray.end());
    answer = sumArray;
    */
    
    for(int i=0; i< sumArray.size(); i++)
    {
        if(i==0)
        {
            answer.push_back(sumArray[i]);
        }
        else if(sumArray[i]  != sumArray[i-1] )
        {
            answer.push_back(sumArray[i]);
        }
    }
    
    return answer;
}