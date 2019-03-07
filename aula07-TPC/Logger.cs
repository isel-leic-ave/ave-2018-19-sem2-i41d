
using System;
using System.Reflection;

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
        	Console.Write(p.Name + "=" + p.GetValue(obj) + ", ");
        }
        Console.WriteLine();
    }
}