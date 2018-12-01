// Fig. 19.16: QueueInheritanceLibrary.cs
// Implementing a queue by inheriting from class List.
using LinkedListLibrary;

namespace QueueInheritanceLibrary
{
   // class QueueInheritance inherits List's capabilities
   public class QueueInheritance<T> : List<T>
   {
      // pass name "queue" to List constructor
      public QueueInheritance() : base("queue") { }

      // place dataValue at end of queue by inserting 
      // dataValue at end of linked list
      public void Enqueue(T dataValue)
      {
         InsertAtBack(dataValue);
      }
            
      // remove item from front of queue by removing
      // item at front of linked list
      public T Dequeue()
      {
         return RemoveFromFront();
      }
   }
}

