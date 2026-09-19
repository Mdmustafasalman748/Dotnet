using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Class
{
    /*Partial Class
     * A class which is declared with a keyword partial is known as partial class.
     * Partial class will allow you to create two classes with same name.
     * We can create object and reference of a partial class.
     */

    public partial class Student
    {
        public void Display()
        {
            Console.WriteLine("This is the display method");
        }
    }
    public partial class Student
    {
        public void Show()
        {
            Console.WriteLine("This is the show method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Display();
            s.Show();
            Console.ReadLine();
        }
    }
}
