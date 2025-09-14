#include <stdio.h>
#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int main()
{
    int N,K;
    cin >> N >> K;
    vector<int> vec(N,0);
    for(int i=0; i<N; i++)
    {
        cin >> vec[i];
    }
    sort(vec.begin(),vec.end(),greater<int>());
    cout << vec[K-1];
}