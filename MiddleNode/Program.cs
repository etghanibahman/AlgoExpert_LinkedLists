using System;

namespace MiddleNode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Prompt
            //LinkedList linkedList1 = new LinkedList(2);
            //LinkedList linkedList2 = new LinkedList(7);
            //LinkedList linkedList3 = new LinkedList(3);
            //LinkedList linkedList4 = new LinkedList(5);
            //linkedList1.next = linkedList2;
            //linkedList2.next = linkedList3;
            //linkedList3.next = linkedList4;
            //linkedList4.next = null;
            #endregion
            #region TestCase1
            //LinkedList linkedList1 = new LinkedList(1);
            #endregion
            #region TestCase2___2
            LinkedList linkedList1 = new LinkedList(1);
            LinkedList linkedList2 = new LinkedList(2);
            LinkedList linkedList3 = new LinkedList(3);
            linkedList1.next = linkedList2;
            linkedList2.next = linkedList3;
            #endregion
            #region TestCase4
            //LinkedList linkedList1 = new LinkedList(1);
            //LinkedList linkedList2 = new LinkedList(2);
            //LinkedList linkedList3 = new LinkedList(3);
            //LinkedList linkedList4 = new LinkedList(4);
            //linkedList1.next = linkedList2;
            //linkedList2.next = linkedList3;
            //linkedList3.next = linkedList4;
            #endregion


            Console.WriteLine($"Middle Node value : {MiddleNode(linkedList1).value}");
        }

        public static LinkedList MiddleNode(LinkedList linkedList)
        {
            LinkedList responseLinkedList = linkedList;
            int lengthList = 0;
            while (linkedList != null)
            {
                lengthList++;
                linkedList = linkedList.next;
            }
            if (lengthList == 1) {
                return responseLinkedList;
            }
            int middleNodeIdx = lengthList / 2;
            //if (lengthList % 2 == 0)
            //{
            //    middleNodeIdx = lengthList / 2 + 1;
            //}
            //else
            //{
            //    middleNodeIdx = lengthList / 2;
            //}
            int counter = 0;

            while (counter != middleNodeIdx)
            {
                responseLinkedList = responseLinkedList.next;
                counter++;
            }

            return responseLinkedList;

        }
        public class LinkedList
        {
            public int value;
            public LinkedList next;

            public LinkedList(int value)
            {
                this.value = value;
                this.next = null;
            }
        }

    }
}
