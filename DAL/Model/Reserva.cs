using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Model
{
    class Reserva
    {
        public int Id { get; set; }
        public DateTime Data_agendamento { get; set; }
        public DateTime Hora_inicial { get; set; }
        public DateTime Hora_final { get; set; }
        public DateTime Data_cadastro { get; set; }
        public DateTime Id_lazer { get; set; }
    }
}
