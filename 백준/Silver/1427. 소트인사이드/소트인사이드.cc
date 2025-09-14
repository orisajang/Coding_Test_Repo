#include <stdio.h>
#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;
int main()
{
    ios_base::sync_with_stdio(false);
    cin.tie(NULL);
    cout.tie(NULL);
    
    int N;
    cin >> N;
    vector<int> vec;
    while(N != 0)
    {
        int num = N % 10;
        vec.push_back(num);
        N /= 10;
    }
    sort(vec.begin(),vec.end(),greater<int>());
    for(int i=0; i<vec.size(); i++)
    {
        cout << vec[i];
    }
    
}