using System;

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
        }
    }
}