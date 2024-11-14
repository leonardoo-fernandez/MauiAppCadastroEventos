using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppCadastroEventos.Models
{
    public class Evento
    {
        public string NomeEvento { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataTermino { get; set; }

        public int NumParticipantes { get; set; }

        public string LocalEvento   { get; set; }

        public double CustoParticipante { get; set; }

        public int TimeSpam
        {
            get => DataTermino.Subtract(DataInicio).Days;
        }

        public double CustoTotal
        {
            get
            {
                double total = NumParticipantes * CustoParticipante;
                
                return total;
            }
        }
    }
}
