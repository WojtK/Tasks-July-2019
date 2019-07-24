public static void Palindrom(string word)
        {
            Console.WriteLine(word);
            Regex rgx = new Regex("[^a-zA-Z]");
            word = rgx.Replace(word, "").ToLower();
            Console.WriteLine(word);
            string reversed = new string(word.Reverse().ToArray());
            Console.WriteLine(reversed);
            if (word == reversed)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
