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


        DateTime vFecha;
        String vProducto;
        int vCantidad;
        int vPrecioUnitario;


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            vFecha = dateFecha.Value;
            vProducto = lstProducto.Text;
            vCantidad = Convert.ToInt32(lstCantidad.Value);
            vPrecioUnitario = Convert.ToInt32(txtPrecioU.Text);
            lblResultado.Text =
                vFecha.ToString() + " - " + vProducto + " - "
                + vCantidad.ToString() + " - "
                + vPrecioUnitario.ToString();
        }

        private void lstProducto_TextChanged(object sender, EventArgs e)
        {
            if (lstProducto.Text != "")
            {
                lstCantidad.Enabled = true;
            }
            else
            {
                lstCantidad.Enabled = false;
            }
        }


        }
    }