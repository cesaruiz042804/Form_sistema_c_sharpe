using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_sistema.Class
{
    internal class class_total_spreadsheet : connection
    {
        public String id_spreadsheet { get; set; }
        public String creation_date { get; set; }
        public String id_employee { get; set; }
        public String name1 { get; set; }
        public String last_name1 { get; set; }
        public String gross_salary { get; set; }
        public String social_security { get; set; }
        public String educational_insurance { get; set; }
        public String net_salary { get; set; }

        public class_total_spreadsheet()
        {

        }

        public class_total_spreadsheet(String url, String procedure) : base(url, procedure)
        {

        }

        public class_total_spreadsheet(String id_spreadsheet, String creation_date, String gross_salary,
            String social_security, String educational_insurance, String net_salary)
        {
            this.id_spreadsheet = id_spreadsheet;
            this.creation_date = creation_date;
            this.gross_salary = gross_salary;
            this.social_security = social_security;
            this.educational_insurance = educational_insurance;
            this.net_salary = net_salary;
        }

        public class_total_spreadsheet(String id_spreadsheet, String creation_date, String id_employee, 
            String name1, String last_name1, String gross_salary,
            String social_security, String educational_insurance, String net_salary)
        {
            this.id_spreadsheet = id_spreadsheet;
            this.creation_date = creation_date;
            this.id_employee = id_employee;
            this.name1 = name1;
            this.last_name1 = last_name1;
            this.gross_salary = gross_salary;
            this.social_security = social_security;
            this.educational_insurance = educational_insurance;
            this.net_salary = net_salary;
        }

        public List<class_total_spreadsheet> select_table_total_spreadsheet()
        {
            try
            {
                open_connection();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<class_total_spreadsheet> list = new List<class_total_spreadsheet>();

                    while (reader.Read())
                    {
                        String[] info = new string[6];
                        info[0] = reader["id_spreadsheet"].ToString();
                        DateTime d = Convert.ToDateTime(reader["creation_date"]).Date;
                        info[1] = d.ToString("MM/dd/yyyy");
                        info[2] = reader["t_gross_salary"].ToString();
                        info[3] = reader["t_social_security"].ToString();
                        info[4] = reader["t_educational_ensurance"].ToString();
                        info[5] = reader["t_net_salary"].ToString();

                        class_total_spreadsheet s = new class_total_spreadsheet(info[0], info[1], info[2], info[3], info[4], info[5]);
                        list.Add(s);
                    }
                    close_connection();
                    return list;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return null;
        }

        public List<class_total_spreadsheet> select_table_data_spreadsheet()
        {
            try
            {
                open_connection();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<class_total_spreadsheet> list = new List<class_total_spreadsheet>();

                    while (reader.Read())
                    {
                        String[] info = new string[9];
                        info[0] = reader["id_spreadsheet"].ToString();
                        DateTime d = Convert.ToDateTime(reader["creation_date"]).Date;
                        info[1] = d.ToString("MM/dd/yyyy");
                        info[2] = reader["id_employee"].ToString();
                        info[3] = reader["name1"].ToString();
                        info[4] = reader["last_name1"].ToString();
                        info[5] = reader["gross_salary"].ToString();
                        info[6] = reader["social_security"].ToString();
                        info[7] = reader["educational_insurance"].ToString();
                        info[8] = reader["net_salary"].ToString();

                        class_total_spreadsheet s = new class_total_spreadsheet(info[0], info[1], info[2], info[3], info[4], info[5], info[6], info[7], info[8]);
                        list.Add(s);
                    }
                    close_connection();
                    return list;
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
