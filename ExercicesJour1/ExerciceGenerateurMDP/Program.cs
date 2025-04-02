// Jour 1 Exercice 9 : Générateur de mot de passe

// Les Variables
// TABLEAU generateur <- charactères utilisables
// VARIABLE motDePasse = STRING
// CLASSE rand = Random
// VARIABLE longueur = ENTIER

// AFFICHER "Entrez la longueur de mot de passe désirée :"
// LIRE longueur

// TANT QUE longueur > 0 FAIRE
// VARIABLE indexGenerateur <- rand ELEMENT SUIVANT DE generateur
// motDePasse += generateur[indexGenerateur]
// longueur <- --longueur
// FIN

// AFFICHER $"Voici votre nouveau mot de passe : {motDePasse}"

string[] generateur = ["a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z",
"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z",
"0","1","2","3","4","5","6","7","8","9",
"?",";",".",":","/","!","§","ù","%",",",",","$","£","&","é","-","è","_","ç","à"];
string motDePasse = "";
Random rand = new();
int longueur;

Console.WriteLine("Entrez la longueur de mot de passe désirée :");
longueur = Convert.ToInt32(Console.ReadLine());


while (longueur > 0)
{
    int indexGenerateur = rand.Next(generateur.Length);
    motDePasse += generateur[indexGenerateur];
    longueur = --longueur;
}
Console.WriteLine($"Voici votre nouveau mot de passe : {motDePasse}");