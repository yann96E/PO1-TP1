namespace Kayak
{
    public class Program
    {
        public static async Task Main(string[] args) {
            try {
                
            bool end = true;
                while (end)
                {
                    Console.WriteLine("\n1. Kayak \n" + "2. KayakPlus \n" + "3.MaxTaxe \n" + "4. ChangerLaCasse \n" + "5. Passeword \n" + "6. E \n" + "7. QCM \n" + "8.WEBENSIMON \n" + "Entrez le numéro de la question que vous souhaitez lire.");
                    int numeroQuestion = int.Parse(Console.ReadLine());


                    switch (numeroQuestion)
                    {
                        case 1:
                            Console.WriteLine("Créer le programme Kayak qui permet de trouver le montant final de location d’un kayak pour une famille sachant que:\n" + "Prix par heure: gratuit pour les bébés, 5$ pour les enfants de moins de 12 ans, 12$ pour les 12 à 65 ans et 10$ pour les plus de 65 ans.");
                            break;
                        case 2:
                            Console.WriteLine("Créer le programme KayakPlus qui, en plus de calculer le montant final de location, trouve le montant total gagné au cours de la journée avec le nombre total de chaque catégorie");
                            break;
                        case 3:
                            Console.WriteLine("Créer le programme MaxTaxe qui permet à chaque personne de 6 couples de saisir leur revenu annuel et trouve le couple qui paie le plus de taxe, avec le montant de cette taxe, sachant que:\n" + "La taxe sur le revenu annuel d’un couple est: 0 % pour un revenu de 25000$ et moins, 15 % pour plus que 25000 jusqu’à 60000$ et 20 % pour plus que 60000$ Et qu’il y a une réduction de 2 % sur la taxe pour chaque enfant du couple.");
                            break;
                        case 4:
                            Console.WriteLine("Créer le programme ChangerLaCasse qui permet de saisir une phrase, puis change chaque lettre minuscule en majuscule et chaque lettre majuscule en minuscule et les espaces par des #.");
                            break;
                        case 5:
                            Console.WriteLine("Soit la chaine de caractères qui contient toutes les lettres minuscules et majuscules et les chiffres de 0 à 9 : a..zA..Z0..9, Créer trois fonctions:\n" + "Min(début, fin) qui affiche juste les minuscules(a étant 0) de début à fin.\n" + "Maj(début, fin) qui affiche juste les majuscules(A étant 0) de début à fin.\n" + "Chiffre(début, fin) qui affiche juste les chiffres(0 étant 0) de début à fin.\n" + "Créer un tableau de chaine de caractères dont la lecture permet d’afficher un mot de passe aléatoire composé de lettres minuscules, majuscules et chiffres.");
                            break;
                        case 6:
                            Console.WriteLine("Créer le programme E qui permet d’afficher la lettre E composé de * ou ♥ sur un nombre de lignes et de colonnes spécifiés par l’utilisateur.");
                            break;
                        case 7:
                            Console.WriteLine("Créer le programme QCM qui pose 4 questions, choisies au hasard parmi une liste de 10 questions, à chaque utilisateur avec 3 choix de réponses pour chaque question et affiche, Pour chaque utilisateur:\n" + "a.Résultat : A pour 4 bonnes réponses, B pour 3, D pour 2 et E pour 1 ou 0.\n" + "b.Correction : juste les questions ratées avec les bonnes réponses");
                            break;
                        case 8:
                            Console.WriteLine("Créer un programme portant votre nom qui permet, à l’aide d’un menu, de lancer les différentes questions du travail.");
                            break;
                    }

                    Console.WriteLine("\nSouhaitez-vous lire une autre question ?");
                    string input = Console.ReadLine().ToLower();
                    if (input == "non" || input == "no" || input == "NON" || input == "NO" || (input != "yes" && input != "oui" && input != "OUI" && input != "YES"))
                    {
                        end = false;

                    }

                }

                Console.WriteLine("\nMerci d'avoir participé.");
            } catch (Exception ex) {
                Console.WriteLine("Error");
            }
        }
    }
}