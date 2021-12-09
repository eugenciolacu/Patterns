using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proxy is a structural design pattern that lets you provide a substitute or placeholder for another object. " +
                "A proxy controls access to the original object, allowing you to perform something either before or after the request gets through to " +
                "the original object.");
            Console.WriteLine();

            Console.WriteLine("Client passing employee with Role Developer to folderproxy");
            Employee emp1 = new Employee("Eugen", "1234", "Developer");
            SharedFolderProxy folderProxy1 = new SharedFolderProxy(emp1);
            folderProxy1.PerformRWOperations();
            
            Console.WriteLine();

            Console.WriteLine("Client passing employee with Role Manager to folderproxy");
            Employee emp2 = new Employee("Mihai", "1234", "Manager");
            SharedFolderProxy folderProxy2 = new SharedFolderProxy(emp2);
            folderProxy2.PerformRWOperations();
        }
    }
}
