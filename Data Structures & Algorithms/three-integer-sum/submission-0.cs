public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> result = [];

        int[] array = nums.ToArray();
        Array.Sort(array);
        int right;
        int left;

        int target;

        for (int i = 0; i < array.Length; i++) {
            if (i > 0 && array[i] == array[i - 1])
                continue;

            right = array.Length - 1;
            left = i + 1;
            while (left < right) {
                target = -array[i];
                if (array[i] + array[left] + array[right] == 0) {
                    result.Add([array[i], array[left], array[right]]);

                    while (left < right && array[left] == array[left + 1]) {
                        left++;
                    }
                    while (left < right && array[right] == array[right - 1]) {
                        right--;
                    }

                    right--;
                    left++;

                } else {
                    if (array[left] + array[right] > target) {
                        right--;
                    } else {
                        left++;
                    }
                }
            }
        }

        return result;
    }
}