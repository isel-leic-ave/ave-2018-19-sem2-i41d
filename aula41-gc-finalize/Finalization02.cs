using System;
using System.Text;
using System.IO;
using System.Threading;

static class App{

    class FileStreamClean : FileStream{
        public FileStreamClean(string path) : base(path, FileMode.Create) {}
        ~FileStreamClean()
        {
            byte[] toBytes = Encoding.ASCII.GetBytes("Finalizing..!");
            this.Write(toBytes, 0, toBytes.Length); // Safe write
            Thread.Sleep(5000);
            Console.WriteLine("Finalization finished!");
            // base.Finalize() // implicito
        }
    }

    static void PrintRunningGC(){
        Console.WriteLine("Running GC...");
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }

	public static void Main(){
        
        // 
        // Uma instância de FileStream mantém um handle para um recurso nativo, i.e. um ficheiro.
        //
        FileStream fs = new FileStreamClean("out.txt");
		// Wait for user to hit <Enter>
        byte[] toBytes = Encoding.ASCII.GetBytes("Ola Mundo!");
        fs.Write(toBytes, 0, toBytes.Length);
        Console.WriteLine("Wait for user to hit <Enter>");
		Console.ReadLine();
		
        PrintRunningGC();        
        
        Console.WriteLine("Wait for user to hit <Enter>");
		Console.ReadLine();
        
	}
    
}
