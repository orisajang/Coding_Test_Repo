#include <string>
#include <vector>
#include <algorithm>
using namespace std;

int solution(vector<vector<int>> sizes) {
    int answer = 0;
    //명함이 회전할 수 있으므로 가장 큰변을 가로, 짧은면을 세로로 정렬
    int maxW =0;
    int maxH =0;
    
    for(int i=0; i<sizes.size(); i++)
    {
        int currentW =  max(sizes[i][0], sizes[i][1]);
        int currentH =  min(sizes[i][0], sizes[i][1]);
        maxW = max(maxW,currentW);
        maxH = max(maxH,currentH);
    }
    answer = maxW * maxH;
    
    return answer;
}
