using System;
using System.Data;
using System.Data.SqlClient;


namespace ProjetoPim
{
    class Bloco
    {
        private int id;
        private String descricao;
        private int qtd_andar;
        private int qtd_apartamento;
        private DateTime data_cadastro;
        private int cadastrado_por;
        private int id_condominio;

        public void setId(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return id;
        }

        public void setDescricao(String descricao)
        {
            this.descricao = descricao;
        }
        public String getDescricao()
        {
            return descricao;
        }

        public void setQtdAndar(int qtd_andar)
        {
            this.qtd_andar = qtd_andar;
        }
        public int getQtdAndar()
        {
            return qtd_andar;
        }

        public void setQtdApartamento(int qtd_apartamento)
        {
            this.qtd_apartamento = qtd_apartamento;
        }
        public int getQtdApartamento()
        {
            return qtd_apartamento;
        }

        public void setDataCadastro(DateTime data_cadastro)
        {
            this.data_cadastro = data_cadastro;
        }
        public DateTime getDataCadastro()
        {
            return data_cadastro;
        }

        public void setCadastradoPor(int cadastrado_por)
        {
            this.cadastrado_por = cadastrado_por;
        }
        public int getCadastroPor()
        {
            return cadastrado_por;
        }

        public void setIdCondominio(int id_condominio)
        {
            this.id_condominio = id_condominio;
        }
        public int getIdCondominio()
        {
            return id_condominio;
        }

        //Método que faz um select
        public Object ListarRegistros()
        {
            SqlConnection conexao_banco = new SqlConnection();
            conexao_banco.ConnectionString = @"Data Source=WALLACE-PC;" + "Initial Catalog=condominio_pim;" + "Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao_banco;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " SELECT id AS Codigo, descricao as [Bloco], qtd_andar as [Qtd Andares], qtd_apartamento as [Qtd Apartamentos]" +
                "data_cadastro as [Cadastrado Em] from [tb_condominio]";

            conexao_banco.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            conexao_banco.Close();
            return dt;


        }

        //Método que Inseri registro no banco
        public void InserirNoBanco()
        {
            SqlConnection conexao_banco = new SqlConnection();
            conexao_banco.ConnectionString = @"Data Source=WALLACE-PC;" + "Initial Catalog=condominio_pim;" + "Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao_banco;
            cmd.CommandText = " INSERT INTO [tb_bloco] " +
                        " (descricao, qtd_andar, qtd_apartamento, cadastrado_por, id_condominio) " +
                        " VALUES ('" + descricao + "', '" + qtd_andar + "', '" + qtd_apartamento + "', " +
                        "'" + cadastrado_por + "', '" + id_condominio + "')";

            conexao_banco.Open();
            cmd.ExecuteNonQuery();
            conexao_banco.Close();

        }

        //Método que exclui do banco
        public int ExcluirBanco(int id)
        {
            SqlConnection conexao_banco = new SqlConnection();
            conexao_banco.ConnectionString = @"Data Source=WALLACE-PC;" + "Initial Catalog=condominio_pim;" + "Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao_banco;
            cmd.CommandText = "DELETE FROM [tb_bloco] WHERE id = " + id;

            conexao_banco.Open();
            int qtdeLinhas = cmd.ExecuteNonQuery();
            conexao_banco.Close();
            return qtdeLinhas;
        }

        public int AtualizarRegistro(int id)
        {
            SqlConnection conexao_banco = new SqlConnection();
            conexao_banco.ConnectionString = @"Data Source=WALLACE-PC;" + "Initial Catalog=condominio_pim;" + "Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao_banco;
            cmd.CommandText = "UPDATE [tb_bloco] set descricao = '" + descricao + "', qtd_apartamento = '" + qtd_apartamento + "', " +
                "qtd_andar = '" + qtd_andar + "', id_condominio = '" + id_condominio + "' WHERE id = " + id;

            conexao_banco.Open();
            int qtdeLinhas = cmd.ExecuteNonQuery();
            conexao_banco.Close();
            return qtdeLinhas;
        }
    }
}
