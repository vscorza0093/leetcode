int[] nums1 = {1, 2, 3};
int[] nums2 = {2, 4, 6};
List<List<int>> answer = new List<List<int>>();

FindDifference(nums1, nums2);

List<List<int>>FindDifference(int[] nums1, int[] nums2) {
    return new List<List<int>>{getAnswer1(nums1, nums2), getAnswer2(nums1, nums2)};
}

List<int> getAnswer1 (int[] nums1, int[] nums2) {
    List<int> answer1 = new List<int>();
    for (int i = 0; i < nums1.Length; i++)
    {
        bool notPresent = true;
        for (int j = 0; j < nums2.Length; j++)
        {
            if (nums1[i] == nums2[j]) 
            {
                notPresent = false;
                break;
            }
        }
        for (int j = 0; j < nums1.Length; j++)
        {
            if (!notPresent)
                break;
            if (i != j && nums1[i] == nums1[j]) 
                break;
            if (j == nums1.Length - 1) 
                answer1.Add(nums1[i]);
        }
    }
    return answer1;
}

List<int> getAnswer2(int[] nums1, int[] nums2) {
    List<int> answer2 = new List<int>();
    for (int i = 0; i < nums2.Length; i++)
    {
        bool notPresent = true;
        for (int j = 0; j < nums1.Length; j++)
        {
            if (nums2[i] == nums1[j]) 
            {
                notPresent = false;
                break;
            }
             
        }
        for (int j = 0; j < nums2.Length; j++)
        {
            if (!notPresent)
                break;
            if (i != j && nums2[i] == nums2[j]) 
                break;
            if (j == nums2.Length - 1) 
                answer2.Add(nums2[i]);
        }
    }
    return answer2;
}

int i = 1;
foreach (var item in FindDifference(nums1, nums2))
{
    foreach (var num in item)
    {
        Console.WriteLine($"Lista {i} - {num}");
    }
    i++;
}