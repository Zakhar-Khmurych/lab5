using System;

namespace lab5try1
{
    class Program
    {
        static void Main(string[] args)
        {

            BigInteger x = new BigInteger("15");
            //Console.WriteLine(x);

            BigInteger y = new BigInteger("16");
            Console.WriteLine(x.Add(y));
            Console.WriteLine(x.Sub(y));

        }
    }
}
