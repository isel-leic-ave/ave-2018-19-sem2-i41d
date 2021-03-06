using System;

class App
{
    /**
     * !!!! compilar com /optimize+ <=> modo Release
     */
    static void Main()
    {
        object root = new object();
        Console.WriteLine(GC.GetGeneration(root)); // 0
        GC.Collect(); 
        Console.WriteLine(GC.GetGeneration(root)); // 1
        GC.Collect(0); // So para a geração 0. root mantem-se em 1
        Console.WriteLine(GC.GetGeneration(root)); // 1
        GC.Collect(1); // so para gerções 0 e 1. root passa para 2
        Console.WriteLine(GC.GetGeneration(root)); // 2
        
        Console.WriteLine(GC.GetTotalMemory(false));
        root = MakeSomeGarbage();
        Console.WriteLine(GC.GetTotalMemory(false));
        GC.Collect();
        Console.WriteLine(GC.GetTotalMemory(false));
        root.GetHashCode();
    }
    
    private const long maxGarbage = 4096;        
    static object[] MakeSomeGarbage()
    {
        Console.WriteLine("..... Making garbage...");
        object[] vts = new object[maxGarbage];

        for(int i = 0; i < maxGarbage; i++)
        {
            vts[i] = new object();
        }
        return vts;
    }
}