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
            //Console.WriteLine(x.Sub(y));
            
           //x*y = a*c*10^(2*(n/2))+(a*d+b*c)*10^(n/2)+bd*10^0*(n/2)
           //ac
           //bd
           //ac_plus_bd
           
            //Console.WriteLine(5/2);

            //int[] arr1 = { 1, 2, 3, 4, 5 };
            //int[] arr2 = { 6, 7, 8, 9, 0 };

            static string bit_depth(int[] number)
            {
                int[] length;
                length = new int[number.Length];

                string depth_res = "";

                for (int i = 0; i < length.Length; i++)
                {
                    depth_res += number[i];
                    depth_res += "*10^";
                    depth_res += length.Length-i-1;
                    if (i < length.Length - 1)
                    {
                        depth_res += " + ";
                    }
                }
                    
                return depth_res;
            }

            // compare; is_odd; add zero; copy 1st, copy 2nd 

            //int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] arr1 = { 2, 0 };
            int[] arr2 = { 3, 1 };
            
            // 2*3 + 2*1 + 3*0 + 0*1
            
            // Math.Pow(10, arr1.Length)
            Console.WriteLine(((arr1[0]*arr2[0])*Math.Pow(10, arr1.Length))+((arr1[0]*arr2[1]+arr2[0]*arr1[1])*Math.Pow(10, arr1.Length-1))+arr1[1]*arr2[1]);

            //Console.WriteLine(bit_depth(arr1));
            
            static int[] Karatsuba(int[] num1, int[] num2)
            {
                int length = num1.Length;
                int[] split_a = new int[num1.Length/2];
                int[] split_b = new int[num1.Length-num1.Length/2];
                int[] split_c = new int[num2.Length/2];
                int[] split_d = new int[num2.Length-num2.Length/2];

                for (int i = 0; i < num1.Length/2; i++)
                {
                    split_a[i] = num1[i];
                    split_c[i] = num2[i];
                }
                for (int i = num1.Length/2; i < num1.Length-num1.Length/2; i++)
                {
                    split_b[i] = num1[i];
                    split_d[i] = num2[i];
                }
                
                int[] mult_res = new int[split_a.Length];
                mult_res = split_a;
                return mult_res;
            }
            
           //Console.WriteLine(Karatsuba(arr1, arr1));
            
        }
    }
}
