#include <string>
#include <vector>

using namespace std;

int solution(string s) {
    int answer = 0;
    
    int sum = 0;
    int beforeNum = 0;
    string str = "";
    
    for(int i=0; i<s.length(); i++)
    {   
        if(s[i] == ' ')
        {
            if(str != "")
            {
                int num = stoi(str);
                sum += num;
                beforeNum = num;
                str = "";
            }
        }
        else if(s[i] == 'Z')
        {
            sum -= beforeNum;
        }
        else
        {
            str += s[i];
        }
    }
    
    if(str != "") 
    {
        int num = stoi(str);
        sum += num;
        str = "";
    }
    
    answer = sum;
    return answer;
}