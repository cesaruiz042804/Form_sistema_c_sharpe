using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Xml.Linq;

namespace Form_sistema.Class
{
    internal class class_spreadsheet : connection
    {
        public static String id; // Static because the getters are initialized as their own copy, and this one too
        public String id_spreadsheet { get; set; }
        public String date { get; set; }
        public String id_employee { get; set; }
        public String hours_worked { get; set; }
        public String gross_salary { get; set; }
        public String social_security { get; set; }
        public String educational_insurance { get; set; }
        public String net_salary { get; set; }
        public String hourly_rate { get; set; }
        public string getId // This is to get the payroll ID where you want to save the employee
        {
            get { return id; }
            set { id = value; }
        }

        public class_spreadsheet()
        {

        }

        public class_spreadsheet(String id_spreadsheet, String url, String procedure) : base(url, procedure)
        {
            this.id_spreadsheet = id_spreadsheet;
        }

        public class_spreadsheet(String id_spreadsheet)
        {
            this.id_spreadsheet = id_spreadsheet;
        }

        public class_spreadsheet(String id_spreadsheet, String date, String url, String procedure) : base(url, procedure)
        {
            this.id_spreadsheet = id_spreadsheet;
            this.date = date;
        }

        public class_spreadsheet(String hours_worked, String hourly_rate)
        {
            this.hours_worked = hours_worked;
            this.hourly_rate = hourly_rate;
        }

        public class_spreadsheet(String id_spreadsheet, String id_employee, String hours_worked, String hourly_rate, String gross_salary,
            String social_security, String educational_insurance, String net_salary, 
            String url, String procedure) : base(url, procedure)
        {
            this.id_spreadsheet = id_spreadsheet;
            this.id_employee = id_employee;
            this.hours_worked = hours_worked;
            this.gross_salary = gross_salary;
            this.social_security = social_security;
            this.educational_insurance = educational_insurance;
            this.net_salary = net_salary;
        }

        public Boolean select_exist_spreadsheet()
        {
            try
            {
                open_connection();

                command.Parameters.AddWithValue("@p_id_spreadsheet", Convert.ToInt16(id_spreadsheet)); // Se pueden sacar los datos como string
                
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        close_connection();
                        return true;
                    }
                    else
                    {
                        close_connection();
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Boolean insert_spreadsheet()
        {
            try
            {
                open_connection();

                command.Parameters.AddWithValue("@p_id_spreadsheet", Convert.ToInt16(id_spreadsheet));
                DateTime d = DateTime.Parse(date);
                command.Parameters.AddWithValue("@p_creation_date", d);


                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (reader["codigo"].ToString() == "1")
                        {
                            close_connection();
                            return true;
                        }
                    }
                }

                close_connection();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public String[] select_add_idEmployee()
        {
            try
            {
                open_connection();

                command.Parameters.AddWithValue("@p_id_employee", id_spreadsheet);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        String[] info = new string[10];
                        info[0] = reader["name1"].ToString();
                        info[1] = reader["name2"].ToString();
                        info[2] = reader["last_name1"].ToString();
                        info[3] = reader["last_name2"].ToString();

                        close_connection();
                        return info;
                    }
                }

                close_connection();
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public Boolean insert_employee_spreadsheet()
        {
            try
            {
                open_connection();

                command.Parameters.AddWithValue("@p_id_spreadsheet", id_spreadsheet);
                command.Parameters.AddWithValue("@p_id_employee", id_employee);
                command.Parameters.AddWithValue("@p_hours_worked", hours_worked);
                command.Parameters.AddWithValue("@p_gross_salary", gross_salary);
                command.Parameters.AddWithValue("@p_social_security", social_security);
                command.Parameters.AddWithValue("@p_educational_insurance", educational_insurance);
                command.Parameters.AddWithValue("@p_net_salary", net_salary);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (reader["codigo"].ToString() == "1")
                        {
                            close_connection();
                            return true;
                        }
                    }
                }

                close_connection();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        
        public List<class_spreadsheet> select_table_spreadsheet()
        {
            try
            {
                open_connection();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<class_spreadsheet> list = new List<class_spreadsheet>();

                    while (reader.Read())
                    {
                        String[] info = new string[2];
                        info[0] = reader["id_spreadsheet"].ToString();
                        DateTime d = Convert.ToDateTime(reader["creation_date"]).Date;
                        info[1] = d.ToString("MM/dd/yyyy");

                        class_spreadsheet s = new class_spreadsheet(info[0], info[1]);
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

        public String t_gross_salary()
        {
            return (Convert.ToInt64(hours_worked) * Convert.ToDouble(hourly_rate)).ToString();
        }

        public String t_social_security()
        {
            return (Convert.ToDouble(this.t_gross_salary()) * 0.0975).ToString();
        }

        public String t_educational_insurance()
        {
            return (Convert.ToDouble(this.t_gross_salary()) * 0.0125).ToString();
        }

        public String t_net_salary()
        {
            return (Convert.ToDouble(this.t_gross_salary()) - Convert.ToDouble(this.t_social_security()) 
                - Convert.ToDouble(this.t_educational_insurance())).ToString();
        }
    }
}
