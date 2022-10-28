using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class TestCode
    {
       
        public static void TestCase1String()
        {
            string result = Maximum.MaximumString("Peach", "Apple", "Banana");
            Console.WriteLine("\nIn First Case Maximum Number is " + result);
        }

        public static void TestCase2String()
        {
            string result = Maximum.MaximumString("Lion", "Zebra", "Cat");
            Console.WriteLine("\nIn Second case Maximum Number is " + result);
        }

        public static void TestCase3String()
        {
            string result = Maximum.MaximumString("Blue", "Red", "Yellow");
            Console.WriteLine("\nIn Third Case Maximum Number is " + result);
        }
    }
}
