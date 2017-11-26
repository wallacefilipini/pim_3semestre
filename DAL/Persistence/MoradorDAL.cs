using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Model;
using System.Data.SqlClient;

namespace DAL.Persistence
{
    public class MoradorDAL : Connection
    {
        public void Record(Morador c)
        {
            try
            {

                //Chama o método que abre a conexão
                OpenConnection();

                //Passa para o objeto Cmd, o insert recebendo valores de variaveis
                Cmd = new SqlCommand("INSERT INTO tb_morador (nome, data_nascimento, sexo, cpf, rg, id_apartamento, cadastrado_por) " +
                    "values (@v1, @v2, @v3, @v4, @v5, @v6, @v7)", Con);

                //Atribuindo valores as variaveis do insert
                Cmd.Parameters.AddWithValue("@V1", c.Nome);
                Cmd.Parameters.AddWithValue("@V2", c.Data_nascimento);
                Cmd.Parameters.AddWithValue("@v3", c.Sexo);
                Cmd.Parameters.AddWithValue("@V4", c.Cpf);
                Cmd.Parameters.AddWithValue("@V5", c.Rg);
                Cmd.Parameters.AddWithValue("@V6", c.Id_Apartamento);
                Cmd.Parameters.AddWithValue("@V7", c.Cadastrado_por);

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

        public void Update(Morador c)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("UPDATE tb_morador SET  nome=@v1, data_nascimento=@v2, sexo=@v3, cpf=@v4, rg=@v5, id_apartamento=@v6, cadastrado_por=@v7 where id =@v8", Con);

                //Atribuindo valores as variaveis do insert
                Cmd.Parameters.AddWithValue("@V1", c.Nome);
                Cmd.Parameters.AddWithValue("@V2", c.Data_nascimento);
                Cmd.Parameters.AddWithValue("@v3", c.Sexo);
                Cmd.Parameters.AddWithValue("@V4", c.Cpf);
                Cmd.Parameters.AddWithValue("@V5", c.Rg);
                Cmd.Parameters.AddWithValue("@V6", c.Id_Apartamento);
                Cmd.Parameters.AddWithValue("@V7", c.Cadastrado_por);
                Cmd.Parameters.AddWithValue("@V8", c.Id);

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
                Cmd = new SqlCommand("DELETE FROM tb_morador where id=@v1", Con);
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

        public Morador FindForCode(int Id)
        {
            try
            {
                Cmd = new SqlCommand("SELECT * FROM tb_morador where id=@v1");
                Cmd.Parameters.AddWithValue("@v1", Id);
                Dr = Cmd.ExecuteReader();
                Morador c = null; //Criando um espaço na memória

                if (Dr.Read())
                {
                    c = new Morador();
                    c.Id = Convert.ToInt32(Dr["Id"]);
                    c.Nome = Convert.ToString(Dr["nome"]);
                    c.Data_nascimento = Convert.ToDateTime(Dr["data_nascimento"]);
                    c.Sexo = Convert.ToString(Dr["sexo"]);
                    c.Cpf = Convert.ToString(Dr["cpf"]);
                    c.Rg = Convert.ToString(Dr["rg"]);
                    c.Id_Apartamento = Convert.ToInt32(Dr["id_apartamento"]);
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

        public List<Morador> Listar()
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("SELECT * FROM tb_morador", Con);
                Dr = Cmd.ExecuteReader();

                List<Morador> lista = new List<Morador>();

                while (Dr.Read())
                {
                    Morador c = new Morador();
                    c = new Morador();
                    c.Id = Convert.ToInt32(Dr["Id"]);
                    c.Nome = Convert.ToString(Dr["nome"]);
                    c.Data_nascimento = Convert.ToDateTime(Dr["data_nascimento"]);
                    c.Sexo = Convert.ToString(Dr["sexo"]);
                    c.Cpf = Convert.ToString(Dr["cpf"]);
                    c.Rg = Convert.ToString(Dr["rg"]);
                    c.Id_Apartamento = Convert.ToInt32(Dr["id_apartamento"]);
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
