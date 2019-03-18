
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

class Getter
{
    PropertyInfo Prop { get; }
    LayoutAttribute Layout { get; }

    public string Name {get {return Prop.Name; }}

    public Getter(PropertyInfo p, LayoutAttribute l)
    {
        this.Prop = p;
        this.Layout = l;
    }

    public object GetValue(object target) {
        if (Layout == null)
            return Prop.GetValue(target);
        else
        {
            return Layout.Format(Prop.GetValue(target));
        }
    }

}

public class Logger
{
    static Dictionary<Type, List<Getter>> getters = new Dictionary<Type, List<Getter>>();

    public static void Log(object obj)
    {
        //Print on screen the type of the object
        Type klass = obj.GetType();
        Console.Write("{0}: ", klass.Name);

        if(typeof(Array).IsAssignableFrom(klass)) {
            klass = klass.GetElementType();  // O tipo de elemento do Array
        }

        List<Getter> gs;
        if(getters.TryGetValue(klass, out gs) == false){
            gs = SetupGetters(klass);
            getters.Add(klass, gs);
        }
        if(!typeof(Array).IsAssignableFrom(obj.GetType())) {
            foreach (Getter g in gs)
            {
                Console.Write(g.Name + "=" + g.GetValue(obj) + ", ");
            }
        } else {
            Array arr = (Array) obj;
            // APi de reflexão sobre arr --- Array.GetValue(int index)
            // 2 ciclos:
            // -- ciclo sobre arr;
            //     --- ciclo sobre getters.
        }
        Console.WriteLine();
    }
    private static List<Getter> SetupGetters(Type klass) {
        //Get all properties from the object
        PropertyInfo[] properties = klass.GetProperties();
        List<Getter> gs = new List<Getter>();
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
                    if (attrs == null || attrs.Length == 0)
                        gs.Add(new Getter(p, null));
                    else
                    {
                        LayoutAttribute l = (LayoutAttribute)attrs[0];
                        gs.Add(new Getter(p, l));
                    }
                }
            }
        }
        return gs;
    }
}