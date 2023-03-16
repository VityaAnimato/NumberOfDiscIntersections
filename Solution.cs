using System;

class Solution 
{
    public int solution(int[] arr) {
        long[] lKth = new long[arr.Length];
        long[] rJth = new long[arr.Length];
        
        for (int i = 0; i < arr.Length; i++) {
            lKth[i] = (long) i - arr[i];
            rJth[i] = (long) i + arr[i];
        }
        
        Array.Sort(lKth);
        Array.Sort(rJth);
        
        int cnt = 0;
        for (int i = 0; i < arr.Length - 1; i++) {
            for (int j = i + 1; j < arr.Length && rJth[i] >= lKth[j]; j++) {
                cnt++;
                
                if (cnt > 10000000)
                    return -1;
            }
        }
        
        return cnt;
    }
}
