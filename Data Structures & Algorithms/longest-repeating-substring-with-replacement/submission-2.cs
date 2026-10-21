public class Solution {
    public int CharacterReplacement(string s, int k) {
        int left = 0;
        var count = new int[26];
        int maxFreq = 0;
        int result = 0;
        int windowLength = 0;
        int replacementsNeeded = 0;
        for (int right = 0; right < s.Length; right++) {
            count[s[right] - 'A']++;
            maxFreq = Math.Max(maxFreq, count[s[right] - 'A']);
            windowLength = right - left + 1;
            replacementsNeeded = windowLength - maxFreq;

            if (replacementsNeeded > k) {
                count[s[left] - 'A']--;
                left++;
            }

            result = Math.Max(result, right - left + 1);
        }

        return result;
    }
}