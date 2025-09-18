#include <string>
#include <vector>
#include <algorithm>

using namespace std;

int absFunc(int num)
{
    if(num < 0) num *= -1;
    return num;
}

int solution(vector<int> array, int n) {
    int answer = 0;

    sort(array.begin(),array.end());
    
    int min = absFunc(array[0] - n);
    int minIndex = 0;
    
    for(int i=1; i<array.size(); i++)
    {
        int subValue = absFunc(array[i] - n);
        if(subValue < min)
        {
            min = subValue;
            minIndex = i;
        }
    }
    answer = array[minIndex];
    
    return answer;
}