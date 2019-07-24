public static void Common_Digit()
        {
            int n = int.Parse(Console.ReadLine());
            string s = "";
            int max = 0;
            int[] tab = new int[256];
            s = Console.ReadLine();
            Char score = Char.MaxValue;
            Array.Clear(tab, 0, tab.Length - 1);

            foreach (Char c in s)
                if(c!=' ' && ++tab[c] > max)
            {                              
                    Console.Write(c + " ");
                    max = tab[c];
                    score = c;               
            }            
            Console.Write("\n" + score);
        }
