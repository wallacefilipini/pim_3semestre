using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Model;
using System.Data.SqlClient;

namespace DAL.Persistence
{
    class LazerDAL : Connection
    {
        public void Record(Lazer c)
        {
            try
            {

                //Chama o método que abre a conexão
                OpenConnection();

                //Passa para o objeto Cmd, o insert recebendo valores de variaveis
                Cmd = new SqlCommand("INSERT INTO tb_lazer (tipo_lazer, local, observacao, cadastrado_por) " +
                    "values (@v1, @v2, @v3, @v4)", Con);

                //Atribuindo valores as variaveis do insert
                Cmd.Parameters.AddWithValue("@V1", c.Tipo_Lazer);
                Cmd.Parameters.AddWithValue("@V2", c.Local);
                Cmd.Parameters.AddWithValue("@v3", c.Observacao);
                Cmd.Parameters.AddWithValue("@V4", c.Cadastrado_por);

                //Executando o método
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao gravar registro!:" + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Update(Lazer c)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("UPDATE tb_lazer SET  (tipo_lazer=@v1, local=@v2, observacao=@v3, cadastrado_por=@v4", Con);

                //Atribuindo valores as variaveis do insert
                Cmd.Parameters.AddWithValue("@V1", c.Tipo_Lazer);
                Cmd.Parameters.AddWithValue("@V2", c.Local);
                Cmd.Parameters.AddWithValue("@v3", c.Observacao);
                Cmd.Parameters.AddWithValue("@V4", c.Cadastrado_por);

                Cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao atualizar o registro!" + ex.Message);
            }
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
                Cmd = new SqlCommand("DELETE FROM tb_lazer where id=@v1", Con);
                Cmd.Parameters.AddWithValue("@v1", Id);
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

        public Lazer FindForCode(int Id)
        {
            try
            {
                Cmd = new SqlCommand("SELECT * FROM tb_lazer where id=@v1");
                Cmd.Parameters.AddWithValue("@v1", Id);

                Lazer c = null; //Criando um espaço na memória

                if (Dr.Read())
                {
                    c = new Lazer();
                    c.Id = Convert.ToInt32(Dr["Id"]);
                    c.Tipo_Lazer = Convert.ToString(Dr["tipo_lazer"]);
                    c.Local = Convert.ToString(Dr["local"]);
                    c.Observacao = Convert.ToString(Dr["observacao"]);
                    c.Data_cadastro = Convert.ToDateTime(Dr["data_cadastro"]);
                    c.Cadastrado_por = Convert.ToInt32(Dr["cadastrado_por"]);

                }
                return c;

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possível encontrar o cliente" + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public List<Lazer> Listar()
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("SELECT * FROM tb_lazer", Con);
                Dr = Cmd.ExecuteReader();

                List<Lazer> lista = new List<Lazer>();

                while (Dr.Read())
                {
                    Lazer c = new Lazer();
                    c = new Lazer();
                    c.Id = Convert.ToInt32(Dr["Id"]);
                    c.Tipo_Lazer = Convert.ToString(Dr["tipo_lazer"]);
                    c.Local = Convert.ToString(Dr["local"]);
                    c.Observacao = Convert.ToString(Dr["observacao"]);
                    c.Data_cadastro = Convert.ToDateTime(Dr["data_cadastro"]);
                    c.Cadastrado_por = Convert.ToInt32(Dr["cadastrado_por"]);

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
