public class Solution {
    public int Trap(int[] height) {
        int v = 0;

        int[] prefixMax = new int[height.Length];
        prefixMax[0] = height[0];
        for (int i = 1; i < height.Length; i++) {
            prefixMax[i] = Math.Max(prefixMax[i - 1], height[i]);
        }

        int[] suffixMax = new int[height.Length];
        suffixMax[^1] = height[^1];
        for (int i = height.Length - 2; i >= 0; i--) {
            suffixMax[i] = Math.Max(suffixMax[i + 1], height[i]);
        }

        for (int i = 0; i < height.Length; i++) {
            v += Math.Min(prefixMax[i], suffixMax[i]) - height[i];
        }

        return v;
    }
}
