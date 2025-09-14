#include <string>
#include <vector>

using namespace std;

int solution(string s) {
    int answer = 0;
    string str = "";
    for(int i=0; i<s.length(); i++)
    {
        if('0' <= s[i] && s[i] <= '9')
        {
            str += s[i];
        }
        else
        {
            //영문 숫자에 따라서 if문 나열하기
            if(s[i] == 'z')
            {
                str+= '0';
                i+= 3; //다음으로 넘어감
            }
            else if(s[i] == 'o')
            {
                str += '1';
                i+= 2;
            }
            else if(s[i] == 't')
            {
                if(s[i+1] == 'w')
                {
                    str+='2';
                    i+= 2;
                }
                else if(s[i+1] == 'h')
                {
                    str+='3';
                    i+=4;
                }
            }
            else if(s[i] == 'f')
            {
                if(s[i+1] == 'o')
                {
                    str += '4';
                    i+=3;
                }
                else if(s[i+1] == 'i')
                {
                    str += '5';
                    i+=3;
                }
            }
            else if(s[i] == 's')
            {
                if(s[i+1] == 'i')
                {
                    str += '6';
                    i+=2;
                }
                else if(s[i+1 == 'e'])
                {
                    str +='7';
                    i+= 4;
                }
            }
            else if(s[i] == 'e')
            {
                str +='8';
                i+=4;
            }
            else if(s[i] == 'n')
            {
                str +='9';
                i+=3;
                
            }
        }
    }
    
    answer = stoi(str);
    
    return answer;
}