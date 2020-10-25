// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

namespace LinkedListStackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Stack problem");
            Console.WriteLine("========================");
            // Creating instance object of LikedListStack class
            LinkedListStack stack = new LinkedListStack();
            // UC1 Create stack and push the element in the stack.
            stack.PushElement(70);
            stack.PushElement(30);
            stack.PushElement(56);
            stack.Display();
            // UC2 ability to peak and pop from the stack till it is empty
            stack.Pop();
            stack.Peek();
            stack.IsEmpty();
            stack.Display();
            Console.WriteLine("========================");

            Console.WriteLine("\n Welcome to Linked List Queue problem");
            Console.WriteLine("========================");
            // UC3 Ability to create a queue using append list method.
            // Creating instance object of LikedListQueue class
            LinkedListQueue queue = new LinkedListQueue();
            // Inserting element in the queue.
            queue.EnqueueElement(56);
            queue.EnqueueElement(30);
            queue.EnqueueElement(70);
            queue.Display();
            //UC4 Ability Dequeue (dlete) element from begininig of the Queue .
            queue.DequeueElement();
            queue.Display();
            queue.DequeueElement();
            queue.Display();
            queue.DequeueElement();
            queue.Display();
        }
    }
}
