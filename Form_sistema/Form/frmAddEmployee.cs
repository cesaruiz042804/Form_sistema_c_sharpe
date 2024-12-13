using Form_sistema.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_sistema
{
    public partial class frmAddEmployee : Form
    {
        methods m = new methods();
        string url = "Data Source=DESKTOP-GJL2Q9B\\SQLDEVELOPER;Initial Catalog=dbGestion;Integrated Security=True";

        public frmAddEmployee()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNewE_Click(object sender, EventArgs e)
        {
            add_employee();
        }

        private void clear_txt()
        {
            lblName1.Text = "";
            lblName2.Text = "";
            lblLast1.Text = "";
            lblLast2.Text = "";
            txtHour.Value = 160;
            txtHourlyRate.Text = "";
            txtIdAddEmp.Text = "";
            txtHour.Enabled = true;
            txtHourlyRate.Enabled = true;
        }

        private void btnSearchE_Click(object sender, EventArgs e)
        {
            string textId = txtIdAddEmp.Text.Trim().Replace("-", "");

            if (textId.Trim().Equals(""))
            {
                errorProvider1.SetError(txtIdAddEmp, "Please, fill in the following information: " + "ID");
            }
            else
            {
                errorProvider1.SetError(txtIdAddEmp, "");

                class_spreadsheet emp = new class_spreadsheet(txtIdAddEmp.Text, url, "sp_select_tbl_spreadsheet_add_emp");

                if (emp.select_add_idEmployee() != null)
                {
                    String[] arr = new string[10];
                    int i = 0;

                    emp = new class_spreadsheet(txtIdAddEmp.Text, url, "sp_select_tbl_spreadsheet_add_emp");

                    foreach (String rs in emp.select_add_idEmployee())
                    {
                        arr[i] = rs;
                        i++;
                    }

                    lblName1.Text = arr[0];
                    lblName2.Text = arr[1];
                    lblLast1.Text = arr[2];
                    lblLast2.Text = arr[3];

                    txtHour.Enabled = true;
                    txtHourlyRate.Enabled = true;
                }
                else
                {
                    MessageBox.Show("We couldn’t locate any employee with the given ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clear_txt();
                }
            }
        }

        private void add_employee()
        {
            frmSelectionSpreadsheet sp = new frmSelectionSpreadsheet();

            class_spreadsheet emp = new class_spreadsheet();


            Boolean verify = true;

            
            if (txtHourlyRate.Text.Trim().Equals(""))
            {
                errorProvider1.SetError(txtHourlyRate, "Please, fill in the following information: " + "Hourly rate");
                verify = false;
            }
            else
            {
                errorProvider1.SetError(txtHourlyRate, "");
            }

            try
            {
                if (Convert.ToDouble(txtHourlyRate.Text) < 4 || Convert.ToDouble(txtHourlyRate.Text) > 20)
                {
                    MessageBox.Show("The entered salary cannot be less than 4 nor greater than 20 dollars.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    verify = false;
                }

                if (verify == true)
                {
                    emp = new class_spreadsheet(txtHour.Value.ToString(), txtHourlyRate.Text);

                    sp.ShowDialog(); // ShowDialog is used to prevent the rest of the code from executing until the form is closed

                    if (emp.getId != null)
                    {
                        class_employee b = new class_employee(txtIdAddEmp.Text, url, "sp_select_tbl_id_employee_spreadsheet");

                        if(b.select_idEmployee() != null)
                        {
                            emp = new class_spreadsheet(emp.getId, txtIdAddEmp.Text, txtHour.Value.ToString(),
                               txtHourlyRate.Text, emp.t_gross_salary(), emp.t_social_security(),
                               emp.t_educational_insurance(), emp.t_net_salary(), url, "sp_insert_tbl_spreadsheet_detail");

                            if (emp.insert_employee_spreadsheet())
                            {
                                MessageBox.Show("The data was saved correctly.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                clear_txt();
                            }
                            else
                            {
                                MessageBox.Show("The data was not saved correctly.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("The employee is already registered in a payroll.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            clear_txt();
                        }
                    }
                    else
                    {
                        MessageBox.Show("You must choose the registration payroll to which you want to add the employee.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("An error occurred.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtHourlyRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtIdAddEmp_Click(object sender, EventArgs e)
        {
            txtIdAddEmp.SelectionStart = 0;
            txtIdAddEmp.SelectionLength = 0;
        }
    }
}
