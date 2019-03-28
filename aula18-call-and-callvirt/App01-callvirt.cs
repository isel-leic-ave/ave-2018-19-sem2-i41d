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

    public void Print() {
        Console.WriteLine("I am a Student");
    }
}


public class App {

    public static void Main(String [] args) {
        Student s = new Student(); // IL: newobj Student::.ctor + stloc.0
        s.Print();
        Student s2 = null;
        s2.Print();
    }
}