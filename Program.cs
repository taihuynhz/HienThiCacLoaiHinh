using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HienThiCacLoaiHinh
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Menu");
            Console.WriteLine("1. Print the rectangle");
            Console.WriteLine("2. Print the square triangle (The corner is square at 4 different angles: top-left, top-right, botton-left, botton-right)");
            Console.WriteLine("3. Print isosceles triangle");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {   
                case 1:

                    Console.Write("Enter the width of the rectangle: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the length of the rectangle: ");
                    int y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    for (int i = 1; i <= x; i++)
                    {
                        for (int j = 1; j <= y; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 2:

                    Console.Write("Enter the height of the square triangle: ");
                    int h = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    Console.WriteLine("Top-left square triangle \n");
                    for (int i = h; i >= 1; i--)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();

                    Console.WriteLine("Top-right square triangle \n");
                    for (int i = h; i >= 1; i--)
                    {
                        for (int j = 1; j <= h; j++)
                        {
                            if (j <= h - i)
                            {
                                Console.Write("  ");
                            }
                            else
                            {
                                Console.Write("* ");
                            }
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();

                    Console.WriteLine("Botton-left square triangle \n");
                    for (int i = 1; i <= h; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();

                    Console.WriteLine("Botton-right square triangle \n");
                    for (int i = 1; i <= h; i++)
                    {
                        for (int j = 1; j <= h; j++)
                        {
                            if(j <= h - i)
                            {
                                Console.Write("  ");
                            }
                            else
                            {
                                Console.Write("* ");
                            }
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    break;

                case 3:

                    Console.Write("Enter the height of the isosceles triangle: ");
                    int g = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i <= g; i++)
                    {
                        for (int j = 1; j <= g - i; j++)
                        {                          
                                Console.Write("  ");                       
                        }
                        for (int j = 1; j <= 2 * i - 1; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("No choice!");
                    break;
            }
        }
    }
}
