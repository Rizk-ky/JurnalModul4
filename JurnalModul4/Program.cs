using System;
using JurnalModul4;
class Program
{
    static void Main(string[] args)
    {
        TableDriven kb = new TableDriven();

        Console.WriteLine(kb.getKodeBuah("Apel"));
        Console.WriteLine(kb.getKodeBuah("Durian"));
        Console.WriteLine(kb.getKodeBuah("Mangga")); 

        Console.WriteLine();

    }
}