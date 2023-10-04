int extraCandies = 3;
int[] candies = {2, 3, 5, 1, 3};
List<bool> finalList = new List<bool>();

answerList(candies, extraCandies);


foreach (var item in finalList)
{
    Console.WriteLine(item);
}

List<bool> answerList(int[] candies, int extraCandies)
{
    for (int i = 0; i < candies.Length; i++)
    {
        int totalCandies = candies[i] + extraCandies;
        bool response = false;
        for (int j = 0; j < candies.Length; j++)
        {
            if (candies[j] <= totalCandies) 
                response = true;
            else
            {
                response = false;
                break;
            }
        }
        finalList.Add(response);
    }
    return finalList;
}

