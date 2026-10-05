using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    /* Properties bring private variable indirectly outside the class*/
    public class Student
    {
        int Sid;
        string SName;
        string SClass;
        int M1, M2, M3;
        public Student(int Sid, string SName, string SClass)
        {
            this.Sid = Sid;
            this.SName = SName;
            this.SClass = SClass;
        }
        public int _Sid
        {
            get { return this.Sid; }
        }
        public string _SName
        {
            get { return this.SName; }
        }
        public string _SClass
        {
            get { return this.SClass; }
        }
        public int _M1
        { 
         get { return this.M1; }
         set { this.M1 = value; }
        }

        public int _M2
        {
            get { return this.M2; }
            set { this.M2 = value; }
        }
        public int _M3
        {
            get { return this.M3; }
            set { this.M3 = value; }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student obj = new Student(100, "Alex", "Tenth");
            obj._M1 = 50;
            obj._M2 = 60;
            obj._M3 = 70;
            Console.WriteLine("Marks1:{0} Marks2:{1} Marks3:{2}",obj._M1,obj._M2,obj._M3);
            Console.WriteLine("Sid:{0} SName:{1} SClass:{2}",obj._Sid,obj._SName,obj._SClass);
            Console.ReadLine();
        }
    }
}
