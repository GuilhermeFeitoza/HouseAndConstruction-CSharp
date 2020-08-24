using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaDeMateriaisParaConstrucao.Telas.Orcamento
{
    public partial class FrmListagemOrcamento : Telas.Venda.FrmListagemVendas
    {
        public FrmListagemOrcamento()
        {
            InitializeComponent();
            Venda.FrmListagemVendas v = new Venda.FrmListagemVendas();
            
        }
    }
}
