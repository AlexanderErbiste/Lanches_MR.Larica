using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Lanchonete
{

    public partial class frmLanchonete : Form
    {
        int contItem = 0;
        public frmLanchonete()
        {
            InitializeComponent();
        }

        private void btnResumo_Click(object sender, EventArgs e)
        {
            //tabControl_Detalhes.SelectedIndex = 2;
            tabControl_Detalhes.SelectedTab = tpResumo;
        }

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            tabControl_Detalhes.Enabled = true;

            if (lblNumPed.Text == "?")
            {
                lblNumPed.Text = "1";
            }
            else
            {
                lblNumPed.Text = (int.Parse(lblNumPed.Text) + 1).ToString();
            }
            dtpDataPed.Value = DateTime.Now;
            btnCancelar.Enabled = true;
            txtCliente.Focus();

        }

        private void btnLançarItens_Click(object sender, EventArgs e)
        {
            tabControl_Detalhes.SelectedTab = tpItens;
        }

        private void cmbProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPreçoL.SelectedIndex = cmbProduto.SelectedIndex;
            txtQtd.Text = "1";
            lblTotal.Text = (double.Parse(cmbPreçoL.Text.Substring(2))
                * int.Parse(txtQtd.Text)).ToString("C");
            txtQtd.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora: " + DateTime.Now.ToString("hh:mm:ss");
        }

        private void txtQtd_TextChanged(object sender, EventArgs e)
        {
            if (txtQtd.Text == "0" || txtQtd.Text == "")
            {
                txtQtd.Text = "1";
            }
            lblTotal.Text = (double.Parse(cmbPreçoL.Text.Substring(2))
                * int.Parse(txtQtd.Text)).ToString("C");
        }

        private void txtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada não é um dígito e não é a tecla Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Se for um caractere inválido, cancela o evento
                e.Handled = true;
            }
        }

        private void txtQtd_Enter(object sender, EventArgs e)
        {
            txtQtd.SelectAll();
        }

        private void cmbProdutos_DropDown(object sender, EventArgs e)
        {

        }

        private void btnAdicionaItem_Click(object sender, EventArgs e)
        {
            if (cmbProduto.SelectedIndex != 0 || cmbBebida.SelectedIndex != 0)
            {
                if (cmbProduto.SelectedIndex != 0)
                {
                    dgvItens.Rows.Add(++contItem, cmbProduto.SelectedItem, txtQtd.Text, cmbPreçoL.SelectedItem, lblTotal.Text.Substring(2));
                    lblTotalPed.Text =
                        (double.Parse(lblTotalPed.Text.Substring(3)) +
                        double.Parse(lblTotal.Text.Substring(2))).ToString("C");
                    dgvItens.FirstDisplayedScrollingRowIndex = dgvItens.Rows.Count - 1;
                }

                if (cmbBebida.SelectedIndex != 0)
                {
                    dgvItens.Rows.Add("", cmbBebida.Text, "", "");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbBebida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBebida.SelectedIndex != 0)
            {
                dgvItens.Rows.Add("", cmbBebida.Text, "", "");
            }
        }
    }
}