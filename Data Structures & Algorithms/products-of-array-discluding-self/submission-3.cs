public class Solution {
    public int[] ProductExceptSelf(int[] nums) {


    var n = nums.Length;
    int[] res = new int[n];

    res[0] = 1;

    for (int i = 1; i < n; i++)
    {
        //pref[i] = pref[i - 1] * nums[i]; если нужно пройтись по массиву включая nums[i]
        res[i] = res[i - 1] * nums[i-1];
    }



    int postfix = 1;
    for (int i = n - 1; i >= 0; i--)
    {
        res[i] *= postfix;
        postfix *= nums[i];
    }

    return res;
    }
}
