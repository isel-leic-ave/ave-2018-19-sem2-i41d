using System;
using System.IO;

static class App{

    static void PrintRunningGC(int n){
        Console.WriteLine("Running GC for generation " +  n);
        GC.Collect(n);   // Objectos finalizáveis => FReachable List
        GC.WaitForPendingFinalizers();
    }

	public static void Main(){
        // TestFinalize();
        // TestDispose();
        TestDisposeWithUsing();
    }
    
    static void TestDispose()
    {
        FileStream fs = null;
        try {
            // 
            // Uma instância de FileStream mantém um handle para um recurso nativo, 
            // i.e. um ficheiro.
            //
            fs = new FileStream("out.txt", FileMode.Create);
            // Wait for user to hit <Enter>
            Console.WriteLine("Wait for user to hit <Enter>");
            Console.ReadLine();
		} finally { // Sempre executado mesmo para qualquer excepção
            fs.Dispose();
            // fs.Write(""); // Dá Excepção porque já foi fechado o stream para o ficheiro.
        }
        
        Console.WriteLine("Wait for user to hit <Enter>");
		Console.ReadLine();
	}

    static void TestDisposeWithUsing()
    {
        using(FileStream fs = new FileStream("out.txt", FileMode.Create)){
            // 
            // Uma instância de FileStream mantém um handle para um recurso nativo, 
            // i.e. um ficheiro.
            //
            // Wait for user to hit <Enter>
            Console.WriteLine("Wait for user to hit <Enter>");
            Console.ReadLine();
		} 
        Console.WriteLine("Wait for user to hit <Enter>");
		Console.ReadLine();
	}
    
    static void TestFinalize()
    {
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
