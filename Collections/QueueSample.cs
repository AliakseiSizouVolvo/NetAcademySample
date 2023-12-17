namespace Collections;

public class QueueAndStackSample
{
    public Queue<int> Queue;
    public Stack<int> Stack;


    public QueueAndStackSample()
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 45 };
        Queue = new Queue<int>(numbers);
        Stack = new Stack<int>(numbers);
    }


    public void Sample()
    {
        //queue
        Queue.Enqueue(1);//add element to the end of queue
        //result 1,2,3,45,1
        var firstElement = Queue.Dequeue();
        //result 2,3,45,1
        var firstElementButNotRemoved = Queue.Peek();

        while(Queue.TryDequeue(out int el))
        {
            var data = el;
        }

        //stack
        //stack[0] = 45
        //stack[1] = 3
        Stack.Push(15);
        //stack[0] = 15
        //stack[1] = 45
        var element = Stack.Pop();
        //1,2,3,45
        var elementWithoutRemoving = Stack.Peek();
    }

}