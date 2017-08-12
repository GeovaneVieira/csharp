using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public delegate string FirstDelegate(int x);
    class DelegateTest
    {
        string name;

        public string InstanceMethod(int i) 
        {
            return string.Format("{0}: {1}", name, i);
        }

        static string StaticMethod(int i)
        {
            return string.Format("Static method: {0}", i);
        }

        static void Main(string[] args)
        {
            FirstDelegate d1 = new FirstDelegate(DelegateTest.StaticMethod);
            DelegateTest instance = new DelegateTest();
            instance.name = "My instance";
            FirstDelegate d2 = new FirstDelegate(instance.InstanceMethod);

            Console.WriteLine(d1(10));
            Console.WriteLine(d2(5));

            Console.WriteLine(d1.Invoke(20));
            Console.WriteLine(d2.Invoke(15));
            Console.ReadLine();

        }
    }
}
