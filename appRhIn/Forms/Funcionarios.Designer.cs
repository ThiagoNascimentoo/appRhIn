namespace appRhIn.Forms
{
    partial class Funcionarios
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtNascDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtAdmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacaoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rHDataSet = new appRhIn.RHDataSet();
            this.funcionarioTableAdapter = new appRhIn.RHDataSetTableAdapters.FuncionarioTableAdapter();
            this.btnCad = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rHDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.dtNascDataGridViewTextBoxColumn,
            this.dtAdmDataGridViewTextBoxColumn,
            this.dtDmDataGridViewTextBoxColumn,
            this.cargoDataGridViewTextBoxColumn,
            this.setorDataGridViewTextBoxColumn,
            this.unidadeDataGridViewTextBoxColumn,
            this.situacaoIdDataGridViewTextBoxColumn,
            this.btnEditar,
            this.btnExcluir});
            this.dataGridView1.DataSource = this.funcionarioBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(758, 576);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 47;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 73;
            // 
            // dtNascDataGridViewTextBoxColumn
            // 
            this.dtNascDataGridViewTextBoxColumn.DataPropertyName = "DtNasc";
            this.dtNascDataGridViewTextBoxColumn.HeaderText = "DtNasc";
            this.dtNascDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dtNascDataGridViewTextBoxColumn.Name = "dtNascDataGridViewTextBoxColumn";
            this.dtNascDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtNascDataGridViewTextBoxColumn.Width = 81;
            // 
            // dtAdmDataGridViewTextBoxColumn
            // 
            this.dtAdmDataGridViewTextBoxColumn.DataPropertyName = "DtAdm";
            this.dtAdmDataGridViewTextBoxColumn.HeaderText = "DtAdm";
            this.dtAdmDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dtAdmDataGridViewTextBoxColumn.Name = "dtAdmDataGridViewTextBoxColumn";
            this.dtAdmDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtAdmDataGridViewTextBoxColumn.Width = 77;
            // 
            // dtDmDataGridViewTextBoxColumn
            // 
            this.dtDmDataGridViewTextBoxColumn.DataPropertyName = "DtDm";
            this.dtDmDataGridViewTextBoxColumn.HeaderText = "DtDm";
            this.dtDmDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dtDmDataGridViewTextBoxColumn.Name = "dtDmDataGridViewTextBoxColumn";
            this.dtDmDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtDmDataGridViewTextBoxColumn.Width = 70;
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "Cargo";
            this.cargoDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.cargoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            this.cargoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cargoDataGridViewTextBoxColumn.Width = 73;
            // 
            // setorDataGridViewTextBoxColumn
            // 
            this.setorDataGridViewTextBoxColumn.DataPropertyName = "Setor";
            this.setorDataGridViewTextBoxColumn.HeaderText = "Setor";
            this.setorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.setorDataGridViewTextBoxColumn.Name = "setorDataGridViewTextBoxColumn";
            this.setorDataGridViewTextBoxColumn.ReadOnly = true;
            this.setorDataGridViewTextBoxColumn.Width = 68;
            // 
            // unidadeDataGridViewTextBoxColumn
            // 
            this.unidadeDataGridViewTextBoxColumn.DataPropertyName = "Unidade";
            this.unidadeDataGridViewTextBoxColumn.HeaderText = "Unidade";
            this.unidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unidadeDataGridViewTextBoxColumn.Name = "unidadeDataGridViewTextBoxColumn";
            this.unidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.unidadeDataGridViewTextBoxColumn.Width = 88;
            // 
            // situacaoIdDataGridViewTextBoxColumn
            // 
            this.situacaoIdDataGridViewTextBoxColumn.DataPropertyName = "SituacaoId";
            this.situacaoIdDataGridViewTextBoxColumn.HeaderText = "SituacaoId";
            this.situacaoIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.situacaoIdDataGridViewTextBoxColumn.Name = "situacaoIdDataGridViewTextBoxColumn";
            this.situacaoIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "Editar";
            this.btnEditar.MinimumWidth = 6;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ReadOnly = true;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseColumnTextForButtonValue = true;
            this.btnEditar.Width = 48;
            // 
            // btnExcluir
            // 
            this.btnExcluir.HeaderText = "Excluir";
            this.btnExcluir.MinimumWidth = 6;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.ReadOnly = true;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseColumnTextForButtonValue = true;
            this.btnExcluir.Width = 52;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "Funcionario";
            this.funcionarioBindingSource.DataSource = this.rHDataSet;
            // 
            // rHDataSet
            // 
            this.rHDataSet.DataSetName = "RHDataSet";
            this.rHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // btnCad
            // 
            this.btnCad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCad.BackColor = System.Drawing.Color.MintCream;
            this.btnCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(129)))));
            this.btnCad.Location = new System.Drawing.Point(609, 16);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(146, 62);
            this.btnCad.TabIndex = 0;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = false;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 676);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(758, 576);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnCad);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(758, 100);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(129)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Funcionários";
            // 
            // Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(782, 700);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Funcionarios";
            this.Text = "Funcionarios";
            this.Load += new System.EventHandler(this.Funcionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rHDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RHDataSet rHDataSet;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private RHDataSetTableAdapters.FuncionarioTableAdapter funcionarioTableAdapter;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtNascDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtAdmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn setorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacaoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnExcluir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}