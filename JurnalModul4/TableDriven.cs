using System;

namespace JurnalModul4
{
    class TableDriven
    {
        string[] namaBuah = {
        "Apel","Aprikot","Alpukat","Pisang","Paprika",
        "Blackberry","Ceri","Kelapa","Jagung",
        "Kurma","Durian","Anggur","Melon","Semangka"
    };

        string[] kodeBuah = {
        "A00","B00","C00","D00","E00",
        "F00","H00","I00","J00",
        "K00","L00","M00","N00","O00"
    };

        public string getKodeBuah(string input)
        {
            for (int i = 0; i < namaBuah.Length; i++)
            {
                if (namaBuah[i] == input)
                {
                    return kodeBuah[i];
                }
            }

            return "Kode buah tidak ditemukan";
        }
    }
}