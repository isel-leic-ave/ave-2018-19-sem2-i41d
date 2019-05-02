using System;
using System.Collections;
using System.Text;
using System.IO;

delegate bool Predicate (object item);

delegate object Function(object item);

class App {

    static IEnumerable Lines(string path)
    {
        string line;
        IList res = new ArrayList();
        
        using(StreamReader file = new StreamReader(path)) // <=> try-with resources do Java >= 7
        {
            while ((line = file.ReadLine()) != null)
            {
                res.Add(line);
            }
        }
        return res;
    }
     
    static IEnumerable Convert(IEnumerable src, Function mapper) {
        IList res = new ArrayList();
        foreach(object l in src) {
            res.Add(mapper.Invoke(l));
        }
        return res;
    }
        
    static IEnumerable Filter(IEnumerable stds, Predicate pred) {
        IList res = new ArrayList();
        foreach(object item in stds) {
            if(pred.Invoke(item))
                res.Add(item);
        }
        return res;
    }
    
    static void Main()
    {
        IEnumerable names = 
            Convert(
                Filter(
                    Filter(
                        Convert(
                            Lines("i41d.txt"),
                            item => Student.Parse(item.ToString())),
                        item => ((Student) item).nr > 41000), 
                    item => ((Student) item).name.StartsWith("A")),
                item => ((Student) item).name.Split(' ')[0]);
    
        foreach(object l in names)
            Console.WriteLine(l);
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
