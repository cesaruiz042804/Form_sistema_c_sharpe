using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Data;
using OxyPlot;

namespace Form_sistema.Class
{
    internal class class_count : connection
    {
        public String t_user { get; set; }
        public String t_employee { get; set; }
        public String t_payroll { get; set; }
        public String t_payroll_detail { get; set; }


        public class_count() { }

        public class_count(String url, String procedure) : base(url, procedure)
        {
        }

        public class_count(String t_user, String t_employee, String t_payroll, String t_payroll_detail) 
        {
            this.t_user = t_user;
            this.t_employee = t_employee;
            this.t_payroll = t_payroll;
            this.t_payroll_detail = t_payroll_detail;
        }

        public String[] select_tbl()
        {
            try
            {
                open_connection();

                using (SqlDataReader reader = command.ExecuteReader())
                {

                    if (reader.Read())
                    {
                        String[] info = new string[10];
                        info[0] = reader["t_user"].ToString();
                        info[1] = reader["t_employee"].ToString();
                        info[2] = reader["t_spreadsheet"].ToString();
                        info[3] = reader["t_spreadsheet_detail"].ToString();

                        close_connection();
                        return info;
                    }
                    close_connection();
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return null;
        }
    }
}
