namespace appRhIn.Forms
{
    partial class Ferias
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Funcionário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataFim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtAdm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(18, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 535);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Funcionário,
            this.DataIN,
            this.DataFim,
            this.DtAdm,
            this.Sit});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(734, 535);
            this.dataGridView1.TabIndex = 0;
            // 
            // Funcionário
            // 
            this.Funcionário.HeaderText = "Funcionário";
            this.Funcionário.MinimumWidth = 6;
            this.Funcionário.Name = "Funcionário";
            // 
            // DataIN
            // 
            this.DataIN.HeaderText = "DataInicio";
            this.DataIN.MinimumWidth = 6;
            this.DataIN.Name = "DataIN";
            // 
            // DataFim
            // 
            this.DataFim.HeaderText = "Data Fim";
            this.DataFim.MinimumWidth = 6;
            this.DataFim.Name = "DataFim";
            // 
            // DtAdm
            // 
            this.DtAdm.HeaderText = "Data Admissão";
            this.DtAdm.MinimumWidth = 6;
            this.DtAdm.Name = "DtAdm";
            // 
            // Sit
            // 
            this.Sit.HeaderText = "Situação";
            this.Sit.MinimumWidth = 6;
            this.Sit.Name = "Sit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(129)))));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(280, 31);
            this.label7.TabIndex = 14;
            this.label7.Text = "Solicitações de Ferias";
            // 
            // Ferias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(764, 653);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ferias";
            this.Text = "Ferias";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionário;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataFim;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtAdm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sit;
        private System.Windows.Forms.Label label7;
    }
}