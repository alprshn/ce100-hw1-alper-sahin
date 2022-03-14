using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/****************************************************************************
 * Copyleft (L) 2022 CENG - All Rights Not Reserved
 * You may use, distribute and modify this code.
 ****************************************************************************/

/**
 * @file ce100-hw1-algo-lib-cs
 * @author Alper Sahin
 * @date 14 March 2022
 *
 * @brief <b> HW-1 Functions </b>
 *
 * HW-1 Sample Lib Functions
 *
 * @see http://bilgisayar.mmf.erdogan.edu.tr/en/
 *
 */
namespace ce100_hw1_algo_lib_cs
{
    public class Class1
    {
        /**
       *
       *	  @name InsSort (ınssort)
       *
       *	  @brief Insertion Sort
       *
       *	  Insertion Sort
       *	  
       *	  @param  [in] mass [\b int[,]] 
       *
       **/
        public static int[] InsSort(int[] mass)
        {
            for (int i = 1; i < mass.Length; i++)
            {
                int cur = mass[i];
                int y = i;
                while (y > 0 && cur < mass[y - 1])
                {
                    mass[y] = mass[y - 1];
                    y--;
                }
                mass[y] = cur;
            }
            return mass;
        }
        /**
       *
       *	  @name  SelectionSortArray (selectionsortarray)
       *
       *	  @brief Selection Sort Array
       *
       *	  Selection Sort Array
       *
       *	  @param  [in] NumArr [\b int[,]] 
       *	   
       *	  
       **/
        public static int[] SelectionSortArray(int[] NumArr)
        {
            var ArrLength = NumArr.Length;
            for (int i = 0; i < ArrLength - 1; i++)
            {
                var smallestval = i;
                for (int h = i + 1; h < ArrLength; h++)
                {
                    if (NumArr[h] < NumArr[smallestval])
                    {
                        smallestval = h;
                    }
                }
                var tempVar = NumArr[smallestval];
                NumArr[smallestval] = NumArr[i];
                NumArr[i] = tempVar;
            }
            return NumArr;
        }
        /**
       *
       *	  @name  Naivepower (naivepower)
       *
       *	  @brief Naive Power
       *
       *	  Naive Power
       *
       *	  @param  [in] p [\b int]  
       *	   
       *	  @param  [in] t [\b int]  
       *	  
       **/
        public static long Naivepower(int p, uint t)
        {
            // initialize result by 1
            int pow = 1;

            // multiply `x` exactly `n` times
            for (int i = 0; i < t; i++)
            {
                pow = pow * p;
            }

            return pow;
        }
        /**
       *
       *	  @name  RecursivePower (recursivepower)
       *
       *	  @brief Recursive Power
       *
       *	  Recursive Power
       *
       *	  @param  [in] baseValue [\b int]  
       *	  
       *	  @param  [in] exponentvalue [\b int]  
       *	  
       **/
        public static double RecursivePower(int baseValue, int exponentvalue)
        {
            if (exponentvalue == 0)
            {
                return 1;
            }
            if (exponentvalue == 1)
            {
                return baseValue;
            }
            return baseValue * RecursivePower(baseValue, exponentvalue - 1);
        }

        // Merges two subarrays of []arr.
        // First subarray is arr[l..m]
        // Second subarray is arr[m+1..r]

        /**
       *
       *	  @name  merge (merge)
       *
       *	  @brief Merge
       *
       *	  Merge
       *	  
       *	  @param  [in] arr [\b int[,]]
       *	  
       *	  @param  [in] a [\b int]  
       *	  
       *	  @param  [in] b [\b int]  
       *	  
       *	  @param  [in] c [\b int]  
       *	  
       **/
        public static void merge(int[] arr, int a, int b, int c)
        {
            // Find sizes of two
            // subarrays to be merged
            int n1 = b - a + 1;
            int n2 = c - b;

            // Create temp arrays
            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            // Copy data to temp arrays
            for (i = 0; i < n1; ++i)
                L[i] = arr[a + i];
            for (j = 0; j < n2; ++j)
                R[j] = arr[b + 1 + j];

            // Merge the temp arrays

            // Initial indexes of first
            // and second subarrays
            i = 0;
            j = 0;

            // Initial index of merged
            // subarray array
            int k = a;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements
            // of L[] if any
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            // Copy remaining elements
            // of R[] if any
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }



