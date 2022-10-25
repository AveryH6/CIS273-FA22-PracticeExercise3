using System;
namespace PracticeExercise3
{
    public interface iQueue<T>
    {
        void Enqueue(T item);
        T Dequeue();

        T First{get;}
        T Last{get;}

        int Length { get; }
        bool IsEmpty { get; }
    }
}

