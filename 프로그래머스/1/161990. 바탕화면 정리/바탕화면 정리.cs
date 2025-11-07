using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string[] wallpaper) {
        int[] answer = new int[4];
        //시작점이랑 , 끝점을 알아야함.., x랑 y를 알면 계산을 할수있음.
        //int minY = 
        List<List<int>> files = new List<List<int>>();
        
        for(int i=0; i< wallpaper.Length; i++)
        {
            files.Add(new List<int>());
        }
        
        for(int x=0; x< wallpaper.Length; x++)
        {
            for(int y = 0; y< wallpaper[x].Length; y++)
            {
                if(wallpaper[x][y] == '#')
                {
                    files[x].Add(y);
                }
            }
        }
        int findX = 51;
        int findY = 51;
        int xFindMax = 0;
        int yFindMax = 0;
        for(int x=0; x<files.Count; x++)
        {
            for(int y=0; y<files[x].Count; y++)
            {
                if(findX > x) findX = x;
                if(findY > files[x][y]) findY = files[x][y];
                if(xFindMax <  x) xFindMax = x;
                if(yFindMax < files[x][y]) yFindMax = files[x][y];
            }
        }

        answer[0] = findX;
        answer[1] = findY;
        answer[2] = xFindMax+1;
        answer[3] = yFindMax+1;
        
        return answer;
    }
}