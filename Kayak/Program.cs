namespace Kayak
{
    public class Program
    {
        public static async Task Main(string[] args) {
            try {
                Console.Write("Combien d'adultes de plus de 65 ans êtes-vous ? ");
                int senior = Int32.Parse(Console.ReadLine());
                Console.Write("Combien d'adultes entre 12 et 65 ans êtes-vous ? ");
                int adultes = Int32.Parse(Console.ReadLine());
                Console.Write("Combien d'enfants de moins de 12 ans êtes-vous ? ");
                int enfants = Int32.Parse(Console.ReadLine());
                Console.Write("Pour combien d'heures souhaitez vous louer les kayaks ? ");
                int heures = Int32.Parse(Console.ReadLine());
                Console.WriteLine($"Le montant final de la location sera: {(senior * 10 + adultes * 12 + enfants * 5) * heures}");
            } catch (Exception ex) {
                Console.WriteLine("Error");
            }
        }
    }
}