using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Process1
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.LoadFrom(@"..\..\..\XmlLibrary\bin\Debug\Print.dll");
            AppDomain.CurrentDomain.Load(assembly.GetName());
            Type t = assembly.GetType("Print.Class1");
            dynamic instance = Activator.CreateInstance(t);
            instance.Display("Process1");
            Console.ReadLine();
        }
    }
}
