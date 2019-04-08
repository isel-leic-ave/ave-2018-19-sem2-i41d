using System;

struct Point{
    int x, y;
    public Point(int x, int y) {
        this.x = x;
        this.y = y;
    }
    public int X { get {return x;} set{ x = value;}}
    public int Y { get {return y;} set{ y = value;}}
    public double Module() {
        return Math.Sqrt(x*x + y*y);
    }
}


public class Person {
    public string Name{ get; set; }
    
    public void Print() {
        Console.WriteLine("I am a Person");
    }

}

public class Student : Person
{
    public int Nr { get; set; }
    public int Group{ get; set; }

    public Student(int nr, string name, int group)
    {
        this.Nr = nr;
        this.Name = name;
        this.Group = group;
        this.Print();
    }

    public override string ToString() {
        Console.WriteLine("calling base...");
        string res = base.ToString(); // ldarg.0 + call
        return res + " I am Student";
    }
    public new void Print() {
        Console.WriteLine("I am a Student");
    }
}

public class WorkerStudent : Person
{

    public new void Print() {
        Console.WriteLine("I am a WorkerStudent");
    }
}

public class App {
    public static void Main(String [] args) {
        Student s = new Student(65142, "Ze Manel", 11);

        // Chamada a um metodo virtual
        string r = s.ToString(); // ldloc.0 + callvirt
        Console.WriteLine(r); // > Student I am a Student
        
        // Chamada a um metodo NAO virtual
        // s.Print(); // ldloc.0 + callvirt
        
        Point p = new Point(5, 7);
        p.Module();  // ldloca + call
        p.GetType(); // ldloc.1 + box + call
    }
}