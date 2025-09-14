#include <stdio.h>
#include <iostream>
#include <vector>
using namespace std;

int main()
{
    int N;
    cin >> N;
    vector<int> vec;
    for(int i=0; i<N; i++)
    {
        int k;
        cin >> k;
        vec.push_back(k);
    }
    
    for(int i=0; i<vec.size()-1; i++)
    {
        for(int j=0; j<vec.size()-1 -i; j++)
        {
            if(vec[j] > vec[j+1])
            {
                int buf = vec[j];
                vec[j] = vec[j+1];
                vec[j+1] = buf;
            }
        }
    }
    
    for(int i=0; i<vec.size(); i++)
    {
        cout << vec[i] << "\n";
    }
    
}