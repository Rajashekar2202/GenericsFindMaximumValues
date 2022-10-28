using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class TestCode
    {
  
        public static void TestCase1Float()
        {
            float result = Maximum.MaximumFloat(21.5f, 8.5f, 15.7f);
            Console.WriteLine("\nIn First Case Maximum Number is " + result);
        }

        public static void TestCase2Float()
        {
            float result = Maximum.MaximumFloat(2.6f, 15.4f, 1.5f);
            Console.WriteLine("\nIn Second case Maximum Number is " + result);
        }

        public static void TestCase3Float()
        {
            float result = Maximum.MaximumFloat(2.6f, 8.5f, 15.7f);
            Console.WriteLine("\nIn Third Case Maximum Number is " + result);
        }


    }
}
