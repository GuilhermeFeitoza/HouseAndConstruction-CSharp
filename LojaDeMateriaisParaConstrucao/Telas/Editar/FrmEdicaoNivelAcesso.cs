using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaDeMateriaisParaConstrucao.Telas.Editar
{
    public partial class FrmEdicaoNivelAcesso : Cadastrar.FrmNIvelAcesso
    {
        
        public FrmEdicaoNivelAcesso()
        {
            InitializeComponent();
        }


        public int CodigoNiv;
     
        private void EditarNivel(object sender, EventArgs e)
        {
            
            BLL.NivelAcesso n = new BLL.NivelAcesso();

            n.CodigoNivelAcesso = CodigoNiv;
            n.NomeNivelAcesso = txtNomeNivelAcesso.Text.ToUpper();
            n.Abreviacao = txtAbrevNivelAcesso.Text;
            n.Descricao = txtDesc.Text;
            n.StatusNivel = 1;

            if (cbUsuarios.Checked)
            {
                n.Permissao_Usuarios = 1;

            }
            else
            { n.Permissao_Usuarios = 0; }

            if (cbClientes.Checked)
            {
                n.Permissao_Clientes = 1;

            }
            else
            {
                n.Permissao_Clientes = 0;
            }
            if (cbFuncionarios.Checked)
            {
                n.Permissao_Funcionarios = 1;
            }
            else
            {
                n.Permissao_Funcionarios = 0;
            }

            if (cbFornecedores.Checked)
            {
                n.Permissao_Fornecedores = 1;
            }
            else
            {
                n.Permissao_Fornecedores = 0;
            }
            if (cbProdutos.Checked)
            {
                n.Permissao_Produtos = 1;
            }
            else
            {
                n.Permissao_Produtos = 0;


            }
            if (cbContas.Checked)
            {
                n.Permissao_Contas = 1;
            }
            else
            {
                n.Permissao_Contas = 0;
            }
            if (cbVender.Checked )
            {
                n.Permissao_Vender = 1;
            }
            else
            {
                n.Permissao_Vender = 0;
            }
            if (cbOrcamento.Checked)
            {
                n.Permissao_Orcamento = 1;
            }
            else
            {
                n.Permissao_Produtos = 0;
            }
           n.AlterarComParametro();

            MessageBox.Show("Editado com sucesso");
            Consultar.ListagemNivelAcesso l = new Consultar.ListagemNivelAcesso();
            l.ShowDialog();
            Close();
           

           
        }
    }
}
