using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Class_Method
{
    /*Sealed class
     * A class which is declared with a keyword sealed is known as sealed class.
     * Sealed class stops the inheritance.
     * We can create the object and reference of the sealed class.
     * 
     * Sealed Method
     * A method which is declared with a keyword sealed is known as sealed method.
     * Sealed method cannot be override in the derived class.
     * Sealed method always comes with the override keyword.
     */

    public sealed class Student
    {
        public int Sid;
        public string SName;
        public string SClass;
        public Student(int sid, string sName, string sClass)
        {
            this.Sid = sid;
            this.SName = sName;
            this.SClass = sClass;
        }
        public void Display()
        {
        }
        public sealed string Result(int M1, int M2)
        {
            if ((M1 + M2) / 2 > 35)
            {
                return "Passed";
            }
            else
            {
                return "Failed";
            }
        }
        public class NewStudent : Student
        {
            public NewStudent(int Sid, string SName, string SClass, string SContact) : base(Sid, SName, SClass)
            {
                this.SContact = SContact;
            }
            public void show()
            {
                Console.WriteLine("Sid:{0} SName:{1} SClass:{2} SContact:{3}", Sid, SName, SClass, SContact);
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Student obj = new Student(100, "John", "Tenth");
                obj.Display();
                NewStudent obj1 = new NewStudent(101, "John", "Ninth", "+91");
                obj1.show();
                Console.ReadLine();
            }
        }
    }
}
