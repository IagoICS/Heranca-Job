using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_heranca
{
    public partial class Professor : Form
    {
        public Professor()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();

        }

        private void txtidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbltitulacao_Click(object sender, EventArgs e)
        {

        }

        private void lblidade_Click(object sender, EventArgs e)
        {

        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void txttilulacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnexibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(professor.ImprimeDados);
        }

        private void btncadprof_Click(object sender, EventArgs e)
        {
            professor = new Professor2(txtnome.Text, (Convert.ToInt32(txtidade.Text)), txttilulacao.Text);
          txtnome.Clear();
            txtidade.Clear();
            txttilulacao.Clear();
        }
        
    }
}
