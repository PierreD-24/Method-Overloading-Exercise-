namespace MethodOverloading
{
    public class Program
    {
        public class MathOperations
        {
            // Method to add two integers
            public int Add(int num1, int num2)
            {
                return num1 + num2;
            }

            // Overload of Add method to add two decimals
            public decimal Add(decimal num1, decimal num2)
            {
                return num1 + num2;
            }

            // Another overload of Add method with three parameters
            public string Add(int num1, int num2, bool isDollarFormat)
            {
                int sum = num1 + num2;

                if (isDollarFormat)
                {
                    return sum == 1 ? $"{sum} dollar" : $"{sum} dollars";
                }
                else
                {
                    return sum.ToString();
                }
            }
        }
        static void Main(string[] args)
        {
            MathOperations math = new MathOperations();

            Console.WriteLine(math.Add(3, 5));


            Console.WriteLine(math.Add(1, 0, true)); 
            Console.WriteLine(math.Add(5, 2, true)); 
            Console.WriteLine(math.Add(5, 2, false));
        }

    }
}
