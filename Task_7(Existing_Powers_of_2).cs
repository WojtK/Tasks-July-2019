public static void Existing_Powers_of_2()
        {
            string s;
            int score = 0;
            int[] tab = new int[256]; 
            string[] tab1 = new string[256]; //tworzymy tablice string aby wprowadzic wartosci w jednej linii
            s = Console.ReadLine(); //wprowadzamy wartosci w jednej linii
            tab1 = s.Split(' '); //dzielimy string 's' na czesci, aby wyodrebnic wprowadzone wartosci

            for (int i = 0; i <tab1.Length; i++)
            {               
                tab[i] = int.Parse(tab1[i]); //przypisujemy tab wartosci
                             
            }          

            for(int j=0; j < tab.Length; j++)
            {
                score |= tab[j]; // wykorzystujemy operator bitowy OR
            };

            for (int i = 0; i < 32; i++)
            {
                int power = 1 << i;  // wykonujemy przesuniecie bitowe w lewo dla kazdego bitu 
                if ((score & power) != 0)
                {
                    Console.Write(power + ",");
                }
            }
        }
