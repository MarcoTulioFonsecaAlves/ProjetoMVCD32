using ProjetoMVCD32.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoMVCD32
{
    public partial class signin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_enviar(object sender, EventArgs e)
        {
            try
            {
                tblClientesDTO clientes = new tblClientesDTO();
                clientes.CPF_Cliente1 = txtCPFD32.Text;
                clientes.Nome_Cliente1 = txtNomeD32.Text;
                clientes.Nome_Mae_Cliente1 = txtNomeMaeD32.Text;
            }
        }
    }
}