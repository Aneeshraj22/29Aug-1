using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29Augpro1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            data<string> a= new data<string>();

            a.Push("car");
            a.Push("auto");
            a.Push("bike");
            a.Push("bus");
            Console.WriteLine("element to be poped");
            a.Pop();
            Console.WriteLine("peeked....");
            a.Peek();
            Console.WriteLine("print the element currently peeked...");
            string q=a.Peek();          
            Console.WriteLine(q);
            Console.WriteLine("Remaining data.............");
            a.printingData();
            Console.ReadLine();
        }
    }
}
