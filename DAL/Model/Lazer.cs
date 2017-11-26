using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Model
{
    public class Lazer
    {
        public int Id { get; set; }
        public String Tipo_Lazer { get; set; }
        public String Local { get; set; }
        public String Observacao { get; set; }
        public DateTime Data_cadastro { get; set; }
        public int Cadastrado_por { get; set; }
    }
}
