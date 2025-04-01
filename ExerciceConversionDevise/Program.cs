// Jour 2 Exercice 5 : Conversion de devise

// Les Variables
// VARIABLE deviseInitiale = ENTIER
// VARIABLE montant = REEL
// VARIABLE deviseCible = ENTIER
// VARIABLE montantConverti = REEL

// AFFICHER "Quelle est votre devise de base ?"
// AFFICHER "Tapez 1 pour EUR, Tapez 2 pour USD, Tapez 3 pour GBP, Tapez 4 pour JPY"
// LIRE deviseInitiale
// AFFICHER "Vers quelle devise voulez-vous la convertir ?"
// AFFICHER "Tapez 1 pour EUR, Tapez 2 pour USD, Tapez 3 pour GBP, Tapez 4 pour JPY"
// LIRE deviseCible
// AFFICHER "Quel est le montant à convertir ?"
// LIRE montant

// SWITCH deviseInitiale
// case 1
    // SWITCH deviseCible
    // case 1
        // AFFICHER "Erreur. Vous avez chercher à convertir des EUR en EUR."
        // BREAK
    // case 2
        // montantConverti <- montant * 1.10
        // AFFICHER $"{montant} EUR est équivalent à {montantConverti:F2} USD."
        // BREAK
    // case 3
        // montantConverti <- montant * 0.85
        // AFFICHER $"{montant} EUR est équivalent à {montantConverti:F2} GBP."
        // BREAK
    // case 4
        // montantConverti <- montant * 158
        // AFFICHER $"{montant} EUR est équivalent à {montantConverti:F2} JPY."
        // BREAK
    // default
        // AFFICHER "Erreur. Devise ou montant invalide."
        // BREAK
    // BREAK
// case 2
    // SWITCH deviseCible
    // case 1
        // montantConverti <- montant / 1.10
        // AFFICHER $"{montant} USD est équivalent à {montantConverti:F2} EUR."
        // BREAK
    // case 2
        // AFFICHER "Erreur. Vous avez chercher à convertir des USD en USD."
        // BREAK
    // case 3
        // montantConverti <- montant / 1.10 * 0.85
        // AFFICHER $"{montant} USD est équivalent à {montantConverti:F2} GBP."
        // BREAK
    // case 4
        // montantConverti <- montant / 1.10 * 158
        // AFFICHER $"{montant} USD est équivalent à {montantConverti:F2} JPY."
        // BREAK
    // default
        // AFFICHER "Erreur. Devise ou montant invalide."
        // BREAK
    // BREAK
// case 3
    // SWITCH deviseCible
    // case 1
        // montantConverti <- montant / 0.85
        // AFFICHER $"{montant} GBP est équivalent à {montantConverti:F2} EUR."
        // BREAK
    // case 2
        // montantConverti <- montant / 0.85 * 1.10
        // AFFICHER $"{montant} GBP est équivalent à {montantConverti:F2} USD."
        // BREAK
    // case 3
        // AFFICHER "Erreur. Vous avez chercher à convertir des GBP en GBP."
        // BREAK
    // case 4
        // montantConverti <- montant / 0.85 * 158
        // AFFICHER $"{montant} GBP est équivalent à {montantConverti:F2} JPY."
        // BREAK
    // default
        // AFFICHER "Erreur. Devise ou montant invalide."
        // BREAK
    // BREAK
// case 4
    // SWITCH deviseCible
    // case 1
        // montantConverti <- montant / 158
        // AFFICHER $"{montant} JPY est équivalent à {montantConverti:F2} EUR."
        // BREAK
    // case 2
        // montantConverti <- montant / 158 * 1.10
        // AFFICHER $"{montant} JPY est équivalent à {montantConverti:F2} USD."
        // BREAK
    // case 3
        // montantConverti <- montant / 158 * 0.85
        // AFFICHER $"{montant} JPY est équivalent à {montantConverti:F2} GBP."
        // BREAK
    // case 4
        // AFFICHER "Erreur. Vous avez chercher à convertir des JPY en JPY."
        // BREAK
    // default
        // AFFICHER "Erreur. Devise ou montant invalide."
        // BREAK
    // BREAK

