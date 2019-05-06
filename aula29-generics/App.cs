using System;

class A<T>{ // T => acessivel às instâncias de A
    T f;
    public A(T f){
        this.f = f;
    }
    public void Foo<T>(T a) { // T => acessível ao método
        // this.f = a; //!!! ERRO de Compilação
    }
}


public class App {
    public static void Main(String [] args) {
        A<int> a = new A<int>(7);
        
        a.Foo<string>("Ola"); // T é inferido como String

    }
}