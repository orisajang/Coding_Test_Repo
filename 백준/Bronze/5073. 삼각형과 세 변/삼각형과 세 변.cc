#include <stdio.h>
#include <iostream>
#include <algorithm>
using namespace std;

int main()
{
    int num[3];
    
    while(true)
    {
        int inputMax = 0;
        int index = 0;
        int sum = 0;
        for(int i=0; i<3; i++)
        {
            cin >> num[i];
            if(inputMax < num[i])
            {
                inputMax = num[i];
                index = i;
            }
            sum += num[i];
        }
        if(num[0] == 0 && num[1] ==0 && num[2] ==0) break;
        sum -= num[index];
        if(num[index] >= sum) 
        {
            cout<< "Invalid"<<"\n";
        }
        else
        {
            int maxCount =0;
            for(int i=0; i<3; i++)
            {
                int count = 0;
                for(int j=0; j<3; j++)
                {
                    if(num[i] == num[j]) count++;
                }
                if(maxCount < count) maxCount = count;
            }
        
            if(maxCount == 3) cout << "Equilateral" << "\n";
            else if(maxCount == 2) cout << "Isosceles" << "\n";
            else cout << "Scalene" << "\n";
        }
        
    }
}