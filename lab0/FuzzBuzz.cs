using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab0
{
    internal class FuzzBuzz
    {
        int top = 0;

        public FuzzBuzz(int t) {
            top = t;
        }

        public void display()
        {
            for(int i = 1; i < top + 1; i++)
            {
                if(i % 3 == 0 && i % 5 ==0)
                {
                    Console.WriteLine("FizzBuzz");
                }else if(i % 3 == 0) {
                    Console.WriteLine("Fizz");
                }else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }else { Console.WriteLine(i); }
            }
        }

    }
}
