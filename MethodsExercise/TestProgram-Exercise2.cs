using System;

namespace MethodsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a random whole number...");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Next, enter another random whole number...");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            //Call each of the following Methods (sub-routines).
            MyAdd(num1, num2);
            MySub(num1, num2);
            MyMult(num1, num2);
            MyDiv(num1, num2);
            MyMod(num1, num2);



            //Final statement to let user know program is finished.
            Console.WriteLine();
            Console.WriteLine("The Methods Test Program is now finished.");
            //End of program
        }

        public static void MyAdd(int num1, int num2)
        {
            int result = (num1 + num2);
            Console.WriteLine($"The sum of {num1} and {num2} is:  {result}");
            return;
        }

        public static void MySub(int num1, int num2)
        {
            int result = (num1 - num2);
            Console.WriteLine($"The remainder of {num1} minus {num2} is:  {result}");
            return;

        }

        public static void MyMult(int num1, int num2)
        {
            int result = (num1 * num2);
            Console.WriteLine($"The product of {num1} times {num2} is:  {result}");
            return;

        }

        public static void MyDiv(int num1, int num2)
        {
            //Convert num1 & num2 to Decimal to accurately process division 
            decimal num_x = Convert.ToDecimal(num1);   
            decimal num_y = Convert.ToDecimal(num2);
            decimal num_z = (num_x / num_y);
            Console.WriteLine($"The value of {num1} divided by {num2} is:  {num_z}");
            return;

        }
        public static void MyMod(int num1, int num2)
        {
            //Convert num1 & num2 to Decimal to accurately process modulus
            decimal num_x = Convert.ToDecimal(num1);
            decimal num_y = Convert.ToDecimal(num2);
            decimal num_z = (num_x % num_y);
            Console.WriteLine($"The modulus of {num1} divided by {num2} is:  {num_z}");
            return;

        }
    }
}
