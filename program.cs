using System;

namespace lab5try1
{
    class Program
    {
        static void Main(string[] args)
        {

            BigInteger x = new BigInteger("000");
            BigInteger y = new BigInteger("000");
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            
            //https://www.youtube.com/watch?v=yWI2K4jOjFQ
            
            //Console.WriteLine(x.Add(y));
            Console.WriteLine(x.Sub(y));
            
           //x*y = a*c*10^(2*(n/2))+(a*d+b*c)*10^(n/2)+bd*10^0*(n/2)
           //ac
           //bd
           //ac_plus_bd
           
            Console.WriteLine(5/2);

            //int[] arr1 = { 1, 2, 3, 4, 5 };
            //int[] arr2 = { 6, 7, 8, 9, 0 };
            
            int[] arr1 = { 1, 2 };
            int[] arr2 = { 3, 4 };

            static int[] Karatsuba(int[] num1, int[] num2)
            {
                int[] split_a = new int[num1.Length/2];
                int[] split_b = new int[num1.Length-num1.Length/2];
                int[] split_c = new int[num2.Length/2];
                int[] split_d = new int[num2.Length-num2.Length/2];

                for (int i = 0; i < num1.Length; i++)
                {
                    split_a[i] = num1[i];
                }
                
                int[] mult_res=split_a;
                return mult_res;
            }
            
           // Console.WriteLine(Karatsuba(int num1, num2));
            
        }
    }
}
