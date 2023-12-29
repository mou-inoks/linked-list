class Node
{
    Node suivant = null;
    int value; 

    public Node(int data)
    {
        this.value = data;
    }

    void appendToTail(int data)
    {
        Node end = new Node(data);

        Node node = this;

        while(node.suivant != null)
        {
            node = node.suivant;
        }
        node.suivant = end;
    }
}