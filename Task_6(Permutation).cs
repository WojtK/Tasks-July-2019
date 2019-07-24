public static void Permutation()
        {
            Console.WriteLine("Array1: ");
            int[] arr1 = new int[11];
            for (int j = 0; j < arr1.Length; j++)
                arr1[j] = int.Parse(Console.ReadLine());
            Console.WriteLine("Array2: ");
            int[] arr2 = new int[11];
            for (int j = 0; j < arr2.Length; j++)
                arr2[j] = int.Parse(Console.ReadLine());

            Array.Sort(arr1);
            Array.Sort(arr2);
            for (int i = 0; i < 11; i++)
                if (arr1[i] != arr2[i])
                {
                    Console.WriteLine("NO");
                    goto finish;
                }
            Console.WriteLine("YES");
            finish:;
        }
