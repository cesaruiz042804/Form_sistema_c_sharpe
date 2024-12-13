namespace Form_sistema
{
    partial class frmAddEmployee
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
            panel3 = new Panel();
            lblLast1 = new Label();
            lblName2 = new Label();
            lblLast2 = new Label();
            lblName1 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label3 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            txtIdAddEmp = new MaskedTextBox();
            btnSearchE = new Button();
            label4 = new Label();
            panel4 = new Panel();
            btnCloseE = new Button();
            S = new Button();
            panel5 = new Panel();
            label10 = new Label();
            label6 = new Label();
            txtHour = new NumericUpDown();
            txtHourlyRate = new TextBox();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtHour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(723, 75);
            panel1.TabIndex = 14;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(40, 14);
            label1.Name = "label1";
            label1.Size = new Size(203, 43);
            label1.TabIndex = 6;
            label1.Text = "Spreadsheet";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblLast1);
            panel3.Controls.Add(lblName2);
            panel3.Controls.Add(lblLast2);
            panel3.Controls.Add(lblName1);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 165);
            panel3.Name = "panel3";
            panel3.Size = new Size(723, 222);
            panel3.TabIndex = 17;
            // 
            // lblLast1
            // 
            lblLast1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLast1.AutoSize = true;
            lblLast1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLast1.ForeColor = SystemColors.MenuHighlight;
            lblLast1.Location = new Point(239, 122);
            lblLast1.Name = "lblLast1";
            lblLast1.Size = new Size(106, 22);
            lblLast1.TabIndex = 27;
            lblLast1.Text = "Last Name:";
            // 
            // lblName2
            // 
            lblName2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblName2.AutoSize = true;
            lblName2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName2.ForeColor = SystemColors.MenuHighlight;
            lblName2.Location = new Point(239, 76);
            lblName2.Name = "lblName2";
            lblName2.Size = new Size(136, 22);
            lblName2.TabIndex = 26;
            lblName2.Text = "Second Name:";
            // 
            // lblLast2
            // 
            lblLast2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLast2.AutoSize = true;
            lblLast2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLast2.ForeColor = SystemColors.MenuHighlight;
            lblLast2.Location = new Point(239, 172);
            lblLast2.Name = "lblLast2";
            lblLast2.Size = new Size(174, 22);
            lblLast2.TabIndex = 25;
            lblLast2.Text = "Second Last name:";
            // 
            // lblName1
            // 
            lblName1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblName1.AutoSize = true;
            lblName1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName1.ForeColor = SystemColors.MenuHighlight;
            lblName1.Location = new Point(239, 29);
            lblName1.Name = "lblName1";
            lblName1.Size = new Size(107, 22);
            lblName1.TabIndex = 24;
            lblName1.Text = "First Name:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(40, 122);
            label9.Name = "label9";
            label9.Size = new Size(106, 22);
            label9.TabIndex = 23;
            label9.Text = "Last Name:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(40, 76);
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
            label7.Location = new Point(40, 172);
            label7.Name = "label7";
            label7.Size = new Size(174, 22);
            label7.TabIndex = 20;
            label7.Text = "Second Last name:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 29);
            label3.Name = "label3";
            label3.Size = new Size(107, 22);
            label3.TabIndex = 10;
            label3.Text = "First Name:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(41, 38);
            label5.Name = "label5";
            label5.Size = new Size(134, 22);
            label5.TabIndex = 18;
            label5.Text = "Worked hours:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtIdAddEmp);
            panel2.Controls.Add(btnSearchE);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(723, 90);
            panel2.TabIndex = 16;
            // 
            // txtIdAddEmp
            // 
            txtIdAddEmp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtIdAddEmp.Font = new Font("Segoe UI", 12F);
            txtIdAddEmp.ForeColor = SystemColors.MenuHighlight;
            txtIdAddEmp.HidePromptOnLeave = true;
            txtIdAddEmp.Location = new Point(128, 32);
            txtIdAddEmp.Mask = "00-0000-0000";
            txtIdAddEmp.Name = "txtIdAddEmp";
            txtIdAddEmp.PromptChar = 'x';
            txtIdAddEmp.Size = new Size(359, 29);
            txtIdAddEmp.TabIndex = 27;
            txtIdAddEmp.Click += txtIdAddEmp_Click;
            // 
            // btnSearchE
            // 
            btnSearchE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSearchE.BackColor = SystemColors.MenuHighlight;
            btnSearchE.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchE.ForeColor = SystemColors.ControlLightLight;
            btnSearchE.Location = new Point(538, 29);
            btnSearchE.Name = "btnSearchE";
            btnSearchE.Size = new Size(120, 35);
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
            // panel4
            // 
            panel4.Controls.Add(btnCloseE);
            panel4.Controls.Add(S);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 542);
            panel4.Name = "panel4";
            panel4.Size = new Size(723, 89);
            panel4.TabIndex = 18;
            panel4.Paint += panel4_Paint;
            // 
            // btnCloseE
            // 
            btnCloseE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCloseE.BackColor = SystemColors.MenuHighlight;
            btnCloseE.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold);
            btnCloseE.ForeColor = SystemColors.ControlLightLight;
            btnCloseE.Location = new Point(240, 29);
            btnCloseE.Name = "btnCloseE";
            btnCloseE.Size = new Size(148, 35);
            btnCloseE.TabIndex = 13;
            btnCloseE.Text = "Back >>";
            btnCloseE.UseVisualStyleBackColor = false;
            // 
            // S
            // 
            S.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            S.BackColor = SystemColors.MenuHighlight;
            S.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold);
            S.ForeColor = SystemColors.ControlLightLight;
            S.Location = new Point(41, 29);
            S.Name = "S";
            S.Size = new Size(160, 35);
            S.TabIndex = 12;
            S.Text = "+ Add Employee";
            S.UseVisualStyleBackColor = false;
            S.Click += btnNewE_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(txtHour);
            panel5.Controls.Add(txtHourlyRate);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label5);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 387);
            panel5.Name = "panel5";
            panel5.Size = new Size(723, 157);
            panel5.TabIndex = 19;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Arial Narrow", 10F, FontStyle.Bold | FontStyle.Italic);
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(405, 102);
            label10.Name = "label10";
            label10.Size = new Size(36, 17);
            label10.TabIndex = 30;
            label10.Text = "4 - 20";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 10F, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(405, 41);
            label6.Name = "label6";
            label6.Size = new Size(117, 17);
            label6.TabIndex = 29;
            label6.Text = "total days per month";
            // 
            // txtHour
            // 
            txtHour.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtHour.Enabled = false;
            txtHour.Font = new Font("Segoe UI", 12F);
            txtHour.ForeColor = SystemColors.MenuHighlight;
            txtHour.Location = new Point(239, 35);
            txtHour.Maximum = new decimal(new int[] { 192, 0, 0, 0 });
            txtHour.Minimum = new decimal(new int[] { 160, 0, 0, 0 });
            txtHour.Name = "txtHour";
            txtHour.Size = new Size(148, 29);
            txtHour.TabIndex = 28;
            txtHour.Value = new decimal(new int[] { 160, 0, 0, 0 });
            // 
            // txtHourlyRate
            // 
            txtHourlyRate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtHourlyRate.Enabled = false;
            txtHourlyRate.Font = new Font("Segoe UI", 12F);
            txtHourlyRate.ForeColor = SystemColors.MenuHighlight;
            txtHourlyRate.Location = new Point(239, 95);
            txtHourlyRate.MaxLength = 50;
            txtHourlyRate.Name = "txtHourlyRate";
            txtHourlyRate.PlaceholderText = "00.00";
            txtHourlyRate.Size = new Size(148, 29);
            txtHourlyRate.TabIndex = 19;
            txtHourlyRate.KeyPress += txtHourlyRate_KeyPress;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 97);
            label2.Name = "label2";
            label2.Size = new Size(102, 22);
            label2.TabIndex = 20;
            label2.Text = "hourly rate:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 631);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmAddEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddEmployee";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtHour).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label3;
        private Panel panel2;
        private MaskedTextBox txtIdAddEmp;
        private Button btnSearchE;
        private Label label4;
        private Panel panel4;
        private Button btnCloseE;
        private Button S;
        private Panel panel5;
        private TextBox txtHourlyRate;
        private Label label2;
        private Label lblLast1;
        private Label lblName2;
        private Label lblLast2;
        private Label lblName1;
        private NumericUpDown txtHour;
        private ErrorProvider errorProvider1;
        private Label label10;
        private Label label6;
    }
}