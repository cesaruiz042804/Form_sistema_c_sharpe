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
    public partial class frmTotalSpreadsheet : Form
    {
        string url = "Data Source=DESKTOP-GJL2Q9B\\SQLDEVELOPER;Initial Catalog=dbGestion;Integrated Security=True";

        public frmTotalSpreadsheet()
        {
            InitializeComponent();
        }

        private void frmTotalSpreadsheet_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Table - Payroll Totals", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            table_data();
        }

        private void table_data()
        {
            try
            {
                class_total_spreadsheet sp = new class_total_spreadsheet(url, "sp_select_tbl_spreadsheet_total_datagrid");
                List<class_total_spreadsheet> data = sp.select_table_total_spreadsheet();

                var listForDisplay = data.Select(e => new
                {
                    e.id_spreadsheet,
                    e.creation_date,
                    e.gross_salary,
                    e.social_security,
                    e.educational_insurance,
                    e.net_salary,
                }).ToList();

                dtTable.DataSource = listForDisplay;

                dtTable.Columns["id_spreadsheet"].HeaderText = "ID Spreadsheet";
                dtTable.Columns["creation_date"].HeaderText = "Creation date";
                dtTable.Columns["gross_salary"].HeaderText = "Gross salary";
                dtTable.Columns["social_security"].HeaderText = "Social security";
                dtTable.Columns["educational_insurance"].HeaderText = "Educational insurance";
                dtTable.Columns["net_salary"].HeaderText = "Net salary";

                dtTable.Columns["id_spreadsheet"].Width = 90;
                dtTable.Columns["creation_date"].Width = 110;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
