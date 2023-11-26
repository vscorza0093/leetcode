using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

string ransomNote = "aa";
string magazine = "ab";

string otherRansomNote = "abcde";
string otherMagazine = "abcdea";
Solution sln = new();


bool canConstruct = sln.CanConstruct(ransomNote, magazine);
bool canConstruct2 = sln.CanConstruct(otherRansomNote, otherMagazine);

Console.WriteLine(canConstruct);
Console.WriteLine(canConstruct2);


public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        Dictionary<char, int> lettersInMagazine = new Dictionary<char, int>{};

        foreach (var letter in magazine)
        {   
            if (lettersInMagazine.ContainsKey(letter))
                lettersInMagazine[letter]++;
            else
                lettersInMagazine.Add(letter, 1);
        }

        foreach (char letter in ransomNote)
        {
            if (lettersInMagazine.ContainsKey(letter) && lettersInMagazine[letter] > 0)
            {
                lettersInMagazine[letter]--;
                continue;
            }
            else
                return false;
        }
        return true;
    }
}