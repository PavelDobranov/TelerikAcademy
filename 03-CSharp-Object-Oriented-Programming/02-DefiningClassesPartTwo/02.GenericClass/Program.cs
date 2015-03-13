namespace GenericClass
{
    using System;

    class Program
    {
        static void Main()
        {
            var genericList = new GenericList<int>(5);

            genericList.Add(1);
            genericList.Add(2);
            genericList.Add(3);
            genericList.Add(4);
            genericList.Add(5);

            Console.WriteLine(genericList);

            genericList.RemoveAt(3);

            Console.WriteLine(genericList);
        }
    }
}