using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunningSumLC
{
    //For every value in the array
    //Default first array index as first new array value
    //Get index value, add next index value
    //Store the result in new array, and
    //Add the next index to the stored value
    //Until we run out of values
    internal class Program
    {
        static int[] nums = new int[] { 1, 3, 5, 7, 9 };
        // 1, 4, 9, 16, 25
        static void Main(string[] args)
        {
            #region Output
            RunningSum(nums);
            foreach (var number in RunningSum(nums))
            {
                Console.WriteLine("Here:" + number);
            }
            Console.ReadKey();
            #endregion
            int[] RunningSum(int[] nums)
            {

                var sum = nums[0]; //Establish initial sum value = to nums[0] to place in runningSum[0] index

                int[] runningSum = new int[nums.Length]; //Establish an array runningSum to hold our totals, giving it a length = to nums.Length

                runningSum[0] = sum; //Make the first index of runningSum = to sum, or first nums value

                for (int i = 1; i < nums.Length; i++) //While i is less than the total length of the array, while numbers still need to be summed
                {
                    sum = sum + nums[i]; //Make sum = to the current sum + the next value in the nums array
                    runningSum[i] = sum; //Make the runningSum array index value of i = to the sum
                }

                return runningSum; //Return the runningSum Array
            }
        }
    }
}
