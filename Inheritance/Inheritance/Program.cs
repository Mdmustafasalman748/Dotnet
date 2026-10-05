using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Inheritance
{
    /* Inheritance 
     * Inheritance means extending the functionality of an existing class.
     * 
     * Base Class - Base class is used to refer the members of the base class.
     * It is used to invoke a constructor from a constructor of its immediate base class.
     * 
     * Virtual Method - A method which is declared with a keyword virtual is known as virtual method.
     * It may or may not override the derived class
     */

    public class Student
    {
        protected int Sid;
        protected string SName;
        protected string SClass;
        public Student(int Sid, string SName, string SClass)
        {
            this.Sid = Sid;
            this.SName = SName;
            this.SClass = SClass;
        }
        public virtual void Display()
        {
            Console.WriteLine("Sid:{0} SName:{1} SClass:{2}",Sid,SName,SClass);
        }
    }
    public class NewStudent : Student
    {
        public string SGender;
        public NewStudent(int Sid, string SName, string SClass, string SGender) : base(Sid, SName, SClass)
        {
            this.SGender = SGender;
        }
        public override void Display()
        {
            //It will execute existing functionality
            //remove base.display(); from here
            Console.WriteLine("Sid:{0} SName:{1} SClass:{2} SGender:{3}", Sid, SName, SClass, SGender);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student obj = new Student(100, "John", "Tenth");
            obj.Display();
            NewStudent obj1 = new NewStudent(101, "James", "Ninth", "Male");
            obj1.Display();
            Console.ReadLine();
        }
    }
}
