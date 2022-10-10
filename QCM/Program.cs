using Random = System.Random;

namespace QCM
{
    public class Program
    {
        static string[] questions = new[] {
            "Quel était le principal facteur de localisation des industries autrefois ?",
            "Quel espace est attractif en France pour les industries ?",
            "Quel espace industriel traditionnel en crise actuellement, est en reconversion ?",
            "Quel régime politique dirige la France jusqu’en octobre 1946 ?",
            "Les Trente Glorieuses désignent…",
            "Qu’est-ce que l’Etat-providence ?",
            "Quelle entreprise d’Etat est créée en 1946 ?",
            "A quelle date le SMIC est-il créé ?",
            "A quelle date est créé le ministère des Affaires culturelles ?",
            "Le Commissariat général au Plan est-il une institution chargée…"
        };
        static Tuple<string, bool>[][] answers = new Tuple<string, bool>[][] 
        {
            new Tuple<string, bool>[] {
                Tuple.Create("Une main d'oeuvre hautement qualifiée.", false),
                Tuple.Create("Un cadre de vie agréable.", false),
                Tuple.Create("La proximité des matières premières.", true),
            },
            new [] {
                Tuple.Create("Le Nord.", false),
                Tuple.Create("Le Massif central.", false),
                Tuple.Create("Le Sud de la France", true),
            },
            new [] {
                Tuple.Create("Le Nord-Est.", true),
                Tuple.Create("Le Sud.", false),
                Tuple.Create("L'Occitanie.", false),
            },
            new [] {
                Tuple.Create("La Ve République.", false),
                Tuple.Create("Le Gouvernement provisoire de la République française.", true),
                Tuple.Create("la IVe République.", false),
            },
            new [] {
                Tuple.Create("La période de forte prospérité que connaissent les pays industrialisés occidentaux après la Seconde Guerre mondiale.", true),
                Tuple.Create("Les deux.", false),
                Tuple.Create("Les trente premiers jours qui suivent la mise en place de la Ve République en France.", false),
            },
            new [] {
                Tuple.Create("Un Etat qui cherche à diminuer le plus possible le montant des impôts.", false),
                Tuple.Create("Un Etat qui intervient dans le domaine social et économique pour veiller au bien-être des citoyens.", true),
                Tuple.Create("Les deux", false),
            },
            new [] {
                Tuple.Create("Les deux.", true),
                Tuple.Create("Gaz de France.", false),
                Tuple.Create("Electricité de France.", false),
            },
            new [] {
                Tuple.Create("1955.", false),
                Tuple.Create("1970", true),
                Tuple.Create("1985", false),
            },
            new [] {
                Tuple.Create("1948", false),
                Tuple.Create("1981", false),
                Tuple.Create("1949", true),
            },
            new [] {
                Tuple.Create("De développer le programme nucléaire français après 1946.", false),
                Tuple.Create("Les deux", false),
                Tuple.Create("D’organiser la reconstruction économique du pays après la Seconde Guerre mondiale", true),
            },
        };

        static void PrintQuestion(int i, int question, bool displayAnswer = false) {
            Console.WriteLine($"{i}) {questions[question]}");
            for (int j = 0; j < 3; ++j) {
                if (displayAnswer == true && answers[question][j].Item2 == true)
                    Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"    {j + 1}. {answers[question][j].Item1}\n");
                Console.ResetColor();
            }
        }

        static int GetAnswer() {
            while (true) {
                var key = Console.ReadKey(true);
                if (key.KeyChar >= '1' && key.KeyChar <= '3') {
                    return key.KeyChar - '1';
                }
            }
        }
        
        public static async Task Main(string[] args) {
            try {
                Random aleatoire = new Random();
                int success = 0;
                int answer = -1;
                List<Tuple<int, int>> failedQuestions = new List<Tuple<int, int>>();
                for (int i = 0; i < 4; ++i) {
                    int question = aleatoire.Next(9);
                    PrintQuestion(i, question);
                    Console.Write("\nVeuillez saisir le numéro de la réponse que vous pensez être la bonne: ");
                    answer = GetAnswer();                    
                    Console.WriteLine(answer + 1);
                    Console.Write('\n');
                    if (answers[question][answer].Item2 == true) {
                        ++success;
                    } else {
                      failedQuestions.Add(Tuple.Create<int, int>(i, question));  
                    }
                }
                Console.WriteLine($"Résultat: {(success == 4 ? 'A' : success == 3 ? 'B' : success == 2 ? 'D' : 'E')}");
                Console.WriteLine("\nCorrection:\n");
                foreach (var failedQuestion in failedQuestions) {
                    PrintQuestion(failedQuestion.Item1, failedQuestion.Item2, true);
                    Console.Write('\n');
                }
            } catch (Exception ex) {
                Console.WriteLine("Error");
            }
        }
    }
}