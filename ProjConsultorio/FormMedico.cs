using ProjConsultorio.Correios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjConsultorio
{
    public partial class FormMedico : Form
    {
        public FormMedico()
        {
            InitializeComponent();
        }
        private void AtualizaGrid()
        {
            using (var tb = new Contexto())
            {
                GridMed.DataSource = null;
                GridMed.DataSource = tb.ObjetoMedico.ToList();
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                using (var tb = new Contexto())
                {
                    var objeto = tb.ObjetoMedico.Find(Convert.ToInt32(txtid.Text));
                    tb.ObjetoMedico.Remove(objeto);
                    tb.SaveChanges();
                    MessageBox.Show("Excluido com Sucesso", "Exclusão");
                    limparcampos();
                    AtualizaGrid();
                }
            }
            catch
            {

            }
        }
        public void limparcampos()
        {
            txtid.Clear();
            txtNomeMed.Clear();
            txtCEP.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtTelMed.Clear();
            txtCpfMed.Clear();
            txtEpecialidadeMed.SelectedIndex = -1;
        }
        private void btnadicionar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var tb = new Contexto())
                {
                    tb.ObjetoMedico.Add(new Medico { IdEspecialidade = Convert.ToInt32(txtEpecialidadeMed.SelectedValue), Nome = txtNomeMed.Text, Telefone = txtTelMed.Text, CPF = txtCpfMed.Text, CEP = txtCEP.Text, Rua = txtEndereco.Text, Bairro = txtBairro.Text, Cidade = txtCidade.Text, Estado = txtEstado.Text });
                    tb.SaveChanges();
                    limparcampos();
                    MessageBox.Show("Incluido com Sucesso", "Inclusão");
                    AtualizaGrid();
                }

            }

            catch
            {


            }

        }
        private void LocalizaCep()
        {
            using (var ws = new Correios.AtendeClienteClient())
            {
                try
                {


                    var resultado = ws.consultaCEP(txtCEP.Text);
                    txtEstado.Text = resultado.uf;

                    txtCidade.Text = resultado.cidade;

                    txtBairro.Text = resultado.bairro;

                    txtEndereco.Text = resultado.end;
                }
                catch
                {
                    MessageBox.Show("Campo Cep Inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormMedico_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbConsultorioDataSet6.Medicos'. Você pode movê-la ou removê-la conforme necessário.
            this.medicosTableAdapter.Fill(this.dbConsultorioDataSet6.Medicos);
            // TODO: esta linha de código carrega dados na tabela 'dbConsultorioDataSet1.Especialidads'. Você pode movê-la ou removê-la conforme necessário.
            this.especialidadsTableAdapter.Fill(this.dbConsultorioDataSet1.Especialidads);
            AtualizaGrid();

        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            LocalizaCep();
        }

        private void GridMed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var tb = new Contexto())
                {
                    var objeto = tb.ObjetoMedico.Find(Convert.ToInt32(txtid.Text));
                    objeto.IdEspecialidade = Convert.ToInt32(txtEpecialidadeMed.SelectedValue);
                    objeto.Nome = txtNomeMed.Text;
                    objeto.Telefone = txtTelMed.Text;
                    objeto.CPF = txtCpfMed.Text;
                    objeto.CEP = txtCEP.Text;
                    objeto.Rua = txtEndereco.Text;
                    objeto.Bairro = txtBairro.Text;
                    objeto.Cidade = txtCidade.Text;
                    objeto.Estado = txtEstado.Text;

                    tb.Entry(objeto).State = EntityState.Modified;
                    tb.SaveChanges();
                    MessageBox.Show("Alterado com Sucesso", "Alteração");
                    AtualizaGrid();

                }
            }
            catch
            {


            }
        }

        private void GridMed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = GridMed.CurrentRow.Cells[0].Value.ToString();

            using (var tb = new Contexto())
                try
                {
                    int especialidadeid;

                    especialidadeid = Convert.ToInt32(GridMed.CurrentRow.Cells[1].Value);
                    var objeto = tb.ObjetoEspecilidade.Find(especialidadeid);
                    txtEpecialidadeMed.Text = objeto.Especialidade;
                    
                }
                catch
                {
                }
            txtNomeMed.Text = GridMed.CurrentRow.Cells[2].Value.ToString();
            txtTelMed.Text = GridMed.CurrentRow.Cells[3].Value.ToString();
            txtCpfMed.Text = GridMed.CurrentRow.Cells[4].Value.ToString();
            txtCEP.Text = GridMed.CurrentRow.Cells[5].Value.ToString();
            txtEndereco.Text = GridMed.CurrentRow.Cells[6].Value.ToString();
            txtBairro.Text = GridMed.CurrentRow.Cells[7].Value.ToString();
            txtCidade.Text = GridMed.CurrentRow.Cells[8].Value.ToString();
            txtEstado.Text = GridMed.CurrentRow.Cells[9].Value.ToString();

        }
    }
}
