

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string prefix = strs[0];

        for (int i = 1; i < strs.Length; i++) {
            int limit = Math.Min(prefix.Length, strs[i].Length);
            int matchCount = 0;

            for (int j = 0; j < limit; j++) {
                if (prefix[j] == strs[i][j]) {
                    matchCount++;
                } else
                    break;
            }
            prefix = prefix.Substring(0, matchCount);
            if (prefix.Length == 0) {
                return "";
            }
        }

        return prefix;
    }
}