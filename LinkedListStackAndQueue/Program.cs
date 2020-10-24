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
            Console.WriteLine("Welcome to Linked List Stack and Queue problem");
            LinkedListStack stack = new LinkedListStack();
            // UC1 Create stack and push the element in the stack.
            stack.PushElement(70);
            stack.PushElement(30);
            stack.PushElement(56);
            stack.Display();
            stack.Pop();
            stack.Peek();
            stack.IsEmpty();
            stack.Display();
        }
    }
}
