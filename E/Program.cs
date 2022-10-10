namespace E
{
    public class Program
    {
        public static async Task Main(string[] args) {
            try {
                Console.Write("Entrer le nombre de colonnes: ");
                float nbColumns = float.Parse(Console.ReadLine());
                Console.Write("Entrer le nombre de lignes: ");
                float nbLines = float.Parse(Console.ReadLine());
                Console.WriteLine("Pour choisir le motif * tapez 1 et pour choisir le motif ♥ tape 2");
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.KeyChar != '1' && key.KeyChar != '2')
                    return;
                bool isLinesPair = nbLines % 2 == 0;
                float linesMiddle = nbLines / 2;
                for (int i = 0; i < nbLines; ++i) {
                    for (int j = 0; j < nbColumns; ++j) {
                        if (j == 0 || i == 0 || i == (isLinesPair ? linesMiddle - 1 : linesMiddle - 0.5) || i == nbLines - 1)
                            Console.Write(key.KeyChar == '1' ? "*" : "♥");
                    }
                    Console.Write('\n');
                }
            } catch (Exception ex) {
                Console.WriteLine("Error");
            }
        }
    }
}