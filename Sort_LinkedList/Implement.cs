namespace Sort_LinkedList
{
    public class Node
    {
        public int Value;
        public Node Next;
    }

    public class NodeOperation
    {
        Node head = null;

        private bool IsNull()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Insert(int key)
        {
            Node newNode = new Node();
            newNode.Value = key;
            if (IsNull())
            {
                head = newNode;
                head.Next = null;
            }
            else if (head.Next == null && key >= head.Value)
            {
                head.Next = newNode;
                newNode.Next = null;
            }
            else if (key <= head.Value)
            {
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                Node finde = head;

                while (finde != null)
                {
                    if (finde.Next == null)
                    {
                        finde.Next = newNode;
                        newNode.Next = null;
                        return;
                    }
                    else if (key >= finde.Value && key <= finde.Next.Value)
                    {
                        newNode.Next = finde.Next;
                        finde.Next = newNode;
                        return;
                    }
                    finde = finde.Next;
                }
            }
        }

        public void Print()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.Value);
                temp = temp.Next;
            }
        }
    }
}
