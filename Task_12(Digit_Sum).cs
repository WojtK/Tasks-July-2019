 public static void Digit_Sum()
        {
            int n = int.Parse(Console.ReadLine());
            string s;          
            int[] tab = new int[256];
            string[] tab1 = new string[256];
            s = Console.ReadLine();
            tab1 = s.Split(' ');
                for (int i = 0; i < n; i++)
                {
                    int sum = 0;
                    int g = int.Parse(tab1[i]);
                    while (g != 0)
                    {
                        sum += g % 10;
                        g /= 10;
                    }
                    tab[i] = sum;
                    
                    Console.WriteLine("Sum of digit index number: "+i+" = "+sum);
                    Console.WriteLine("---------");
                }               

            Console.WriteLine("The maximum digit sum -> index number: "+Array.IndexOf(tab, tab.Max()));
            }
