class GetterStudentNr : IGetter
{
    private readonly LayoutAttribute layout;
    private readonly string name;

    public GetterStudentNr(string name, LayoutAttribute l)
    {
        this.name = name;
        this.layout = l;
    }
    
    public string Name {
        get {
            return name;
        }
    }

    public object GetValue(object target) {
        Student st = (Student) target;
        object val = st.Nr;
        return layout == null
            ? val
            : layout.Format(val);
    }
}

public struct Student
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

    public int Nr { get {return nr; }}
    
    public string Name { get {return name; } }
    public int Group { get {return group; } }
    
    public string GithubId { get {return githubId; } }
}