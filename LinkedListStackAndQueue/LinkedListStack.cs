// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListStackAndQueue
{
    class LinkedListStack
    {
        // top node to mark the begining of the linked list.
        public Node top;
        /// <summary>
        /// UC1 Create stack and push the element in the stack.
        /// </summary>
        /// <param name="newData"></param>
        public void PushElement(int newData)
        {
            // Creating a new node to push.
            Node newNode = new Node(newData);
            if (this.top != null)
            {
                // Taking previous node adresss and assigning into new node of next.
                //its making connection between previous and current node.
                newNode.Next = this.top;
            }
            // moving top pointer into new node.
            this.top = newNode;
            Console.WriteLine("New node {0} is push to stack", this.top.data);
        }
        /// <summary>
        /// Creating DisplayList metbhod for displaying the Linkedlist
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Displaying the Linked list stack :");
            //initialising temp variable for checking head pointer.
            Node temp = this.top;
            // If temp is null then then print the Linked list stack is empty.
            if (temp == null)
            {
                Console.WriteLine("\n Linked List stack is empty");
                return;
            }
            // else we will iterating the temp til the temp is null using while loop. 
            else
            {
                while (temp != null)
                {
                    Console.Write(" " + temp.data);
                    //checking if other nodes are present in the list by moving the temp to next node
                    temp = temp.Next;
                }
            }
        }
    }
}
