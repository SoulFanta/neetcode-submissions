public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
    if (nums.Length == 0) return 0;

    var set = new HashSet<int>(nums);
    int longestStreak = 0;
    foreach (int n in set)
    {
        if (!set.Contains(n - 1))
        {
            int currentNum = n;
            int currentStreak = 1;

            while (set.Contains(currentNum + 1))
            {
                currentNum += 1;
                currentStreak += 1;
            }

            longestStreak = Math.Max(longestStreak, currentStreak);
        }

    }
    return longestStreak;

}
}
