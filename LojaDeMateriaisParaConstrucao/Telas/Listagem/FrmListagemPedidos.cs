using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaDeMateriaisParaConstrucao.Telas.Listagem
{
    public partial class FrmListagemPedidos : Modelos.FrmConsulta
    {
        public FrmListagemPedidos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void CarregarDadosGrid()
        {
            try
            {
                BLL.Pedido ped = new BLL.Pedido();
                dataGridView1.DataSource = ped.Listar(textBox1.Text.Trim().ToUpper(), 1).Tables[0];
                textBox1.Focus();

                if (dataGridView1.Rows.Count == 0)
                {
                    btnEditar.Enabled = false;
                    btnConsultar.Enabled = false;
                    btnDesativar.Enabled = false;
                    btnAtivar.Enabled = false;
                    btnExcluir.Enabled = false;
                }
                else
                {
                    btnEditar.Enabled = true;
                    btnConsultar.Enabled = true;
                    btnDesativar.Enabled = true;
                    btnAtivar.Enabled = true;
                    btnExcluir.Enabled = true;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
        private void Exibir(Object o, EventArgs e)
        {
            CarregarDadosGrid();
            if (o == btnfiltrar)
            {
                textBox1.Text = String.Empty;
            }
            textBox1.Focus();

        }






    }
}
