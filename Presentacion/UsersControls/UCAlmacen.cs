using Presentacion.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class UCAlmacen : UserControl
    {
        public UCAlmacen()
        {
            InitializeComponent();
        }

        private void btnAgregarAlmacen_Click(object sender, EventArgs e)
        {
            Form Agregar = new FormAgregarAlmacen();
            Agregar.ShowDialog();
        }
    }
}
