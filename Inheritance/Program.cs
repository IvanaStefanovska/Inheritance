﻿using System;
using Classes;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("Ivana", "Stefanovska");
            manager.PrintInfo();
            manager.AddBonus(3000);
            Console.WriteLine("Salary: {0}", manager.GetSalary());
            Console.WriteLine("------------------------------------");

            SalesPerson sales01 = new SalesPerson("Random1", "Random2");
            sales01.PrintInfo();
            sales01.ExtendSuccessSaleRevenue(1500);
            Console.WriteLine("Salary: {0}", sales01.GetSalary());


            Console.ReadLine();
        }
    }
}
