public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
    var counts = new Dictionary<int, int>();
    foreach (int num in nums)
    {
        counts[num] = counts.GetValueOrDefault(num, 0) + 1;
    }
    int[] result = new int[k];
    PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
    foreach (var pair in counts)
    {
        pq.Enqueue(pair.Key, pair.Value);
        if (pq.Count > k)
            pq.Dequeue();
    }

    int i = 0;
    while (pq.Count > 0)
    {
        result[i++] = pq.Dequeue();
    }

    return result;
}
}
