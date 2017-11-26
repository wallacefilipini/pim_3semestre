using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DAL.Model;


namespace DAL.Persistence
{
    public class BlocoDAL : Connection
    {
        public void Record(Bloco c)
        {
            try
            {

                //Chama o método que abre a conexão
                OpenConnection();

                //Passa para o objeto Cmd, o insert recebendo valores de variaveis
                Cmd = new SqlCommand("INSERT INTO tb_bloco (descricao, qtd_andar, qtd_apartamento, cadastrado_por, id_condominio) " +
                    "values (@v1, @v2, @v3, @v4, @v5)", Con);

                //Atribuindo valores as variaveis do insert
                Cmd.Parameters.AddWithValue("@V1", c.Descricao);
                Cmd.Parameters.AddWithValue("@V2", c.Qtd_andar);
                Cmd.Parameters.AddWithValue("@v3", c.Qtd_apartamento);
                Cmd.Parameters.AddWithValue("@V4", c.Cadastrado_por);
                Cmd.Parameters.AddWithValue("@V5", c.Id_condominio);

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

        public void Update(Bloco c)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("UPDATE tb_bloco SET  descricao=@v1, qtd_andar=@v2, qtd_apartamento=@v3, cadastrado_por=@v4, id_condominio=@v5  where id=@v6", Con);

                //Atribuindo valores as variaveis do insert
                Cmd.Parameters.AddWithValue("@V1", c.Descricao);
                Cmd.Parameters.AddWithValue("@V2", c.Qtd_andar);
                Cmd.Parameters.AddWithValue("@v3", c.Qtd_apartamento);
                Cmd.Parameters.AddWithValue("@V4", c.Cadastrado_por);
                Cmd.Parameters.AddWithValue("@V5", c.Id_condominio);
                Cmd.Parameters.AddWithValue("@V6", c.Id);

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
                Cmd = new SqlCommand("DELETE FROM tb_bloco where id=@v1", Con);
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

        public Bloco FindForCode(int Id)
        {
            try
            {
                Cmd = new SqlCommand("SELECT * FROM tb_bloco where id=@v1");
                Cmd.Parameters.AddWithValue("@v1", Id);
                Dr = Cmd.ExecuteReader();
                Bloco c = null; //Criando um espaço na memória

                if (Dr.Read())
                {
                    c = new Bloco();
                    c.Id = Convert.ToInt32(Dr["Id"]);
                    c.Descricao = Convert.ToString(Dr["descricao"]);
                    c.Qtd_andar = Convert.ToInt32(Dr["qtd_andar"]);
                    c.Qtd_apartamento = Convert.ToInt32(Dr["qtd_apartamento"]);
                    c.Data_cadastro = Convert.ToDateTime(Dr["data_cadastro"]);
                    c.Cadastrado_por = Convert.ToInt32(Dr["cadastrado_por"]);
                    c.Id_condominio = Convert.ToInt32(Dr["id_condominio"]);
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

        public List<Bloco> Listar()
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("SELECT * FROM tb_bloco", Con);
                Dr = Cmd.ExecuteReader();

                List<Bloco> lista = new List<Bloco>();

                while (Dr.Read())
                {
                    Bloco c = new Bloco();
                    c = new Bloco();
                    c.Id = Convert.ToInt32(Dr["Id"]);
                    c.Descricao = Convert.ToString(Dr["descricao"]);
                    c.Qtd_andar = Convert.ToInt32(Dr["qtd_andar"]);
                    c.Qtd_apartamento = Convert.ToInt32(Dr["qtd_apartamento"]);
                    c.Data_cadastro = Convert.ToDateTime(Dr["data_cadastro"]);
                    //c.Cadastrado_por = Convert.ToInt32(Dr["cadastrado_por"]);
                    c.Id_condominio = Convert.ToInt32(Dr["id_condominio"]);

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
