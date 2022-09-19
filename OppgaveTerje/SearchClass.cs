using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OppgaveTerje
{
    internal class SearchClass
    {
        public List<Verksted> VerkstedList = new List<Verksted>();
        public SearchClass()
        {
            string fileName = "verkstedfil.json";
            string jsonString = File.ReadAllText(fileName);
            VerkstedList = JsonConvert.DeserializeObject<List<Verksted>>(jsonString);
        }

        public void DisplayAll()
        {
            //ikke i bruk enda
            if (VerkstedList != null)
            {
                
                foreach (var verksted in VerkstedList)
                {
                    Console.WriteLine($"{verksted.Bedriftsnavn}\n");
                    Console.WriteLine($"{verksted.Adresse}");
                    Console.WriteLine($"{verksted.Postnummer}");
                    Console.WriteLine($"{verksted.Poststed}");
                    Console.WriteLine($"{verksted.Godkjenningstyper}");
                    Console.WriteLine($"{verksted.Organisasjonsnummer}");
                    Console.WriteLine($"{verksted.Godkjenningsnummer}");
                }

                Console.WriteLine(VerkstedList.Count);

            }
        }

        public void MatchingPostNummer(string postnummer)
        {
            // søker på postnummer
            var query = from verksted in VerkstedList where verksted.Postnummer.StartsWith(postnummer) select verksted;

            foreach (var result in query)
            {
                Console.WriteLine($"{result.Bedriftsnavn}");
                Console.WriteLine($"{result.Adresse}");
                Console.WriteLine($"{result.Postnummer}");
                Console.WriteLine($"{result.Poststed}");
                Console.WriteLine($"{result.Godkjenningstyper}");
                Console.WriteLine($"{result.Organisasjonsnummer}");
                Console.WriteLine($"{result.Godkjenningsnummer}\n");
            }
        }

        public void MatchingGodkjenningsTyper(string godkjenningstyper)
        {
            //søker på godkjenningstyper
            var query = from verksted in VerkstedList where verksted.Godkjenningstyper.StartsWith(godkjenningstyper) select verksted;

            foreach (var result in query)
            {
                Console.WriteLine($"{result.Bedriftsnavn}");
                Console.WriteLine($"{result.Adresse}");
                Console.WriteLine($"{result.Postnummer}");
                Console.WriteLine($"{result.Poststed}");
                Console.WriteLine($"{result.Godkjenningstyper}");
                Console.WriteLine($"{result.Organisasjonsnummer}");
                Console.WriteLine($"{result.Godkjenningsnummer}\n");
            }
        }
    }
}
