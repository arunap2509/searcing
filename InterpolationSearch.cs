namespace Searching
{
    public class InterpolationSearch
    {
        /*
            for interpolation search to work we need to have an array which is sorted and also has data which is uniformly distributed or fairly distributed 
            if not then the number of operations required is more
            if it satisfies the condition then it just requires one operation
        */
        public bool Search(int [] arr, int num)
        {
            int low = 0;
            int high = arr.Length - 1;

            while(low <= high && num >= arr[low] && num <= arr[high])
            {
                if(low == high)
                {
                    if(arr[low] == num)
                    {
                        return true;
                    }
                    break;
                }
                
                int pos =(int) (low + (((double) (high - low) / (arr[high] - arr[low])) * (num - arr[low])));

                if(arr[pos] == num)
                {
                    return true;
                }
                else if(arr[pos] > num)
                {
                    high = pos - 1;
                }
                else
                {
                    low = pos + 1;
                }
            }

            return false;
        }
    }
}