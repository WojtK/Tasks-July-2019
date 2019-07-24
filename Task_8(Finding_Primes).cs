 public static void Finding_Primes()
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            bool prime_number = true;
            int score = 0;
            int j;

            for (int i = m; i <= n; i++)
            {
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        prime_number = false;
                    }
                }
                if ((prime_number == true) && (i > 1))
                {
                    score++; 
                }

                else prime_number = true;

            }
            Console.WriteLine(score);
        }
