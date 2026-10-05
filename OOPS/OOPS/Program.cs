using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class FirstClass
    {
        public void Display()
        {
            Console.WriteLine("MS");
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            FirstClass obj= new FirstClass();
            obj.Display();
            Console.ReadLine();
            /*OOPS - Object Oriented Programming Structure
             *Objects contains looks/feels and behaviour
             *Example: Mobile looks/feels: brand, color, material, size, camera. behaviour: calling, texting, browsing, gaming, entertainment
             *Object: object is a real time entity. Objects has looks feels and behaviour.
             *Syntax: classname objectname= new classname();
             *Class: It is the blueprint of an object. Class contains properties and methods.
             *Syntax: Access specifier class classname
             *{
             *}
             *Method: method contains logic and functionality.
             *Syntax: Access specifier returntype methodname()
             *{
             *}
             *Access Specifier: It defines the scope of a particular class.
             *Public - All over the application
             *Private - Only within the class
             *Protected - It is a protected class
             */


        }
    }
}
