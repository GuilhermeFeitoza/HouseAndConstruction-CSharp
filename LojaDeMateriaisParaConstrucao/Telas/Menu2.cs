using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace LojaDeMateriaisParaConstrucao.Telas
{
    public partial class Menu2 : Form
    {
        public  int CodigoUsuario;
        public Menu2()
        {
            InitializeComponent();
            Exibir();
         
            BLL.Usuario u = new BLL.Usuario();
             CodigoUsuario = u.CodigoUsuario;

        }
        public int CodigoUsuarioLogado;
      
      
        private void BuscarNivelAcesso(object o ,EventArgs e )
        {
            try { 


            CodigoUsuarioLogado = Convert.ToInt32(lblNivel.Text);

            BLL.NivelAcesso n = new BLL.NivelAcesso();

            n.CodigoNivelAcesso = CodigoUsuarioLogado;
            System.Data.SqlClient.SqlDataReader ddr;
            ddr = n.Consultar();
            ddr.Read();

            if (ddr.HasRows)
            {

                lblNivel.Text = Convert.ToString(ddr["NomeNivelAcesso"]);
                    if (Convert.ToByte(ddr["Permissao_Clientes"]) == 0)
                    {
                        btnClientes.Enabled = false;
                    }
                    if (Convert.ToByte(ddr["Permissao_Usuarios"]) == 0)
                    {
                        btnUsuario.Enabled = false;
                    }

                    if (Convert.ToByte(ddr["Permissao_Funcionarios"]) == 0)
                    {
                        btnFuncionarios.Enabled = false;

                    }
                    if (Convert.ToByte(ddr["Permissao_Fornecedores"]) == 0)
                    {
                        btnFornecedores.Enabled = false;
                    }
                    if (Convert.ToByte(ddr["Permissao_Produtos"]) == 0)
                    {
                        btnProdutos.Enabled = false;

                    }
                    if (Convert.ToByte(ddr["Permissao_Contas"]) == 0)
                    {
                        btnContas.Enabled = false;
                    }
                    if (Convert.ToByte(ddr["Permissao_Vender"]) == 0)
                    {
                        btnVender.Enabled = false;
                        btnPedido.Enabled = false;
                    }
                    if (Convert.ToByte(ddr["Permissao_Orcamento"]) == 0)
                    {
                        btnOrcamentos.Enabled = false;
                    }

                }
                else {
                    lblNivel.Text = "Sem Nivel";




                }
            
            

            }
            catch (Exception ex)
            {

                throw ex;
            }



        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 60;
            }
            else
            {
                MenuVertical.Width = 250;
            }


            if (MenuVertical.Width == 60)
            {
                painelContender.Width = 1243;
                ResumoInicio r = new ResumoInicio();
                r.Width = 1243;




            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        public void AbrirFormInPanel(object Formhijo)
        {
            if (this.painelContender.Controls.Count > 0)
                this.painelContender.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.painelContender.Controls.Add(fh);
            this.painelContender.Tag = fh;
            fh.Show();
        }

          private void btnlogoInicio_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Telas.ResumoInicio());
        }

        private void Exibir() {
            AbrirFormInPanel(new Telas.ResumoInicio());
        }

        private void ExibirFuncionarios(object o, EventArgs e)
        {


            AbrirFormInPanel(new Telas.Menus.FrmMenuFuncionario());







        }
        public void AbrirEstoque()
        {


            AbrirFormInPanel(new FrmAlertaEstoque());


            

        }
        private void ExibirFornecedores(object o, EventArgs e)
        {


            AbrirFormInPanel(new Telas.Menus.FrmMenuFornecedores());






        }

        private void ExibirUsuarios(object o , EventArgs e) {


            AbrirFormInPanel(new Telas.Menus.FrmMenuUsuario());






        }
        private void ExibirClientes(object o, EventArgs e)
        {


            AbrirFormInPanel(new Telas.Menus.FrmMenuClientes());

                    }


        private void ExibirContasAPagar(object o , EventArgs e) {


            AbrirFormInPanel(new Telas.Menus.FrmMenuConta());






        }
        private void AbrirFornecedor(object o , EventArgs e) {

            Telas.Consultar.FrmListagemFornecedores f = new Consultar.FrmListagemFornecedores();
            f.ShowDialog();



        }

        private void AbrirProduto(object o, EventArgs e) {

            AbrirFormInPanel(new Telas.Menus.FrmMenuProdutos());


        }






        private void AbrirContas(object o, EventArgs e) {

            Telas.Contas_a_pagar.FrmGestaoDeContasAPagar cp = new Contas_a_pagar.FrmGestaoDeContasAPagar();
            cp.ShowDialog();

        }






        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void AbrirCliente(object o , EventArgs e) {

            Telas.Consultar.FrmListagemClientes f = new Telas.Consultar.FrmListagemClientes();
            f.ShowDialog();





        }
        private void AbrirUsuario(object o, EventArgs e)
        {

            Telas.Consultar.FrmConsultaUsuario f = new Consultar.FrmConsultaUsuario();
             f.ShowDialog();





        }

        private void Menu2_Load(object sender, EventArgs e)
        {
            btnlogoInicio_Click(null, e);
        }

        private void AbrirFuncionario(object o , EventArgs e) {

            Telas.Consultar.FrmListagemFuncionario f = new Telas.Consultar.FrmListagemFuncionario();
            f.ShowDialog();

        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Exibir();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
        
            AbrirFormInPanel(new Menus.FrmMenuVendas());
        }

        private void btnOrcamentos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Menus.FrmMenuOrcamento());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dispose();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Menus.FrmMenuPedido());
        }

        private void btnFaleConosco_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FaleConosco.FrmPainelFaleConosco());
        }

        private void AbrirCupom(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Menus.FrmMenuCupons());

        }
    }
}
