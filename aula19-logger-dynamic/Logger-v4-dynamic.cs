
using System;
using System.Collections.Generic;
using System.Reflection;

public interface IFormat
{
    string Format(object val);
}

[AttributeUsage(AttributeTargets.Property)]
public class IgnoreAttribute : Attribute
{
}

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class LayoutAttribute : Attribute
{
    public IFormat formatter { get; set; }
    public LayoutAttribute(Type klass)
    {
        if (!typeof(IFormat).IsAssignableFrom(klass))
            throw new InvalidOperationException("Layout parameter should be a type inheriting from IFormat!");

        // Type.EmptyTypes = empty array of type Type - fetching a parameterless constructor
        formatter = (IFormat)klass.GetConstructor(Type.EmptyTypes).Invoke(null);

        // Or...
        formatter = (IFormat)Activator.CreateInstance(klass);
    }
    public string Format(object val)
    {
        return formatter.Format(val);
    }
}

public interface  IGetter
{   
    string Name{ get; }
    object GetValue(object target) ;

}

public class Logger
{
    static Dictionary<Type, List<IGetter>> getters = new Dictionary<Type, List<IGetter>>();

    public static void Log(object obj)
    {
        //Print on screen the type of the object
        Type klass = obj.GetType();
        bool isArray = typeof(Array).IsAssignableFrom(klass);
        Console.Write("{0}: ", klass.Name);

        if(klass.IsPrimitive){
            Console.Write(obj);
        }
        else if(!isArray) {
            List<IGetter> gs;
            if(getters.TryGetValue(klass, out gs) == false){
                gs = SetupGetters(klass);
                getters.Add(klass, gs);
            }
            foreach (IGetter g in gs)
            {
                Console.Write(g.Name + " : " + g.GetValue(obj) + ", ");
            }
        } else {
            // APi de reflexão sobre arr ---> Array.GetValue(int index)
            Array arr = (Array)obj;
            Console.WriteLine();
            // Ciclo sobre arr;
            for(int i=0;i<arr.Length;++i){
                object o = arr.GetValue(i);
                Console.Write("  ");
                Log(o);
            }
        }
        Console.WriteLine();
    }
    private static List<IGetter> SetupGetters(Type klass) {
        //Get all properties from the object
        PropertyInfo[] properties = klass.GetProperties();
        List<IGetter> gs = new List<IGetter>();
        /*
         * If obj type has no properties then just prints a new line!
         */
        if (properties != null && properties.Length != 0) {
            for (int i = 0; i < properties.Length; i++) {
                //Print all Properties and their respective values
                PropertyInfo p = properties[i];
                // 1. p.GetCustomAttributes(false); => 2. testar se é typeof(IgnoreAttribute)
                // 2. p.GetCustomAttributes(typeof(IgnoreAttribute), false);
                if (p.IsDefined(typeof(IgnoreAttribute)) == false)
                {
                    object[] attrs = p.GetCustomAttributes(typeof(LayoutAttribute), false);
                    Type getter = BuildGetter(klass, p);
                    if (attrs == null || attrs.Length == 0){
                        object[] args = {p.Name, null};
                        gs.Add((IGetter) Activator.CreateInstance(getter, args));
                    }
                    else
                    {
                        LayoutAttribute l = (LayoutAttribute)attrs[0];
                        object[] args = {p.Name, l};
                        gs.Add((IGetter) Activator.CreateInstance(getter, args));
                    }
                }
            }
        }
        return gs;
    }

    static Type BuildGetter(Type klass, PropertyInfo prop) {
        throw new NotImplementedException();
    }
}