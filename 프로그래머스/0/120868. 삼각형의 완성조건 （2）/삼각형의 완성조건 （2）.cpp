#include <string>
#include <vector>
#include <cmath>

using namespace std;

int solution(vector<int> sides) {
    int answer = 0;
    //삼각형의 세변의 길이는 두변의 합이 나머지보다 커야함
    //두변이 주어졌을때 c가 될 수 있는 정수의 개수
    //1) c가 가장크다면?
    //a+b > c , c가 될수있는 최대값은 (a+b-1)
    //2) c가 가장 큰값이 아니라면?
    //a+c > b, c > b-a
    //b+c > a, c > a-b
    //a가 큰경우와 b가 큰경우가 존재, 즉
    //c가 b-a일수도있고, a-b일수도 있기때문에 절대값을 씌워줌
    //c > |a-b|, c가 될수있는 최대값은 |a-b|+1;
    //즉 c의 범위는?
    //|a-b|+1 <= c <=(a+b-1) 
    //정수 갯수는? (최대값+1 - 최소값)
    //((a+b-1) +1) - (|a-b|+1)  ; //+1은 정수끝부분 포함해야해서
    
    int a = sides[0];
    int b = sides[1];
    int minVal = abs(a-b)+1;
    int maxVal = a+b -1;
    
    answer = (maxVal - minVal) +1;
    
    
    return answer;
}