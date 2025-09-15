#include <stdio.h>
#include <iostream>
#include <stack>


using namespace std;

int main()
{
    int K; 
    cin >> K;
    
    stack<int> st;
    long long sum = 0;
    for(int i=0; i<K; i++)
    {
        int num;
        cin >> num;
        if(num == 0) 
        {
            sum -= st.top();
            st.pop();
        }
        else
        {
            sum+= num; 
            st.push(num);
        }
    }
    cout << sum;
}