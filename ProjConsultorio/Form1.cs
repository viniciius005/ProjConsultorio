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
            Form Paciente = new FormPaciente();
            Paciente.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            Form Medico = new FormMedico();
            Medico.Show();
        }

        private void btnEspecialidade_Click(object sender, EventArgs e)
        {
            Form Especialidade = new FormEsspecialidade();
            Especialidade.Show();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Form Consulta = new FormConsulta();
            Consulta.Show();
        }
    }
}
