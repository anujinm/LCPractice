using System;

namespace Problems
{
    public class MaxConsecutiveOnes3 
    {
        public int LongestOnes(int[] nums, int k) {
            int kcounter = 0, max = 0, l = 0;

            if (k == nums.Length)
                return k;
        
            // keep moving right until we reach k limit
            for (int r = 0; r < nums.Length; r++)
            {
                if (nums[r] == 0)
                    kcounter++;
                
                // once we are over the limit, start moving left pointer
                while (kcounter > k)
                {
                    if (nums[l] == 0)
                        kcounter--;
                    l++;
                }

                // once we finalize the pointers locations, save the sum
                max = Math.Max(max, r- l + 1);
            }
            return max;
        }
    }
}