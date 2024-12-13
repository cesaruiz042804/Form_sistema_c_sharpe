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
    public partial class frmTableEmployee : Form
    {
        string url = "Data Source=DESKTOP-GJL2Q9B\\SQLDEVELOPER;Initial Catalog=dbGestion;Integrated Security=True";

        public frmTableEmployee()
        {
            InitializeComponent();
        }

        private void frmTableEmployee_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Table - Employee", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            table_data();
        }

        private void table_data()
        {
            try
            {
                class_employee emp = new class_employee(url, "sp_select_tbl_employee_datagrid");
                List<class_employee> data = emp.select_table_employee();

                var employeeListForDisplay = data.Select(e => new
                {
                    e.id_employee,
                    e.name1,
                    e.name2,
                    e.last_name1,
                    e.last_name2,
                    e.date,
                    e.address,
                    e.phone,
                }).ToList();

                /* Esto es para especificar que atributos deseo mostrar en el dataGridView
                // ya que al tener muchos constructores, se terminan mostrando todos los atributos
                 de distintos constructores */

                dtTable.DataSource = employeeListForDisplay;

                dtTable.Columns["id_employee"].HeaderText = "ID";
                dtTable.Columns["name1"].HeaderText = "First Name";
                dtTable.Columns["name2"].HeaderText = "Second Name";
                dtTable.Columns["last_name1"].HeaderText = "Last Name";
                dtTable.Columns["last_name2"].HeaderText = "Second Last Name";
                dtTable.Columns["date"].HeaderText = "Date of Birth";
                dtTable.Columns["address"].HeaderText = "Address";
                dtTable.Columns["phone"].HeaderText = "Phone Number";

                dtTable.Columns["id_employee"].Width = 100;
                dtTable.Columns["name1"].Width = 110;
                dtTable.Columns["name2"].Width = 110;
                dtTable.Columns["last_name1"].Width = 110;
                dtTable.Columns["last_name2"].Width = 110;
                dtTable.Columns["date"].Width = 110;
                dtTable.Columns["phone"].Width = 110;

                dtTable.Columns["date"].DefaultCellStyle.Format = "MM/dd/yyyy";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
