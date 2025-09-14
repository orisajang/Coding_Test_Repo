#include<stdio.h>
#include<iostream>
#include<vector>

using namespace std;

int main()
{
    int N,M;
    cin >> N >> M;
    vector<int> num;
    for(int i=0; i<N; i++)
    {
        int k;
        cin >> k;
        num.push_back(k);
    }
    int max = 0;
    for(int i=0; i<N; i++){
        for(int j=0; j<N; j++){
            for(int k=0; k<N; k++){
                if(i==j || i==k || j==k) continue;
                else
                {
                    //3개의 수를 더한 값이 M을 넘지않고, 그 값이 max보다 크면
                    int sum = num[i]+num[j]+num[k];
                    if(sum <= M && sum > max) max = sum;
                }
            }
        }
    }
    cout << max;
    
}