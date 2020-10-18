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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMedico));
            this.GridMed = new System.Windows.Forms.DataGridView();
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
            this.Endereço = new System.Windows.Forms.Label();
            this.txtEnderecoMed = new System.Windows.Forms.TextBox();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridMed)).BeginInit();
            this.SuspendLayout();
            // 
            // GridMed
            // 
            this.GridMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMed.Location = new System.Drawing.Point(33, 163);
            this.GridMed.Name = "GridMed";
            this.GridMed.Size = new System.Drawing.Size(569, 284);
            this.GridMed.TabIndex = 20;
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
            this.txtEpecialidadeMed.FormattingEnabled = true;
            this.txtEpecialidadeMed.Location = new System.Drawing.Point(108, 48);
            this.txtEpecialidadeMed.Name = "txtEpecialidadeMed";
            this.txtEpecialidadeMed.Size = new System.Drawing.Size(150, 21);
            this.txtEpecialidadeMed.TabIndex = 0;
            // 
            // Endereço
            // 
            this.Endereço.AutoSize = true;
            this.Endereço.Location = new System.Drawing.Point(40, 107);
            this.Endereço.Name = "Endereço";
            this.Endereço.Size = new System.Drawing.Size(53, 13);
            this.Endereço.TabIndex = 9;
            this.Endereço.Text = "Endereço";
            // 
            // txtEnderecoMed
            // 
            this.txtEnderecoMed.Location = new System.Drawing.Point(108, 104);
            this.txtEnderecoMed.Name = "txtEnderecoMed";
            this.txtEnderecoMed.Size = new System.Drawing.Size(269, 20);
            this.txtEnderecoMed.TabIndex = 2;
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(205, 130);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(75, 23);
            this.btnadicionar.TabIndex = 5;
            this.btnadicionar.Text = "Adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(286, 130);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(367, 130);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // FormMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtEpecialidadeMed);
            this.Controls.Add(this.GridMed);
            this.Controls.Add(this.txtCpfMed);
            this.Controls.Add(this.txtTelMed);
            this.Controls.Add(this.txtEnderecoMed);
            this.Controls.Add(this.txtNomeMed);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Endereço);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(649, 489);
            this.MinimumSize = new System.Drawing.Size(649, 489);
            this.Name = "FormMedico";
            this.Text = "FormMedico";
            ((System.ComponentModel.ISupportInitialize)(this.GridMed)).EndInit();
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
        private System.Windows.Forms.Label Endereço;
        private System.Windows.Forms.TextBox txtEnderecoMed;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
    }
}