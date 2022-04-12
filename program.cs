using System;

namespace lab5try1
{
    class Program
    {
        static void Main(string[] args)
        {

            BigInteger x = new BigInteger("12345");
            //Console.WriteLine(x);

            BigInteger y = new BigInteger("678");
            Console.WriteLine(x.Add(y));

        }
    }
}
