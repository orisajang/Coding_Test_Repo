#include <string>
#include <vector>

using namespace std;

int solution(string my_string) {
    int answer = 0;
    string str = "";
    for(int i=0; i< my_string.length(); i++)
    {
        if('0' <= my_string[i] && my_string[i] <= '9')
        {
            str += my_string[i];
        }
        else
        {
            if(str != "")
            {
                answer += stoi(str); 
                str = "";
            }
        }
    }
    if(str!= "")
    {
        answer += stoi(str);
        str = "";
    }

    return answer;
}