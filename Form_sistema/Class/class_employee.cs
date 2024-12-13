using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Data;

namespace Form_sistema.Class
{
    internal class class_employee : connection
    {
        public String id_employee { get; set; }
        public String id_employeeConfirm { get; set; }
        public String name1 { get; set; }
        public String name2 { get; set; }
        public String last_name1 { get; set; }
        public String last_name2 { get; set; }
        public String phone { get; set; }
        public String address { get; set; }
        public String date { get; set; }


        public class_employee() { }

        public class_employee(String id_employee, String url, String procedure) : base(url, procedure)
        {
            this.id_employee = id_employee;
        }

        public class_employee(String id_employee, String name1, String name2, String last_name1,
            String last_name2, String date, String address, String phone, String url, String procedure) : base(url, procedure)
        {
            this.id_employee = id_employee;
            this.name1 = name1;
            this.name2 = name2;
            this.last_name1 = last_name1;
            this.last_name2 = last_name2;
            this.date = date;
            this.address = address;
            this.phone = phone;
        }

        public class_employee(String id_employee, String id_employeeConfirm, String name1, String name2, String last_name1,
            String last_name2, String date, String address, String phone, String url, String procedure) : base(url, procedure)
        {
            this.id_employee = id_employee;
            this.id_employeeConfirm = id_employeeConfirm;
            this.name1 = name1;
            this.name2 = name2;
            this.last_name1 = last_name1;
            this.last_name2 = last_name2;
            this.date = date;
            this.address = address;
            this.phone = phone;
        }
        public class_employee(String id_employee, String name1, String name2, String last_name1,
            String last_name2, String date, String address, String phone)
        {
            this.id_employee = id_employee;
            this.name1 = name1;
            this.name2 = name2;
            this.last_name1 = last_name1;
            this.last_name2 = last_name2;
            this.date = date;
            this.address = address;
            this.phone = phone;
        }

        public class_employee(String url, String procedure) : base(url, procedure)
        {

        }

        public String[] select_idEmployee()
        {
            try
            {
                open_connection();

                command.Parameters.AddWithValue("@p_id_employee", id_employee);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        String[] info = new string[10];
                        info[0] = reader["id_employee"].ToString();
                        info[1] = reader["name1"].ToString();
                        info[2] = reader["name2"].ToString();
                        info[3] = reader["last_name1"].ToString();
                        info[4] = reader["last_name2"].ToString();
                        info[5] = reader["date_of_birth"].ToString();
                        info[6] = reader["address"].ToString();
                        info[7] = reader["phone_number"].ToString();

                        close_connection();
                        return info;
                    }
                }

                close_connection();
                return null;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public Boolean insert_employee()
        {
            try
            {
                open_connection();

                command.Parameters.AddWithValue("@p_id_employee", id_employee);
                command.Parameters.AddWithValue("@p_name1", name1);
                command.Parameters.AddWithValue("@p_name2", name2);
                command.Parameters.AddWithValue("@p_last_name1", last_name1);
                command.Parameters.AddWithValue("@p_last_name2", last_name2);
                DateTime d = DateTime.Parse(date);
                command.Parameters.AddWithValue("@p_date_of_birth", d);
                command.Parameters.AddWithValue("@p_address", address);
                command.Parameters.AddWithValue("@p_phone_number", phone);


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

        public Boolean update_employee()
        {
            try
            {
                open_connection();

                command.Parameters.AddWithValue("@p_id_employee", id_employee);
                command.Parameters.AddWithValue("@p_id_employeeConfirm", id_employeeConfirm);
                command.Parameters.AddWithValue("@p_name1", name1);
                command.Parameters.AddWithValue("@p_name2", name2);
                command.Parameters.AddWithValue("@p_last_name1", last_name1);
                command.Parameters.AddWithValue("@p_last_name2", last_name2);
                DateTime d = DateTime.Parse(date);
                command.Parameters.AddWithValue("@p_date_of_birth", d);
                command.Parameters.AddWithValue("@p_address", address);
                command.Parameters.AddWithValue("@p_phone_number", phone);

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

        public List<class_employee> select_table_employee()
        {
            try
            {
                open_connection();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<class_employee> list = new List<class_employee>();

                    while (reader.Read())
                    {
                        String[] info = new string[10];
                        info[0] = reader["id_employee"].ToString();
                        info[1] = reader["name1"].ToString();
                        info[2] = reader["name2"].ToString();
                        info[3] = reader["last_name1"].ToString();
                        info[4] = reader["last_name2"].ToString();
                        DateTime d = Convert.ToDateTime(reader["date_of_birth"]).Date;
                        info[5] = d.ToString("MM/dd/yyyy");
                        info[6] = reader["address"].ToString();
                        info[7] = reader["phone_number"].ToString();


                        class_employee emp = new class_employee(info[0], info[1], info[2], info[3], info[4], info[5], info[6], info[7]);
                        list.Add(emp);
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
