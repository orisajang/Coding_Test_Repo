using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] topping) {
        int n = topping.Length;
        if (n <= 1) return 0;

        // 오른쪽에 있는 토핑들의 빈도수 카운트
        Dictionary<int, int> rightCount = new Dictionary<int, int>();
        foreach (int t in topping) {
            if (rightCount.ContainsKey(t)) rightCount[t]++;
            else rightCount[t] = 1;
        }

        HashSet<int> leftSet = new HashSet<int>(); // 왼쪽에 존재하는 토핑 종류
        int answer = 0;
        int rightUnique = rightCount.Count;

        for (int i = 0; i < n; i++) {
            int cur = topping[i];

            // 왼쪽에 추가
            leftSet.Add(cur);

            // 오른쪽에서 하나 제거
            rightCount[cur]--;
            if (rightCount[cur] == 0) {
                rightCount.Remove(cur);
                rightUnique--;
            }

            // 잘라지는 위치는 i까지가 왼쪽, i+1부터 오른쪽
            // 오른쪽이 비어있으면 더 이상 분할 불가 -> (i == n-1) 시엔 검사하지 않음
            if (i < n - 1 && leftSet.Count == rightUnique) {
                answer++;
            }
        }

        return answer;
    }
}