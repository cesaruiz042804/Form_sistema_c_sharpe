namespace Form_sistema
{
    partial class frmUser
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
            label1 = new Label();
            txtUserU = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            txtIdU1 = new MaskedTextBox();
            btnSearchU = new Button();
            label4 = new Label();
            panel3 = new Panel();
            panel5 = new Panel();
            txtAddressU = new TextBox();
            cboxPasswordU = new CheckBox();
            txtIdU2 = new MaskedTextBox();
            txtPasswordU1 = new TextBox();
            txtNameU = new TextBox();
            txtPasswordU2 = new TextBox();
            txtLastNameU = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            btnUpdateU = new Button();
            btnSaveU = new Button();
            btnCloseU = new Button();
            btnNewU = new Button();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(247, 9);
            label1.Name = "label1";
            label1.Size = new Size(273, 43);
            label1.TabIndex = 6;
            label1.Text = "User Registration";
            // 
            // txtUserU
            // 
            txtUserU.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUserU.Enabled = false;
            txtUserU.Font = new Font("Segoe UI", 12F);
            txtUserU.ForeColor = SystemColors.MenuHighlight;
            txtUserU.Location = new Point(23, 63);
            txtUserU.MaxLength = 50;
            txtUserU.Name = "txtUserU";
            txtUserU.PlaceholderText = "User name";
            txtUserU.Size = new Size(427, 29);
            txtUserU.TabIndex = 8;
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
            label3.Text = "User name:";
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
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(744, 64);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtIdU1);
            panel2.Controls.Add(btnSearchU);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(744, 90);
            panel2.TabIndex = 13;
            panel2.Paint += panel2_Paint;
            // 
            // txtIdU1
            // 
            txtIdU1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtIdU1.Font = new Font("Segoe UI", 12F);
            txtIdU1.ForeColor = SystemColors.MenuHighlight;
            txtIdU1.HidePromptOnLeave = true;
            txtIdU1.Location = new Point(157, 32);
            txtIdU1.Mask = "00-0000-0000";
            txtIdU1.Name = "txtIdU1";
            txtIdU1.PromptChar = 'x';
            txtIdU1.Size = new Size(391, 29);
            txtIdU1.TabIndex = 27;
            txtIdU1.Click += txtIdU1_Click;
            // 
            // btnSearchU
            // 
            btnSearchU.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSearchU.BackColor = SystemColors.MenuHighlight;
            btnSearchU.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchU.ForeColor = SystemColors.ControlLightLight;
            btnSearchU.Location = new Point(590, 28);
            btnSearchU.Name = "btnSearchU";
            btnSearchU.Size = new Size(88, 37);
            btnSearchU.TabIndex = 11;
            btnSearchU.Text = "Search";
            btnSearchU.UseVisualStyleBackColor = false;
            btnSearchU.Click += btnSearchU_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(77, 31);
            label4.Name = "label4";
            label4.Size = new Size(35, 22);
            label4.TabIndex = 10;
            label4.Text = "ID:";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 154);
            panel3.Name = "panel3";
            panel3.Size = new Size(744, 363);
            panel3.TabIndex = 14;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtAddressU);
            panel5.Controls.Add(cboxPasswordU);
            panel5.Controls.Add(txtUserU);
            panel5.Controls.Add(txtIdU2);
            panel5.Controls.Add(txtPasswordU1);
            panel5.Controls.Add(txtNameU);
            panel5.Controls.Add(txtPasswordU2);
            panel5.Controls.Add(txtLastNameU);
            panel5.Location = new Point(228, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(516, 363);
            panel5.TabIndex = 28;
            panel5.Paint += panel5_Paint;
            // 
            // txtAddressU
            // 
            txtAddressU.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtAddressU.Enabled = false;
            txtAddressU.Font = new Font("Segoe UI", 12F);
            txtAddressU.ForeColor = SystemColors.MenuHighlight;
            txtAddressU.Location = new Point(23, 309);
            txtAddressU.MaxLength = 50;
            txtAddressU.Name = "txtAddressU";
            txtAddressU.PlaceholderText = "Address";
            txtAddressU.Size = new Size(427, 29);
            txtAddressU.TabIndex = 16;
            // 
            // cboxPasswordU
            // 
            cboxPasswordU.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboxPasswordU.AutoSize = true;
            cboxPasswordU.Enabled = false;
            cboxPasswordU.Font = new Font("Arial", 9.75F);
            cboxPasswordU.ImeMode = ImeMode.NoControl;
            cboxPasswordU.Location = new Point(23, 191);
            cboxPasswordU.Name = "cboxPasswordU";
            cboxPasswordU.Size = new Size(117, 20);
            cboxPasswordU.TabIndex = 27;
            cboxPasswordU.Text = "Show password";
            cboxPasswordU.UseVisualStyleBackColor = true;
            cboxPasswordU.CheckedChanged += cboxPasswordU_CheckedChanged;
            // 
            // txtIdU2
            // 
            txtIdU2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtIdU2.Enabled = false;
            txtIdU2.Font = new Font("Segoe UI", 12F);
            txtIdU2.ForeColor = SystemColors.MenuHighlight;
            txtIdU2.Location = new Point(23, 19);
            txtIdU2.Mask = "00-0000-0000";
            txtIdU2.Name = "txtIdU2";
            txtIdU2.PromptChar = 'x';
            txtIdU2.Size = new Size(427, 29);
            txtIdU2.TabIndex = 26;
            txtIdU2.Click += txtIdU2_Click;
            // 
            // txtPasswordU1
            // 
            txtPasswordU1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPasswordU1.Enabled = false;
            txtPasswordU1.Font = new Font("Segoe UI", 12F);
            txtPasswordU1.ForeColor = SystemColors.MenuHighlight;
            txtPasswordU1.Location = new Point(23, 110);
            txtPasswordU1.MaxLength = 50;
            txtPasswordU1.Name = "txtPasswordU1";
            txtPasswordU1.PasswordChar = '*';
            txtPasswordU1.PlaceholderText = "Password";
            txtPasswordU1.Size = new Size(427, 29);
            txtPasswordU1.TabIndex = 13;
            // 
            // txtNameU
            // 
            txtNameU.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNameU.Enabled = false;
            txtNameU.Font = new Font("Segoe UI", 12F);
            txtNameU.ForeColor = SystemColors.MenuHighlight;
            txtNameU.Location = new Point(23, 219);
            txtNameU.MaxLength = 50;
            txtNameU.Name = "txtNameU";
            txtNameU.PlaceholderText = "Name";
            txtNameU.Size = new Size(427, 29);
            txtNameU.TabIndex = 14;
            // 
            // txtPasswordU2
            // 
            txtPasswordU2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPasswordU2.Enabled = false;
            txtPasswordU2.Font = new Font("Segoe UI", 12F);
            txtPasswordU2.ForeColor = SystemColors.MenuHighlight;
            txtPasswordU2.Location = new Point(23, 156);
            txtPasswordU2.MaxLength = 50;
            txtPasswordU2.Name = "txtPasswordU2";
            txtPasswordU2.PasswordChar = '*';
            txtPasswordU2.PlaceholderText = "Confirm Password";
            txtPasswordU2.Size = new Size(427, 29);
            txtPasswordU2.TabIndex = 22;
            // 
            // txtLastNameU
            // 
            txtLastNameU.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLastNameU.Enabled = false;
            txtLastNameU.Font = new Font("Segoe UI", 12F);
            txtLastNameU.ForeColor = SystemColors.MenuHighlight;
            txtLastNameU.Location = new Point(23, 263);
            txtLastNameU.MaxLength = 50;
            txtLastNameU.Name = "txtLastNameU";
            txtLastNameU.PlaceholderText = "Last Name";
            txtLastNameU.Size = new Size(427, 29);
            txtLastNameU.TabIndex = 15;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(40, 158);
            label9.Name = "label9";
            label9.Size = new Size(171, 22);
            label9.TabIndex = 23;
            label9.Text = "Confirm Password:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(40, 112);
            label8.Name = "label8";
            label8.Size = new Size(99, 22);
            label8.TabIndex = 21;
            label8.Text = "Password:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(40, 221);
            label7.Name = "label7";
            label7.Size = new Size(65, 22);
            label7.TabIndex = 20;
            label7.Text = "Name:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(40, 265);
            label6.Name = "label6";
            label6.Size = new Size(106, 22);
            label6.TabIndex = 19;
            label6.Text = "Last Name:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(40, 311);
            label5.Name = "label5";
            label5.Size = new Size(87, 22);
            label5.TabIndex = 18;
            label5.Text = "Address:";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnUpdateU);
            panel4.Controls.Add(btnSaveU);
            panel4.Controls.Add(btnCloseU);
            panel4.Controls.Add(btnNewU);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 517);
            panel4.Name = "panel4";
            panel4.Size = new Size(744, 81);
            panel4.TabIndex = 15;
            // 
            // btnUpdateU
            // 
            btnUpdateU.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUpdateU.BackColor = SystemColors.MenuHighlight;
            btnUpdateU.Enabled = false;
            btnUpdateU.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold);
            btnUpdateU.ForeColor = SystemColors.ControlLightLight;
            btnUpdateU.Location = new Point(395, 24);
            btnUpdateU.Name = "btnUpdateU";
            btnUpdateU.Size = new Size(125, 35);
            btnUpdateU.TabIndex = 15;
            btnUpdateU.Text = "Update";
            btnUpdateU.UseVisualStyleBackColor = false;
            btnUpdateU.Click += btnUpdateU_Click;
            // 
            // btnSaveU
            // 
            btnSaveU.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSaveU.BackColor = SystemColors.MenuHighlight;
            btnSaveU.Enabled = false;
            btnSaveU.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold);
            btnSaveU.ForeColor = SystemColors.ControlLightLight;
            btnSaveU.Location = new Point(247, 24);
            btnSaveU.Name = "btnSaveU";
            btnSaveU.Size = new Size(125, 35);
            btnSaveU.TabIndex = 14;
            btnSaveU.Text = "Save";
            btnSaveU.UseVisualStyleBackColor = false;
            btnSaveU.Click += btnSaveU_Click;
            // 
            // btnCloseU
            // 
            btnCloseU.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCloseU.BackColor = SystemColors.MenuHighlight;
            btnCloseU.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold);
            btnCloseU.ForeColor = SystemColors.ControlLightLight;
            btnCloseU.Location = new Point(553, 24);
            btnCloseU.Name = "btnCloseU";
            btnCloseU.Size = new Size(125, 35);
            btnCloseU.TabIndex = 13;
            btnCloseU.Text = "Close";
            btnCloseU.UseVisualStyleBackColor = false;
            // 
            // btnNewU
            // 
            btnNewU.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnNewU.BackColor = SystemColors.MenuHighlight;
            btnNewU.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold);
            btnNewU.ForeColor = SystemColors.ControlLightLight;
            btnNewU.Location = new Point(41, 24);
            btnNewU.Name = "btnNewU";
            btnNewU.Size = new Size(125, 35);
            btnNewU.TabIndex = 12;
            btnNewU.Text = "New";
            btnNewU.UseVisualStyleBackColor = false;
            btnNewU.Click += btnNewU_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(744, 600);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUser";
            Load += frmUser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtUserU;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private Button btnSearchU;
        private Panel panel3;
        private TextBox txtAddressU;
        private TextBox txtLastNameU;
        private TextBox txtNameU;
        private TextBox txtPasswordU1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label9;
        private TextBox txtPasswordU2;
        private Panel panel4;
        private Button btnUpdateU;
        private Button btnSaveU;
        private Button btnCloseU;
        private Button btnNewU;
        private MaskedTextBox txtIdU2;
        private MaskedTextBox txtIdU1;
        private ErrorProvider errorProvider1;
        private CheckBox cboxPasswordU;
        private Panel panel5;
    }
}