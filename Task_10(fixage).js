fixage(tab)
    {
        var newtab = [];
		var s = "";
        for(var i =0; i < tab.length; i++)
            {
                if(tab[i] >= 18 && tab[i] <= 60)
                    {
                       newtab.push(tab[i]);
                    }
            }
        for(var i=0; i < newtab.length; i++) 
        {
          s+=newtab[i]+","; 
        }
        if (newtab[0] == null)
		{
			console.log("NA");
		}else
          console.log(s); 
    }
