using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodTest
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class ClaseA
    {

    }
    public class MiClase<T>
    {
        T value;

        public MiClase(T t)
        {
            this.value = t;
        }

        public void Write()
        {
            Console.WriteLine(this.value);
        }
    }
}
