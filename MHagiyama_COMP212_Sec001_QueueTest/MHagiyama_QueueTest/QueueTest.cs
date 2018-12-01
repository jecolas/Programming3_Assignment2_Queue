// Fig. 19.17: QueueTest.cs
// Testing class QueueInheritance.
using System;
using QueueInheritanceLibrary;
using LinkedListLibrary;

// demonstrate functionality of class QueueInheritance
class QueueTest
{
   static void Main()
   {
      QueueInheritance<string> queue = new QueueInheritance<string>();

        // create objects to store in the queue
        string fName = "Moemi";
        string lName = "Hagiyama";
        string country = "Canada";
        string city = "Toronto";

      // use method Enqueue to add items to queue
      queue.Enqueue(fName);
      queue.Display();
      queue.Enqueue(lName);
      queue.Display();
      queue.Enqueue(country);
      queue.Display();
      queue.Enqueue(city);
      queue.Display();

      // use method Dequeue to remove items from queue
      object removedObject = null;

      // remove items from queue
      try
      {
         while (true)
         {
            removedObject = queue.Dequeue();
            Console.WriteLine($"{removedObject} dequeued");
            queue.Display();
         }
      }
      catch (EmptyListException emptyListException)
      {
         // if exception occurs, write stack trace
         Console.Error.WriteLine(emptyListException.StackTrace);
      }
   }
}

