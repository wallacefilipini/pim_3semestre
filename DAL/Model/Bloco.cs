﻿using System;

namespace DAL.Model
{
    public class Bloco
    {
        public int Id { get; set; }
        public String Descricao { get; set; }
        public int Qtd_andar { get; set; }
        public int Qtd_apartamento { get; set; }
        public DateTime Data_cadastro { get; set; }
        public int Cadastrado_por { get; set; }
        public int Id_condominio { get; set; }
    }
}
