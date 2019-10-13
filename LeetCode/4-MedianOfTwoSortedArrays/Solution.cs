using System;

namespace _4_MedianOfTwoSortedArrays
{
    internal class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var (sArray, lArray) = GetSmallerAndLargerArray(nums1, nums2);

            int min = 0,
                max = sArray.Length,
                half = (sArray.Length + lArray.Length + 1) / 2,
                i, j;

            while (min <= max)
            {
                i = (min + max) / 2;
                j = half - i;

                if (i < sArray.Length && lArray[j - 1] > sArray[i])
                {
                    min = i + 1;
                }
                else if (i > 0 && sArray[i - 1] > lArray[j])
                {
                    max = i - 1;
                }
                else
                {
                    int maxLeftArray = GetMaxLeftArray(i, j, sArray, lArray);

                    if (((sArray.Length + lArray.Length) & 1) == 1)
                        return maxLeftArray;

                    int minRightArray = GetMinRightArray(i, j, sArray, lArray);

                    return (maxLeftArray + minRightArray) / 2.0;
                }
            }

            throw new Exception("Should never reach here");
        }

        private (int[], int[]) GetSmallerAndLargerArray(int[] a, int[] b)
        {
            return a.Length > b.Length
                ? (b, a)
                : (a, b);
        }

        private int GetMaxLeftArray(int leftIndex, int rightIndex, int[] smallerArray, int[] largerArray)
        {
            if (leftIndex == 0)
            {
                return largerArray[rightIndex - 1];
            }
            else if (rightIndex == 0)
            {
                return smallerArray[leftIndex - 1];
            }
            else
            {
                return Math.Max(smallerArray[leftIndex - 1], largerArray[rightIndex - 1]);
            }
        }

        private int GetMinRightArray(int leftIndex, int rightIndex, int[] smallerArray, int[] largerArray)
        {
            if (leftIndex == smallerArray.Length)
            {
                return largerArray[rightIndex];
            }
            else if (rightIndex == largerArray.Length)
            {
                return smallerArray[leftIndex];
            }
            else
            {
                return Math.Min(smallerArray[leftIndex], largerArray[rightIndex]);
            }
        }
    }
}
