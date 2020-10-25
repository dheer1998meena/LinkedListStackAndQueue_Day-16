using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LinkedListStackAndQueue
{
    public class LinkedListQueue
    {
        // top node to mark the begining of the Queue.
        public Node head;
        /// <summary>
        /// UC3 Ability to create a queue using append list method.
        /// </summary>
        /// <param name="newData"></param>
        public void EnqueueElement(int newData)
        {
            //Creating a new Node and inserting in the Queue
            Node newNode = new Node(newData);
            // Checking if condition first If the head is null then  head is pointing to the new node
            if (this.head==null)
            {
                this.head = newNode;
            }
            else
            {
                //initialising temp variable for checking head pointer.
                Node temp = this.head;
                //Iterating using while loop. 
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                //Assigning the new node to the end of the queue.
                temp.Next = newNode;
            }
            //Insert new node into the queue.
            Console.WriteLine("Inserted element into the Queue is :" + newNode.data);
        }
        /// <summary>
        ///  Creating Display method for displaying the Queue
        /// </summary>
        public void Display()
        {
            //initialising temp variable for checking head pointer.
            Node temp = this.head;
            // Checking the end condition if the queue is Empty
            if (temp == null)
            {
                Console.WriteLine(" queue is empty");
                return;
            }
            else
            {
                // Traversing till the head of the queue
                // Displaying the element in the queue and then incrementing the position
                while (temp!= null)
                {
                    Console.Write(" " + temp.data);
                    //checking if other nodes are present in the queue by moving the temp to next node
                    temp = temp.Next;
                }
            }


        }
    }
}
