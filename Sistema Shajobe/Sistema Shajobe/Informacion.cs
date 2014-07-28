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
    public partial class Informacion : Form
    {
        public Informacion()
        {
            InitializeComponent();
        }
        #region Diseño de la forma
        #region Declarando controles de la forma
        private System.Windows.Forms.Label lbl_CorreoElectronico;
        private System.Windows.Forms.Label lbl_Contraseña;
        private System.Windows.Forms.Label lbl_Confirmacion;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Button bttn_Guardar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbl_Ser;
        private System.Windows.Forms.ComboBox combo_Servidor;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Telefono;
        private System.Windows.Forms.TextBox txt_Confirmacion;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.TextBox txt_CorreoElectronico;
        #endregion
        private void Diseño_Forma()
        {
            #region Creando controles de la forma
            this.components = new System.ComponentModel.Container();
            this.lbl_CorreoElectronico = new System.Windows.Forms.Label();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.lbl_Confirmacion = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.bttn_Guardar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_CorreoElectronico = new System.Windows.Forms.TextBox();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.txt_Confirmacion = new System.Windows.Forms.TextBox();
            this.maskedTextBox_Telefono = new System.Windows.Forms.MaskedTextBox();
            this.combo_Servidor = new System.Windows.Forms.ComboBox();
            this.lbl_Ser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            #endregion
            // 
            // lbl_CorreoElectronico
            // 
            this.lbl_CorreoElectronico.AutoSize = true;
            this.lbl_CorreoElectronico.Location = new System.Drawing.Point(25, 31);
            this.lbl_CorreoElectronico.Name = "lbl_CorreoElectronico";
            this.lbl_CorreoElectronico.Size = new System.Drawing.Size(93, 13);
            this.lbl_CorreoElectronico.TabIndex = 0;
            this.lbl_CorreoElectronico.Text = "Correo electronico";
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.Location = new System.Drawing.Point(25, 66);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(61, 13);
            this.lbl_Contraseña.TabIndex = 1;
            this.lbl_Contraseña.Text = "Contraseña";
            // 
            // lbl_Confirmacion
            // 
            this.lbl_Confirmacion.AutoSize = true;
            this.lbl_Confirmacion.Location = new System.Drawing.Point(25, 101);
            this.lbl_Confirmacion.Name = "lbl_Confirmacion";
            this.lbl_Confirmacion.Size = new System.Drawing.Size(108, 13);
            this.lbl_Confirmacion.TabIndex = 2;
            this.lbl_Confirmacion.Text = "Confirmar Contraseña";
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Location = new System.Drawing.Point(25, 136);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(49, 13);
            this.lbl_Telefono.TabIndex = 3;
            this.lbl_Telefono.Text = "Teléfono";
            // 
            // bttn_Guardar
            // 
            this.bttn_Guardar.Location = new System.Drawing.Point(270, 126);
            this.bttn_Guardar.Name = "bttn_Guardar";
            this.bttn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.bttn_Guardar.TabIndex = 4;
            this.bttn_Guardar.Text = "Guardar";
            this.bttn_Guardar.UseVisualStyleBackColor = true;
            this.bttn_Guardar.Click += new System.EventHandler(this.bttn_Guardar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txt_CorreoElectronico
            // 
            this.txt_CorreoElectronico.Location = new System.Drawing.Point(139, 24);
            this.txt_CorreoElectronico.MaxLength = 25;
            this.txt_CorreoElectronico.Name = "txt_CorreoElectronico";
            this.txt_CorreoElectronico.Size = new System.Drawing.Size(100, 20);
            this.txt_CorreoElectronico.TabIndex = 5;
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Location = new System.Drawing.Point(139, 59);
            this.txt_Contraseña.MaxLength = 15;
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.PasswordChar = '*';
            this.txt_Contraseña.Size = new System.Drawing.Size(100, 20);
            this.txt_Contraseña.TabIndex = 6;
            // 
            // txt_Confirmacion
            // 
            this.txt_Confirmacion.Location = new System.Drawing.Point(139, 94);
            this.txt_Confirmacion.MaxLength = 15;
            this.txt_Confirmacion.Name = "txt_Confirmacion";
            this.txt_Confirmacion.PasswordChar = '*';
            this.txt_Confirmacion.Size = new System.Drawing.Size(100, 20);
            this.txt_Confirmacion.TabIndex = 7;
            // 
            // maskedTextBox_Telefono
            // 
            this.maskedTextBox_Telefono.Location = new System.Drawing.Point(139, 129);
            this.maskedTextBox_Telefono.Mask = "000-000-0000";
            this.maskedTextBox_Telefono.Name = "maskedTextBox_Telefono";
            this.maskedTextBox_Telefono.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_Telefono.TabIndex = 8;
            // 
            // combo_Servidor
            // 
            this.combo_Servidor.FormattingEnabled = true;
            this.combo_Servidor.Items.AddRange(new object[] {
            "hotmail.com",
            "live.com.mx",
            "gmail.com",
            "yahoo.com.mx"});
            this.combo_Servidor.Location = new System.Drawing.Point(270, 23);
            this.combo_Servidor.Name = "combo_Servidor";
            this.combo_Servidor.Size = new System.Drawing.Size(121, 21);
            this.combo_Servidor.TabIndex = 9;
            // 
            // lbl_Ser
            // 
            this.lbl_Ser.AutoSize = true;
            this.lbl_Ser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ser.Location = new System.Drawing.Point(245, 28);
            this.lbl_Ser.Name = "lbl_Ser";
            this.lbl_Ser.Size = new System.Drawing.Size(19, 13);
            this.lbl_Ser.TabIndex = 10;
            this.lbl_Ser.Text = "@";
            // 
            // Informacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 166);
            this.Controls.Add(this.lbl_Ser);
            this.Controls.Add(this.combo_Servidor);
            this.Controls.Add(this.maskedTextBox_Telefono);
            this.Controls.Add(this.txt_Confirmacion);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.txt_CorreoElectronico);
            this.Controls.Add(this.bttn_Guardar);
            this.Controls.Add(this.lbl_Telefono);
            this.Controls.Add(this.lbl_Confirmacion);
            this.Controls.Add(this.lbl_Contraseña);
            this.Controls.Add(this.lbl_CorreoElectronico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(415, 190);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(415, 190);
            this.Name = "Informacion";
            this.Text = "Información del negocio";
            this.Load += new System.EventHandler(this.Informacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private void Informacion_Load(object sender, EventArgs e)
        {
            // REALIZA ANIMACION EN LA VENTANA
            #region Animacion
            AnimateWindow(Handle, 350, AnimateWindowFlags.AW_CENTER);
            AnimateWindow(Handle, 450, AnimateWindowFlags.AW_CENTER | AnimateWindowFlags.AW_SLIDE);
            ResumeLayout(false);
            PerformLayout();
            #endregion
            // CREA Y DISEÑA LA VENTANA
            Diseño_Forma();
            // SELECCIONA POR DEFECTO EL SERVIDOR DE HOTMAIL
            combo_Servidor.SelectedIndex = 0;
        }
        #region Eventos
        private void bttn_Guardar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            //  CODIGO QUE FALTA PARA VERIFICAR QUE TODOS LOS CAMPOS ESTEN LLENOS
            if (txt_Contraseña.Text.Trim()=="" || txt_Confirmacion.Text.Trim()=="")
            {
                
            }
            else
            {
                if (txt_Contraseña.Text==txt_Confirmacion.Text)
                {
                    //CODIGO QUE FALTA PARA GUARDAR
                }
                else
                {
                    errorProvider1.SetError(txt_Contraseña,"La contraseña no son iguales");
                    errorProvider1.SetError(txt_Confirmacion, "La contraseña no son iguales");
                    MessageBox.Show("Verifique la contraseña porfavor", "Contraseña no son iguales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
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
