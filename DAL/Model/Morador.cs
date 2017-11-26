using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Model
{
    public class Morador
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public DateTime Data_nascimento { get; set; }
        public String Sexo { get; set; }
        public String Cpf { get; set; }
        public String Rg { get; set; }
        public int Id_Apartamento { get; set; }
        public DateTime Data_cadastro { get; set; }
        public int Cadastrado_por { get; set; }
    }
}
