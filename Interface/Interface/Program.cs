using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    /*Interface
     * Interface is a purely abstract class.
     * Intereface contains only abstract members.
     * With interface we can achieve multi level inheritance.
     * It is not mandatory but is a thumb rule of microsoft to use I as 
     * prefix for every interface.
     * Interface is by default public and abstract, there is no need to define 
     * access specifier and override.
     * In interface it is mandatory to call the abstract method.*/

    public interface IEmployee
    {
       double CalSal(int SPD, int NOD);
    }
    public interface IEmployee1
    {
        double CalSal(int SPD, int NOD);
    }
    public class Salary : IEmployee
    {
        public double CalSal(int SPD,int NOD)
        {
            double salary=SPD*NOD;
            return salary;
        }
    }
    public class Developer : Salary, IEmployee
    {
        public double CalSal(int SPD,int NOD)
        {
            double salary=(SPD*NOD)+5000;
            return salary;
        }
    }
    
        internal class Program
        {
            static void Main(string[] args)
        {
            Developer d = new Developer();
            double salary=d.CalSal(2000, 22);
            Console.WriteLine("Your salary is:"+salary);
            Console.ReadLine();
        }
    }
}