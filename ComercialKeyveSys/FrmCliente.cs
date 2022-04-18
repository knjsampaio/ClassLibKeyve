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
    public partial class dtpDataCad : Form
    {
        public dtpDataCad(Form parent)
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

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvClientes.Rows.Clear();
            List<Cliente> listaDeClientes = Cliente.Listar();
            int cont = listaDeClientes.Count;
            foreach (Cliente cliente in listaDeClientes)
            {
                dgvClientes.Rows.Add();
                dgvClientes.Rows[cont].Cells[0].Value = cliente.Id.ToString();
                dgvClientes.Rows[cont].Cells[0].Value = cliente.Nome.ToString();
                dgvClientes.Rows[cont].Cells[0].Value = cliente.Id.ToString();
                dgvClientes.Rows[cont].Cells[0].Value = cliente.Id.ToString();
                dgvClientes.Rows[cont].Cells[0].Value = cliente.Id.ToString();
                cont++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(btnBuscar.Text == "...")
            {
                txtid.ReadOnly = false;
                txtid.Focus();
                btnBuscar.Text = "Buscar";
            }
            else
            {
                Cliente cliente = Cliente.ConsultarPorId(int.Parse(txtid.Text));
                if (cliente.Id > 0)
                {
                    txtnome.Text = cliente.Id.ToString();
                    txtCpf.Text = cliente.Cpf.ToString();
                    txtEmail.Text = cliente.Email.ToString();
                    dtpDataCad.Value = cliente.DataCad.Date;
                    chkAtivo.Checked = cliente.Ativo;

                    btnBuscar.Text
                }
                else
                {
                    MessageBox.Show("Este código de cliente não existe!");
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            if (cliente.Alterar(int.Parse(txtid.Text),txtnome.Text,txtEmail.Text))
            {
                MessageBox.Show("Cliente alterado com sucesso!");
            }
            else
            {
                MessageBox.Show("Falha na alteração do cliente!");
            }
        }
    }
}
