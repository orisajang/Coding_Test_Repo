#include <stdio.h>
#include <iostream>
#include <algorithm>

using namespace std;

int main()
{
    int arraySize = 0;
    vector<int> vec;
    int findNum = 0;
    
    cin >> arraySize;
    for(int i=0; i<arraySize; i++)
    {
        int k = 0;
        cin>> k;
        vec.push_back(k);
    }
    cin >> findNum;
    
    int left = 0;
    int right = vec.size()-1;
    int count =0;
    sort(vec.begin(),vec.end());
    while(left < right)
    {
        int sum = vec[left] + vec[right];
        if( sum == findNum)
        {
            count++;
            left++;
            right--;
        }
        else if(sum < findNum) left++;
        else if(sum > findNum) right--;
    }
    cout << count;
}