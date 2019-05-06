using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;

delegate bool Predicate<T>(T item);

delegate R Function<T,R>(T item);

class ConvertEnumerable<T,R> : IEnumerable<R> {
    IEnumerable<T> src;
    Function<T,R> mapper;
    public ConvertEnumerable(IEnumerable<T> src, Function<T,R> mapper) {
        this.src = src;
        this.mapper = mapper;
    }
    IEnumerator IEnumerable.GetEnumerator() {
        return this.GetEnumerator();
    }
    public IEnumerator<R> GetEnumerator() {
        return new ConvertEnumerator<T,R>(src, mapper);
    }
}
class ConvertEnumerator<T,R> : IEnumerator<R> {
    IEnumerator<T> srcIter;
    Function<T,R> mapper;
    public ConvertEnumerator(IEnumerable<T> src, Function<T,R> mapper) {
        this.srcIter = src.GetEnumerator();
        this.mapper = mapper;
    }
    public bool MoveNext() {
        return srcIter.MoveNext();
    }
    object IEnumerator.Current {
        get { return this.Current; }
    }
    
    public R Current {
        get { return mapper(srcIter.Current); }
    }
    public void Reset() {
        srcIter.Reset();
    }
    public void Dispose() {
        srcIter.Dispose();
    }
}

class FilterEnumerable<T> : IEnumerable<T> {
    IEnumerable<T> src;
    Predicate<T> p;
    public FilterEnumerable(IEnumerable<T> src, Predicate<T> p) {
        this.src = src;
        this.p = p;
    }
    IEnumerator IEnumerable.GetEnumerator() {
        return this.GetEnumerator();
    }
    public IEnumerator<T> GetEnumerator() {
        return new FilterEnumerator<T>(src, p);
    }
}
class FilterEnumerator<T> : IEnumerator, IEnumerator<T> {
    IEnumerator<T> srcIter;
    Predicate<T> p;
    public FilterEnumerator(IEnumerable<T> src, Predicate<T> p) {
        this.srcIter = src.GetEnumerator();
        this.p = p;
    }
    public bool MoveNext() {
        while(srcIter.MoveNext()) {
            if(p((T) srcIter.Current))
                return true;
        }
        return false;
    }
    object IEnumerator.Current {
        get { return srcIter.Current; }
    }
    
    public T Current {
        get { return srcIter.Current; }
    }
    
    public void Reset() {
        srcIter.Reset();
    }
    public void Dispose() {
        srcIter.Dispose();
    }
}


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
     
    static IEnumerable<R> Convert<T,R>(IEnumerable<T> src, Function<T,R> mapper) {
        return new ConvertEnumerable<T,R>(src, mapper);
    }  
    static IEnumerable Distinct(IEnumerable src) {
        return new DistinctEnumerable(src);
    }
    static IEnumerable<T> Filter<T>(IEnumerable<T> src, Predicate<T> pred) {
        return new FilterEnumerable<T>(src, pred);
    }
    
    static void Main()
    {
        IEnumerable names = 
            Distinct(
                Convert(
                    Filter(
                        Convert<string, Student>(
                            Lines("i41d.txt"),
                            Student.Parse),
                        item => { 
                            // Console.WriteLine("Filter2..." + item); 
                            return item.name.StartsWith("R");
                        }),
                    item => { 
                        // Console.WriteLine("Convert..." + item); 
                        return item.name.Split(' ')[0];
                    })
            );
                        
        // Console.ReadLine();
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