int deviseInitiale, deviseCible;
double montant, montantConverti;

Console.WriteLine("Quelle est votre devise de base ?");
Console.WriteLine("Tapez 1 pour EUR, Tapez 2 pour USD, Tapez 3 pour GBP, Tapez 4 pour JPY");
deviseInitiale = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vers quelle devise voulez-vous la convertir ?");
Console.WriteLine("Tapez 1 pour EUR, Tapez 2 pour USD, Tapez 3 pour GBP, Tapez 4 pour JPY");
deviseCible = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Quel est le montant à convertir ?");
montant = Convert.ToDouble(Console.ReadLine());

switch (deviseInitiale)
{
    case 1 :
        switch (deviseCible)
        {
            case 1 :
                Console.WriteLine("Erreur. Vous avez chercher à convertir des EUR en EUR.");
                break;
            case 2 :
                montantConverti = montant * 1.10;
                Console.WriteLine($"{montant} EUR est équivalent à {montantConverti:F2} USD.");
                break;
            case 3 :
                montantConverti = montant * 0.85;
                Console.WriteLine($"{montant} EUR est équivalent à {montantConverti:F2} GBP.");
                break;
            case 4 :
                montantConverti = montant * 158;
                Console.WriteLine($"{montant} EUR est équivalent à {montantConverti:F2} JPY.");
                break;
            default :
                Console.WriteLine("Erreur. Devise ou montant invalide.");
                break;
        }
    break;
    case 2 :
        switch (deviseCible)
        {
            case 1 :
                montantConverti = montant / 1.10;
                Console.WriteLine($"{montant} USD est équivalent à {montantConverti:F2} EUR.");
                break;
            case 2 :
                Console.WriteLine("Erreur. Vous avez chercher à convertir des USD en USD.");
                break;
            case 3 :
                montantConverti = montant / 1.10 * 0.85;
                Console.WriteLine($"{montant} USD est équivalent à {montantConverti:F2} GBP.");
                break;
            case 4 :
                montantConverti = montant / 1.10 * 158;
                Console.WriteLine($"{montant} USD est équivalent à {montantConverti:F2} JPY.");
                break;
            default :
                Console.WriteLine("Erreur. Devise ou montant invalide.");
                break;
        }
    break;    
    case 3 :
        switch (deviseCible)
        {
            case 1 :
                montantConverti = montant / 0.85;
                Console.WriteLine($"{montant} GBP est équivalent à {montantConverti:F2} EUR.");
                break;
            case 2 :
                montantConverti = montant / 0.85 * 1.10;
                Console.WriteLine($"{montant} GBP est équivalent à {montantConverti:F2} USD.");
                break;
            case 3 :
                Console.WriteLine("Erreur. Vous avez chercher à convertir des GBP en GBP.");
                break;
            case 4 :
                montantConverti = montant / 0.85 * 158;
                Console.WriteLine($"{montant} GBP est équivalent à {montantConverti:F2} JPY.");
                break;
            default :
                Console.WriteLine("Erreur. Devise ou montant invalide.");
                break;
        }
    break;
    case 4 :
        switch (deviseCible)
        {
            case 1 :
                montantConverti = montant / 158;
                Console.WriteLine($"{montant} JPY est équivalent à {montantConverti:F2} EUR.");
                break;
            case 2 :
                montantConverti = montant / 158 * 1.10;
                Console.WriteLine($"{montant} JPY est équivalent à {montantConverti:F2} USD.");
                break;
            case 3 :
                montantConverti = montant / 158 * 0.85;
                Console.WriteLine($"{montant} JPY est équivalent à {montantConverti:F2} GBP.");
                break;
            case 4 :
                Console.WriteLine("Erreur. Vous avez chercher à convertir des JPY en JPY.");
                break;
            default :
                Console.WriteLine("Erreur. Devise ou montant invalide.");
                break;
        }
    break;
    default :
        Console.WriteLine("Erreur. Devise ou montant invalide.");
        break;
}