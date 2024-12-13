using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace Form_sistema.Class
{
    internal class connection
    {
        public SqlConnection con;
        public SqlCommand command;
        public SqlDataReader reader;

        public String url { get; set; }
        public String procedure { get; set; }

        public connection() { }

        public connection(String url, String procedure)
        {
            this.url = url;
            this.procedure = procedure;
            this.open_connection();
        }

        public void open_connection()
        {
            con = new SqlConnection(url);
            con.Open();
            command = new SqlCommand(procedure, con);
            command.CommandType = CommandType.StoredProcedure;
        }

        public void close_connection()
        {
            con.Close();
        }

        public void DB()
        {
            string connectionString = "Data Source=DESKTOP-GJL2Q9B\\SQLDEVELOPER;Initial Catalog=dbGestion;Integrated Security=True";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "SELECT * FROM tbl_user";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            string columna1 = reader["userId"].ToString();
                            string columna2 = reader["username"].ToString();
                            string columna3 = reader["name"].ToString();
                            string columna4 = reader["last_name"].ToString(); 
                            string columna5 = reader["address"].ToString();
                            string columna6 = reader["date_of_entry"].ToString();
                            Console.WriteLine(columna1 + " : " + columna2 + " : " + columna3 + " : " +
                                columna4 + " : " + columna5 + " : " + columna6 + " : ");

                        }
                    }

                    con.Close();
                    Console.WriteLine("Conexion exitosa");
                 }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar con la base de datos: " + ex.Message);
            }
        }
    }
}
