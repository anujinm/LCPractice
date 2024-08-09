using System.Collections.Generic;

namespace Problems
{
    public class NumberOfDiceRollsWithTargetSum1155
    {
        public int NumRollsToTarget(int n, int k, int target) 
        {
            if (n == 1 && target < k)
                return 1;
        
            if (k*n < target)
                return 0;
                
            Dictionary<(int, int), int> cache = new();

            int GetTotalOfN(int nd, int target)
            {
                if (nd * k < target || (nd == 0 && target != 0))
                    return 0;
                if (nd == 0 && target == 0)
                    return 1;

                if (cache.ContainsKey((nd, target)))
                    return cache[(nd, target)];
                
                var sum = 0;
                for (int i = 1; i <= k; i++)
                {
                    sum = (sum + GetTotalOfN(nd - 1, target - i)) % 1000000007;
                }

                cache.Add((nd, target), sum);
                return sum;
            }

            return GetTotalOfN(n, target);
        }
    }
}