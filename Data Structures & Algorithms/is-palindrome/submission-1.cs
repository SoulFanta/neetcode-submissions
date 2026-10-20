public class Solution {
    public bool IsPalindrome(string s) {
        string str = new string(s.Where(char.IsLetterOrDigit).ToArray()).ToLower();
        int left = 0;
        int right = str.Length - 1;

        while (left < right) {
            if (str[left] == str[right]) {
                left++;
                right--;
            } else {
                return false;
            }
        }
        return true;
    }
}
