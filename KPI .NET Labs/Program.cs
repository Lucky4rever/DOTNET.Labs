﻿using DOTNET_Labs.Variant13.NET3;
using DOTNET_Labs.Variant13.NET4;
using DOTNET_Labs.Variant13.NET5;
using System;

namespace DOTNET_Labs
{
    class Program {
        static void Main() {
            Lab3 lab3 = Lab3.GetInstance();
            lab3.Var13_Lab3();

            Lab4 lab4 = Lab4.GetInstance();
            lab4.Var13_Lab4();

            Lab5 lab5 = Lab5.GetInstance();
            lab5.Var13_Lab5();

            Console.ReadLine();
        }
    }
}
