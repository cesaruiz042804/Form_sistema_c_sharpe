namespace Form_sistema
{
    partial class Form1
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges49 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges50 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges51 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges52 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelGuna = new Panel();
            gunaUser = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            label5 = new Label();
            gunaEmployee = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            label4 = new Label();
            gunaEmpPay = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            label3 = new Label();
            gunaPayroll = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            label2 = new Label();
            panel1 = new Panel();
            icon1 = new FontAwesome.Sharp.IconButton();
            btnMenuUser = new FontAwesome.Sharp.IconButton();
            panelUser = new Panel();
            btnTableUser = new FontAwesome.Sharp.IconButton();
            ibtnDeleteUser = new FontAwesome.Sharp.IconButton();
            btnAddUser = new FontAwesome.Sharp.IconButton();
            btnMenuEmployee = new FontAwesome.Sharp.IconButton();
            panelEmployee = new Panel();
            btnTableEmployee = new FontAwesome.Sharp.IconButton();
            btnDeleteEmployee = new FontAwesome.Sharp.IconButton();
            btnAddEmployees = new FontAwesome.Sharp.IconButton();
            btnMenuSpreadsheet = new FontAwesome.Sharp.IconButton();
            panelSpreadsheet = new Panel();
            iconButton10 = new FontAwesome.Sharp.IconButton();
            btnTotalSp = new FontAwesome.Sharp.IconButton();
            btnAddEmployeeSp = new FontAwesome.Sharp.IconButton();
            btnPayrollTotals = new FontAwesome.Sharp.IconButton();
            btnCreateSpreasheet = new FontAwesome.Sharp.IconButton();
            btnMenuSettings = new FontAwesome.Sharp.IconButton();
            panelSettings = new Panel();
            btnHelp = new FontAwesome.Sharp.IconButton();
            btnLanguage = new FontAwesome.Sharp.IconButton();
            btnTheme = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            panelGuna.SuspendLayout();
            panel1.SuspendLayout();
            panelUser.SuspendLayout();
            panelEmployee.SuspendLayout();
            panelSpreadsheet.SuspendLayout();
            panelSettings.SuspendLayout();
            SuspendLayout();
            // 
            // panelGuna
            // 
            panelGuna.BackColor = Color.FromArgb(5, 5, 20);
            panelGuna.Controls.Add(gunaUser);
            panelGuna.Controls.Add(label5);
            panelGuna.Controls.Add(gunaEmployee);
            panelGuna.Controls.Add(label4);
            panelGuna.Controls.Add(gunaEmpPay);
            panelGuna.Controls.Add(label3);
            panelGuna.Controls.Add(gunaPayroll);
            panelGuna.Controls.Add(label2);
            panelGuna.Dock = DockStyle.Right;
            panelGuna.ForeColor = SystemColors.GradientActiveCaption;
            panelGuna.Location = new Point(281, 0);
            panelGuna.Name = "panelGuna";
            panelGuna.Size = new Size(546, 932);
            panelGuna.TabIndex = 11;
            // 
            // gunaUser
            // 
            gunaUser.AnimationSpeed = 0.9F;
            gunaUser.BackColor = Color.Transparent;
            gunaUser.FillColor = Color.FromArgb(200, 213, 218, 223);
            gunaUser.FillThickness = 25;
            gunaUser.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            gunaUser.ForeColor = Color.GhostWhite;
            gunaUser.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            gunaUser.Location = new Point(68, 40);
            gunaUser.Maximum = 50;
            gunaUser.Minimum = 0;
            gunaUser.Name = "gunaUser";
            gunaUser.ProgressColor = Color.RoyalBlue;
            gunaUser.ProgressColor2 = Color.Transparent;
            gunaUser.ProgressThickness = 25;
            gunaUser.ShadowDecoration.CustomizableEdges = customizableEdges49;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(220, 220, 250);
            label5.Location = new Point(104, 400);
            label5.Name = "label5";
            label5.Size = new Size(62, 23);
            label5.TabIndex = 9;
            label5.Text = "Payroll";
            // 
            // gunaEmployee
            // 
            gunaEmployee.AnimationSpeed = 0.9F;
            gunaEmployee.BackColor = Color.Transparent;
            gunaEmployee.FillColor = Color.FromArgb(200, 213, 218, 223);
            gunaEmployee.FillThickness = 25;
            gunaEmployee.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            gunaEmployee.ForeColor = Color.GhostWhite;
            gunaEmployee.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            gunaEmployee.Location = new Point(323, 40);
            gunaEmployee.Maximum = 50;
            gunaEmployee.Minimum = 0;
            gunaEmployee.Name = "gunaEmployee";
            gunaEmployee.ProgressColor = Color.RoyalBlue;
            gunaEmployee.ProgressColor2 = Color.Transparent;
            gunaEmployee.ProgressThickness = 25;
            gunaEmployee.ShadowDecoration.CustomizableEdges = customizableEdges50;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(220, 220, 250);
            label4.Location = new Point(298, 400);
            label4.Name = "label4";
            label4.Size = new Size(174, 23);
            label4.TabIndex = 8;
            label4.Text = "Employees on payroll";
            // 
            // gunaEmpPay
            // 
            gunaEmpPay.AnimationSpeed = 0.9F;
            gunaEmpPay.BackColor = Color.Transparent;
            gunaEmpPay.FillColor = Color.FromArgb(200, 213, 218, 223);
            gunaEmpPay.FillThickness = 25;
            gunaEmpPay.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            gunaEmpPay.ForeColor = Color.GhostWhite;
            gunaEmpPay.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            gunaEmpPay.Location = new Point(323, 250);
            gunaEmpPay.Maximum = 50;
            gunaEmpPay.Minimum = 0;
            gunaEmpPay.Name = "gunaEmpPay";
            gunaEmpPay.ProgressColor = Color.RoyalBlue;
            gunaEmpPay.ProgressColor2 = Color.Transparent;
            gunaEmpPay.ProgressThickness = 25;
            gunaEmpPay.ShadowDecoration.CustomizableEdges = customizableEdges51;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(220, 220, 250);
            label3.Location = new Point(349, 190);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 7;
            label3.Text = "Employee";
            // 
            // gunaPayroll
            // 
            gunaPayroll.AnimationSpeed = 0.9F;
            gunaPayroll.BackColor = Color.Transparent;
            gunaPayroll.FillColor = Color.FromArgb(200, 213, 218, 223);
            gunaPayroll.FillThickness = 25;
            gunaPayroll.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            gunaPayroll.ForeColor = Color.GhostWhite;
            gunaPayroll.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            gunaPayroll.Location = new Point(68, 250);
            gunaPayroll.Maximum = 50;
            gunaPayroll.Minimum = 0;
            gunaPayroll.Name = "gunaPayroll";
            gunaPayroll.ProgressColor = Color.RoyalBlue;
            gunaPayroll.ProgressColor2 = Color.Transparent;
            gunaPayroll.ProgressThickness = 25;
            gunaPayroll.ShadowDecoration.CustomizableEdges = customizableEdges52;
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
            label2.ForeColor = Color.FromArgb(220, 220, 250);
            label2.Location = new Point(115, 190);
            label2.Name = "label2";
            label2.Size = new Size(45, 23);
            label2.TabIndex = 6;
            label2.Text = "User";
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
            panel1.Size = new Size(290, 932);
            panel1.TabIndex = 12;
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
            icon1.Size = new Size(290, 69);
            icon1.TabIndex = 2;
            icon1.Text = "Menu";
            icon1.TextAlign = ContentAlignment.MiddleLeft;
            icon1.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon1.UseVisualStyleBackColor = false;
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
            btnMenuUser.Size = new Size(290, 34);
            btnMenuUser.TabIndex = 21;
            btnMenuUser.Text = "User";
            btnMenuUser.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuUser.UseVisualStyleBackColor = false;
            // 
            // panelUser
            // 
            panelUser.Controls.Add(btnTableUser);
            panelUser.Controls.Add(ibtnDeleteUser);
            panelUser.Controls.Add(btnAddUser);
            panelUser.Dock = DockStyle.Top;
            panelUser.Location = new Point(0, 103);
            panelUser.Name = "panelUser";
            panelUser.Size = new Size(290, 121);
            panelUser.TabIndex = 22;
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
            btnTableUser.Size = new Size(290, 34);
            btnTableUser.TabIndex = 23;
            btnTableUser.Text = "Table - User registration";
            btnTableUser.TextAlign = ContentAlignment.MiddleLeft;
            btnTableUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTableUser.UseVisualStyleBackColor = false;
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
            ibtnDeleteUser.Size = new Size(290, 34);
            ibtnDeleteUser.TabIndex = 22;
            ibtnDeleteUser.Text = "Delete user";
            ibtnDeleteUser.TextAlign = ContentAlignment.MiddleLeft;
            ibtnDeleteUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnDeleteUser.UseVisualStyleBackColor = false;
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
            btnAddUser.Size = new Size(290, 34);
            btnAddUser.TabIndex = 21;
            btnAddUser.Text = "Add or update data";
            btnAddUser.TextAlign = ContentAlignment.MiddleLeft;
            btnAddUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddUser.UseVisualStyleBackColor = false;
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
            btnMenuEmployee.Size = new Size(290, 34);
            btnMenuEmployee.TabIndex = 23;
            btnMenuEmployee.Text = "Employee";
            btnMenuEmployee.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuEmployee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuEmployee.UseVisualStyleBackColor = false;
            // 
            // panelEmployee
            // 
            panelEmployee.Controls.Add(btnTableEmployee);
            panelEmployee.Controls.Add(btnDeleteEmployee);
            panelEmployee.Controls.Add(btnAddEmployees);
            panelEmployee.Dock = DockStyle.Top;
            panelEmployee.Location = new Point(0, 258);
            panelEmployee.Name = "panelEmployee";
            panelEmployee.Size = new Size(290, 122);
            panelEmployee.TabIndex = 24;
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
            btnTableEmployee.Size = new Size(290, 34);
            btnTableEmployee.TabIndex = 24;
            btnTableEmployee.Text = "Table - Employee registration";
            btnTableEmployee.TextAlign = ContentAlignment.MiddleLeft;
            btnTableEmployee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTableEmployee.UseVisualStyleBackColor = false;
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
            btnDeleteEmployee.Size = new Size(290, 34);
            btnDeleteEmployee.TabIndex = 23;
            btnDeleteEmployee.Text = "Delete employee";
            btnDeleteEmployee.TextAlign = ContentAlignment.MiddleLeft;
            btnDeleteEmployee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeleteEmployee.UseVisualStyleBackColor = false;
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
            btnAddEmployees.Size = new Size(290, 34);
            btnAddEmployees.TabIndex = 22;
            btnAddEmployees.Text = "Add or update data";
            btnAddEmployees.TextAlign = ContentAlignment.MiddleLeft;
            btnAddEmployees.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddEmployees.UseVisualStyleBackColor = false;
            // 
            // btnMenuSpreadsheet
            // 
            btnMenuSpreadsheet.BackColor = Color.SteelBlue;
            btnMenuSpreadsheet.Dock = DockStyle.Top;
            btnMenuSpreadsheet.Enabled = false;
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
            btnMenuSpreadsheet.Size = new Size(290, 34);
            btnMenuSpreadsheet.TabIndex = 25;
            btnMenuSpreadsheet.Text = "Spreadsheet";
            btnMenuSpreadsheet.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuSpreadsheet.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuSpreadsheet.UseVisualStyleBackColor = false;
            // 
            // panelSpreadsheet
            // 
            panelSpreadsheet.Controls.Add(iconButton10);
            panelSpreadsheet.Controls.Add(btnTotalSp);
            panelSpreadsheet.Controls.Add(btnAddEmployeeSp);
            panelSpreadsheet.Controls.Add(btnPayrollTotals);
            panelSpreadsheet.Controls.Add(btnCreateSpreasheet);
            panelSpreadsheet.Dock = DockStyle.Top;
            panelSpreadsheet.Location = new Point(0, 414);
            panelSpreadsheet.Name = "panelSpreadsheet";
            panelSpreadsheet.Size = new Size(290, 187);
            panelSpreadsheet.TabIndex = 26;
            // 
            // iconButton10
            // 
            iconButton10.BackColor = Color.SteelBlue;
            iconButton10.Dock = DockStyle.Top;
            iconButton10.Enabled = false;
            iconButton10.FlatAppearance.BorderColor = Color.SteelBlue;
            iconButton10.FlatAppearance.BorderSize = 0;
            iconButton10.FlatStyle = FlatStyle.Flat;
            iconButton10.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            iconButton10.ForeColor = Color.White;
            iconButton10.IconChar = FontAwesome.Sharp.IconChar.SquarePollHorizontal;
            iconButton10.IconColor = Color.White;
            iconButton10.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton10.IconSize = 25;
            iconButton10.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton10.Location = new Point(0, 136);
            iconButton10.Name = "iconButton10";
            iconButton10.Padding = new Padding(25, 0, 0, 0);
            iconButton10.Rotation = 270D;
            iconButton10.Size = new Size(290, 34);
            iconButton10.TabIndex = 16;
            iconButton10.Text = "Payroll Totals by Date and Sheet";
            iconButton10.TextAlign = ContentAlignment.MiddleLeft;
            iconButton10.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton10.UseVisualStyleBackColor = false;
            // 
            // btnTotalSp
            // 
            btnTotalSp.BackColor = Color.SteelBlue;
            btnTotalSp.Dock = DockStyle.Top;
            btnTotalSp.Enabled = false;
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
            btnTotalSp.Size = new Size(290, 34);
            btnTotalSp.TabIndex = 15;
            btnTotalSp.Text = "Total Spreadsheet";
            btnTotalSp.TextAlign = ContentAlignment.MiddleLeft;
            btnTotalSp.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTotalSp.UseVisualStyleBackColor = false;
            // 
            // btnAddEmployeeSp
            // 
            btnAddEmployeeSp.BackColor = Color.SteelBlue;
            btnAddEmployeeSp.Dock = DockStyle.Top;
            btnAddEmployeeSp.Enabled = false;
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
            btnAddEmployeeSp.Size = new Size(290, 34);
            btnAddEmployeeSp.TabIndex = 14;
            btnAddEmployeeSp.Text = "Add employee spreadsheed";
            btnAddEmployeeSp.TextAlign = ContentAlignment.MiddleLeft;
            btnAddEmployeeSp.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddEmployeeSp.UseVisualStyleBackColor = false;
            // 
            // btnPayrollTotals
            // 
            btnPayrollTotals.BackColor = Color.SteelBlue;
            btnPayrollTotals.Dock = DockStyle.Top;
            btnPayrollTotals.Enabled = false;
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
            btnPayrollTotals.Size = new Size(290, 34);
            btnPayrollTotals.TabIndex = 13;
            btnPayrollTotals.Text = "Payroll Totals by Date and Sheet";
            btnPayrollTotals.TextAlign = ContentAlignment.MiddleLeft;
            btnPayrollTotals.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPayrollTotals.UseVisualStyleBackColor = false;
            // 
            // btnCreateSpreasheet
            // 
            btnCreateSpreasheet.BackColor = Color.SteelBlue;
            btnCreateSpreasheet.Dock = DockStyle.Top;
            btnCreateSpreasheet.Enabled = false;
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
            btnCreateSpreasheet.Size = new Size(290, 34);
            btnCreateSpreasheet.TabIndex = 12;
            btnCreateSpreasheet.Text = "Create";
            btnCreateSpreasheet.TextAlign = ContentAlignment.MiddleLeft;
            btnCreateSpreasheet.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCreateSpreasheet.UseVisualStyleBackColor = false;
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
            btnMenuSettings.Size = new Size(290, 34);
            btnMenuSettings.TabIndex = 27;
            btnMenuSettings.Text = "Settings";
            btnMenuSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuSettings.UseVisualStyleBackColor = false;
            // 
            // panelSettings
            // 
            panelSettings.Controls.Add(btnHelp);
            panelSettings.Controls.Add(btnLanguage);
            panelSettings.Controls.Add(btnTheme);
            panelSettings.Dock = DockStyle.Top;
            panelSettings.Location = new Point(0, 635);
            panelSettings.Name = "panelSettings";
            panelSettings.Size = new Size(290, 126);
            panelSettings.TabIndex = 28;
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
            btnHelp.Size = new Size(290, 34);
            btnHelp.TabIndex = 16;
            btnHelp.Text = "Help";
            btnHelp.TextAlign = ContentAlignment.MiddleLeft;
            btnHelp.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHelp.UseVisualStyleBackColor = false;
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
            btnLanguage.Size = new Size(290, 34);
            btnLanguage.TabIndex = 15;
            btnLanguage.Text = "Language";
            btnLanguage.TextAlign = ContentAlignment.MiddleLeft;
            btnLanguage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLanguage.UseVisualStyleBackColor = false;
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
            btnTheme.Size = new Size(290, 34);
            btnTheme.TabIndex = 14;
            btnTheme.Text = "Theme - dark mode";
            btnTheme.TextAlign = ContentAlignment.MiddleLeft;
            btnTheme.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTheme.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 761);
            panel2.Name = "panel2";
            panel2.Size = new Size(290, 171);
            panel2.TabIndex = 29;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 932);
            Controls.Add(panel1);
            Controls.Add(panelGuna);
            Name = "Form1";
            Text = "Form1";
            panelGuna.ResumeLayout(false);
            panelGuna.PerformLayout();
            panel1.ResumeLayout(false);
            panelUser.ResumeLayout(false);
            panelEmployee.ResumeLayout(false);
            panelSpreadsheet.ResumeLayout(false);
            panelSettings.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelGuna;
        private Guna.UI2.WinForms.Guna2CircleProgressBar gunaUser;
        private Label label5;
        private Guna.UI2.WinForms.Guna2CircleProgressBar gunaEmployee;
        private Label label4;
        private Guna.UI2.WinForms.Guna2CircleProgressBar gunaEmpPay;
        private Label label3;
        private Guna.UI2.WinForms.Guna2CircleProgressBar gunaPayroll;
        private Label label2;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton icon1;
        private FontAwesome.Sharp.IconButton btnMenuUser;
        private Panel panelUser;
        private FontAwesome.Sharp.IconButton btnTableUser;
        private FontAwesome.Sharp.IconButton ibtnDeleteUser;
        private FontAwesome.Sharp.IconButton btnAddUser;
        private FontAwesome.Sharp.IconButton btnMenuEmployee;
        private Panel panelEmployee;
        private FontAwesome.Sharp.IconButton btnTableEmployee;
        private FontAwesome.Sharp.IconButton btnDeleteEmployee;
        private FontAwesome.Sharp.IconButton btnAddEmployees;
        private FontAwesome.Sharp.IconButton btnMenuSpreadsheet;
        private Panel panelSpreadsheet;
        private FontAwesome.Sharp.IconButton iconButton10;
        private FontAwesome.Sharp.IconButton btnTotalSp;
        private FontAwesome.Sharp.IconButton btnAddEmployeeSp;
        private FontAwesome.Sharp.IconButton btnPayrollTotals;
        private FontAwesome.Sharp.IconButton btnCreateSpreasheet;
        private FontAwesome.Sharp.IconButton btnMenuSettings;
        private Panel panelSettings;
        private FontAwesome.Sharp.IconButton btnHelp;
        private FontAwesome.Sharp.IconButton btnLanguage;
        private FontAwesome.Sharp.IconButton btnTheme;
        private Panel panel2;
    }
}