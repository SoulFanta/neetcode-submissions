public class Solution {
     public bool hasDuplicate(int[] nums)
{
    HashSet<int> set = new HashSet<int>();
    foreach (int n in nums)
    {
        if (!set.Add(n))
    {
        return true;
    }
}
return false;
 }
}