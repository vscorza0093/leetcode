/*

Given two strings s and t, return true if t is an anagram of s, and false otherwise.

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

Example 1:

Input: s = "anagram", t = "nagaram"
Output: true
Example 2:

Input: s = "rat", t = "car"
Output: false

*/

public class Solution {
    public bool IsAnagram(string s, string t) {
               Dictionary<char, int> keyValuePairs = new();

        if (s.Length != t.Length)
            return false;

        foreach (char letter in s)
        {
            if (keyValuePairs.ContainsKey(letter))
                keyValuePairs[letter]++;
            else
                keyValuePairs.Add(letter,1);
        }

        foreach (char letter in t)
        {
            if(keyValuePairs.ContainsKey(letter))
                keyValuePairs[letter]--;
            else
                return false;
            if(keyValuePairs[letter] < 0)
                return false;
        }
        return true;       
    }
}