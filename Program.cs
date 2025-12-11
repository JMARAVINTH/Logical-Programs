namespace logicalPrograms
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            string? userValue = null;
            string? resultString = null;
            bool? resultbool = null;

            Console.WriteLine("---PLEASE SELECT THE CHOICE ---");
            Console.WriteLine("---1. Testing Reverse String ---");
            Console.WriteLine("---2. Testing Is Plaindrome String ---");
            Console.WriteLine("---3. Testing Counting Characters String ---");
            Console.WriteLine("---4. Testing Print Fibonacci ---");
            Console.WriteLine("---5. Testing Is Prime Number---");
            Console.WriteLine("---6. Testing Is Is Arm Strong Number---");
            string? userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("Please Enter the String");
                    userValue = Console.ReadLine();
                    resultString = ReverseString(userValue);
                    Console.WriteLine($"Original: {userValue} | Reversed: {resultString}");
                    break;

                case "2":
                    Console.WriteLine("Please Enter the String");
                    userValue = Console.ReadLine();
                    resultbool = IsPlaindrome(userValue);
                    Console.WriteLine($"Original: {userValue} | Is Plain Drome: {resultbool}");
                    break;

                case "3":
                    Console.WriteLine("Please Enter the String");
                    userValue = Console.ReadLine();
                    CountCharactersDublicates(userValue);
                    break;
                    
                case "4":
                    Console.WriteLine("Please Enter the Number length");
                    userValue = Console.ReadLine();
                    PrintFibonacci(Convert.ToInt32(userValue));
                    break;

                case "5":
                    Console.WriteLine("Please Enter the Number");
                    userValue = Console.ReadLine();
                    resultbool = IsPrime(Convert.ToInt32(userValue));
                    Console.WriteLine($"Original: {userValue} | Is Prime number : {resultbool}");
                    break;
                case "6":
                    Console.WriteLine("Please Enter the Number");
                    userValue = Console.ReadLine();
                    resultbool = IsArmStrong(Convert.ToInt32(userValue));
                    Console.WriteLine($"Original: {userValue} | Is Arm Strong number : {resultbool}");
                    break;
            }
            Console.ReadKey();

        }

        #region ReverseString
        public static string ReverseString(string? input) 
        {
            if (string.IsNullOrEmpty(input)) throw new NullReferenceException();

            char[] charArray = input.ToCharArray();
            int left = 0;
            int right = charArray.Length - 1;
            while(left < right)
            {
                char temp = charArray[left];
                charArray[left] = charArray[right];
                charArray[right] = temp;
                left++;
                right--;
            }
            return new string(charArray);
        }

        #endregion ReverseString

        #region Palindrome

        public static bool IsPlaindrome(string? input)
        {
            if (string.IsNullOrEmpty(input)) throw new NullReferenceException();

            int left = 0;
            int right = input.Length - 1;
            while (left < right)
            {
                if (input[left] != input[right]) return false;
                left++;
                right--;
            }
            return true;
        }

        #endregion Palindrome

        #region CountCharacterDublicates
        public static void CountCharactersDublicates(string? input)
        {
            if(string.IsNullOrEmpty(input)) throw new NullReferenceException();

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach(char c in input)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }

            foreach(var item in charCount)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }

        #endregion CountCharacterDublicates

        #region PrintFibonacci
        public static void PrintFibonacci(int length)
        {
            int a = 0,b = 1,c = 0;

            Console.Write($"{a} {b}");

            for(int i = 2; i < length; i++)
            {
                c = a + b;
                Console.Write($" {c}");
                a = b;
                b = c;
            }
        }

        #endregion PrintFibonacci

        #region IsPrime
        public static bool IsPrime(int number)
        {
            if (number < 0) return false;
            if (number == 2) return true;
            for(int i = 2; i < number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        #endregion IsPrime

        #region IsArmStrong
        public static bool IsArmStrong(int number)
        {
            int sum = 0, temp = number, remainder;
            while(temp > 0)
            {
                remainder = temp % 10;

                sum = sum + (remainder * remainder * remainder);

                temp = temp / 10;
            }
            return sum == number;
        }
        #endregion IsArmStrong

        #region FindSecondLargest
        public static int FindSecondLargest(int[] arr)
        {
            int max = int.MinValue;
            int secondMax = int.MinValue;

            foreach (int num in arr)
            {
                if (num > max)
                {
                    secondMax = max;
                    max = num;
                }
                else if (num > secondMax && num != max)
                {
                    secondMax = num;
                }
            }
            return secondMax;
        }

        #endregion FindSecondLargest

        #region Factorial
        public static int Factorial(int n)
        {
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }

        #endregion Factorial
    }
}