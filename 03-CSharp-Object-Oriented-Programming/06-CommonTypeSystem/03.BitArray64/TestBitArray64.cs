// Problem 5. 64 Bit array
// Define a class BitArray64 to hold 64 bit values inside an ulong value.
// Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

namespace BitArray64
{
    using System;

    class TestBitArray64
    {
        static void Main()
        {
            try
            {
                BitArray64 bitArr = new BitArray64(150000);

                // test foreach for BitArr
                Console.WriteLine("[ TEST - foreach ]");
                Console.WriteLine("---------------------------------");

                foreach (var bit in bitArr)
                {
                    Console.Write(bit);
                }

                Console.WriteLine();

                // test ToString() method
                Console.WriteLine("\n[ TEST - ToString() method ]");
                Console.WriteLine("---------------------------------");
                Console.WriteLine(bitArr);

                // test GetHashCode() method
                Console.WriteLine("\n[ TEST - GetHashCode() method ]");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("bitArr.GetHashCode() : {0}", bitArr.GetHashCode());

                // test indexer
                Console.WriteLine("\n[ TEST - indexer ]");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("bitArr[62] = {0}", bitArr[62]);
                Console.WriteLine("bitArr[4] = {0}", bitArr[4]);
                //Console.WriteLine("bitArr[62] = {0}", bitArr[62]); // throw IndexOutOfRangeException

                // test Equals() method            
                BitArray64 secondBitArr = new BitArray64(65000);

                Console.WriteLine("\n[ TEST - Equals() method ]");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("bitArr.Equals(secondBitArr) : {0}", bitArr.Equals(secondBitArr));

                // test operators == and !=
                Console.WriteLine("\n[ TEST - operators == and != ]");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("bitArr == secondBitArr : {0}", bitArr == secondBitArr);
                Console.WriteLine("bitArr != secondBitArr : {0}", bitArr != secondBitArr);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}