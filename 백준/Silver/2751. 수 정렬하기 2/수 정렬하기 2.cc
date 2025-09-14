#include <stdio.h>
#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int main()
{
    int N;
    cin >> N;
    vector<int> vec(N,0);
    
    for(int i=0; i<N; i++)
    {
        cin >>vec[i];
    }
    
    sort(vec.begin(),vec.end());
    for(int i=0; i<N; i++)
    {
        cout << vec[i];
        if(i != N-1) cout << "\n";
    }
    
}