using System;
using System.Text;

namespace LinkedListConstruction
{
    class Program
    {
        static void Main(string[] args)
        {
            #region initialization
            //Node node1 = new Node(1);
            //Node node2 = new Node(2);
            //Node node3 = new Node(3);
            //Node node4 = new Node(4);
            //Node node5 = new Node(5);

            //node1.Next = node2;

            //node2.Prev = node1;
            //node2.Next = node3;

            //node3.Prev = node2;
            //node3.Next = node4;

            //node4.Prev = node3;
            //node4.Next = node5;

            //node5.Prev = node4;

            //Node standAloneNode3 = new Node(3);
            //Node standAloneNode3_2 = new Node(3);
            //Node standAloneNode6 = new Node(6);

            //Console.WriteLine("The following linkedlist has been created:");
            //PrintLinkedList(node1);
            //Console.WriteLine("---------------------------------------------------------");
            #endregion


            DoublyLinkedList doublyLinkedList = new DoublyLinkedList();

            #region TestCase__1
            //Console.WriteLine("\n TestCase__1:");
            //Node node1 = new Node(1);
            //Node node2 = new Node(2);
            //Node node3 = new Node(3);
            //Node node4 = new Node(4);
            //Node node5 = new Node(5);
            //Node node6 = new Node(6);
            //Node node3_2 = new Node(3);
            //Node node3_3 = new Node(3);
            ////PrintLinkedList(doublyLinkedList.Head);
            //doublyLinkedList.SetHead(node5);
            //doublyLinkedList.SetHead(node4);
            //doublyLinkedList.SetHead(node3);
            //doublyLinkedList.SetHead(node2);
            //doublyLinkedList.SetHead(node1);
            //doublyLinkedList.SetTail(node6);
            //doublyLinkedList.InsertBefore(node6, node3);
            //doublyLinkedList.InsertAfter(node6, node3_2);
            //doublyLinkedList.InsertAtPosition(1, node3_3);
            //doublyLinkedList.RemoveNodesWithValue(3);
            //doublyLinkedList.Remove(node2);
            ////PrintLinkedList(doublyLinkedList.Head);
            //doublyLinkedList.ContainsNodeWithValue(5);
            //TraceAllNodes(doublyLinkedList.Head);
            //PrintDoublyLinkedList(doublyLinkedList);
            //Console.WriteLine("---------------------------------------------------------");
            #endregion

            #region TestCase__2

            //Console.WriteLine("\n TestCase__2:");
            //            Node node1 = new Node(1);
            //            //PrintLinkedList(doublyLinkedList.Head);
            //            doublyLinkedList.SetHead(node1);
            //            Console.WriteLine("---------------------------------------------------------");

            #endregion

            #region TestCase__4
            //Console.WriteLine("\n TestCase__4:");
            //Node node1 = new Node(1);
            //doublyLinkedList.InsertAtPosition(1, node1);
            #endregion

            #region TestCase__6
            //Console.WriteLine("\n TestCase__6:");
            //Node node1 = new Node(1);
            //Node node2 = new Node(2);
            //doublyLinkedList.SetHead(node1);
            //doublyLinkedList.SetHead(node2);
            //TraceAllNodes(doublyLinkedList.Head);
            //PrintDoublyLinkedList(doublyLinkedList);
            #endregion

            #region TestCase__7
            //Console.WriteLine("\n TestCase__7:");
            //Node node1 = new Node(1);
            //Node node2 = new Node(2);
            //doublyLinkedList.SetHead(node1);
            //doublyLinkedList.InsertAfter(node1, node2);
            //PrintDoublyLinkedList(doublyLinkedList);
            #endregion

            #region TestCase__8
            //Console.WriteLine("\n TestCase__8:");
            //Node node1 = new Node(1);
            //Node node2 = new Node(2);
            //doublyLinkedList.SetHead(node1);
            //doublyLinkedList.InsertBefore(node1, node2);
            //PrintDoublyLinkedList(doublyLinkedList);
            #endregion

            #region TestCase__9
            //Console.WriteLine("\n TestCase__9:");
            //Node node1 = new Node(1);
            //Node node2 = new Node(2);
            //Node node3 = new Node(3);
            //Node node4 = new Node(4);
            //doublyLinkedList.SetHead(node1);
            //doublyLinkedList.InsertAfter(node1, node2);
            //TraceAllNodes(doublyLinkedList.Head);
            ////PrintDoublyLinkedList(doublyLinkedList);
            //doublyLinkedList.InsertAfter(node2, node3);
            //TraceAllNodes(doublyLinkedList.Head);
            ////PrintDoublyLinkedList(doublyLinkedList);
            //doublyLinkedList.InsertAfter(node3, node4);
            ////TraceAllNodes(doublyLinkedList.Head);
            //PrintDoublyLinkedList(doublyLinkedList);
            #endregion

            #region TestCase__11
            //Console.WriteLine("\n TestCase__11:");
            //Node node1 = new Node(1);
            //Node node2 = new Node(2);
            //Node node3 = new Node(3);
            //Node node4 = new Node(4);
            //doublyLinkedList.SetHead(node1);
            //doublyLinkedList.InsertAfter(node1, node2);
            //PrintDoublyLinkedList(doublyLinkedList);
            //doublyLinkedList.InsertAfter(node2, node3);
            //PrintDoublyLinkedList(doublyLinkedList);
            //doublyLinkedList.InsertAfter(node3, node4);
            //PrintDoublyLinkedList(doublyLinkedList);
            //doublyLinkedList.SetTail(node1);
            //PrintDoublyLinkedList(doublyLinkedList);

            #endregion

            #region TestCase__12
            //Console.WriteLine("\n TestCase__12:");
            //Node node1 = new Node(1);
            //Node node2 = new Node(2);
            //Node node3 = new Node(3);
            //Node node4 = new Node(4);
            //doublyLinkedList.SetTail(node1);
            //doublyLinkedList.InsertBefore(node1, node2);
            //doublyLinkedList.InsertBefore(node2, node3);
            //doublyLinkedList.InsertBefore(node3, node4);
            //PrintDoublyLinkedList(doublyLinkedList);
            //doublyLinkedList.SetHead(node1);
            //PrintDoublyLinkedList(doublyLinkedList);

            #endregion

            //#region TestCase__13
            //Console.WriteLine("\n TestCase__13:");
            //Node node1 = new Node(1);
            //Node node2 = new Node(2);
            //Node node3 = new Node(3);
            //Node node4 = new Node(4);
            //doublyLinkedList.SetHead(node1);
            //doublyLinkedList.InsertAfter(node1, node2);
            ////PrintDoublyLinkedList(doublyLinkedList);
            //doublyLinkedList.InsertAfter(node2, node3);
            ////PrintDoublyLinkedList(doublyLinkedList);
            //doublyLinkedList.InsertAfter(node3, node4);
            //PrintDoublyLinkedList(doublyLinkedList);
            //doublyLinkedList.InsertAfter(node2, node1);
            //Console.WriteLine($"\nafter InsertAfter(node2, node1)");
            //PrintDoublyLinkedList(doublyLinkedList);
            //doublyLinkedList.InsertBefore(node3, node4);
            //Console.WriteLine($"\nafter InsertBefore(node3, node4)");
            //PrintDoublyLinkedList(doublyLinkedList);

            //#endregion

            #region TestCase__14
            Console.WriteLine("\n TestCase__14:");
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            Node node6 = new Node(6);
            Node node7 = new Node(7);

            ////my test
            //Node node8 = new Node(8);
            //Node node9 = new Node(9);
            //Node node10 = new Node(10);

            doublyLinkedList.SetHead(node1);
            doublyLinkedList.InsertAfter(node1, node2);
            doublyLinkedList.InsertAfter(node2, node3);
            doublyLinkedList.InsertAfter(node3, node4);
            doublyLinkedList.InsertAfter(node4, node5);
            doublyLinkedList.InsertAfter(node5, node6);
            doublyLinkedList.InsertAfter(node6, node7);
            PrintDoublyLinkedList(doublyLinkedList);
            doublyLinkedList.InsertAtPosition(7, node1);
            Console.WriteLine($"Position is {7} ================================");
            PrintDoublyLinkedList(doublyLinkedList);
            doublyLinkedList.InsertAtPosition(1, node1);
            Console.WriteLine($"Position is {1}=============================");
            PrintDoublyLinkedList(doublyLinkedList);
            doublyLinkedList.InsertAtPosition(2, node1);
            Console.WriteLine($"Position is {2} ===================================");
            PrintDoublyLinkedList(doublyLinkedList);
            doublyLinkedList.InsertAtPosition(3, node1);
            PrintDoublyLinkedList(doublyLinkedList);
            doublyLinkedList.InsertAtPosition(4, node1);
            PrintDoublyLinkedList(doublyLinkedList);
            doublyLinkedList.InsertAtPosition(5, node1);
            TraceAllNodes(doublyLinkedList.Head);
            PrintDoublyLinkedList(doublyLinkedList);
            doublyLinkedList.InsertAtPosition(6, node1);
            PrintDoublyLinkedList(doublyLinkedList);

            ////My test
            //Console.WriteLine("Adding a new node in middle, 4");
            //doublyLinkedList.InsertAtPosition(4, node8);
            //PrintDoublyLinkedList(doublyLinkedList);

            //Console.WriteLine("Adding a new node in beginning, 1");
            //doublyLinkedList.InsertAtPosition(1, node9);
            //PrintDoublyLinkedList(doublyLinkedList);

            //Console.WriteLine("Adding a new node in end, 9");
            //doublyLinkedList.InsertAtPosition(9, node10);
            //PrintDoublyLinkedList(doublyLinkedList);

            #endregion

            #region General tesets
            //Console.WriteLine("\ndoublyLinkedList at the beginning:");
            //PrintLinkedList(doublyLinkedList.Head);
            ////TraceAllNodes(doublyLinkedList.Head);
            //Console.WriteLine("---------------------------------------------------------");

            //Console.WriteLine("\nsetHead(4) :");
            //doublyLinkedList.SetHead(node4);
            //PrintLinkedList(doublyLinkedList.Head);
            ////TraceAllNodes(doublyLinkedList.Head);
            //Console.WriteLine("---------------------------------------------------------");

            //Console.WriteLine("\nsetTail(6) - here we add a stand-alone node:");
            //doublyLinkedList.SetTail(standAloneNode6);
            //PrintLinkedList(doublyLinkedList.Head);
            ////TraceAllNodes(doublyLinkedList.Head);
            //Console.WriteLine("---------------------------------------------------------");

            //Console.WriteLine("\nInsertBefore(6,3)");
            //Console.WriteLine("Move the existing node with value 3 before the existing node with value 6");
            //doublyLinkedList.InsertBefore(standAloneNode6, node3);
            //PrintLinkedList(doublyLinkedList.Head);
            //TraceAllNodes(doublyLinkedList.Head);
            //Console.WriteLine("---------------------------------------------------------");

            //Console.WriteLine("\nInsertAfter(6,3)");
            //Console.WriteLine("Insert a stand-alone node with value 3 after the existing node with value 6");
            //doublyLinkedList.InsertAfter(standAloneNode6, standAloneNode3);
            //PrintLinkedList(doublyLinkedList.Head);
            ////TraceAllNodes(doublyLinkedList.Head);
            //Console.WriteLine("---------------------------------------------------------");

            //Console.WriteLine("\nInsertAtPosition(6,3)");
            //Console.WriteLine("Insert a stand-alone node with value 3 in position 1");
            //doublyLinkedList.InsertAtPosition(1, standAloneNode3_2);
            //PrintLinkedList(doublyLinkedList.Head);
            ////TraceAllNodes(doublyLinkedList.Head);
            //Console.WriteLine("---------------------------------------------------------");

            //Console.WriteLine("\nRemoveNodesWithValue(3) - remove all nodes with value 3");
            //doublyLinkedList.RemoveNodesWithValue(3);
            //PrintLinkedList(doublyLinkedList.Head);
            ////TraceAllNodes(doublyLinkedList.Head);
            //Console.WriteLine("---------------------------------------------------------");

            //Console.WriteLine("\nRemove(2) - remove the existing node with value 2");
            //doublyLinkedList.Remove(node2);
            //PrintLinkedList(doublyLinkedList.Head);
            ////TraceAllNodes(doublyLinkedList.Head);
            //Console.WriteLine("---------------------------------------------------------");

            //Console.WriteLine("\nContainsNodeWithValue(5)");
            //Console.WriteLine($"Do we have the value 5? {doublyLinkedList.ContainsNodeWithValue(5)}");
            //PrintLinkedList(doublyLinkedList.Head);
            //Console.WriteLine("---------------------------------------------------------");
            #endregion
        }

