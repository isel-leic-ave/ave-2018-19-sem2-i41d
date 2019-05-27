using System;
using System.IO;

static class App{

    static void PrintRunningGC(int n){
        Console.WriteLine("Running GC for generation " +  n);
        GC.Collect(n);   // Objectos finalizáveis => FReachable List
        GC.WaitForPendingFinalizers();
    }

	public static void Main(){
        
        // 
        // Uma instância de FileStream mantém um handle para um recurso nativo, 
        // i.e. um ficheiro.
        //
        FileStream fs = new FileStream("out.txt", FileMode.Create);
		// Wait for user to hit <Enter>
        Console.WriteLine("Wait for user to hit <Enter>");
		Console.ReadLine();
		
        PrintRunningGC(0);
        
        Console.WriteLine("Wait for user to hit <Enter>");
		Console.ReadLine();
	}
    
}
