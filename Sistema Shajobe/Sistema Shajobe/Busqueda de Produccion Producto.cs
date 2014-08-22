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
//LIBRERIAS DE REPORTES
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Sistema_Shajobe
{
    public partial class Busqueda_de_Produccion_Producto : Form
    {
        public Busqueda_de_Produccion_Producto()
        {
            InitializeComponent();
        }
        #region Diseño
        #region Declarando controles de la ventana
        private System.Windows.Forms.PictureBox picture_Imagen;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button bttn_Consultar;
        private System.Windows.Forms.GroupBox groupBox_DatosCliente;
        private System.Windows.Forms.Button btt_Buscar;
        private System.Windows.Forms.TextBox txt_Producto;
        private System.Windows.Forms.DataGridView dataGridView_Produccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_ProduccionC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_BarraC;
        private System.Windows.Forms.Label lbl_Producto;
        private System.Windows.Forms.ErrorProvider errorProvider_Textbox;
        #endregion
        private void Diseño_Ventana()
        {
            #region Creando controles de la ventana
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.bttn_Consultar = new System.Windows.Forms.Button();
            this.picture_Imagen = new System.Windows.Forms.PictureBox();
            this.groupBox_DatosCliente = new System.Windows.Forms.GroupBox();
            this.btt_Buscar = new System.Windows.Forms.Button();
            this.txt_Producto = new System.Windows.Forms.TextBox();
            this.dataGridView_Produccion = new System.Windows.Forms.DataGridView();
            this.Id_ProduccionC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_BarraC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Producto = new System.Windows.Forms.Label();
            this.errorProvider_Textbox = new System.Windows.Forms.ErrorProvider();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Imagen)).BeginInit();
            this.groupBox_DatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Produccion)).BeginInit();
            this.SuspendLayout();
            #endregion
            #region Dando diseño a los controles
            // 
            // errorProvider_Textbox
            // 
            this.errorProvider_Textbox.ContainerControl = this;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(77, 28);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(203, 13);
            this.lbl_Titulo.TabIndex = 9;
            this.lbl_Titulo.Text = "Busque y seleccione un producto";
            // 
            // bttn_Consultar
            // 
            this.bttn_Consultar.Location = new System.Drawing.Point(373, 71);
            this.bttn_Consultar.Name = "bttn_Consultar";
            this.bttn_Consultar.Size = new System.Drawing.Size(75, 23);
            this.bttn_Consultar.TabIndex = 8;
            this.bttn_Consultar.Text = "Consultar";
            this.bttn_Consultar.UseVisualStyleBackColor = true;
            this.bttn_Consultar.Click += new System.EventHandler(this.bttn_Consultar_Click);
            // 
            // picture_Imagen
            // 
            this.picture_Imagen.BackgroundImage = global::Sistema_Shajobe.Properties.Resources.Reportes;
            this.picture_Imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_Imagen.Location = new System.Drawing.Point(373, 162);
            this.picture_Imagen.Name = "picture_Imagen";
            this.picture_Imagen.Size = new System.Drawing.Size(89, 66);
            this.picture_Imagen.TabIndex = 10;
            this.picture_Imagen.TabStop = false;
            // 
            // groupBox_DatosCliente
            // 
            this.groupBox_DatosCliente.Controls.Add(this.btt_Buscar);
            this.groupBox_DatosCliente.Controls.Add(this.txt_Producto);
            this.groupBox_DatosCliente.Controls.Add(this.dataGridView_Produccion);
            this.groupBox_DatosCliente.Controls.Add(this.lbl_Producto);
            this.groupBox_DatosCliente.Location = new System.Drawing.Point(23, 62);
            this.groupBox_DatosCliente.Name = "groupBox_DatosCliente";
            this.groupBox_DatosCliente.Size = new System.Drawing.Size(335, 171);
            this.groupBox_DatosCliente.TabIndex = 11;
            this.groupBox_DatosCliente.TabStop = false;
            this.groupBox_DatosCliente.Text = "Datos de producción de producto";
            // 
            // btt_Buscar
            // 
            this.btt_Buscar.Location = new System.Drawing.Point(226, 18);
            this.btt_Buscar.Name = "btt_Buscar";
            this.btt_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btt_Buscar.TabIndex = 5;
            this.btt_Buscar.Text = "Buscar";
            this.btt_Buscar.UseVisualStyleBackColor = true;
            this.btt_Buscar.Click += new System.EventHandler(this.btt_Buscar_Click);
            // 
            // txt_Producto
            // 
            this.txt_Producto.Location = new System.Drawing.Point(81, 22);
            this.txt_Producto.MaxLength = 25;
            this.txt_Producto.Name = "txt_Producto";
            this.txt_Producto.Size = new System.Drawing.Size(116, 20);
            this.txt_Producto.TabIndex = 4;
            this.txt_Producto.KeyPress += new KeyPressEventHandler(txt_Producto_KeyPress);
            // 
            // dataGridView_Produccion
            // 
            this.dataGridView_Produccion.AllowUserToDeleteRows = false;
            this.dataGridView_Produccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_ProduccionC,
            this.NombreC,
            this.Codigo_BarraC});
            this.dataGridView_Produccion.Location = new System.Drawing.Point(2, 62);
            this.dataGridView_Produccion.MultiSelect = false;
            this.dataGridView_Produccion.Name = "dataGridView_Produccion";
            this.dataGridView_Produccion.ReadOnly = true;
            this.dataGridView_Produccion.Size = new System.Drawing.Size(332, 104);
            this.dataGridView_Produccion.TabIndex = 3;
            // 
            // Id_ProduccionC
            // 
            this.Id_ProduccionC.HeaderText = "Id_ProduccionC";
            this.Id_ProduccionC.Name = "Id_ProduccionC";
            this.Id_ProduccionC.ReadOnly = true;
            this.Id_ProduccionC.Visible = false;
            // 
            // NombreC
            // 
            this.NombreC.HeaderText = "Nombre";
            this.NombreC.Name = "NombreC";
            this.NombreC.ReadOnly = true;
            this.NombreC.Width = 96;
            // 
            // Codigo_BarraC
            // 
            this.Codigo_BarraC.HeaderText = "Codigo de barra";
            this.Codigo_BarraC.Name = "Codigo_BarraC";
            this.Codigo_BarraC.ReadOnly = true;
            this.Codigo_BarraC.Width = 97;
            // 
            // lbl_Producto
            // 
            this.lbl_Producto.AutoSize = true;
            this.lbl_Producto.Location = new System.Drawing.Point(19, 28);
            this.lbl_Producto.Name = "lbl_Producto";
            this.lbl_Producto.Size = new System.Drawing.Size(56, 13);
            this.lbl_Producto.TabIndex = 2;
            this.lbl_Producto.Text = "Producto";
            // 
            // Reportes_CP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(486, 246);
            this.Controls.Add(this.groupBox_DatosCliente);
            this.Controls.Add(this.picture_Imagen);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.bttn_Consultar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(492, 270);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(492, 270);
            this.Name = "Busqueda_de_Produccion_Producto";
            this.Icon = global::Sistema_Shajobe.Properties.Resources.produccion1;
            this.Text = "Reportes de información de produccion de producto";
            ((System.ComponentModel.ISupportInitialize)(this.picture_Imagen)).EndInit();
            this.groupBox_DatosCliente.ResumeLayout(false);
            this.groupBox_DatosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Produccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Textbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            #endregion
        }
        #endregion
        private void Busqueda_de_Produccion_Producto_Load(object sender, EventArgs e)
        {
            // REALIZA ANIMACION EN LA VENTANA
            #region Animacion
            AnimateWindow(Handle, 350, AnimateWindowFlags.AW_CENTER);
            AnimateWindow(Handle, 450, AnimateWindowFlags.AW_CENTER | AnimateWindowFlags.AW_SLIDE);
            ResumeLayout(false);
            PerformLayout();
            #endregion
            Diseño_Ventana();
            //GENERANDO EL AUTOCOMPLETAR DE txt_Producto
            txt_Producto.AutoCompleteCustomSource = Autocomplete_Produccion();
            txt_Producto.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_Producto.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        #region Eventos
        //-------------------------------------------------------------
        //------------------Variables y Arreglos-----------------------
        //-------------------------------------------------------------
        private int Idp;//LO USO PARA OBTENER EL ID COMO RESULTADO DE LA BUSQUEDA
        #region Comportamientos de los controles
        #region Busquedas
        private void bttn_Consultar_Click(object sender, EventArgs e)
        {
            if (dataGridView_Produccion.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto al cual se va a realizar la consulta", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (dataGridView_Produccion.RowCount > 0)
                {
                    int dato = Convert.ToInt32(dataGridView_Produccion.CurrentRow.Cells["Id_ProduccionC"].Value);
                    Reporte_Produccion rc = new Reporte_Produccion();
                    rc.recibe(dato);
                    rc.Show();
                }
            }
        }
        private void btt_Buscar_Click(object sender, EventArgs e)
        {
            errorProvider_Textbox.Clear();
            if (txt_Producto.Text.Trim() == "")
            {
                errorProvider_Textbox.SetError(txt_Producto, "No puedes dejar el campo vacio");
                MessageBox.Show("Inserta todos los datos marcados", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OleDbConnection con = new OleDbConnection();
                OleDbCommand coman = new OleDbCommand();
                OleDbDataReader dr;
                con.ConnectionString = ObtenerString();
                coman.Connection = con;
                string busqueda = txt_Producto.Text;
                txt_Producto.Text = busqueda.ToUpper();
                coman.CommandText = "SELECT Tb_Produccion.Id_Produccion, Tb_Producto.Nombre, Tb_Producto.Codigo_Barra, Tb_Produccion.Activo FROM Tb_Producto INNER JOIN Tb_Produccion ON Tb_Producto.Id_Producto = Tb_Produccion.Id_Producto WHERE (Tb_Producto.Nombre ='" + busqueda.ToUpper() + "') OR (Tb_Producto.Codigo_Barra ='" + busqueda.ToUpper() + "') AND (Tb_Produccion.Activo = 'S')";
                coman.CommandType = CommandType.Text;
                con.Open();
                dataGridView_Produccion.Rows.Clear();
                dr = coman.ExecuteReader();
                while (dr.Read())
                {
                    int Renglon = dataGridView_Produccion.Rows.Add();
                    Idp = dr.GetInt32(dr.GetOrdinal("Id_Produccion"));
                    dataGridView_Produccion.Rows[Renglon].Cells["Id_ProduccionC"].Value = dr.GetInt32(dr.GetOrdinal("Id_Produccion"));
                    dataGridView_Produccion.Rows[Renglon].Cells["NombreC"].Value = dr.GetString(dr.GetOrdinal("Nombre"));
                    dataGridView_Produccion.Rows[Renglon].Cells["Codigo_BarraC"].Value = dr.GetString(dr.GetOrdinal("Codigo_Barra"));
                }
                con.Close();
            }
        }
        #endregion
        #endregion
        //-------------------------------------------------------------
        //----------------------AUTO COMPLETAR-------------------------
        //-------------------------------------------------------------
        //metodo para cargar la coleccion de datos para el autocomplete
        public static DataTable Datos_Produccion()
        {
            DataTable dt = new DataTable();
            OleDbConnection conexion = new OleDbConnection(ObtenerString());//cadena conexion
            //string consulta = "SELECT * FROM Tb_Cliente where Activo='S'"; 
            string consulta = "SELECT Tb_Producto.Nombre, Tb_Producto.Codigo_Barra FROM Tb_Producto INNER JOIN Tb_Produccion ON Tb_Producto.Id_Producto = Tb_Produccion.Id_Producto WHERE (Tb_Produccion.Activo = 'S')"; //SOLO SE TRAE CLIENTES QUE SE ENCUENTREN ACTIVOS
            OleDbCommand comando = new OleDbCommand(consulta, conexion);
            OleDbDataAdapter adap = new OleDbDataAdapter(comando);
            adap.Fill(dt);
            return dt;
        }
        //metodo para cargar la coleccion de datos para el autocomplete
        public static AutoCompleteStringCollection Autocomplete_Produccion()
        {
            DataTable dt = Datos_Produccion();
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row["Nombre"]));
                coleccion.Add(Convert.ToString(row["Codigo_Barra"]));
            }
            return coleccion;
        }
        //-------------------------------------------------------------
        //-------------VALIDACION DEL CAMPO txt_Producto----------------
        //-------------------------------------------------------------
        private void txt_Producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de letras-----------------------------------------------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto-------------------------- Uso del espacio
            if ((e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47) && (e.KeyChar < 31 || e.KeyChar > 33))
            {
                MessageBox.Show("Solo se aceptan letras", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        //-------------------------------------------------------------
        //-------------------------CONEXION----------------------------
        //-------------------------------------------------------------
        #region Cadena de conexion
        public static string ObtenerString()
        {
            return Settings.Default.SHAJOBEConnectionString;
        }
        #endregion
        //-------------------------------------------------------------
        //-------------------AL CERRAR LA VENTANA----------------------
        //-------------------------------------------------------------
        private void Abono_FormClosing(object sender, FormClosingEventArgs e)
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