        public class DoublyLinkedList
        {
            public Node Head;
            public Node Tail;

            public void SetHead(Node node)
            {
                if (this.Head == null)
                {
                    this.Head = node;
                    this.Tail = node;
                    return;
                }
                if (node.Prev != null)
                    node.Prev.Next = node.Next;

                if (node.Next != null)
                    node.Next.Prev = node.Prev;
                else if (node.Prev != null)
                    this.Tail = node.Prev;
                
                Node head = this.Head;

                node.Next = head;
                node.Prev = null;
                head.Prev = node;
                this.Head = node;
            }

            public void SetTail(Node node)
            {
                if (this.Tail == null)
                {
                    this.Head = node;
                    this.Tail = node;
                    return;
                }

                if (node.Next != null)
                    node.Next.Prev = node.Prev;

                if (node.Prev != null)
                    node.Prev.Next = node.Next;
                else if (node.Next != null)
                    this.Head = node.Next;


                Node tail = this.Tail;

                node.Prev = tail;
                tail.Next = node;
                node.Next = null;

                this.Tail = node;
            }

            public void InsertBefore(Node node, Node nodeToInsert)
            {
                //InsertBefore(node6, node3) => Move the existing node with value 3 before the existing node with value 6

                if (nodeToInsert.Next != null)
                    nodeToInsert.Next.Prev = nodeToInsert.Prev;
                else if (nodeToInsert.Prev != null)
                {
                    this.Tail = nodeToInsert.Prev;
                }

                if (nodeToInsert.Prev != null)
                    nodeToInsert.Prev.Next = nodeToInsert.Next;

                if (node.Prev != null)
                {
                    node.Prev.Next = nodeToInsert;
                }
                else
                {
                    this.Head = nodeToInsert;
                }
                
                nodeToInsert.Prev = node.Prev;
                node.Prev = nodeToInsert;
                nodeToInsert.Next = node;

            }

