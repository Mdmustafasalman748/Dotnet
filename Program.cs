using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine() to print
             Console.ReadLine() to hold output
            Every statement ends with a semicolon
            Data Types
            int, douuble, string
            Syntax to define a variable 
            1. Data type 2. Variable name 3. = 4. Value
            */

            int Firstno = 20;
            int Secondno = 30;
            int res=Firstno + Secondno;
            Console.WriteLine("The result is" + res);
            Console.ReadLine();

            /* Taking input from user */
            Console.WriteLine("Enter the first number:");
            int FirstNum=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int SecondNum=int.Parse(Console.ReadLine());
            int result = FirstNum + SecondNum;
            Console.WriteLine("The result is"  +result);
            Console.ReadLine();

            /* Concadenation - Any data type + string */

            /* CONTROL STRUCTURES*/

            /* Conditional statements:
             1. If - one or two conditions
            syntax: if(condition) { 
            statement; 
            }
            
            2. Else if - if more than two conditions
            syntax: else if(condition) 
            {
            statement;
            }

            3. Switch - for options
            syntax: switch(variable name)
            {
            case 1:
               statement;
            case 2:
               statement;
            default:
               statement;
            }
*/

            /*UNCONDITIONAL STATEMENTS*/
            /* 1. goto - to go back to a condition or statement
             2. break - to break the statement and come out of the loop
             3. continue - to continue the iretation in the loop

            Looping 
            1. for - used for finite iterations
            syntax: for(initialization, condition/statement, increment/decrement)
            {
            statement;
            

            2. while - used for infinite iterations
            syntax: while(condition)
            {
            }

            3. foreach - used for collections
            syntax: foreach(datatype in item objectname)
            {
            }

        }
    }
}
