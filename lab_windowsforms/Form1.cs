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

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Olá, Mundo\nPara de corrigir o professor, Yvan");
            SortColors();
        }

        private void SortColors()
        {
            Color[] colors = {
                Color.Red,
                Color.Green,
                Color.Blue,
                Color.Yellow,
                Color.Orange,
                Color.Purple,
                Color.Pink,
                Color.Brown,
                Color.Gray,
                Color.Black
            };
            Random sorteio = new Random();
            
            int indice = sorteio.Next(colors.Length);
            this.BackColor = colors[indice];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] nomes = { "Raphael", "Wallacy", "Amanda", "Pedro" };

            Random sorteio = new Random();
            int indice = sorteio.Next(nomes.Length);

            this.lbl_titulo.Text = nomes[indice];
        }
    }
}
 