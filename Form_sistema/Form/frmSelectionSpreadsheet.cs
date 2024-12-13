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
    public partial class frmSelectionSpreadsheet : Form
    {
        string url = "Data Source=DESKTOP-GJL2Q9B\\SQLDEVELOPER;Initial Catalog=dbGestion;Integrated Security=True";

        public frmSelectionSpreadsheet()
        {
            InitializeComponent();
        }

        private void frmSelectionSpreadsheet_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Table - Spreasheet", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            table_data();
        }

        /*
            Hacer una tabla para seleccionar la planilla. Se escoge la planilla haciendo doble click en la fila
        */

        private void table_data()
        {
            try
            {
                class_spreadsheet s = new class_spreadsheet("", url, "sp_select_tbl_spreadsheet_datagrid");
                List<class_spreadsheet> data = s.select_table_spreadsheet();

                var employeeListForDisplay = data.Select(s => new
                {
                    s.hours_worked,
                    s.hourly_rate
                }).ToList();

                dtTable.DataSource = employeeListForDisplay;

                dtTable.Columns["hours_worked"].HeaderText = "ID";
                dtTable.Columns["hourly_rate"].HeaderText = "Create date";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dtTable.Rows[e.RowIndex].Selected = true;

                DataGridViewRow selectedRow = dtTable.Rows[e.RowIndex];
                class_spreadsheet s = new class_spreadsheet();
                s.getId = selectedRow.Cells[0].Value.ToString(); // obtener el valor de la primera celda

                //MessageBox.Show("Id: " + s.getId, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
        }
    }
}
