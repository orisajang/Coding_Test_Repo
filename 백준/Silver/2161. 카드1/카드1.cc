#include <stdio.h>
#include <iostream>
#include <queue>
using namespace std;
int main()
{
    int N;
    cin >> N;
    
    queue<int> que;
    for(int i=1; i<= N; i++)
    {
        que.push(i);
    }
    while(!que.empty())
    {
        cout << que.front();
        que.pop();
        
        if(!que.empty())
        {
            cout << " ";
            int num = que.front();
            que.push(num);
            que.pop();
        }
    }
    
}