        /**
       *
       *	  @name  mergeSort (mergesort)
       *
       *	  @brief Merge Sort
       *
       *	  Merge Sort
       *	  
       *	  @param  [in] array [\b int[,]] 
       *	  
       **/
        public static int[] mergeSort(int[] array)
        {
            //Main function that
            //sorts arr[l..r] using
            //merge()
            int[] left;
            int[] right;
            int[] result = new int[array.Length];
            //As this is a recursive algorithm, we need to have a base case to 
            //avoid an infinite recursion and therfore a stackoverflow
            if (array.Length <= 1)
                return array;
            // The exact midpoint of our array
            int midPoint = array.Length / 2;
            //Will represent our 'left' array
            left = new int[midPoint];

            //if array has an even number of elements,
            //the left and right array will have the same number of 
            //elements
            if (array.Length % 2 == 0)
                right = new int[midPoint];
            //if array has an odd number of elements,
            //the right array will have one more element than left
            else
                right = new int[midPoint + 1];
            //populate left array
            for (int i = 0; i < midPoint; i++)
                left[i] = array[i];
            //populate right array
            int x = 0;
            //We start our index from the midpoint, as we
            //have already populated the left array from 0 to midpont
            for (int i = midPoint; i < array.Length; i++)
            {
                right[x] = array[i];
                x++;
            }
            //Recursively sort the left array
            left = mergeSort(left);
            //Recursively sort the right array
            right = mergeSort(right);
            //Merge our two sorted arrays
            result = merge(left, right);
            return result;
        }
        /**
       *
       *	  @name  merge (merge)
       *
       *	  @brief Merge
       *
       *	  Merge
       *	  
       *	  @param  [in] left [\b int[,]]
       *	  
       *	  @param  [in] right [\b int[,]] 
       *	  
       **/
        public static int[] merge(int[] left, int[] right)
        //This method will be responsible for combining our two sorted arrays
        //into one giant array
        {
            int resultLen = right.Length + left.Length;
            int[] result = new int[resultLen];
            //
            int indexLeft = 0, indexRight = 0, indexResult = 0;
            //while either array still has an element
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                //if both arrays have elements  
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    //If item on left array is less than item on right array,
                    //add that item to the result array 
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }

                    // else the item in the right array wll be
                    // added to the results array
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }

                //if only the left array still has elements,
                //add all its items to the results array
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }

                //if only the right array still has elements,
                //add all its items to the results array
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }

        // Returns index of x if it is present in arr[],
        // else return -1

      /**
      *
      *	  @name  IterativebinarySearch (ıterativebinarysearch)
      *
      *	  @brief Iterative Binary Search
      *
      *	  Iterative Binary Search
      *	  
      *	  @param  [in] arr [\b int[,]]
      *	  
      *	  @param  [in] z [\b int]  
      *	  
      *	  
      **/
        public static int IterativebinarySearch(int[] arr, int z)
        {
            int l = 0, r = arr.Length - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;

                // Check if x is present at mid
                if (arr[m] == z)
                    return m;

                // If x greater, ignore left half
                if (arr[m] < z)
                    l = m + 1;

                // If x is smaller, ignore right half
                else
                    r = m - 1;
            }

            // if we reach here, then element was
            // not present
            return -1;
        }

        // Returns index of x if it is present in
        // arr[l..r], else return -1

        /**
      *
      *	  @name  BinarySearchRecursive (binarysearchrecursive)
      *
      *	  @brief Binary Search Recursive
      *
      *	  Binary Search Recursive
      *	  
      *	  @param  [in] arr [\b int[,]]
      *	  
      *	  @param  [in] S [\b int]  
      *	  
      *	  @param  [in] H [\b int]  
      *	  
      *	  @param  [in] keynumber [\b int]  
      *	  
      **/
        public static int BinarySearchRecursive(int[] arr, int S, int H, int keynumber)
        {
            int mid = S + (H - S) / 2;

            // find the mid-value in the search space and
            // compares it with the target

            // Base condition (target value is found)
            if (keynumber == arr[mid])
            {
                return mid;
            }

            // discard all elements in the right search space,
            // including the middle element
            else if (keynumber < arr[mid])
            {
                return BinarySearchRecursive(arr, S, mid - 1, keynumber);
            }

            // discard all elements in the left search space,
            // including the middle element
            else
            {
                return BinarySearchRecursive(arr, mid + 1, H, keynumber);
            }
        }

    }
}