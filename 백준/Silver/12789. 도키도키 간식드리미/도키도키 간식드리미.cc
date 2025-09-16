#include <stdio.h>
#include <iostream>
#include <stack>
#include <queue>
using namespace std;
int main()
{
    int studentCount;
    cin >> studentCount;
    int num = 1;
    stack<int> stack1;
    queue<int> queue1;
    for(int i=0; i< studentCount; i++)
    {
        int k;
        cin >> k;
        queue1.push(k);
    }
    bool bOk = true;
    while(!queue1.empty() || !stack1.empty())
    {
        if(!queue1.empty() && queue1.front() == num)
        {
            queue1.pop();
            num++;
        }
        else if(!stack1.empty() && stack1.top() == num)
        {
            stack1.pop();
            num++;
        }
        else if(!queue1.empty())
        {
            int buf = queue1.front();
            queue1.pop();
            stack1.push(buf);
        }
        else if(queue1.empty() && stack1.top() != num)
        {
            bOk = false;
            cout << "Sad";
            break;
        }
        
    }
    if(bOk) cout << "Nice";
    
    
    
}