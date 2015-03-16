// Problem 5. Generic class
// Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
// Keep the elements of the list in an array with fixed capacity which is given as parameter 
// in the class constructor.
// Implement methods for adding element, accessing element by index, removing element by index,
// inserting element at given position, clearing the list, finding element by its value and ToString().
// Check all input parameters to avoid accessing elements at invalid positions.

// Problem 6. Auto-grow
// Implement auto-grow functionality: when the internal array is full, create a new array of double size
// and move all elements to it.

namespace GenericClass
{
    using System;

    class TestGenericList
    {
        static void Main()
        {
            GenericList<int> genericList = new GenericList<int>();

            genericList.Add(12);
            genericList.Add(3);
            genericList.Add(6);
            genericList.Add(32);
            genericList.Add(8);

            Console.WriteLine("Generic list ToString(): {0}", genericList);

            int index = 3;
            genericList.RemoveAt(index);

            Console.WriteLine("Generic list after removing element at index [{0}]: {1}", index, genericList);

            int element = 7;
            genericList.InsertAt(index, element);

            Console.WriteLine("Generic list after inserting element {0} at index [{1}]: {2}", element, index, genericList);

            Console.WriteLine("Index of element {0}: {1}", element, genericList.IndexOf(element));

            Console.WriteLine("Generic list count: {0}", genericList.Count);
            Console.WriteLine("Generic list capacity: {0}", genericList.Capacity);

            Console.WriteLine("Min element: {0}", genericList.Min());
            Console.WriteLine("Max element: {0}", genericList.Max());
        }
    }
}