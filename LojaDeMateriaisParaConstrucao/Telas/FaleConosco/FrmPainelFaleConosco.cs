using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaDeMateriaisParaConstrucao.Telas.FaleConosco
{
    public partial class FrmPainelFaleConosco : Form
    {
      
        public FrmPainelFaleConosco()
        {
            InitializeComponent();
        }

    
        
        BLL.FaleConosco f = new BLL.FaleConosco();
        BLL.Usuario usu = new BLL.Usuario();
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmPainelFaleConosco_Load(object sender, EventArgs e)
        {
           
            try
            {

                panel1.Visible = false;
                dataGridView1.Location = new Point(33, 6);
                //BLL.FaleConosco f = new BLL.FaleConosco();
                //System.Data.SqlClient.SqlDataReader ddr;
                //ddr = f.RetornarMensagem(f.RetornarMensagemMaisAntiga());
                //ddr.Read();
                //if (ddr.HasRows)
                //{
                //    CodigoDaMensagemAtual = Convert.ToInt32(ddr["CodigoContato"]);
                //    lblNome.Text = Convert.ToString(ddr["NomeContato"]);
                //    lblEmail.Text = Convert.ToString(ddr["EmailContato"]);
                //    lblAssunto.Text = Convert.ToString(ddr["AssuntoContato"]);
                //    if (ddr["DataContato"]!=null)
                //    {
                //        lblData.Text = Convert.ToString(ddr["DataContato"]);
                //    }

                //    lblTel.Text = Convert.ToString(ddr["TelContato"]);
                //    txtMensagem.Text = Convert.ToString(ddr["Mensagem"]);
                //    if (Convert.ToInt32(ddr["StatusContato"])==0)
                //    {
                //        bunifuFlatButton1.Visible = true;
                //        groupResposta.Visible = false;
                //        lblStatus.Text = "Aguardando resposta";
                //        pcbStatus.Visible = false;
                //        pcbStatus2.Visible = true;

                //    }
                //    if (Convert.ToInt32(ddr["StatusContato"]) == 1)
                //    {
                //        bunifuFlatButton1.Visible = false;
                //        groupResposta.Visible = true;
                //        lblStatus.Text = "Respondida";
                //        pcbStatus.Visible = true;
                //        pcbStatus2.Visible = false;
                //        txtResposta.Text = Convert.ToString(ddr["Resposta"]);
                //        lblUsuario.Text = Convert.ToString(ddr["NomeUsuario"]);


                //    }

                //}


                dataGridView1.DataSource = f.ListarMensagem().Tables[0];
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
             
            }

        

        }

    

 

     

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
          
            Telas.FaleConosco.FrmResponderFaleConosco f = new FrmResponderFaleConosco();
            f.Codigo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            f.lblNome.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            f.lblEmail.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            f.lblAssunto.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            f.lblTel.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            f.lblData.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);

            f.ShowDialog();
            FrmPainelFaleConosco_Load(sender,e);
        }

        private void txtMensagem_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Visible = true;
            dataGridView1.Location = new Point(33, 384);
            if (Convert.ToInt32(dataGridView1.CurrentRow.Cells[7].Value) == 1)//Respondida
            {
                //33; 384
              
                bunifuFlatButton1.Visible = false;
                groupResposta.Visible = true;
                lblStatus.Text = "Respondida";
                pcbStatus.Visible = true;
                pcbStatus2.Visible = false;
                txtResposta.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[8].Value);
                lblUsuario.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[9].Value);
                int CodigoUsu = Convert.ToInt32(lblUsuario.Text);
                BLL.Usuario u = new BLL.Usuario();
                System.Data.SqlClient.SqlDataReader ddr2;

                u.CodigoUsuario = CodigoUsu;
                ddr2 = u.Consultar();
                ddr2.Read();
                if (ddr2.HasRows)
                {
                    lblUsuario.Text = Convert.ToString(ddr2["NomeUsuario"]);
                }


            }
            if (Convert.ToInt32(dataGridView1.CurrentRow.Cells[7].Value) == 0)
            {
                bunifuFlatButton1.Visible = true;
                groupResposta.Visible = false;
                lblStatus.Text = "Aguardando resposta";
               pcbStatus.Visible = false;
                pcbStatus2.Visible = true; 

            }
            lblNome.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            lblEmail.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            lblAssunto.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            lblTel.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            lblData.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            txtMensagem.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value); 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xuiCheckBox2_CheckedStateChanged(object sender, EventArgs e)
        {
           
        }
    }
    }

