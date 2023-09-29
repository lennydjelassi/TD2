using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TD2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Création du tableau mois qui contient les 12 mois de l'année
            string[] mois = new string[]
            {
            "Janvier", "Février", "Mars", "Avril", "Mai", "Juin",
            "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre"
            };

            // Création de la liste des mois à partir du tableau
            List<string> listeMois = new List<string>(mois); //création d'une nouvelle liste


            // Liste des mois en rouge avec la lettre r
            List<string> moisAvecRouge = new List<string>(); //création d'une nouvelle liste


            // Liste des mois avec numéro
            List<string> moisAvecNumero = new List<string>(); //création d'une nouvelle liste
            for (int i = 0; i < mois.Length; i++) //boucle d'itération en for pour parcourir le tableau mois
            {
                moisAvecNumero.Add($"{i + 1}. {mois[i]}"); //ajoute à la liste moisAvecNumero le numéro du mois concerné
            }


            //montre à l'utilisateur les différents choix qui s'offrent à lui
            Console.WriteLine("Choisissez entre les numéros 1, 2 ou 3 :");
            Console.WriteLine("1. liste des mois");
            Console.WriteLine("2. liste des mois avec en rouge les mois contenant un R");
            Console.WriteLine("3. liste des mois avec leur numéro");

            // Demande à l'utilisateur de saisir un choix
            Console.Write("Entrez votre choix (1, 2 ou 3) : ");
            string choixUtilisateur = Console.ReadLine();

            // Convertir l'entrée en un nombre entier
            if (int.TryParse(choixUtilisateur, out int choix))
            {
                switch (choix)
                {
                    case 1: //si le choix est 1 alors la liste affiché sera listeMois
                        foreach (string m in mois)
                        {
                            Console.WriteLine(m); //print les mois 
                        }
                        break;
                    case 2: //si le choix est 2 alors la liste affiché sera moisAvecRouge
                        foreach (string m in mois) //fais le tour du tableau mois
                        {
                            if (m.Contains("r") || m.Contains("R")) //condition pour savoir si m contient la lettre r en minuscule ou majuscule
                            {
                                Console.ForegroundColor = ConsoleColor.Red; //change la couleur en rouge
                                moisAvecRouge.Add(m); //ajoute le mois en rouge à la liste moisAvecRouge
                                Console.WriteLine(m); //print le mois
                                Console.ResetColor(); //reset la couleur
                            }
                            else
                            {
                                Console.WriteLine(m); //print le mois
                            }
                        }
                        break;
                    case 3: //si le choix est 3 alors la liste affichée sera moisAvecNumero
                        foreach (string m in moisAvecNumero)
                        {
                            Console.WriteLine(m); //print les mois de la liste moisAvecNumero
                        }
                        break;
                    default:
                        Console.WriteLine("Choix invalide. Veuillez choisir entre 1, 2 ou 3.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrée invalide. Veuillez saisir un nombre valide (1, 2 ou 3).");
            }

            Console.ReadLine();
        }
    }
}
