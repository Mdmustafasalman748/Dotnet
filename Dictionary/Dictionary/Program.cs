using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dictionary<keytype,valuetype> DictionaryName=new Dictionary<keytype,valuetype>();*/
             Dictionary<String,int> age=new Dictionary<string,int>();
            age.Add("John", 23);
            age.Add("James", 27);
            age.Add("Alex", 38);
            age.Remove("John");
            foreach (var item in age)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
