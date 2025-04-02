// Jour 2 Exercice 10 : Calcul de date future

// Les Variables
// VARIABLES jour, mois, annee, anneeCible, moisCible,jourCible, ajoutAnnee,ajoutJour, ajoutMois = ENTIER

// AFFICHER "Entrez la date initiale :"
// AFFICHER "Jour :"
// LIRE jour
// AFFICHER "Mois :"
// LIRE mois
// AFFICHER "Année :"
// LIRE annee
// // AFFICHER "Nombre de jours à ajouter :"
// LIRE ajoutJour

// jourCible <- (jour + ajoutJour) % 30
// ajoutMois <- (jour + ajoutJour) / 30
// moisCible <- (mois + ajoutMois) % 12
// ajoutAnnee <- (mois + ajoutMois) / 12
// aneeCible <- annee + ajoutAnnee

// SI moisCible = 0 ALORS
// moisCible <- 12
// anneeCible <- anneeCible - 1
// FIN

// SI jourCible = 0 ALORS
// jourCible <- 30
// moisCible <- moisCible - 1
    // SI moisCible = 0 ALORS
    // moisCible <- 12
    // anneeCible <- anneeCible - 1
    // FIN
// FIN

// AFFICHER $"La date après {jour} jours sera : {anneeCible}/{moisCible}/{jourCible}"

int jour, mois, annee, anneeCible, moisCible, jourCible, ajoutAnnee,ajoutJour, ajoutMois;

Console.WriteLine("Entrez la date initiale :");
Console.WriteLine("Jour :");
jour = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Mois :");
mois = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Année :");
annee = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Nombre de jours à ajouter :");
ajoutJour = Convert.ToInt32(Console.ReadLine());

jourCible = (jour + ajoutJour) % 30;
ajoutMois = (jour + ajoutJour) / 30;
moisCible = (mois + ajoutMois) % 12;
ajoutAnnee = (mois + ajoutMois) / 12;
anneeCible = annee + ajoutAnnee;

if (moisCible == 0)
{
    moisCible = 12;
    anneeCible -= 1;
}

if (jourCible == 0)
{
    jourCible = 30;
    moisCible -= 1;

    if (moisCible == 0)
    {
        moisCible = 12;
        anneeCible -= 1;
    }
}

Console.WriteLine($"La date après {jour} jours sera : {anneeCible}/{moisCible}/{jourCible}");


