// Jour 1 Exercice 8 : Palindrome

// Les Variables
// VARIABLE motUtilisateur, motInverse = STRING

// AFFICHER "Quel mot voulez-vous tester pour savoir si c'est un palindrome ?"
// LIRE motUtilisateur
// TABLEAU motGaD <- DECOMPOSE EN LETTRE motUtilisateur
// INVERSE motGaD
// motInverse <- RECOMPOSE EN STRING motGaD

// SI motUtilisateur = motInverse
// AFFICHER $"{motUtilisateur} est un palindrome.")
// SINON
// AFFICHER $"{motUtilisateur} n'est pas un palindrome, inversé il donne {motInverse}."


string motUtilisateur, motInverse;
Console.WriteLine("Quel mot voulez-vous tester pour savoir si c'est un palindrome ?");
motUtilisateur = Console.ReadLine();

char[] motGaD = motUtilisateur.ToCharArray();
Array.Reverse(motGaD);
motInverse = new string(motGaD);

if (motUtilisateur == motInverse)
{
    Console.WriteLine($"{motUtilisateur} est un palindrome.");
}
else
{
    Console.WriteLine($"{motUtilisateur} n'est pas un palindrome, inversé il donne {motInverse}.");
}
