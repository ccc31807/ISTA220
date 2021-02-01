using System;

namespace progex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPart 1, circumference and area of a circle.");
            int intradius = GetInput("Enter an integer for the radius: ");
            double circumference = 2 * Math.PI * intradius;
            Console.WriteLine($"The circumference is {circumference}");
            double area = Math.PI * intradius * intradius;
            Console.WriteLine($"The area is {area}");

            Console.WriteLine("\nPart 2, volume of a hemisphere.");
            intradius = GetInput("Enter an integer for the radius: ");
            double numerator = (4.0 / 3.0) * Math.PI * intradius * intradius * intradius;
            double denominator = 2.0;
            double volume = numerator / denominator;
            Console.WriteLine($"The volume is {volume}");

            Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");
            int a = GetInput("Enter an integer for side a: ");
            int b = GetInput("Enter an integer for side b: ");
            int c = GetInput("Enter an integer for side c: ");
            double p = (a + b + c) / 2;
            area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"The area is {area}");

            Console.WriteLine("\nPart 4, solving a quadratic equation.");
            a = GetInput("Enter an integer for coefficient a: ", true);
            b = GetInput("Enter an integer for coefficient b: ", true);
            c = GetInput("Enter an integer for coefficient c: ", true);
            double positive_num = (b * -1) + Math.Sqrt(b * b - 4 * a * c);
            double negative_num = (b * -1) - Math.Sqrt(b * b - 4 * a * c);
            denominator = 2 * a;
            Console.WriteLine($"The positive solution is {positive_num / denominator}");
            Console.WriteLine($"The negative solution is {negative_num / denominator}");
        }

        private static int GetInput(string prompt, bool quad = false)
        {
            begin:
            Console.Write(prompt);
            string strradius = Console.ReadLine();
            int intradius;
            try
            {
                intradius = int.Parse(strradius);
                //if (intradius == 0 && !quad)
                //    throw new DivideByZeroException();
                if (intradius < 1 && !quad)
                    throw new ArgumentOutOfRangeException();
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("You must enter a value.");
                goto begin;
            }
            catch (FormatException)
            {
                Console.WriteLine("You must enter a valid number.");
                goto begin;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Your number is out of range");
                goto begin;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                goto begin;
            }
            finally
            {
                Console.WriteLine("Okay");
            }
            return intradius;


        }
    }
}