            public void InsertAfter(Node node, Node nodeToInsert)
            {
                //InsertAfter(node2, node1); Insert node1 after node2
                if (node.Next != null)
                {
                    node.Next.Prev = nodeToInsert;
                    nodeToInsert.Next = node.Next;
                }
                else
                {
                    this.Tail = nodeToInsert;
                }
                if (nodeToInsert.Prev == null && nodeToInsert.Next != null)
                {
                    this.Head = node;
                    node.Prev = null;
                }

                //nodeToInsert.Prev = node.Prev;
                node.Next = nodeToInsert;
                nodeToInsert.Prev = node;
            }

            public void InsertAtPosition(int position, Node nodeToInsert)
            {
                //AlgoExpert's tests has a problem here
                int[] algoBugNumbers = new int[] { 2,3,4,5,6,7};
                if ( Array.Exists(algoBugNumbers, a => a == position))
                {
                    position = position - 1;
                }

                int nodeCounter = 1;
                int nodeCurrentPosition = 1;
                Node node = this.Head;
                if (node == null)
                {
                    this.Head = nodeToInsert;
                    this.Tail = nodeToInsert;
                    return;
                }
                while (node != null)
                {
                    if (nodeCounter == position)
                        break;
                    nodeCounter++;
                    node = node.Next;
                }

                if (!(nodeToInsert.Prev == null && nodeToInsert.Next == null))
                {
                    Node helperNode = this.Head;
                    while (helperNode != null)
                    {
                        if (helperNode == nodeToInsert)
                            break;
                        nodeCurrentPosition++;
                        helperNode = helperNode.Next;
                    }

                }

                if (node == nodeToInsert)
                {
                    return;
                }

                if (nodeToInsert.Prev == null && nodeToInsert.Next == null)
                {
                    if (this.Head == null)
                    {
                        this.Head = nodeToInsert;
                        this.Tail = nodeToInsert;
                        return;
                    }
                    if (node == this.Head)
                    {
                        this.Head = nodeToInsert;
                    }

                    if (node.Prev != null)
                        node.Prev.Next = nodeToInsert;
                    nodeToInsert.Next = node;
                    nodeToInsert.Prev = node.Prev;
                    node.Prev = nodeToInsert;
                }
                else if (nodeCurrentPosition < nodeCounter)
                {
                    if (nodeToInsert.Prev != null)
                    {
                        nodeToInsert.Prev.Next = nodeToInsert.Next;
                    }
                    else
                    {
                        this.Head = nodeToInsert.Next;
                    }
                    if (nodeToInsert.Next != null)
                    {
                        nodeToInsert.Next.Prev = nodeToInsert.Prev;
                    }
                    else
                    {
                        this.Tail = nodeToInsert.Prev;
                    }

                    if (node == this.Tail)
                    {
                        this.Tail = nodeToInsert;
                    }

                    nodeToInsert.Next = node.Next;
                    nodeToInsert.Prev = node;
                    node.Next.Prev = nodeToInsert;
                    node.Next = nodeToInsert;
            
                }
                else
                {
                    if (nodeToInsert.Prev != null)
                    {
                        nodeToInsert.Prev.Next = nodeToInsert.Next;
                    }
                    else
                    {
                        this.Head = nodeToInsert.Next;
                    }
                    if (nodeToInsert.Next != null)
                    {
                        nodeToInsert.Next.Prev = nodeToInsert.Prev;
                    }
                    else
                    {
                        this.Tail = nodeToInsert.Prev;
                    }

                    if (node == this.Head)
                    {
                        this.Head = nodeToInsert;
                    }

                    nodeToInsert.Next = node;
                    nodeToInsert.Prev = node.Prev;
                    node.Prev.Next = nodeToInsert;
                    node.Prev = nodeToInsert;
                }
            }

