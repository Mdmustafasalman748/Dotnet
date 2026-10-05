using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Overloading
{
    /* Constructor Overloading - In a class, if we have more than one constructor with 
     * different parameters then it is called constructor overloading*/
    public class NewBank
    {
        public int AcNo;
        public string Name;
        public double Balance;
        public string Contact;
        public NewBank(int acNo, string name, double balance)
        {
            AcNo = acNo;
            Name = name;
            Balance = balance;
        }
        public NewBank(int acNo, string name, double balance, string contact)
        {
            AcNo = acNo;
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
            Console.WriteLine("Acno:{0} Name:{1} Balance:{2} Contact:{3}", AcNo, Name, Balance, Contact);
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            NewBank obj = new NewBank(100, "John", 500);
            obj.Display();
            NewBank obj1 = new NewBank(101, "James", 800, "4342265");
            obj1.Show();
            Console.ReadLine();
        }
    }
}
