int[] flowerbed = {1, 0, 0, 0, 1};
int n = 2;


for (int i = 0; i < flowerbed.Length; i++)
{
    if (flowerbed[i] == 0 && i > 0)
    {
        if (i == flowerbed.Length -1)
        {
            if (flowerbed[flowerbed.Length -1] == 0 && flowerbed[flowerbed.Length - 2] == 0)
            {
                flowerbed[flowerbed.Length -1] = 1;
                n--;
            }
        }
        else 
        {
            if (flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0)
            {
                flowerbed[i] = 1;
                n--;
            }
        }
    }
    else if (flowerbed[i] == 0 && i == 0)
    {
        if (flowerbed[i + 1] == 0)
        {
            flowerbed[i] = 1;
            n--;
        }  
    }
    if (n == 0)
        break;
}

foreach (var item in flowerbed)
{
    Console.WriteLine(item);
}

if (n > 0) 
    Console.WriteLine(false);
else
    Console.WriteLine(true);