using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjConsultorio
{

    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void btnPaciente_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormPaciente>().Count() > 0)
            {
                MessageBox.Show("A janela já está aberta!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form Paciente = new FormPaciente();
                Paciente.Show();
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMedico_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormMedico>().Count() > 0)
            {
                MessageBox.Show("A janela já está aberta!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form Medico = new FormMedico();
                Medico.Show();
            }
        }
        private void btnEspecialidade_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormEsspecialidade>().Count() > 0)
            {
                MessageBox.Show("A janela já está aberta!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form Especialidade = new FormEsspecialidade();
                Especialidade.Show();
            }
        }
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormConsulta>().Count() > 0)
            {
                MessageBox.Show("A janela já está aberta!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form Consulta = new FormConsulta();
                Consulta.Show();

            }
        }
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ManutencaoUsuario>().Count() > 0)
            {
                MessageBox.Show("A janela já está aberta!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form User = new ManutencaoUsuario();
                User.Show();
            }
        }
    }
}
