using System;
using System.Collections.Generic;

public class Solution {
    public void Sort(List<int> list)
    {
        for(int i=0; i< list.Count-1; i++ )
        {
            for(int j=0; j<list.Count-1- i; j++)
            {
                if(list[j] < list[j+1])
                {
                    int buf = list[j];
                    list[j] = list[j+1];
                    list[j+1] = buf;
                }
            }
        }
    }
    public int[] solution(int k, int[] score) {
        int count = score.Length;
        int[] answer = new int[count];
        List<int> array = new List<int>();
        for(int i=0; i<count; i++)
        {
            if(i< k)
            {
                array.Add(score[i]);
                Sort(array);
            }
            else
            {
                if(array[k-1] < score[i])
                {
                    array[k-1] = score[i];
                    Sort(array);
                }
            }
            int arrayCount = array.Count;
            answer[i] = array[arrayCount-1];
        }
        return answer;
    }
}