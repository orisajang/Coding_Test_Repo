#include <string>
#include <vector>

using namespace std;

int solution(int M, int N) {
    int answer = 0;
    
    //y축의 길이 -1만큼 자른 숫자 answer에 더하고 (갯수: 자른횟수+1)
    //(y축에서 나온갯수) *  x축의 길이 -1 만큼 자름
    //if(M !=1 && N != 1) 
    int count = M;
    answer += M-1;
    //자른것으로 y축 계산
    answer += (count * (N-1));
    
    
    return answer;
}