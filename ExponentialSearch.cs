using System;

namespace Searching
{
    public class ExponentialSearch
    {
        public bool Search(int [] arr, int num)
        {
            if(arr[0] == num)
            {
                return true;
            }

            int exp = 1;

            while(exp < arr.Length && arr[exp] <= num)
            {
                if(arr[exp] == num)
                {
                    return true;
                }

                exp *= 2;
            }

            return BinarySearchRecursive(arr, exp / 2, Math.Min(arr.Length - 1, exp), num);
        }

        private bool BinarySearch(int [] arr, int low, int high, int num)
        {
            while(low < high)
            {
                int mid = (low + high) / 2;

                if(arr[mid] == num)
                {
                    return true;
                }
                else if(arr[mid] < num)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return false;
        }

        private bool BinarySearchRecursive(int [] arr, int low, int high, int num)
        {
            int mid = (low + high) / 2;

            if(arr[mid] == num) 
            {
                return true;
            }
            else if(arr[mid] < num)
            {
                return BinarySearchRecursive(arr, mid + 1, high, num);
            }
            else
            {
                return BinarySearchRecursive(arr, low, mid - 1, num);
            }
        }
    }
}