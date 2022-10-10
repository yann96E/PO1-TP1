namespace Password
{
    public class Program
    {
        public static async Task Main(string[] args) {
            try {
                Console.WriteLine(Min(1, 3));
                Console.WriteLine(Max(0, 4));
                Console.WriteLine(Chiffre(0, 9));
                Console.WriteLine(GenerateNPassword(50));
            } catch (Exception ex) {
                Console.WriteLine("Error");
            }
        }
        
        static string Min(int début, int fin) {
            if (début < 0 || début > 26 || fin < 0 || fin > 26 || fin <= début)
                return "";
            return "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".Substring(début, (fin - début) + 1);
        }

        static string Max(int début, int fin)
        {
            if (début < 0 || début > 26 || fin < 0 || fin > 26 || fin <= début)
                return "";
            return "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".Substring(début + 26, (fin - début) + 1);
        }
        static string Chiffre(int début, int fin)
        {
            return "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".Substring(début + 52, (fin - début) + 1);
        }

        static char[] GenerateNPassword(int n)
        {
            string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] password = new char[n];
            Random aleatoire = new Random();
            for(int i = 0; i < n; i++)            
                password[i] = characters[aleatoire.Next(characters.Length)];
            return password;
        }
    }
}