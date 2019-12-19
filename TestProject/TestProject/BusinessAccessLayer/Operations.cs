using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestProject.BusinessAccessLayer
{
    public class Operations
    {
        public int Addition(int a,int b,int c)
        {
            return a + b+c;
            
        }
        public int Subtraction(int a, int b, int c)
        {
            return a - b - c;

        }
         public int Multiplication(int a, int b, int c)
        {

            return a *b *c;

        }
        public void Multiplication(int a, int b, int c,int d)
        {

            int f= a * b * c*d;

        }

    }
}
