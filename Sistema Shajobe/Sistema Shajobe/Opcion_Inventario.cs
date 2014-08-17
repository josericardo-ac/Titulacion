using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sistema_Shajobe.Properties;//Nos permite tener acceso y control sobre las propiedades del proyecto en este caso la direccion del appconfig y entre otros
//Librerias de Animacion
using System.Runtime.InteropServices;
namespace Sistema_Shajobe
{
    public partial class Opcion_Inventario : Form
    {
        public Opcion_Inventario()
        {
            InitializeComponent();
        }
        #region Diseño de la ventana
        #region Declarando controles
        private System.Windows.Forms.GroupBox groupBox_Opcion;
        private System.Windows.Forms.Button bttn_Consultar;
        private System.Windows.Forms.RadioButton radioButton_InventarioProducto;
        private System.Windows.Forms.RadioButton radioButton_InventarioMateriaPrima;
        private System.Windows.Forms.PictureBox pictureBox_Inv;
        #endregion
        #region Diseño
        private void Diseño_Ventana()
        {
            #region Creando controles
             this.groupBox_Opcion = new System.Windows.Forms.GroupBox();
            this.radioButton_InventarioMateriaPrima = new System.Windows.Forms.RadioButton();
            this.radioButton_InventarioProducto = new System.Windows.Forms.RadioButton();
            this.bttn_Consultar = new System.Windows.Forms.Button();
            this.pictureBox_Inv = new System.Windows.Forms.PictureBox();
            this.groupBox_Opcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Inv)).BeginInit();
            this.SuspendLayout();
            #endregion
            #region Diseñando controles
            // 
            // groupBox_Opcion
            // 
            this.groupBox_Opcion.Controls.Add(this.bttn_Consultar);
            this.groupBox_Opcion.Controls.Add(this.radioButton_InventarioProducto);
            this.groupBox_Opcion.Controls.Add(this.radioButton_InventarioMateriaPrima);
            this.groupBox_Opcion.Location = new System.Drawing.Point(12, 78);
            this.groupBox_Opcion.Name = "groupBox_Opcion";
            this.groupBox_Opcion.Size = new System.Drawing.Size(260, 122);
            this.groupBox_Opcion.TabIndex = 0;
            this.groupBox_Opcion.TabStop = false;
            this.groupBox_Opcion.Text = "Seleccione una opción";
            // 
            // radioButton_InventarioMateriaPrima
            // 
            this.radioButton_InventarioMateriaPrima.AutoSize = true;
            this.radioButton_InventarioMateriaPrima.Location = new System.Drawing.Point(20, 19);
            this.radioButton_InventarioMateriaPrima.Name = "radioButton_InventarioMateriaPrima";
            this.radioButton_InventarioMateriaPrima.Size = new System.Drawing.Size(162, 17);
            this.radioButton_InventarioMateriaPrima.TabIndex = 0;
            this.radioButton_InventarioMateriaPrima.TabStop = true;
            this.radioButton_InventarioMateriaPrima.Text = "Información de Materia Prima";
            this.radioButton_InventarioMateriaPrima.UseVisualStyleBackColor = true;
            // 
            // radioButton_InventarioProducto
            // 
            this.radioButton_InventarioProducto.AutoSize = true;
            this.radioButton_InventarioProducto.Location = new System.Drawing.Point(20, 42);
            this.radioButton_InventarioProducto.Name = "radioButton_InventarioProducto";
            this.radioButton_InventarioProducto.Size = new System.Drawing.Size(140, 17);
            this.radioButton_InventarioProducto.TabIndex = 1;
            this.radioButton_InventarioProducto.TabStop = true;
            this.radioButton_InventarioProducto.Text = "Información de producto";
            this.radioButton_InventarioProducto.UseVisualStyleBackColor = true;
            // 
            // bttn_Consultar
            // 
            this.bttn_Consultar.Location = new System.Drawing.Point(167, 70);
            this.bttn_Consultar.Name = "bttn_Consultar";
            this.bttn_Consultar.Size = new System.Drawing.Size(75, 23);
            this.bttn_Consultar.TabIndex = 2;
            this.bttn_Consultar.Text = "Consultar";
            this.bttn_Consultar.UseVisualStyleBackColor = true;
            this.bttn_Consultar.Click += new System.EventHandler(this.bttn_Consultar_Click);
            // 
            // pictureBox_Inv
            // 
            this.pictureBox_Inv.BackgroundImage = global::Sistema_Shajobe.Properties.Resources.Inventario;
            this.pictureBox_Inv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Inv.Location = new System.Drawing.Point(102, 12);
            this.pictureBox_Inv.Name = "pictureBox_Inv";
            this.pictureBox_Inv.Size = new System.Drawing.Size(92, 64);
            this.pictureBox_Inv.TabIndex = 1;
            this.pictureBox_Inv.TabStop = false;
            // 
            // Opcion_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(284, 215);
            this.Controls.Add(this.pictureBox_Inv);
            this.Controls.Add(this.groupBox_Opcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(290, 243);
            this.MinimumSize = new System.Drawing.Size(290, 243);
            this.Icon = global::Sistema_Shajobe.Properties.Resources.Inventario_ICO;
            this.Name = "Opcion_Inventario";
            this.Text = "Opcion Inventario";
            this.groupBox_Opcion.ResumeLayout(false);
            this.groupBox_Opcion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Inv)).EndInit();
            this.ResumeLayout(false);
            #endregion
        }
        #endregion
        #endregion
        private void Opcion_Inventario_Load(object sender, EventArgs e)
        {
            #region Animacion
            AnimateWindow(Handle, 350, AnimateWindowFlags.AW_CENTER);
            AnimateWindow(Handle, 450, AnimateWindowFlags.AW_CENTER | AnimateWindowFlags.AW_SLIDE);
            ResumeLayout(false);
            PerformLayout();
            #endregion
            Diseño_Ventana();
        }
        private void Opcion_Inventario_FormClosing(object sender, FormClosingEventArgs e)
        {
            //-------------------------------------------------------------
            //-------------------AL CERRAR LA VENTANA----------------------
            //-------------------------------------------------------------
            Dispose();
            Application.OpenForms["Menu_principal"].Activate();
        }
        #region Eventos
        private void bttn_Consultar_Click(object sender, EventArgs e)
        {
            if (radioButton_InventarioMateriaPrima.Checked==true)
            {
                Reporte_Informacion_de_inventario_materia_prima rm = new Reporte_Informacion_de_inventario_materia_prima();
                rm.Show();
            }
            else if (radioButton_InventarioProducto.Checked==true)
            {
                Reporte_informacion_de_inventario_de_producto rp = new Reporte_informacion_de_inventario_de_producto();
                rp.Show();
            }
        }
        //-------------------------------------------------------------
        //-------------------AL CERRAR LA VENTANA----------------------
        //-------------------------------------------------------------
        private void Reportes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            Application.OpenForms["Menu_principal"].Activate();
        }
        #endregion
        #region Animación de la forma
        // 
        //EFECTOS VENTANA
        //
        [DllImport("user32.dll")]
        static extern bool AnimateWindow(IntPtr hWnd, int time, AnimateWindowFlags flags);
        [Flags]
        enum AnimateWindowFlags
        {
            AW_HOR_POSITIVE = 0x00000001,
            AW_HOR_NEGATIVE = 0x00000002,
            AW_VER_POSITIVE = 0x00000004,
            AW_VER_NEGATIVE = 0x00000008,
            AW_CENTER = 0x00000010,
            AW_HIDE = 0x00010000,
            AW_ACTIVATE = 0x00020000,
            AW_SLIDE = 0x00040000,
            AW_BLEND = 0x00080000
        }
        #endregion
    }
}
