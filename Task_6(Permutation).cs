public static void Permutation()
        {
            Console.WriteLine("Array1: ");
            int[] arr1 = new int[11]; //kazdy ciag liczb ma 11 elementow, stad tworzymy dwie tablice, ktore wypelniamy
            for (int j = 0; j < arr1.Length; j++)
                arr1[j] = int.Parse(Console.ReadLine());
            Console.WriteLine("Array2: ");
            int[] arr2 = new int[11];
            for (int j = 0; j < arr2.Length; j++)
                arr2[j] = int.Parse(Console.ReadLine());

            Array.Sort(arr1);  
            Array.Sort(arr2); // sortujemy obie
            for (int i = 0; i < 11; i++)
                if (arr1[i] != arr2[i]) // porownujemy, jesli gdzies sie roznia to nie jest mozliwa permutacja
                {
                    Console.WriteLine("NO");
                    goto finish; //w przypadku roznicy miedzy tablicami, przechodzimy do finish:
                }
            Console.WriteLine("YES");
            finish:;
        }
