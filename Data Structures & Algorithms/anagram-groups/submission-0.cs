public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
    var sort_str= new Dictionary<string, List<string>>();
        foreach (string s in strs)
        {
            var count = new int[26]; // for 1 words
            foreach (char c in s)
            {
                count[c - 'a']++;
            }

            string key = string.Join("#", count);

            if (!sort_str.ContainsKey(key))
            {
                sort_str[key] = new List<string>();
        }
        sort_str[key].Add(s);
    }
    return [.. sort_str.Values];
}
}
