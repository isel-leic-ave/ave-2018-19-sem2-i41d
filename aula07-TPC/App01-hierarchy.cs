using System;

interface I1 {}
interface I2 {}
interface I3 {}
class A {}
class B : A, I1 {}
class C : B, I2, I3 {
    public override String ToString() {
            return "C";
    }
}
struct S {
    public override String ToString() {
        return "S";
    }
}
// struct T : S {} Erro de compilação

class Program {    

    static void PrintBase(Type klass){
        if(klass == typeof(object)) {
            Console.WriteLine();
            return;
        }
        Type super = klass.BaseType;
        Console.Write(" ----|> {0}", super.Name);
        PrintInterfaces(super);
        PrintBase(super);
    }
    static void PrintHierarchy(object obj) {
        Type klass = obj.GetType();  // Type <=> Class do Java
        Console.Write("{0} has type {1}", obj, klass.Name);
        PrintInterfaces(klass);
        PrintBase(klass);
    }
    static void PrintInterfaces(Type klass) {
        Type[] itfs = klass.GetInterfaces();
        if(itfs == null || itfs.Length == 0) return;
        String res = "";
        foreach(Type i in itfs) // <=> Java: for(Class i : itfs)
            res += i.Name + " ";
        Console.Write(" ({0})", res);
    }
    
    static void Main() {
        string s = "isel";  // Designação primitiva de string
        object o = s;  // Designação primitiva de object
        Object o2 = o; // => erro de compilação SEM a instrução using System;
        int n1 = 7;    // Designação primitiva de int
        Int32 n2 = 7;  // System.Int32
        Int32 n3 = n1; // SÓ cópia de valor. É != Java: Integer n3 = n1 // => boxings
        object n4 = n1; // <=> Java Integer n4 = n1 => BOXING !!!! Overhead
        
        PrintHierarchy(new object()); // 
        PrintHierarchy(s); // isel is of type String --|> Object
        PrintHierarchy(o); // isel is of type String  --|> Object
        PrintHierarchy(n1);// 7 is of type Int32   --|> ValueType  --|> Object
        
        C c = new C();
        S st = new S();
        PrintHierarchy(c); // 
        PrintHierarchy(st);// 
    }
}