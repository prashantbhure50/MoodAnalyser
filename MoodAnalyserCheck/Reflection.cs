using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserCheck
{
    class Reflection
    {
        public static void ReflectionTest()
        {
           Type type = Type.GetType("MoodAnalyserCheck.MoodAnalyser");
            Console.WriteLine("Full Name :{0}", type.FullName);
            Console.WriteLine("Class name is : {0}", type.Name);
            Console.WriteLine("Methods in customerInfo class");
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }
            Console.WriteLine("Properties in MoodAnalyser class");
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }

            Console.WriteLine("Constructors in MoodAnalyser class");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }

    }
}
