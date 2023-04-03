namespace Lesson
{
    class MyList
    {
        public Node head;

        public void reverse(){
            Node currentNode = head;
            if(currentNode == null) return;
            Node previosNode = null;
            Node nextNode = currentNode.Next;
            currentNode.Next = previosNode;
            while(nextNode != null){
                previosNode = currentNode;
                currentNode = nextNode;
                nextNode = nextNode.Next;
                currentNode.Next = previosNode;
            }
            head = currentNode;
        }
        public void AddFirst(string value)
        {
            Node newNode = new Node();
            if (head == null)
            {
                head = newNode;
                head.Value = value;
            }
            else
            {
                newNode.Value = value;
                newNode.Next = head;
                head = newNode;
            }
        }

        public Node PopFirst()
        {
            if (head == null) return null;
            Node first = head;
            head = head.Next;
            return first;
        }

        public Node Find(string value)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Value == value) return current;
                current = current.Next;
            }
            return null;
        }

        public bool Contain(string value)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Value == value) return true;
                current = current.Next;
            }
            return false;
        }

        public void AddLast(string value)
        {
            Node current = head;
            if (current == null)
            {
                AddFirst(value);
                return;
            }
            Node newNode = new Node();
            newNode.Value = value;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
        public Node PopLast()
        {
            Node current = head;
            Node previos = current;
            if (current == null)
            {
                return null;
            }
            if(current.Next == null){
                head = null;
                return current;
            }
            while (current.Next != null)
            {
                previos = current;
                current = current.Next;
            }
            previos.Next = null;
            return previos;
        }


    }
}






