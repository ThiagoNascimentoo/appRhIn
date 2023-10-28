namespace appRhIn.Forms
{
    partial class CadastrarFuncionario
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
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelCpf = new System.Windows.Forms.Label();
            this.labelUnidade = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textCpf = new System.Windows.Forms.MaskedTextBox();
            this.rHDataSet = new appRhIn.RHDataSet();
            this.unidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unidadeTableAdapter = new appRhIn.RHDataSetTableAdapters.UnidadeTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textDtDem = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textUnidade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textDtNasc = new System.Windows.Forms.MaskedTextBox();
            this.textDtAdm = new System.Windows.Forms.MaskedTextBox();
            this.textCargo = new System.Windows.Forms.ComboBox();
            this.cargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textSetor = new System.Windows.Forms.ComboBox();
            this.setorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.textSituacao = new System.Windows.Forms.ComboBox();
            this.situacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioTableAdapter = new appRhIn.RHDataSetTableAdapters.FuncionarioTableAdapter();
            this.cargoTableAdapter = new appRhIn.RHDataSetTableAdapters.CargoTableAdapter();
            this.setorTableAdapter = new appRhIn.RHDataSetTableAdapters.SetorTableAdapter();
            this.situacaoTableAdapter = new appRhIn.RHDataSetTableAdapters.SituacaoTableAdapter();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadeBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.situacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(13, 20);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(70, 25);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(149, 23);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(198, 30);
            this.textBoxNome.TabIndex = 1;
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCpf.Location = new System.Drawing.Point(353, 20);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(58, 25);
            this.labelCpf.TabIndex = 2;
            this.labelCpf.Text = "CPF:";
            // 
            // labelUnidade
            // 
            this.labelUnidade.AutoSize = true;
            this.labelUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnidade.Location = new System.Drawing.Point(13, 186);
            this.labelUnidade.Name = "labelUnidade";
            this.labelUnidade.Size = new System.Drawing.Size(91, 25);
            this.labelUnidade.TabIndex = 4;
            this.labelUnidade.Text = "Unidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cargo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Setor:";
            // 
            // textCpf
            // 
            this.textCpf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCpf.Location = new System.Drawing.Point(489, 23);
            this.textCpf.Mask = "000,000,000-00";
            this.textCpf.Name = "textCpf";
            this.textCpf.Size = new System.Drawing.Size(199, 30);
            this.textCpf.TabIndex = 10;
            // 
            // rHDataSet
            // 
            this.rHDataSet.DataSetName = "RHDataSet";
            this.rHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unidadeBindingSource
            // 
            this.unidadeBindingSource.DataMember = "Unidade";
            this.unidadeBindingSource.DataSource = this.rHDataSet;
            // 
            // unidadeTableAdapter
            // 
            this.unidadeTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.textDtDem, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button1, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.textUnidade, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelNome, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNome, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelUnidade, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelCpf, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textCpf, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textDtNasc, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textDtAdm, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.textCargo, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.textSetor, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textSituacao, 1, 4);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(48, 111);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 20, 0, 0);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9992F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9992F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9992F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9992F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0032F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(691, 436);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // textDtDem
            // 
            this.textDtDem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textDtDem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDtDem.Location = new System.Drawing.Point(489, 272);
            this.textDtDem.Mask = "00/00/0000";
            this.textDtDem.Name = "textDtDem";
            this.textDtDem.Size = new System.Drawing.Size(199, 30);
            this.textDtDem.TabIndex = 24;
            this.textDtDem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textDtDem.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(353, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 50);
            this.label6.TabIndex = 23;
            this.label6.Text = "Data Demissão:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(129)))));
            this.button1.Location = new System.Drawing.Point(489, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 49);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textUnidade
            // 
            this.textUnidade.DataSource = this.unidadeBindingSource;
            this.textUnidade.DisplayMember = "Nome";
            this.textUnidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUnidade.FormattingEnabled = true;
            this.textUnidade.Location = new System.Drawing.Point(149, 189);
            this.textUnidade.Name = "textUnidade";
            this.textUnidade.Size = new System.Drawing.Size(198, 33);
            this.textUnidade.TabIndex = 14;
            this.textUnidade.ValueMember = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 50);
            this.label2.TabIndex = 15;
            this.label2.Text = "Data Admissão:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 50);
            this.label1.TabIndex = 12;
            this.label1.Text = "Data Nascimento:";
            // 
            // textDtNasc
            // 
            this.textDtNasc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textDtNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDtNasc.Location = new System.Drawing.Point(149, 106);
            this.textDtNasc.Mask = "00/00/0000";
            this.textDtNasc.Name = "textDtNasc";
            this.textDtNasc.Size = new System.Drawing.Size(198, 30);
            this.textDtNasc.TabIndex = 13;
            this.textDtNasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textDtNasc.ValidatingType = typeof(System.DateTime);
            // 
            // textDtAdm
            // 
            this.textDtAdm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textDtAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDtAdm.Location = new System.Drawing.Point(489, 106);
            this.textDtAdm.Mask = "00/00/0000";
            this.textDtAdm.Name = "textDtAdm";
            this.textDtAdm.Size = new System.Drawing.Size(199, 30);
            this.textDtAdm.TabIndex = 14;
            this.textDtAdm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textDtAdm.ValidatingType = typeof(System.DateTime);
            // 
            // textCargo
            // 
            this.textCargo.DataSource = this.cargoBindingSource;
            this.textCargo.DisplayMember = "Nome";
            this.textCargo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCargo.FormattingEnabled = true;
            this.textCargo.Location = new System.Drawing.Point(489, 189);
            this.textCargo.Name = "textCargo";
            this.textCargo.Size = new System.Drawing.Size(199, 33);
            this.textCargo.TabIndex = 18;
            this.textCargo.ValueMember = "Id";
            // 
            // cargoBindingSource
            // 
            this.cargoBindingSource.DataMember = "Cargo";
            this.cargoBindingSource.DataSource = this.rHDataSet;
            // 
            // textSetor
            // 
            this.textSetor.DataSource = this.setorBindingSource;
            this.textSetor.DisplayMember = "Nome";
            this.textSetor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSetor.FormattingEnabled = true;
            this.textSetor.Location = new System.Drawing.Point(149, 272);
            this.textSetor.Name = "textSetor";
            this.textSetor.Size = new System.Drawing.Size(198, 33);
            this.textSetor.TabIndex = 19;
            this.textSetor.ValueMember = "Id";
            // 
            // setorBindingSource
            // 
            this.setorBindingSource.DataMember = "Setor";
            this.setorBindingSource.DataSource = this.rHDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Situação:";
            // 
            // textSituacao
            // 
            this.textSituacao.DataSource = this.situacaoBindingSource;
            this.textSituacao.DisplayMember = "Nome";
            this.textSituacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSituacao.FormattingEnabled = true;
            this.textSituacao.Location = new System.Drawing.Point(149, 355);
            this.textSituacao.Name = "textSituacao";
            this.textSituacao.Size = new System.Drawing.Size(198, 33);
            this.textSituacao.TabIndex = 22;
            this.textSituacao.ValueMember = "Id";
            // 
            // situacaoBindingSource
            // 
            this.situacaoBindingSource.DataMember = "Situacao";
            this.situacaoBindingSource.DataSource = this.rHDataSet;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // cargoTableAdapter
            // 
            this.cargoTableAdapter.ClearBeforeFill = true;
            // 
            // setorTableAdapter
            // 
            this.setorTableAdapter.ClearBeforeFill = true;
            // 
            // situacaoTableAdapter
            // 
            this.situacaoTableAdapter.ClearBeforeFill = true;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "Funcionario";
            this.funcionarioBindingSource.DataSource = this.rHDataSet;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(129)))));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(283, 31);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cadastrar Funcionario";
            // 
            // CadastrarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 700);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastrarFuncionario";
            this.Text = "CadastrarFuncionario";
            this.Load += new System.EventHandler(this.CadastrarFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadeBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.situacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.Label labelUnidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox textCpf;
        private RHDataSet rHDataSet;
        private System.Windows.Forms.BindingSource unidadeBindingSource;
        private RHDataSetTableAdapters.UnidadeTableAdapter unidadeTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox textDtNasc;
        private System.Windows.Forms.MaskedTextBox textDtAdm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox textUnidade;
        private System.Windows.Forms.ComboBox textCargo;
        private RHDataSetTableAdapters.FuncionarioTableAdapter funcionarioTableAdapter;
        private System.Windows.Forms.BindingSource cargoBindingSource;
        private RHDataSetTableAdapters.CargoTableAdapter cargoTableAdapter;
        private System.Windows.Forms.ComboBox textSetor;
        private System.Windows.Forms.BindingSource setorBindingSource;
        private RHDataSetTableAdapters.SetorTableAdapter setorTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource situacaoBindingSource;
        private RHDataSetTableAdapters.SituacaoTableAdapter situacaoTableAdapter;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private System.Windows.Forms.MaskedTextBox textDtDem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox textSituacao;
        private System.Windows.Forms.Label label7;
    }
}