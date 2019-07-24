public static void ReverseArray()
        {
            //Wprowadzamy rozmiar, deklarujemy tablice i wypelniamy wartosciami
            Console.WriteLine("enter the size: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int j = 0; j < arr.Length; j++)
                arr[j] = int.Parse(Console.ReadLine());
            
            for (int i = arr.Length; i > 0; i--) //Odwraca petle wypisujac ja od tylu
                Console.Write(arr[i - 1] + " "); //Zamiast petli mozna bylo tez uzyc Array.Reverse(arr) i wypisac tablice arr
        }
