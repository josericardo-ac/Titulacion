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
    public partial class Inventario_Producto : Form
    {
        public Inventario_Producto()
        {
            InitializeComponent();
        }
        #region Diseño de la forma
        #region Declarando controles de la forma
        private System.Windows.Forms.GroupBox groupBox_Datos;
        private System.Windows.Forms.GroupBox groupBoxInventario;
        private System.Windows.Forms.DataGridView dataGridViewInventario;
        private System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label lbl_Unidad;
        private System.Windows.Forms.Label lbl_Saldo;
        private System.Windows.Forms.Label lbl_PrecioVenta;
        private System.Windows.Forms.Label lbl_PrecioCompra;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.Label lbl_Producto;
        private System.Windows.Forms.Label lbl_Concepto;
        private System.Windows.Forms.Label lbl_Lote;
        private System.Windows.Forms.Label lbl_Almacen;
        private System.Windows.Forms.ComboBox comboBox_Unidad;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Fecha;
        private System.Windows.Forms.TextBox txt_Saldo;
        private System.Windows.Forms.TextBox txt_PrecioVenta;
        private System.Windows.Forms.TextBox txt_PrecioCompra;
        private System.Windows.Forms.TextBox txt_Unidad;
        private System.Windows.Forms.ComboBox comboBox_Producto;
        private System.Windows.Forms.ComboBox comboBox_Concepto;
        private System.Windows.Forms.TextBox txt_Lote;
        private System.Windows.Forms.ComboBox comboBox_Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Barra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Maxima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Minima;
        #endregion
        private void Diseño_Forma()
        {
            #region Creando controles de la forma
            groupBox_Datos = new System.Windows.Forms.GroupBox();
            lbl_Fecha = new System.Windows.Forms.Label();
            lbl_Unidad = new System.Windows.Forms.Label();
            lbl_Saldo = new System.Windows.Forms.Label();
            lbl_PrecioVenta = new System.Windows.Forms.Label();
            lbl_PrecioCompra = new System.Windows.Forms.Label();
            lbl_Cantidad = new System.Windows.Forms.Label();
            lbl_Producto = new System.Windows.Forms.Label();
            lbl_Concepto = new System.Windows.Forms.Label();
            lbl_Lote = new System.Windows.Forms.Label();
            lbl_Almacen = new System.Windows.Forms.Label();
            comboBox_Unidad = new System.Windows.Forms.ComboBox();
            dateTimePicker_Fecha = new System.Windows.Forms.DateTimePicker();
            txt_Saldo = new System.Windows.Forms.TextBox();
            txt_PrecioVenta = new System.Windows.Forms.TextBox();
            txt_PrecioCompra = new System.Windows.Forms.TextBox();
            txt_Unidad = new System.Windows.Forms.TextBox();
            comboBox_Producto = new System.Windows.Forms.ComboBox();
            comboBox_Concepto = new System.Windows.Forms.ComboBox();
            txt_Lote = new System.Windows.Forms.TextBox();
            comboBox_Almacen = new System.Windows.Forms.ComboBox();
            groupBoxInventario = new System.Windows.Forms.GroupBox();
            dataGridViewInventario = new System.Windows.Forms.DataGridView();
            pic_Logo = new System.Windows.Forms.PictureBox();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Codigo_Barra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cantidad_Maxima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cantidad_Minima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBox_Datos.SuspendLayout();
            groupBoxInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridViewInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pic_Logo)).BeginInit();
            SuspendLayout();
            #endregion
            // 
            // groupBox_Datos
            // 
            groupBox_Datos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            groupBox_Datos.Controls.Add(pic_Logo);
            groupBox_Datos.Controls.Add(lbl_Fecha);
            groupBox_Datos.Controls.Add(lbl_Unidad);
            groupBox_Datos.Controls.Add(lbl_Saldo);
            groupBox_Datos.Controls.Add(lbl_PrecioVenta);
            groupBox_Datos.Controls.Add(lbl_PrecioCompra);
            groupBox_Datos.Controls.Add(lbl_Cantidad);
            groupBox_Datos.Controls.Add(lbl_Producto);
            groupBox_Datos.Controls.Add(lbl_Concepto);
            groupBox_Datos.Controls.Add(lbl_Lote);
            groupBox_Datos.Controls.Add(lbl_Almacen);
            groupBox_Datos.Controls.Add(comboBox_Unidad);
            groupBox_Datos.Controls.Add(dateTimePicker_Fecha);
            groupBox_Datos.Controls.Add(txt_Saldo);
            groupBox_Datos.Controls.Add(txt_PrecioVenta);
            groupBox_Datos.Controls.Add(txt_PrecioCompra);
            groupBox_Datos.Controls.Add(txt_Unidad);
            groupBox_Datos.Controls.Add(comboBox_Producto);
            groupBox_Datos.Controls.Add(comboBox_Concepto);
            groupBox_Datos.Controls.Add(txt_Lote);
            groupBox_Datos.Controls.Add(comboBox_Almacen);
            groupBox_Datos.Location = new System.Drawing.Point(0, 36);
            groupBox_Datos.Name = "groupBox_Datos";
            groupBox_Datos.Size = new System.Drawing.Size(898, 150);
            groupBox_Datos.TabIndex = 0;
            groupBox_Datos.TabStop = false;
            groupBox_Datos.Text = "Datos de Inventario";
            // 
            // lbl_Fecha
            // 
            lbl_Fecha.AutoSize = true;
            lbl_Fecha.Location = new System.Drawing.Point(627, 31);
            lbl_Fecha.Name = "lbl_Fecha";
            lbl_Fecha.Size = new System.Drawing.Size(37, 13);
            lbl_Fecha.TabIndex = 19;
            lbl_Fecha.Text = "Fecha";
            // 
            // lbl_Unidad
            // 
            lbl_Unidad.AutoSize = true;
            lbl_Unidad.Location = new System.Drawing.Point(436, 31);
            lbl_Unidad.Name = "lbl_Unidad";
            lbl_Unidad.Size = new System.Drawing.Size(41, 13);
            lbl_Unidad.TabIndex = 18;
            lbl_Unidad.Text = "Unidad";
            // 
            // lbl_Saldo
            // 
            lbl_Saldo.AutoSize = true;
            lbl_Saldo.Location = new System.Drawing.Point(236, 110);
            lbl_Saldo.Name = "lbl_Saldo";
            lbl_Saldo.Size = new System.Drawing.Size(34, 13);
            lbl_Saldo.TabIndex = 17;
            lbl_Saldo.Text = "Saldo";
            // 
            // lbl_PrecioVenta
            // 
            lbl_PrecioVenta.AutoSize = true;
            lbl_PrecioVenta.Location = new System.Drawing.Point(236, 83);
            lbl_PrecioVenta.Name = "lbl_PrecioVenta";
            lbl_PrecioVenta.Size = new System.Drawing.Size(67, 13);
            lbl_PrecioVenta.TabIndex = 16;
            lbl_PrecioVenta.Text = "Precio venta";
            // 
            // lbl_PrecioCompra
            // 
            lbl_PrecioCompra.AutoSize = true;
            lbl_PrecioCompra.Location = new System.Drawing.Point(236, 57);
            lbl_PrecioCompra.Name = "lbl_PrecioCompra";
            lbl_PrecioCompra.Size = new System.Drawing.Size(75, 13);
            lbl_PrecioCompra.TabIndex = 15;
            lbl_PrecioCompra.Text = "Precio compra";
            // 
            // lbl_Cantidad
            // 
            lbl_Cantidad.AutoSize = true;
            lbl_Cantidad.Location = new System.Drawing.Point(236, 32);
            lbl_Cantidad.Name = "lbl_Cantidad";
            lbl_Cantidad.Size = new System.Drawing.Size(49, 13);
            lbl_Cantidad.TabIndex = 14;
            lbl_Cantidad.Text = "Cantidad";
            // 
            // lbl_Producto
            // 
            lbl_Producto.AutoSize = true;
            lbl_Producto.Location = new System.Drawing.Point(24, 113);
            lbl_Producto.Name = "lbl_Producto";
            lbl_Producto.Size = new System.Drawing.Size(50, 13);
            lbl_Producto.TabIndex = 13;
            lbl_Producto.Text = "Producto";
            // 
            // lbl_Concepto
            // 
            lbl_Concepto.AutoSize = true;
            lbl_Concepto.Location = new System.Drawing.Point(24, 85);
            lbl_Concepto.Name = "lbl_Concepto";
            lbl_Concepto.Size = new System.Drawing.Size(53, 13);
            lbl_Concepto.TabIndex = 12;
            lbl_Concepto.Text = "Concepto";
            // 
            // lbl_Lote
            // 
            lbl_Lote.AutoSize = true;
            lbl_Lote.Location = new System.Drawing.Point(24, 57);
            lbl_Lote.Name = "lbl_Lote";
            lbl_Lote.Size = new System.Drawing.Size(28, 13);
            lbl_Lote.TabIndex = 11;
            lbl_Lote.Text = "Lote";
            // 
            // lbl_Almacen
            // 
            lbl_Almacen.AutoSize = true;
            lbl_Almacen.Location = new System.Drawing.Point(24, 32);
            lbl_Almacen.Name = "lbl_Almacen";
            lbl_Almacen.Size = new System.Drawing.Size(48, 13);
            lbl_Almacen.TabIndex = 10;
            lbl_Almacen.Text = "Almacén";
            // 
            // comboBox_Unidad
            // 
            comboBox_Unidad.FormattingEnabled = true;
            comboBox_Unidad.Location = new System.Drawing.Point(483, 28);
            comboBox_Unidad.Name = "comboBox_Unidad";
            comboBox_Unidad.Size = new System.Drawing.Size(121, 21);
            comboBox_Unidad.TabIndex = 9;
            // 
            // dateTimePicker_Fecha
            // 
            dateTimePicker_Fecha.Location = new System.Drawing.Point(685, 29);
            dateTimePicker_Fecha.Name = "dateTimePicker_Fecha";
            dateTimePicker_Fecha.Size = new System.Drawing.Size(200, 20);
            dateTimePicker_Fecha.TabIndex = 8;
            // 
            // txt_Saldo
            // 
            txt_Saldo.Enabled = false;
            txt_Saldo.Location = new System.Drawing.Point(319, 106);
            txt_Saldo.Name = "txt_Saldo";
            txt_Saldo.Size = new System.Drawing.Size(100, 20);
            txt_Saldo.TabIndex = 7;
            // 
            // txt_PrecioVenta
            // 
            txt_PrecioVenta.Location = new System.Drawing.Point(319, 80);
            txt_PrecioVenta.Name = "txt_PrecioVenta";
            txt_PrecioVenta.Size = new System.Drawing.Size(100, 20);
            txt_PrecioVenta.TabIndex = 6;
            // 
            // txt_PrecioCompra
            // 
            txt_PrecioCompra.Location = new System.Drawing.Point(319, 54);
            txt_PrecioCompra.Name = "txt_PrecioCompra";
            txt_PrecioCompra.Size = new System.Drawing.Size(100, 20);
            txt_PrecioCompra.TabIndex = 5;
            // 
            // txt_Unidad
            // 
            txt_Unidad.Location = new System.Drawing.Point(319, 29);
            txt_Unidad.MaxLength = 9;
            txt_Unidad.Name = "txt_Unidad";
            txt_Unidad.Size = new System.Drawing.Size(100, 20);
            txt_Unidad.TabIndex = 4;
            // 
            // comboBox_Producto
            // 
            comboBox_Producto.FormattingEnabled = true;
            comboBox_Producto.Location = new System.Drawing.Point(102, 107);
            comboBox_Producto.Name = "comboBox_Producto";
            comboBox_Producto.Size = new System.Drawing.Size(121, 21);
            comboBox_Producto.TabIndex = 3;
            // 
            // comboBox_Concepto
            // 
            comboBox_Concepto.FormattingEnabled = true;
            comboBox_Concepto.Location = new System.Drawing.Point(102, 80);
            comboBox_Concepto.Name = "comboBox_Concepto";
            comboBox_Concepto.Size = new System.Drawing.Size(121, 21);
            comboBox_Concepto.TabIndex = 2;
            // 
            // txt_Lote
            // 
            txt_Lote.Location = new System.Drawing.Point(102, 54);
            txt_Lote.MaxLength = 10;
            txt_Lote.Name = "txt_Lote";
            txt_Lote.Size = new System.Drawing.Size(100, 20);
            txt_Lote.TabIndex = 1;
            // 
            // comboBox_Almacen
            // 
            comboBox_Almacen.FormattingEnabled = true;
            comboBox_Almacen.Location = new System.Drawing.Point(102, 28);
            comboBox_Almacen.Name = "comboBox_Almacen";
            comboBox_Almacen.Size = new System.Drawing.Size(121, 21);
            comboBox_Almacen.TabIndex = 0;
            // 
            // groupBoxInventario
            // 
            groupBoxInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            groupBoxInventario.Controls.Add(dataGridViewInventario);
            groupBoxInventario.Location = new System.Drawing.Point(0, 192);
            groupBoxInventario.Name = "groupBoxInventario";
            groupBoxInventario.Size = new System.Drawing.Size(898, 376);
            groupBoxInventario.TabIndex = 1;
            groupBoxInventario.TabStop = false;
            groupBoxInventario.Text = "Inventario";
            // 
            // dataGridViewInventario
            // 
            dataGridViewInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Id,
            Producto,
            Descripción,
            Codigo_Barra,
            Lote,
            Cantidad,
            Cantidad_Maxima,
            Cantidad_Minima});
            dataGridViewInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewInventario.Location = new System.Drawing.Point(3, 16);
            dataGridViewInventario.Name = "dataGridViewInventario";
            dataGridViewInventario.Size = new System.Drawing.Size(892, 357);
            dataGridViewInventario.TabIndex = 0;
            // 
            // pic_Logo
            // 
            pic_Logo.BackgroundImage = global::Sistema_Shajobe.Properties.Resources.Logo_Shajobe;
            pic_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pic_Logo.Location = new System.Drawing.Point(690, 65);
            pic_Logo.Name = "pic_Logo";
            pic_Logo.Size = new System.Drawing.Size(175, 75);
            pic_Logo.TabIndex = 33;
            pic_Logo.TabStop = false;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Visible = false;
            Id.Width = 41;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.Width = 75;
            // 
            // Descripción
            // 
            Descripción.HeaderText = "Descripción";
            Descripción.Name = "Descripción";
            Descripción.Width = 88;
            // 
            // Codigo_Barra
            // 
            Codigo_Barra.HeaderText = "Codigo de barra";
            Codigo_Barra.Name = "Codigo_Barra";
            Codigo_Barra.Width = 77;
            // 
            // Lote
            // 
            Lote.HeaderText = "Lote";
            Lote.Name = "Lote";
            Lote.Width = 53;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 74;
            // 
            // Cantidad_Maxima
            // 
            Cantidad_Maxima.HeaderText = "Cantidad maxima";
            Cantidad_Maxima.Name = "Cantidad_Maxima";
            Cantidad_Maxima.Width = 103;
            // 
            // Cantidad_Minima
            // 
            Cantidad_Minima.HeaderText = "Cantidad minima";
            Cantidad_Minima.Name = "Cantidad_Minima";
            // 
            // Inventario
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(196)))));
            ClientSize = new System.Drawing.Size(897, 567);
            Controls.Add(groupBoxInventario);
            Controls.Add(groupBox_Datos);
            Icon = global::Sistema_Shajobe.Properties.Resources.Inventario_ICO;
            MinimumSize = new System.Drawing.Size(913, 605);
            MaximumSize = new System.Drawing.Size(913, 605);
            MaximizeBox = false;
            Name = "InventarioProducto";
            Text = "Invenario producto";
            WindowState = System.Windows.Forms.FormWindowState.Normal;
            groupBox_Datos.ResumeLayout(false);
            groupBox_Datos.PerformLayout();
            groupBoxInventario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(dataGridViewInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pic_Logo)).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private void Inventario_Producto_Load(object sender, EventArgs e)
        {
            #region Animacion
            AnimateWindow(Handle, 350, AnimateWindowFlags.AW_CENTER);
            AnimateWindow(Handle, 450, AnimateWindowFlags.AW_CENTER | AnimateWindowFlags.AW_SLIDE);
            ResumeLayout(false);
            PerformLayout();
            #endregion
            Diseño_Forma();
            //Llenando Combobobx
            Llenando_ComboboxAlmacen();
           // Llenando_ComboboxProducto();
           // Llenando_ComboboxUnidadMedida();
        }
        //-------------------------------------------------------------
        //-------------------------CONEXION----------------------------
        //-------------------------------------------------------------
        //OBTIENE LA CADENA DE CONEXION
        public static string ObtenerString()
        {
            return Settings.Default.SHAJOBEConnectionString;
        }
        //-------------------------------------------------------------
        //-------------------Llenado de comboBox-----------------------
        //-------------------------------------------------------------
        private void Llenando_ComboboxProducto()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "Select Nombre  from Tb_Producto where Activo='S'";
            coman.CommandType = CommandType.Text;
            con.Open();
            comboBox_Producto.Items.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Declarando Variables y obteniendo los valores correspondiente
                string Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                comboBox_Producto.Items.Add(Nombre);
            }
            con.Close();
        }
        private void Llenando_ComboboxAlmacen()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "Select Nombre from Tb_Almacen where Activo='S'";
            coman.CommandType = CommandType.Text;
            con.Open();
            comboBox_Almacen.Items.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Declarando Variables y obteniendo los valores correspondiente
                string Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                comboBox_Almacen.Items.Add(Nombre);
            }
            con.Close();
        }
        private void Llenando_ComboboxUnidadMedida()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "Select Simbolo from Tb_Unidadmedida where Activo='S'";
            coman.CommandType = CommandType.Text;
            con.Open();
            comboBox_Unidad.Items.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Declarando Variables y obteniendo los valores correspondiente
                string Simbolo = dr.GetString(dr.GetOrdinal("Simbolo"));
                comboBox_Unidad.Items.Add(Simbolo);
            }
            con.Close();
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
