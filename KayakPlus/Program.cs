namespace Kayak
{
    public class Program
    {
        static void GetNumberPeoples(ref int nb, ref int somme, string questions, int price) {
            Console.Write(questions);
            int tmp = Int32.Parse(Console.ReadLine());
            nb += tmp;
            somme += tmp * price;
        }
        
        public static async Task Main(string[] args) {
            try {
                bool end = true;
                int recette = 0, seniors = 0, adultes = 0, enfants = 0, bebes = 0, somme = 0, tmp = 0;
                while (true) {
                    somme = 0;
                    GetNumberPeoples(ref seniors, ref somme, "Combien d'adultes de plus de 65 ans êtes-vous ? ", 10);
                    GetNumberPeoples(ref adultes, ref somme, "Combien d'adultes entre 12 et 65 ans êtes-vous ? ", 12);
                    GetNumberPeoples(ref enfants, ref somme, "Combien d'enfants de moins de 12 ans y a t-il ? ", 5);

                    Console.Write("Combien de bébé y a t-il ? ");
                    bebes += Int32.Parse(Console.ReadLine());
                    
                    Console.Write("Pour combien d'heures souhaitez vous louer les kayaks ? ");
                    somme *= Int32.Parse(Console.ReadLine());
                    
                    Console.WriteLine($"Le montant final de la location sera: {somme}\n");
                    recette += somme;

                    Console.Write("Souhaitez-vous enregistrez une bouvelle réservations ? ");
                    string input = Console.ReadLine().ToLower();
                    Console.Write('\n');
                    if (input == "non" || input == "no" || (input != "oui" && input != "yes")) {
                        break;
                    }
                }
                Console.WriteLine($"Le montant total gagné au cours de la journée est de {recette}.\nIl y a eu {seniors} seniors, {adultes} adultes, {enfants} enfants et {bebes} bébés.");
            } catch (Exception ex) {
                Console.WriteLine("Error");
            }
        }
    }
}