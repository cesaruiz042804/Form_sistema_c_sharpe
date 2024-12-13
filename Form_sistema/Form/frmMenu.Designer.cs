namespace Form_sistema
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            panel2 = new Panel();
            panelSettings = new Panel();
            btnHelp = new FontAwesome.Sharp.IconButton();
            btnLanguage = new FontAwesome.Sharp.IconButton();
            btnTheme = new FontAwesome.Sharp.IconButton();
            btnMenuSettings = new FontAwesome.Sharp.IconButton();
            panelSpreadsheet = new Panel();
            btnDeleteSp = new FontAwesome.Sharp.IconButton();
            btnTotalSp = new FontAwesome.Sharp.IconButton();
            btnAddEmployeeSp = new FontAwesome.Sharp.IconButton();
            btnPayrollTotals = new FontAwesome.Sharp.IconButton();
            btnCreateSpreasheet = new FontAwesome.Sharp.IconButton();
            btnMenuSpreadsheet = new FontAwesome.Sharp.IconButton();
            panelEmployee = new Panel();
            btnTableEmployee = new FontAwesome.Sharp.IconButton();
            btnDeleteEmployee = new FontAwesome.Sharp.IconButton();
            btnAddEmployees = new FontAwesome.Sharp.IconButton();
            btnMenuEmployee = new FontAwesome.Sharp.IconButton();
            panelUser = new Panel();
            btnTableUser = new FontAwesome.Sharp.IconButton();
            ibtnDeleteUser = new FontAwesome.Sharp.IconButton();
            btnAddUser = new FontAwesome.Sharp.IconButton();
            btnMenuUser = new FontAwesome.Sharp.IconButton();
            icon1 = new FontAwesome.Sharp.IconButton();
            lblTime = new Label();
            gunaUser = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            gunaEmployee = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            gunaEmpPay = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            gunaPayroll = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panelGuna = new Panel();
            btnAddEmployee = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panelSettings.SuspendLayout();
            panelSpreadsheet.SuspendLayout();
            panelEmployee.SuspendLayout();
            panelUser.SuspendLayout();
            panelGuna.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panelSettings);
            panel1.Controls.Add(btnMenuSettings);
            panel1.Controls.Add(panelSpreadsheet);
            panel1.Controls.Add(btnMenuSpreadsheet);
            panel1.Controls.Add(panelEmployee);
            panel1.Controls.Add(btnMenuEmployee);
            panel1.Controls.Add(panelUser);
            panel1.Controls.Add(btnMenuUser);
            panel1.Controls.Add(icon1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 591);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 761);
            panel2.Name = "panel2";
            panel2.Size = new Size(273, 0);
            panel2.TabIndex = 39;
            // 
            // panelSettings
            // 
            panelSettings.Controls.Add(btnHelp);
            panelSettings.Controls.Add(btnLanguage);
            panelSettings.Controls.Add(btnTheme);
            panelSettings.Dock = DockStyle.Top;
            panelSettings.Location = new Point(0, 635);
            panelSettings.Name = "panelSettings";
            panelSettings.Size = new Size(273, 126);
            panelSettings.TabIndex = 38;
            // 
            // btnHelp
            // 
            btnHelp.BackColor = Color.SteelBlue;
            btnHelp.Dock = DockStyle.Top;
            btnHelp.FlatAppearance.BorderColor = Color.SteelBlue;
            btnHelp.FlatAppearance.BorderSize = 0;
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            btnHelp.ForeColor = Color.White;
            btnHelp.IconChar = FontAwesome.Sharp.IconChar.Info;
            btnHelp.IconColor = Color.White;
            btnHelp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHelp.IconSize = 25;
            btnHelp.ImageAlign = ContentAlignment.MiddleLeft;
            btnHelp.Location = new Point(0, 68);
            btnHelp.Name = "btnHelp";
            btnHelp.Padding = new Padding(25, 0, 0, 0);
            btnHelp.Size = new Size(273, 34);
            btnHelp.TabIndex = 16;
            btnHelp.Text = "Help";
            btnHelp.TextAlign = ContentAlignment.MiddleLeft;
            btnHelp.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;
            // 
            // btnLanguage
            // 
            btnLanguage.BackColor = Color.SteelBlue;
            btnLanguage.Dock = DockStyle.Top;
            btnLanguage.FlatAppearance.BorderColor = Color.SteelBlue;
            btnLanguage.FlatAppearance.BorderSize = 0;
            btnLanguage.FlatStyle = FlatStyle.Flat;
            btnLanguage.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            btnLanguage.ForeColor = Color.White;
            btnLanguage.IconChar = FontAwesome.Sharp.IconChar.Globe;
            btnLanguage.IconColor = Color.White;
            btnLanguage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLanguage.IconSize = 25;
            btnLanguage.ImageAlign = ContentAlignment.MiddleLeft;
            btnLanguage.Location = new Point(0, 34);
            btnLanguage.Name = "btnLanguage";
            btnLanguage.Padding = new Padding(25, 0, 0, 0);
            btnLanguage.Size = new Size(273, 34);
            btnLanguage.TabIndex = 15;
            btnLanguage.Text = "Language";
            btnLanguage.TextAlign = ContentAlignment.MiddleLeft;
            btnLanguage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLanguage.UseVisualStyleBackColor = false;
            btnLanguage.Click += btnLanguage_Click;
            // 
            // btnTheme
            // 
            btnTheme.BackColor = Color.SteelBlue;
            btnTheme.Dock = DockStyle.Top;
            btnTheme.FlatAppearance.BorderColor = Color.SteelBlue;
            btnTheme.FlatAppearance.BorderSize = 0;
            btnTheme.FlatStyle = FlatStyle.Flat;
            btnTheme.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            btnTheme.ForeColor = Color.White;
            btnTheme.IconChar = FontAwesome.Sharp.IconChar.CircleHalfStroke;
            btnTheme.IconColor = Color.White;
            btnTheme.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTheme.IconSize = 25;
            btnTheme.ImageAlign = ContentAlignment.MiddleLeft;
            btnTheme.Location = new Point(0, 0);
            btnTheme.Name = "btnTheme";
            btnTheme.Padding = new Padding(25, 0, 0, 0);
            btnTheme.Size = new Size(273, 34);
            btnTheme.TabIndex = 14;
            btnTheme.Text = "Theme - dark mode";
            btnTheme.TextAlign = ContentAlignment.MiddleLeft;
            btnTheme.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTheme.UseVisualStyleBackColor = false;
            btnTheme.Click += btnTheme_Click_1;
            // 
            // btnMenuSettings
            // 
            btnMenuSettings.BackColor = Color.SteelBlue;
            btnMenuSettings.Dock = DockStyle.Top;
            btnMenuSettings.FlatAppearance.BorderColor = Color.SteelBlue;
            btnMenuSettings.FlatAppearance.BorderSize = 0;
            btnMenuSettings.FlatStyle = FlatStyle.Flat;
            btnMenuSettings.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            btnMenuSettings.ForeColor = Color.White;
            btnMenuSettings.IconChar = FontAwesome.Sharp.IconChar.Tools;
            btnMenuSettings.IconColor = Color.White;
            btnMenuSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenuSettings.IconSize = 25;
            btnMenuSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuSettings.Location = new Point(0, 601);
            btnMenuSettings.Name = "btnMenuSettings";
            btnMenuSettings.Size = new Size(273, 34);
            btnMenuSettings.TabIndex = 37;
            btnMenuSettings.Text = "Settings";
            btnMenuSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuSettings.UseVisualStyleBackColor = false;
            btnMenuSettings.Click += btnMenuSettings_Click;
            // 
            // panelSpreadsheet
            // 
            panelSpreadsheet.Controls.Add(btnDeleteSp);
            panelSpreadsheet.Controls.Add(btnTotalSp);
            panelSpreadsheet.Controls.Add(btnAddEmployeeSp);
            panelSpreadsheet.Controls.Add(btnPayrollTotals);
            panelSpreadsheet.Controls.Add(btnCreateSpreasheet);
            panelSpreadsheet.Dock = DockStyle.Top;
            panelSpreadsheet.Location = new Point(0, 414);
            panelSpreadsheet.Name = "panelSpreadsheet";
            panelSpreadsheet.Size = new Size(273, 187);
            panelSpreadsheet.TabIndex = 36;
            // 
            // btnDeleteSp
            // 
            btnDeleteSp.BackColor = Color.SteelBlue;
            btnDeleteSp.Dock = DockStyle.Top;
            btnDeleteSp.FlatAppearance.BorderColor = Color.SteelBlue;
            btnDeleteSp.FlatAppearance.BorderSize = 0;
            btnDeleteSp.FlatStyle = FlatStyle.Flat;
            btnDeleteSp.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            btnDeleteSp.ForeColor = Color.White;
            btnDeleteSp.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            btnDeleteSp.IconColor = Color.White;
            btnDeleteSp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDeleteSp.IconSize = 25;
            btnDeleteSp.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteSp.Location = new Point(0, 136);
            btnDeleteSp.Name = "btnDeleteSp";
            btnDeleteSp.Padding = new Padding(25, 0, 0, 0);
            btnDeleteSp.Rotation = 180D;
            btnDeleteSp.Size = new Size(273, 34);
            btnDeleteSp.TabIndex = 16;
            btnDeleteSp.Text = "Delete payroll";
            btnDeleteSp.TextAlign = ContentAlignment.MiddleLeft;
            btnDeleteSp.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeleteSp.UseVisualStyleBackColor = false;
            // 
            // btnTotalSp
            // 
            btnTotalSp.BackColor = Color.SteelBlue;
            btnTotalSp.Dock = DockStyle.Top;
            btnTotalSp.FlatAppearance.BorderColor = Color.SteelBlue;
            btnTotalSp.FlatAppearance.BorderSize = 0;
            btnTotalSp.FlatStyle = FlatStyle.Flat;
            btnTotalSp.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            btnTotalSp.ForeColor = Color.White;
            btnTotalSp.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            btnTotalSp.IconColor = Color.White;
            btnTotalSp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTotalSp.IconSize = 25;
            btnTotalSp.ImageAlign = ContentAlignment.MiddleLeft;
            btnTotalSp.Location = new Point(0, 102);
            btnTotalSp.Name = "btnTotalSp";
            btnTotalSp.Padding = new Padding(25, 0, 0, 0);
            btnTotalSp.Size = new Size(273, 34);
            btnTotalSp.TabIndex = 15;
            btnTotalSp.Text = "Total payroll";
            btnTotalSp.TextAlign = ContentAlignment.MiddleLeft;
            btnTotalSp.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTotalSp.UseVisualStyleBackColor = false;
            btnTotalSp.Click += btnTotalSp_Click;
            // 
            // btnAddEmployeeSp
            // 
            btnAddEmployeeSp.BackColor = Color.SteelBlue;
            btnAddEmployeeSp.Dock = DockStyle.Top;
            btnAddEmployeeSp.FlatAppearance.BorderColor = Color.SteelBlue;
            btnAddEmployeeSp.FlatAppearance.BorderSize = 0;
            btnAddEmployeeSp.FlatStyle = FlatStyle.Flat;
            btnAddEmployeeSp.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            btnAddEmployeeSp.ForeColor = Color.White;
            btnAddEmployeeSp.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            btnAddEmployeeSp.IconColor = Color.White;
            btnAddEmployeeSp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddEmployeeSp.IconSize = 25;
            btnAddEmployeeSp.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddEmployeeSp.Location = new Point(0, 68);
            btnAddEmployeeSp.Name = "btnAddEmployeeSp";
            btnAddEmployeeSp.Padding = new Padding(25, 0, 0, 0);
            btnAddEmployeeSp.Size = new Size(273, 34);
            btnAddEmployeeSp.TabIndex = 14;
            btnAddEmployeeSp.Text = "Add employee payroll";
            btnAddEmployeeSp.TextAlign = ContentAlignment.MiddleLeft;
            btnAddEmployeeSp.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddEmployeeSp.UseVisualStyleBackColor = false;
            btnAddEmployeeSp.Click += btnAddEmployeeSp_Click;
            // 
            // btnPayrollTotals
            // 
            btnPayrollTotals.BackColor = Color.SteelBlue;
            btnPayrollTotals.Dock = DockStyle.Top;
            btnPayrollTotals.FlatAppearance.BorderColor = Color.SteelBlue;
            btnPayrollTotals.FlatAppearance.BorderSize = 0;
            btnPayrollTotals.FlatStyle = FlatStyle.Flat;
            btnPayrollTotals.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            btnPayrollTotals.ForeColor = Color.White;
            btnPayrollTotals.IconChar = FontAwesome.Sharp.IconChar.SquarePollHorizontal;
            btnPayrollTotals.IconColor = Color.White;
            btnPayrollTotals.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPayrollTotals.IconSize = 25;
            btnPayrollTotals.ImageAlign = ContentAlignment.MiddleLeft;
            btnPayrollTotals.Location = new Point(0, 34);
            btnPayrollTotals.Name = "btnPayrollTotals";
            btnPayrollTotals.Padding = new Padding(25, 0, 0, 0);
            btnPayrollTotals.Rotation = 270D;
            btnPayrollTotals.Size = new Size(273, 34);
            btnPayrollTotals.TabIndex = 13;
            btnPayrollTotals.Text = "Payroll Totals by Date and Sheet";
            btnPayrollTotals.TextAlign = ContentAlignment.MiddleLeft;
            btnPayrollTotals.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPayrollTotals.UseVisualStyleBackColor = false;
            btnPayrollTotals.Click += btnPayrollTotals_Click;
            // 
            // btnCreateSpreasheet
            // 
            btnCreateSpreasheet.BackColor = Color.SteelBlue;
            btnCreateSpreasheet.Dock = DockStyle.Top;
            btnCreateSpreasheet.FlatAppearance.BorderColor = Color.SteelBlue;
            btnCreateSpreasheet.FlatAppearance.BorderSize = 0;
            btnCreateSpreasheet.FlatStyle = FlatStyle.Flat;
            btnCreateSpreasheet.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            btnCreateSpreasheet.ForeColor = Color.White;
            btnCreateSpreasheet.IconChar = FontAwesome.Sharp.IconChar.FolderPlus;
            btnCreateSpreasheet.IconColor = Color.White;
            btnCreateSpreasheet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCreateSpreasheet.IconSize = 25;
            btnCreateSpreasheet.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateSpreasheet.Location = new Point(0, 0);
            btnCreateSpreasheet.Name = "btnCreateSpreasheet";
            btnCreateSpreasheet.Padding = new Padding(25, 0, 0, 0);
            btnCreateSpreasheet.Size = new Size(273, 34);
            btnCreateSpreasheet.TabIndex = 12;
            btnCreateSpreasheet.Text = "Create";
            btnCreateSpreasheet.TextAlign = ContentAlignment.MiddleLeft;
            btnCreateSpreasheet.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCreateSpreasheet.UseVisualStyleBackColor = false;
            btnCreateSpreasheet.Click += btnCreateSpreasheet_Click;
            // 
            // btnMenuSpreadsheet
            // 
            btnMenuSpreadsheet.BackColor = Color.SteelBlue;
            btnMenuSpreadsheet.Dock = DockStyle.Top;
            btnMenuSpreadsheet.FlatAppearance.BorderColor = Color.SteelBlue;
            btnMenuSpreadsheet.FlatAppearance.BorderSize = 0;
            btnMenuSpreadsheet.FlatStyle = FlatStyle.Flat;
            btnMenuSpreadsheet.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            btnMenuSpreadsheet.ForeColor = Color.White;
            btnMenuSpreadsheet.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            btnMenuSpreadsheet.IconColor = Color.White;
            btnMenuSpreadsheet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenuSpreadsheet.IconSize = 25;
            btnMenuSpreadsheet.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuSpreadsheet.Location = new Point(0, 380);
            btnMenuSpreadsheet.Name = "btnMenuSpreadsheet";
            btnMenuSpreadsheet.Size = new Size(273, 34);
            btnMenuSpreadsheet.TabIndex = 35;
            btnMenuSpreadsheet.Text = "Payroll";
            btnMenuSpreadsheet.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuSpreadsheet.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuSpreadsheet.UseVisualStyleBackColor = false;
            btnMenuSpreadsheet.Click += btnMenuSpreadsheet_Click;
            // 
            // panelEmployee
            // 
            panelEmployee.Controls.Add(btnTableEmployee);
            panelEmployee.Controls.Add(btnDeleteEmployee);
            panelEmployee.Controls.Add(btnAddEmployees);
            panelEmployee.Dock = DockStyle.Top;
            panelEmployee.Location = new Point(0, 258);
            panelEmployee.Name = "panelEmployee";
            panelEmployee.Size = new Size(273, 122);
            panelEmployee.TabIndex = 34;
            // 
            // btnTableEmployee
            // 
            btnTableEmployee.BackColor = Color.SteelBlue;
            btnTableEmployee.Dock = DockStyle.Top;
            btnTableEmployee.FlatAppearance.BorderColor = Color.SteelBlue;
            btnTableEmployee.FlatAppearance.BorderSize = 0;
            btnTableEmployee.FlatStyle = FlatStyle.Flat;
            btnTableEmployee.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            btnTableEmployee.ForeColor = Color.White;
            btnTableEmployee.IconChar = FontAwesome.Sharp.IconChar.Table;
            btnTableEmployee.IconColor = Color.White;
            btnTableEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTableEmployee.IconSize = 25;
            btnTableEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            btnTableEmployee.Location = new Point(0, 68);
            btnTableEmployee.Name = "btnTableEmployee";
            btnTableEmployee.Padding = new Padding(25, 0, 0, 0);
            btnTableEmployee.Size = new Size(273, 34);
            btnTableEmployee.TabIndex = 24;
            btnTableEmployee.Text = "Table - Employee registration";
            btnTableEmployee.TextAlign = ContentAlignment.MiddleLeft;
            btnTableEmployee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTableEmployee.UseVisualStyleBackColor = false;
            btnTableEmployee.Click += btnTableEmployee_Click;
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.BackColor = Color.SteelBlue;
            btnDeleteEmployee.Dock = DockStyle.Top;
            btnDeleteEmployee.FlatAppearance.BorderColor = Color.SteelBlue;
            btnDeleteEmployee.FlatAppearance.BorderSize = 0;
            btnDeleteEmployee.FlatStyle = FlatStyle.Flat;
            btnDeleteEmployee.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            btnDeleteEmployee.ForeColor = Color.White;
            btnDeleteEmployee.IconChar = FontAwesome.Sharp.IconChar.UserXmark;
            btnDeleteEmployee.IconColor = Color.White;
            btnDeleteEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDeleteEmployee.IconSize = 25;
            btnDeleteEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteEmployee.Location = new Point(0, 34);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Padding = new Padding(25, 0, 0, 0);
            btnDeleteEmployee.Size = new Size(273, 34);
            btnDeleteEmployee.TabIndex = 23;
            btnDeleteEmployee.Text = "Delete employee";
            btnDeleteEmployee.TextAlign = ContentAlignment.MiddleLeft;
            btnDeleteEmployee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeleteEmployee.UseVisualStyleBackColor = false;
            btnDeleteEmployee.Click += btnDeleteEmployee_Click;
            // 
            // btnAddEmployees
            // 
            btnAddEmployees.BackColor = Color.SteelBlue;
            btnAddEmployees.Dock = DockStyle.Top;
            btnAddEmployees.FlatAppearance.BorderColor = Color.SteelBlue;
            btnAddEmployees.FlatAppearance.BorderSize = 0;
            btnAddEmployees.FlatStyle = FlatStyle.Flat;
            btnAddEmployees.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            btnAddEmployees.ForeColor = Color.White;
            btnAddEmployees.IconChar = FontAwesome.Sharp.IconChar.PenRuler;
            btnAddEmployees.IconColor = Color.White;
            btnAddEmployees.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddEmployees.IconSize = 25;
            btnAddEmployees.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddEmployees.Location = new Point(0, 0);
            btnAddEmployees.Name = "btnAddEmployees";
            btnAddEmployees.Padding = new Padding(25, 0, 0, 0);
            btnAddEmployees.Size = new Size(273, 34);
            btnAddEmployees.TabIndex = 22;
            btnAddEmployees.Text = "Add or update data";
            btnAddEmployees.TextAlign = ContentAlignment.MiddleLeft;
            btnAddEmployees.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddEmployees.UseVisualStyleBackColor = false;
            btnAddEmployees.Click += btnAddEmployees_Click;
            // 
            // btnMenuEmployee
            // 
            btnMenuEmployee.BackColor = Color.SteelBlue;
            btnMenuEmployee.Dock = DockStyle.Top;
            btnMenuEmployee.FlatAppearance.BorderColor = Color.SteelBlue;
            btnMenuEmployee.FlatAppearance.BorderSize = 0;
            btnMenuEmployee.FlatStyle = FlatStyle.Flat;
            btnMenuEmployee.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            btnMenuEmployee.ForeColor = Color.White;
            btnMenuEmployee.IconChar = FontAwesome.Sharp.IconChar.Users;
            btnMenuEmployee.IconColor = Color.White;
            btnMenuEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenuEmployee.IconSize = 25;
            btnMenuEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuEmployee.Location = new Point(0, 224);
            btnMenuEmployee.Name = "btnMenuEmployee";
            btnMenuEmployee.Size = new Size(273, 34);
            btnMenuEmployee.TabIndex = 33;
            btnMenuEmployee.Text = "Employee";
            btnMenuEmployee.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuEmployee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuEmployee.UseVisualStyleBackColor = false;
            btnMenuEmployee.Click += btnMenuEmployee_Click;
            // 
            // panelUser
            // 
            panelUser.Controls.Add(btnTableUser);
            panelUser.Controls.Add(ibtnDeleteUser);
            panelUser.Controls.Add(btnAddUser);
            panelUser.Dock = DockStyle.Top;
            panelUser.Location = new Point(0, 103);
            panelUser.Name = "panelUser";
            panelUser.Size = new Size(273, 121);
            panelUser.TabIndex = 32;
            // 
            // btnTableUser
            // 
            btnTableUser.BackColor = Color.SteelBlue;
            btnTableUser.Dock = DockStyle.Top;
            btnTableUser.FlatAppearance.BorderColor = Color.SteelBlue;
            btnTableUser.FlatAppearance.BorderSize = 0;
            btnTableUser.FlatStyle = FlatStyle.Flat;
            btnTableUser.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            btnTableUser.ForeColor = Color.White;
            btnTableUser.IconChar = FontAwesome.Sharp.IconChar.Table;
            btnTableUser.IconColor = Color.White;
            btnTableUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTableUser.IconSize = 25;
            btnTableUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnTableUser.Location = new Point(0, 68);
            btnTableUser.Name = "btnTableUser";
            btnTableUser.Padding = new Padding(25, 0, 0, 0);
            btnTableUser.Size = new Size(273, 34);
            btnTableUser.TabIndex = 23;
            btnTableUser.Text = "Table - User registration";
            btnTableUser.TextAlign = ContentAlignment.MiddleLeft;
            btnTableUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTableUser.UseVisualStyleBackColor = false;
            btnTableUser.Click += btnTableUser_Click;
            // 
            // ibtnDeleteUser
            // 
            ibtnDeleteUser.BackColor = Color.SteelBlue;
            ibtnDeleteUser.Dock = DockStyle.Top;
            ibtnDeleteUser.FlatAppearance.BorderColor = Color.SteelBlue;
            ibtnDeleteUser.FlatAppearance.BorderSize = 0;
            ibtnDeleteUser.FlatStyle = FlatStyle.Flat;
            ibtnDeleteUser.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            ibtnDeleteUser.ForeColor = Color.White;
            ibtnDeleteUser.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            ibtnDeleteUser.IconColor = Color.White;
            ibtnDeleteUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnDeleteUser.IconSize = 25;
            ibtnDeleteUser.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnDeleteUser.Location = new Point(0, 34);
            ibtnDeleteUser.Name = "ibtnDeleteUser";
            ibtnDeleteUser.Padding = new Padding(25, 0, 0, 0);
            ibtnDeleteUser.Size = new Size(273, 34);
            ibtnDeleteUser.TabIndex = 22;
            ibtnDeleteUser.Text = "Delete user";
            ibtnDeleteUser.TextAlign = ContentAlignment.MiddleLeft;
            ibtnDeleteUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnDeleteUser.UseVisualStyleBackColor = false;
            ibtnDeleteUser.Click += ibtnDeleteUser_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.SteelBlue;
            btnAddUser.Dock = DockStyle.Top;
            btnAddUser.FlatAppearance.BorderColor = Color.SteelBlue;
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            btnAddUser.ForeColor = Color.White;
            btnAddUser.IconChar = FontAwesome.Sharp.IconChar.PenNib;
            btnAddUser.IconColor = Color.White;
            btnAddUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddUser.IconSize = 25;
            btnAddUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddUser.Location = new Point(0, 0);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Padding = new Padding(25, 0, 0, 0);
            btnAddUser.Size = new Size(273, 34);
            btnAddUser.TabIndex = 21;
            btnAddUser.Text = "Add or update data";
            btnAddUser.TextAlign = ContentAlignment.MiddleLeft;
            btnAddUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnMenuUser
            // 
            btnMenuUser.BackColor = Color.SteelBlue;
            btnMenuUser.Dock = DockStyle.Top;
            btnMenuUser.FlatAppearance.BorderColor = Color.SteelBlue;
            btnMenuUser.FlatAppearance.BorderSize = 0;
            btnMenuUser.FlatStyle = FlatStyle.Flat;
            btnMenuUser.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            btnMenuUser.ForeColor = Color.White;
            btnMenuUser.IconChar = FontAwesome.Sharp.IconChar.User;
            btnMenuUser.IconColor = Color.White;
            btnMenuUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenuUser.IconSize = 25;
            btnMenuUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuUser.Location = new Point(0, 69);
            btnMenuUser.Name = "btnMenuUser";
            btnMenuUser.Size = new Size(273, 34);
            btnMenuUser.TabIndex = 31;
            btnMenuUser.Text = "User";
            btnMenuUser.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuUser.UseVisualStyleBackColor = false;
            btnMenuUser.Click += btnMenuUser_Click;
            // 
            // icon1
            // 
            icon1.BackColor = Color.SteelBlue;
            icon1.Dock = DockStyle.Top;
            icon1.FlatAppearance.BorderColor = Color.SteelBlue;
            icon1.FlatAppearance.BorderSize = 0;
            icon1.FlatStyle = FlatStyle.Flat;
            icon1.Font = new Font("Arial Narrow", 16.25F, FontStyle.Bold);
            icon1.ForeColor = Color.White;
            icon1.IconChar = FontAwesome.Sharp.IconChar.Bars;
            icon1.IconColor = Color.White;
            icon1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon1.IconSize = 25;
            icon1.ImageAlign = ContentAlignment.MiddleLeft;
            icon1.Location = new Point(0, 0);
            icon1.Name = "icon1";
            icon1.Size = new Size(273, 69);
            icon1.TabIndex = 30;
            icon1.Text = "Menu";
            icon1.TextAlign = ContentAlignment.MiddleLeft;
            icon1.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon1.UseVisualStyleBackColor = false;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Arial", 60.25F, FontStyle.Bold);
            lblTime.ForeColor = Color.DarkGray;
            lblTime.Location = new Point(90, 473);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(364, 95);
            lblTime.TabIndex = 0;
            lblTime.Text = "12:60:59";
            lblTime.Click += label1_Click;
            // 
            // gunaUser
            // 
            gunaUser.AnimationSpeed = 0.9F;
            gunaUser.BackColor = Color.Transparent;
            gunaUser.FillColor = Color.FromArgb(200, 213, 218, 223);
            gunaUser.FillThickness = 25;
            gunaUser.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            gunaUser.ForeColor = Color.DodgerBlue;
            gunaUser.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            gunaUser.Location = new Point(69, 54);
            gunaUser.Maximum = 50;
            gunaUser.Minimum = 0;
            gunaUser.Name = "gunaUser";
            gunaUser.ProgressColor = Color.DodgerBlue;
            gunaUser.ProgressColor2 = Color.LightGray;
            gunaUser.ProgressThickness = 25;
            gunaUser.ShadowDecoration.CustomizableEdges = customizableEdges1;
            gunaUser.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            gunaUser.ShowText = true;
            gunaUser.Size = new Size(130, 130);
            gunaUser.TabIndex = 1;
            gunaUser.Tag = "";
            gunaUser.Text = "User";
            gunaUser.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Value;
            gunaUser.UseTransparentBackground = true;
            gunaUser.Value = 25;
            // 
            // gunaEmployee
            // 
            gunaEmployee.AnimationSpeed = 0.9F;
            gunaEmployee.BackColor = Color.Transparent;
            gunaEmployee.FillColor = Color.FromArgb(200, 213, 218, 223);
            gunaEmployee.FillThickness = 25;
            gunaEmployee.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            gunaEmployee.ForeColor = Color.DodgerBlue;
            gunaEmployee.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            gunaEmployee.Location = new Point(324, 54);
            gunaEmployee.Maximum = 50;
            gunaEmployee.Minimum = 0;
            gunaEmployee.Name = "gunaEmployee";
            gunaEmployee.ProgressColor = Color.DodgerBlue;
            gunaEmployee.ProgressColor2 = Color.LightGray;
            gunaEmployee.ProgressThickness = 25;
            gunaEmployee.ShadowDecoration.CustomizableEdges = customizableEdges2;
            gunaEmployee.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            gunaEmployee.ShowText = true;
            gunaEmployee.Size = new Size(130, 130);
            gunaEmployee.TabIndex = 2;
            gunaEmployee.Tag = "";
            gunaEmployee.Text = "Employee";
            gunaEmployee.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Value;
            gunaEmployee.UseTransparentBackground = true;
            gunaEmployee.Value = 25;
            // 
            // gunaEmpPay
            // 
            gunaEmpPay.AnimationSpeed = 0.9F;
            gunaEmpPay.BackColor = Color.Transparent;
            gunaEmpPay.FillColor = Color.FromArgb(200, 213, 218, 223);
            gunaEmpPay.FillThickness = 25;
            gunaEmpPay.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            gunaEmpPay.ForeColor = Color.DodgerBlue;
            gunaEmpPay.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            gunaEmpPay.Location = new Point(324, 264);
            gunaEmpPay.Maximum = 50;
            gunaEmpPay.Minimum = 0;
            gunaEmpPay.Name = "gunaEmpPay";
            gunaEmpPay.ProgressColor = Color.DodgerBlue;
            gunaEmpPay.ProgressColor2 = Color.LightGray;
            gunaEmpPay.ProgressThickness = 25;
            gunaEmpPay.ShadowDecoration.CustomizableEdges = customizableEdges3;
            gunaEmpPay.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            gunaEmpPay.ShowText = true;
            gunaEmpPay.Size = new Size(130, 130);
            gunaEmpPay.TabIndex = 2;
            gunaEmpPay.Tag = "";
            gunaEmpPay.Text = "Payroll";
            gunaEmpPay.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Value;
            gunaEmpPay.UseTransparentBackground = true;
            gunaEmpPay.Value = 25;
            // 
            // gunaPayroll
            // 
            gunaPayroll.AnimationSpeed = 0.9F;
            gunaPayroll.BackColor = Color.Transparent;
            gunaPayroll.FillColor = Color.FromArgb(200, 213, 218, 223);
            gunaPayroll.FillThickness = 25;
            gunaPayroll.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            gunaPayroll.ForeColor = Color.DodgerBlue;
            gunaPayroll.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            gunaPayroll.Location = new Point(69, 264);
            gunaPayroll.Maximum = 50;
            gunaPayroll.Minimum = 0;
            gunaPayroll.Name = "gunaPayroll";
            gunaPayroll.ProgressColor = Color.DodgerBlue;
            gunaPayroll.ProgressColor2 = Color.LightGray;
            gunaPayroll.ProgressThickness = 25;
            gunaPayroll.ShadowDecoration.CustomizableEdges = customizableEdges4;
            gunaPayroll.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            gunaPayroll.ShowText = true;
            gunaPayroll.Size = new Size(130, 130);
            gunaPayroll.TabIndex = 3;
            gunaPayroll.Tag = "";
            gunaPayroll.Text = "kjn";
            gunaPayroll.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Value;
            gunaPayroll.UseTransparentBackground = true;
            gunaPayroll.Value = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(116, 204);
            label2.Name = "label2";
            label2.Size = new Size(45, 23);
            label2.TabIndex = 6;
            label2.Text = "User";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(350, 204);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 7;
            label3.Text = "Employee";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(299, 414);
            label4.Name = "label4";
            label4.Size = new Size(174, 23);
            label4.TabIndex = 8;
            label4.Text = "Employees on payroll";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(105, 414);
            label5.Name = "label5";
            label5.Size = new Size(62, 23);
            label5.TabIndex = 9;
            label5.Text = "Payroll";
            // 
            // panelGuna
            // 
            panelGuna.Controls.Add(lblTime);
            panelGuna.Controls.Add(gunaUser);
            panelGuna.Controls.Add(label5);
            panelGuna.Controls.Add(gunaEmployee);
            panelGuna.Controls.Add(label4);
            panelGuna.Controls.Add(gunaEmpPay);
            panelGuna.Controls.Add(label3);
            panelGuna.Controls.Add(gunaPayroll);
            panelGuna.Controls.Add(label2);
            panelGuna.Dock = DockStyle.Fill;
            panelGuna.Location = new Point(290, 0);
            panelGuna.Name = "panelGuna";
            panelGuna.Size = new Size(546, 591);
            panelGuna.TabIndex = 10;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.SteelBlue;
            btnAddEmployee.Dock = DockStyle.Top;
            btnAddEmployee.FlatAppearance.BorderColor = Color.SteelBlue;
            btnAddEmployee.FlatAppearance.BorderSize = 0;
            btnAddEmployee.FlatStyle = FlatStyle.Flat;
            btnAddEmployee.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            btnAddEmployee.ForeColor = Color.White;
            btnAddEmployee.IconChar = FontAwesome.Sharp.IconChar.PenNib;
            btnAddEmployee.IconColor = Color.White;
            btnAddEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddEmployee.IconSize = 25;
            btnAddEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddEmployee.Location = new Point(0, 34);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Padding = new Padding(25, 0, 0, 0);
            btnAddEmployee.Size = new Size(290, 34);
            btnAddEmployee.TabIndex = 21;
            btnAddEmployee.Text = "Add or update data";
            btnAddEmployee.TextAlign = ContentAlignment.MiddleLeft;
            btnAddEmployee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddEmployee.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.SteelBlue;
            iconButton3.Dock = DockStyle.Top;
            iconButton3.FlatAppearance.BorderColor = Color.SteelBlue;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.UserXmark;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 25;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(0, 68);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new Padding(25, 0, 0, 0);
            iconButton3.Size = new Size(290, 34);
            iconButton3.TabIndex = 22;
            iconButton3.Text = "Delete employee";
            iconButton3.TextAlign = ContentAlignment.MiddleLeft;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.SteelBlue;
            iconButton4.Dock = DockStyle.Top;
            iconButton4.FlatAppearance.BorderColor = Color.SteelBlue;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            iconButton4.ForeColor = Color.White;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Table;
            iconButton4.IconColor = Color.White;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 25;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(0, 102);
            iconButton4.Name = "iconButton4";
            iconButton4.Padding = new Padding(25, 0, 0, 0);
            iconButton4.Size = new Size(290, 34);
            iconButton4.TabIndex = 23;
            iconButton4.Text = "Employee Registration";
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 591);
            Controls.Add(panelGuna);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlDarkDark;
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += frmMenu_Load;
            panel1.ResumeLayout(false);
            panelSettings.ResumeLayout(false);
            panelSpreadsheet.ResumeLayout(false);
            panelEmployee.ResumeLayout(false);
            panelUser.ResumeLayout(false);
            panelGuna.ResumeLayout(false);
            panelGuna.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar gunaUser;
        private Guna.UI2.WinForms.Guna2CircleProgressBar gunaEmployee;
        private Guna.UI2.WinForms.Guna2CircleProgressBar gunaEmpPay;
        private Guna.UI2.WinForms.Guna2CircleProgressBar gunaPayroll;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panelGuna;
        private FontAwesome.Sharp.IconButton icon3;
        private FontAwesome.Sharp.IconButton icon4;
        private FontAwesome.Sharp.IconButton icon16;
        private FontAwesome.Sharp.IconButton icon19;
        private FontAwesome.Sharp.IconButton icon18;
        private FontAwesome.Sharp.IconButton icon17;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btnAddEmployee;
        private FontAwesome.Sharp.IconButton iconButton4;
        private Panel panel2;
        private Panel panelSettings;
        private FontAwesome.Sharp.IconButton btnHelp;
        private FontAwesome.Sharp.IconButton btnLanguage;
        private FontAwesome.Sharp.IconButton btnTheme;
        private FontAwesome.Sharp.IconButton btnMenuSettings;
        private Panel panelSpreadsheet;
        private FontAwesome.Sharp.IconButton btnTotalSp;
        private FontAwesome.Sharp.IconButton btnAddEmployeeSp;
        private FontAwesome.Sharp.IconButton btnPayrollTotals;
        private FontAwesome.Sharp.IconButton btnCreateSpreasheet;
        private FontAwesome.Sharp.IconButton btnMenuSpreadsheet;
        private Panel panelEmployee;
        private FontAwesome.Sharp.IconButton btnTableEmployee;
        private FontAwesome.Sharp.IconButton btnDeleteEmployee;
        private FontAwesome.Sharp.IconButton btnAddEmployees;
        private FontAwesome.Sharp.IconButton btnMenuEmployee;
        private Panel panelUser;
        private FontAwesome.Sharp.IconButton btnTableUser;
        private FontAwesome.Sharp.IconButton ibtnDeleteUser;
        private FontAwesome.Sharp.IconButton btnAddUser;
        private FontAwesome.Sharp.IconButton btnMenuUser;
        private FontAwesome.Sharp.IconButton icon1;
        private FontAwesome.Sharp.IconButton btnDeleteSp;
        private Label lblTime;
        private System.Windows.Forms.Timer timer1;
    }
}