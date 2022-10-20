using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _29Augpro1
{
    class data<T>
    {


        static int max = 1000;
        T[] values= new T[max];
        int top = -1;

        public void Push(T s)
        {
            if(top >= 1000)
            {
                Console.WriteLine("can not able to push");

            }
            else
            {
                values[++top] = s;
                    
            }
        }
        public  void Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("cannot be popped");
            }
            else
            {
                T s=values[top--];
                Console.WriteLine(s);
            }
        }
        public  T Peek()
        {
            if (top < 0)
            {
             
                return default(T);            }
            else
            {
                T s= values[top];
                return s;
            }
        }
        public void printingData()
        {
            for (int i = top; i >=0; i--)
            {
                Console.WriteLine(values[i]);
            }
        }

    }
}    
