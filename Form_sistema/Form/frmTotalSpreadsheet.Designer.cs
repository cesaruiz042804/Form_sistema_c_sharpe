namespace Form_sistema
{
    partial class frmTotalSpreadsheet
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
            dtTable = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dtTable).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dtTable
            // 
            dtTable.AllowUserToAddRows = false;
            dtTable.AllowUserToDeleteRows = false;
            dtTable.BackgroundColor = SystemColors.ButtonFace;
            dtTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtTable.Location = new Point(77, 32);
            dtTable.Name = "dtTable";
            dtTable.ReadOnly = true;
            dtTable.Size = new Size(641, 264);
            dtTable.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 121);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(77, 35);
            label1.Name = "label1";
            label1.Size = new Size(261, 57);
            label1.TabIndex = 1;
            label1.Text = "Spreadsheet";
            // 
            // panel2
            // 
            panel2.Controls.Add(dtTable);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 329);
            panel2.TabIndex = 4;
            // 
            // frmTotalSpreadsheet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.WindowFrame;
            Name = "frmTotalSpreadsheet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addEmployeeSpreadsheet";
            Load += frmTotalSpreadsheet_Load;
            ((System.ComponentModel.ISupportInitialize)dtTable).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtTable;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
    }
}