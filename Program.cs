﻿using System;

namespace MamaLis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MamaLis Project !");
            EmployeesSystem a = new EmployeesSystem();
            a.initializeEmployees();
            a.MainMenu();
           


        }
    }
}
