// 연결 리스트 (Linked List)
//
// 각 데이터 시퀀스가 순서를 가지고 연결된 순차적 구조
// 동적인 데이터 추가 / 삭제 에 유리하다.
// 각 요소는 Node
// 각 Node에는 Key와 다음 노드를 가리키는 포인터인 next가 포함
// 첫 번째 요소는 Head
// 마지막 요소는 Tail
//
// Alt + Tab을 사용하여 프로그램 간 전환
// 갤러리

class Node<T>
{
    public T data;
    public Node<T> next;

    public Node(T data)
    {
        this.data = data;
        next = null;
    }
}

class LinkedList<T>
{
    private Node<T> head;
    private int count;

    public LinkedList()
    {
        head = null;
        count = 0;
    }

    public void AddFirst(T data)
    {
        Node<T> newNode = new Node<T>(data);
        newNode.next = head;
        head = newNode;
        count++;
    }

    public void AddLast(T data)
    {
        Node<T> newNode = new Node<T>(data);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node<T> current = head;
            while (current.next != null)
            {
                current = current.next;
            }

            current.next = newNode;
        }

        count++;
    }
    public int Count
    {
        get
        {
            return count;
        }
    }

    public void Print()
    {
        Node<T> current = head;
        while (current != null)
        {
            Console.Write(current.data + " ");
            current= current.next;
        }
        Console.WriteLine();
    }
}


