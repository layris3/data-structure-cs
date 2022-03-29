using System;

namespace Data_Structure
{
    public class SinglyLinkedList<T>
    {
        public SinglyListNode<T> Head { get; set; }
    }

    public class SinglyListNode<T>
    {
        public T Value { get; set; }
        public SinglyListNode<T> Next { get; set; }

        public SinglyListNode(T value)
        {
            this.Value = value;
        }
    }


}
