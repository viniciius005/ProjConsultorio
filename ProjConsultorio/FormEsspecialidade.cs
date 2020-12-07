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
    public partial class FormEsspecialidade : Form
    {
        public FormEsspecialidade()
        {
            InitializeComponent();
        }

        private void FormEsspecialidade_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }
        public void limparcampos()
        {
            txtEspecialidade.Clear();
        }
        private void AtualizaGrid()
        {
            using (var tb = new Contexto())
            {
                GridEspecialidade.DataSource = null;
                GridEspecialidade.DataSource = tb.ObjetoEspecilidade.ToList();
            }
        }
        private void btnadicionar_Click(object sender, EventArgs e)
        {
            using (var tb = new Contexto())
            {
                tb.ObjetoEspecilidade.Add(new Especialidad { Especialidade = txtEspecialidade.Text });
                tb.SaveChanges();
                MessageBox.Show("Incluido com Sucesso", "Inclusão");
                limparcampos();
                AtualizaGrid();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var tb = new Contexto())
                {
                    var objeto = tb.ObjetoEspecilidade.Find(Convert.ToInt32(txtIdExpecialidade.Text));
                    objeto.Especialidade = txtEspecialidade.Text;
                   

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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                using (var tb = new Contexto())
                {
                    var objeto = tb.ObjetoEspecilidade.Find(Convert.ToInt32(txtIdExpecialidade.Text));
                    tb.ObjetoEspecilidade.Remove(objeto);
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

        private void GridEspecialidade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdExpecialidade.Text = GridEspecialidade.CurrentRow.Cells[0].Value.ToString();
            txtEspecialidade.Text = GridEspecialidade.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
