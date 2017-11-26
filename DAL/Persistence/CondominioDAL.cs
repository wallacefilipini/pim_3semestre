using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DAL.Model;

namespace DAL.Persistence
{
    //Herança da classe Connection
    public class CondominioDAL : Connection
    {
        
        public void Record(Condominio c)
        {
            try
            {

                //Chama o método que abre a conexão
                OpenConnection();

                //Passa para o objeto Cmd, o insert recebendo valores de variaveis
                Cmd = new SqlCommand("INSERT INTO tb_condominio (nome_condominio, cep, endereco, bairro, cidade, estado, numero, complemento, observacao, cadastrado_por) " +
                    "values (@v1, @v2, @v3, @v4, @v5, @v6, @v7, @v8, @v9, @v10)", Con);

                //Atribuindo valores as variaveis do insert
                Cmd.Parameters.AddWithValue("@V1", c.Nome_condominio);
                Cmd.Parameters.AddWithValue("@V2", c.Cep);
                Cmd.Parameters.AddWithValue("@v3", c.Endereco);
                Cmd.Parameters.AddWithValue("@V4", c.Bairro);
                Cmd.Parameters.AddWithValue("@V5", c.Cidade);
                Cmd.Parameters.AddWithValue("@V6", c.Estado);
                Cmd.Parameters.AddWithValue("@V7", c.Numero);
                Cmd.Parameters.AddWithValue("@V8", c.Complemento);
                Cmd.Parameters.AddWithValue("@V9", c.Observacao);
                Cmd.Parameters.AddWithValue("@V10", c.Cadastrado_por);

                //Executando o método
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao gravar o registro!:" + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Update(Condominio c)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand ("UPDATE tb_condominio SET nome_condominio=@v1, cep=@v2, endereco=@v3, bairro=@v4, cidade=@v5, estado=@v6, numero=@v7, complemento=@v8, observacao=@v9 where id=@v11", Con);

                //Atribuindo valores as variaveis do insert
                Cmd.Parameters.AddWithValue("@V1", c.Nome_condominio);
                Cmd.Parameters.AddWithValue("@V2", c.Cep);
                Cmd.Parameters.AddWithValue("@v3", c.Endereco);
                Cmd.Parameters.AddWithValue("@V4", c.Bairro);
                Cmd.Parameters.AddWithValue("@V5", c.Cidade);
                Cmd.Parameters.AddWithValue("@V6", c.Estado);
                Cmd.Parameters.AddWithValue("@V7", c.Numero);
                Cmd.Parameters.AddWithValue("@V8", c.Complemento);
                Cmd.Parameters.AddWithValue("@V9", c.Observacao);
                //Cmd.Parameters.AddWithValue("@V10", c.Cadastrado_por);
                Cmd.Parameters.AddWithValue("@V11", c.Id);

                Cmd.ExecuteNonQuery();

            }
            //catch (Exception ex)
            //{

                //throw new Exception("Erro ao atualizar o registro!" + ex.Message);
            //}
            finally
            {
                CloseConnection();
            }
        }
            
        public void Delete(int Id)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("DELETE FROM tb_condominio where id=@v1", Con);
                Cmd.Parameters.AddWithValue("@v1", Id);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao excluir o registro!" + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public Condominio FindForCode (int Id)
        {
            try
            {
                Cmd = new SqlCommand("SELECT * FROM tb_condominio where id=@v1");
                Cmd.Parameters.AddWithValue("@v1", Id);
                Dr = Cmd.ExecuteReader();
                Condominio c = null; //Criando um espaço na memória
                
                if (Dr.Read())
                {
                    c = new Condominio();
                    c.Id                = Convert.ToInt32(Dr["Id"]);
                    c.Nome_condominio   = Convert.ToString(Dr["nome_condominio"]);
                    c.Cep               = Convert.ToString(Dr["nome_condominio"]);
                    c.Endereco          = Convert.ToString(Dr["endereco"]);
                    c.Bairro            = Convert.ToString(Dr["bairro"]);
                    c.Cidade            = Convert.ToString(Dr["cidade"]);
                    c.Estado            = Convert.ToString(Dr["estado"]);
                    c.Numero            = Convert.ToInt32(Dr["numero"]);
                    c.Complemento       = Convert.ToString(Dr["complemento"]);
                    c.Observacao        = Convert.ToString(Dr["observacao"]);
                    c.Cadastrado_por    = Convert.ToInt32(Dr["cadastrado_por"]);
                }
                return c;

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possível encontrar o registro" + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public List<Condominio> Listar()
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("SELECT * FROM tb_condominio", Con);
                Dr = Cmd.ExecuteReader();

                List<Condominio> lista = new List<Condominio>();

                while (Dr.Read())
                {
                    Condominio c = new Condominio();
                    c.Id                = Convert.ToInt32(Dr["Id"]);
                    c.Nome_condominio   = Convert.ToString(Dr["nome_condominio"]);
                    c.Cep               = Convert.ToString(Dr["cep"]);
                    c.Endereco          = Convert.ToString(Dr["endereco"]);
                    c.Bairro            = Convert.ToString(Dr["bairro"]);
                    c.Cidade            = Convert.ToString(Dr["cidade"]);
                    c.Estado            = Convert.ToString(Dr["estado"]);
                    c.Numero            = Convert.ToInt32(Dr["numero"]);
                    c.Complemento       = Convert.ToString(Dr["complemento"]);
                    c.Observacao        = Convert.ToString(Dr["observacao"]);
                    //c.Cadastrado_por    = Convert.ToInt32(Dr["cadastrado_por"]);

                    lista.Add(c);

                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível listar os registros!" + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
