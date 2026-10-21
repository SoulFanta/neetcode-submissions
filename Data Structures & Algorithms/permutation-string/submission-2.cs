public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int lenghtS1 = s1.Length;

        var countS1 = new int[26];
        var countWindow = new int[26];

        if (s1.Length > s2.Length) {
            return false;
        }

        for (int i = 0; i < lenghtS1; i++) {
            countS1[s1[i] - 'a']++;
            countWindow[s2[i] - 'a']++;
        }
        if (AreEqual(countS1, countWindow)) {
            return true;
        }

        for (int right = lenghtS1; right < s2.Length; right++) {
            countWindow[s2[right] - 'a']++;
            int left = right - lenghtS1;
            countWindow[s2[left] - 'a']--;

            if (AreEqual(countS1, countWindow)) {
                return true;
            }
        }

        return false;
    }
    private bool AreEqual(int[] a, int[] b) {
        for (int i = 0; i < 26; i++) {
            if (a[i] != b[i]) {
                return false;
            }
        }

        return true;
    }
}
