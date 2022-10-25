using System;
namespace PracticeExercise3
{
    public interface iStack<T>
    {
        void Push(T item);

        T Pop();

        T Peek();

        bool IsEmpty { get; }

        int Length{ get; }
       
    }
}

