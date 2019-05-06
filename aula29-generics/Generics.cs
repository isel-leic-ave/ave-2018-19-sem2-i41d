using System;

interface I {
    object foo();
}
interface I<T> : I {
    T foo();
}
class A<T> : I<T> {
    public T foo(){
        return default(T);
    }
    object I.foo(){
        return "ola";
    }
}


public class Generics {
    public static void Main() {
        A<String> a = new A<String>();
        I<String> i1 = a;
        String m1 = a.foo();
        I i2 = a;
        Object o = i2.foo();
    }
}