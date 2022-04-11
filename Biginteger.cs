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
