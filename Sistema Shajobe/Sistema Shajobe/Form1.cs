using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Librerias Agregadas 
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.OleDb;//Establece el tipo de conexion a la base de datos
using System.Configuration;//Establecemos comunicacion con la libreria de configuracion para poder hacer uso del App.Config
using Sistema_Shajobe.Properties;//Nos permite tener acceso y control sobre las propiedades del proyecto en este caso la direccion del appconfig y entre otros
//Librerias de Animacion
using System.Runtime.InteropServices;

namespace Sistema_Shajobe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Diseño de la forma
        #region Creando controles de la forma
        private PictureBox pic_Logo;
        private ErrorProvider errorProvider1;
        private TextBox txt_Usuario;
        private TextBox txt_Contrasena;
        private Button btn_Iniciar;
        private Label lbl_Contrasena;
        private Label lbl_Usuario;
        private PictureBox Linea;
        private System.Windows.Forms.LinkLabel linkLbl_Cerrarconexion;
        #endregion
        private void Diseño_Forma()
        {
            //Iniciando Controles
            pic_Logo = new System.Windows.Forms.PictureBox();
            errorProvider1 = new System.Windows.Forms.ErrorProvider();
            txt_Usuario = new System.Windows.Forms.TextBox();
            txt_Contrasena = new System.Windows.Forms.TextBox();
            btn_Iniciar = new System.Windows.Forms.Button();
            lbl_Contrasena = new System.Windows.Forms.Label();
            lbl_Usuario = new System.Windows.Forms.Label();
            Linea = new System.Windows.Forms.PictureBox();
            linkLbl_Cerrarconexion = new System.Windows.Forms.LinkLabel();
            // 
            // linkLbl_Cerrarconexion
            // 
            linkLbl_Cerrarconexion.AutoSize = true;
            linkLbl_Cerrarconexion.Location = new System.Drawing.Point(20, 155);
            linkLbl_Cerrarconexion.Name = "linkLbl_Cerrarconexion";
            linkLbl_Cerrarconexion.Size = new System.Drawing.Size(92, 13);
            linkLbl_Cerrarconexion.TabIndex = 3;
            linkLbl_Cerrarconexion.TabStop = true;
            linkLbl_Cerrarconexion.Text = "Cerrar conexiones";
            linkLbl_Cerrarconexion.MouseClick += new System.Windows.Forms.MouseEventHandler(linkLabel1_MouseClick);
            // 
            // pic_Logo
            // 
            pic_Logo.BackgroundImage = global::Sistema_Shajobe.Properties.Resources.Logo_Shajobe;
            pic_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pic_Logo.Location = new System.Drawing.Point(22, 22);
            pic_Logo.Name = "pic_Logo";
            pic_Logo.Size = new System.Drawing.Size(111, 56);
            pic_Logo.TabIndex = 13;
            pic_Logo.TabStop = false;
            //
            // Linea
            //
            Linea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(186)))), ((int)(((byte)(82)))));
            Linea.Location = new System.Drawing.Point(30, 22);
            Linea.Name = "Linea";
            Linea.Size = new System.Drawing.Size(399, 20);
            Linea.TabIndex = 14;
            Linea.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // txt_Usuario
            // 
            txt_Usuario.Location = new System.Drawing.Point(169, 96);
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.Size = new System.Drawing.Size(127, 20);
            txt_Usuario.TabIndex = 12;
            txt_Usuario.MaxLength = 10;
            // 
            // txt_Contrasena
            // 
            txt_Contrasena.Location = new System.Drawing.Point(169, 122);
            txt_Contrasena.Name = "txt_Contrasena";
            txt_Contrasena.PasswordChar = '*';
            txt_Contrasena.Size = new System.Drawing.Size(127, 20);
            txt_Contrasena.TabIndex = 11;
            txt_Contrasena.MaxLength = 10;
            // 
            // btn_Iniciar
            // 
            btn_Iniciar.BackgroundImage = global::Sistema_Shajobe.Properties.Resources.Siguiente;
            btn_Iniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_Iniciar.Location = new System.Drawing.Point(309, 88);
            btn_Iniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(196)))));
            btn_Iniciar.Name = "btn_Iniciar";
            btn_Iniciar.Size = new System.Drawing.Size(70, 63);
            btn_Iniciar.TabIndex = 10;
            btn_Iniciar.UseVisualStyleBackColor = true;
            btn_Iniciar.Click += new System.EventHandler(btn_Iniciar_Click);
            // 
            // lbl_Contrasena
            // 
            lbl_Contrasena.AutoSize = true;
            lbl_Contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Contrasena.Location = new System.Drawing.Point(59, 122);
            lbl_Contrasena.Name = "lbl_Contrasena";
            lbl_Contrasena.Size = new System.Drawing.Size(92, 20);
            lbl_Contrasena.TabIndex = 9;
            lbl_Contrasena.Text = "Contraseña";
            lbl_Contrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(186)))), ((int)(((byte)(82)))));
            // 
            // lbl_Usuario
            // 
            lbl_Usuario.AutoSize = true;
            lbl_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Usuario.Location = new System.Drawing.Point(59, 96);
            lbl_Usuario.Name = "lbl_Usuario";
            lbl_Usuario.Size = new System.Drawing.Size(64, 20);
            lbl_Usuario.TabIndex = 8;
            lbl_Usuario.Text = "Usuario";
            lbl_Usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(186)))), ((int)(((byte)(82)))));
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(438, 71);
            Controls.Add(pic_Logo);
            Controls.Add(txt_Usuario);
            Controls.Add(txt_Contrasena);
            Controls.Add(btn_Iniciar);
            Controls.Add(lbl_Contrasena);
            Controls.Add(lbl_Usuario);
            Controls.Add(linkLbl_Cerrarconexion);
            Controls.Add(Linea);
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(196)))));
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = global::Sistema_Shajobe.Properties.Resources.Shajobe_ICO;
            MaximumSize = new System.Drawing.Size(444, 200);
            MinimumSize = new System.Drawing.Size(444, 200);
            MaximizeBox = false;
            Name = "Iniciar_Sesion";
            //StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "I n i c i a r  s e s i ó n";
            Load += new System.EventHandler(Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(pic_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(errorProvider1)).EndInit();
            ResumeLayout(false);
            //Animacion
            Visible = false;     //Para que este oculta y aparezca con el efecto
            AnimateWindow(Handle, 350, AnimateWindowFlags.AW_CENTER);
            AnimateWindow(Handle, 350, AnimateWindowFlags.AW_CENTER | AnimateWindowFlags.AW_SLIDE);
            PerformLayout();
        }
        #endregion  
        private void Form1_Load(object sender, EventArgs e)
        {
            #region Animacion
            AnimateWindow(Handle, 350, AnimateWindowFlags.AW_CENTER);
            AnimateWindow(Handle, 450, AnimateWindowFlags.AW_CENTER | AnimateWindowFlags.AW_SLIDE);
            ResumeLayout(false);
            PerformLayout();
            #endregion
            Diseño_Forma();
            Verificar_ExistenciaBD();
            //Menu_principal tp = new Menu_principal();
            //tp.Show();
        }
        //-------------------------------------------------------------
        //------------------Variables y Arreglos-----------------------
        //-------------------------------------------------------------
        private bool Espacios_Vacios = false;
        //-------------------------------------------------------------
        //----------------CONFIGURACION DE CONTROLES-------------------
        //-------------------------------------------------------------
        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            bool i = Verificar_CamposVacios();
            if (i == true)
                MessageBox.Show("Inserta todos los datos marcados", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                OleDbConnection conexion = null;
                OleDbTransaction transaccion = null;
                try
                {
                    if (Validar_Datos() != 0)
                    {
                        if (Validar() == 0)
                        {
                            conexion = new OleDbConnection(ObtenerString());
                            conexion.Open();
                            transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                            OleDbCommand comando = new OleDbCommand("SP_Login_Verificar", conexion, transaccion);
                            comando.CommandType = CommandType.StoredProcedure;
                            comando.Parameters.Clear();
                            comando.Parameters.AddWithValue("@NOM_USER", txt_Usuario.Text);
                            comando.Parameters.AddWithValue("@CONTRASEÑA", txt_Contrasena.Text);
                            comando.ExecuteNonQuery();
                            transaccion.Commit();
                            conexion.Close();
                            txt_Contrasena.Clear();
                            txt_Usuario.Clear();
                            MessageBox.Show("Bienvenido", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Menu_principal mp = new Menu_principal();
                            mp.Show();
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("No se pueden tener 2 o mas cuentas activas", "Erro de conexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Verifique usuario y contraseña", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        txt_Contrasena.Clear();
                        txt_Usuario.Clear();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Usuario no encontrado", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txt_Contrasena.Clear();
                    txt_Usuario.Clear();
                }
            }
        }
        //-------------------------------------------------------------
        //---------------CONTROL DE ESPACIOS VACIOS--------------------
        //-------------------------------------------------------------
        #region Verificar campos vacios
        //METODOS PARA INDICAR ERROR DE CAMPOS VACIOS
        private TextBox[] Campos = new TextBox[2];
        private bool Verificar_CamposVacios()
        {
            //Se introduce los textbox en un arreglo con el fin de identificar espacios vacios
            Campos[0] = txt_Usuario;
            Campos[1] = txt_Contrasena;
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
                    errorProvider1.SetError(txt_Usuario, "No puedes dejar el campo vacio");
                    break;
                case 1:
                    errorProvider1.SetError(txt_Contrasena, "No puedes dejar el campo vacio");
                    break;
                default:
                    break;
            }
        }
        #endregion
        //-------------------------------------------------------------
        //-------------------Validacion de campos----------------------
        //-------------------------------------------------------------
        #region Validacion de registros de usuario
        private int Validar()
        {
            int Cuentas_Activas = 0;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "select COUNT(Estado)As Cuenta_Act from Tb_Usuarios_Login where Estado='A'";
            coman.CommandType = CommandType.Text;
            con.Open();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                Cuentas_Activas = dr.GetInt32(dr.GetOrdinal("Cuenta_Act"));
            }
            con.Close();
            return Cuentas_Activas;
        }
        private int Validar_Datos()
        {
            int Ultimo_Id = 0;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "select Id_Usuario from Tb_Usuario where Nom_User='" + txt_Usuario.Text + "' AND Contraseña='" + txt_Contrasena.Text + "'";
            coman.CommandType = CommandType.Text;
            con.Open();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                Ultimo_Id = dr.GetInt32(dr.GetOrdinal("Id_Usuario"));
            }
            con.Close();
            return Ultimo_Id;
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
        //--------------CERRAR CUENTAS DE SESION ACTIVAS---------------
        //-------------------------------------------------------------
        private void linkLabel1_MouseClick(object sender, MouseEventArgs e)
        {
            try 
	        {	        
		        OleDbConnection con = new OleDbConnection();
                OleDbDataReader dr;
                OleDbCommand com = new OleDbCommand();
                con.ConnectionString = ObtenerString();
                com.Connection = con;
                com.CommandText = "update Tb_Usuarios_Login set Estado='D' where Estado='A'";
                com.CommandType = CommandType.Text;
                con.Open();
                dr = com.ExecuteReader();
                //while (dr.Read())
                //{
                //}
                con.Close();
                MessageBox.Show("Cuentas cerradas con exito", "Informe de resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
	        }
	        catch (Exception)
	        {

                MessageBox.Show("No se puede cerrar la cuenta activa", "Informe de resultado", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        } 
        }
        //-------------------------------------------------------------
        //-----------CHECAR EXISTENCIA DE LA BASE DE DATOS-------------
        //-------------------------------------------------------------
        private String[] basesDeDatos()
        {
            string instancia = ".";
            // Las bases de datos propias de SQL Server
            string[] basesSys = { "master", "model", "msdb", "tempdb" };
            string[] bases;
            DataTable dt = new DataTable();
            // Usamos la seguridad integrada de Windows
            string sCnn = "Server=" + instancia + "; database=master; integrated security=yes";

            // La orden T-SQL para recuperar las bases de master
            string sel = "SELECT name FROM sysdatabases";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sel, sCnn);
                da.Fill(dt);
                bases = new string[dt.Rows.Count - 1];
                int k = -1;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string s = dt.Rows[i]["name"].ToString();
                    // Solo asignar las bases que no son del sistema
                    if (Array.IndexOf(basesSys, s) == -1)
                    {
                        k += 1;
                        bases[k] = s;
                    }
                }
                if (k == -1) return null;
                // ReDim Preserve
                {
                    int i1_RPbases = bases.Length;
                    string[] copiaDe_bases = new string[i1_RPbases];
                    Array.Copy(bases, copiaDe_bases, i1_RPbases);
                    bases = new string[(k + 1)];
                    Array.Copy(copiaDe_bases, bases, (k + 1));
                };
                return bases;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error al recuperar las bases de la instancia indicada",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        private void Verificar_ExistenciaBD()
        {
            string[] BD;
            bool Existencia = false;
            BD = basesDeDatos();
            for (int i = 0; i < BD.Length; i++)
            {
                if (BD[i] == "SHAJOBE")
                {
                    Existencia = true;
                    break;
                }
            }
            if (Existencia == false)
            {
                if (MessageBox.Show("Verifique que la base de datos este instalada", "Error al recuperar las bases de la instancia indicada", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    Application.Exit();
                    //EN CASO DE QUE LA BASE DE DATOS NO EXISTA MOSTRARA EL MENSAJE DE QUE NO SE CUENTRA DISPONIBLE
                    //AL FINALIZAR CERRARA EL PROGRAMA
                }
            }
        }
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
