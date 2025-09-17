#include <stdio.h>
#include <iostream>
#include <string>
using namespace std;

int main()
{
    int N;
    cin >> N;
    
    int count = 0;
    int startNum = 665;
    while(count < N)
    {
        startNum++;
        string str = to_string(startNum);
        int continueSix = 0; //6이 3번연속 나오면 
        bool bContinueNumber = false;
        for(int i=0; i< str.length(); i++)
        {
            if(str[i] == '6') continueSix++;
            else continueSix = 0;
            
            if(continueSix == 3) 
            {
                bContinueNumber = true;
                break;
            }
        }
        if(bContinueNumber) count++;
    }
    cout << startNum;
    
    
}