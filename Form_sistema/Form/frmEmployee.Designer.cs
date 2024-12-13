namespace Form_sistema
{
    partial class frmEmployee
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            txtIdE1 = new MaskedTextBox();
            btnSearchE = new Button();
            label4 = new Label();
            panel3 = new Panel();
            txtPhoneE = new MaskedTextBox();
            txtDateE = new DateTimePicker();
            label11 = new Label();
            txtIdE2 = new MaskedTextBox();
            label10 = new Label();
            label9 = new Label();
            txtLastNameE1 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            txtAddressE = new TextBox();
            txtLastNameE2 = new TextBox();
            txtNameE2 = new TextBox();
            txtNameE1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            btnUpdateE = new Button();
            btnSaveE = new Button();
            btnCloseE = new Button();
            btnNewE = new Button();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(727, 64);
            panel1.TabIndex = 13;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(191, 9);
            label1.Name = "label1";
            label1.Size = new Size(349, 43);
            label1.TabIndex = 6;
            label1.Text = "Employee Registration";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtIdE1);
            panel2.Controls.Add(btnSearchE);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(727, 90);
            panel2.TabIndex = 14;
            // 
            // txtIdE1
            // 
            txtIdE1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtIdE1.Font = new Font("Segoe UI", 12F);
            txtIdE1.ForeColor = SystemColors.MenuHighlight;
            txtIdE1.HidePromptOnLeave = true;
            txtIdE1.Location = new Point(128, 32);
            txtIdE1.Mask = "00-0000-0000";
            txtIdE1.Name = "txtIdE1";
            txtIdE1.PromptChar = 'x';
            txtIdE1.Size = new Size(389, 29);
            txtIdE1.TabIndex = 27;
            txtIdE1.Click += txtIdE1_Click;
            // 
            // btnSearchE
            // 
            btnSearchE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSearchE.BackColor = SystemColors.MenuHighlight;
            btnSearchE.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchE.ForeColor = SystemColors.ControlLightLight;
            btnSearchE.Location = new Point(567, 31);
            btnSearchE.Name = "btnSearchE";
            btnSearchE.Size = new Size(100, 35);
            btnSearchE.TabIndex = 11;
            btnSearchE.Text = "Search";
            btnSearchE.UseVisualStyleBackColor = false;
            btnSearchE.Click += btnSearchE_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(51, 34);
            label4.Name = "label4";
            label4.Size = new Size(35, 22);
            label4.TabIndex = 10;
            label4.Text = "ID:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtPhoneE);
            panel3.Controls.Add(txtDateE);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(txtIdE2);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(txtLastNameE1);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txtAddressE);
            panel3.Controls.Add(txtLastNameE2);
            panel3.Controls.Add(txtNameE2);
            panel3.Controls.Add(txtNameE1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 154);
            panel3.Name = "panel3";
            panel3.Size = new Size(727, 406);
            panel3.TabIndex = 15;
            // 
            // txtPhoneE
            // 
            txtPhoneE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPhoneE.Culture = new System.Globalization.CultureInfo("qu-PE");
            txtPhoneE.Enabled = false;
            txtPhoneE.Font = new Font("Segoe UI", 12F);
            txtPhoneE.ForeColor = SystemColors.MenuHighlight;
            txtPhoneE.Location = new Point(250, 355);
            txtPhoneE.Mask = "(+000) 0000-0000";
            txtPhoneE.Name = "txtPhoneE";
            txtPhoneE.PromptChar = 'x';
            txtPhoneE.Size = new Size(417, 29);
            txtPhoneE.TabIndex = 30;
            txtPhoneE.Click += txtPhoneE_Click;
            // 
            // txtDateE
            // 
            txtDateE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDateE.CalendarForeColor = SystemColors.MenuHighlight;
            txtDateE.CalendarTitleForeColor = SystemColors.MenuHighlight;
            txtDateE.Enabled = false;
            txtDateE.Location = new Point(250, 261);
            txtDateE.Name = "txtDateE";
            txtDateE.Size = new Size(417, 23);
            txtDateE.TabIndex = 29;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(42, 352);
            label11.Name = "label11";
            label11.Size = new Size(142, 22);
            label11.TabIndex = 28;
            label11.Text = "Phone Number:";
            // 
            // txtIdE2
            // 
            txtIdE2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtIdE2.Enabled = false;
            txtIdE2.Font = new Font("Segoe UI", 12F);
            txtIdE2.ForeColor = SystemColors.MenuHighlight;
            txtIdE2.Location = new Point(250, 19);
            txtIdE2.Mask = "00-0000-0000";
            txtIdE2.Name = "txtIdE2";
            txtIdE2.PromptChar = 'x';
            txtIdE2.Size = new Size(417, 29);
            txtIdE2.TabIndex = 26;
            txtIdE2.Click += txtIdE2_Click;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(40, 261);
            label10.Name = "label10";
            label10.Size = new Size(120, 22);
            label10.TabIndex = 24;
            label10.Text = "Date of Birth:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(40, 158);
            label9.Name = "label9";
            label9.Size = new Size(106, 22);
            label9.TabIndex = 23;
            label9.Text = "Last Name:";
            // 
            // txtLastNameE1
            // 
            txtLastNameE1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLastNameE1.Enabled = false;
            txtLastNameE1.Font = new Font("Segoe UI", 12F);
            txtLastNameE1.ForeColor = SystemColors.MenuHighlight;
            txtLastNameE1.Location = new Point(250, 156);
            txtLastNameE1.MaxLength = 50;
            txtLastNameE1.Name = "txtLastNameE1";
            txtLastNameE1.PlaceholderText = "Last Name";
            txtLastNameE1.Size = new Size(417, 29);
            txtLastNameE1.TabIndex = 22;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(40, 112);
            label8.Name = "label8";
            label8.Size = new Size(136, 22);
            label8.TabIndex = 21;
            label8.Text = "Second Name:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(40, 208);
            label7.Name = "label7";
            label7.Size = new Size(174, 22);
            label7.TabIndex = 20;
            label7.Text = "Second Last name:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(42, 309);
            label5.Name = "label5";
            label5.Size = new Size(87, 22);
            label5.TabIndex = 18;
            label5.Text = "Address:";
            // 
            // txtAddressE
            // 
            txtAddressE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtAddressE.Enabled = false;
            txtAddressE.Font = new Font("Segoe UI", 12F);
            txtAddressE.ForeColor = SystemColors.MenuHighlight;
            txtAddressE.Location = new Point(250, 309);
            txtAddressE.MaxLength = 50;
            txtAddressE.Name = "txtAddressE";
            txtAddressE.PlaceholderText = "Address";
            txtAddressE.Size = new Size(417, 29);
            txtAddressE.TabIndex = 16;
            // 
            // txtLastNameE2
            // 
            txtLastNameE2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLastNameE2.Enabled = false;
            txtLastNameE2.Font = new Font("Segoe UI", 12F);
            txtLastNameE2.ForeColor = SystemColors.MenuHighlight;
            txtLastNameE2.Location = new Point(250, 206);
            txtLastNameE2.MaxLength = 50;
            txtLastNameE2.Name = "txtLastNameE2";
            txtLastNameE2.PlaceholderText = "Second Last Name";
            txtLastNameE2.Size = new Size(417, 29);
            txtLastNameE2.TabIndex = 14;
            // 
            // txtNameE2
            // 
            txtNameE2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNameE2.Enabled = false;
            txtNameE2.Font = new Font("Segoe UI", 12F);
            txtNameE2.ForeColor = SystemColors.MenuHighlight;
            txtNameE2.Location = new Point(250, 110);
            txtNameE2.MaxLength = 50;
            txtNameE2.Name = "txtNameE2";
            txtNameE2.PlaceholderText = "Second Name";
            txtNameE2.Size = new Size(417, 29);
            txtNameE2.TabIndex = 13;
            // 
            // txtNameE1
            // 
            txtNameE1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNameE1.Enabled = false;
            txtNameE1.Font = new Font("Segoe UI", 12F);
            txtNameE1.ForeColor = SystemColors.MenuHighlight;
            txtNameE1.Location = new Point(250, 63);
            txtNameE1.MaxLength = 50;
            txtNameE1.Name = "txtNameE1";
            txtNameE1.PlaceholderText = "First Name";
            txtNameE1.Size = new Size(417, 29);
            txtNameE1.TabIndex = 8;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 21);
            label2.Name = "label2";
            label2.Size = new Size(35, 22);
            label2.TabIndex = 9;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 65);
            label3.Name = "label3";
            label3.Size = new Size(107, 22);
            label3.TabIndex = 10;
            label3.Text = "First Name:";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnUpdateE);
            panel4.Controls.Add(btnSaveE);
            panel4.Controls.Add(btnCloseE);
            panel4.Controls.Add(btnNewE);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 559);
            panel4.Name = "panel4";
            panel4.Size = new Size(727, 98);
            panel4.TabIndex = 16;
            // 
            // btnUpdateE
            // 
            btnUpdateE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUpdateE.BackColor = SystemColors.MenuHighlight;
            btnUpdateE.Enabled = false;
            btnUpdateE.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold);
            btnUpdateE.ForeColor = SystemColors.ControlLightLight;
            btnUpdateE.Location = new Point(407, 34);
            btnUpdateE.Name = "btnUpdateE";
            btnUpdateE.Size = new Size(100, 35);
            btnUpdateE.TabIndex = 15;
            btnUpdateE.Text = "Update";
            btnUpdateE.UseVisualStyleBackColor = false;
            btnUpdateE.Click += btnUpdateE_Click;
            // 
            // btnSaveE
            // 
            btnSaveE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSaveE.BackColor = SystemColors.MenuHighlight;
            btnSaveE.Enabled = false;
            btnSaveE.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold);
            btnSaveE.ForeColor = SystemColors.ControlLightLight;
            btnSaveE.Location = new Point(250, 34);
            btnSaveE.Name = "btnSaveE";
            btnSaveE.Size = new Size(100, 35);
            btnSaveE.TabIndex = 14;
            btnSaveE.Text = "Save";
            btnSaveE.UseVisualStyleBackColor = false;
            btnSaveE.Click += btnSaveE_Click;
            // 
            // btnCloseE
            // 
            btnCloseE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCloseE.BackColor = SystemColors.MenuHighlight;
            btnCloseE.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold);
            btnCloseE.ForeColor = SystemColors.ControlLightLight;
            btnCloseE.Location = new Point(567, 34);
            btnCloseE.Name = "btnCloseE";
            btnCloseE.Size = new Size(100, 35);
            btnCloseE.TabIndex = 13;
            btnCloseE.Text = "Close";
            btnCloseE.UseVisualStyleBackColor = false;
            // 
            // btnNewE
            // 
            btnNewE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnNewE.BackColor = SystemColors.MenuHighlight;
            btnNewE.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold);
            btnNewE.ForeColor = SystemColors.ControlLightLight;
            btnNewE.Location = new Point(41, 34);
            btnNewE.Name = "btnNewE";
            btnNewE.Size = new Size(100, 35);
            btnNewE.TabIndex = 12;
            btnNewE.Text = "New";
            btnNewE.UseVisualStyleBackColor = false;
            btnNewE.Click += btnNewE_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 657);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private MaskedTextBox txtIdE1;
        private Button btnSearchE;
        private Label label4;
        private Panel panel3;
        private MaskedTextBox txtIdE2;
        private Label label10;
        private Label label9;
        private TextBox txtLastNameE1;
        private Label label8;
        private Label label7;
        private Label label5;
        private TextBox txtAddressE;
        private TextBox txtLastNameE2;
        private TextBox txtNameE2;
        private TextBox txtNameE1;
        private Label label2;
        private Label label3;
        private DateTimePicker txtDateE;
        private Label label11;
        private MaskedTextBox txtPhoneE;
        private Panel panel4;
        private Button btnUpdateE;
        private Button btnSaveE;
        private Button btnCloseE;
        private Button btnNewE;
        private ErrorProvider errorProvider1;
    }
}