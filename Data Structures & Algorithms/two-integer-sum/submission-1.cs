public class Solution {
    public int[] TwoSum(int[] nums, int target) {
   Dictionary<int, int> ints = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];

            if (ints.ContainsKey(diff))
            {
                return new int[] { ints[diff], i };
            }

            
            ints.Add(nums[i], i);
        }

        return new int[0];
    }
}
