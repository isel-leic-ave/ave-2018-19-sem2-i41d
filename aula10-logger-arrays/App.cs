using System;

class SurnameFormatter : IFormat {
    public string Format(object val){
        if(val.GetType() != typeof(string))
            throw new InvalidOperationException("You cannot use this formatter for non string values!");
        string [] words = val.ToString().Split(' ');
        return words[words.Length - 1];
    }
}

class DoubleFormatter : IFormat {
    public string Format(object val){
        if(val.GetType() != typeof(double))
            throw new InvalidOperationException("You cannot use this formatter for non double values!");
        return ((double) val).ToString("0.##");
    }
}

public class Student
{
    readonly int nr;
    readonly string name;
    readonly int group;
    readonly string githubId;

    public Student(int nr, string name, int group, string githubId)
    {
        this.nr = nr;
        this.name = name;
        this.group = group;
        this.githubId = githubId;
    }

    [Ignore] public int Nr { get {return nr; }}
    [Layout(typeof(SurnameFormatter))]
    public string Name { get {return name; } }
    [Ignore] public int Group { get {return group; } }
    
    public string GithubId { get {return githubId; } }
}

class Point{
    int x, y;
    public Point(int x, int y) {
        this.x = x;
        this.y = y;
    }
    [Ignore] public int X { get {return x;} set{ x = value;}}
    [Ignore] public int Y { get {return y;} set{ y = value;}}
    [Layout(typeof(DoubleFormatter))]
    public double Module{
        get{
            return Math.Sqrt(x*x + y*y);
        }
    }
    
}

interface IAccount { long Balance{ get; set; }}

class Account : IAccount {public long Balance{ get; set; }}

class App {
    static void Main(){
        Point p = new Point(7, 9);
        Student s = new Student(154134, "Ze Manel", 5243, "ze");
        Account a = new Account();
        a.Balance = 62143;
        Logger.Log(p);
        Logger.Log(new Point(8,3));
        Logger.Log(s);
        Logger.Log(a);
    }
}