namespace ChangerLaCasse
{
    public class Program
    {
        public static async Task Main(string[] args) {
            try {
                string input = Console.ReadLine();
                char[] res = new char[input.Length]; 
                for (int i = 0; i < input.Length; ++i) {
                    if (Char.IsLetter(input[i]))
                        res[i] = Char.IsLower(input[i]) ? Char.ToUpper(input[i]) : Char.ToLower(input[i]);
                    else if (input[i] == ' ')
                        res[i] = '#';
                }
                Console.WriteLine(res);
            } catch (Exception ex) {
                Console.WriteLine("Error");
            }
        }
    }
}