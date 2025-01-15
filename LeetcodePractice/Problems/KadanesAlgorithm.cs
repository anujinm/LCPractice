using System.Collections.Generic;
using System;

namespace Problems
{
    public class KadanesAlgorithm
    {
        public int FindMaxSumSubArray(int[] arr) // O(n) time, O(1) space
        {
            int maxSum = arr[0];
            int currentSum = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                currentSum = Math.Max(currentSum, 0); // if it's negative, start over as it doesn't contribute to the sum
                currentSum += arr[i]; // update with the current integer
                maxSum = Math.Max(maxSum, currentSum);
            }

            return maxSum;
        }
    }
}