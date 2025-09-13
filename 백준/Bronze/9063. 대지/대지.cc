#include <stdio.h>
#include <iostream>
#include <algorithm>
using namespace std;

int main()
{
    int N;
    cin >> N;
    int xMax = 0;
    int xMin = 0;
    int yMax = 0;
    int yMin = 0;
    
    for(int i=0; i<N; i++)
    {
        int xPos,yPos;
        cin >> xPos >> yPos;
        if(i==0)
        {
            xMax = xPos;
            xMin = xPos;
            yMax = yPos;
            yMin = yPos;
        }
        else
        {
            xMax = max(xMax,xPos);
            xMin = min(xMin,xPos);
            yMax = max(yMax,yPos);
            yMin = min(yMin,yPos);
        }
    }
    
    int xResult = xMax - xMin;
    int yResult = yMax - yMin;
    
    cout << xResult * yResult;
    
}