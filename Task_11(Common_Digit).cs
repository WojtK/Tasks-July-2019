public static void Common_Digit()
        {
            string s = "";
            int max = 0;
            int n = int.Parse(Console.ReadLine()); //wczytujemy rozmiar
            int[] tab = new int[256];
            s = Console.ReadLine(); //wczytujemy dane z jednej linii
            Char score = Char.MaxValue; 
            Array.Clear(tab, 0, tab.Length - 1);

            foreach (Char c in s)
                if(c!=' ' && ++tab[c] > max) // szukamy najczesciej wystepujacej liczby
            {                              
                    Console.Write(c + " "); //wypisuje aktualnie najczesciej spotkana liczbe
                    max = tab[c]; 
                    score = c;               
            }            
            Console.Write("\n" + score); //wypisuje liczbe o najwiekszej ilosci wystapien
        }
