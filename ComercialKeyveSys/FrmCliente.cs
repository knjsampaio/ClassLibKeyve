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
    public partial class FrmCliente : Form
    {
        public FrmCliente(Form parent)
        {
            InitializeComponent();

            MdiParent = parent;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente(txtnome.Text, txtCpf.Text, txtEmail.Text);
            c.Inserir();
            if (c.Id > 0)
            {
                txtid.Text = c.Id.ToString();
                MessageBox.Show("Cliente gravado com sucesso!");
            }
            else
            {
                MessageBox.Show("Falha ao inserir cliente.");
            }
        }
    }
}
