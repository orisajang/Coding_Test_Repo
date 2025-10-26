using System.Text;
public class Solution {
    public string solution(string s) {
        string answer = "";
        StringBuilder sb = new StringBuilder();
        //첫 문자가 알파벳이고 && 공백 이후 문자일때 체크
        bool isSpaceAfterChar = true;
        
        for(int i=0; i<s.Length; i++)
        {
            char ch = s[i];
            int diffValue = 'a' - 'A';
            if(isSpaceAfterChar == true)
            {
                if('a' <= ch && ch <= 'z')
                {
                    ch = (char)(ch - diffValue);
                }
            }
            else
            {
                if('A' <= s[i] && s[i] <= 'Z')
                {
                    ch = (char)(ch + diffValue);
                }
                
            }
            sb.Append(ch);
            isSpaceAfterChar = false;
            if(s[i] == ' ') isSpaceAfterChar = true;
        }
        
        
        answer = sb.ToString();
        
        return answer;
    }
}