using Form_sistema.Class;
using Guna.Charts.WinForms;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.Charts.Interfaces;
using DevExpress.Xpo.DB;
using System.Security.Policy;
using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Windows.Media;
using FontAwesome.Sharp;


namespace Form_sistema
{
    public partial class frmMenu : Form
    {

        string url = "Data Source=DESKTOP-GJL2Q9B\\SQLDEVELOPER;Initial Catalog=dbGestion;Integrated Security=True";

        public frmMenu()
        {
            InitializeComponent();
            customizeDesign();
            frmLogin l = new frmLogin();
            //initial();
        }
        private void frmMenu_Load(object sender, EventArgs e)
        {
            count_tbl();
            gunaUser.Animated = true;
            gunaEmployee.Animated = true;
            gunaPayroll.Animated = true;
            gunaEmpPay.Animated = true;

            
            if(Properties.Settings.Default.Themes != "")
            {
                change_color(Properties.Settings.Default.Themes);
            }
            else
            {
                change_color("light");
            }
            
        }


        public void getTextSpanish()
        {
            /*
            label1.Text = Res_SP.Menu;
            btnUser.Text = Res_SP.User;
            btnAddUser.Text = Res_SP.Add_or_update_data;
            btnDeleteUser.Text = Res_SP.Delete_user;
            btnInformationU.Text = Res_SP.More_Information;
            btnAddEmployee.Text = Res_SP.Add_or_update_data;
            btnEmployee.Text = Res_SP.Employee;
            btnDeleteEmployee.Text = Res_SP.Delete_employee;
            btnInformationE.Text = Res_SP.More_Information;
            btnCreate.Text = Res_SP.Create;
            btnSpreadsheet.Text = Res_SP.Spreadsheet;
            btnTotalSpreadsheet.Text = Res_SP.Total_Spreadsheet;
            btnAddEmployeeSpread.Text = Res_SP.Add_employee_spreadsheed;
            btnCalculation.Text = Res_SP.Spreadsheet_Calculation;
            btnSettings.Text = Res_SP.Settings;
            btnLanguage.Text = Res_SP.Language;
            btnHelp.Text = Res_SP.Help;
            btnTheme.Text = Res_SP.Theme;
            */
        }

        public void getTextEnglish()
        {
            /*
            label1.Text = Res_SP.Menu;
            btnUser.Text = Res_SP.User;
            btnAddUser.Text = Res_SP.Add_or_update_data;
            btnDeleteUser.Text = Res_SP.Delete_user;
            btnInformationU.Text = Res_SP.More_Information;
            btnAddEmployee.Text = Res_SP.Add_or_update_data;
            btnEmployee.Text = Res_SP.Employee;
            btnDeleteEmployee.Text = Res_SP.Delete_employee;
            btnInformationE.Text = Res_SP.More_Information;
            btnCreate.Text = Res_SP.Create;
            btnSpreadsheet.Text = Res_SP.Spreadsheet;
            btnTotalSpreadsheet.Text = Res_SP.Total_Spreadsheet;
            btnAddEmployeeSpread.Text = Res_SP.Add_employee_spreadsheed;
            btnCalculation.Text = Res_SP.Spreadsheet_Calculation;
            btnSettings.Text = Res_SP.Settings;
            btnLanguage.Text = Res_SP.Language;
            btnHelp.Text = Res_SP.Help;
            btnTheme.Text = Res_SP.Theme;
            */
        }

