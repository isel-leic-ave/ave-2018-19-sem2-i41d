using System;

    
class A {}
class B : A {}
class C : B {
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

    static void PrintHierarchy(object obj) {
        // ???? Comparar BaseType com o tipo Object ???? => typeof(Object)
    
        Type klass = obj.GetType();  // Type <=> Class do Java
        Type super = klass.BaseType; 
        Console.WriteLine("{0} has type {1} ---|> {2} ---|>....", 
            obj,
            klass,
            super);
    }
    
    static void Main() {
        string s = "isel";  // Designação primitiva de string
        object o = s;  // Designação primitiva de object
        Object o2 = o; // => erro de compilação SEM a instrução using System;
        int n1 = 7;    // Designação primitiva de int
        Int32 n2 = 7;  // System.Int32
        Int32 n3 = n1; // SÓ cópia de valor. É != Java: Integer n3 = n1 // => boxings
        object n4 = n1; // <=> Java Integer n4 = n1 => BOXING !!!! Overhead
        
        PrintHierarchy(s); // isel is of type String --|> Object
        PrintHierarchy(o); // isel is of type String  --|> Object
        PrintHierarchy(n1);// 7 is of type Int32   --|> ValueType  --|> Object
        
        C c = new C();
        S st = new S();
        PrintHierarchy(c); // 
        PrintHierarchy(st);// 
    }
}