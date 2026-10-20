public class Solution {
     public bool hasDuplicate(int[] nums)
{
    if (nums.Length > new HashSet<int>(nums).Count) { return true; } 
    else { return false; }
 }
}