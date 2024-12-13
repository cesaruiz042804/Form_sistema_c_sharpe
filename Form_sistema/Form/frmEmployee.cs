using Form_sistema.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_sistema
{
    public partial class frmEmployee : Form
    {
        methods m = new methods();
        string url = "Data Source=DESKTOP-GJL2Q9B\\SQLDEVELOPER;Initial Catalog=dbGestion;Integrated Security=True";

        public frmEmployee()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clean_txt()
        {
            txtIdE1.Text = "";
            txtIdE2.Text = "";
            txtNameE1.Text = "";
            txtNameE2.Text = "";
            txtLastNameE1.Text = "";
            txtLastNameE2.Text = "";
            txtDateE.Text = "";
            txtAddressE.Text = "";
            txtPhoneE.Text = "";
        }

        private void active_txt_btn()
        {
            txtIdE2.Enabled = true;
            txtNameE1.Enabled = true;
            txtNameE2.Enabled = true;
            txtLastNameE1.Enabled = true;
            txtLastNameE2.Enabled = true;
            txtDateE.Enabled = true;
            txtAddressE.Enabled = true;
            txtPhoneE.Enabled = true;

            btnSaveE.Enabled = true;
            //btnUpdateE.Enabled = true;

            txtIdE1.Enabled = false;
            btnSearchE.Enabled = false;
            btnNewE.Enabled = false;
        }

        private void desactive_txt_btn()
        {
            txtIdE2.Enabled = false;
            txtNameE1.Enabled = false;
            txtNameE2.Enabled = false;
            txtLastNameE1.Enabled = false;
            txtLastNameE2.Enabled = false;
            txtDateE.Enabled = false;
            txtAddressE.Enabled = false;
            txtPhoneE.Enabled = false;

            btnSaveE.Enabled = false;
            btnUpdateE.Enabled = false;

            txtIdE1.Enabled = true;
            btnSearchE.Enabled = true;
            btnNewE.Enabled = true;
        }

        private void after_search()
        {
            btnSearchE.Enabled = false;
            txtIdE1.Enabled = false;
            btnUpdateE.Enabled = true;
        }

        private void btnNewE_Click(object sender, EventArgs e)
        {
            active_txt_btn();
        }

        private void btnSaveE_Click(object sender, EventArgs e)
        {
            Control[] arr_control = { txtIdE2, txtNameE1, txtNameE2, txtLastNameE1,
                txtLastNameE2, txtDateE, txtAddressE, txtPhoneE };
            String[] name_box = { "txtIdU2", "txtUserU", "txtPasswordU1", "txtPasswordU2", "txtNameU", "txtLastNameU", "txtAddressU", "txtDateU" };
            String[] valor = { txtIdE2.Text, txtNameE1.Text, txtNameE2.Text, txtLastNameE1.Text,
            txtLastNameE1.Text, txtDateE.Text, txtAddressE.Text, txtPhoneE.Text };
            String[] words = { "ID", "First Name", "Second Name", "Last Name", "Name", "Second Last Name", "Date of Birth", "Address", "Phone Number" };
            String text_box = "You cannot leave the text boxes empty in: ";

            Boolean verify = m.check_box(errorProvider1, arr_control, name_box, valor, words, text_box);

            if (verify == true)
            {
                String textId = txtIdE1.Text.Replace("-", "").Trim();

                if (textId.Equals(""))
                {
                    class_employee emp = new class_employee(txtIdE2.Text, txtNameE1.Text, txtNameE2.Text,
                        txtLastNameE1.Text, txtLastNameE2.Text, txtDateE.Text, txtAddressE.Text,
                        txtPhoneE.Text, url, "sp_insert_tbl_employee");

                    if (emp.insert_employee() == true)
                    {
                        MessageBox.Show("The data has been successfully saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        clean_txt();
                        desactive_txt_btn();
                    }
                    else
                    {
                        MessageBox.Show("The data has not been saved correctly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    class_employee emp = new class_employee(txtIdE1.Text, txtIdE2.Text, txtNameE1.Text, txtNameE2.Text,
                        txtLastNameE1.Text, txtLastNameE2.Text, txtDateE.Text, txtAddressE.Text,
                        txtPhoneE.Text, url, "sp_update_tbl_employee");

                    if (emp.update_employee() == true)
                    {
                        MessageBox.Show("The data was updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        clean_txt();
                        desactive_txt_btn();
                    }
                    else
                    {
                        MessageBox.Show("The data was not updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        public void getTextSpanish()
        {
            label1.Text = Res_SP.Employee_Registration;
            label3.Text = Res_SP.First_Name;
            label8.Text = Res_SP.Second_Name;
            label9.Text = Res_SP.Last_Name;
            label7.Text = Res_SP.Second_Last_Name;
            label10.Text = Res_SP.Date_of_Birth;
            label5.Text = Res_SP.Address;
            label11.Text = Res_SP.Phone_Number;
            btnNewE.Text = Res_SP.New;
            btnSaveE.Text = Res_SP.Save;
            btnUpdateE.Text = Res_SP.Update;
            btnCloseE.Text = Res_SP.Close;
            btnSearchE.Text = Res_SP.Search;
        }

        public void getTextEnglish()
        {
            label1.Text = Res_SP.Employee_Registration;
            label3.Text = Res_SP.First_Name;
            label8.Text = Res_SP.Second_Name;
            label9.Text = Res_SP.Last_Name;
            label7.Text = Res_SP.Second_Last_Name;
            label10.Text = Res_SP.Date_of_Birth;
            label5.Text = Res_SP.Address;
            label11.Text = Res_SP.Phone_Number;
            btnNewE.Text = Res_SP.New;
            btnSaveE.Text = Res_SP.Save;
            btnUpdateE.Text = Res_SP.Update;
            btnCloseE.Text = Res_SP.Close;
            btnSearchE.Text = Res_SP.Search;
        }

        private void btnSearchE_Click(object sender, EventArgs e)
        {
            string textId = txtIdE1.Text.Trim().Replace("-", "");

            if (textId.Trim().Equals(""))
            {
                errorProvider1.SetError(txtIdE1, "Please, fill in the following information: " + "ID");
            }
            else
            {
                errorProvider1.SetError(txtIdE1, "");

                class_employee emp = new class_employee(txtIdE1.Text, url, "sp_select_tbl_id_employee");

                if (emp.select_idEmployee() != null)
                {
                    String[] arr = new string[10];
                    int i = 0;

                    emp = new class_employee(txtIdE1.Text, url, "sp_select_tbl_id_employee");

                    foreach (String rs in emp.select_idEmployee())
                    {
                        arr[i] = rs;
                        i++;
                    }

                    txtIdE2.Text = arr[0];
                    txtNameE1.Text = arr[1];
                    txtNameE2.Text = arr[2];
                    txtLastNameE1.Text = arr[3];
                    txtLastNameE2.Text = arr[4];
                    txtDateE.Text = arr[5];
                    txtAddressE.Text = arr[6];
                    txtPhoneE.Text = arr[7];

                    after_search();
                }
                else
                {
                    MessageBox.Show("We couldn’t locate any employee with the given ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtIdE1_Click(object sender, EventArgs e)
        {
            txtIdE1.SelectionStart = 0;
            txtIdE1.SelectionLength = 0;
        }

        private void txtIdE2_Click(object sender, EventArgs e)
        {
            txtIdE2.SelectionStart = 0;
            txtIdE2.SelectionLength = 0;
        }

        private void txtPhoneE_Click(object sender, EventArgs e)
        {
            txtPhoneE.SelectionStart = 0;
            txtPhoneE.SelectionLength = 0;
        }

        private void btnUpdateE_Click(object sender, EventArgs e)
        {
            active_txt_btn();
        }
    }
}