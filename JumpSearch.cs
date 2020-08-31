using System;

namespace Searching
{
    public class JumpSearch
    {
        public bool Search(int [] arr, int num)
        {
            int jump = (int) Math.Sqrt(arr.Length);
            int low = 0;
            int high = jump;

            while (high < arr.Length)
            {
                if(arr[high] > num)
                {
                    break;
                }

                if(arr[high] == num)
                {
                    return true;
                }
                
                low = high;
                high = high + jump;
            }

            for(int i = low; i < arr.Length; i++)
            {
                if(arr[i] == num)
                {
                    return true;
                }
            }
            return false;
        }
    }
}