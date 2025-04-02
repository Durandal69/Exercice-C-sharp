// Jour 2 Exercice 1 : Calculateur de notes

// Les Variables
// VARIABLE nombreNotes = ENTIER
// VARIABLES moyenne, noteMax, noteMin = REEL
// VARIABLE appreciation = STRING

// AFFICHER "Combien de notes souhaitez-vous saisir ?"
// LIRE nombreNotes
// TABLEAU notes <- taille = nombreNotes

// POUR i = 0 ; i < nombreNotes ; i++
// AFFICHER $"Entrez la note {i + 1} :"
// TABLEAU notes[i] <- ajouter notes
// FIN

// moyenne <- notes.Average()
// noteMax <- notes.Max()
// noteMin <- notes.Min()

// SI moyenne >= 20 ALORS
// AFFICHER "Erreur, veuillez vérifier que les notes se trouvent dans l'intervalle de 0 à 20."
// SINON SI moyenne >= 16 ALORS
// appreciation = "Très bien"
// SINON SI moyenne >= 14 ALORS
// appreciation = "Bien"
// SINON SI moyenne >= 12 ALORS
// appreciation = "Assez bien"
// SINON SI moyenne >= 10 ALORS
// appreciation = "Passable"
// SINON SI moyenne < 10 ALORS
// appreciation = "Insuffisant"
// SINON
// AFFICHER "Erreur, veuillez vérifier que les notes se trouvent dans l'intervalle de 0 à 20."
// FIN

// AFFICHER "Résultats :"
// AFFICHER $"Moyenne : {moyenne}"
// AFFICHER $"Note la plus haute : {noteMax}"
// AFFICHER $"Note la plus basse : {noteMin}"
// AFFICHER $"Appréciation : {appreciation}"

int nombreNotes;
double moyenne, noteMax, noteMin;
string appreciation = "";

Console.WriteLine("Combien de notes souhaitez-vous saisir ?");
nombreNotes = Convert.ToInt32(Console.ReadLine());
double[] notes = new double[nombreNotes];

for (int i = 0 ; i < nombreNotes ; i++)
{
    Console.WriteLine($"Entrez la note {i + 1} :");
    notes[i] = Convert.ToDouble(Console.ReadLine());
}

moyenne = notes.Average();
noteMax = notes.Max();
noteMin = notes.Min();

if (moyenne >= 20)
{
    Console.WriteLine("Erreur, veuillez vérifier que les notes se trouvent dans l'intervalle de 0 à 20.");
}
else if (moyenne >= 16)
{
    appreciation = "Très bien";
}
else if (moyenne >= 14)
{
    appreciation = "Bien";
}
else if (moyenne >= 12)
{
    appreciation = "Assez bien";
}
else if (moyenne >= 10)
{
    appreciation = "Passable";
}
else if (moyenne < 10)
{
    appreciation = "Insuffisant";
}
else
{
    Console.WriteLine("Erreur, veuillez vérifier que les notes se trouvent dans l'intervalle de 0 à 20.");
}

Console.WriteLine("Résultats :");
Console.WriteLine($"Moyenne : {moyenne}");
Console.WriteLine($"Note la plus haute : {noteMax}");
Console.WriteLine($"Note la plus basse : {noteMin}");
Console.WriteLine($"Appréciation : {appreciation}");