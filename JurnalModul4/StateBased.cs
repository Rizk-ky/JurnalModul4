namespace JurnalModul4
    {
        using System;

        class PosisiKarakterGame
        {
            string state = "Berdiri";

            public void TombolW()
            {
                if (state == "Berdiri")
                {
                    state = "Terbang";
                    Console.WriteLine("posisi take off");
                }
                else if (state == "Jongkok")
                {
                    state = "Berdiri";
                }
            }

            public void TombolS()
            {
                if (state == "Terbang")
                {
                    state = "Jongkok";
                    Console.WriteLine("posisi landing");
                }
                else if (state == "Berdiri")
                {
                    state = "Jongkok";
                }
            }

            public void PrintState()
            {
                Console.WriteLine("State sekarang: " + state);
            }
        }
    }