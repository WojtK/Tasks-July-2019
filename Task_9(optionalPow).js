 function optionalPow(a,b){
        var score = 1;
      if(document.getElementById('OK_button').onclick)
          {
              score = Math.pow(a,b);
          }
      if(document.getElementById('Cancel_button').onclick)
          {
              score = Math.pow(b,a);
          }
        return score;
  }
