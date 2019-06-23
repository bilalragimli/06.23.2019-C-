using System;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            BDU bdu = new BDU();
                int sum1 = bdu.plus(10, 3, 7);
                int sum2 = bdu.plus(25, 4);
            Console.WriteLine("3 ededin cemi={0}", sum1);
            Console.WriteLine("2 ededin cemi={0}", sum2);
            Console.Read();
        }
    }
}
