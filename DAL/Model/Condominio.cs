using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Model
{
    public class Condominio
    {
        public int Id { get; set; }
        public String Nome_condominio { get; set; }
        public String Cep { get; set; }
        public String Endereco { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }
        public int Numero { get; set; }
        public String Complemento { get; set; }
        public DateTime Data_cadastro { get; set; }
        public int Cadastrado_por { get; set; }
        public String Observacao { get; set; }

    }
}
