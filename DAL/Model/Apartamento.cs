using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Model
{
    public class Apartamento
    {
        public int Id { get; set; }
        public int Numero_apto { get; set; }
        public int Andar_apto { get; set; }
        public int Numero_garagem { get; set; }
        public DateTime Data_cadastro { get; set; }
        public int Cadastrado_por { get; set; }
        public int Id_Bloco { get; set; }
    }
}
