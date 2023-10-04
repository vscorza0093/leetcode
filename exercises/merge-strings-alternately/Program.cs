String word1 = "abcd";
String word2 = "pq";

String finalString = "";
int word1Len = word1.Length;
int word2len = word2.Length;

int biggerLen = (word1Len > word2len) ? word1Len : word2len;

for (int i = 0; i < biggerLen; i++)
{
    if (word1Len > word2len && i > word2len - 1)
        finalString += word1[i];
    else if (word1Len < word2len && i > word1Len - 1)
        finalString += word2[i];
    else
    {
        finalString += word1[i];
        finalString += word2[i];
    }
}