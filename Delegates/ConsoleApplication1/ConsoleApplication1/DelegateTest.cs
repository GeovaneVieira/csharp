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

        public string StaticMethod(int i)
        {
            return string.Format("Static method: {0}", i);
        }

        static void Main(string[] args)
        {

        }
    }
}
