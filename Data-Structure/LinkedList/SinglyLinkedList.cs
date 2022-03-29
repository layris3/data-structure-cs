using System;

namespace Data_Structure
{
    public class SinglyLinkedList<T>
    {
        public SinglyListNode<T> Head { get; set; }
        public SinglyLinkedList(SinglyListNode<T> head)
        {
            this.Head = head;
        }

        public void ChangeHead(SinglyListNode<T> node)
        {
            node.Next = this.Head;
            this.Head = node;
        }

        public void DeleteNode(SinglyListNode<T> target)
        {
            var prev = Head;
            var node = Head;
            while (node != target && node.Next != null)
            {
                prev = node;
                node = node.Next;
            }

            prev.Next = node.Next;
        }

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
