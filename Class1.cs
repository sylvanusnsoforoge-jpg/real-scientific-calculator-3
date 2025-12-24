using System;
using static System.Math;
namespace My_new_project_scientific_calculator
{
    class Class1
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter your operation of choice");
                Console.WriteLine("+: Addition");
                Console.WriteLine("-: Subtraction");
                Console.WriteLine("*: Multiplication");
                Console.WriteLine("/: Division");
                Console.WriteLine("^: power x^y");
                Console.WriteLine("%: Modulus x%y");
                Console.WriteLine("s: Sine (sin(x))");
                Console.WriteLine("c: Cosine (cos(x))");
                Console.WriteLine("t: Tansine (tan(x))");
                Console.WriteLine("q: Exit the program");
                Console.WriteLine("Enter your Option");

                String Operation = Console.ReadLine();
                Console.ReadLine().ToLower();

                if (Operation == "q")
                {
                    break;
                }
                else if (Operation == "s" || Operation == "c" || Operation == "t") 
                {
                    Console.WriteLine("Enter a single number (in degrees)");
                    double num = Convert.ToDouble(Console.ReadLine());
                    

                    switch (Operation)
                    {
                        case "s":
                            double radiansSin = num * Math.PI / 180.0;
                            Console.WriteLine($"Result: sin({num}) = {Math.Sin(radiansSin)}");
                            break;

                        case "c":
                            double radiansCos = num * Math.PI / 180.0;
                            Console.WriteLine($"Result: cos({num}) = {Math.Cos(radiansCos)}");
                            break;

                        case "t":
                            double radiansTan = num * Math.PI / 180.0;
                            Console.WriteLine($"Result: tan({num}) = {Math.Tan(radiansTan)}");
                            break;


                    }

                    
                }
                else
                {
                    Console.WriteLine(" Enter your First Number");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(" Enter your second Number");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    double result = 0;

                    switch (Operation)
                    {
                        case "+":
                            result = num1 + num2;
                            Console.WriteLine($"Result: {num1}+{num2} = {result}");
                            break;

                        case "-":
                            result = num1 - num2;
                            Console.WriteLine($"Result: {num1}-{num2} = {result}");
                            break;


                        case "*":
                            result = num1 * num2;
                            Console.WriteLine($"Result: {num1}*{num2} = {result}");
                            break;

                        case "/":
                            if(num2==0)
                                Console.WriteLine("Error: cannot divide by Zero");

                            else if(num2!=0)
                                result = num1 / num2;
                            Console.WriteLine($"Result: {num1}/{num2} = {result}");
                            break;

                        case "%":
                            result = num1 % num2;
                            Console.WriteLine($"Result: {num1}%{num2} = {result}");
                            break;

                        case "^":
                            result = Pow(num1, num2);
                            Console.WriteLine($"Result: {num1}^{num2} = {result}");
                            break;

                       
          
                        default:
                            Console.WriteLine("this is an invalid option, please try again");
                            break;
                    }
                }
                Console.WriteLine("/npress any key to continue");
                Console.ReadKey();
            }
        }
    }


}
