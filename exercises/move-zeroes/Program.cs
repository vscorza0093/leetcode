// Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

// Note that you must do this in-place without making a copy of the array.

 

// Example 1:

// Input: nums = [0,1,0,3,12]
// Output: [1,3,12,0,0]
// Example 2:

// Input: nums = [0]
// Output: [0]

Solution.MoveZeroes([0]);

public static class Solution {
    public static void MoveZeroes(int[] nums) {
        if (nums.Length == 1)
        {
            Console.WriteLine(nums[0]);
            return;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0) {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] != 0)
                    {
                        nums[i] = nums[j];
                        nums[j] = 0;
                        break;
                    }
                }
            }

            foreach (var item in nums)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }       
    }

    public static bool IsValidArray(int[] nums)
    {
        return IsValidLength(nums);
    }

    public static bool IsValidLength(int[] nums)
    {
        if (nums.Length <= 1)
        {
            if (nums.Length == 1)
                return true;
            else
                return false;
        }

        return true;

    }
}