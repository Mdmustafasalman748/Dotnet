using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Method_Overloading
{
    /*Static Polymorphism / Static Binding
     * Static polymorphism is the linking of a function with an object during compile time.
     * Two techniques: 1. Function overloading 2. Operator Overloading */

    /*Method Overloading - In a class, if we have more than one method with same name and different 
     * parameters then it is called method overloading.*/

    public class NewBank
    {
        public int AcNo;
        public string Name;
        public double Balance;
        public string Contact;
        public NewBank(int acno, string name, double balance)
        {
            AcNo = acno;
            Name = name;
            Balance = balance;
        }
        public NewBank(int acno,string name,double balance, string contact)
        {
            AcNo = acno;
            Name = name;
            Balance = balance;
            Contact = contact;
        }
        public void Display()
        {
            Console.WriteLine("AcNo:{0} Name:{1} Balance:{2}", AcNo, Name, Balance);
        }
        public void Show()
        {
            Console.WriteLine("AcNo:{0} Name:{1} Balance:{2} Contact:{3}", AcNo, Name, Balance, Contact);
        }
        public void Show(string Name)
        {
            Console.WriteLine("Your name is" + Name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            NewBank obj = new NewBank(100, "John", 500);
            obj.Display();
            NewBank obj1 = new NewBank(101, "James", 800, "4365732");
            obj1.Show();
            obj1.Show("Peter");
            Console.ReadLine();
        }
    }
}
