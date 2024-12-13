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
    public partial class frmSpreadsheetCalculation : Form
    {
        string url = "Data Source=DESKTOP-GJL2Q9B\\SQLDEVELOPER;Initial Catalog=dbGestion;Integrated Security=True";

        public frmSpreadsheetCalculation()
        {
            InitializeComponent();
        }

        private void frmSpreadsheetCalculation_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Table - Payroll Totals", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            table_data();
        }

        private void table_data()
        {
            try
            {
                class_total_spreadsheet sp = new class_total_spreadsheet(url, "sp_select_tbl_spreadsheet_data_datagrid");
                List<class_total_spreadsheet> data = sp.select_table_data_spreadsheet();

                var listForDisplay = data.Select(e => new
                {
                    e.id_spreadsheet,
                    e.creation_date,
                    e.id_employee,
                    e.name1,
                    e.last_name1,
                    e.gross_salary,
                    e.social_security,
                    e.educational_insurance,
                    e.net_salary,
                }).ToList();

                dtTable.DataSource = listForDisplay;

                dtTable.Columns["id_spreadsheet"].HeaderText = "ID Spreadsheet";
                dtTable.Columns["creation_date"].HeaderText = "Creation Date";
                dtTable.Columns["id_employee"].HeaderText = "ID Employee";
                dtTable.Columns["name1"].HeaderText = "Name";
                dtTable.Columns["last_name1"].HeaderText = "Last Name";
                dtTable.Columns["gross_salary"].HeaderText = "Gross Salary";
                dtTable.Columns["social_security"].HeaderText = "Social Security";
                dtTable.Columns["educational_insurance"].HeaderText = "Educational Insurance";
                dtTable.Columns["net_salary"].HeaderText = "Net Salary";

                dtTable.Columns["id_spreadsheet"].Width = 110;
                dtTable.Columns["creation_date"].Width = 110;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
