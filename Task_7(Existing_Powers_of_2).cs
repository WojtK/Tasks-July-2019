public static void Existing_Powers_of_2()
        {
            string s;
            int score = 0;
            int[] tab = new int[256];
            string[] tab1 = new string[256];
            s = Console.ReadLine();
            tab1 = s.Split(' ');

            for (int i = 0; i <tab1.Length; i++)
            {               
                tab[i] = int.Parse(tab1[i]);
                             
            }          

            for(int j=0; j < tab.Length; j++)
            {
                score |= tab[j];
            };

            for (int i = 0; i < 32; i++)
            {
                int power = 1 << i;
                if ((score & power) != 0)
                {
                    Console.Write(power + ",");
                }
            }
        }
