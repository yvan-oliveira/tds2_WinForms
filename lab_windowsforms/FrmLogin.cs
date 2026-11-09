using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_windowsforms.Classes
{
    public partial class FrmLogin : Form
    {
        List<Login> users = new List<Login>();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

            Login user1 = new Login(1, "Arthur Silva", "admin_arthur@gmail.com", "1234", "Administrador");
            Login user2 = new Login(2, "Luan Bispo", "user_luan@gmail.com", "1234", "Operador");
            Login user3 = new Login(3, "Amanda Costa", "guest_amanda @gmail.com", "1234", "Operador");

            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string textoLogin = this.txtLogin.Text;
            string textoSenha = this.txtSenha.Text;

            if (string.IsNullOrWhiteSpace(textoLogin))
            {
                this.txtLogin.BackColor = Color.Red;
                MessageBox.Show("O login de usuário NÃO PODE SER VAZIO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSenha.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textoSenha))
            {
                this.txtSenha.BackColor = Color.Red;
                MessageBox.Show("A senha de usuário NÃO PODE SER VAZIA", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSenha.Focus();
                return;
            }

            Login usuarioEncontrado = users.FirstOrDefault(usuario => usuario.Authenticate(textoLogin, textoSenha));
        
            
            if (usuarioEncontrado == null)
            {
                MessageBox.Show("Usuário NÃO encontrado", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Bem-vindo, {usuarioEncontrado.UserName}");
                FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal(usuarioEncontrado);
                this.Hide();
                frmMenuPrincipal.Show();
            }

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            this.txtLogin.BackColor = Color.White;  
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            this.txtSenha.BackColor = Color.White;
        }
    }
}
