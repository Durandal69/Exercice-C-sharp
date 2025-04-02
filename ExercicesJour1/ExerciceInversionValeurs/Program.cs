// Test Exercice 3

// Déclaration des variables
int valeur1;
int valeur2;
int tampon;
try
{
// Acquisition des valeurs de l'utilisateur
Console.WriteLine("Entrez votre première valeur :");
valeur1 = int.Parse(Console.ReadLine());
Console.WriteLine("Entrez votre deuxième valeur :");
valeur2 = int.Parse(Console.ReadLine());

// Vérification des résultats entrés
Console.WriteLine("Votre première valeur est " + valeur1);
Console.WriteLine("Votre deuxième valeur est " + valeur2);

// Inversion des valeurs
tampon = valeur2;
valeur2 = valeur1;
valeur1 = tampon;

// Affichage des résultats
Console.WriteLine("Et votre première valeur est maintenant : " + valeur1);
Console.WriteLine("Et votre deuxième valeur est maintenant : " + valeur2);
}
catch (System.Exception)
{
    Console.WriteLine("Une erreur inattendue est survenue.");
}