
namespace Presentacion
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.imageCol = new System.Windows.Forms.ImageList(this.components);
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.mainSolicitud = new System.Windows.Forms.TabPage();
            this.mainReportes = new System.Windows.Forms.TabPage();
            this.mainInsabi = new System.Windows.Forms.TabPage();
            this.mainRespaldo = new System.Windows.Forms.TabPage();
            this.mainUsuario = new System.Windows.Forms.TabPage();
            this.cargaSoli = new MaterialSkin.Controls.MaterialButton();
            this.tabControl.SuspendLayout();
            this.mainSolicitud.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageCol
            // 
            this.imageCol.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageCol.ImageStream")));
            this.imageCol.TransparentColor = System.Drawing.Color.Transparent;
            this.imageCol.Images.SetKeyName(0, "solicitud.png");
            this.imageCol.Images.SetKeyName(1, "buscar.png");
            this.imageCol.Images.SetKeyName(2, "cargar.png");
            this.imageCol.Images.SetKeyName(3, "descarga.png");
            this.imageCol.Images.SetKeyName(4, "descarga1.png");
            this.imageCol.Images.SetKeyName(5, "eliminar.png");
            this.imageCol.Images.SetKeyName(6, "inicio.png");
            this.imageCol.Images.SetKeyName(7, "insabi.png");
            this.imageCol.Images.SetKeyName(8, "reporte.png");
            this.imageCol.Images.SetKeyName(9, "reporte2.png");
            this.imageCol.Images.SetKeyName(10, "usuario.png");
            this.imageCol.Images.SetKeyName(11, "usuarioadd.png");
            this.imageCol.Images.SetKeyName(12, "soli.png");
            this.imageCol.Images.SetKeyName(13, "salida.png");
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.mainSolicitud);
            this.tabControl.Controls.Add(this.mainReportes);
            this.tabControl.Controls.Add(this.mainInsabi);
            this.tabControl.Controls.Add(this.mainRespaldo);
            this.tabControl.Controls.Add(this.mainUsuario);
            this.tabControl.Depth = 0;
            this.tabControl.ImageList = this.imageCol;
            this.tabControl.Location = new System.Drawing.Point(6, 67);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(973, 556);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 1;
            // 
            // mainSolicitud
            // 
            this.mainSolicitud.Controls.Add(this.cargaSoli);
            this.mainSolicitud.ImageKey = "soli.png";
            this.mainSolicitud.Location = new System.Drawing.Point(4, 39);
            this.mainSolicitud.Name = "mainSolicitud";
            this.mainSolicitud.Padding = new System.Windows.Forms.Padding(3);
            this.mainSolicitud.Size = new System.Drawing.Size(965, 513);
            this.mainSolicitud.TabIndex = 0;
            this.mainSolicitud.Text = "Solicitudes";
            this.mainSolicitud.UseVisualStyleBackColor = true;
            // 
            // mainReportes
            // 
            this.mainReportes.ImageKey = "reporte.png";
            this.mainReportes.Location = new System.Drawing.Point(4, 39);
            this.mainReportes.Name = "mainReportes";
            this.mainReportes.Size = new System.Drawing.Size(965, 513);
            this.mainReportes.TabIndex = 1;
            this.mainReportes.Text = "Reportes";
            this.mainReportes.UseVisualStyleBackColor = true;
            // 
            // mainInsabi
            // 
            this.mainInsabi.ImageKey = "insabi.png";
            this.mainInsabi.Location = new System.Drawing.Point(4, 39);
            this.mainInsabi.Name = "mainInsabi";
            this.mainInsabi.Size = new System.Drawing.Size(965, 513);
            this.mainInsabi.TabIndex = 2;
            this.mainInsabi.Text = "Insabi";
            this.mainInsabi.UseVisualStyleBackColor = true;
            // 
            // mainRespaldo
            // 
            this.mainRespaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.mainRespaldo.ImageKey = "descarga.png";
            this.mainRespaldo.Location = new System.Drawing.Point(4, 39);
            this.mainRespaldo.Name = "mainRespaldo";
            this.mainRespaldo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainRespaldo.Size = new System.Drawing.Size(965, 513);
            this.mainRespaldo.TabIndex = 3;
            this.mainRespaldo.Text = "Timbrado";
            this.mainRespaldo.UseVisualStyleBackColor = true;
            // 
            // mainUsuario
            // 
            this.mainUsuario.ImageKey = "usuario.png";
            this.mainUsuario.Location = new System.Drawing.Point(4, 39);
            this.mainUsuario.Name = "mainUsuario";
            this.mainUsuario.Size = new System.Drawing.Size(965, 513);
            this.mainUsuario.TabIndex = 4;
            this.mainUsuario.Text = "Usuarios";
            this.mainUsuario.UseVisualStyleBackColor = true;
            // 
            // cargaSoli
            // 
            this.cargaSoli.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cargaSoli.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cargaSoli.Depth = 0;
            this.cargaSoli.HighEmphasis = true;
            this.cargaSoli.Icon = null;
            this.cargaSoli.Location = new System.Drawing.Point(69, 57);
            this.cargaSoli.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cargaSoli.MouseState = MaterialSkin.MouseState.HOVER;
            this.cargaSoli.Name = "cargaSoli";
            this.cargaSoli.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cargaSoli.Size = new System.Drawing.Size(158, 36);
            this.cargaSoli.TabIndex = 0;
            this.cargaSoli.Text = "Carga Solicitud";
            this.cargaSoli.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cargaSoli.UseAccentColor = false;
            this.cargaSoli.UseVisualStyleBackColor = true;
            this.cargaSoli.Click += new System.EventHandler(this.cargaSoli_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 629);
            this.Controls.Add(this.tabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabControl;
            this.Name = "Menu";
            this.Text = "Explotación de Datos";
            this.tabControl.ResumeLayout(false);
            this.mainSolicitud.ResumeLayout(false);
            this.mainSolicitud.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageCol;
        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage mainSolicitud;
        private System.Windows.Forms.TabPage mainReportes;
        private System.Windows.Forms.TabPage mainInsabi;
        private System.Windows.Forms.TabPage mainRespaldo;
        private System.Windows.Forms.TabPage mainUsuario;
        private MaterialSkin.Controls.MaterialButton cargaSoli;
    }
}