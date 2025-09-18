#include <stdio.h>
#include <iostream>
#include <deque>
#include <vector>
using namespace std;

int main()
{
    int N;
    cin >> N;
    vector<int> vec(N);
    deque<int> deq;
    for(int i=0; i<N; i++)
    {
        cin >> vec[i];
        deq.push_back(i);
    }
    //dequeue선언 및 vec위치찾아서 왼쪽이나 오른쪽 이동
    //첫번째는 0번째위치의 숫자만큼 이동
    int moveValue = vec[0];
    
    cout << "1 ";
    deq.pop_front();
    
    while(!deq.empty())
    {
        if(moveValue > 0)
        {
            for(int i=0; i< moveValue-1; i++)
            {
                int num = deq.front();
                deq.push_back(num);
                deq.pop_front();
            }
            int buf1 = deq.front(); //
            moveValue = vec[buf1];
            cout << (buf1 +1);
            deq.pop_front();
            
        }
        else if(moveValue < 0)
        {
            moveValue *= -1;
            for(int i=0; i< moveValue-1; i++)
            {
                int num2 = deq.back();
                deq.push_front(num2);
                deq.pop_back();
            }
            int buf2 = deq.back();
            moveValue = vec[buf2];
            cout << (buf2 +1);
            deq.pop_back();
        }
        if(!deq.empty()) cout << " ";
    }
}