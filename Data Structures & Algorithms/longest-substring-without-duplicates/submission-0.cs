public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int left = 0;
        int result = 0;
        HashSet<char> set = new HashSet<char>();

        for (int right = 0; right < s.Length; right++) {
            while (set.Contains(s[right])) {
                set.Remove(s[left]);
                left++;
            }

            set.Add(s[right]);

            result = Math.Max(result, right - left + 1);
        }

        return result;
    }
}