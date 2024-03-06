// 스택(Stack)
//
// 순서가 보존되는 선형 데이터 구조
// 가장 마지막 요소(가장 최근 요소)부터 처리하는 LIFO(Last In First Out)
//
// 실행 취소
// 수학적 표현식을 구문 분석하고 평가
// 재귀 프로그래밍에서 함수 호출을 구현

class Stack<T>
{
    private T[] elements;
    private int top;

    public Stack(int size)
    {
        elements = new T[size];
        top = -1;
    }

    public void Push(T item)
    {
        if (top == elements.Length - 1)
        {
            Console.WriteLine("Stack is full");
            return;
        }
        elements[++top] = item;
    }

    public T Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty");
            return default(T);
        }

        return elements[top--];
    }

    public T Peek()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty");
            return default(T);
        }

        return elements[top];
    }

    public bool IsEmpty()
    {
        return top == -1;
    }

    public int Size()
    {
        return top + 1;
    }
}
