namespace Assignment1_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. Create a simple console application and declare basic datatypes like int, float, decimal, double and print their min and max values.

            int intNum1 = 6;
            int intNum2 = 7;

            float fNum1 = 1.0f;
            float fNum2 = 3.0f;

            decimal dNum1 = 10.0M;
            decimal dNum2 = 8.0M;

            double dubNum1 = 100.23;
            double dubNum2 = 25.32;

            Console.WriteLine("The int Max is " + Math.Max(intNum1, intNum2) + " The int Min is " + Math.Min(intNum1, intNum2));
            Console.WriteLine("The float Max is " + Math.Max(fNum1, fNum2) + " The float Min is " + Math.Min(fNum1, fNum2));
            Console.WriteLine("The decimal Max is " + Math.Max(dNum1, dNum2) + " The decimal Min is " + Math.Min(dNum1, dNum2));
            Console.WriteLine("The double Max is " + Math.Max(dubNum1, dubNum2) + " The double Min is " + Math.Min(dubNum1, dubNum2));

            // 3. and 4. Write a C# Sharp program to print the sum of two numbers and the result of dividing two numbers.
            // Prompt the user to enter the numbers

            Console.WriteLine("For an example of summation and division");

            Console.WriteLine("Enter the first number.");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Second number.");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double sum = num1 + num2;
            Console.WriteLine("\nThe summation of the two numbers is: " + sum);

            double div;

            if (num2 != 0) { 
                div = num1 / num2;
                Console.WriteLine("\nThe first number divided by the second is: " + div);
            }
            else { 
                Console.WriteLine("\nERROR: Cannot divide by 0 as it will result in undefined");
            }

            
            



        }
    }
}
