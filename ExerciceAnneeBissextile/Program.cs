// Jour 2 Exercice Année Bissextile

// Les variables
// VARIABLE année : ENTIER

// AFFICHER "Pour quelle année voulez-vous savoir si elle est bissextile ?"
// LIRE année

// Calcul
// SI divisible par 4 ET NON par 100 OU divisible par 400 
// AFFICHER $"L'année {année} est bissextile."
// SINON
// AFFICHER $"L'année {année} n'est pas bissextile."

int année;

Console.WriteLine("Pour quelle année voulez-vous savoir si elle est bissextile ?");
année = Convert.ToInt32(Console.ReadLine());

if ((année % 4) == 0 && (année % 100) != 0 || (année % 400) == 0 )
{
    Console.WriteLine($"L'année {année} est bissextile.");
}
else
{
    Console.WriteLine($"L'année {année} n'est pas bissextile.");
}