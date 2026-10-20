public class Solution {
    public int MaxArea(int[] heights) {
        int right = heights.Length - 1;
        ;
        int left = 0;
        int v = 0;
        while (left < right) {
            if ((right - left) * Math.Min(heights[left], heights[right]) > v) {
                v = (right - left) * Math.Min(heights[left], heights[right]);
            }

            if (heights[left] > heights[right])
                right--;
            else
                left++;
        }

        return v;
    }
}