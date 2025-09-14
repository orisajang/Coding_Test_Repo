#include <stdio.h>
#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int main()
{
    vector<int> vec(5,0);
    int sum = 0;
    int count = vec.size();
    for(int i=0; i< count; i++)
    {
        cin >> vec[i];
        sum += vec[i];
    }
    sort(vec.begin(),vec.end());
    int average = sum / count;
    cout << average << "\n" << vec[2];
    
}