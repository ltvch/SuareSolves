using System;

namespace QuadraticEquationLibrary
{
    public class QuadraticSolves : IDisposable
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        /// <summary>
        /// Parse inserted double number
        /// </summary>
        /// <param name="variable">Char inserted argument</param>
        /// <returns>Return parsed integer inserted</returns>
        public double InsertVariable(string variable)
        {
            Console.Write($"Insert value {variable}: ");
            return double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Calculate first or second root
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="root1">Is first root</param>
        /// <returns>Return root</returns>
        public double RootValue(bool root1)
        {
            if (root1)
            {
                return (-B + Math.Sqrt(Discriminant())) / (2 * A);
            }
            else
            {
                return (-B - Math.Sqrt(Discriminant())) / (2 * A);
            }
        }

        /// <summary>
        /// Check Discriminant is positive number
        /// </summary>
        /// <param name="a">a argument in a∗x2+b∗x+c=0></param>
        /// <param name="b">b argument in a∗x2+b∗x+c=0</param>
        /// <param name="c">c argument in a∗x2+b∗x+c=0</param>
        /// <returns></returns>
        public bool CheckDiscriminant()
        {
            return Discriminant() >= 0;
        }

        /// <summary>
        /// Calculate Discriminant
        /// </summary>
        /// <param name="a">a argument in a∗x2+b∗x+c=0</param>
        /// <param name="b">b argument in a∗x2+b∗x+c=0</param>
        /// <param name="c">c argument in a∗x2+b∗x+c=0</param>
        /// <returns></returns>
        private double Discriminant()
        {
            if(A != 0)
            return B * B - 4 * A * C;
            else
                throw new Exception("A cant be ziro.");
        }

        /// <summary>
        /// Realize Dispose for IDisposable
        /// </summary>
        public void Dispose()
        {
            // Console.WriteLine("Dispose()");
        }
    }
}
