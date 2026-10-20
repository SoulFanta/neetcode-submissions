public class Solution {

    public string Encode(IList<string> strs) {
    StringBuilder res = new StringBuilder();

    foreach (string strItem in strs)
    {
        res.Append(strItem.Length);
        res.Append('#');
        res.Append(strItem);
    }

    return res.ToString();
}

    public List<string> Decode(string s) {
    List<string> result = new List<string>();
    int start = 0; 

    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == '#')
        {
            int length = int.Parse(s.Substring(start, i - start));
            string word = s.Substring(i + 1, length);
            result.Add(word);
            i = i + length;
            start = i + 1;
        }
    }
    return result;
}
}
