public static void Palindrom(string word)
        {
            Regex rgx = new Regex("[^a-zA-Z]");
            word = rgx.Replace(word, "").ToLower(); //usuwamy wszelkie "zle znaki"
            string reversed = new string(word.Reverse().ToArray()); // tworzymy nowy string, ktory jest odwrocona wersja word
            Console.WriteLine(reversed);
            if (word == reversed)  //porownujemy
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
