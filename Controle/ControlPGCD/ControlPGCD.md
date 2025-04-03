Pseudo code pour le PGCD avec l'algorithme d'Euclide


Début
  VARIABLE a, b : ENTIER
  VARIABLE pgcd : ENTIER
  
  AFFICHER "Entrez le premier nombre : "
  LIRE a
  
  AFFICHER "Entrez le deuxième nombre : "
  LIRE b
  
  SI a <= 0 OU b <= 0 ALORS
    AFFICHER "Les nombres doivent être positifs"
    TERMINER
  FIN SI

    // Algorithme d'Euclide pour le PGCD
  FONCTION CalculerPGCD(a, b : ENTIER) : ENTIER
    VARIABLE temp : ENTIER
    
    TANT QUE b != 0 FAIRE
      temp <- b
      b <- a % b
      a <- temp
    FIN TANT QUE
    
    RETOURNER a
  FIN FONCTION
  
  pgcd <- CalculerPGCD(a, b)

    AFFICHER "PGCD(" + a + ", " + b + ") = " + pgcd

FIN
