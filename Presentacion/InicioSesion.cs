using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cBusiness;
using cCommon.Temp;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin.Properties;

namespace Presentacion
{
    public partial class InicioSesion : MaterialForm
    {
        public InicioSesion()
        {
            InitializeComponent();
            /*
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.LightBlue400, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, Accent.Orange700, MaterialSkin.TextShade.WHITE);
            */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try {
                if (usertxt.Text != "Usuario" && usertxt.TextLength >4)
                {
                    if (passtext.Text != "Contraseña" && passtext.TextLength > 3)
                    {
                        UserModel user = new UserModel();
                        var validLogin = user.LoginUser(usertxt.Text, passtext.Text);
                        if (validLogin == true)
                        {
                            Menu mainMenu = new Menu();
                            this.Hide();
                            mainMenu.Show();
                        }
                        else
                        {
                            MessageBox.Show("Datos erroneos");
                        }
                    }
                    else MessageBox.Show("El tamaño y/o formato de la contraseña no es valido.");
                }
                else MessageBox.Show("Por favor ingresar un usuario valido.");
            }
            catch (Exception )
            {
                MessageBox.Show("Ha ocurrido un error en la conexión");
            }
            
        }
    }
}
