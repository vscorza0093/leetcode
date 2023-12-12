// Given an array of integers arr, return true if the number of occurrences of each value in the array is unique or false otherwise.
// Example 1:

// Input: arr = [1,2,2,1,1,3]
// Output: true
// Explanation: The value 1 has 3 occurrences, 2 has 2 and 3 has 1. No two values have the same number of occurrences.
// Example 2:

// Input: arr = [1,2]
// Output: false
// Example 3:

// Input: arr = [-3,0,1,-3,1,1,1,-3,10,0]
// Output: true

Console.WriteLine(Solution.UniqueOccurrences([1,2,2,1,1,3]));

public static class Solution {
    public static bool UniqueOccurrences(int[] arr) {
        Dictionary<int, int> keyValuePairs = new();
        Dictionary<int, int> ocurrencesKeyValuePairs = new();

        foreach (int number in arr)
        {
            if (keyValuePairs.ContainsKey(number))
                keyValuePairs[number]++;
            else
                keyValuePairs.Add(number, 1);
        }

        foreach (int occurrences in keyValuePairs.Values)
        {
            if (ocurrencesKeyValuePairs.ContainsKey(occurrences))
                return false;
            else
                ocurrencesKeyValuePairs.Add(occurrences, 1);
        }

        return true;
    }
}