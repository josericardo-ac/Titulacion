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
//Libreria de Archivos
using System.IO;

namespace Sistema_Shajobe
{
    public partial class Respaldo : Form
    {
        public Respaldo()
        {
            InitializeComponent();
        }
        #region Diseño de la forma
        #region Declarando controles de la forma
        private System.Windows.Forms.Button bttn_Copia;
        private System.Windows.Forms.Button bttn_Restaurar;
        private System.Windows.Forms.GroupBox groupBox_Opciones;
        private System.Windows.Forms.Button bttn_Salir;
        private System.Windows.Forms.PictureBox pic_Seguridad;
        #endregion
        private void Diseño_Forma()
        {
            #region Creando controles de la forma
            this.bttn_Copia = new System.Windows.Forms.Button();
            this.bttn_Restaurar = new System.Windows.Forms.Button();
            this.groupBox_Opciones = new System.Windows.Forms.GroupBox();
            this.bttn_Salir = new System.Windows.Forms.Button();
            this.pic_Seguridad = new System.Windows.Forms.PictureBox();
            this.groupBox_Opciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Seguridad)).BeginInit();
            this.SuspendLayout();
            #endregion
            // 
            // bttn_Copia
            // 
            this.bttn_Copia.Location = new System.Drawing.Point(35, 66);
            this.bttn_Copia.Name = "bttn_Copia";
            this.bttn_Copia.Size = new System.Drawing.Size(175, 23);
            this.bttn_Copia.TabIndex = 0;
            this.bttn_Copia.Text = "Realizar copia de seguridad";
            this.bttn_Copia.UseVisualStyleBackColor = true;
            this.bttn_Copia.Click += new System.EventHandler(this.bttn_Copia_Click);
            // 
            // bttn_Restaurar
            // 
            this.bttn_Restaurar.Location = new System.Drawing.Point(35, 122);
            this.bttn_Restaurar.Name = "bttn_Restaurar";
            this.bttn_Restaurar.Size = new System.Drawing.Size(175, 23);
            this.bttn_Restaurar.TabIndex = 1;
            this.bttn_Restaurar.Text = "Restaurar una copia de seguridad";
            this.bttn_Restaurar.UseVisualStyleBackColor = true;
            this.bttn_Restaurar.Click += new System.EventHandler(this.bttn_Restaurar_Click);
            // 
            // groupBox_Opciones
            // 
            this.groupBox_Opciones.Controls.Add(this.bttn_Salir);
            this.groupBox_Opciones.Controls.Add(this.bttn_Restaurar);
            this.groupBox_Opciones.Controls.Add(this.bttn_Copia);
            this.groupBox_Opciones.Location = new System.Drawing.Point(12, 27);
            this.groupBox_Opciones.Name = "groupBox_Opciones";
            this.groupBox_Opciones.Size = new System.Drawing.Size(271, 243);
            this.groupBox_Opciones.TabIndex = 2;
            this.groupBox_Opciones.TabStop = false;
            this.groupBox_Opciones.Text = "Copia de Seguridad y Restauración";
            // 
            // bttn_Salir
            // 
            this.bttn_Salir.Location = new System.Drawing.Point(190, 212);
            this.bttn_Salir.Name = "bttn_Salir";
            this.bttn_Salir.Size = new System.Drawing.Size(75, 23);
            this.bttn_Salir.TabIndex = 4;
            this.bttn_Salir.Text = "Salir";
            this.bttn_Salir.UseVisualStyleBackColor = true;
            this.bttn_Salir.Click += new System.EventHandler(this.bttn_Salir_Click);
            // 
            // pic_Seguridad
            // 
            this.pic_Seguridad.BackgroundImage = global::Sistema_Shajobe.Properties.Resources.Administrative_Tools;
            this.pic_Seguridad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Seguridad.Location = new System.Drawing.Point(228, 9);
            this.pic_Seguridad.Name = "pic_Seguridad";
            this.pic_Seguridad.Size = new System.Drawing.Size(88, 73);
            this.pic_Seguridad.TabIndex = 3;
            this.pic_Seguridad.TabStop = false;
            // 
            // Respaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(327, 282);
            this.ControlBox = false;
            this.Controls.Add(this.pic_Seguridad);
            this.Controls.Add(this.groupBox_Opciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = global::Sistema_Shajobe.Properties.Resources.Administrative_Tools_ICO;
            this.MaximumSize = new System.Drawing.Size(333, 306);
            this.MinimumSize = new System.Drawing.Size(333, 306);
            this.Name = "Respaldo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seguridad";
            this.groupBox_Opciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Seguridad)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion
        private void Respaldo_Load(object sender, EventArgs e)
        {
            #region Animacion
            AnimateWindow(Handle, 350, AnimateWindowFlags.AW_CENTER);
            AnimateWindow(Handle, 450, AnimateWindowFlags.AW_CENTER | AnimateWindowFlags.AW_SLIDE);
            ResumeLayout(false);
            PerformLayout();
            #endregion
            Diseño_Forma();
        }
        #region Eventos
        private void bttn_Copia_Click(object sender, EventArgs e)
        {
            bool desea_respaldar = true;

            //poner cursor de relojito mintras respalda
            Cursor.Current = Cursors.WaitCursor;

            if (Directory.Exists(@"C:\Shajobe\Respaldo"))
            {
                if (File.Exists(@"C:\Shajobe\Respaldo\resp.bak"))
                {
                    if (MessageBox.Show(@"Ya habia un respaldo anteriormente ¿desea remplazarlo?", "Respaldo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        File.Delete(@"C:\Shajobe\Respaldo\resp.bak");
                    }
                    else
                        desea_respaldar = false;
                }
            }
            else
                Directory.CreateDirectory(@"C:\Shajobe\Respaldo");

            if (desea_respaldar)
            { 
                //esto puede ser un método aparte de conexion a la base de datos-----------
                OleDbConnection connect;
                string con = ObtenerString();
                connect = new OleDbConnection(con);
                connect.Open();
                //-------------------------------------------------------------------------

                //esto puede ser un método aparte para ejecutar comandos SQL---------------
                OleDbCommand command;
                command = new OleDbCommand(@"backup database SHAJOBE to disk ='C:\Shajobe\Respaldo\resp.bak' with init,stats=10", connect);
                command.ExecuteNonQuery();
                //-------------------------------------------------------------------------

                connect.Close();
                MessageBox.Show("El Respaldo de la base de datos fue realizado satisfactoriamente", "Respaldo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void bttn_Restaurar_Click(object sender, EventArgs e)
        {
            //poner cursor de relojito
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                if (File.Exists(@"C:\Shajobe\Respaldo\resp.bak"))
                {
                    if (MessageBox.Show("¿Está seguro de restaurar?", "Respaldo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //esto puede ser un método aparte de conexion a la base de datos-----------
                        OleDbConnection connect;
                        string con = ObtenerString();
                        connect = new OleDbConnection(con);
                        connect.Open();
                        //--------------------------------------------------------------------------

                        //esto puede ser un método aparte para ejecutar comandos SQL----------------
                        OleDbCommand command;
                        command = new OleDbCommand("use master", connect);
                        command.ExecuteNonQuery();
                        command = new OleDbCommand(@"restore database SHAJOBE from disk = 'C:\Shajobe\Respaldo\resp.bak' WITH REPLACE", connect);
                        command.ExecuteNonQuery();
                        //--------------------------------------------------------------------------
                        connect.Close();

                        MessageBox.Show("Se ha restaurado la base de datos", "Restauración", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show(@"No haz hecho ningun respaldo anteriormente (o no está en la ruta correcta)", "Restauracion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void bttn_Salir_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Menu_principal"].Activate();
            this.Close();
        }
        //-------------------------------------------------------------
        //-------------------------CONEXION----------------------------
        //-------------------------------------------------------------
        #region Cadena de conexión
        //OBTIENE LA CADENA DE CONEXION
        public static string ObtenerString()
        {
            return Settings.Default.SHAJOBEConnectionString;
        }
        #endregion
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
