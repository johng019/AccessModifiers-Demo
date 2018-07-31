using System;
using AccessDemo;

namespace ConsoleUI
{
    // Entry Point / Main Method
    class Program
    {
       public static void Main(string[] args)
        {
            AccessDemoTypes demo = new AccessDemoTypes();
            OutsideofAssemblyClass oac = new OutsideofAssemblyClass();
            InAssemblyClass iac = new InAssemblyClass();

            Console.WriteLine("Accessable to Main method DIRECTLY from AccessDemoTypes.cs methods:\r\n");
            demo.PublicModifier();
            Console.WriteLine("\r\n///////////////////////////////////////\r\n");
            Console.WriteLine("Accessable to Main method indirectly through OutsideOfAssemblyClass.cs methods:\r\n");
            oac.GetOutsideAssemblyClassMethods();
            Console.WriteLine("\r\n////////////////////////////////////////\r\n");
            Console.WriteLine("Accessable to Main method indirectly though InAsseblyClass.cs methods:\r\n" );
            iac.GetAccessMethods();
            Console.ReadLine();
        }
    }
}
 