// 큐(Queue)
//
// 가장 먼저 입력된 요소를 처리하는 FIFO (First In First Out)
//
// 멀티스레딩에서 스레드를 관리
// 대기열 시스템

class Queue<T>
{
    private T[] elements;
    private int front;
    private int rear;
    private int size;
    private int capacity;

    public Queue(int capacity)
    {
        this.capacity= capacity;
        elements = new T[capacity];
        front = 0;
        rear = -1;
        size = 0;
    }

    public void Enqueue(T item)
    {
        if (size == capacity)
        {
            Console.WriteLine("Queue is full");
            return;
        }
        rear = (rear + 1) % capacity;
        elements[rear] = item;
        size++;
    }

    public T Dequeue()
    {
        if (size == 0)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        T item = elements[front];
        front = (front + 1) % capacity;
        size--;
        return item;
    }

    public T Front()
    {
        if (size == 0)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        return elements[front];
    }

    public int Size()
    {
        return size;
    }

    public bool IsEmpty()
    {
        return size == 0;
    }

}
