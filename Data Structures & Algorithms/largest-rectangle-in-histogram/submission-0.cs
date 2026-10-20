public class Solution {
    public int LargestRectangleArea(int[] heights) {
        var stack = new Stack<int>();  // храним индексы колонок
        int maxArea = 0;
        int n = heights.Length;
        for (int i = 0; i <= n; i++) {
            int currentHeight = i == n ? 0 : heights[i];
            while (stack.Count > 0 && heights[stack.Peek()] > currentHeight) {
                int height = heights[stack.Pop()];

                int left = stack.Count > 0 ? stack.Peek() : -1;
                int width = i - left - 1;
                maxArea = Math.Max(maxArea, height * width);
            }
            stack.Push(i);
        }
        return maxArea;
    }
}
