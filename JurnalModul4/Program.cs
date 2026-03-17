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

        PosisiKarakterGame game = new PosisiKarakterGame();

        game.PrintState();

        game.TombolW();
        game.PrintState();

        game.TombolS();
        game.PrintState();
    }
}