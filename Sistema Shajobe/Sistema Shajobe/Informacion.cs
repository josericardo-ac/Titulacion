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
            this.txt_CorreoElectronico.MaxLength = 30;
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
            this.combo_Servidor.KeyPress += new KeyPressEventHandler(NoescrituracomboBox_KeyPress);
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(196)))));
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(Informacion_FormClosing);
            this.Icon = global::Sistema_Shajobe.Properties.Resources.Vista_ICO;
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
            // SELECCIONA DATOS POR DEFECTO EL SERVIDOR
            Cargar_Datos();
        }
        #region Eventos
        private void Cargar_Datos()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "SELECT * FROM V_Informacion";
            coman.CommandType = CommandType.Text;
            con.Open();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Declarando Variables y obteniendo los valores correspondiente
                txt_CorreoElectronico.Text = dr.GetString(dr.GetOrdinal("Correo"));
                txt_Contraseña.Text = dr.GetString(dr.GetOrdinal("Contraseña"));
                txt_Confirmacion.Text = dr.GetString(dr.GetOrdinal("Contraseña"));
                int indice= dr.GetInt32(dr.GetOrdinal("Servidor"));
                indice--;
                combo_Servidor.SelectedIndex = indice;
                maskedTextBox_Telefono.Text = dr.GetString(dr.GetOrdinal("Telefono"));
            }
            con.Close();
        }
        private void bttn_Guardar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool i = Verificar_CamposVacios();
            if (i == true)
            {
                MessageBox.Show("Inserta todos los datos marcados", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (maskedTextBox_Telefono.Text.Trim()=="")
            {
                MessageBox.Show("Inserta todos los datos marcados", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorProvider1.SetError(maskedTextBox_Telefono, "No puedes dejar el campo vacio");
            }
            else if(i==false && maskedTextBox_Telefono.Text !="")
            {
                if (txt_Contraseña.Text==txt_Confirmacion.Text)
                {
                    OleDbConnection conexion = null;
                    OleDbTransaction transaccion = null;
                    try
                    {
                        conexion = new OleDbConnection(ObtenerString());
                        conexion.Open();
                        transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                        OleDbCommand comando = new OleDbCommand("SP_Informacion_Modificar", conexion, transaccion);
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@Correo", txt_CorreoElectronico.Text);
                        comando.Parameters.AddWithValue("@Servidor", combo_Servidor.SelectedIndex+1);
                        comando.Parameters.AddWithValue("@Contraseña", txt_Contraseña.Text);
                        comando.Parameters.AddWithValue("@Telefono", maskedTextBox_Telefono.Text);
                        comando.ExecuteNonQuery();
                        transaccion.Commit();
                        conexion.Close();
                        MessageBox.Show("Datos guardados con éxito", "Solicitud procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ha ocurrido un error inesperado", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    errorProvider1.SetError(txt_Contraseña,"La contraseña no son iguales");
                    errorProvider1.SetError(txt_Confirmacion, "La contraseña no son iguales");
                    MessageBox.Show("Verifique la contraseña porfavor", "Contraseña no son iguales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            Cargar_Datos();
        }
        //-------------------------------------------------------------
        //-----------------NO ESCRITURA EN LOS COMBOBOX----------------
        //-------------------------------------------------------------
        private void NoescrituracomboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        //-------------------------------------------------------------
        //---------------CONTROL DE ESPACIOS VACIOS--------------------
        //-------------------------------------------------------------
        #region Verificar campos vacios
        private TextBox[] Campos = new TextBox[3];
        private bool Espacios_Vacios = false;
        private bool Verificar_CamposVacios()
        {
            //Se introduce los textbox en un arreglo con el fin de identificar espacios vacios
            Campos[0] = txt_CorreoElectronico;
            Campos[1] = txt_Contraseña;
            Campos[2] = txt_Confirmacion;
            //Reinicio el error provider para volver a reemarcar
            errorProvider1.Clear();
            Espacios_Vacios = false;
            for (int i = 0; i < Campos.Length; i++)
            {
                if (Campos[i].Text.Trim() == "")
                {
                    Indicador_CamposVacios(i);
                    Espacios_Vacios = true;
                }
            }
            return Espacios_Vacios;
        }
        private void Indicador_CamposVacios(int i)
        {
            switch (i)
            {
                case 0:
                    errorProvider1.SetError(txt_CorreoElectronico, "No puedes dejar el campo vacio");
                    break;
                case 1:
                    errorProvider1.SetError(txt_Contraseña, "No puedes dejar el campo vacio");
                    break;
                case 2:
                    errorProvider1.SetError(txt_Confirmacion, "No puedes dejar el campo vacio");
                    break;
                default:
                    break;
            }
        }
        #endregion
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
        //-------------------------------------------------------------
        //-------------------AL CERRAR LA VENTANA----------------------
        //-------------------------------------------------------------
        private void Informacion_FormClosing(object sender, FormClosingEventArgs e)
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
