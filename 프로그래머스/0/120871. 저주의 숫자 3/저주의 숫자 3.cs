using System;

public class Solution {
    public int solution(int n) {
        int current = 0;
        for (int i = 1; i <= n; i++)
	    {
		    current += 1;
		    while(true)
		    {
		    	if(current % 3 ==0)
		    	{
		    		current += 1;
		    		continue;
		    	}
		    	string str = current.ToString();
		    	if(str.Contains("3"))
		    	{
		    		current += 1;
		    		continue;
		    	}
		    	break;
		    }
	    }
        return current;
    }
}