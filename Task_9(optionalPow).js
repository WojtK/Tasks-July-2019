 function optionalPow(a,b){
        var score = 1; // wartosc domyslna
      if(document.getElementById('OK_button').onclick) //sprawdza czy nie zostal klikniety przycisk OK (domyslnie 'OK_button')
          {
              score = Math.pow(a,b);
          }
      if(document.getElementById('Cancel_button').onclick) //sprawdza czy nie zostal klikniety przycisk CANCEL (domyslnie 'Cancel_button')
          {
              score = Math.pow(b,a); 
          }
        return score; // zwraca wynik potegowania
  }
