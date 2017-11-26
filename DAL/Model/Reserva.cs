using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Model
{
    public class Reserva
    {
        public int Id { get; set; }
        public DateTime Data_agendamento { get; set; }
        public DateTime Hora_inicial { get; set; }
        public DateTime Hora_final { get; set; }
        public DateTime Data_cadastro { get; set; }
        public int Id_lazer { get; set; }
        public int cadastrado_por { get; set; }
        public int id_apartamento { get; set; }
    }
}
