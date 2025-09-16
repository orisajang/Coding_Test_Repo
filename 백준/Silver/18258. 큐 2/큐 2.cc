#include <stdio.h>
#include <iostream>
#include <queue>
using namespace std;

int main()
{
    ios_base::sync_with_stdio(false);
    cin.tie(NULL);
    cout.tie(NULL);
    
    int N;
    cin >> N;
    queue<int> que;
    
    for(int i=0; i< N; i++)
    {
        string str;
        cin >> str;
        
        if(str == "push")
        {
            int num;
            cin >> num;
            que.push(num);
        }
        else if(str == "pop")
        {
            if(que.empty()) cout << "-1" << "\n";
            else
            {
                cout<< que.front() << "\n";
                que.pop();
            }
        }
        else if(str == "size")
        {
            cout << que.size() << "\n";
        }
        else if(str == "empty")
        {
            if(que.empty()) cout << "1" << "\n";
            else cout << "0" << "\n";
        }
        else if(str == "front")
        {
            if(que.empty()) cout << "-1" << "\n";
            else cout << que.front() << "\n";
        }
        else if(str == "back")
        {
            if(que.empty()) cout << "-1" << "\n";
            else cout << que.back() << "\n";
        }
        
    }
    
}