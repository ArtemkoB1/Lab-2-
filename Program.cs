using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_А_та_П
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task 1");
            Console.WriteLine("Enter the value of x:");
            double x = Convert.ToDouble(Console.ReadLine());
            double a = 1.5;
            double y=0;
                if (x < 1.3)
             y = (Math.PI * Math.Pow(x, 2)) - 7 / Math.Pow(x, 2);
                if (x == 1.3)
             y = a * Math.Pow(x, 3) + 7 / Math.Sqrt(x);
                if (x > 1.3)
             y = Math.Tan(x + 7 * Math.Sqrt(x));
             Console.WriteLine($"The value of y {y}");
             Console.ReadKey();

            Console.WriteLine("task 2");
            Console.Write("Enter the purchase amount:");
            double purchaseAmount = Convert.ToDouble(Console.ReadLine());
            double discount = 0;
               if (purchaseAmount > 1000)
            discount = 0.05;
               else if (purchaseAmount > 500)
            discount = 0.03;
            double finalAmount = purchaseAmount - (purchaseAmount * discount);
             Console.WriteLine($" Discount:{discount * 100}%");
             Console.WriteLine($"Amount due after discount: {finalAmount} грн");
             Console.ReadKey();


            Console.WriteLine("task 3");
            Console.WriteLine("Enter a number(up to 5 inclusive)");
            int number = Convert.ToInt32(Console.ReadLine());
            int numDigits = number.ToString().Length;
            int product = 1;
            switch (numDigits)
            {
                case 1:
                    product = number;
                    break;
                case 2:
                    product = (number / 10) * (number % 10);
                    break;
                case 3:
                    product = (number / 100) * ((number / 10) % 10) * (number % 10);
                    break;
                case 4:
                    product = (number / 1000) * ((number / 100) % 10) * 
                        ((number / 10) % 10) * (number % 10);
                    break;
                case 5:
                    product = (number / 10000) * ((number / 1000) % 10) * 
                           ((number / 100) % 10) *((number / 10) % 10) * (number % 10);
                    break;
                default:
                    Console.WriteLine("The number contains more than 5 digits or less than 1 digit!");
                    return;
            }
            Console.WriteLine($"The product of the digits of a number {number} = {product}");
            Console.ReadKey();





        }
    }
}
