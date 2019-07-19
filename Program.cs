using System;

namespace SquareSolves
{
    internal class Program
    {
        private static void Main(string[] args)
        {
           bool isOk = true;

            do
            {
                try
                {
                    isOk = true;

                    double a = InsertVariable("a");
                    double b = InsertVariable("b");
                    double c = InsertVariable("c");

                    if (CheckSolves(a, b, c))
                    {
                        Console.WriteLine("\nПервый корень равен {0}", RootValue(a, b, c, true));
                        Console.WriteLine("\nВторой корень равен {0}", RootValue(a, b, c, false));
                    }
                    else
                    {
                        Console.WriteLine("\n\nС такими параметрами дискриминант меньше 0,\n корни невещественные.");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex+"\n");
                    isOk = false;
                }

            } while (!isOk);
            

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        /// <summary>
        /// Parse inserted double number
        /// </summary>
        /// <param name="variable">Char inserted argument</param>
        /// <returns>Return parsed integer inserted</returns>
        private static double InsertVariable(string variable)
        {
            Console.Write($"Insert value {variable}: ");
            try
            {
                return double.Parse(Console.ReadLine());
            }
            catch (NotFiniteNumberException nfe)
            {
                Console.WriteLine("Exception is '+' infinity or '-' infinity or NaN: " + nfe.Message);
                return 0;
            }

        }

        /// <summary>
        /// Calculate first or second root
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="root1">Is first root</param>
        /// <returns>Return root</returns>
        private static double RootValue(double a, double b, double c, bool root1)
        {
            if (root1)
            {
               return (-b + Math.Sqrt(Discriminant(a, b, c))) / (2 * a);               
            }
            else
            {
                return (-b - Math.Sqrt(Discriminant(a, b, c))) / (2 * a);
            }
        }
        /// <summary>
        /// Check Discriminant is positive number
        /// </summary>
        /// <param name="a">a argument in a∗x2+b∗x+c=0></param>
        /// <param name="b">b argument in a∗x2+b∗x+c=0</param>
        /// <param name="c">c argument in a∗x2+b∗x+c=0</param>
        /// <returns></returns>
        private static bool CheckSolves(double a, double b, double c)
        {
            return Discriminant(a, b, c) >= 0;
        }

        /// <summary>
        /// Calculate Discriminant
        /// </summary>
        /// <param name="a">a argument in a∗x2+b∗x+c=0</param>
        /// <param name="b">b argument in a∗x2+b∗x+c=0</param>
        /// <param name="c">c argument in a∗x2+b∗x+c=0</param>
        /// <returns></returns>
        private static double Discriminant(double a, double b, double c)
        {
            return (b * b - 4 * a * c); 
        }
    }
}
