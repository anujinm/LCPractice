using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public class MaximumPopulationYear1854
    {
        public int MaximumPopulation(int[][] logs) {
            Dictionary<int, int> dict = new();

            for (int i = 1950; i <= 2050; i++)
            {
                dict.Add(i, 0);
                foreach (var person in logs)
                {
                    var wasAlive = person[0] <= i && i < person[1];
                    dict[i] += wasAlive ? 1 : 0;
                }
            }

            return dict.OrderByDescending(x => x.Value).First().Key;
        }
    }
}