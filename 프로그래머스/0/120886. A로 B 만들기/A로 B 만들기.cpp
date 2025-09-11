#include <string>
#include <vector>

using namespace std;

int solution(string before, string after) {
    int answer = 0;
    //알파벳들의 갯수가 같으면? 해당단어를 만들수 있다
    //알파벳 배열 만들어서 갯수가 같으면 통과하게하거나,
    //정렬쓴게 before과 after이 같으면 통과
    //오름차순, 내림차순 정렬을 사용
    
    for(int i=0; i< before.length(); i++)
    {
        for(int j=0; j< before.length() -1 - i; j++)
        {
            //대소 비교 
            int before_number1 = before[j] - 'a';
            int before_number2 = before[j+1] - 'a';
            int after_number1 = after[j] - 'a';
            int after_number2 = after[j+1] - 'a';
            
            if(before_number1 > before_number2)
            {
                char buf = before[j];
                before[j] = before[j+1];
                before[j+1] = buf;
            }
            if(after_number1 > after_number2)
            {
                char buf = after[j];
                after[j] = after[j+1];
                after[j+1] = buf;
            }
        }
    }
    if(before == after) answer = 1;
    else answer = 0;
    
    return answer;
}