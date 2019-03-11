
using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Property)]
public class IgnoreAttribute : Attribute {
}

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class LayoutAttribute : Attribute {
    public string Format {get ; set; }
    public LayoutAttribute(string format) {
        this.Format = format;
    }
}

public class Logger {
    public static void Log(object obj){
        //Print on screen the type of the object
        Type klass = obj.GetType();
        Console.Write("{0}:", klass.Name);

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
                    if(p.PropertyType != typeof(double))
                        throw new InvalidOperationException("You cannot use Layout attribute on non double properties such as : " + p.Name +  " of " + klass.Name);
                    LayoutAttribute l = (LayoutAttribute) attrs[0];
                    Console.Write(p.Name + "=" + ((double) val).ToString(l.Format) + ", ");
                }
            }
        }
        Console.WriteLine();
    }
}