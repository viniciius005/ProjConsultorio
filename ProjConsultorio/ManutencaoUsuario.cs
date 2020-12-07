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
    public partial class ManutencaoUsuario : Form
    {
        public ManutencaoUsuario()
        {
            InitializeComponent();
        }

        public void limparcampos()
        {
            txtNome.Clear();
            txtSobrenome.Clear();
            txtSegundoNome.Clear();
            txtUsuario.Clear();
            txtSenha.Clear();
            txtId.Clear();
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
               

                using (var tb = new Contexto())
                {
                    tb.ObjetoManutUser.Add(new ManutUser { Nome =txtNome.Text , SegundoNome = txtSegundoNome.Text, Sobrenome=txtSobrenome.Text, Usuario = txtUsuario.Text, Senha=txtSenha.Text });
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

       
        private void AtualizaGrid()
        {
            using (var tb = new Contexto())
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = tb.ObjetoManutUser.ToList();
            }
        }

        private void ManutencaoUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbConsultorioDataSet4.ManutUsers'. Você pode movê-la ou removê-la conforme necessário.
            this.manutUsersTableAdapter.Fill(this.dbConsultorioDataSet4.ManutUsers);
            AtualizaGrid();
        }

        private void txtSobrenome_Leave(object sender, EventArgs e)
        {
            if (alterar == 0)
            {
                string nome = txtNome.Text;
                string segundonome = txtSegundoNome.Text;
                string sobrenome = txtSobrenome.Text;

                string usuario;

                if (segundonome == "")
                {
                    usuario = nome + "." + sobrenome;
                    txtUsuario.Text = usuario;
                }
                else
                {
                    string CB = segundonome.Substring(0, 1);
                    usuario = nome + "." + CB + sobrenome;
                    txtUsuario.Text = usuario;
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var tb = new Contexto())
                {
                    alterar = 0;
                    var objeto = tb.ObjetoManutUser.Find(Convert.ToInt32(txtId.Text));                  
                    objeto.Nome = txtNome.Text;
                    objeto.SegundoNome = txtSegundoNome.Text;
                    objeto.Sobrenome = txtSobrenome.Text;
                    objeto.Usuario = txtUsuario.Text;
                    objeto.Senha = txtSenha.Text;
                    tb.Entry(objeto).State = EntityState.Modified;
                    tb.SaveChanges();
                    MessageBox.Show("Alterado com Sucesso", "Alteração");
                    AtualizaGrid();
                    limparcampos();

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
                    var objeto = tb.ObjetoManutUser.Find(Convert.ToInt32(txtId.Text));
                    tb.ObjetoManutUser.Remove(objeto);
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

        int alterar = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            alterar = 1;
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSegundoNome.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtSobrenome.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtUsuario.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSenha.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtUsuario_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LoginADM confirm = new LoginADM();
            confirm.ShowDialog();

            if (confirm.Ladm == 1)
            {
                txtUsuario.ReadOnly = false;
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
