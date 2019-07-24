public static void ReverseArray()
        {
            Console.WriteLine("enter the size: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int j = 0; j < arr.Length; j++)
                arr[j] = int.Parse(Console.ReadLine());

            for (int i = arr.Length; i > 0; i--)
                Console.Write(arr[i - 1] + " ");
        }
