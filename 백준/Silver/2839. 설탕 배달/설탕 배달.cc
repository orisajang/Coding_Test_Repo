#include <stdio.h>
#include <iostream>

using namespace std;

int main()
{
    int N;
    cin >> N;
    
    //3kg와 5kg
    //5kg로 나누었을때 몫을 구한다 . 최대 3이라면?
    //5kg포대가 0일때, 1일때,2일때, 3일때를 뺀다음에?
    //3kg로 나누었을때 몇개가 나오는지. (정확하게 0이어야함)
    int mok = N / 5;
    int count = -1;
    
    for(int i=0; i<= mok; i++)
    {
        int num = N - (i * 5);
        if(num % 3 == 0)
        {
            int result = (num / 3) + i;
            if(count ==-1)
            {
                count = result;
            }
            else if(count > result) 
            {
                count = result;
            }
        }
    }
    cout << count;
    
}