using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DAL.Persistence
{
    public class Connection
    {
        //Atributes
        protected SqlConnection Con;
        protected SqlCommand Cmd;
        protected SqlDataReader Dr;

        //Método p/ abrir conexão
        protected void OpenConnection()
        {
            try
            {
                Con = new SqlConnection("Data Source=localhost;Initial Catalog=condominio_pim;Integrated Security=True"); //Connection String
                Con.Open();
            }
            catch(Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        //Método p/ fechar conexão
        protected void CloseConnection()
        {
            try
            {
                Con.Close();
            }
            catch(Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


    }
}
