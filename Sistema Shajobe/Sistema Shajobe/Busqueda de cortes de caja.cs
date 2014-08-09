using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Librerias Agregadas 
using System.Data.OleDb;//Establece el tipo de conexion a la base de datos
using System.Configuration;//Establecemos comunicacion con la libreria de configuracion para poder hacer uso del App.Config
using Sistema_Shajobe.Properties;//Nos permite tener acceso y control sobre las propiedades del proyecto en este caso la direccion del appconfig y entre otros
//Librerias de Animacion
using System.Runtime.InteropServices;

namespace Sistema_Shajobe
{
    public partial class Busqueda_de_cortes_de_caja : Form
    {
        public Busqueda_de_cortes_de_caja()
        {
            InitializeComponent();
        }
        #region Diseño
        #region Declarando controles
        private System.Windows.Forms.Button bttn_Consultar;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_Apartir;
        private System.Windows.Forms.Label lbl_Hasta;
        private System.Windows.Forms.MonthCalendar monthCalendar_Muestra;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Apartir;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Hasta;
        private System.Windows.Forms.PictureBox picture_Imagen;
        #endregion
        private void Diseño_Ventana()
        {
            #region Creando controles
            this.bttn_Consultar = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_Apartir = new System.Windows.Forms.Label();
            this.lbl_Hasta = new System.Windows.Forms.Label();
            this.monthCalendar_Muestra = new System.Windows.Forms.MonthCalendar();
            this.dateTimePicker_Apartir = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Hasta = new System.Windows.Forms.DateTimePicker();
            this.picture_Imagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Imagen)).BeginInit();
            this.SuspendLayout();
            #endregion
            #region Diseñando controles
            // 
            // bttn_Consultar
            // 
            this.bttn_Consultar.Location = new System.Drawing.Point(377, 103);
            this.bttn_Consultar.Name = "bttn_Consultar";
            this.bttn_Consultar.Size = new System.Drawing.Size(75, 23);
            this.bttn_Consultar.TabIndex = 0;
            this.bttn_Consultar.Text = "Consultar";
            this.bttn_Consultar.UseVisualStyleBackColor = true;
            this.bttn_Consultar.Click += new System.EventHandler(this.bttn_Consultar_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(64, 34);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(221, 13);
            this.lbl_Titulo.TabIndex = 1;
            this.lbl_Titulo.Text = "Seleccione el periodo de la busqueda";
            // 
            // lbl_Apartir
            // 
            this.lbl_Apartir.AutoSize = true;
            this.lbl_Apartir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apartir.Location = new System.Drawing.Point(64, 72);
            this.lbl_Apartir.Name = "lbl_Apartir";
            this.lbl_Apartir.Size = new System.Drawing.Size(44, 13);
            this.lbl_Apartir.TabIndex = 2;
            this.lbl_Apartir.Text = "Apartir";
            // 
            // lbl_Hasta
            // 
            this.lbl_Hasta.AutoSize = true;
            this.lbl_Hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hasta.Location = new System.Drawing.Point(64, 108);
            this.lbl_Hasta.Name = "lbl_Hasta";
            this.lbl_Hasta.Size = new System.Drawing.Size(40, 13);
            this.lbl_Hasta.TabIndex = 3;
            this.lbl_Hasta.Text = "Hasta";
            // 
            // monthCalendar_Muestra
            // 
            this.monthCalendar_Muestra.Location = new System.Drawing.Point(131, 162);
            this.monthCalendar_Muestra.Name = "monthCalendar_Muestra";
            this.monthCalendar_Muestra.TabIndex = 4;
            // 
            // dateTimePicker_Apartir
            // 
            this.dateTimePicker_Apartir.Location = new System.Drawing.Point(131, 65);
            this.dateTimePicker_Apartir.Name = "dateTimePicker_Apartir";
            this.dateTimePicker_Apartir.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_Apartir.TabIndex = 5;
            // 
            // dateTimePicker_Hasta
            // 
            this.dateTimePicker_Hasta.Location = new System.Drawing.Point(131, 102);
            this.dateTimePicker_Hasta.Name = "dateTimePicker_Hasta";
            this.dateTimePicker_Hasta.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_Hasta.TabIndex = 6;
            // 
            // picture_Imagen
            // 
            this.picture_Imagen.BackgroundImage = global::Sistema_Shajobe.Properties.Resources.Reportes;
            this.picture_Imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_Imagen.Location = new System.Drawing.Point(19, 162);
            this.picture_Imagen.Name = "picture_Imagen";
            this.picture_Imagen.Size = new System.Drawing.Size(89, 66);
            this.picture_Imagen.TabIndex = 7;
            this.picture_Imagen.TabStop = false;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(470, 343);
            this.Controls.Add(this.picture_Imagen);
            this.Controls.Add(this.dateTimePicker_Hasta);
            this.Controls.Add(this.dateTimePicker_Apartir);
            this.Controls.Add(this.monthCalendar_Muestra);
            this.Controls.Add(this.lbl_Hasta);
            this.Controls.Add(this.lbl_Apartir);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.bttn_Consultar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(476, 367);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(476, 367);
            this.Name = "Busqueda_de_cortes_de_caja";
            this.Text = "Periodo de corte de caja";
            this.Icon = global::Sistema_Shajobe.Properties.Resources.Caja_ICO;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reportes_FormClosing);
            this.Load += new System.EventHandler(this.Busqueda_de_cortes_de_caja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_Imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            #endregion
        }
        #endregion
        private void Busqueda_de_cortes_de_caja_Load(object sender, EventArgs e)
        {
            #region Animacion
            AnimateWindow(Handle, 350, AnimateWindowFlags.AW_CENTER);
            AnimateWindow(Handle, 450, AnimateWindowFlags.AW_CENTER | AnimateWindowFlags.AW_SLIDE);
            ResumeLayout(false);
            PerformLayout();
            #endregion
            Diseño_Ventana();
        }
        #region Eventos
        private void bttn_Consultar_Click(object sender, EventArgs e)
        {
            string Apartir= dateTimePicker_Apartir.Value.ToString();
            string Hasta= dateTimePicker_Hasta.Value.ToString();
            Reporte_Caja rc = new Reporte_Caja();
            rc.recibe_DatoA(Apartir);
            rc.recibe_DatoH(Hasta);
            rc.Show();
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
