using System; 

public class App 
{
    static void Main() {}
}

public sealed class TestedAttribute : Attribute
{
}
public sealed class DocumentedAttribute : Attribute
{
}
[AttributeUsage(AttributeTargets.Method, AllowMultiple= true)]
public sealed class LabelAttribute : Attribute
{
    private readonly string msg;
    public LabelAttribute(string msg) { this.msg = msg;}
    public LabelAttribute() { this.msg = null; }
    public int Nr { get; set; }
}

// [ Label("ldhdj", Nr = 17) ] // Custom Attribute restrito a métodos
public sealed class MyCode {
  [ TestedAttribute ]
  [ DocumentedAttribute ]
  static void f() {}

  [ Tested ]
  [ Label("Ola", Nr = 7) ] // Chama o construtor com parâmetros
  [ Label(Nr = 11) ] // Chama o construtor sem parâmetros
  static void g() {}

  [ Tested, Documented ]
  [ Label ]
  static void h() {}
}

