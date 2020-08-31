using System;

namespace Searching
{
    class Program
    {
        static void Main(string[] args)
        {
            JumpSearch jump = new JumpSearch();
            //jump.Search(new int [] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14}, 14);

            InterpolationSearch interpolation = new InterpolationSearch();
            //interpolation.Search(new int [] {1, 2, 7, 15, 20}, 7);

            ExponentialSearch exponential = new ExponentialSearch();
            exponential.Search(new int [] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15}, 14);
        }
    }
}
