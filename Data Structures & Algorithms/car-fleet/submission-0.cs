public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n = position.Length;
        if (n == 0)
            return 0;
        var cars = new Car[n];
        for (int i = 0; i < n; i++) {
            cars[i] =
                new Car { Position = position[i], Time = (float)(target - position[i]) / speed[i] };
        }
        Array.Sort(cars, (a, b) => b.Position.CompareTo(a.Position));

        int fleetsCount = 0;
        float lastFleetTime = 0;

        foreach (var car in cars) {
            if (car.Time > lastFleetTime) {
                fleetsCount++;
                lastFleetTime = car.Time;
            }
        }

        return fleetsCount;
    }
    private struct Car {
        public int Position;
        public float Time;
    }
}