        private void count_tbl()
        {
            try
            {
                class_count user = new class_count(url, "sp_select_tbl_count");

                if (user.select_tbl() != null)
                {
                    user = new class_count(url, "sp_select_tbl_count");

                    String[] info = new string[4];
                    int i = 0;

                    foreach (String item in user.select_tbl())
                    {
                        if (item != null)
                        {
                            info[i] = item;
                        }
                        i++;
                    }

                    gunaUser.Value = Convert.ToInt32(info[0]);
                    gunaEmployee.Value = Convert.ToInt32(info[1]);
                    gunaPayroll.Value = Convert.ToInt32(info[2]);
                    gunaEmpPay.Value = Convert.ToInt32(info[3]);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void change_color(String Theme)
        {
            class_theme.option_theme(Theme);
            
            class_color.ChangeControlsBackColor(panel1, class_theme.Background1);
            class_color.ChangeForeColorsBackColor(panel1, class_theme.LetterBtn);

            class_color.ChangeControlsBackColor(panelGuna, class_theme.Background2);
            class_color.ChangeForeColorsBackColor(panelGuna, class_theme.LetterBack);
            panelGuna.BackColor = class_theme.Background2;
        }
        


        /*
        private void ChangeControlsBackColor(Control parent, Color color)
        {
            foreach (Control control in parent.Controls)
            {
                control.BackColor = color;
                // Si el control tiene hijos, aplicar recursivamente
                if (control.HasChildren)
                {
                    ChangeControlsBackColor(control, color);
                }
            }
        }
        */

        /*
                private void ChangeForeColorsBackColor(Control parent, Color color)
                {
                    foreach (Control control in parent.Controls)
                    {
                        control.ForeColor = color;
                        // Si el control tiene hijos, aplicar recursivamente
                        if (control.HasChildren)
                        {
                            ChangeForeColorsBackColor(control, color);
                        }
                    }
                }
                */

        /*
        private const int DWMWA_CAPTION_COLOR = 35;

        [DllImport("dwmapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        private void SetTitleBarColor(int r, int g, int b)
        {
            Color color = Color.FromArgb(r, g, b);
            int colorValue = ColorTranslator.ToWin32(color);
            DwmSetWindowAttribute(this.Handle, DWMWA_CAPTION_COLOR, ref colorValue, sizeof(int));
        }
        */

        private void customizeDesign()
        {
            panelUser.Visible = false;
            panelEmployee.Visible = false;
            panelSpreadsheet.Visible = false;
            panelSettings.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panelUser.Visible == true)
                panelUser.Visible = false;
            if (panelEmployee.Visible == true)
                panelEmployee.Visible = false;
            if (panelSpreadsheet.Visible == true)
                panelSpreadsheet.Visible = false;
            if (panelSettings.Visible == true)
                panelSettings.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void btnMenuUser_Click(object sender, EventArgs e)
        {
            showSubmenu(panelUser);
        }

        private void btnMenuEmployee_Click(object sender, EventArgs e)
        {
            showSubmenu(panelEmployee);
        }

        private void btnMenuSpreadsheet_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSpreadsheet);
        }

        private void btnMenuSettings_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSettings);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            frmUser frm = new frmUser();
            frm.ShowDialog();
        }

        private void ibtnDeleteUser_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnTableUser_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            frmTableUser frm = new frmTableUser();
            frm.Show();
        }

        private void btnAddEmployees_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            frmEmployee frm = new frmEmployee();
            frm.ShowDialog();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnTableEmployee_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            frmTableEmployee frm = new frmTableEmployee();
            frm.Show();
        }

        private void btnCreateSpreasheet_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            frmCreateSpreadsheet frm = new frmCreateSpreadsheet();
            frm.ShowDialog();
        }

        private void btnPayrollTotals_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            frmTotalSpreadsheet frm = new frmTotalSpreadsheet();
            frm.Show();
        }

        private void btnAddEmployeeSp_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            frmAddEmployee frm = new frmAddEmployee();
            frm.ShowDialog();
        }

        private void btnTotalSp_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            frmSpreadsheetCalculation frm = new frmSpreadsheetCalculation();
            frm.Show();
        }

        private void btnTheme_Click_1(object sender, EventArgs e)
        {
            hideSubmenu();
            
            if(btnTheme.Text == "Theme - dark mode")
            {
                Properties.Settings.Default.Themes = "dark";
                Properties.Settings.Default.Save();
                change_color(Properties.Settings.Default.Themes);
                btnTheme.Text = "Theme - light mode";
            }
            else
            {
                Properties.Settings.Default.Themes = "light";
                Properties.Settings.Default.Save();
                change_color(Properties.Settings.Default.Themes);
                btnTheme.Text = "Theme - dark mode";
            }
            
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
