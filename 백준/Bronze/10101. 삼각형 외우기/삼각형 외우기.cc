#include <stdio.h>
#include <iostream>
#include <map>

using namespace std;

int main()
{
    int angle[3];
    cin >> angle[0] >> angle[1] >> angle[2];

    int sum = angle[0] + angle[1] + angle[2];
    int count = 0;
    if (sum != 180) cout << "Error";
    else
    {
        int maxCount = 0;
        for(int i=0; i<3; i++)
        {
            int count = 0;
            for(int j=0; j<3; j++)
            {
                if(angle[i]==angle[j]) count++;
            }
            if(maxCount < count) maxCount = count;
        }
        if(maxCount ==3) cout << "Equilateral";
        else if(maxCount ==2) cout << "Isosceles";
        else cout << "Scalene";
    }
    
    
}