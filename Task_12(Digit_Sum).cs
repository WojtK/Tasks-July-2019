 public static void Digit_Sum()
        {
            int n = int.Parse(Console.ReadLine()); //wczytujemy rozmiar
            string s;          
            int[] tab = new int[256];
            string[] tab1 = new string[256];
            s = Console.ReadLine(); // wczytujemy dane w jednej linii
            tab1 = s.Split(' '); //dzielimy string 's' na czesci, ktore przypisujemy tab1
                for (int i = 0; i < n; i++)
                {
                    int sum = 0;
                    int g = int.Parse(tab1[i]); //pobieramy wartosc z tab1 i sumujemy jej cyfry
                    while (g != 0)
                    {
                        sum += g % 10;
                        g /= 10;
                    }
                    tab[i] = sum; //zwracamy otrzymany wynik do tab 
                    
                    Console.WriteLine("Sum of digit index number: "+i+" = "+sum); //wypisujemy sume liczb dla poszczegolnego indexu
                    Console.WriteLine("---------");
                }               

            Console.WriteLine("The maximum digit sum -> index number: "+Array.IndexOf(tab, tab.Max()));
                //wypisujemy index, pod ktorym wystepuje najwieksza wartosc z zsumowanych liczb
            }
