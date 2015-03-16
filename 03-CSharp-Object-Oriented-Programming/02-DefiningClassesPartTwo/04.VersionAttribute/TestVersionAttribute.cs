namespace VersionAttribute
{
    using System;

    [Version("Pesho 0.1")]
    class TestVersionAttribute
    {
        static void Main()
        {
            object[] attributes = typeof(TestVersionAttribute).GetCustomAttributes(false);
            Console.WriteLine("Version: {0}", attributes[0]);
        }
    }
}
