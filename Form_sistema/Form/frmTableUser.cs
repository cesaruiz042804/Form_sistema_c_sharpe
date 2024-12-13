using Form_sistema.Class;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_sistema
{
    public partial class frmTableUser : Form
    {
        string url = "Data Source=DESKTOP-GJL2Q9B\\SQLDEVELOPER;Initial Catalog=dbGestion;Integrated Security=True";

        public frmTableUser()
        {
            InitializeComponent();
        }

        private void frmTableUser_Load(object sender, EventArgs e)
        {
            table_data();
            MessageBox.Show("Table - User", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void table_data()
        {
            try
            {
               class_user user = new class_user(url, "sp_select_tbl_user_datagrid");
                List<class_user> data = user.select_table_user();

                var userListForDisplay = data.Select(u => new
                {
                    u.userId,
                    u.username,
                    u.name,
                    u.last_name,
                    u.address,
                    u.date
                }).ToList();
                
                /* Esto es para especificar que atributos deseo mostrar en el dataGridView
                // ya que al tener muchos constructores, se terminan mostrando todos los atributos
                 de distintos constructores */

                dtTable.DataSource = userListForDisplay;

                dtTable.Columns["userId"].HeaderText = "ID";
                dtTable.Columns["username"].HeaderText = "User Name";
                dtTable.Columns["name"].HeaderText = "Name";
                dtTable.Columns["last_name"].HeaderText = "Last Name";
                dtTable.Columns["address"].HeaderText = "Address";
                dtTable.Columns["date"].HeaderText = "Date of Entry";

                dtTable.Columns["userId"].Width = 100;
                dtTable.Columns["name"].Width = 110;
                dtTable.Columns["last_name"].Width = 110;
                dtTable.Columns["date"].Width = 110;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
