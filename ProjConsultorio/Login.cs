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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void limparcampos()
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();
        }

        public void ll()
        {
            if (txtUsuario.Text == "" && txtSenha.Text == "") //Campos vazios
            {
                MessageBox.Show("Por favor preencha os dados de Usuario e Senha !", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limparcampos();
            }
            else if (txtSenha.Text == "") //txtSenha vazia
            {
                MessageBox.Show("Campo Senha vazio!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limparcampos();
            }
            else if (txtUsuario.Text == "") //txtUsuario vazia
            {
                MessageBox.Show("Campo Usuario vazio!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limparcampos();
            }

            string Usuario = txtUsuario.Text;
            string Senha = txtSenha.Text;
            using (var tb = new Contexto())
            {
                try
                {
                    var objeto = tb.ObjetoManutUser.Where(a => a.Usuario == Usuario).FirstOrDefault();

                    if (objeto != null)
                    {
                        if (objeto.Usuario == Usuario)
                        {
                            if (objeto.Senha == Senha)
                            {

                                MessageBox.Show("Login Efetuado com Sucesso!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                limparcampos();
                                this.Hide();
                                Form abrir = new FormPrincipal();
                                abrir.Closed += (s, args) => this.Close();
                                abrir.Show();

                            }
                            else
                            {
                                MessageBox.Show("Login não Efetuado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                limparcampos();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Login não Efetuado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            limparcampos();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ll();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ll();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ll();
            }
        }
    }
}
