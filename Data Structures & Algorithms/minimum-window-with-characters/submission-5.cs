public class Solution {
    private bool ContainsAll(Dictionary<char, int> window, Dictionary<char, int> target) {
        foreach (var pair in target) {
            char character = pair.Key;
            int requiredCount = pair.Value;

            if (!window.TryGetValue(character, out int windowCount)) {
                return false;
            }

            if (windowCount < requiredCount) {
                return false;
            }
        }

        return true;
    }

    private Dictionary<char, int> CountCharacters(string text) {
        var counts = new Dictionary<char, int>();

        foreach (char character in text) {
            if (!counts.ContainsKey(character)) {
                counts[character] = 0;
            }

            counts[character]++;
        }

        return counts;
    }

    public string MinWindow(string s, string t) {
        var targetCount = CountCharacters(t);
        var windowCount = new Dictionary<char, int>();

        int bestLeft = -1;
        int bestLength = int.MaxValue;
        int left = 0;

        for (int right = 0; right < s.Length; right++) {
            char rightCharacter = s[right];

            if (!windowCount.ContainsKey(rightCharacter)) {
                windowCount[rightCharacter] = 0;
            }

            windowCount[rightCharacter]++;

            while (ContainsAll(windowCount, targetCount)) {
                int currentLength = right - left + 1;

                if (currentLength < bestLength) {
                    bestLength = currentLength;
                    bestLeft = left;
                }

                char leftCharacter = s[left];
                windowCount[leftCharacter]--;

                if (windowCount[leftCharacter] == 0) {
                    windowCount.Remove(leftCharacter);
                }
                left++;
            }
        }
        if (bestLeft == -1) {
            return "";
        }
        return s.Substring(bestLeft, bestLength);
    }
}
