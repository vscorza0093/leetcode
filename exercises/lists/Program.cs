LinkedList<int> linkedList = new LinkedList<int>();

linkedList.AddLast(1);
linkedList.AddLast(2);
linkedList.AddLast(3);

List<int> list = new List<int>(){1, 2, 3};

linkedList.AddLast(4);
list.Add(4);

Console.WriteLine("linked list");
foreach (var item in linkedList)
{
    Console.WriteLine(item);
}

Console.WriteLine("list");
foreach (var item in list)
{
    Console.WriteLine(item);
}



