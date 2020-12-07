namespace ProjConsultorio
{
    partial class FormConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsulta));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtMedico = new System.Windows.Forms.ComboBox();
            this.medicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbConsultorioDataSet2 = new ProjConsultorio.DbConsultorioDataSet2();
            this.txtPaciente = new System.Windows.Forms.ComboBox();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbConsultorioDataSet3 = new ProjConsultorio.DbConsultorioDataSet3();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.GridConsulta = new System.Windows.Forms.DataGridView();
            this.txtExame = new System.Windows.Forms.TextBox();
            this.medicosTableAdapter = new ProjConsultorio.DbConsultorioDataSet2TableAdapters.MedicosTableAdapter();
            this.pacientesTableAdapter = new ProjConsultorio.DbConsultorioDataSet3TableAdapters.PacientesTableAdapter();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.dbConsultorioDataSet5 = new ProjConsultorio.DbConsultorioDataSet5();
            this.consultasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultasTableAdapter = new ProjConsultorio.DbConsultorioDataSet5TableAdapters.ConsultasTableAdapter();
            this.idConsultaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMedicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosticoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Paciente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data / Hora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Exame";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Diagnostico";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(265, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Valor";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(94, 13);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(30, 20);
            this.txtId.TabIndex = 45;
            // 
            // txtMedico
            // 
            this.txtMedico.DataSource = this.medicosBindingSource;
            this.txtMedico.DisplayMember = "Nome";
            this.txtMedico.FormattingEnabled = true;
            this.txtMedico.Location = new System.Drawing.Point(94, 49);
            this.txtMedico.Name = "txtMedico";
            this.txtMedico.Size = new System.Drawing.Size(121, 21);
            this.txtMedico.TabIndex = 0;
            this.txtMedico.ValueMember = "IdMedico";
            // 
            // medicosBindingSource
            // 
            this.medicosBindingSource.DataMember = "Medicos";
            this.medicosBindingSource.DataSource = this.dbConsultorioDataSet2;
            // 
            // dbConsultorioDataSet2
            // 
            this.dbConsultorioDataSet2.DataSetName = "DbConsultorioDataSet2";
            this.dbConsultorioDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPaciente
            // 
            this.txtPaciente.DataSource = this.pacientesBindingSource;
            this.txtPaciente.DisplayMember = "Nome";
            this.txtPaciente.FormattingEnabled = true;
            this.txtPaciente.Location = new System.Drawing.Point(94, 83);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(121, 21);
            this.txtPaciente.TabIndex = 1;
            this.txtPaciente.ValueMember = "IdPaciente";
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "Pacientes";
            this.pacientesBindingSource.DataSource = this.dbConsultorioDataSet3;
            // 
            // dbConsultorioDataSet3
            // 
            this.dbConsultorioDataSet3.DataSetName = "DbConsultorioDataSet3";
            this.dbConsultorioDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(97, 117);
            this.txtData.Mask = "00/00/0000 90:00";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 2;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Location = new System.Drawing.Point(315, 98);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(342, 90);
            this.txtDiagnostico.TabIndex = 5;
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(37, 163);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(75, 23);
            this.btnadicionar.TabIndex = 6;
            this.btnadicionar.Text = "Adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(118, 163);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(199, 163);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // GridConsulta
            // 
            this.GridConsulta.AllowUserToAddRows = false;
            this.GridConsulta.AllowUserToDeleteRows = false;
            this.GridConsulta.AutoGenerateColumns = false;
            this.GridConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idConsultaDataGridViewTextBoxColumn,
            this.idMedicoDataGridViewTextBoxColumn,
            this.idPacienteDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.diagnosticoDataGridViewTextBoxColumn,
            this.exameDataGridViewTextBoxColumn});
            this.GridConsulta.DataSource = this.consultasBindingSource;
            this.GridConsulta.Location = new System.Drawing.Point(12, 205);
            this.GridConsulta.Name = "GridConsulta";
            this.GridConsulta.ReadOnly = true;
            this.GridConsulta.Size = new System.Drawing.Size(646, 233);
            this.GridConsulta.TabIndex = 18;
            this.GridConsulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridConsulta_CellClick);
            this.GridConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridConsulta_CellContentClick);
            // 
            // txtExame
            // 
            this.txtExame.Location = new System.Drawing.Point(315, 43);
            this.txtExame.Multiline = true;
            this.txtExame.Name = "txtExame";
            this.txtExame.Size = new System.Drawing.Size(342, 49);
            this.txtExame.TabIndex = 4;
            // 
            // medicosTableAdapter
            // 
            this.medicosTableAdapter.ClearBeforeFill = true;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(315, 16);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 3;
            // 
            // dbConsultorioDataSet5
            // 
            this.dbConsultorioDataSet5.DataSetName = "DbConsultorioDataSet5";
            this.dbConsultorioDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultasBindingSource
            // 
            this.consultasBindingSource.DataMember = "Consultas";
            this.consultasBindingSource.DataSource = this.dbConsultorioDataSet5;
            // 
            // consultasTableAdapter
            // 
            this.consultasTableAdapter.ClearBeforeFill = true;
            // 
            // idConsultaDataGridViewTextBoxColumn
            // 
            this.idConsultaDataGridViewTextBoxColumn.DataPropertyName = "IdConsulta";
            this.idConsultaDataGridViewTextBoxColumn.HeaderText = "ConsultaId";
            this.idConsultaDataGridViewTextBoxColumn.Name = "idConsultaDataGridViewTextBoxColumn";
            this.idConsultaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idMedicoDataGridViewTextBoxColumn
            // 
            this.idMedicoDataGridViewTextBoxColumn.DataPropertyName = "IdMedico";
            this.idMedicoDataGridViewTextBoxColumn.HeaderText = "MedicoId";
            this.idMedicoDataGridViewTextBoxColumn.Name = "idMedicoDataGridViewTextBoxColumn";
            this.idMedicoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idPacienteDataGridViewTextBoxColumn
            // 
            this.idPacienteDataGridViewTextBoxColumn.DataPropertyName = "IdPaciente";
            this.idPacienteDataGridViewTextBoxColumn.HeaderText = "PacienteId";
            this.idPacienteDataGridViewTextBoxColumn.Name = "idPacienteDataGridViewTextBoxColumn";
            this.idPacienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diagnosticoDataGridViewTextBoxColumn
            // 
            this.diagnosticoDataGridViewTextBoxColumn.DataPropertyName = "Diagnostico";
            this.diagnosticoDataGridViewTextBoxColumn.HeaderText = "Diagnostico";
            this.diagnosticoDataGridViewTextBoxColumn.Name = "diagnosticoDataGridViewTextBoxColumn";
            this.diagnosticoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // exameDataGridViewTextBoxColumn
            // 
            this.exameDataGridViewTextBoxColumn.DataPropertyName = "Exame";
            this.exameDataGridViewTextBoxColumn.HeaderText = "Exame";
            this.exameDataGridViewTextBoxColumn.Name = "exameDataGridViewTextBoxColumn";
            this.exameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Controls.Add(this.GridConsulta);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtExame);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.txtMedico);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(692, 489);
            this.MinimumSize = new System.Drawing.Size(692, 489);
            this.Name = "FormConsulta";
            this.Text = "FormConsulta";
            this.Load += new System.EventHandler(this.FormConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox txtMedico;
        private System.Windows.Forms.ComboBox txtPaciente;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView GridConsulta;
        private System.Windows.Forms.TextBox txtExame;
        private DbConsultorioDataSet2 dbConsultorioDataSet2;
        private System.Windows.Forms.BindingSource medicosBindingSource;
        private DbConsultorioDataSet2TableAdapters.MedicosTableAdapter medicosTableAdapter;
        private DbConsultorioDataSet3 dbConsultorioDataSet3;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private DbConsultorioDataSet3TableAdapters.PacientesTableAdapter pacientesTableAdapter;
        private System.Windows.Forms.TextBox txtValor;
        private DbConsultorioDataSet5 dbConsultorioDataSet5;
        private System.Windows.Forms.BindingSource consultasBindingSource;
        private DbConsultorioDataSet5TableAdapters.ConsultasTableAdapter consultasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idConsultaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosticoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exameDataGridViewTextBoxColumn;
    }
}