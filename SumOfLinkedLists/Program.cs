using System;

namespace SumOfLinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TestCase__1
            Console.WriteLine("TestCase__1:\n");
            LinkedList node1_0 = new LinkedList(2);
            LinkedList node1_1 = new LinkedList(4);
            LinkedList node1_2 = new LinkedList(7);
            LinkedList node1_3 = new LinkedList(1);

            node1_0.next = node1_1;
            node1_1.next = node1_2;
            node1_2.next = node1_3;
            node1_3.next = null;

            LinkedList node2_0 = new LinkedList(9);
            LinkedList node2_1 = new LinkedList(4);
            LinkedList node2_2 = new LinkedList(5);

            node2_0.next = node2_1;
            node2_1.next = node2_2;
            node2_2.next = null;

            #endregion
            LinkedList sumOfLinkedLists = SumOfLinkedLists(node1_0,node2_0);
            while (sumOfLinkedLists != null)
            {
                Console.Write($"{sumOfLinkedLists.value} => ");
                sumOfLinkedLists = sumOfLinkedLists.next;
            }
        }


        #region My_Solution
        public static LinkedList SumOfLinkedLists(LinkedList linkedListOne, LinkedList linkedListTwo)
        {
            var linkedListOneCurrentNode = linkedListOne;
            var linkedListTwoCurrentNode = linkedListTwo;
            LinkedList sumOfLinkedLists = null;
            LinkedList currentNode = null;
            var num1 = 0;
            var num2 = 0;
            var carryOver = 0;
            while (linkedListOneCurrentNode != null || linkedListTwoCurrentNode != null || carryOver > 0)
            {
                num1 = 0;
                num2 = 0;
                if (linkedListOneCurrentNode != null)
                {
                    num1 = linkedListOneCurrentNode.value;
                    linkedListOneCurrentNode = linkedListOneCurrentNode.next;
                }
                if (linkedListTwoCurrentNode != null)
                {
                    num2 = linkedListTwoCurrentNode.value;
                    linkedListTwoCurrentNode = linkedListTwoCurrentNode.next;
                }
                var total = num1 + num2 + carryOver;
                var numberForSumOfLinkedLists = 0;
                numberForSumOfLinkedLists = total % 10;
                carryOver = total / 10;
                var newNode = new LinkedList(numberForSumOfLinkedLists);
                if (sumOfLinkedLists == null)
                {
                    sumOfLinkedLists = newNode;
                    currentNode = sumOfLinkedLists;
                }
                else
                {
                    currentNode.next = newNode;
                    currentNode = currentNode.next;
                }
            }
    
            return sumOfLinkedLists;
        }

        #endregion

        #region My__Solution
        //public static LinkedList SumOfLinkedLists(LinkedList linkedListOne, LinkedList linkedListTwo)
        //{
        //    int num1 = 0;
        //    int num2 = 0;
        //    int loop = 0;
        //    while (linkedListOne != null)
        //    {
        //        num1 += linkedListOne.value * int.Parse(Math.Pow(10, loop).ToString());
        //        loop += 1;
        //        linkedListOne = linkedListOne.next;
        //    }
        //    loop = 0;
        //    while (linkedListTwo != null)
        //    {
        //        num2 += linkedListTwo.value * int.Parse(Math.Pow(10, loop).ToString());
        //        loop += 1;
        //        linkedListTwo = linkedListTwo.next;
        //    }


        //    LinkedList result = new LinkedList((num1 + num2) % 10);
        //    if (num1 + num2 < 10)
        //    {
        //        return result;
        //    }
        //    var sum = ((num1 + num2) / 10).ToString();
        //    LinkedList cur = result;
        //    for (int i = sum.Length - 1; i >= 0; i--)
        //    {
        //        cur.next = new LinkedList(int.Parse(sum[i].ToString()));
        //        cur = cur.next;
        //    }

        //    return result;
        //}
        #endregion


        // This is an input class. Do not edit.
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
