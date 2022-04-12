using System;
using System.Linq;

namespace lab5try1
{
    public class BigInteger
    {
        private bool _is_negative = false;
        
        private int[] _numbers;

        private string _numbersString;
        public BigInteger(string value)
        {
            char[] characters = value.ToCharArray();
            int i = 0;
            
            _numbers = new int[value.Length];
            
            foreach (var symbol in characters)
            {
                _numbers[i] = Convert.ToByte(symbol)-48;
                i += 1;
            }
        }

        public override string ToString()
        {
            if (_is_negative)
            {
                _numbersString += "-";
            }
            
            for (int i = 0; i < _numbers.Length; i++)
            {
                _numbersString += Convert.ToString(_numbers[i]);
            }

            return _numbersString;
        }
        public BigInteger Add(BigInteger another)
        {

            int maxLength = this._numbers.Length;
            int minLength = another._numbers.Length;

            int[] num1Copy;
            int[] num2Copy;

            if (this._numbers.Length < another._numbers.Length)
            {
                maxLength = another._numbers.Length;
                minLength = this._numbers.Length;

            }
            
            num1Copy = new int[maxLength];
            num2Copy = new int[maxLength];
            

            for (int i = this._numbers.Length-1; i >=0; i--)
            {
                num1Copy[i+maxLength-this._numbers.Length] = this._numbers[i];
            }

            for (int i = another._numbers.Length-1; i >=0; i--)
            {
                num2Copy[i+maxLength-another._numbers.Length] = another._numbers[i];
            }
            
            int[] sum;
            sum = new int[maxLength+1];

            for (int i = maxLength-1; i >=0; i--)
            {
                sum[i+1] += num1Copy[i] + num2Copy[i];
            }

            for (int i = sum.Length-1; i > -1; i--)
            {
                if (sum[i] >= 10)
                {
                    sum[i] = sum[i] % 10;
                    sum[i-1] = sum[i-1] + 1;
                    
                }
            }
            
            string s ="";

            if (((sum[0] == 0) && (sum.Length>1)))
            {
                for (int i = 1; i < sum.Length; i++)
                {
                    s += sum[i];
                }
            }
            else
            {
                for (int i = 0; i < sum.Length; i++)
                {
                    s += sum[i];
                }
            }
            
            BigInteger result = new BigInteger(s);
            return result;
        }
        

        public BigInteger Sub(BigInteger another)
        {
            bool isNegative=false;
            int maxLength = this._numbers.Length;
            int minLength = another._numbers.Length;

            if (this._numbers.Length < another._numbers.Length)
            {
                maxLength = another._numbers.Length;
                minLength = this._numbers.Length;
            }

            int[] num1Copy;
            int[] num2Copy;

            num1Copy = new int[maxLength];
            num2Copy = new int[maxLength];


            for (int i = this._numbers.Length-1; i >=0; i--)
            {
                num1Copy[i + maxLength - this._numbers.Length] = this._numbers[i];
            }

            for (int i = another._numbers.Length - 1; i>=0; i--)
            {
                num2Copy[i + maxLength - another._numbers.Length] = another._numbers[i];
            }

            for (int i = 0; i < maxLength; i++)
            {
                if (this._numbers[i] < another._numbers[i])
                {
                    isNegative = true;
                    break;
                }
            }

            int[] diff;
            diff = new int[maxLength+1];
            
            if (isNegative)
            {
                for (int i = maxLength-1; i >=0; i--)
                {
                    diff[i+1] = num2Copy[i] - num1Copy[i];
                }
            }
            else
            {
                for (int i = maxLength-1; i >=0; i--)
                {
                    diff[i+1] = num1Copy[i] - num2Copy[i];
                }
            }
            

            for (int i = diff.Length - 1; i > 0; i--)
            {
                if (diff[i] < 0)
                {
                    diff[i] = diff[i] + 10;
                    diff[i - 1] = diff[i - 1] - 1;
                }
            }
           
            
            string d ="";
            
            if ((diff[0] == 0) && (diff.Length>1))
            {
                for (int i = 1; i < diff.Length; i++)
                {
                    d += diff[i];
                }
            }
            else
            {
                for (int i = 0; i < diff.Length; i++)
                {
                    d += diff[i];
                }
            }
            
            BigInteger result = new BigInteger(d);
            result._is_negative = isNegative;
            return result;
        }
    }
}
