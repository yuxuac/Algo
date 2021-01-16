using System;

namespace algo.Algorithm
{
    public class Sorting
    {
        /*
        ----
        Step 1:
        Bubble Sort
        Insertion Sort
        Selection Sort
        ----
        Step 2:
        Merge Sort
        Quick Sort
        */



        public static void NativeSort(int[] array)
        {
            Array.Sort(array);
        }

        public static void Print(int[] array)
        {
            Console.WriteLine(string.Join("->", array));
        }
        // 3, 1, 4, 2, 5
        // i (0~3)
        // j (0~3)
        // 
        // O(n^2)
        public static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        // O(n^2)
        public static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[minIndex] > array[j])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    var temp = array[minIndex];
                    array[minIndex] = array[i];
                    array[i] = temp;
                }
            }
        }

        // 6, 5, 3, 1, 8, 7, 2, 4
        // 5, 6, ...
        // 3, 5, 6, ...
        // 1, 3, 5, 6, ...
        // 1, 3, 5, 6, 8, ...
        // 1, 3, 5, 6, 7, 8, 2...
        // 1, 2, 3, 5, 6, 7, 8, ...
        // 1, 2, 3, 4, 5, 6, 7, 8

        // 99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0 (i = 1)
        // 44, 99, 6, 2, 1, 5, 63, 87, 283, 4, 0 (i = 2)
        // 6, 44, 99, 2, 1, 5, 63, 87, 283, 4, 0 (i = 3)
        // 2, 6, 44, 99, 1, 5, 63, 87, 283, 4, 0 (i = 4)
        // 1, 2, 6, 44, 99, 5, 63, 87, 283, 4, 0 (i = 5)

        // O(n^2)
        public static void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int position = -1;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[i])
                    {
                        position = j;
                        break;
                    }
                }
                // Get the position
                if (position >= 0)
                {
                    // Lift the element up
                    int temp = array[i];
                    // Move other elements rightward.
                    for (int k = i; k > position; k--)
                    {
                        array[k] = array[k - 1];
                    }
                    // Set the lifted element to the position
                    array[position] = temp;
                }
            }
        }

        // 6, 5, 3, 1, 8, 7, 2, 4
        public static void MergeSort(int[] array)
        {
            if (array.Length <= 1)
                return;
            else if (array.Length == 2) // O(1)
            {
                if (array[0] > array[1])
                {
                    var temp = array[1];
                    array[1] = array[0];
                    array[0] = temp;
                }
            }
            else if (array.Length > 2)
            {
                int mid = array.Length / 2;
                // 0 ~ mid-1
                // mid ~ length - 1
                int[] leftArray = new int[mid];
                Array.Copy(array, 0, leftArray, 0, mid);
                int[] rightArray = new int[array.Length - mid];
                Array.Copy(array, mid, rightArray, 0, array.Length - mid);

                MergeSort(leftArray); // O(n/2)
                MergeSort(rightArray); // O(n/2)

                int i = 0;
                int il = 0;
                int ir = 0;
                while (i < array.Length) // O(n)
                {
                    if(il >= leftArray.Length)
                    {
                        array[i++] = rightArray[ir++];
                    }
                    else if(ir >= rightArray.Length)
                    {
                        array[i++] = leftArray[il++];
                    }
                    else
                    {
                        if (leftArray[il] > rightArray[ir])
                        {
                            array[i++] = rightArray[ir++];
                        }
                        else if (leftArray[il] < rightArray[ir])
                        {
                            array[i++] = leftArray[il++];
                        }
                        else if (leftArray[il] == rightArray[ir])
                        {
                            array[i++] = leftArray[il++];
                            array[i++] = leftArray[ir++];
                        }
                    }
                }
            }
        }
    
        // 3, 7, 8, 5, 2, 1, 9, 5, 4
        public static void QuickSort(int[] array)
        {
            if(array.Length <= 1) return;
            else 
            {
                int pivot = 0;
                for(int i = 1; i < array.Length; i++)
                {
                    // *Any value less or equal than array[pivot]
                    if(array[i] <= array[pivot])
                    {
                        int val = array[i];
                        // *Move rightward
                        for(int j = i; j > pivot; j--)
                        {
                            array[j] = array[j-1];
                        }
                        array[pivot] = val;
                        pivot++;
                    }
                }

                // Concat sorted array.
                int[] leftArray = new int[pivot];
                int[] rightArray = new int[array.Length - pivot - 1];
                Array.Copy(array, 0, leftArray, 0, pivot);
                Array.Copy(array, pivot + 1, rightArray, 0, array.Length - 1 - pivot);
                QuickSort(leftArray);
                QuickSort(rightArray);
                for(int i = 0 ; i < array.Length; i++)
                {
                    if(i < leftArray.Length)
                        array[i] = leftArray[i];
                    else if(i == pivot)
                        continue;
                    else {
                        array[i] = rightArray[i - pivot - 1];
                    }
                }
            }
        }
    }
}