// Jour 1 Exercice 7 : Calcul de factorielle (version itérative)

// Les variables
// VARIABLE nInitial, resultatIntermediaire, resultatFinal, n = ENTIER
// AFFICHER "Quelle est votre valeur de n pour le calcul de factorielle ?"
// LIRE n
// nInitial <- n
// resultatFinal <- 0
// resultatIntermediaire <- n

// SI n = 1
// AFFICHER $"La factorielle de {n} est : {n}."
// SINON SI n < 1
// AFFICHER "Attention, une factorielle nécessite un nombre entier positif au départ !"
// SINON
// TANT QUE nInitial > 1 FAIRE
//      resultatIntermediaire <- ResultatIntermediaire * --nInitial
//      resultatFinal <- resultatIntermediaire
// FIN TANT QUE
// AFFICHER $"La factorielle de {n} est : {resultatFinal}."
// FIN


int nInitial, resultatIntermediaire, resultatFinal, n;

Console.WriteLine("Quelle est votre valeur de n pour le calcul de factorielle ?");
n = Convert.ToInt32(Console.ReadLine());
nInitial = n;
resultatFinal = 0;
resultatIntermediaire = n;

if (n == 1)
{
    Console.WriteLine($"La factorielle de {n} est : {n}.");
}
else if (n < 1)
{
    Console.WriteLine("Attention, une factorielle nécessite un nombre entier positif au départ !");
}
else
{
while (nInitial > 1)
{
    resultatIntermediaire = resultatIntermediaire * --nInitial;
    resultatFinal = resultatIntermediaire;
}
Console.WriteLine($"La factorielle de {n} est : {resultatFinal}.");
}