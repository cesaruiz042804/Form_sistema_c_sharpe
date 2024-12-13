using Form_sistema.Class;

using System.Media;
using System.Text;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.VisualBasic.ApplicationServices;

namespace Form_sistema
{
    public partial class frmLogin : Form
    {
        methods m = new methods();
        string url = "Data Source=DESKTOP-GJL2Q9B\\SQLDEVELOPER;Initial Catalog=dbGestion;Integrated Security=True";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Control[] arr_control = { txtUserL, txtPasswordL };
            String[] name_box = { "txtUserL", "txtPassword" };
            String[] valor = { txtUserL.Text, txtPasswordL.Text };
            String[] words = { "User", "Password" };
            String text_box = "You cannot leave the text boxes empty in: ";

            Boolean verify = m.check_box(errorProvider1, arr_control, name_box, valor, words, text_box);

            frmMenu menu = new frmMenu();
            menu.Show();

            if (verify == true)
            {
                class_user user = new class_user(txtUserL.Text, txtPasswordL.Text, url, "sp_select_user_login");

                if (user.select_userLogin() == true)
                { 
                    txtUserL.Text = "";
                    txtPasswordL.Text = "";
                    MessageBox.Show("Your welcome", "Nice 0_0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //frmMenu menu = new frmMenu();
                    //menu.Show();
                    //SoundPlayer sound = new SoundPlayer();
                    //sound.SoundLocation = "C:/Users/User/OneDrive/Desktop/audio1.wav";
                    //sound.Play();
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Text = user.hashing(txtPasswordL.Text);
                }
            }
        }

        private void checkBox1_Validated(object sender, EventArgs e) // Esto es para poder ver el password
        {
            if (cboxPasswordL.Checked == true)
            {
                txtPasswordL.PasswordChar = '\0';
            }
            else
            {
                txtPasswordL.PasswordChar = '*';
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        } 

        private void getTextSpanish()
        {
            label1.Text = Res_SP.Login;
            label2.Text = Res_SP.User;
            txtUserL.PlaceholderText = Res_SP.User;
            label3.Text = Res_SP.Password;
            txtPasswordL.PlaceholderText = Res_SP.Password;
            label4.Text = Res_SP.Language;
            cboxPasswordL.Text = Res_SP.Show_Password;
            btnSign.Text = Res_SP.Sign_in;
        }

        private void getTextEnglish()
        {
            label1.Text = Res_EN.Login;
            label2.Text = Res_EN.User;
            txtUserL.PlaceholderText = Res_EN.User;
            label3.Text = Res_EN.Password;
            txtPasswordL.PlaceholderText = Res_EN.Password;
            label4.Text = Res_EN.Language;
            cboxPasswordL.Text = Res_EN.Show_Password;
            btnSign.Text = Res_EN.Sign_in;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmEmployee fEmployee = new frmEmployee(); 
            if (comboBox1.SelectedIndex == 0)
            {
                getTextSpanish();
                frmMenu menu = new frmMenu();
                menu.getTextSpanish();
                fEmployee.getTextSpanish();
            }
            else if (comboBox1.SelectedIndex == 1)
            {   
                getTextEnglish();
                frmMenu menu = new frmMenu();
                menu.Invalidate();
                menu.getTextEnglish();
                fEmployee.getTextEnglish();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            /*
            if (Properties.Settings.Default.Themes != "")
            {
                change_color(Properties.Settings.Default.Themes);
            }
            else
            {
                change_color("light");
            }
            */
        }

        /*
        public void change_color(String Theme)
        {
            class_theme.option_theme(Theme);

            class_color.ChangeControlsBackColor(panel1, class_theme.PanelMenuTotal);
            class_color.ChangeForeColorsBackColor(panel1, class_theme.FontColorA);

            class_color.ChangeControlsBackColor(panelLogin, class_theme.PanelGuna);
            class_color.ChangeForeColorsBackColor(panelLogin, class_theme.FontColorB);
            panelLogin.BackColor = class_theme.PanelLogin;

            class_color.ChangeButtonColorsBackColor(panelLogin, class_theme.FontColorA);
            class_color.ChangeButtonColorsForeColor(panelLogin, class_theme.PanelMenuTotal);
        }
        */
    }
}
