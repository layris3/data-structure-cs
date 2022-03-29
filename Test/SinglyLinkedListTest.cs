using Data_Structure;
using System;
using Xunit;

namespace Test
{
    public class SinglyLinkedListTest
    {
        [Fact]
        public void DeleteNodeTest()
        {
            SinglyLinkedList<int> linkedList = GenerateLinkedList(new int[] { 1,2,3,4 });
            linkedList.DeleteNode(new SinglyListNode<int>(1));
            Assert.Equal(2, linkedList.Head.Value);
        }

        private SinglyLinkedList<int> GenerateLinkedList(int[] arr)
        {
            var node = new SinglyListNode<int>(arr[0]);
            SinglyLinkedList<int> linkedList = new SinglyLinkedList<int>(node);
            for (int i = 1; i < arr.Length; i++)
            {
                node.Next = new SinglyListNode<int>(arr[i]);
                node = node.Next;
            }

            return linkedList;
        }
    }
}
