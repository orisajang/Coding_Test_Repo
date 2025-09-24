#include <string>
#include <vector>

using namespace std;

int solution(string my_string) {
    int answer = 0;
    int sum = 0;
    string str = "";
    bool isPlus = true;
    for(int i=0; i< my_string.length(); i++)
    {
        if('0' <= my_string[i] && my_string[i] <= '9')
        {
            str+= my_string[i];
        }
        else if(my_string[i] == '+' || my_string[i] == '-')
        {
            int k = stoi(str);
            if(!isPlus) k *= -1;
            sum += k;
            str = "";
            isPlus = (my_string[i] == '+') ? true : false;
        }
    }
    if(str != "")
    {
        int k = stoi(str);
        if(!isPlus) k *= -1;
        sum += k;
    }
    answer = sum;
    
    return answer;
}