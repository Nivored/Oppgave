using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace OppgaveTerje
{
    internal class Verksted
    {
        public string? Bedriftsnavn { get; set; }
        public string? Adresse { get; set; }
        public string? Postnummer { get; set; }
        public string? Poststed { get; set; }
        public string? Godkjenningstyper { get; set; }
        public int Organisasjonsnummer { get; set; }
        public int Godkjenningsnummer { get; set; }
    }
}

