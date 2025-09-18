#include <stdio.h>
#include <iostream>
#include <queue>
using namespace std;

int main()
{
    //1 ~ N까지 계속 반복
    //한사람이 제거되면 남은사람이
    int N,K;
    cin >> N >> K;
    queue<int> que;
    for(int i=1; i<= N; i++)
    {
        que.push(i);
    }
    
    cout << '<';
    
    while(!que.empty())
    {
        for(int i=0; i< K-1; i++)
        {
            int num = que.front();
            que.push(num);
            que.pop();
        }
        cout << que.front();
        que.pop();
        if(!que.empty()) cout << ", ";
        else cout << '>';
    } 
}