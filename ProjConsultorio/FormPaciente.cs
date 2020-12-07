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
    public partial class FormPaciente : Form
    {
        public FormPaciente()
        {
            InitializeComponent();
        }
        public void limparcampos()
        {
            txtid.Clear();
            txtNome.Clear();
            txtEndereco.Clear();
            txtTel.Clear();
            txtConvenio.SelectedIndex = -1;
            txtPlano.SelectedIndex = -1;
            txtCpf.Clear();
            txtNumCard.Clear();
            txtNome.Focus();
            txtBairro.Clear();
            txtCEP.Clear();
            txtEstado.Clear();
            txtCidade.Clear();
        }
        private void btnadicionar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var tb = new Contexto())
                {
                    tb.ObjetoPaciente.Add(new Paciente { Nome = txtNome.Text, Telefone = txtTel.Text, CPF = txtCpf.Text,
                        Convenio = txtConvenio.Text, Plano = txtPlano.Text, NumCartao = txtNumCard.Text, 
                    Rua = txtEndereco.Text, CEP = txtCEP.Text, Bairro = txtBairro.Text, Cidade = txtCidade.Text, Estado = txtEstado.Text });
                    tb.SaveChanges();
                    limparcampos();
                    MessageBox.Show("Incluido com Sucesso", "Inclusão");
                    AtualizaGrid();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AtualizaGrid();
        }
        private void AtualizaGrid()
        {
            using (var tb = new Contexto())
            {
                Grid1.DataSource = null;
                Grid1.DataSource = tb.ObjetoPaciente.ToList();
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
                catch (Exception)
                {
                    MessageBox.Show("Campo Cep Inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void txtCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            AtualizaGrid();
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            LocalizaCep();
        }

        private void FormPaciente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbConsultorioDataSet7.Pacientes'. Você pode movê-la ou removê-la conforme necessário.
            this.pacientesTableAdapter.Fill(this.dbConsultorioDataSet7.Pacientes);
            AtualizaGrid();
        }

        private void txtConvenio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            using (var tb = new Contexto())
            {

                try
                {
                    var objeto = tb.ObjetoPaciente.Find(Convert.ToInt32(txtid.Text));
                    objeto.Nome = txtNome.Text;
                    objeto.CEP = txtCEP.Text;
                    objeto.Rua = txtEndereco.Text;
                    objeto.Bairro = txtBairro.Text;
                    objeto.Estado = txtEstado.Text;
                    objeto.Cidade = txtCidade.Text;
                    objeto.Telefone = txtTel.Text;
                    objeto.CPF = txtCpf.Text;
                    objeto.Convenio = txtConvenio.Text;
                    objeto.Plano = txtPlano.Text;
                    objeto.NumCartao = txtNumCard.Text;


                    tb.Entry(objeto).State = EntityState.Modified;
                    tb.SaveChanges();
                    MessageBox.Show("Alteração Concluida", "Alteração");
                    limparcampos();
                    AtualizaGrid();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }

            }
        }

        private void Grid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = Grid1.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = Grid1.CurrentRow.Cells[1].Value.ToString();
            txtTel.Text = Grid1.CurrentRow.Cells[2].Value.ToString();
            txtCpf.Text = Grid1.CurrentRow.Cells[3].Value.ToString();
            txtConvenio.Text = Grid1.CurrentRow.Cells[4].Value.ToString();
            txtPlano.Text = Grid1.CurrentRow.Cells[5].Value.ToString();
            txtNumCard.Text = Grid1.CurrentRow.Cells[6].Value.ToString();
            txtCEP.Text = Grid1.CurrentRow.Cells[7].Value.ToString();
            txtEndereco.Text = Grid1.CurrentRow.Cells[8].Value.ToString();
            txtBairro.Text = Grid1.CurrentRow.Cells[9].Value.ToString();
            txtCidade.Text = Grid1.CurrentRow.Cells[10].Value.ToString();
            txtEstado.Text = Grid1.CurrentRow.Cells[11].Value.ToString();


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                using (var tb = new Contexto())
                {
                    var objeto = tb.ObjetoPaciente.Find(Convert.ToInt32(txtid.Text));
                    tb.ObjetoPaciente.Remove(objeto);
                    tb.SaveChanges();
                    MessageBox.Show("Excluido com Sucesso", "Exclusão");
                    limparcampos();
                    AtualizaGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
