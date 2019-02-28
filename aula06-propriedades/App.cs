using System;

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

    public int Nr { get {return nr; } }
    public string Name { get {return name; } }
    public int Group { get {return group; } }
    public string GithubId { get {return githubId; } }
}

class Point{
    int x, y;
    public Point(int x, int y) {
        this.x = x;
        this.y = y;
    }
    public int X { get {return x;} set{ x = value;}}
    public int Y { get {return y;} set{ y = value;}}
    public double Module{
        get{
            return Math.Sqrt(x*x + y*y);
        }
    }
    
}

interface IAccount { long Balance{ get; set; }}

class Account : IAccount {public long Balance{ get; set; }}