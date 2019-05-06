
interface I<T> {
    T foo(T m);
}
class A<T> implements I<T> {
    public T foo(T m){
        return m;
    }
}


public class Generics {
    public static void main(String [] args) {
        A<String> a = new A<String>();
        I<String> i1 = a;
        I i2 = a;
        String m1 = i1.foo("ola");
        Object m2 = i2.foo("ola");
    }
}