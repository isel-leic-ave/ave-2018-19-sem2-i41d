public class App01Hierarchy {
    static void PrintHierarchy(Object obj) {
        Class c = obj.getClass();  // Type <=> Class do Java
        System.out.print(obj + " has class " + c);
        PrintInterfaces(c);
        PrintBase(c);
    }

    static void PrintBase(Class c){
        if(c == Object.class) {
            System.out.println();
            return;
        }
        Class base = c.getSuperclass();
        System.out.print(" ----|> " + base.getName());
        PrintInterfaces(base);
        PrintBase(base);
    }

    static void PrintInterfaces(Class c) {
        Class[] itfs = c.getInterfaces();
        if(itfs == null || itfs.length == 0) return;
        String res = "";
        for (Class cl :itfs)
            res += cl.getName() + " ";

        System.out.print("(" + res + ")");
    }

    public static void main(String[] args){
        String s = "isel";  // Designa��o primitiva de string
        Object o = s;  // Designa��o primitiva de object
        Object o2 = o; // => erro de compila��o SEM a instru��o using System;
        int n1 = 7;    // Designa��o primitiva de int
        Integer n2 = 7;  // System.Int32
        Integer n3 = n1; // S� c�pia de valor. � != Java: Integer n3 = n1 // => boxings
        Object n4 = n1; // <=> Java Integer n4 = n1 => BOXING !!!! Overhead

        PrintHierarchy(new Object()); //
        PrintHierarchy(s); // isel is of type String --|> Object
        PrintHierarchy(o); // isel is of type String  --|> Object
        PrintHierarchy(n1);// 7 is of type Int32   --|> ValueType  --|> Object
    }
}