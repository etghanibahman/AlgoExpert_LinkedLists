using System;

namespace RemoveKthNodeFromEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TestCase__1
            Console.WriteLine("TestCase__1:\n");
            LinkedList node0 = new LinkedList(0);
            LinkedList node1 = new LinkedList(1);
            LinkedList node2 = new LinkedList(2);
            LinkedList node3 = new LinkedList(3);
            LinkedList node4 = new LinkedList(4);
            LinkedList node5 = new LinkedList(5);
            LinkedList node6 = new LinkedList(6);
            LinkedList node7 = new LinkedList(7);
            LinkedList node8 = new LinkedList(8);
            LinkedList node9 = new LinkedList(9);
            node0.Next = node1;
            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;
            node5.Next = node6;
            node6.Next = node7;
            node7.Next = node8;
            node8.Next = node9;
            node9.Next = null;
            LinkedList head = node0;
            int k = 10;
            while (head != null)
            {
                Console.Write($"{head.Value} => ");
                head = head.Next;
            }
            head = node0;
            Console.WriteLine($"\nTestCase__1___After removing node {k} :\n");
            RemoveKthNodeFromEnd(head, k);
            while (head != null)
            {
                Console.Write($"{head.Value} => ");
                head = head.Next;
            }
            #endregion

        }

		public static void RemoveKthNodeFromEnd(LinkedList head, int k)
		{
            LinkedList secondHead = head;
            LinkedList nodeToBeRemoved = head;

            for (int i = 0; i < k; i++)
            {
                secondHead = secondHead.Next;
            }

            if (secondHead == null)
            {
                nodeToBeRemoved.Value = nodeToBeRemoved.Next.Value;
                nodeToBeRemoved.Next = nodeToBeRemoved.Next.Next;
            }
            else
            {
                while (secondHead != null)
                {
                    if (secondHead.Next == null)
                    {
                        nodeToBeRemoved.Next = nodeToBeRemoved.Next.Next;
                        break;
                    }
                    secondHead = secondHead.Next;
                    nodeToBeRemoved = nodeToBeRemoved.Next;
                }
            }
        }

		public class LinkedList
		{
			public int Value;
			public LinkedList Next = null;

			public LinkedList(int value)
			{
				this.Value = value;
			}
		}
	}
}
