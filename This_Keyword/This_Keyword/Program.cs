using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_Keyword
{
    /*This keyword - This keyword is used to refer the members of the class.
     * It is used to invoke a constructor from a constructor within the class.*/
    public class Bank
    {
        public int AcNo;
        public string Name;
        public double Balance;
        public string Contact;
        public Bank(int AcNo, string Name, double Balance)
        {
            this.AcNo = AcNo;
            this.Name = Name;
            this.Balance = Balance;
        }
        public Bank(int AcNo, string Name, double Balance, string Contact) : this(AcNo, Name, Balance)
        {
            this.Contact = Contact;
        }
        public void Display()
        {
            Console.WriteLine("AcNo:{0} Name:{1} Balance:{2}",AcNo,Name,Balance);
        }
        public void Show()
        {
            Console.WriteLine("AcNo:{0} Name:{1} Balance:{2} Contact:{3}",AcNo, Name,Balance,Contact);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank obj = new Bank(100, "John", 500);
            obj.Display();
            Bank obj1 = new Bank(101, "James", 800, "4365737");
            obj1.Show();
            Console.ReadLine();
        }
    }
}
