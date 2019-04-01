using System;
using System.Reflection;
using System.Reflection.Emit;

public class App {
    static void Main() {
    
        Type klass = BuildType();
        object obj = Activator.CreateInstance(klass, new object[]{11});
        Console.WriteLine(obj);
    }
    
    public static Type BuildType() {
        AssemblyName aName = new AssemblyName("DynamicAssemblyExample");
        AssemblyBuilder ab = 
            AppDomain.CurrentDomain.DefineDynamicAssembly(
                aName, 
                AssemblyBuilderAccess.RunAndSave);

        // For a single-module assembly, the module name is usually
        // the assembly name plus an extension.
        ModuleBuilder mb = 
            ab.DefineDynamicModule(aName.Name, aName.Name + ".dll");
      
        TypeBuilder tb = mb.DefineType(
            "MyDynamicType", 
             TypeAttributes.Public);

        // Add a private field of type int (Int32).
        FieldBuilder fbNumber = tb.DefineField(
            "m_number", 
            typeof(int), 
            FieldAttributes.Private);

        // Define a constructor that takes an integer argument and 
        // stores it in the private field. 
        Type[] parameterTypes = { typeof(int) };
        ConstructorBuilder ctor1 = tb.DefineConstructor(
            MethodAttributes.Public, 
            CallingConventions.Standard, 
            parameterTypes);

        ILGenerator ctor1IL = ctor1.GetILGenerator();
        // For a constructor, argument zero is a reference to the new
        // instance. Push it on the stack before calling the base
        // class constructor. Specify the default constructor of the 
        // base class (System.Object) by passing an empty array of 
        // types (Type.EmptyTypes) to GetConstructor.
        ctor1IL.Emit(OpCodes.Ldarg_0);
        ctor1IL.Emit(OpCodes.Call, 
            typeof(object).GetConstructor(Type.EmptyTypes));
        // Push the instance on the stack before pushing the argument
        // that is to be assigned to the private field m_number.
        ctor1IL.Emit(OpCodes.Ldarg_0);
        ctor1IL.Emit(OpCodes.Ldarg_1);
        ctor1IL.Emit(OpCodes.Stfld, fbNumber);
        ctor1IL.Emit(OpCodes.Ret);

        // Define a default constructor that supplies a default value
        // for the private field. For parameter types, pass the empty
        // array of types or pass null.
        ConstructorBuilder ctor0 = tb.DefineConstructor(
            MethodAttributes.Public, 
            CallingConventions.Standard, 
            Type.EmptyTypes);

        ILGenerator ctor0IL = ctor0.GetILGenerator();
        // For a constructor, argument zero is a reference to the new
        // instance. Push it on the stack before pushing the default
        // value on the stack, then call constructor ctor1.
        ctor0IL.Emit(OpCodes.Ldarg_0);
        ctor0IL.Emit(OpCodes.Ldc_I4_S, 42);
        ctor0IL.Emit(OpCodes.Call, ctor1);
        ctor0IL.Emit(OpCodes.Ret);

        // Override ToString
        MethodBuilder toStr = tb.DefineMethod(
            "ToString",
            MethodAttributes.Public | MethodAttributes.ReuseSlot | 
            MethodAttributes.HideBySig | MethodAttributes.Virtual, 
            typeof(string), 
            Type.EmptyTypes);

        ILGenerator il = toStr.GetILGenerator();
        il.Emit(OpCodes.Ldstr, "m_number = ");
        il.Emit(OpCodes.Ldarg_0);
        il.Emit(OpCodes.Ldfld, fbNumber);
        il.Emit(OpCodes.Box, typeof(int));
        Type[] objectArgs = {typeof(object), typeof(object)};
        il.Emit(OpCodes.Call, typeof(string).GetMethod("Concat", objectArgs));
        il.Emit(OpCodes.Ret);
        
        // Finish the type.
        Type t = tb.CreateType(); 

        // The following line saves the single-module assembly. This
        // requires AssemblyBuilderAccess to include Save. You can now
        // type "ildasm MyDynamicAsm.dll" at the command prompt, and 
        // examine the assembly. You can also write a program that has
        // a reference to the assembly, and use the MyDynamicType type.
        // 
        ab.Save(aName.Name + ".dll");
        return t;
    }
}