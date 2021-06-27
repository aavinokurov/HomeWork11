using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    interface I1
    {
        void M();
    }

    interface I2
    {
        void M();
    }

    class A : I1, I2
    {
        public void M() { Console.WriteLine("A.M()"); }
        void I1.M() { Console.WriteLine("A.I1.M()"); }
        void I2.M() { Console.WriteLine("A.I2.M()"); }
    }

    class B : A, I1, I2
    {
        void I1.M() { Console.WriteLine("B.I1.M()"); }
        void I2.M() { Console.WriteLine("B.I2.M()"); }
    }
}
