using Form_sistema.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Form_sistema
{
    public partial class frmUser : Form
    {
        methods m = new methods();
        string url = "Data Source=DESKTOP-GJL2Q9B\\SQLDEVELOPER;Initial Catalog=dbGestion;Integrated Security=True";

        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Themes != "")
            {
                change_color(Properties.Settings.Default.Themes);
            }
            else
            {
                change_color("light");
            }
        }
        public void change_color(String Theme)
        {
            class_theme.option_theme(Theme);

            class_color.ChangeForeColorsBackColor(panel1, class_theme.LetterBack);
            class_color.ChangeForeColorsBackColor(panel2, class_theme.LetterBack);
            class_color.ChangeForeColorsBackColor(panel3, class_theme.LetterBack);
            class_color.ChangeForeColorsBackColor(panel4, class_theme.LetterBack);
            class_color.ChangeForeColorsBackColor(panel5, class_theme.LetterTextBox);
            panel1.BackColor = class_theme.Background1;
            panel2.BackColor = class_theme.Background1;
            panel3.BackColor = class_theme.Background1;
            panel4.BackColor = class_theme.Background1;
            class_color.ChangeButtonColorsBackColor(panel2, class_theme.Btn);
            class_color.ChangeButtonColorsForeColor(panel2, class_theme.LetterBtn);
            class_color.ChangeButtonColorsBackColor(panel4, class_theme.Btn);
            class_color.ChangeButtonColorsForeColor(panel4, class_theme.LetterBtn);
            /*
            class_color.ChangeForeColorsBackColor(panel1, class_theme.FontColorA);
            class_color.ChangeForeColorsBackColor(panel2, class_theme.FontColorA);
            class_color.ChangeForeColorsBackColor(panel3, class_theme.FontColorA);
            class_color.ChangeForeColorsBackColor(panel4, class_theme.FontColorA);
            class_color.ChangeForeColorsBackColor(panel5, class_theme.PanelMenuTotal);
            panel1.BackColor = class_theme.ColorAlternative;
            panel2.BackColor = class_theme.ColorAlternative;
            panel3.BackColor = class_theme.ColorAlternative;
            panel4.BackColor = class_theme.ColorAlternative;
            cboxPasswordU.ForeColor = class_theme.FontColorA;

            /*
            class_color.ChangeButtonColorsBackColor(panel1, class_theme.FontColorA);
            class_color.ChangeButtonColorsForeColor(panel1, class_theme.PanelMenuTotal);
            class_color.ChangeButtonColorsBackColor(panel2, class_theme.FontColorA);
            class_color.ChangeButtonColorsForeColor(panel2, class_theme.PanelMenuTotal);
            class_color.ChangeButtonColorsBackColor(panel3, class_theme.FontColorA);
            class_color.ChangeButtonColorsForeColor(panel3, class_theme.PanelMenuTotal);
            class_color.ChangeButtonColorsBackColor(panel4, class_theme.FontColorA);
            class_color.ChangeButtonColorsForeColor(panel4, class_theme.PanelMenuTotal);
            */

            /*
            class_color.ChangeButtonColorsBackColor(panel1, class_theme.PanelMenuTotal);
            class_color.ChangeButtonColorsForeColor(panel1, class_theme.FontColorA);
            class_color.ChangeButtonColorsBackColor(panel2, class_theme.PanelMenuTotal);
            class_color.ChangeButtonColorsForeColor(panel2, class_theme.FontColorA);
            class_color.ChangeButtonColorsBackColor(panel3, class_theme.PanelMenuTotal);
            class_color.ChangeButtonColorsForeColor(panel3, class_theme.FontColorA);
            class_color.ChangeButtonColorsBackColor(panel4, class_theme.PanelMenuTotal);
            class_color.ChangeButtonColorsForeColor(panel4, class_theme.FontColorA);
            */
        }

        private void btnNewU_Click(object sender, EventArgs e)
        {
            active_txt_btn();
            txtIdU1.Text = "";
        }
        private void clean_txt()
        {
            txtIdU1.Text = "";
            txtIdU2.Text = "";
            txtNameU.Text = "";
            txtLastNameU.Text = "";
            txtPasswordU1.Text = "";
            txtPasswordU2.Text = "";
            txtAddressU.Text = "";
        }

        private void active_txt_btn()
        {
            txtIdU2.Enabled = true;
            txtUserU.Enabled = true;
            txtNameU.Enabled = true;
            txtLastNameU.Enabled = true;
            txtPasswordU1.Enabled = true;
            txtPasswordU2.Enabled = true;
            cboxPasswordU.Enabled = true;
            txtAddressU.Enabled = true;
            cboxPasswordU.Enabled = true;

            btnSaveU.Enabled = true;
            //btnUpdateU.Enabled = true;

            txtIdU1.Enabled = false;
            btnSearchU.Enabled = false;
            btnNewU.Enabled = false;
        }

        private void desactive_txt_btn()
        {
            txtIdU2.Enabled = false;
            txtUserU.Enabled = false;
            txtNameU.Enabled = false;
            txtLastNameU.Enabled = false;
            txtPasswordU1.Enabled = false;
            txtPasswordU2.Enabled = false;
            cboxPasswordU.Enabled = false;
            txtAddressU.Enabled = false;
            cboxPasswordU.Enabled = false;

            btnSaveU.Enabled = false;
            btnUpdateU.Enabled = false;

            txtIdU1.Enabled = true;
            btnSearchU.Enabled = true;
            btnNewU.Enabled = true;
        }

        private void after_search()
        {
            btnSearchU.Enabled = false;
            txtIdU1.Enabled = false;
            btnUpdateU.Enabled = true;
        }

        private void btnSaveU_Click(object sender, EventArgs e)
        {
            Control[] arr_control = { txtIdU2, txtUserU, txtPasswordU1, txtPasswordU2,
                txtNameU, txtLastNameU, txtAddressU };
            String[] name_box = { "txtIdU2", "txtUserU", "txtPasswordU1", "txtPasswordU2", "txtNameU", "txtLastNameU", "txtAddressU" };
            String[] valor = { txtIdU2.Text, txtUserU.Text, txtPasswordU1.Text, txtPasswordU2.Text,
            txtNameU.Text, txtLastNameU.Text, txtAddressU.Text };
            String[] words = { "ID", "User", "Password", "Confirm Password", "Name", "Last Name", "Address" };
            String text_box = "You cannot leave the text boxes empty in: ";

            Boolean verify = m.check_box(errorProvider1, arr_control, name_box, valor, words, text_box);

            if (verify == true)
            {
                if (txtPasswordU1.Text != txtPasswordU2.Text)
                {
                    verify = false;
                    MessageBox.Show("Please verify that the passwords match.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (verify == true)
                {
                    String textId = txtIdU1.Text.Replace("-", "").Trim();

                    if (textId.Equals(""))
                    {
                        class_user user = new class_user(txtIdU2.Text, txtUserU.Text, txtPasswordU1.Text,
                            txtNameU.Text, txtLastNameU.Text, txtAddressU.Text, url, "sp_insert_tbl_user");

                        if (user.insert_user() == true)
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
                        class_user user = new class_user(txtIdU1.Text, txtIdU2.Text, txtUserU.Text, txtPasswordU1.Text,
                            txtNameU.Text, txtLastNameU.Text, txtAddressU.Text, url, "sp_update_tbl_user");

                        if (user.update_user() == true)
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
        }

        private void btnSearchU_Click(object sender, EventArgs e)
        {
            string textId = txtIdU1.Text.Trim().Replace("-", "");

            if (textId.Trim().Equals(""))
            {
                errorProvider1.SetError(txtIdU1, "Please, fill in the following information: " + "ID");
            }
            else
            {
                errorProvider1.SetError(txtIdU1, "");

                class_user user = new class_user(txtIdU1.Text, url, "sp_select_tbl_user");

                if (user.select_userId() != null)
                {
                    String[] arr = new string[10];
                    int i = 0;

                    user = new class_user(txtIdU1.Text, url, "sp_select_tbl_user");

                    foreach (String rs in user.select_userId())
                    {
                        arr[i] = rs;
                        i++;
                    }

                    txtIdU2.Text = arr[0];
                    txtUserU.Text = arr[1];
                    txtNameU.Text = arr[2];
                    txtLastNameU.Text = arr[3];
                    txtAddressU.Text = arr[4];

                    after_search();
                }
                else
                {
                    MessageBox.Show("We couldn’t locate any user with the given ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnUpdateU_Click(object sender, EventArgs e)
        {
            active_txt_btn();
        }

        private void cboxPasswordU_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxPasswordU.Checked == true)
            {
                txtPasswordU1.PasswordChar = '\0';
                txtPasswordU2.PasswordChar = '\0';
            }
            else
            {
                txtPasswordU1.PasswordChar = '*';
                txtPasswordU2.PasswordChar = '*';
            }
        }

        private void txtIdU1_Click(object sender, EventArgs e)
        {
            txtIdU1.SelectionStart = 0;
            txtIdU1.SelectionLength = 0;
        }

        private void txtIdU2_Click(object sender, EventArgs e)
        {
            txtIdU2.SelectionStart = 0;
            txtIdU2.SelectionLength = 0;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
