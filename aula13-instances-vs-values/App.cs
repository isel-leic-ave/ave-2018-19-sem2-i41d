using System;
using System.Collections.Generic;
using System.Reflection;


public class Student
{
    public int Nr { get; set; }
    public int Group{ get; set; }
    public string Name{ get; set; }
    public string GithubId{ get; set; }

    public Student(int nr, String name, int group, string githubId)
    {
        this.Nr = nr;
        this.Name = name;
        this.Group = group;
        this.GithubId = githubId;
    }

    public void Print() {
        Console.WriteLine(this.ToString());
    }
}


struct Point{
    int x, y;
    
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
        Console.WriteLine(this.ToString());
    }

}

struct S {}
class C {}

public class App {
    public static void Main(String [] args) {
        // Point p = new Point();    // => initobj        
        Point p = new Point(5, 7); 
        Student std = new Student(74517, "Ze Manel", 17, "ze"); // => newobj
        std.Print(); // ldloc.1 + callvirt Student::Print()       
        p.Print();
    }
}