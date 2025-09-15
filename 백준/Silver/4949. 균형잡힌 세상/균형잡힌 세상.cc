#include <stdio.h>
#include <iostream>
#include <string>
#include <stack>

using namespace std;

int main()
{
    //stack을 만들음. pop을 하기전에 top에 다른 형태의 괄호 시작이 들어있거나
    //stack이 비어있으면 false
    while(true)
    {
        string str;
        getline(cin, str);
        if(str == ".") break;
        
        stack<char> st;
        bool bBalance = true;
        for(int i=0; i<str.length(); i++)
        {
            if(str[i] == '(' || str[i] == '[')
            {
                st.push(str[i]);
            }
            else if(str[i] == ')' || str[i] == ']')
            {
                if(st.empty()) 
                {
                    bBalance = false;
                    break;
                }
                char c = st.top();
                
                if(str[i] == ')' && c != '(')
                {
                    bBalance = false;
                    break;
                }
                else if(str[i]==']' && c!= '[')
                {
                    bBalance = false;
                    break;
                }
                st.pop();
            }
        }
        if(bBalance && st.empty()) cout << "yes"<< "\n";
        else cout << "no"<< "\n";
        
    }
}
