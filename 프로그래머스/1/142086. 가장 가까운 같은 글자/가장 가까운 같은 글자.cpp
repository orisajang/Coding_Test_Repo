#include <string>
#include <vector>

using namespace std;

vector<int> solution(string s) {
    vector<int> answer;
    vector<int> alpabet(26,-1);
    
    for(int i=0; i<s.size(); i++)
    {
        int num = s[i] - 'a';
        if(alpabet[num] != -1)
        {
            int diff = i - alpabet[num];
            answer.push_back(diff);
            alpabet[num] = i;
        }
        else
        {
            alpabet[num] = i;
            answer.push_back(-1);
        }
    }
    
    return answer;
}