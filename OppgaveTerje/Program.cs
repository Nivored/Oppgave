using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using OppgaveTerje;


namespace OppgaveTerje
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            MenuOptions();
        }

        static void MenuOptions()
        {
            Console.WriteLine("1: Søk på postnummer");
            Console.WriteLine("2: Søk på Godkjennings Typer");
            Console.WriteLine("0: Avslutt");
            MenuInputs();
        }

        static void MenuInputs()
        {
            switch (Console.ReadLine())
            {
                case "1":
                    listPostNummer();
                    break;
                case "2":
                    listGodkjenningsTyper();
                    break;
                case "0":
                    break;
            }
        }

        static void listPostNummer()
        {
            var verksted = new SearchClass();
            while (true)
            {
                Console.WriteLine("Tast ett Postnummer");
                verksted.MatchingPostNummer(Console.ReadLine());

            }
        }

        static void listGodkjenningsTyper()
        {
            var verksted = new SearchClass();
            while (true)
            {
                Console.WriteLine("Tast Godkjennings Typer");
                verksted.MatchingGodkjenningsTyper(Console.ReadLine().ToUpper());
            }
        }
    }
}
