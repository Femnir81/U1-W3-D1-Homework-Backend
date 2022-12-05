using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace U1_W3_D1_Homework_Backend
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BottonePrenotazione_Click(object sender, EventArgs e)
        {
            string nome = NomeInput.Text;
            string cognome = CognomeInput.Text;
            string salaScelta = MenuSala.SelectedValue;
            Prenotazione prenotazioneCliente= new Prenotazione();
            prenotazioneCliente.Nome = nome;
            prenotazioneCliente.Cognome = cognome;
            prenotazioneCliente.Sala = salaScelta;
            prenotazioneCliente.BigliettoRidotto = BigliettoRidotto.Checked;
            Prenotazione.ListaPrenotazione.Add(prenotazioneCliente);
            NomeInput.Text = "";
            CognomeInput.Text = "";
            BigliettoRidotto.Checked= false;   
            BigliettiVenduti();
        }

        public void BigliettiVenduti()
        {
            int countNord = 0;
            int countEst = 0;
            int countSud = 0;
            int countRidottiNord = 0;
            int countRidottiEst = 0;
            int countRidottiSud = 0;

            foreach (Prenotazione item in Prenotazione.ListaPrenotazione)
            {
                if (item.Sala == "SALA NORD")
                {
                    countNord++;
                }
                if (item.Sala == "SALA NORD" && item.BigliettoRidotto == true)
                {
                    countRidottiNord++;
                }
            }
            SalaNord.Text = $"Biglietti venduti SALA NORD: {countNord}, di cui {countRidottiNord} ridotti.";

            foreach (Prenotazione item in Prenotazione.ListaPrenotazione)
            {
                if (item.Sala == "SALA EST")
                {
                    countEst++;
                }
                if (item.Sala == "SALA EST" && item.BigliettoRidotto == true)
                {
                    countRidottiEst++;
                }
            }
            SalaEst.Text = $"Biglietti venduti SALA EST: {countEst}, di cui {countRidottiEst} ridotti.";

            foreach (Prenotazione item in Prenotazione.ListaPrenotazione)
            {
                if (item.Sala == "SALA SUD")
                {
                    countSud++;
                }
                if (item.Sala == "SALA SUD" && item.BigliettoRidotto == true)
                {
                    countRidottiSud++;
                }
            }
            SalaSud.Text = $"Biglietti venduti SALA SUD: {countSud}, di cui {countRidottiSud} ridotti.";
        }
    }
}