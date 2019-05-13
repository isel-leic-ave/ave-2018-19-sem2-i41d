using System;

delegate bool Predicate<T>(T item);
delegate R Function<T,R>(T item);

class C {
    readonly string name;
    public C(string name) { this.name = name; }
    public bool Match(C other) { return name.Equals(other.name); }
}

class App {
    static void Main() {
        Function<object, string> f1 = obj => obj.ToString(); // Anonymous method, Lambda
        
        Function<string, int> f2 = int.Parse; // Named Method, Method Reference/Handle/Pointer
        // <=> Function<string, int> f2 = new Function<string, int>(int.Parse);
        
        f1(5); // 5 => parametro obj
        f1.Invoke(7);
        
        f2("72183"); // => "72183" argumento de Parse
        C isel = new C("isel");
        Console.WriteLine(isel.Match(new C("super")));
        
        
        Predicate<C> f3 = isel.Match; // ldloc.2 + ldftn(...) + newobj Predicate::ctor
        Console.WriteLine(f3(new C("isel")));
    }
}
