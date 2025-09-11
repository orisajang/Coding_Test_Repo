#include <string>
#include <vector>

using namespace std;

int solution(string t, string p) {
    int answer = 0;
    
    for(int i=0; i< t.length(); i++)
    {
        string strSub = "";
        if( p.length() + i > t.length() ) break;
        else
        {
            for(int j=0; j< p.length(); j++)
            {
                strSub += t[i+j];
            }
            if(stoll(strSub) <= stoll(p)) answer++;
        }
    }
    
    return answer;
}