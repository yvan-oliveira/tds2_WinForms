using lab_windowsforms.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_windowsforms
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal(Login usuarioAutenticado)
        {
            InitializeComponent();

            this.strFuncionario.Text = usuarioAutenticado.UserName;
            this.strFuncao.Text = usuarioAutenticado.UserProfile;
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O Senhor é o ");
        }

        private void pessoaFisicaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
