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
    public partial class frm_formulario_de_cadastro : Form
    {
        public frm_formulario_de_cadastro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] nomes = { "Raphael", "Wallacy", "Amanda", "Pedro" };

            Random sorteio = new Random();
            int indice = sorteio.Next(nomes.Length);

            this.lbl_titulo.Text = nomes[indice];
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            string nome = this.txt_nome.Text;
            string endereco = this.txt_endereco.Text;
            string dtNascimento = this.dtp_nascimento.Text;
            string cpf = this.mtb_cpf.Text;
            string telefone = this.mtb_telefone.Text;
            string genero = this.cmb_genero.SelectedItem?.ToString() ?? "Não informado";

            MessageBox.Show($"Nome: {nome}\n" +
                            $"Endereço: {endereco}\n" +
                            $"Nascimento: {dtNascimento}\n" +
                            $"CPF: {cpf}\n" +
                            $"Telefone: {telefone}\n" +
                            $"Genero: {genero}\n");
        }
    }
}
 