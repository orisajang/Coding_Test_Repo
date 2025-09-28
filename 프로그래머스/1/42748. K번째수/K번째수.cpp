#include <string>
#include <vector>

using namespace std;

void mySort(vector<int>& array) //버블정렬
{
    for(int i=0; i< array.size()-1; i++)
    {
        for(int j=0; j<array.size()-1 -i; j++)
        {
            if(array[j] > array[j+1])
            {
                int buf = array[j];
                array[j] = array[j+1];
                array[j+1] = buf;
            }
        }
    }
}

vector<int> solution(vector<int> array, vector<vector<int>> commands) {
    vector<int> answer;
    for(int index = 0; index < commands.size(); index++)
    {
        vector<int> nowCommand = commands[index];
        vector<int> newCommand;
        int i = nowCommand[0]; //2
        int j = nowCommand[1]; //5
        int k = nowCommand[2]; //3
        for(int idx = i-1; idx <= j-1; idx++)
        {
            newCommand.push_back(array[idx]);
        }
        mySort(newCommand);
        answer.push_back(newCommand[k-1]);
    }
    return answer;
}