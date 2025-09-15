#include <stdio.h>
#include <iostream>
#include <stack>

using namespace std;

int main()
{
    ios_base::sync_with_stdio(false);
    cin.tie(NULL);
    cout.tie(NULL);
    stack<int> stackArray;
    int n;
    cin >> n;
    for(int i=0; i<n; i++)
    {
        int order;
        cin >> order;
        switch(order)
        {
            case 1:
                int num;
                cin >> num;
                stackArray.push(num);
                break;
            case 2:
                if(stackArray.empty()) cout << "-1" << "\n";
                else
                {
                    int buf = stackArray.top();
                    cout << buf << "\n";
                    stackArray.pop();
                }
                break;
            case 3:
                cout<< stackArray.size() << "\n";
                break;
            case 4:
                if(stackArray.empty()) cout << "1" << "\n";
                else cout << "0" << "\n";
                break;
            case 5:
                if(stackArray.empty()) cout << "-1" << "\n";
                else cout << stackArray.top() << "\n";
                break;
                
        }
    }
    
    
}