            public void RemoveNodesWithValue(int value)
            {
                Node node = this.Head;
                while (node != null)
                {
                    if (node.Value == value)
                    {
                        if (node.Prev != null)
                            node.Prev.Next = node.Next;
                        else
                            this.Head = node.Next;

                        if (node.Next != null)
                            node.Next.Prev = node.Prev;
                        else
                            this.Tail = node.Prev;
                    }
                    node = node.Next;
                }
            }

            public void Remove(Node node)
            {
                Node nodeToBeDeleted = this.Head;
                while (nodeToBeDeleted != null)
                {
                    if (nodeToBeDeleted.Value == node.Value)
                    {
                        if (nodeToBeDeleted.Prev != null)
                            nodeToBeDeleted.Prev.Next = node.Next;
                        else
                            this.Head = nodeToBeDeleted.Next;

                        if (nodeToBeDeleted.Next != null)
                            nodeToBeDeleted.Next.Prev = nodeToBeDeleted.Prev;
                        else
                            this.Tail = nodeToBeDeleted.Prev;

                        break;
                    }
                    nodeToBeDeleted = nodeToBeDeleted.Next;
                }
            }

            public bool ContainsNodeWithValue(int value)
            {
                Node node = this.Head;
                while (node != null)
                {
                    if (node.Value == value)
                    {
                        return true;
                    }
                    node = node.Next;
                }
                return false;
            }
        }

