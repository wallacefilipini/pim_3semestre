using System;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoPim
{
    public class Condominio
    {
        private int id;
        private String nome_condominio;
        private String cep;
        private String endereco;
        private String bairro;
        private String cidade;
        private String estado;
        private int numero;
        private String complemento;
        private DateTime data_cadastro;
        private int cadastrado_por;
        private String Observacao;


        public void setId(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return id;
        }

        public void setNome(String nome_condominio)
        {
            this.nome_condominio = nome_condominio;
        }
        public String getNome()
        {
            return nome_condominio;
        }

        public void setCep(String cep)
        {
            this.cep = cep;
        }
        public String getCep()
        {
            return cep;
        }

        public void setEndereco(String endereco)
        {
            this.endereco = endereco;
        }
        public String getEndereco()
        {
            return endereco;
        }

        public void setBairro(String bairro)
        {
            this.bairro = bairro;
        }
        public String getBairro()
        {
            return bairro;
        }

        public void setCidade(String cidade)
        {
            this.cidade = cidade;
        }
        public String getCidade()
        {
            return cidade;
        }

        public void setEstado(String estado)
        {
            this.estado = estado;
        }
        public String getEstado()
        {
            return estado;
        }

        public void setNumero(int numero)
        {
            this.numero = numero;
        }
        public int getNumero()
        {
            return numero;
        }

        public void setComplemento(String complemento)
        {
            this.complemento = complemento;
        }
        public String getComplemento()
        {
            return complemento;
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
        public int getCadastradoPor()
        {
            return cadastrado_por;
        }

        public void setObservacao(String Observacao)
        {
            this.Observacao = Observacao;
        }
        public String getObservacao()
        {
            return Observacao;
        }

        


        //Método que faz um select
        public Object ListarRegistros()
        {
            SqlConnection conexao_banco = new SqlConnection();
            conexao_banco.ConnectionString = @"Data Source=WALLACE-PC;" + "Initial Catalog=condominio_pim;" + "Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao_banco;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " SELECT id AS Codigo, nome_condominio as [Condomínio], endereco As [Endereço], numero As Número" +
                                ", complemento As Complemento, cep As Cep,  bairro As Bairro, cidade As Cidade, estado As Estado, observacao As Observação, data_cadastro as [Cadastrado Em] from [tb_condominio]";

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
            cmd.CommandText = " INSERT INTO [tb_condominio] " +
                        " (nome_condominio, cep, endereco, numero, complemento, cidade, estado, observacao, bairro, cadastrado_por) " +
                        " VALUES ('" + nome_condominio + "', '" + cep + "', '" + endereco + "', '" + numero + "', " +
                        "'" + complemento + "', '" + cidade + "', '" + estado + "', '" + Observacao + "', '" + bairro + "', '" + cadastrado_por + "')";

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
            cmd.CommandText = "DELETE FROM [tb_condominio] WHERE id = " + id;

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
            cmd.CommandText = "UPDATE [tb_condominio] set nome_condominio = '" + nome_condominio + "', cep = '" + cep + "', endereco = '" + endereco + "'," +
                "numero = '" + numero + "', complemento = '" + complemento + "', cidade = '" + cidade + "', estado = '" + estado + "', observacao = '" + Observacao + "'," +
                "bairro = '" + bairro + "' WHERE id = " + id;

            conexao_banco.Open();
            int qtdeLinhas = cmd.ExecuteNonQuery();
            conexao_banco.Close();
            return qtdeLinhas;
        }


    }
}