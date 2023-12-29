class Node
{
    Node next = null;
    int data; 

    public Node(int data)
    {
        this.data = data;
    }

    void appendToTail(int data)
    {
        Node end = new Node(data);

        Node node = this;

        while(node.next != null)
        {
            node = node.next;
        }
        node.next = end;
    }
}