using System;
using System.Collections.Generic;
using System.Reflection;

public class Person {}

public class Student : Person
{
   
   private int nr;
    public Student() {
    }
    
    // NÃO virtual
    public void Print() {
        Console.WriteLine("I am a Student!!!!" + this.CalcGrade());
    }
    
    public int CalcGrade() {
        return 0;
    }
}


public class App {
    public static void Main(String [] args) {
        Student s = null;

        // Chamada a um metodo virtual
        // s.ToString(); // callvirt
        
        // Chamada a um metodo NAO virtual
        s.Print(); // callvirt
    }
}