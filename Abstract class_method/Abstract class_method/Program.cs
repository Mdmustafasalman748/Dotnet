using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_method
{
    /*Abstract Class
     * A class which is declared with a keyword abstract is known as abstract class.
     * Abstract class contains abstract as well as non abstract members.
     * We cannot create object of an abstract class but we can create reference of an abstract class.
     * 
     * Abstract Method
     * A method which is declared with a keyword abstract is known as abstract method.
     * Abstract method doesn't contain any body.
     * If we declared abstract method in the base class then we have to override it in the derived class.
     * If a method is abstract then the class should be abstract.
     */

    public abstract class Employee
    {
        public abstract double CalSal(double SPD, double NOD);
    }
    public class NewEmployee : Employee
    {
        public override double CalSal(double SPD, double NOD)
        {
            double Salary = SPD * NOD;
            return Salary;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            NewEmployee obj= new NewEmployee();
            double Salary = obj.CalSal(1500,22);
            Console.WriteLine(Salary);
            Console.ReadLine();
        }
    }
}
