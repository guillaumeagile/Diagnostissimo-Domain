using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace Doctissimo.Domain.Regles {
    public class Courriel : Doctissimo.Domain.Model.Courriel {
        public string Sujet { get; set; }

        public Courriel () {
            Sujet = "non déterminé";
        }

       

    }
}