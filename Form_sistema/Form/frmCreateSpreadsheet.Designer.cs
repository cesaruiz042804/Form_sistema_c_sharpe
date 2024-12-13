namespace Form_sistema
{
    partial class frmCreateSpreadsheet
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
            panel1 = new Panel();
            label2 = new Label();
            txtDateS = new DateTimePicker();
            btnCreateS = new Button();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            txtNumcode = new NumericUpDown();
            panel2 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNumcode).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 31);
            label1.Name = "label1";
            label1.Size = new Size(488, 57);
            label1.TabIndex = 1;
            label1.Text = "Spreadsheet Information";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(492, 121);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 16F, FontStyle.Bold);
            label2.Location = new Point(22, 108);
            label2.Name = "label2";
            label2.Size = new Size(135, 26);
            label2.TabIndex = 3;
            label2.Text = "Creation Date:";
            // 
            // txtDateS
            // 
            txtDateS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDateS.Font = new Font("Segoe UI", 12F);
            txtDateS.Location = new Point(22, 140);
            txtDateS.Name = "txtDateS";
            txtDateS.Size = new Size(265, 29);
            txtDateS.TabIndex = 4;
            // 
            // btnCreateS
            // 
            btnCreateS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCreateS.BackColor = SystemColors.MenuHighlight;
            btnCreateS.Font = new Font("Arial Narrow", 12.25F, FontStyle.Bold);
            btnCreateS.ForeColor = SystemColors.ControlLightLight;
            btnCreateS.Location = new Point(22, 206);
            btnCreateS.Name = "btnCreateS";
            btnCreateS.Size = new Size(265, 40);
            btnCreateS.TabIndex = 16;
            btnCreateS.Text = "Create";
            btnCreateS.UseVisualStyleBackColor = false;
            btnCreateS.Click += btnCreateS_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 16F, FontStyle.Bold);
            label3.Location = new Point(16, 27);
            label3.Name = "label3";
            label3.Size = new Size(136, 26);
            label3.TabIndex = 17;
            label3.Text = "Number Code:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // txtNumcode
            // 
            txtNumcode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNumcode.Font = new Font("Segoe UI", 12F);
            txtNumcode.Location = new Point(22, 59);
            txtNumcode.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            txtNumcode.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtNumcode.Name = "txtNumcode";
            txtNumcode.Size = new Size(265, 29);
            txtNumcode.TabIndex = 18;
            txtNumcode.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnCreateS);
            panel2.Controls.Add(txtNumcode);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtDateS);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(492, 282);
            panel2.TabIndex = 19;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Font = new Font("Arial Narrow", 12.25F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(369, 206);
            button1.Name = "button1";
            button1.Size = new Size(98, 40);
            button1.TabIndex = 19;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            // 
            // frmCreateSpreadsheet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 403);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmCreateSpreadsheet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateSpreadsheet";
            Load += CreateSpreadsheet_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNumcode).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private DateTimePicker txtDateS;
        private Button btnCreateS;
        private Label label3;
        private ErrorProvider errorProvider1;
        private NumericUpDown txtNumcode;
        private Panel panel2;
        private Button button1;
    }
}