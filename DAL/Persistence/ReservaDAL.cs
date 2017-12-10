using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Model;
using System.Data.SqlClient;

namespace DAL.Persistence
{
    public class ReservaDAL : Connection
    {
        public void Record(Reserva c)
        {
            try
            {

                //Chama o método que abre a conexão
                OpenConnection();

                //Passa para o objeto Cmd, o insert recebendo valores de variaveis
                Cmd = new SqlCommand("INSERT INTO tb_reserva (data_agendamento, hora_inicial, hora_final, id_lazer, cadastrado_por, id_apartamento) " +
                    "values (@v1, @v2, @v3, @v4, @v5, @v6)", Con);

                //Atribuindo valores as variaveis do insert
                Cmd.Parameters.AddWithValue("@V1", c.Data_agendamento);
                Cmd.Parameters.AddWithValue("@V2", c.Hora_inicial);
                Cmd.Parameters.AddWithValue("@v3", c.Hora_final);
                Cmd.Parameters.AddWithValue("@V4", c.Id_lazer);
                Cmd.Parameters.AddWithValue("@V5", c.cadastrado_por);
                Cmd.Parameters.AddWithValue("@V6", c.id_apartamento);

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

        public void Update(Reserva c)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("UPDATE tb_reserva SET  (data_agendamento=@v1, hora_inicial=@v2, hora_final=@v3, id_lazer=@v4, cadastrado_por=@v5, id_apartamento=@v6", Con);

                //Atribuindo valores as variaveis do insert
                Cmd.Parameters.AddWithValue("@V1", c.Data_agendamento);
                Cmd.Parameters.AddWithValue("@V2", c.Hora_inicial);
                Cmd.Parameters.AddWithValue("@v3", c.Hora_final);
                Cmd.Parameters.AddWithValue("@V4", c.Id_lazer);
                Cmd.Parameters.AddWithValue("@V5", c.cadastrado_por);
                Cmd.Parameters.AddWithValue("@V4", c.id_apartamento);

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
                Cmd = new SqlCommand("DELETE FROM tb_reserva where id=@v1", Con);
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

        public Reserva FindForCode(DateTime data_agendamento, DateTime hora_inicial, DateTime hora_final, int id_lazer)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("SELECT count(*) FROM tb_reserva where data_agendamento =@v1 and id_lazer=@v4 and hora_inicial >=@v2 and hora_inicial <=@v3 and hora_final >= @v2 and hora_final<=@v3", Con);
                

                Cmd.Parameters.AddWithValue("@v1", data_agendamento);
                Cmd.Parameters.AddWithValue("@v2", hora_inicial);
                Cmd.Parameters.AddWithValue("@v3", hora_final);
                Cmd.Parameters.AddWithValue("@v4", id_lazer);


                Int32 Dr = (Int32) Cmd.ExecuteScalar();
                Reserva c = null; //Criando um espaço na memória

                c = new Reserva();
                c.verifica = Dr;    
                
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

        public List<Reserva> Listar()
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("SELECT * FROM tb_reserva", Con);
                Dr = Cmd.ExecuteReader();

                List<Reserva> lista = new List<Reserva>();

                while (Dr.Read())
                {
                    Reserva c = new Reserva();
                    c = new Reserva();
                    c.Id = Convert.ToInt32(Dr["Id"]);
                    c.Data_agendamento = Convert.ToDateTime(Dr["data_agendamento"]);
                    c.Hora_inicial = Convert.ToDateTime(Dr["hora_inicial"]);
                    c.Hora_final = Convert.ToDateTime(Dr["hora_final"]);
                    c.Data_cadastro = Convert.ToDateTime(Dr["data_cadastro"]);
                    c.Id_lazer = Convert.ToInt32(Dr["id_lazer"]);
                    c.cadastrado_por = Convert.ToInt32(Dr["cadastrado_por"]);
                    c.id_apartamento = Convert.ToInt32(Dr["id_apartamento"]);

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
