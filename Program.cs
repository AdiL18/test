using System;

namespace git_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! this is test");

            var projectName = "x-project";
            Console.WriteLine("start project:" + projectName);
            for (int i = 0; i < 200; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
