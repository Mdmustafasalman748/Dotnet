using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    interface IStudent
    {
        void Marks(int M1,int M2);
    }
    public class NewStudent
    {
        public void Display()
        {
            Console.WriteLine("This is a New Student class");
        }
    }
    public class NewNewStudent : NewStudent, IStudent
    {
        public void Show()
        {
            Console.WriteLine("This is NewNewStudent Class");
        }
        public void Marks(int M1,int M2)
        {
            int M3 = M1 + M2;
            Console.WriteLine("Your total is:"+M3);
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            NewNewStudent obj= new NewNewStudent();
            obj.Display();
            obj.Show();
            obj.Marks(50, 70);
            Console.ReadLine();
            
        }
    }
}
