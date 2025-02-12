using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAssignment2
{
    public class RotateArray
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, };
            int k = 3;
            rotateArray(ref nums,k);
            Console.WriteLine(string.Join(", ", nums));
        }
        static void rotateArray(ref int[] nums,int k)
        {
            k %= nums.Length;
            reverse(0,nums.Length-1,ref nums);
            reverse(0, k-1, ref nums);
            reverse(k, nums.Length - 1, ref nums);
        }
        static void reverse(int start, int end, ref int[] nums)
        {
            while (start < end)
            {
                int temp = nums[start];
                nums[start++] = nums[end];
                nums[end--] = temp;
            }
        }

    }
}
