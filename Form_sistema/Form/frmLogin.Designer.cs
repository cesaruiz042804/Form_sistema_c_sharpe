namespace Form_sistema
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            FontAwesome.Sharp.IconPictureBox iconLogo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            label1 = new Label();
            txtUserL = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cboxPasswordL = new CheckBox();
            btnSign = new Button();
            txtPasswordL = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            panel1 = new Panel();
            panelLogin = new Panel();
            textBox1 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            iconLogo = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)iconLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel1.SuspendLayout();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // iconLogo
            // 
            iconLogo.BackColor = Color.SteelBlue;
            resources.ApplyResources(iconLogo, "iconLogo");
            iconLogo.ForeColor = Color.Azure;
            iconLogo.IconChar = FontAwesome.Sharp.IconChar.OldRepublic;
            iconLogo.IconColor = Color.Azure;
            iconLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconLogo.IconSize = 470;
            iconLogo.Name = "iconLogo";
            iconLogo.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = SystemColors.GrayText;
            label1.Name = "label1";
            // 
            // txtUserL
            // 
            resources.ApplyResources(txtUserL, "txtUserL");
            txtUserL.ForeColor = SystemColors.MenuHighlight;
            txtUserL.Name = "txtUserL";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = SystemColors.GrayText;
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = SystemColors.GrayText;
            label3.Name = "label3";
            // 
            // cboxPasswordL
            // 
            resources.ApplyResources(cboxPasswordL, "cboxPasswordL");
            cboxPasswordL.ForeColor = SystemColors.GrayText;
            cboxPasswordL.Name = "cboxPasswordL";
            cboxPasswordL.UseVisualStyleBackColor = true;
            cboxPasswordL.CheckedChanged += checkBox1_Validated;
            cboxPasswordL.Validated += checkBox1_Validated;
            // 
            // btnSign
            // 
            resources.ApplyResources(btnSign, "btnSign");
            btnSign.ForeColor = SystemColors.ControlDarkDark;
            btnSign.Name = "btnSign";
            btnSign.UseVisualStyleBackColor = true;
            btnSign.Click += button1_Click;
            // 
            // txtPasswordL
            // 
            resources.ApplyResources(txtPasswordL, "txtPasswordL");
            txtPasswordL.ForeColor = SystemColors.MenuHighlight;
            txtPasswordL.Name = "txtPasswordL";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(iconLogo);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // panelLogin
            // 
            panelLogin.Controls.Add(textBox1);
            panelLogin.Controls.Add(label4);
            panelLogin.Controls.Add(comboBox1);
            panelLogin.Controls.Add(btnSign);
            panelLogin.Controls.Add(label1);
            panelLogin.Controls.Add(txtUserL);
            panelLogin.Controls.Add(cboxPasswordL);
            panelLogin.Controls.Add(txtPasswordL);
            panelLogin.Controls.Add(label3);
            panelLogin.Controls.Add(label2);
            resources.ApplyResources(panelLogin, "panelLogin");
            panelLogin.Name = "panelLogin";
            panelLogin.Paint += panel2_Paint;
            // 
            // textBox1
            // 
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { resources.GetString("comboBox1.Items"), resources.GetString("comboBox1.Items1") });
            resources.ApplyResources(comboBox1, "comboBox1");
            comboBox1.Name = "comboBox1";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // frmLogin
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelLogin);
            Controls.Add(panel1);
            Name = "frmLogin";
            Opacity = 0.95D;
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)iconLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel1.ResumeLayout(false);
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtUserL;
        private Label label2;
        private Label label3;
        private CheckBox cboxPasswordL;
        private Button btnSign;
        private TextBox txtPasswordL;
        private ErrorProvider errorProvider1;
        private Panel panel1;
        private Panel panelLogin;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox textBox1;
    }
}
