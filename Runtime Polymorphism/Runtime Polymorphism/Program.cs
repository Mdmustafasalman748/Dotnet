using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runtime_Polymorphism
{
    /* Runtime Polymorphism means override the base class method in the derived class
     * by creating a similar function.
     * We can achieve this by using override and virtual keywords and the inheritance principle.
     */

    public abstract class Employee
    {
        public int Empid;
        public string Empname;
        public string Empgender;
        public Employee(int Empid,string Empname,string Empgender)
        {
            this.Empid = Empid;
            this.Empname = Empname;
            this.Empgender = Empgender;
        }
        public abstract double CalSal(double SPD, double NOD);
        public virtual void Display()
        {
            Console.WriteLine("Empid:0} Empname:{1} Empgender:{2}",Empid,Empname,Empgender);
        }
    }
    public class Developer : Employee
    {
        public string Tech;
        public Developer(int Empid, string Empname, string Empgender, string Tech) : base(Empid, Empname, Empgender)
        {
            this.Tech = Tech;
        }
        public override double CalSal(double SPD, double NOD)
        {
            double Salary = (SPD * NOD) + 5000;
            return Salary;
        }
        public override void Display() {
            Console.WriteLine("Empid:{0} Empname:{1} Empgender:{2} Tech:{3}", Empid,Empname,Empgender,Tech);
    }
    }
    public class Tester : Employee
    {
        public string Tool;
        public Tester(int Empid, string Empname, string Empgender, string Tool) : base(Empid, Empname, Empgender)
        {
            this.Tool = Tool;
        }
        public override double CalSal(double SPD, double NOD)
        {
            double Salary = (SPD * NOD) + 2000;
            return Salary;
        }
        public override void Display()
        {
            Console.WriteLine("Empid:{0} Empname:{1} Empgender:{2} Tool:{3}", Empid, Empname, Empgender, Tool);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee E;
            E = new Developer(0000, "XXXX", "XXXX", "XXXX");
            Console.WriteLine("Select 1.Developer 2.Tester");
            int ch=int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    E = new Developer(100, "John", "Male", "Dotnet");
                    E.CalSal(2000, 22);
                    E.Display(); 
                    break;
                case 2:
                    E = new Tester(101, "James", "Male", "Automation");
                    E.CalSal(1500, 22);
                    E.Display();
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
            Console.ReadLine();
        }
    }
}
