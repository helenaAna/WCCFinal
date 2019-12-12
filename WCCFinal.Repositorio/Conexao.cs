using System;
using System.Data;
using System.Data.SqlClient;


namespace WCCFinal.Repositorio
{
    public class Conexao
    {
        private string StringConexao()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "DESKTOP-GAT13IM\\SQLEXPRESS";
            builder.UserID = "sa";
            builder.Password = "132";
            builder.InitialCatalog = "WCC";
           // builder.IntegratedSecurity = true;

            return builder.ConnectionString;           
        }

        public DataTable Consulta(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(StringConexao()))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = new SqlCommand(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    return (dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }          
        }

        public void Executar (string query)
        {
            try
            {
                using (SqlConnection connetion = 
                    new SqlConnection(StringConexao()))
                {
                    connetion.Open();
                    using (SqlCommand command = new SqlCommand(query, connetion))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
