// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
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
            Console.WriteLine("\n Displaying the Linked list stack :");
            //initialising temp variable for checking head pointer.
            Node temp = this.top;
            // If temp is null then then print the stack is empty.
            if (temp == null)
            {
                Console.WriteLine("Linked List stack is empty");
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
        /// <summary>
        /// UC2 ability to peak and pop from the stack till it is empty
        /// </summary>
        //Peek from the top of the stack and displaying the element
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("\n top of the stack node is {0}", this.top.data);
        }
        /// <summary>
        /// Popping element from the Stack till the stack is empty
        /// </summary>
        public void Pop()
        {
           if(this.top == null)
            {
                Console.WriteLine("Stack is empty, Again deletion not possible");
                return;
            }
            Console.WriteLine("\n Value to be popped is {0}", this.top.data);
            //Shorting the node by restoring the next node reference to current node
            this.top = this.top.Next;
        }
        /// <summary>
        /// Popping is continue  till the Stack is empty and Peeking from the top element in the Stack
        /// </summary>
        public void IsEmpty()
        {
            // iterating using while loop till the stack is empty.
            while(this.top != null)
            {
                //Its denoting the top of the element in the stack
                Peek();
                // Its poppping element from the stack.
                Pop();
            }
        }
    }
}

