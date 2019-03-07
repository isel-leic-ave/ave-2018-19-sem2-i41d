using System;

class MyColor : Attribute {}
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
class MyNote : Attribute
{
    public string Label{get; set;}
    public int Nr {get; set; }
    public MyNote(){}
    public MyNote(string label) { Label = label; }
    public override string ToString(){
        return "I am a custom attribute MyNote!";
    }
}

[MyNote]
[MyColor]
class A {}

[MyNote("super", Nr = 7)]
[MyNote("isel")]
class B {}
public class App {

    static void LoookingForMyNote(object target){
        Type klass = target.GetType();
        object[] attrs = klass.GetCustomAttributes(false);
        foreach (object at in attrs)
        {
            if(at.GetType() == typeof(MyNote)){
                MyNote note = (MyNote) at;
                Console.WriteLine(klass + ": MyNote  --- " + note.Label);
            }
        }
    }
    static void Main(){
        A a = new A();
        B b = new B();
        LoookingForMyNote(a);
        LoookingForMyNote(b);
    }
}