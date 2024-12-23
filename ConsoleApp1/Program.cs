using System;

class Program
{
    static void Main()
    {
        // Demande de la hauteur du sapin
        int hauteur = DemanderHauteur();

        // Dessin des feuilles du sapin
        DessinerFeuilles(hauteur);

        // Dessin du tronc du sapin
        DessinerTronc(hauteur);
    }

    // Fonction pour demander la hauteur du sapin
    static int DemanderHauteur()
    {
        int hauteur = 0;

        // Demande à l'utilisateur d'entrer la hauteur du sapin
        Console.WriteLine("Entrez la hauteur du sapin (entre 1 et 30) :");

        // Boucle pour valider la saisie
        while (true)
        {
            string saisie = Console.ReadLine();

            if (int.TryParse(saisie, out hauteur))
            {
                if (hauteur >= 1 && hauteur <= 30)
                {
                    break; // Si la saisie est valide, sortir de la boucle
                }
                else
                {
                    Console.WriteLine("Veuillez entrer un nombre entre 1 et 30.");
                }
            }
            else
            {
                Console.WriteLine("Saisie invalide. Veuillez entrer un nombre entier.");
            }
        }

        return hauteur;
    }

    // Fonction pour dessiner les feuilles du sapin
    static void DessinerFeuilles(int hauteur)
    {
        for (int i = 1; i <= hauteur; i++)
        {
            // Calcul du nombre d'étoiles pour cette ligne (1, 3, 5, ...)
            int nombreEtoiles = 2 * i - 1;

            // Calcul de l'indentation (centrer le sapin)
            int indentation = hauteur - i;

            // Affichage de la ligne avec indentation et étoiles
            Console.WriteLine(new string(' ', indentation) + new string('*', nombreEtoiles));
        }
    }

    // Fonction pour dessiner le tronc du sapin
    static void DessinerTronc(int hauteur)
    {
        // La hauteur du tronc est environ 1/3 de la hauteur des feuilles
        int hauteurTronc = Math.Max(1, hauteur / 3);

        // Le tronc est toujours constitué de 3 caractères `|||`
        string tronc = "|||";

        // Calcul de l'indentation pour centrer le tronc sur la ligne la plus large
        int indentation = (hauteur * 2 - 1 - tronc.Length) / 2;

        // Affichage du tronc
        for (int i = 0; i < hauteurTronc; i++)
        {
            Console.WriteLine(new string(' ', indentation) + tronc);
        }
    }
}
