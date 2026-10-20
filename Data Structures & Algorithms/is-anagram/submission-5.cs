public class Solution {
   public bool IsAnagram(string s, string t)
{
    if (s.Length != t.Length) {  return false; }
    var ints = new int[28];
    
    for (int i = 0; i < s.Length; i++) { 
    ints[s[i]- 'a']++;
    ints[t[i] - 'a']--;
    }

    foreach (var i in ints)
    {
        if (i != 0)
        {
            return false;
        }
    }
    return true;

}
    }
