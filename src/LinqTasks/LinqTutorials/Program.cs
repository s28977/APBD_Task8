using System;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            var backendEmps = LinqTasks.Task1();
            foreach (var emp in backendEmps)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
