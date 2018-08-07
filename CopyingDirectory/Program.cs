using System;
using CopyingLibrary;

namespace CopyingDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            string source=null;
            string target=null;

            Class1 test = new Class1();

            Console.WriteLine("Welcome to CopyingDirectory");
            Console.WriteLine("Input source directory path: ");
            source = Console.ReadLine();
            //source = "C:\\Users\\Vandalay\\Documents\\testFolder";
            Console.WriteLine("Input target directory path: ");
            target = Console.ReadLine();
            //target = "C:\\Users\\Vandalay\\Documents\\testOutput";
           
            Console.WriteLine("Source path is {0}: " , source);
            Console.WriteLine("Target path is {0}: ", target);

            if (string.IsNullOrEmpty(source) || string.IsNullOrEmpty(target))
            {
                Console.WriteLine("Source and target paths can't be empty!");
            }
            else
            {
                test.CopyingMethod(source, target);
            }
                    
           
            Console.WriteLine("Press any key to exit program");
            Console.ReadKey();

        }
    }
}
