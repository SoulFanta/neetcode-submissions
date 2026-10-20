public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs)
{
    if (strs.Length == 1)
    {
        return [[strs[0]]];
    }

    var sort_str = new Dictionary<string, List<string>>();

    foreach (string s in strs)
    {
        var count = new int[26];

        foreach (char c in s)
        {
            count[c - 'a']++;
        }

        StringBuilder st = new StringBuilder();
        foreach (int i in count)
        {
            st.Append(i);
            st.Append('#');
        }

        string key = st.ToString();

        if (!sort_str.ContainsKey(key))
        {
            sort_str[key] = new List<string>();
        }

        sort_str[key].Add(s);
    }

    return [.. sort_str.Values];
}
}
