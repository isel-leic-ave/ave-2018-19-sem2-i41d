using System;
using System.Reflection;

class Program {

    static void PrintMethods(Type klass) {
        MethodInfo[] methods = klass.GetMethods();
        foreach (MethodInfo m in methods)
        {
            Console.Write("     " + m.Name);
            ParameterInfo[] args = m.GetParameters();
            if(args.Length == 0) {
                Console.WriteLine();
                continue;
            }
            string res = "";
            foreach (ParameterInfo p in args)
            {
                res += p.ParameterType.Name + " ";
            }
            Console.WriteLine("({0})", res);
        }
    }

    static void Inspect(string path) {
        Assembly asm = Assembly.LoadFrom(path);
        Type[] types = asm.GetTypes();
        foreach (Type t in types)
        {
            Console.WriteLine(t.Name);
            PrintMethods(t);
        }
    }
    static void Main() {
        Inspect("RestSharp.dll");
    }
}