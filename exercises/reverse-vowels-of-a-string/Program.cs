string s = "Live on evasions? No, I save no evil.";
List<char> fsList = new List<char>();

List<int> indexToSwap = new List<int>();

foreach (var item in s)
{
    fsList.Add(item);
}

for (int i = 0; i < s.Length; i++)
{
    if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u' || s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U') {
        indexToSwap.Add(i);
    }
}

string swap(List<int> indexToSwap, List<char>fsList){
    indexToSwap.Sort();
    for (int i = 0; i < indexToSwap.Count; i++)
    {
        if (indexToSwap.Count == 2){
            char temp = fsList[indexToSwap[i]];
            fsList[indexToSwap[i]] = fsList[indexToSwap[indexToSwap.Count - 1 - i]];
            fsList[indexToSwap[indexToSwap.Count - 1 - i]] = temp;
            break;
        }
        else if (indexToSwap[indexToSwap.Count - 1 - i] - i <= 1)
        {
            break;
        }
        else {
            char temp = fsList[indexToSwap[i]];
            fsList[indexToSwap[i]] = fsList[indexToSwap[indexToSwap.Count - 1 - i]];
            fsList[indexToSwap[indexToSwap.Count - 1 - i]] = temp;
        }
    }

    string finalString = "";
    foreach (var item in fsList)
    {
        finalString += item;
    }
    return finalString;
}

Console.WriteLine(swap(indexToSwap, fsList));


/*
L  i
1 34
e  e
3 32
o  o
5 30
e  e
8 27
a  a
10 25
i  I
12 22
o  o
13 19
*/