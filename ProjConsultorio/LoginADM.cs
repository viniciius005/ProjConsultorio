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
    public partial class LoginADM : Form
    {
        public LoginADM()
        {
            InitializeComponent();
        }
        public int Ladm { get; set; }

        public void limparcampos()
        {
            txtusuario.Clear();
            txtsenha.Clear();
            txtusuario.Focus();
        }

        public void ll()
        {
            string xUsuario = txtusuario.Text;
            string xSenha = txtsenha.Text;


            using (var tb = new Contexto())
            {
                var objeto = tb.ObjetoManutUser.Where(a => a.Usuario == xUsuario).FirstOrDefault();


                if (objeto != null)
                {
                    if (objeto.Usuario == xUsuario)
                    {
                        if (objeto.Usuario == "adm")
                        {
                            if (objeto.Senha == xSenha)
                            {
                                Ladm = 1;
                                this.Close();
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


        private void btnLogar_Click(object sender, EventArgs e)
        {
            ll();
        }

        private void txtusuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ll();
            }
        }

        private void txtsenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ll();
            }
        }

        private void LoginADM_Load(object sender, EventArgs e)
        {

        }
    }
}
