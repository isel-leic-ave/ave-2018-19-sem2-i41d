using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;


static class App { // <=> FINAL and ABSTRACT => Não pode ser extendida e nem instanciada
    static IEnumerable<string> Lines(string path) {
        string line;
        using(StreamReader file = new StreamReader(path)) // <=> try-with resources
        {
            while ((line = file.ReadLine()) != null)
            {
                yield return line;
            }
        }
    }
    static void Main()
    {
        int count = 0;
        IEnumerable<string> names = Lines("i41d.txt")
            .Select(item => { 
                count++;
                return Student.Parse(item.ToString());
            })
            .Where(item => { 
                count++;
                return item.nr > 41000;
            })
            .Where(item => { 
                count++;
                // Console.WriteLine("Filter2..." + item); 
                return item.name.StartsWith("A");
            })
            .Select(item => { 
                count++;
                // Console.WriteLine("Convert..." + item); 
                return item.name.Split(' ')[0];
            })
            .Distinct()
            .Take(4);
                        
        // Console.ReadLine();
        foreach(object l in names)
            Console.WriteLine(l);
            
        Console.WriteLine(count);         
    }
}

public class Student
{
    public readonly int nr;
    public readonly string name;
    public readonly int group;
    public readonly string email;
    public readonly string githubId;

    public Student(int nr, String name, int group, string email, string githubId)
    {
        this.nr = nr;
        this.name = name;
        this.group = group;
        this.email = email;
        this.githubId = githubId;
    }

    public override String ToString()
    {
        return String.Format("{0} {1} ({2}, {3})", nr, name, group, githubId);
    }
    public void Print()
    {
        Console.WriteLine(this.ToString());
    }
    
    public static Student Parse(object src){
        return Student.Parse(src.ToString());
    }
    
    public static Student Parse(string src){
        string [] words = src.Split('|');
        return new Student(
            int.Parse(words[0]),
            words[1],
            int.Parse(words[2]),
            words[3],
            words[4]);
    }
}
