using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibKeyve;

namespace ComercialKeyveSys
{
    public partial class FrmProduto : Form
    {
        public FrmProduto(Form parent)
        {
            InitializeComponent();

            MdiParent = parent;
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtdescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente(txtdescricao.Text, txtunidade.Text, txtcodbar.Text);
            c.Inserir();
            
        }
    }
}
