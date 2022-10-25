using System;
namespace PracticeExercise3
{
    public class Deque<T> : iDeque<T>
    {
        private LinkedList<T> linkedList;

        public Deque()
        {
            linkedList = new LinkedList<T>();
        }

        public bool IsEmpty => linkedList.Count == 0;

        public int Length => linkedList.Count;

        public T Front => IsEmpty ? throw new EmptyQueueException() : linkedList.First.Value;

        public T Back => IsEmpty ? throw new EmptyQueueException() : linkedList.Last.Value;

        public void AddBack(T item)
        {
            linkedList.AddLast(item);
        }

        public void AddFront(T item)
        {
            linkedList.AddFirst(item);
        }

        public T RemoveBack()
        {
            var back = linkedList.Last.Value;
            linkedList.RemoveLast();

            return back;
        }

        public T RemoveFront()
        {
            if (IsEmpty)
            {
                throw new EmptyQueueException();
            }

            var fron = linkedList.First.Value;
            linkedList.RemoveFirst();

            return fron;
        }

        public override string ToString()
        {
            string result = "<Back> ";

            var currentNode = linkedList.Last;
            while (currentNode != null)
            {
                result += currentNode.Value;
                if (currentNode.Previous != null)
                {
                    result += " → ";
                }
                currentNode = currentNode.Previous;
            }

            result += " <Front>";

            return result;
        }
    }
}

