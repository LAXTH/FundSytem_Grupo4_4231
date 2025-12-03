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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            SidePanel.Height = btnInicio.Height;
            SidePanel.Top = btnInicio.Top;
            ucInicio1.BringToFront(); 
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnInicio.Height;
            SidePanel.Top = btnInicio.Top;
            ucInicio1.BringToFront();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnProveedor.Height;
            SidePanel.Top = btnProveedor.Top;
            ucProveedor1.BringToFront(); 
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnAlmacen.Height;
            SidePanel.Top = btnAlmacen.Top;
            ucAlmacen1.BringToFront();
        }

        private void btnInsumo_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnInsumo.Height;
            SidePanel.Top = btnInsumo.Top;
            ucInsumo1.BringToFront();
        }

        private void btnGraficas_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnGraficas.Height;
            SidePanel.Top = btnGraficas.Top;
            ucGraficas1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
