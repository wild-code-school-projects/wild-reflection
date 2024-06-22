using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionInspection
{
    internal class Inspection
    {
        private object _objectToInspect;
        public Inspection(object objectToInspect)
        {
            _objectToInspect = objectToInspect;
        }

        public void GetAllProperties()
        {
            Type objectType = _objectToInspect.GetType();

            if (objectType != null)
            {
                PropertyInfo[] properties = objectType.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance);

                Console.WriteLine("Properties");

                foreach (var p in properties)
                {
                    Console.WriteLine($"\t {p.Name} {p.GetValue(_objectToInspect)}");
                }
            }
        }

        public void GetAllFields()
        {
            Type objectType = _objectToInspect.GetType();
            if (objectType != null)
            {
                FieldInfo[] fields = objectType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

                Console.WriteLine("Fields");

                foreach (var f in fields)
                {
                    Console.WriteLine($"\t {f.Name} {f.GetValue(_objectToInspect)}" );
                }
            }
        }

        public void GetAllMethods()
        {
            Type objectType = _objectToInspect.GetType();
            if (objectType != null)
            {
                MethodInfo[] methods = objectType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

                Console.WriteLine("Methods");

                foreach (var m in methods)
                {
                    Console.WriteLine("\t" + m);
                }
            }
        }
    }
}
