using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Model;
using System.Data.SqlClient;

namespace DAL.Persistence
{
    class UsuarioDAL : Connection
    {
       
        public Usuario FindForCode(int Id)
        {
            try
            {
                Cmd = new SqlCommand("SELECT * FROM tb_usuario where id=@v1");
                Cmd.Parameters.AddWithValue("@v1", Id);

                Usuario c = null; //Criando um espaço na memória

                if (Dr.Read())
                {
                    c = new Usuario();
                    c.User_id = Convert.ToInt32(Dr["user_id"]);
                    c.Name = Convert.ToString(Dr["name"]);
                    c.Email = Convert.ToString(Dr["email"]);
                    c.Password = Convert.ToString(Dr["password"]);

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
    }
}
