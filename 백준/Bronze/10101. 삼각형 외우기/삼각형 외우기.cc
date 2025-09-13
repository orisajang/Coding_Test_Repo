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
        map<int, int> map;
        int arraySize = sizeof(angle) / sizeof(angle[0]);
        for (int i = 0; i < arraySize; i++)
        {
            map[angle[i]]++;
        }
        bool bFind = false;
        for (auto i : map)
        {
            if (i.second == 3)
            {
                cout << "Equilateral";
                bFind = true;
            }
            else if (i.second == 2)
            {
                cout << "Isosceles";
                bFind = true;
            }
        }
        if (!bFind) cout << "Scalene";
    }
    
    
}