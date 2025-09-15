#include <stdio.h>
#include <iostream>
#include <stack>
#include <string>
using namespace std;

int main()
{
    int N;
    cin >> N;
    
    
    //문자가 '('라면 넣음. ')'라면 뺌. 수가 부족하면? NO 출력
    for(int i=0; i<N; i++)
    {
        stack<char> st;
        string str;
        cin >> str;
        bool bVps = true;
        for(int j=0; j< str.length(); j++)
        {
            if(str[j] == '(')
            {
                st.push(str[j]);
            }
            else if(str[j] == ')')
            {
                if(st.empty() || st.top() != '(')
                {
                    bVps = false;
                    break;
                }
                else
                {
                    st.pop();
                }
            }
        }
        if(bVps && st.empty()) cout << "YES" << "\n";
        else cout << "NO"<< "\n";
        
    }
}