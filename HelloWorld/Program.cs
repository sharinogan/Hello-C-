using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fraudulentOrderIDs = new string[3];

            fraudulentOrderIDs[0] = "A123";
            fraudulentOrderIDs[1] = "B456";
            fraudulentOrderIDs[2] = "C789";

            for (int i = 0; i < fraudulentOrderIDs.Length; i++)
            {
                Console.WriteLine(fraudulentOrderIDs[i]);
            }
        }
    }
}
