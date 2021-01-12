using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Algo
{
    public class Algo
    {
        // IsSumExistsInArray
        public static object IsSumExistsInArray(int[] array, int sum)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            object result = null;

            for (int i = 0; i < array.Length; i++)
            {
                if (dic.ContainsKey(array[i]))
                {
                    result = new { min = dic[array[i]], max = i };
                    break;
                }
                else
                {
                    dic.Add(sum - array[i], i);
                }

            }
            return result;
        }

        // IsSumExistsInSortedArray
        public static bool IsSumExistsInSortedArray(int[] array, int sum)
        {
            bool flag = false;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == sum) flag = true;
                }
            }
            return flag;
        }

        // IsSumExistsInSortedArray2
        public static object IsSumExistsInSortedArray2(int[] array, int sum)
        {
            int min = 0;
            int max = array.Length - 1;
            object result = null;
            int tempSum = 0;
            while (min < max)
            {
                tempSum = array[min] + array[max];

                if (tempSum == sum)
                {
                    result = new { min, max };
                    break;
                }
                else if (tempSum > sum)
                    max--;
                else
                    min++;
            }
            return result;
        }


        // BinarySearch in sorted array
        /*
            // 1, 2, 3, 4, 5, 6; find:5;
            // 1, 2, 3, 4, 5, 6; find:2;
            // 1, 2, 3, 4, 5; find: 4;
        */
        public static object BinarySearch(int[] array, int sum)
        {
            int result = -1;
            int min = 0;
            int max = array.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (sum == array[mid])
                {
                    result = mid;
                    break;
                }
                else if (sum < array[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return new { min, max };
        }

        // TwoSum: find 2 indexes in nums with values have the sum of 'target'
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] resultArray = new int[2];
            Dictionary<int, int> dic1 = new Dictionary<int, int>();
            int firstVal = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic1.ContainsKey(nums[i]))
                {
                    resultArray[1] = i;
                    firstVal = target - nums[i];
                    break;
                }
                else
                {
                    dic1.Add(target - nums[i], i);
                }
            }

            //O(n)
            resultArray[0] = dic1[target - firstVal];

            return resultArray;
        }

        // TwoSum2: find 2 indexes in nums with values have the sum of 'target'
        public static int[] TwoSum2(int[] nums, int target)
        {
            int[] resultArray = new int[2];
            HashSet<int> hs1 = new HashSet<int>();
            int firstVal = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (hs1.Contains(target - nums[i]))
                {
                    resultArray[1] = i;
                    firstVal = target - nums[i];
                    break;
                }
            }
            int firstValIndex = 0;
            foreach (var item in hs1)
            {
                if (item == firstVal)
                {
                    resultArray[0] = firstValIndex;
                    break;
                }
                firstValIndex++;
            }

            return resultArray;
        }

        // ReverseString
        // O(n)
        public static string ReverseString(string input)
        {
            if (input == null) throw new Exception("null string can't be reversed!");

            char[] tempArray = new char[input.Length];
            char[] inputArray = input.ToArray();
            for (int i = inputArray.Length - 1; i >= 0; i--)
            {
                tempArray[inputArray.Length - 1 - i] = inputArray[i];
            }
            return string.Join("", tempArray);
        }

        // Merge 2 sorted arrays 
        // O(n)
        public static int[] MergeSortedArrays(int[] array1, int[] array2)
        {

            if (array1 == null) return array2;
            else if (array2 == null) return array1;

            int[] mergedArray = new int[array1.Length + array2.Length];

            int ma_index = 0;
            int index1 = 0;
            int index2 = 0;

            while (ma_index < array1.Length + array2.Length)
            {
                if (index2 >= array2.Length || array1[index1] < array2[index2])
                {
                    mergedArray[ma_index] = array1[index1];
                    ma_index++;
                    index1++;
                }
                else if (index1 >= array1.Length || array1[index1] > array2[index2])
                {
                    mergedArray[ma_index] = array2[index2];
                    ma_index++;
                    index2++;
                }
                else
                {
                    mergedArray[ma_index] = array1[index1];
                    ma_index++;
                    index1++;
                    mergedArray[ma_index] = array2[index2];
                    ma_index++;
                    index2++;
                }
            }
            return mergedArray;
        }

        // MaxSubArray
        // [-2, 1, -3, 4, -1, 2, 1, -5, 4] => [4, -1, 2, 1]
        // [-1, -1, -2, -3] => [-1]
        public static int MaxSubArray(int[] nums)
        {
            int sum = 0;
            int maxSum = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                sum = sum + nums[i]; 
                if (sum > maxSum)
                    maxSum = sum;  
                if (sum < 0)
                    sum = 0; 
            }
            return maxSum;
        }

    }
}