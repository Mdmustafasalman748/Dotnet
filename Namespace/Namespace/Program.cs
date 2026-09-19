using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace
{
    /*Namespace is a collection of classes and namespaces.
     * A namespace can have multiple classes.*/
    class Testing
    {

    }
    class Test1
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test.test1cl obj = new Test.test1cl();
            Test.Dotnet.dt objdt = new Test.Dotnet.dt();
            obj.Display();
            objdt.Display();
            Console.ReadLine();
        }
    }
}
namespace Test
{
    namespace Dotnet
    {
        class dt
        {
            public void Display()
            {
                Console.WriteLine("This is Display1 Method of Dotnet Namespace");
            }
        }
    }
    class test1cl
    {
        public void Display()
        {
            Console.WriteLine("This is Display Method of Test Namespace");
        }
    }
}