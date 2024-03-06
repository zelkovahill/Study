public class List<T>
{
    private T[] array;
    private int capacity;
    private int count;

    public List(int size)
    {
        capacity = size;
        array = new T[capacity];
        count = 0;
    }

    public void Add(T item)
    {
        if (count == capacity)
        {
            // 배열 크기가 부족할 경우 용량을 두 배로 늘림
            capacity *= 2;
            T[] newArray = new T[capacity];
            Array.Copy(array,newArray,count);
            array= newArray;
        }

        array[count] = item;
        count++;
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new IndexOutOfRangeException();
        }

        for (int i = index; i < count - 1; i++)
        {
            array[i] = array[i + 1];
        }

        count--;
    }

    public int Count
    {
        get
        {
            return count;
        }
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException();
            }

            return array[index];
        }
        set
        {
            if(index< 0 || index >= count)
            {
                throw new IndexOutOfRangeException();
            }
            array[index] = value;
        }
    }
    
}
