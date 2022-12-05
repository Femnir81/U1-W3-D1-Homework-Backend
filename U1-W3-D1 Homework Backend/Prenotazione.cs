using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace U1_W3_D1_Homework_Backend
{
    public class Prenotazione
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Sala { get; set; }
        public bool BigliettoRidotto { get; set; }

        public static List<Prenotazione> ListaPrenotazione { get; set;} = new List<Prenotazione>();
}
}