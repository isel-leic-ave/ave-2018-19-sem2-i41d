
using System;
using System.Reflection;

public interface IFormat {
     string Format(object val);
}

[AttributeUsage(AttributeTargets.Property)]
public class IgnoreAttribute : Attribute {
}

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class LayoutAttribute : Attribute {
    public Type klass {get ; set; }
    public LayoutAttribute(Type klass) {
        if(!typeof(IFormat).IsAssignableFrom(klass))
            throw new InvalidOperationException("Layout parameter should be a type inheriting from IFormat!");        
    }
    public string Format(object val) {
        // TPC: Chamar o método Format sobre uma instância de klass
        return  "DUMMY";
    }
}

public class Logger {
    public static void Log(object obj){
        //Print on screen the type of the object
        Type klass = obj.GetType();
        Console.Write("{0}: ", klass.Name);

        //Get all properties from the object
        PropertyInfo[] properties = klass.GetProperties();
        /*
         * If obj type has no properties then just prints a new line!
         */
        if (properties == null || properties.Length == 0){
            Console.WriteLine();
            return;
        }
        for(int i=0; i<properties.Length; i++) {
            //Print all Properties and their respective values
        	PropertyInfo p = properties[i];
            // 1. p.GetCustomAttributes(false); => 2. testar se é typeof(IgnoreAttribute)
            // 2. p.GetCustomAttributes(typeof(IgnoreAttribute), false);
            if(p.IsDefined(typeof(IgnoreAttribute)) == false) {
                object[] attrs = p.GetCustomAttributes(typeof(LayoutAttribute), false);
                object val = p.GetValue(obj);
                if(attrs == null || attrs.Length == 0)
        	        Console.Write(p.Name + "=" + val + ", ");
                else {
                    LayoutAttribute l = (LayoutAttribute) attrs[0];
                    Console.Write(p.Name + "=" + l.Format(val) + ", ");
                }
            }
        }
        Console.WriteLine();
    }
}