namespace Form_sistema
{
    partial class frmTableEmployee
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
            panel2 = new Panel();
            dtTable = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtTable).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(dtTable);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(1036, 416);
            panel2.TabIndex = 17;
            // 
            // dtTable
            // 
            dtTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtTable.BackgroundColor = SystemColors.Control;
            dtTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtTable.Location = new Point(31, 51);
            dtTable.Name = "dtTable";
            dtTable.Size = new Size(971, 296);
            dtTable.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1036, 64);
            panel1.TabIndex = 16;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(335, 9);
            label1.Name = "label1";
            label1.Size = new Size(349, 43);
            label1.TabIndex = 6;
            label1.Text = "Employee Registration";
            // 
            // frmTableEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 480);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmTableEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTableEmployee";
            Load += frmTableEmployee_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtTable).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dtTable;
        private Panel panel1;
        private Label label1;
    }
}