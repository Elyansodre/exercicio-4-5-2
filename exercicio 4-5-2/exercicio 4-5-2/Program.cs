﻿using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, soma;
            x = int.Parse(Console.ReadLine());
            soma = 0;
            while (x != 0)
            {
                soma = soma + x;
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(soma);
            Console.ReadLine();

        }
    }
}