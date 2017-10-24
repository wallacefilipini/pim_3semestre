using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Model
{
    class Lazer
    {
        public int Id { get; set; }
        public String Tipo_Lazer { get; set; }
        public String Local { get; set; }
        public String Observacao { get; set; }
        public String Data_cadastro { get; set; }
        public String Cadastrado_por { get; set; }
    }
}
