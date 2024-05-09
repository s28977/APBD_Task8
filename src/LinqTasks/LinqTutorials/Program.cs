﻿using System;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            var task1 = LinqTasks.Task1();
            Console.WriteLine("Task 1");
            foreach (var emp in task1)
            {
                Console.WriteLine(emp.Job);
            }

            Console.WriteLine();

            var task2 = LinqTasks.Task2();
            Console.WriteLine("Task 2");
            foreach (var emp in task2)
            {
                Console.WriteLine(emp.Ename + " " + emp.Job + " " + emp.Salary);
            }

            Console.WriteLine();

            Console.WriteLine("Task 3");
            Console.WriteLine(LinqTasks.Task3());

            Console.WriteLine();

            var task4 = LinqTasks.Task4();
            Console.WriteLine("Task 4");
            foreach (var emp in task4)
            {
                Console.WriteLine(emp.Ename + " " + emp.Salary);
            }

            Console.WriteLine();

            var task5 = LinqTasks.Task5();
            Console.WriteLine("Task 5");
            foreach (var emp in task5)
            {
                Console.WriteLine(emp);
            }

            Console.WriteLine();

            var task6 = LinqTasks.Task6();
            Console.WriteLine("Task 6");
            foreach (var emp in task6)
            {
                Console.WriteLine(emp);
            }

            Console.WriteLine();
            
            var task7 = LinqTasks.Task7();
            Console.WriteLine("Task 7");
            foreach (var emp in task7)
            {
                Console.WriteLine(emp);
            }

            Console.WriteLine();
            
            Console.WriteLine("Task 8");
            Console.WriteLine(LinqTasks.Task8());

            Console.WriteLine();
            
            Console.WriteLine("Task 9");
            var e = LinqTasks.Task9();
            Console.WriteLine(e.Ename + " " + e.HireDate);

            Console.WriteLine();
            
            

        }
    }
}