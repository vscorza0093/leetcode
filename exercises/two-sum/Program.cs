foreach (var sum in TwoSum([3, 2, 4], 6))
{
    Console.WriteLine(sum);
}

// Generated with CHAT-GPT for AI studies

int[] TwoSum(int[] nums, int target)
{
    Dictionary<int, int> numIndex = new();

    for (int i = 0; i < nums.Length; i++)
    {
        int complement = target - nums[i];

        if (numIndex.TryGetValue(complement, out int complementIndex))
        {
            return new int[] { complementIndex, i };
        }

        if (!numIndex.ContainsKey(nums[i]))
        {
            numIndex.Add(nums[i], i);
        }
    }

    return Array.Empty<int>(); // If no solution is found
}
