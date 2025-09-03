using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAppRegistros
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void lstProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProducto.Text != "")
                {
                lblCantidad.Enabled = true;
                 }
            else
                {
                lblCantidad.Enabled = false;
                }
        }
    }
}
