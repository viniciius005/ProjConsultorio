namespace ProjConsultorio
{
    partial class FormMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMedico));
            this.GridMed = new System.Windows.Forms.DataGridView();
            this.medicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbConsultorioDataSet6 = new ProjConsultorio.DbConsultorioDataSet6();
            this.txtCpfMed = new System.Windows.Forms.MaskedTextBox();
            this.txtTelMed = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeMed = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEpecialidadeMed = new System.Windows.Forms.ComboBox();
            this.especialidadsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbConsultorioDataSet1 = new ProjConsultorio.DbConsultorioDataSet1();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dbConsultorioDataSet = new ProjConsultorio.DbConsultorioDataSet();
            this.dbConsultorioDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.especialidadsTableAdapter = new ProjConsultorio.DbConsultorioDataSet1TableAdapters.EspecialidadsTableAdapter();
            this.medicosTableAdapter = new ProjConsultorio.DbConsultorioDataSet6TableAdapters.MedicosTableAdapter();
            this.dbConsultorioDataSet8 = new ProjConsultorio.DbConsultorioDataSet8();
            this.dbConsultorioDataSet7 = new ProjConsultorio.DbConsultorioDataSet7();
            this.dbConsultorioDataSet9 = new ProjConsultorio.DbConsultorioDataSet9();
            this.dbConsultorioDataSet9BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idMedicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEspecialidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioDataSet9BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GridMed
            // 
            this.GridMed.AllowUserToAddRows = false;
            this.GridMed.AllowUserToDeleteRows = false;
            this.GridMed.AutoGenerateColumns = false;
            this.GridMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMedicoDataGridViewTextBoxColumn,
            this.idEspecialidadeDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.cEPDataGridViewTextBoxColumn,
            this.ruaDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.GridMed.DataSource = this.medicosBindingSource;
            this.GridMed.Location = new System.Drawing.Point(33, 216);
            this.GridMed.Name = "GridMed";
            this.GridMed.ReadOnly = true;
            this.GridMed.Size = new System.Drawing.Size(569, 231);
            this.GridMed.TabIndex = 20;
            this.GridMed.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridMed_CellClick);
            this.GridMed.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridMed_CellContentClick);
            // 
            // medicosBindingSource
            // 
            this.medicosBindingSource.DataMember = "Medicos";
            this.medicosBindingSource.DataSource = this.dbConsultorioDataSet6;
            // 
            // dbConsultorioDataSet6
            // 
            this.dbConsultorioDataSet6.DataSetName = "DbConsultorioDataSet6";
            this.dbConsultorioDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCpfMed
            // 
            this.txtCpfMed.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCpfMed.Location = new System.Drawing.Point(338, 48);
            this.txtCpfMed.Mask = "000.000.000-00";
            this.txtCpfMed.Name = "txtCpfMed";
            this.txtCpfMed.Size = new System.Drawing.Size(100, 20);
            this.txtCpfMed.TabIndex = 4;
            // 
            // txtTelMed
            // 
            this.txtTelMed.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTelMed.Location = new System.Drawing.Point(338, 16);
            this.txtTelMed.Mask = "(99) 00000-0000";
            this.txtTelMed.Name = "txtTelMed";
            this.txtTelMed.Size = new System.Drawing.Size(100, 20);
            this.txtTelMed.TabIndex = 3;
            // 
            // txtNomeMed
            // 
            this.txtNomeMed.Location = new System.Drawing.Point(108, 78);
            this.txtNomeMed.Name = "txtNomeMed";
            this.txtNomeMed.Size = new System.Drawing.Size(269, 20);
            this.txtNomeMed.TabIndex = 1;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(108, 19);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(28, 20);
            this.txtid.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Especialidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id";
            // 
            // txtEpecialidadeMed
            // 
            this.txtEpecialidadeMed.DataSource = this.especialidadsBindingSource;
            this.txtEpecialidadeMed.DisplayMember = "Especialidade";
            this.txtEpecialidadeMed.FormattingEnabled = true;
            this.txtEpecialidadeMed.Location = new System.Drawing.Point(108, 48);
            this.txtEpecialidadeMed.Name = "txtEpecialidadeMed";
            this.txtEpecialidadeMed.Size = new System.Drawing.Size(150, 21);
            this.txtEpecialidadeMed.TabIndex = 0;
            this.txtEpecialidadeMed.ValueMember = "IdEspecialidade";
            // 
            // especialidadsBindingSource
            // 
            this.especialidadsBindingSource.DataMember = "Especialidads";
            this.especialidadsBindingSource.DataSource = this.dbConsultorioDataSet1;
            // 
            // dbConsultorioDataSet1
            // 
            this.dbConsultorioDataSet1.DataSetName = "DbConsultorioDataSet1";
            this.dbConsultorioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(205, 187);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(75, 23);
            this.btnadicionar.TabIndex = 5;
            this.btnadicionar.Text = "Adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(286, 187);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(367, 187);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(286, 104);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(37, 20);
            this.txtEstado.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(228, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 59;
            this.label12.Text = "Estado";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(365, 158);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(94, 20);
            this.txtCidade.TabIndex = 58;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(307, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 56;
            this.label11.Text = "Cidade";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(110, 158);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(191, 20);
            this.txtBairro.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Bairro";
            // 
            // txtCEP
            // 
            this.txtCEP.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCEP.Location = new System.Drawing.Point(110, 104);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(100, 20);
            this.txtCEP.TabIndex = 51;
            this.txtCEP.Leave += new System.EventHandler(this.txtCEP_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "CEP";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(110, 130);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(269, 20);
            this.txtEndereco.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Endereço";
            // 
            // dbConsultorioDataSet
            // 
            this.dbConsultorioDataSet.DataSetName = "DbConsultorioDataSet";
            this.dbConsultorioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbConsultorioDataSetBindingSource
            // 
            this.dbConsultorioDataSetBindingSource.DataSource = this.dbConsultorioDataSet;
            this.dbConsultorioDataSetBindingSource.Position = 0;
            // 
            // especialidadsTableAdapter
            // 
            this.especialidadsTableAdapter.ClearBeforeFill = true;
            // 
            // medicosTableAdapter
            // 
            this.medicosTableAdapter.ClearBeforeFill = true;
            // 
            // dbConsultorioDataSet8
            // 
            this.dbConsultorioDataSet8.DataSetName = "DbConsultorioDataSet8";
            this.dbConsultorioDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbConsultorioDataSet7
            // 
            this.dbConsultorioDataSet7.DataSetName = "DbConsultorioDataSet7";
            this.dbConsultorioDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbConsultorioDataSet9
            // 
            this.dbConsultorioDataSet9.DataSetName = "DbConsultorioDataSet9";
            this.dbConsultorioDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbConsultorioDataSet9BindingSource
            // 
            this.dbConsultorioDataSet9BindingSource.DataSource = this.dbConsultorioDataSet9;
            this.dbConsultorioDataSet9BindingSource.Position = 0;
            // 
            // idMedicoDataGridViewTextBoxColumn
            // 
            this.idMedicoDataGridViewTextBoxColumn.DataPropertyName = "IdMedico";
            this.idMedicoDataGridViewTextBoxColumn.HeaderText = "IdMedico";
            this.idMedicoDataGridViewTextBoxColumn.Name = "idMedicoDataGridViewTextBoxColumn";
            this.idMedicoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idEspecialidadeDataGridViewTextBoxColumn
            // 
            this.idEspecialidadeDataGridViewTextBoxColumn.DataPropertyName = "IdEspecialidade";
            this.idEspecialidadeDataGridViewTextBoxColumn.HeaderText = "IdEspecialidade";
            this.idEspecialidadeDataGridViewTextBoxColumn.Name = "idEspecialidadeDataGridViewTextBoxColumn";
            this.idEspecialidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cEPDataGridViewTextBoxColumn
            // 
            this.cEPDataGridViewTextBoxColumn.DataPropertyName = "CEP";
            this.cEPDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cEPDataGridViewTextBoxColumn.Name = "cEPDataGridViewTextBoxColumn";
            this.cEPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ruaDataGridViewTextBoxColumn
            // 
            this.ruaDataGridViewTextBoxColumn.DataPropertyName = "Rua";
            this.ruaDataGridViewTextBoxColumn.HeaderText = "Rua";
            this.ruaDataGridViewTextBoxColumn.Name = "ruaDataGridViewTextBoxColumn";
            this.ruaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "Bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            this.bairroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtEpecialidadeMed);
            this.Controls.Add(this.GridMed);
            this.Controls.Add(this.txtCpfMed);
            this.Controls.Add(this.txtTelMed);
            this.Controls.Add(this.txtNomeMed);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(649, 489);
            this.MinimumSize = new System.Drawing.Size(649, 489);
            this.Name = "FormMedico";
            this.Text = "FormMedico";
            this.Load += new System.EventHandler(this.FormMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioDataSet9BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridMed;
        private System.Windows.Forms.MaskedTextBox txtCpfMed;
        private System.Windows.Forms.MaskedTextBox txtTelMed;
        private System.Windows.Forms.TextBox txtNomeMed;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtEpecialidadeMed;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource dbConsultorioDataSetBindingSource;
        private DbConsultorioDataSet dbConsultorioDataSet;
        private DbConsultorioDataSet1 dbConsultorioDataSet1;
        private System.Windows.Forms.BindingSource especialidadsBindingSource;
        private DbConsultorioDataSet1TableAdapters.EspecialidadsTableAdapter especialidadsTableAdapter;
        private DbConsultorioDataSet6 dbConsultorioDataSet6;
        private System.Windows.Forms.BindingSource medicosBindingSource;
        private DbConsultorioDataSet6TableAdapters.MedicosTableAdapter medicosTableAdapter;
        private DbConsultorioDataSet8 dbConsultorioDataSet8;
        private DbConsultorioDataSet7 dbConsultorioDataSet7;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEspecialidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private DbConsultorioDataSet9 dbConsultorioDataSet9;
        private System.Windows.Forms.BindingSource dbConsultorioDataSet9BindingSource;
    }
}