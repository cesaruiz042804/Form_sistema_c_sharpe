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
    public partial class frmCreateSpreadsheet : Form
    {
        methods m = new methods();
        string url = "Data Source=DESKTOP-GJL2Q9B\\SQLDEVELOPER;Initial Catalog=dbGestion;Integrated Security=True";

        public frmCreateSpreadsheet()
        {
            InitializeComponent();
        }

        private void CreateSpreadsheet_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateS_Click(object sender, EventArgs e)
        {
            class_spreadsheet s = new class_spreadsheet(txtNumcode.Value.ToString(), url, "sp_select_idSpreadsheet");

            if (s.select_exist_spreadsheet() != true)
            {
                s = new class_spreadsheet(txtNumcode.Value.ToString(), txtDateS.Text, url, "sp_insert_tbl_spreadsheet");
                if (s.insert_spreadsheet())
                {
                    MessageBox.Show("The form has been created successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("The form has not been created successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("There is already a form with that code.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
