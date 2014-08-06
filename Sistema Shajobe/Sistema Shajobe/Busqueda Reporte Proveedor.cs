﻿using System;
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
    public partial class Busqueda_Reporte_Proveedor : Form
    {
        public Busqueda_Reporte_Proveedor()
        {
            InitializeComponent();
        }
        #region Diseño
        #region Declarando controles de la ventana
        private System.Windows.Forms.PictureBox picture_Imagen;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button bttn_Consultar;
        private System.Windows.Forms.GroupBox groupBox_DatosProveedor;
        private System.Windows.Forms.Button btt_Buscar;
        private System.Windows.Forms.TextBox txt_Proveedor;
        private System.Windows.Forms.DataGridView dataGridView_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_ProveedorC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_PC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_MC;
        private System.Windows.Forms.Label lbl_Proveedor;
        private System.Windows.Forms.ErrorProvider errorProvider_Textbox;
        #endregion
        private void Diseño_Ventana()
        {
            #region Creando controles de la ventana
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.bttn_Consultar = new System.Windows.Forms.Button();
            this.picture_Imagen = new System.Windows.Forms.PictureBox();
            this.groupBox_DatosProveedor = new System.Windows.Forms.GroupBox();
            this.btt_Buscar = new System.Windows.Forms.Button();
            this.txt_Proveedor = new System.Windows.Forms.TextBox();
            this.dataGridView_Proveedor = new System.Windows.Forms.DataGridView();
            this.Id_ProveedorC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_PC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_MC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Proveedor = new System.Windows.Forms.Label();
            this.errorProvider_Textbox = new System.Windows.Forms.ErrorProvider();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Imagen)).BeginInit();
            this.groupBox_DatosProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Proveedor)).BeginInit();
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
            this.lbl_Titulo.Text = "Busque y seleccione un proveedor";
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
            // groupBox_DatosProveedor
            // 
            this.groupBox_DatosProveedor.Controls.Add(this.btt_Buscar);
            this.groupBox_DatosProveedor.Controls.Add(this.txt_Proveedor);
            this.groupBox_DatosProveedor.Controls.Add(this.dataGridView_Proveedor);
            this.groupBox_DatosProveedor.Controls.Add(this.lbl_Proveedor);
            this.groupBox_DatosProveedor.Location = new System.Drawing.Point(23, 62);
            this.groupBox_DatosProveedor.Name = "groupBox_DatosProveedor";
            this.groupBox_DatosProveedor.Size = new System.Drawing.Size(335, 171);
            this.groupBox_DatosProveedor.TabIndex = 11;
            this.groupBox_DatosProveedor.TabStop = false;
            this.groupBox_DatosProveedor.Text = "Datos del proveedor";
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
            // txt_Proveedor
            // 
            this.txt_Proveedor.Location = new System.Drawing.Point(81, 22);
            this.txt_Proveedor.MaxLength = 25;
            this.txt_Proveedor.Name = "txt_Proveedor";
            this.txt_Proveedor.Size = new System.Drawing.Size(116, 20);
            this.txt_Proveedor.TabIndex = 4;
            this.txt_Proveedor.KeyPress += new KeyPressEventHandler(txt_Proveedor_KeyPress);
            // 
            // dataGridView_Proveedor
            // 
            this.dataGridView_Proveedor.AllowUserToDeleteRows = false;
            this.dataGridView_Proveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_ProveedorC,
            this.NombreC,
            this.Apellido_PC,
            this.Apellido_MC});
            this.dataGridView_Proveedor.Location = new System.Drawing.Point(2, 62);
            this.dataGridView_Proveedor.MultiSelect = false;
            this.dataGridView_Proveedor.Name = "dataGridView_Proveedor";
            this.dataGridView_Proveedor.ReadOnly = true;
            this.dataGridView_Proveedor.Size = new System.Drawing.Size(332, 104);
            this.dataGridView_Proveedor.TabIndex = 3;
            // 
            // Id_ProveedorC
            // 
            this.Id_ProveedorC.HeaderText = "Id_ProveedorC";
            this.Id_ProveedorC.Name = "Id_ProveedorC";
            this.Id_ProveedorC.ReadOnly = true;
            this.Id_ProveedorC.Visible = false;
            // 
            // NombreC
            // 
            this.NombreC.HeaderText = "Nombre";
            this.NombreC.Name = "NombreC";
            this.NombreC.ReadOnly = true;
            this.NombreC.Width = 96;
            // 
            // Apellido_PC
            // 
            this.Apellido_PC.HeaderText = "Apellido Paterno";
            this.Apellido_PC.Name = "Apellido_PC";
            this.Apellido_PC.ReadOnly = true;
            this.Apellido_PC.Width = 97;
            // 
            // Apellido_MC
            // 
            this.Apellido_MC.HeaderText = "Apellido Materno";
            this.Apellido_MC.Name = "Apellido_MC";
            this.Apellido_MC.ReadOnly = true;
            this.Apellido_MC.Width = 96;
            // 
            // lbl_Proveedor
            // 
            this.lbl_Proveedor.AutoSize = true;
            this.lbl_Proveedor.Location = new System.Drawing.Point(19, 28);
            this.lbl_Proveedor.Name = "lbl_Proveedor";
            this.lbl_Proveedor.Size = new System.Drawing.Size(56, 13);
            this.lbl_Proveedor.TabIndex = 2;
            this.lbl_Proveedor.Text = "Proveedor";
            // 
            // Reportes_CP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(486, 246);
            this.Controls.Add(this.groupBox_DatosProveedor);
            this.Controls.Add(this.picture_Imagen);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.bttn_Consultar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(492, 270);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(492, 270);
            this.Name = "Busqueda_Reporte_Proveedor";
            this.Icon = global::Sistema_Shajobe.Properties.Resources.Proveedores_ICO;
            this.Text = "Reportes de información del proveedor";
            ((System.ComponentModel.ISupportInitialize)(this.picture_Imagen)).EndInit();
            this.groupBox_DatosProveedor.ResumeLayout(false);
            this.groupBox_DatosProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Proveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Textbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            #endregion
        }
        #endregion
        private void Busqueda_Reporte_Proveedor_Load(object sender, EventArgs e)
        {
            // REALIZA ANIMACION EN LA VENTANA
            #region Animacion
            AnimateWindow(Handle, 350, AnimateWindowFlags.AW_CENTER);
            AnimateWindow(Handle, 450, AnimateWindowFlags.AW_CENTER | AnimateWindowFlags.AW_SLIDE);
            ResumeLayout(false);
            PerformLayout();
            #endregion
            Diseño_Ventana();
            //GENERANDO EL AUTOCOMPLETAR DE txt_Proveedor
            txt_Proveedor.AutoCompleteCustomSource = Autocomplete_Cliente();
            txt_Proveedor.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_Proveedor.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
            if (dataGridView_Proveedor.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente al cual se va a realizar la consulta", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (dataGridView_Proveedor.RowCount > 0)
                {
                    int dato = Convert.ToInt32(dataGridView_Proveedor.CurrentRow.Cells["Id_ProveedorC"].Value);
                    Repore_proveedor rc = new Repore_proveedor();
                    rc.recibe(dato);
                    rc.Show();
                }
            }
        }
        private void btt_Buscar_Click(object sender, EventArgs e)
        {
            errorProvider_Textbox.Clear();
            if (txt_Proveedor.Text.Trim() == "")
            {
                errorProvider_Textbox.SetError(txt_Proveedor, "No puedes dejar el campo vacio");
                MessageBox.Show("Inserta todos los datos marcados", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OleDbConnection con = new OleDbConnection();
                OleDbCommand coman = new OleDbCommand();
                OleDbDataReader dr;
                con.ConnectionString = ObtenerString();
                coman.Connection = con;
                string busqueda = txt_Proveedor.Text;
                txt_Proveedor.Text = busqueda.ToUpper();
                coman.CommandText = "SELECT Id_Proveedor, Nombre, Apellido_P, Apellido_M FROM Tb_Proveedor WHERE (Tb_Proveedor.Activo = 'S') and (Tb_Proveedor.Nombre='" + busqueda.ToUpper() + "'OR Tb_Proveedor.Apellido_P='" + busqueda.ToUpper() + "'OR Tb_Proveedor.Apellido_M='" + busqueda.ToUpper() + "')";
                coman.CommandType = CommandType.Text;
                con.Open();
                dataGridView_Proveedor.Rows.Clear();
                dr = coman.ExecuteReader();
                while (dr.Read())
                {
                    int Renglon = dataGridView_Proveedor.Rows.Add();
                    Idp = dr.GetInt32(dr.GetOrdinal("Id_Proveedor"));
                    dataGridView_Proveedor.Rows[Renglon].Cells["Id_ProveedorC"].Value = dr.GetInt32(dr.GetOrdinal("Id_Proveedor"));
                    dataGridView_Proveedor.Rows[Renglon].Cells["NombreC"].Value = dr.GetString(dr.GetOrdinal("Nombre"));
                    dataGridView_Proveedor.Rows[Renglon].Cells["Apellido_PC"].Value = dr.GetString(dr.GetOrdinal("Apellido_P"));
                    dataGridView_Proveedor.Rows[Renglon].Cells["Apellido_MC"].Value = dr.GetString(dr.GetOrdinal("Apellido_M"));
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
        public static DataTable Datos_Cliente()
        {
            DataTable dt = new DataTable();
            OleDbConnection conexion = new OleDbConnection(ObtenerString());//cadena conexion
            //string consulta = "SELECT * FROM Tb_Cliente where Activo='S'"; 
            string consulta = "SELECT Nombre, Apellido_P, Apellido_M FROM Tb_Proveedor WHERE (Activo = 'S')"; //SOLO SE TRAE CLIENTES QUE SE ENCUENTREN ACTIVOS
            OleDbCommand comando = new OleDbCommand(consulta, conexion);
            OleDbDataAdapter adap = new OleDbDataAdapter(comando);
            adap.Fill(dt);
            return dt;
        }
        //metodo para cargar la coleccion de datos para el autocomplete
        public static AutoCompleteStringCollection Autocomplete_Cliente()
        {
            DataTable dt = Datos_Cliente();
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row["Nombre"]));
                coleccion.Add(Convert.ToString(row["Apellido_P"]));
                coleccion.Add(Convert.ToString(row["Apellido_M"]));
            }
            return coleccion;
        }
        //-------------------------------------------------------------
        //-------------VALIDACION DEL CAMPO txt_Proveedor----------------
        //-------------------------------------------------------------
        private void txt_Proveedor_KeyPress(object sender, KeyPressEventArgs e)
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
