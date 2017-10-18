﻿namespace P03_Printing_Triangle
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangleHeader(n);
            PrintTriangleBody(n);
            PrintTriangleFooter(n);
        }

        public static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        public static void PrintTriangleHeader(int n)
        {
            for (int i = 0; i < n; i++)
            {
                PrintLine(1, i);
            }
        }

        public static void PrintTriangleBody(int n)
        {
            PrintLine(1, n);
        }

        public static void PrintTriangleFooter(int n)
        {
            for (int i = n - 1; i > 0; i--)
            {
                PrintLine(1, i);
            }
        }
    }
}