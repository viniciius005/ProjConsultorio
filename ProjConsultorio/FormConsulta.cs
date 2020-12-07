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
    public partial class FormConsulta : Form
    {
        public FormConsulta()
        {
            InitializeComponent();
        }

        public void limparcampos()
        {
            txtId.Clear();
            txtData.Clear();
            txtValor.Clear();
            txtExame.Clear();
            txtDiagnostico.Clear();
        }

        private void FormConsulta_Load(object sender, EventArgs e)
        {

            this.consultasTableAdapter.Fill(this.dbConsultorioDataSet5.Consultas);

            this.pacientesTableAdapter.Fill(this.dbConsultorioDataSet3.Pacientes);

            this.medicosTableAdapter.Fill(this.dbConsultorioDataSet2.Medicos);
            AtualizaGrid();
        }
        private void AtualizaGrid()
        {
            using (var tb = new Contexto())
            {
                GridConsulta.DataSource = null;
                GridConsulta.DataSource = tb.ObjetoConsulta.ToList();
            }
        }
        private void btnadicionar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var tb = new Contexto())
                {
                    tb.ObjetoConsulta.Add(new Consulta { IdMedico = Convert.ToInt32(txtMedico.SelectedValue), IdPaciente = Convert.ToInt32(txtPaciente.SelectedValue), Data = Convert.ToDateTime(txtData.Text), Valor = Convert.ToDouble(txtValor.Text), Diagnostico = txtDiagnostico.Text, Exame = txtExame.Text });
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

        private void GridConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var tb = new Contexto())
                {
                    var objeto = tb.ObjetoConsulta.Find(Convert.ToInt32(txtId.Text));
                    objeto.IdMedico = Convert.ToInt32(txtMedico.SelectedValue);
                    objeto.IdPaciente = Convert.ToInt32(txtPaciente.SelectedValue);
                    objeto.Data = Convert.ToDateTime(txtData.Text);
                    objeto.Valor = Convert.ToDouble(txtValor.Text);
                    objeto.Exame = txtExame.Text;
                    objeto.Diagnostico = txtDiagnostico.Text;

                    tb.Entry(objeto).State = EntityState.Modified;
                    tb.SaveChanges();
                    MessageBox.Show("Alterado com Sucesso", "Alteração");
                    AtualizaGrid();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void GridConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = GridConsulta.CurrentRow.Cells[0].Value.ToString();

            using (var tb = new Contexto())
            {
                try
                {
                    int medicID;

                    medicID = Convert.ToInt32(GridConsulta.CurrentRow.Cells[1].Value);
                    var objeto = tb.ObjetoMedico.Find(medicID);
                    txtMedico.Text = objeto.Nome;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                using (var tb1 = new Contexto())
                {
                    try
                    {
                        int medicID;

                        medicID = Convert.ToInt32(GridConsulta.CurrentRow.Cells[2].Value);
                        var objeto = tb1.ObjetoPaciente.Find(medicID);
                        txtPaciente.Text = objeto.Nome;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                    txtData.Text = GridConsulta.CurrentRow.Cells[3].Value.ToString();
                    txtValor.Text = GridConsulta.CurrentRow.Cells[4].Value.ToString();
                    txtDiagnostico.Text = GridConsulta.CurrentRow.Cells[5].Value.ToString();
                    txtExame.Text = GridConsulta.CurrentRow.Cells[6].Value.ToString();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                using (var tb = new Contexto())
                {
                    var objeto = tb.ObjetoConsulta.Find(Convert.ToInt32(txtId.Text));
                    tb.ObjetoConsulta.Remove(objeto);
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
