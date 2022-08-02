using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin.Properties;
using cBusiness;

namespace Presentacion
{
    public partial class Menu : MaterialSkin.Controls.MaterialForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void cargaSoli_Click(object sender, EventArgs e)
        {
            CargaSolicitud carga = new CargaSolicitud();
            this.Hide();
            carga.Show();
            cargaSoli.Hide();
            
        }
    }
}
