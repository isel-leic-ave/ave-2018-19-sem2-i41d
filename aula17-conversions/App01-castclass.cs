using System;
using System.Collections.Generic;
using System.Reflection;

public class Person {}

public class Student : Person
{
    public int Nr { get; set; }
    public int Group{ get; set; }
    public string Name{ get; set; }
    public string GithubId{ get; set; }
    public DateTime BirthDate {get; set; }

    public Student() {
    }
    public Student(int nr, String name, int group, string githubId, DateTime b)
    {
        this.Nr = nr;
        this.Name = name;
        this.Group = group;
        this.GithubId = githubId;
        this.BirthDate = b;
    }
}


struct Point{
    int x, y;
    
    // public Point() {} // NãO é possível porque não existe forma de chamar este construtor.
    public Point(int x, int y) {
        this.x = x;
        this.y = y;
    }  
    public int X {
        get{return x;}
        set{ x = value; }
    }
    public int Y { 
        get{return y;}
        set{ y = value; }
    }
    public double Module { // READ ONLY
        get {
            return Math.Sqrt(x*x + y*y);
        }
    }

    public void Print() {
        Console.WriteLine(x + ", " + y);
    }
}

public class App {

    public static void CheckStudent(object o) {
        Student s = o as Student; // isinst
        if(s != null)
            Console.WriteLine(s.GithubId);

        /*
        if(o is Student) { // isinst + ldnull + cgt
            Student s = (Student) o; // ... + castclass + ...
            Console.WriteLine(s.GithubId);
        }
         */
    }

    public static void Main(String [] args) {
        Student s = new Student(); // IL: newobj Student::.ctor + stloc.0
        Person p = s;              // ldloc.0 + stloc.1
        
        Student s2 = (Student) p;  // ldloc.1 + castclass Student + stloc.2
        Object o = new Object();
        // p = (Person) o; // ldloc.3 + castclass Person + stloc.1 => Excepção !!!

        p = o as Person;  // ldloc.3 + isinst Person + stloc.1 => null
        string msg = p == null ? "null" : p.ToString();
        Console.WriteLine(msg); 
    }
    
    static void testBoxUnbox() {
        Point p1 = new Point(6,7); 
        Student std = new Student();
        Console.WriteLine(p1.GetType()); // => Point
        Console.WriteLine(std.GetType());// => Student
        Object o = p1; // ldloc.0 + box Point + stloc.1

        Point p2 = (Point) o; // ldloc.1 + unbox + stloc.2

        o.GetType();  // ldloc.1 + callvirt Object::GetType
        p1.GetType(); // ldloc.0 + box Point + callvirt Object::GetType
        p1.Print();   // NÂO existe BOX
    }
}