namespace Test101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string currentUser = null;
            string input = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Sveiki atvykę į protmūsį!");
                Console.WriteLine();
                if (currentUser == null)
                {

                    Console.WriteLine("Pasirinkite:");
                    Console.WriteLine("1. Prisijungti");
                    Console.WriteLine("2. Results");

                    input = Console.ReadLine();

                    switch (input)
                    {
                        case "1":
                            //prisijungimas
                            Login(ref currentUser);
                            break;
                        case "2":
                            Play();
                            break;
                        default:
                            Console.WriteLine("Neteisingas pasirinkimas, bandykite dar kartą");
                            break;

                    }
                }

            } while (input != "exit");


        }
        static void Login(ref string user)
        {
            Console.Write("Įveskite savo vardą ir pavardę: ");
            user = Console.ReadLine();
        }
        static void Play()
        {
            List<string> questions = new List<string> { "Žalgirio komandos spalva?", "2+2?" };
            List<string> answer = new List<string> { "žalia", "4" };

            for (int i = 0; i < questions.Count; i++)
            {
                Console.Clear();
                Console.WriteLine(questions[i]);
                string input = Console.ReadLine();
                if (input == answer[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Teisingai");
                    Console.ResetColor();
                    //taip teisingai pridedam taškus 
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Neteisingai");
                    Console.ResetColor();
                    //neteisingai nepridedam taškų
                }
                Console.WriteLine("Paspausk bet ką kad testum");
                Console.ReadKey();
            }
        }
    }
}
