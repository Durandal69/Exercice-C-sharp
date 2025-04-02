// Jour 1 Exercice 2 : Calcul de mensualité de prêt

// Annonce des variables
// VARIABLE montantEmprunt : REEL
// VARIABLE tauxInteretAnnuel : REEL
// VARIABLE dureePretMois : ENTIER
// VARIABLE mensualite : REEL
double montantEmprunt;
double tauxInteretAnnuel;
int dureePretMois;
double mensualite;

// Entrées des valeurs utilisateurs
// AFFICHER "Entrez le montant de l'emprunt :"
// LIRE montantEmprunt
Console.WriteLine("Entrez le montant de l'emprunt :");
montantEmprunt = Convert.ToDouble(Console.ReadLine());
// AFFICHER "Entrez le taux d'intérêt annuel en %:"
// LIRE tauxInteretAnnuel / 100
Console.WriteLine("Entrez le taux d'intérêt annuel en % :");
tauxInteretAnnuel = Convert.ToDouble(Console.ReadLine()) / 100;
// AFFICHER "Entrez la durée du prêt en années :"
// LIRE dureePretMois
Console.WriteLine("Entrez la durée du prêt en années :");
dureePretMois = Convert.ToInt32(Console.ReadLine());

// Calcul des mensualités et affichage du résultat
// mensualite <- (montantEmprunt * tauxInteretAnnuel / 12) / (1 - (1 + tauxInteretAnnuel / 12)^(-dureePretMois*12))
// AFFICHER "Vos mensualités sont de " + mensualite + " €."
mensualite = (montantEmprunt * tauxInteretAnnuel / 12) / (1 - Math.Pow(1 + (tauxInteretAnnuel / 12), -dureePretMois*12));
Console.WriteLine("Vos mensualités sont de " + mensualite + " €.");
