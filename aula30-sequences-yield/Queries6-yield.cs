using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;

delegate bool Predicate<T>(T item);

delegate R Function<T,R>(T item);

class App {
    static IEnumerable<string> Lines(string path)
    {
        string line;
        List<string> res = new List<string>();
        
        using(StreamReader file = new StreamReader(path)) // <=> try-with resources do Java >= 7
        {
            while ((line = file.ReadLine()) != null)
            {
                res.Add(line);
            }
        }
        return res;
    }
     
    static IEnumerable<T> Generate<T>(Func<T> generator) {
        while(true) yield return generator();
    
        // yield return 72; // 1º elemento da sequência retornada 
        // yield return 8234; // 2º elemento da sequência retornada 
        // yield return 542; // 3º elemento da sequência retornada 
        // return new GeneratorEnumerable<T>(generator);
    }
    static IEnumerable<R> Convert<T,R>(IEnumerable<T> src, Function<T,R> mapper) {
        foreach(T item in src)
                yield return mapper(item);
    }  
    static IEnumerable<T> Distinct<T>(IEnumerable<T> src) {
        HashSet<T> added = new HashSet<T>();
        foreach(T item in src)
            if(added.Add(item))
                yield return item;
    }
    static IEnumerable<T> Filter<T>(IEnumerable<T> src, Predicate<T> pred) {
        foreach(T item in src)
            if(pred(item))
                yield return item;
    }   
    static IEnumerable<T> Take<T>(IEnumerable<T> src, int limit) {
        IEnumerator<T> iter = src.GetEnumerator();
        for(int i = 0; i < limit && iter.MoveNext(); i++)
            yield return iter.Current;
    }   
    static void Main()
    {
        int n = 0;
        IEnumerable<int> nrs = Take(Generate(() => n++), 7); // 0, 1, 2, 3, ...
        
        foreach(object l in nrs)
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
