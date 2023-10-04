LinkedList linkedList = new LinkedList();
linkedList.AddNodeToFront(1);
linkedList.AddNodeToFront(2);
linkedList.AddNodeToFront(3);
linkedList.AddNodeToFront(4);
linkedList.AddNodeToFront(5);

linkedList.PrintNode();

class LinkedListNode {
    public int data;
    public LinkedListNode? next;

    public LinkedListNode(int data, LinkedListNode? next = null){
        this.data = data;
        this.next = next;
    }
}

class LinkedList {
    public int count;
    public LinkedListNode? head;

    public LinkedList() {
        head = null;
        count = 0;
    }

    public void AddNodeToFront(int data) {
        LinkedListNode node = new LinkedListNode(data){
            next = head
        };
        head = node;
        count++;
    }

    public void PrintNode() {
        LinkedListNode? runner = head;

        while (runner != null)
        {
            Console.WriteLine(runner.data);
            runner = runner.next;
        }
    }
}

 