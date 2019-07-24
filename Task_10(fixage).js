fixage(tab) //pobiera podana tablice
    {
        var newtab = []; //deklarujemy pusta tablice
		var s = "";
        for(var i =0; i < tab.length; i++)
            {
                if(tab[i] >= 18 && tab[i] <= 60) //sprawdzamy czy dany indeks tablicy nie ma przypadkiem poszukiwanej przez nas wartosci
                    {
                       newtab.push(tab[i]); // jestli tak to dodajemy go do tablicy newtab
                    }
            }
        for(var i=0; i < newtab.length; i++) 
        {
          s+=newtab[i]+","; //wypisujemy newtab
        }
        if (newtab[0] == null)
		{
			console.log("NA"); //jesli newtab jest puste, wypisujemy "NA"
		}else
          console.log(s); 
    }
