#include <stdio.h>
#include <iostream>
#include <queue>

using namespace std;

int main()
{
    int nSize;
    cin >> nSize;
    queue<int> que;
    
    while(true)
    {
        int N;
        cin >> N;
        if(N == -1) break;
        else if(N == 0)
        {
            if(!que.empty()) que.pop();
        }
        else
        {
            if(que.size() < nSize) que.push(N);
        }
    }
    
    while(!que.empty())
    {
        cout << que.front();
        que.pop();
        if(!que.empty()) cout << " ";
    }
}