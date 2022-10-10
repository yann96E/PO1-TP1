namespace MaxTaxe
{
    public class Program
    {
        static public float calculateTax() {
            Console.Write("Quel est le revenue de la permière personne ? ");
            int personne1 = Int32.Parse(Console.ReadLine());
            Console.Write("Quel est le revenue de la deuxième personne ? ");
            int personne2 = Int32.Parse(Console.ReadLine());
            Console.Write("Combien d'enfant avez-vous ? ");
            int nbEnfant = Int32.Parse(Console.ReadLine());
            float income = personne1 + personne2;
            if (income > 25000 && income <= 60000) {
                income *= 0.15f - (nbEnfant * 0.02f);
            } else if (income > 60000) {
                income *= 0.20f - (nbEnfant * 0.02f);
            }
            float toPay = income - 0.98f * nbEnfant;
            return toPay;
        } 
        
        public static async Task Main(string[] args) {
            try {
                float taxe = 0;
                float index = 0;
                float tmp = 0;
                for (int i = 1; i <= 6; ++i) {
                    Console.WriteLine($"Couple numéro {i}:");
                    tmp = calculateTax();
                    if (tmp > taxe) {
                        index = i;
                        taxe = tmp;
                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"Le couple qui paye le plus d'impôt est le couple numéro {index} avec un impôt de {taxe}");
            } catch (Exception ex) {
                Console.WriteLine("Error");
            }
        }
    }
}