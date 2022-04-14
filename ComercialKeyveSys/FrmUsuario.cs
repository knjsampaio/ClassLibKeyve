using ClassLibKeyve;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialKeyveSys
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario(Form parent)
        {
            InitializeComponent();
            MdiParent = parent;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Usuario frm = new Usuario(txtusername.Text, txtuseremail.Text);
            frm.Inserir();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
