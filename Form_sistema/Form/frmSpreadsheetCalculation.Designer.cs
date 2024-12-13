namespace Form_sistema
{
    partial class frmSpreadsheetCalculation
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
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dtTable).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dtTable
            // 
            dtTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtTable.BackgroundColor = SystemColors.ControlLight;
            dtTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtTable.Location = new Point(26, 44);
            dtTable.Name = "dtTable";
            dtTable.ReadOnly = true;
            dtTable.Size = new Size(1133, 348);
            dtTable.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1184, 64);
            panel1.TabIndex = 14;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(26, 9);
            label1.Name = "label1";
            label1.Size = new Size(349, 43);
            label1.TabIndex = 6;
            label1.Text = "Employee Registration";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12.25F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(26, 20);
            label3.Name = "label3";
            label3.Size = new Size(141, 22);
            label3.TabIndex = 15;
            label3.Text = "Gross Total Salary:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12.25F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(327, 20);
            label2.Name = "label2";
            label2.Size = new Size(123, 22);
            label2.TabIndex = 16;
            label2.Text = "Net Total Salary:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12.25F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(456, 20);
            label4.Name = "label4";
            label4.Size = new Size(62, 22);
            label4.TabIndex = 17;
            label4.Text = "xxxx.xx";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12.25F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(173, 20);
            label5.Name = "label5";
            label5.Size = new Size(62, 22);
            label5.TabIndex = 18;
            label5.Text = "xxxx.xx";
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 481);
            panel2.Name = "panel2";
            panel2.Size = new Size(1184, 80);
            panel2.TabIndex = 19;
            // 
            // panel3
            // 
            panel3.Controls.Add(dtTable);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 64);
            panel3.Name = "panel3";
            panel3.Size = new Size(1184, 417);
            panel3.TabIndex = 20;
            // 
            // frmSpreadsheetCalculation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 561);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmSpreadsheetCalculation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmSpreadsheetCalculation_Load;
            ((System.ComponentModel.ISupportInitialize)dtTable).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtTable;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Panel panel2;
        private Panel panel3;
    }
}