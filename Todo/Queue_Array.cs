using System.Linq;

namespace DSnA
{
    /// <summary>
    /// This class implements the queue using Array, here array has been implemented in circular fashion using Mod (%)
    /// Here the size of queue is fixed i.e. N
    /// Also elements are inserted only up to N-1 position to avoid the ambiquity between queue empty and full scenarios i.e. f==r
    /// </summary>
    public class Queue_Array
    {
        private int MaxElement = 10;
        private int front = 0;
        private int rear = 0;
        private object[] _customQueue;

        public Queue_Array()
        {
            _customQueue = new object[MaxElement];
        }

        public Queue_Array(int n)
        {
            _customQueue = new object[n];
            MaxElement = n;
        }

        public int Size()
        {
            return ((MaxElement + rear - front) % MaxElement);
        }

        public bool IsEmpty()
        {
            return (front == rear);
        }

        public void Reset()
        {
            _customQueue.ToList().Clear();
            front = 0;
            rear = 0;
        }

        public object Front()
        {
            return IsEmpty() ? "Queue is empty" : _customQueue[front];
        }

        public object Enqueue(object obj)
        {
            if (Size() == (MaxElement - 1))
            {
                return "Queue is full";
            }
            _customQueue[rear] = obj;
            rear = (rear + 1) % MaxElement;
            return obj;
        }

        public object Dequeue()
        {
            if (IsEmpty())
            {
                return "Queue is empty";
            }
            object obj = _customQueue[front];
            _customQueue[front] = null;
            front = (front + 1) % MaxElement;
            return obj;
        }
    }
}
