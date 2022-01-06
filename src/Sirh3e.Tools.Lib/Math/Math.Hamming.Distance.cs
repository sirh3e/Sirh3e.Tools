namespace Sirh3e.Tools.Lib;

public static partial class Math
{
    public static class Hamming
    {
        public static int SolveDistances(string[] distances)
        {
            var distance = int.MaxValue;
            for (var x = 0; x < distances.Length; x++)
            for (var y = x + 1; y < distances.Length; y++)
            {
                var result = SolveDistance(distances[x], distances[y]);
                if (distance > result)
                    distance = result;
            }

            return distance;
        }

        public static int SolveDistance(in string src, in string dst)
            => src.Select(c => c)
                  .Zip(dst.Select(c => c))
                  .Count(t => t.First != t.Second);
    }
}