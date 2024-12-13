using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Runtime.Intrinsics.Arm;

namespace Form_sistema.Class
{
    internal class class_user : connection
    {
        public String username { get; set; }
        public String password { get; set; }
        public String userId { get; set; }
        public String name { get; set; }
        public String last_name { get; set; }
        public String address { get; set; }
        public String date { get; set; }
        public String userIdConfirm { get; set; }

        public class_user() { }

        public class_user(String username, String password, String url, String procedure) : base(url, procedure)
        {
            this.username = username;
            this.password = password;
        }

        public class_user(String userId, String url, String procedure) : base(url, procedure)
        {
            this.userId = userId;
        }

        public class_user(String userId, String username, String password, String name,
            String last_name, String address, String url, String procedure) : base(url, procedure)
        {
            this.userId = userId;
            this.username = username;
            this.password = password;
            this.name = name;
            this.last_name = last_name;
            this.address = address;
        }

        public class_user(String userId, String userIdConfirm, String username, String password, String name,
            String last_name, String address, String url, String procedure) : base(url, procedure)
        {
            this.userId = userId;
            this.userIdConfirm = userIdConfirm;
            this.username = username;
            this.password = password;
            this.name = name;
            this.last_name = last_name;
            this.address = address;
        }
        public class_user(String userId, String username, String name, String last_name, String address, String date)
        {
            this.userId = userId;
            this.username = username;
            this.name = name;
            this.last_name = last_name;
            this.address = address;
            this.date = date;
        }

        public class_user(String url, String procedure) : base(url, procedure)
        {
         
        }

        public Boolean select_userLogin()
        {
            try
            {
                open_connection();

                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string userConfirm = reader["username"].ToString();
                        string passwordConfirm = reader["password"].ToString();

                        if (username == userConfirm && hashing(password) == passwordConfirm)
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
                Console.WriteLine("Hubo un error: " + ex.Message);
                return false;
            }
        }

        public String[] select_userId()
        {
            try
            {
                open_connection();

                command.Parameters.AddWithValue("@p_userId", userId);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        String[] info = new string[10];
                        info[0] = reader["userId"].ToString();
                        info[1] = reader["username"].ToString();
                        info[2] = reader["name"].ToString();
                        info[3] = reader["last_name"].ToString();
                        info[4] = reader["address"].ToString();
                        info[5] = reader["date_of_entry"].ToString();

                        close_connection();
                        return info;
                    }
                }

                close_connection();
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hubo un error: " + ex.Message);
                return null;
            }
        }

        public Boolean insert_user()
        {
            try
            {
                open_connection();

                command.Parameters.AddWithValue("@p_userId", userId);
                command.Parameters.AddWithValue("@p_username", username);
                command.Parameters.AddWithValue("@p_password", hashing(password));
                command.Parameters.AddWithValue("@p_name", name);
                command.Parameters.AddWithValue("@p_last_name", last_name);
                command.Parameters.AddWithValue("@p_address", address);

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

        public Boolean update_user()
        {
            try
            {
                open_connection();

                command.Parameters.AddWithValue("@p_userId", userId);
                command.Parameters.AddWithValue("@p_userIdConfirm", userIdConfirm);
                command.Parameters.AddWithValue("@p_username", username);
                command.Parameters.AddWithValue("@p_password", hashing(password));
                command.Parameters.AddWithValue("@p_name", name);
                command.Parameters.AddWithValue("@p_last_name", last_name);
                command.Parameters.AddWithValue("@p_address", address);

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

        public List<class_user> select_table_user()
        {
            try
            {
                open_connection();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<class_user> list = new List<class_user>();

                    while (reader.Read())
                    {
                        String[] info = new string[10];
                        info[0] = reader["userId"].ToString();
                        info[1] = reader["username"].ToString();
                        info[2] = reader["name"].ToString();
                        info[3] = reader["last_name"].ToString();
                        info[4] = reader["address"].ToString();
                        DateTime d = Convert.ToDateTime(reader["date_of_entry"]).Date;
                        info[5] = d.ToString("MM/dd/yyyy");

                        class_user user = new class_user(info[0], info[1], info[2], info[3], info[4], info[5]);
                        list.Add(user);
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

        public String hashing(String password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(bytes);

                StringBuilder hashBuilder = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    hashBuilder.Append(b.ToString("X2")); // Esto significa que cada byte se representará con dos caracteres hexadecimales (por ejemplo, 0A, 1B, etc.).
                }
                return hashBuilder.ToString();
            }
        }
    }
}


