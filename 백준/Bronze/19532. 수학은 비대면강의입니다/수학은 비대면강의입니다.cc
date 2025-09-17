#include <stdio.h>
#include <iostream>
using namespace std;


int main()
{
    //연립방정식 x와 y를 구하는방법은?
    //양변을 곱해서 찾는다
    //1. x값 찾기
    //y를 없애기 위해서
    //ax+by = c 에는 e값을, dx+ey =f에는 b값을 곱해줌  
    //aex+bey = ec
    //dbx +bey = bf;
    //두개를 빼면?
    //aex-dbx = ec-bf;
    //(ae-db)x = ec-bf;
    //x = ec-bf / ae-db;
    //2. y값 찾기
    //x를 없애기 위해서
    //ax+by = c 에는 d값을, dx+ey=f에는 a값을 곱해줌
    //adx +bdy = cd;
    //adx + aey = af;
    //두개를 빼면?
    //bdy - aey = cd - af;
    //(bd - ae)y = cd - af;
    //y = cd-af / bd-ae;  양변에 마이너스 붙이면? -(cd-af) / -(bd-ae);
    //y = af-cd / ae-bd;
    //x를 구할때와 y를 구할때의 분모는 ae-bd로 같음
    
    int a,b,c,d,e,f;
    cin >> a >> b >> c >> d >> e >> f;
    int bunmo = a*e - b*d;
    
    int xValue = (e*c-b*f) / bunmo;
    int yValue = (a*f - c*d) / bunmo;
    
    cout << xValue << " " << yValue;
    
    
    
}