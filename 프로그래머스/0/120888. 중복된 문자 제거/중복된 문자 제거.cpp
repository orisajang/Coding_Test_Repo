#include <string>
#include <vector>

using namespace std;

string solution(string my_string) {
    string answer = "";
    int maxSize = 'z' - 'A' +1; // 10 - 5 = 5개
    int array[1000] = {0};
    
    for(int i=0; i< my_string.length(); i++)
    {
        int diffNumber = 'z' - my_string[i];
        if(array[diffNumber] == 0)
        {
            array[diffNumber] = 1;
            answer += my_string[i];
        }
    }
    
    return answer;
}