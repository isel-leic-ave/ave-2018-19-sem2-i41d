using System;

class PontoApp {

    public static void Main(String[] args)
    {
        Ponto p = new Ponto(5, 7);
        p.print();
        Console.WriteLine("p._x = {0}", p._x);
        Console.WriteLine("p._y = {0}", p._y);
    }
}