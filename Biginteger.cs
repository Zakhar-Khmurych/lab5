 public class BigInteger
    {   
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
 }
