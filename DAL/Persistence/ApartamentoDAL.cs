using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Model;
using System.Data.SqlClient;

namespace DAL.Persistence
{
    class ApartamentoDAL : Connection
    {
        public void Record(Apartamento c)
        {
            try
            {

                //Chama o método que abre a conexão
                OpenConnection();

                //Passa para o objeto Cmd, o insert recebendo valores de variaveis
                Cmd = new SqlCommand("INSERT INTO tb_apartamento (numero_apto, andar_apto, numero_garagem, cadastrado_por, id_bloco) " +
                    "values (@v1, @v2, @v3, @v4, @v5)", Con);

                //Atribuindo valores as variaveis do insert
                Cmd.Parameters.AddWithValue("@V1", c.Numero_apto);
                Cmd.Parameters.AddWithValue("@V2", c.Andar_apto);
                Cmd.Parameters.AddWithValue("@v3", c.Numero_garagem);
                Cmd.Parameters.AddWithValue("@V4", c.Cadastrado_por);
                Cmd.Parameters.AddWithValue("@V5", c.Id_Bloco);

                //Executando o método
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao gravar apartamento!:" + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Upadte(Apartamento c)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("UPDATE tb_apartamento SET  (numero_apto=@v1, andar_apto=@v2, numero_garagem=@v3, cadastrado_por=@v4, id_bloco=@v5  where id=@v6", Con);

                //Atribuindo valores as variaveis do insert
                Cmd.Parameters.AddWithValue("@V1", c.Numero_apto);
                Cmd.Parameters.AddWithValue("@V2", c.Andar_apto);
                Cmd.Parameters.AddWithValue("@v3", c.Numero_garagem);
                Cmd.Parameters.AddWithValue("@V4", c.Cadastrado_por);
                Cmd.Parameters.AddWithValue("@V5", c.Id_Bloco);
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
                Cmd = new SqlCommand("DELETE FROM tb_apartamento where id=@v1", Con);
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

        public Apartamento FindForCode(int Id)
        {
            try
            {
                Cmd = new SqlCommand("SELECT * FROM tb_apartamento where id=@v1");
                Cmd.Parameters.AddWithValue("@v1", Id);

                Apartamento c = null; //Criando um espaço na memória

                if (Dr.Read())
                {
                    c = new Apartamento();
                    c.Id = Convert.ToInt32(Dr["Id"]);
                    c.Numero_apto = Convert.ToInt32(Dr["numero_apto"]);
                    c.Andar_apto = Convert.ToInt32(Dr["andar_apto"]);
                    c.Numero_apto = Convert.ToInt32(Dr["numero_apto"]);
                    c.Data_cadastro = Convert.ToDateTime(Dr["data_cadastro"]);
                    c.Cadastrado_por = Convert.ToInt32(Dr["cadastrado_por"]);
                    c.Id_Bloco = Convert.ToInt32(Dr["id_bloco"]);
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

        public List<Apartamento> Listar()
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("SELECT * FROM tb_apartamento", Con);
                Dr = Cmd.ExecuteReader();

                List<Apartamento> lista = new List<Apartamento>();

                while (Dr.Read())
                {
                    Apartamento c = new Apartamento();
                    c = new Apartamento();
                    c.Id = Convert.ToInt32(Dr["Id"]);
                    c.Numero_apto = Convert.ToInt32(Dr["numero_apto"]);
                    c.Andar_apto = Convert.ToInt32(Dr["andar_apto"]);
                    c.Numero_apto = Convert.ToInt32(Dr["numero_apto"]);
                    c.Data_cadastro = Convert.ToDateTime(Dr["data_cadastro"]);
                    c.Cadastrado_por = Convert.ToInt32(Dr["cadastrado_por"]);
                    c.Id_Bloco = Convert.ToInt32(Dr["id_bloco"]);

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
