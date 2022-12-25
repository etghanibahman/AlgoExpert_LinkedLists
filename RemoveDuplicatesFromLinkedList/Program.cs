using System;

namespace RemoveDuplicatesFromLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

			LinkedList linkedList1 = new LinkedList(1);
			LinkedList linkedList2 = new LinkedList(1);
			LinkedList linkedList3 = new LinkedList(1);
			LinkedList linkedList4 = new LinkedList(3);
			LinkedList linkedList5 = new LinkedList(4);
			LinkedList linkedList6 = new LinkedList(4);
			LinkedList linkedList7 = new LinkedList(4);
			LinkedList linkedList8 = new LinkedList(5);
			LinkedList linkedList9 = new LinkedList(6);
			LinkedList linkedList10 = new LinkedList(6);
			
			linkedList1.next = linkedList2;
			linkedList2.next = linkedList3;
			linkedList3.next = linkedList4;
			linkedList4.next = linkedList5;
			linkedList5.next = linkedList6;
			linkedList6.next = linkedList7;
			linkedList7.next = linkedList8;
			linkedList8.next = linkedList9;
			linkedList9.next = linkedList10;
			linkedList10.next = null;


			var res = RemoveDuplicatesFromLinkedList(linkedList1);

            while (res != null)
            {
				Console.WriteLine(res.value);
				res = res.next;
            }

			//	{

			//"linkedList": {
			//		"head": "1",
			//  "nodes": [

			// { "id": "1", "next": "1-2", "value": 1},
			//    { "id": "1-2", "next": "1-3", "value": 1},
			//    { "id": "1-3", "next": "2", "value": 1},
			//    { "id": "2", "next": "3", "value": 3},
			//    { "id": "3", "next": "3-2", "value": 4},
			//    { "id": "3-2", "next": "3-3", "value": 4},
			//    { "id": "3-3", "next": "4", "value": 4},
			//    { "id": "4", "next": "5", "value": 5},
			//    { "id": "5", "next": "5-2", "value": 6},
			//    { "id": "5-2", "next": null, "value": 6}
			//  ]
			//}
			//}
			//};

			//Console.WriteLine("Hello World!");
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

		public static LinkedList RemoveDuplicatesFromLinkedList(LinkedList linkedList)
		{
			var currentNode = linkedList;
			while (currentNode != null && currentNode.next != null)
            {
                if (currentNode.value == currentNode.next.value)
                {
					currentNode.next = currentNode.next.next;
                }
                else
                {
					currentNode = currentNode.next;
                }
			}

			return linkedList;
		}
	}
}
