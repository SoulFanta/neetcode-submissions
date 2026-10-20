public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
    var counts = new Dictionary<int, int>();
    foreach (int num in nums)
    {
        if (counts.ContainsKey(num))
            counts[num]++;
        else
            counts[num] = 1;
    }

    var buckets = new List<int>[nums.Length + 1];
    foreach (var pair in counts)
    {
        int freq = pair.Value;
        if (buckets[freq] == null)
        {
            buckets[freq] = new List<int>();
        }
        buckets[freq].Add(pair.Key);
    }

    int[] result = new int[k];
    int index = 0;

    for (int i = buckets.Length - 1; i >= 0 && index < k; i--)
    {
        if (buckets[i] != null)
        {
            foreach (int num in buckets[i])
            {
                result[index++] = num;
                if (index == k) return result;
            }
        }
    }
    return result;
}
}
