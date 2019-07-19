using System;
using QuadraticEquationLibrary;
//Введите значение a: 2
//Введите значение b: 3
//Введите значение c: 3
//Дискриминант меньше 0, корни невещественные.
//Для закрытия данного окна нажмите <ВВОД>...

//Введите значение a: 2
//Введите значение b: 6
//Введите значение c: 4
//Первый корень равен -1
//Второй корень равен -2
//Для закрытия данного окна нажмите<ВВОД>...

namespace QuadraticEquation
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
                    using (QuadraticSolves q = new QuadraticSolves())
                    {
                        q.A = q.InsertVariable("a");
                        q.B = q.InsertVariable("b");
                        q.C = q.InsertVariable("c");

                        if (q.CheckDiscriminant())
                        {
                            Console.WriteLine("\nПервый корень {0}", q.RootValue(true));
                            Console.WriteLine("\nВторой корень {0}", q.RootValue(false));
                        }
                        else
                        {
                            Console.WriteLine("\n\nС такими параметрами дискриминант меньше 0,\n корни невещественные.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex + "\n");
                    isOk = false;
                }

            } while (!isOk);

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
