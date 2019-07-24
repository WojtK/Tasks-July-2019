 public static void Finding_Primes()
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine()); //wczytujemy zakresy

            bool prime_number = true;
            int score = 0;
            int j;

            for (int i = m; i <= n; i++)
            {
                // sprawdzamy czy liczba dzieli sie nie tylko przez 1 i sama siebie
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0) //jezeli nie dzieli sie tylko przez siebie, to nie jest to liczba pierwsza
                    {
                        prime_number = false;
                    }
                }
                if ((prime_number == true) && (i > 1))
                {
                    Console.WriteLine("Prime number is: " + i); //wypisujemy liczby pierwsze
                    score++; //wypisujac dodajemy kolejne wystapienie liczby pierwszej
                }

                else prime_number = true;
            }
            Console.WriteLine(score); //wynik
        }