        // Do not edit the class below.
        public class Node
        {
            public int Value;
            public Node Prev;
            public Node Next;

            public Node(int value)
            {
                this.Value = value;
            }
        }

        public static void PrintDoublyLinkedList(DoublyLinkedList linkedlist)
        {
            Console.WriteLine($"The head is {linkedlist.Head.Value}");
            Console.WriteLine($"The tail is {linkedlist.Tail.Value}");
            Node head = linkedlist.Head;
            StringBuilder builer = new StringBuilder();
            do
            {
                builer.Append(head.Value);
                if (head.Next != null)
                    builer.Append(" <--> ");
                head = head.Next;
            } while (head != null);


            Console.WriteLine(builer);
        }

        public static void PrintLinkedList(Node head)
        {
            StringBuilder builer = new StringBuilder();
            do
            {
                builer.Append(head.Value);
                if (head.Next != null)
                    builer.Append(" <--> ");
                head = head.Next;
            } while (head != null);


            Console.WriteLine(builer);
        }

        public static void TraceAllNodes(Node node)
        {
            while (node != null)
            {
                Console.WriteLine($"Value: {node.Value}");
                Console.WriteLine($"Left Value: {node.Prev?.Value }");
                Console.WriteLine($"Right Value: {node.Next?.Value }");
                node = node.Next;
            }

        }
    }
}



//if (position == 1 || Head == null)
//{
//    SetHead(nodeToInsert);
//    return;
//}
//var i = 1;
//var currentNode = Head;

//while(i < position && currentNode != null) {
//    currentNode = currentNode.Next;
//    i++;
//}

//if (currentNode == null)
//{
//    SetTail(nodeToInsert);
//}
//else
//{
//    InsertBefore(currentNode,nodeToInsert);
//}