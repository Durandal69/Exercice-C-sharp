// Jour 1 Exercice 3 : Calcul de l'IMC

// Annonce des variables
// VARIABLE poids, taille, IMC : REEL
double poids, taille, IMC;

// Entrées des valeurs utilisateurs
// AFFICHER "Entrez le poids en kg"
// LIRE poids
// AFFICHER "Entrez la taille en m"
// LIRE taille
Console.WriteLine("Entrez le poids en kg :");
poids = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Entrez la taille en m :");
taille = Convert.ToDouble(Console.ReadLine());

// Calcul de l'IMC
// IMC <- poids / taille²
IMC = poids / (taille * taille);

// Comparatif avec les fourchettes de poids et affichage
// SI IMC < 18,5 ALORS
// AFFICHER $"Vous êtes en insuffisance pondérale, votre IMC est de {IMC:F1}"
if (IMC < 18.5)
{
    Console.WriteLine($"Vous êtes en insuffisance pondérale, votre IMC est de {IMC:F1}");
}
// SI 18,5 <= IMC < 25 ALORS
// AFFICHER $"Vous avez une corpulence normale, votre IMC est de {IMC:F1}"
else if (IMC < 25)
{
    Console.WriteLine($"Vous avez une corpulence normale, votre IMC est de {IMC:F1}");
}
// SI 25 <= IMC < 30 ALORS
// AFFICHER $"Vous êtes en surpoids, votre IMC est de {IMC:F1}"
else if (IMC < 30)
{
    Console.WriteLine($"Vous êtes en surpoids, votre IMC est de {IMC:F1}");
}
// SI 30 <= IMC < 35 ALORS
// AFFICHER $"Vous êtes en obésité modérée, votre IMC est de {IMC:F1}"
else if (IMC < 35)
{
    Console.WriteLine($"Vous êtes en obésité modérée, votre IMC est de {IMC:F1}");
}
// SI 35 <= IMC < 40 ALORS
// AFFICHER $"Vous êtes en obésité sévère, votre IMC est de " + IMC
else if (IMC < 40)
{
    Console.WriteLine($"Vous êtes en obésité sévère, votre IMC est de {IMC:F1}");
}
// SI IMC >= 40 ALORS
// AFFICHER $"Vous êtes en obésité morbide, votre IMC est de " + IMC
else if (IMC >= 40)
{
    Console.WriteLine($"Vous êtes en obésité morbide, votre IMC est de {IMC:F1}");
}
// SINON
// AFFICHER "Une erreur a été rencontrée."
else
{
    Console.WriteLine("Une erreur a été rencontrée.");
}
// FIN SI