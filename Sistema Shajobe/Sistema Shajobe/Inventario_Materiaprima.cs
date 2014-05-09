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
    public partial class Inventario_Materiaprima : Form
    {
        public Inventario_Materiaprima()
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
        private System.Windows.Forms.Label lbl_Materiaprima;
        private System.Windows.Forms.Label lbl_Concepto;
        private System.Windows.Forms.Label lbl_Lote;
        private System.Windows.Forms.Label lbl_Almacen;
        private System.Windows.Forms.ComboBox comboBox_Unidad;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Fecha;
        private System.Windows.Forms.TextBox txt_Saldo;
        private System.Windows.Forms.TextBox txt_PrecioVenta;
        private System.Windows.Forms.TextBox txt_PrecioCompra;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.ComboBox comboBox_Materiaprima;
        private System.Windows.Forms.ComboBox comboBox_Concepto;
        private System.Windows.Forms.TextBox txt_Lote;
        private System.Windows.Forms.ComboBox comboBox_Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materiaprima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipopieza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipomateriaprima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Maxima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Minima;
        //MENU
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercadeToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider_Textbox;
        private System.Windows.Forms.ErrorProvider errorProvider_Combobox;
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
            lbl_Materiaprima = new System.Windows.Forms.Label();
            lbl_Concepto = new System.Windows.Forms.Label();
            lbl_Lote = new System.Windows.Forms.Label();
            lbl_Almacen = new System.Windows.Forms.Label();
            comboBox_Unidad = new System.Windows.Forms.ComboBox();
            dateTimePicker_Fecha = new System.Windows.Forms.DateTimePicker();
            txt_Saldo = new System.Windows.Forms.TextBox();
            txt_PrecioVenta = new System.Windows.Forms.TextBox();
            txt_PrecioCompra = new System.Windows.Forms.TextBox();
            txt_Cantidad = new System.Windows.Forms.TextBox();
            comboBox_Materiaprima = new System.Windows.Forms.ComboBox();
            comboBox_Concepto = new System.Windows.Forms.ComboBox();
            txt_Lote = new System.Windows.Forms.TextBox();
            comboBox_Almacen = new System.Windows.Forms.ComboBox();
            groupBoxInventario = new System.Windows.Forms.GroupBox();
            dataGridViewInventario = new System.Windows.Forms.DataGridView();
            pic_Logo = new System.Windows.Forms.PictureBox();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Materiaprima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Tipopieza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Tipomateriaprima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cantidad_Maxima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cantidad_Minima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            //MENU
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tipo_pieza));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            acercadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            errorProvider_Textbox = new System.Windows.Forms.ErrorProvider(components);
            errorProvider_Combobox = new System.Windows.Forms.ErrorProvider(components);
            menuStrip1.SuspendLayout();
            groupBox_Datos.SuspendLayout();
            groupBoxInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridViewInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pic_Logo)).BeginInit();
            SuspendLayout();
            #endregion
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            acercadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            // 
            // menuStrip1
            // 
            ((System.ComponentModel.ISupportInitialize)(errorProvider_Textbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(errorProvider_Combobox)).BeginInit();
            menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(186)))), ((int)(((byte)(82)))));
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            archivoToolStripMenuItem,
            editarToolStripMenuItem,
            ayudaToolStripMenuItem});
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(448, 24);
            menuStrip1.TabIndex = 77;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            nuevoToolStripMenuItem,
            abrirToolStripMenuItem,
            toolStripSeparator,
            guardarToolStripMenuItem,
            toolStripSeparator1,
            salirToolStripMenuItem});
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            nuevoToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Nuevo;
            nuevoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            nuevoToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            nuevoToolStripMenuItem.Text = "&Nuevo";
            nuevoToolStripMenuItem.Click += new System.EventHandler(nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripMenuItem.Image")));
            abrirToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Abrir;
            abrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            abrirToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            abrirToolStripMenuItem.Text = "&Abrir";
            abrirToolStripMenuItem.Click += new System.EventHandler(abrirToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new System.Drawing.Size(148, 6);
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripMenuItem.Image")));
            guardarToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Guardar;
            guardarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            guardarToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            guardarToolStripMenuItem.Text = "&Guardar";
            guardarToolStripMenuItem.Click += new System.EventHandler(guardarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            salirToolStripMenuItem.Text = "&Salir";
            salirToolStripMenuItem.Click += new System.EventHandler(salirToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            modificarToolStripMenuItem,
            eliminarToolStripMenuItem});
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            editarToolStripMenuItem.Text = "&Editar";
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.Enabled = false;
            modificarToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Modificar;
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            modificarToolStripMenuItem.Text = "Modificar";
            modificarToolStripMenuItem.Click += new System.EventHandler(modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Enabled = false;
            eliminarToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Borrar;
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += new System.EventHandler(eliminarToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            acercadeToolStripMenuItem});
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            ayudaToolStripMenuItem.Text = "Ay&uda";
            // 
            // acercadeToolStripMenuItem
            // 
            acercadeToolStripMenuItem.Name = "acercadeToolStripMenuItem";
            acercadeToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            acercadeToolStripMenuItem.Text = "&Acerca de...";
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
            groupBox_Datos.Controls.Add(lbl_Materiaprima);
            groupBox_Datos.Controls.Add(lbl_Concepto);
            groupBox_Datos.Controls.Add(lbl_Lote);
            groupBox_Datos.Controls.Add(lbl_Almacen);
            groupBox_Datos.Controls.Add(comboBox_Unidad);
            groupBox_Datos.Controls.Add(dateTimePicker_Fecha);
            groupBox_Datos.Controls.Add(txt_Saldo);
            groupBox_Datos.Controls.Add(txt_PrecioVenta);
            groupBox_Datos.Controls.Add(txt_PrecioCompra);
            groupBox_Datos.Controls.Add(txt_Cantidad);
            groupBox_Datos.Controls.Add(comboBox_Materiaprima);
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
            // errorProvider_Textbox
            // 
            errorProvider_Textbox.ContainerControl = this;
            // 
            // errorProvider_Combobox
            // 
            errorProvider_Combobox.ContainerControl = this;
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
            lbl_Saldo.Location = new System.Drawing.Point(436, 57);
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
            // lbl_Materiaprima
            // 
            lbl_Materiaprima.AutoSize = true;
            lbl_Materiaprima.Location = new System.Drawing.Point(14, 113);
            lbl_Materiaprima.Name = "lbl_Materiaprima";
            lbl_Materiaprima.Size = new System.Drawing.Size(50, 13);
            lbl_Materiaprima.TabIndex = 13;
            lbl_Materiaprima.Text = "Materia prima";
            // 
            // lbl_Concepto
            // 
            lbl_Concepto.AutoSize = true;
            lbl_Concepto.Location = new System.Drawing.Point(14, 85);
            lbl_Concepto.Name = "lbl_Concepto";
            lbl_Concepto.Size = new System.Drawing.Size(53, 13);
            lbl_Concepto.TabIndex = 12;
            lbl_Concepto.Text = "Concepto";
            // 
            // lbl_Lote
            // 
            lbl_Lote.AutoSize = true;
            lbl_Lote.Location = new System.Drawing.Point(14, 57);
            lbl_Lote.Name = "lbl_Lote";
            lbl_Lote.Size = new System.Drawing.Size(28, 13);
            lbl_Lote.TabIndex = 11;
            lbl_Lote.Text = "Lote";
            // 
            // lbl_Almacen
            // 
            lbl_Almacen.AutoSize = true;
            lbl_Almacen.Location = new System.Drawing.Point(14, 32);
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
            txt_Saldo.Location = new System.Drawing.Point(483, 54);
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
            // txt_Cantidad
            // 
            txt_Cantidad.Location = new System.Drawing.Point(319, 29);
            txt_Cantidad.MaxLength = 9;
            txt_Cantidad.Name = "txt_Cantidad";
            txt_Cantidad.Size = new System.Drawing.Size(100, 20);
            txt_Cantidad.TabIndex = 4;
            // 
            // comboBox_Materiaprima
            // 
            comboBox_Materiaprima.FormattingEnabled = true;
            comboBox_Materiaprima.Location = new System.Drawing.Point(102, 107);
            comboBox_Materiaprima.Name = "comboBox_Materiaprima";
            comboBox_Materiaprima.Size = new System.Drawing.Size(191, 21);
            comboBox_Materiaprima.TabIndex = 3;
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
            dataGridViewInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Id,
            Materiaprima,
            Tipopieza,
            Lote,
            Descripción,
            Tipomateriaprima,
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
            // Materiaprima
            // 
            Materiaprima.HeaderText = "Materiaprima";
            Materiaprima.Name = "Materiaprima";
            Materiaprima.Width = 75;
            // 
            // Descripción
            // 
            Descripción.HeaderText = "Descripción";
            Descripción.Name = "Descripción";
            Descripción.Width = 88;
            // 
            // Lote
            // 
            Lote.HeaderText = "Lote";
            Lote.Name = "Lote";
            Lote.Width = 28;
            // 
            // Tipopieza
            // 
            Tipopieza.HeaderText = "Tipo de pieza";
            Tipopieza.Name = "Tipopieza";
            Tipopieza.Width = 77;
            // 
            // Tipomateriaprima
            // 
            Tipomateriaprima.HeaderText = "Tipo de materia prima";
            Tipomateriaprima.Name = "Tipomateriaprima";
            Tipomateriaprima.Width = 53;
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
            Controls.Add(menuStrip1);
            Controls.Add(groupBox_Datos);
            Icon = global::Sistema_Shajobe.Properties.Resources.Inventario_ICO;
            MinimumSize = new System.Drawing.Size(913, 605);
            MaximumSize = new System.Drawing.Size(913, 605);
            MaximizeBox = false;
            Name = "Inventario_Materiaprima";
            Text = "Inventario de materia prima";
            WindowState = System.Windows.Forms.FormWindowState.Normal;
            groupBox_Datos.ResumeLayout(false);
            groupBox_Datos.PerformLayout();
            groupBoxInventario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(dataGridViewInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pic_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(errorProvider_Textbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(errorProvider_Combobox)).EndInit();
            ResumeLayout(false);
        }
        #endregion
        private void Inventario_Materiaprima_Load(object sender, EventArgs e)
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
            Llenando_ComboboxMateriaprima();
            Llenando_ComboboxUnidadMedida();
            Llenando_ComboboxConcepto();
            Llenando_DataGridViewInventario();
        }
        //-------------------------------------------------------------
        //------------------VARIABLES Y ARREGLOS-----------------------
        //-------------------------------------------------------------
        private TextBox[] Campos = new TextBox[4];
        private ComboBox[] CamposC = new ComboBox[4];
        private int Idp;//LO USO PARA OBTENER EL ID COMO RESULTADO DE LA BUSQUEDA
        private bool Espacios_Vacios = false, Espacios_NoSeleccionados = false;
        //-------------------------------------------------------------
        //------------------BUSQUEDA DEL SISTEMA-----------------------
        //-------------------------------------------------------------
        #region Busquedas del sistema
        //-------------------------------------------------------------
        //------------------DATAGRIDVIEW BUSQUEDA----------------------
        //-------------------------------------------------------------

        //ACCION QUE REALIZA CUANDO SE DA DOBLE CLIC SOBRE EL DATAGRIDVIEW DE BUSQUEDA
        private void data_resultado_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Idp = Convert.ToInt32(data_resultado.CurrentRow.Cells["Idb"].Value);
            Limpiar();
            BusquedaDatos(Idp);
            //Quito el panel de busqueda
            Controls.Remove(panel_Busqueda);
        }
        public void BusquedaDatos(int Idp)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "SELECT Tb_InventarioMateriaprima.Id_Almacen, Tb_InventarioMateriaprima.Lote,Tb_InventarioMateriaprimadetalle.Id_Concepto, Tb_Materiaprima.Id_Materiaprima, Tb_InventarioMateriaprimadetalle.Cantidad_Actual, Tb_InventarioMateriaprimadetalle.Precio_Compra, Tb_InventarioMateriaprimadetalle.Precio_Venta, Tb_InventarioMateriaprimadetalle.Saldo_Articulos, Tb_InventarioMateriaprimadetalle.Id_Unidadmedida, Tb_InventarioMateriaprimadetalle.Fecha_Modificacion FROM Tb_Materiaprima INNER JOIN Tb_InventarioMateriaprimadetalle ON Tb_Materiaprima.Id_Materiaprima = Tb_InventarioMateriaprimadetalle.Id_Materiaprima INNER JOIN Tb_InventarioMateriaprima ON Tb_InventarioMateriaprimadetalle.Id_InventarioMateriaprima = Tb_InventarioMateriaprima.Id_InventarioMateriaprima where Tb_InventarioMateriaprima.Id_InventarioMateriaprima='" + Idp + "'";
            coman.CommandType = CommandType.Text;
            con.Open();
            data_resultado.Rows.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Combobox de almacén
                int seleccion = dr.GetInt32(dr.GetOrdinal("Id_Almacen"));
                seleccion = seleccion - 1;
                comboBox_Almacen.SelectedIndex = seleccion;
                //Txt txt_Lote
                txt_Lote.Text = dr.GetString(dr.GetOrdinal("Lote"));
                //Combobox concepto
                int seleccion1 = dr.GetInt32(dr.GetOrdinal("Id_Concepto"));
                seleccion1 = seleccion1 - 1;
                comboBox_Concepto.SelectedIndex = seleccion1;
                //Combobox Materiaprima
                int seleccion2 = dr.GetInt32(dr.GetOrdinal("Id_Materiaprima"));
                seleccion2 = seleccion2 - 1;
                comboBox_Materiaprima.SelectedIndex = seleccion2;
                //txt cantidad
                txt_Cantidad.Text = dr.GetDecimal(dr.GetOrdinal("Cantidad_Actual")).ToString("N");
                //txt precio compra
                txt_PrecioCompra.Text = dr.GetDecimal(dr.GetOrdinal("Precio_Compra")).ToString("N");
                //txt precio Venta
                txt_PrecioVenta.Text = dr.GetDecimal(dr.GetOrdinal("Precio_Venta")).ToString("N");
                //txt saldo
                txt_Saldo.Text = dr.GetDecimal(dr.GetOrdinal("Saldo_Articulos")).ToString("N");
                //Combobox unidad
                int seleccion3 = dr.GetInt32(dr.GetOrdinal("Id_Unidadmedida"));
                seleccion3 = seleccion3 - 1;
                comboBox_Unidad.SelectedIndex = seleccion3;
                //Fecha
                //dateTimePicker_Fecha.Value=
                eliminarToolStripMenuItem.Enabled = true;
                modificarToolStripMenuItem.Enabled = true;
            }
            con.Close();
        }
        private void Busqueda()
        {
            if (txt_Busqueda.Text.Trim() == "")
            {
                errorProvider_Textbox.SetError(txt_Busqueda, "No puedes dejar el campo vacio");
                MessageBox.Show("Inserta todos los datos marcados", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OleDbConnection con = new OleDbConnection();
                OleDbCommand coman = new OleDbCommand();
                OleDbDataReader dr;
                con.ConnectionString = ObtenerString();
                coman.Connection = con;
                string busqueda = txt_Busqueda.Text;
                txt_Busqueda.Text = busqueda.ToUpper();
                //coman.CommandText = "Select * from Tb_Materiaprima  where (Nombre='" + busqueda.ToUpper() + "'OR Tipopieza='" + busqueda.ToUpper() + "') AND Activo='S'";
                coman.CommandText = "SELECT Tb_Inventariomateriaprima.Id_Inventariomateriaprima, Tb_MateriaPrima.Nombre, Tb_TipoPieza.Nombre AS TipoPieza, Tb_MateriaPrima.Descripcion FROM Tb_Inventariomateriaprima INNER JOIN Tb_Inventariomateriaprimadetalle ON  Tb_Inventariomateriaprima.Id_Inventariomateriaprima = Tb_Inventariomateriaprimadetalle.Id_Inventariomateriaprima INNER JOIN Tb_MateriaPrima ON Tb_Inventariomateriaprimadetalle.Id_MateriaPrima = Tb_MateriaPrima.Id_MateriaPrima INNER JOIN Tb_TipoPieza ON Tb_MateriaPrima.Id_TipoPieza = Tb_TipoPieza.Id_TipoPieza WHERE (Tb_MateriaPrima.Nombre = '" + busqueda.ToUpper() + "')";
                coman.CommandType = CommandType.Text;
                con.Open();
                data_resultado.Rows.Clear();
                dr = coman.ExecuteReader();
                while (dr.Read())
                {
                    int Renglon = data_resultado.Rows.Add();
                    Idp = dr.GetInt32(dr.GetOrdinal("Id_InventarioMateriaprima"));
                    data_resultado.Rows[Renglon].Cells["Idb"].Value = dr.GetInt32(dr.GetOrdinal("Id_InventarioMateriaprima"));
                    data_resultado.Rows[Renglon].Cells["Nombreb"].Value = dr.GetString(dr.GetOrdinal("Nombre"));
                    data_resultado.Rows[Renglon].Cells["TipoPiezab"].Value = dr.GetString(dr.GetOrdinal("TipoPieza"));
                    data_resultado.Rows[Renglon].Cells["Descripcionb"].Value = dr.GetString(dr.GetOrdinal("Descripcion"));
                }
                con.Close();
            }
        }
        private void bttn_Busqueda_Click(object sender, EventArgs e)
        {
            Busqueda();
        }
        #endregion
        //-------------------------------------------------------------
        //-------------------LLENANDO CONTROLES------------------------
        //-------------------------------------------------------------
        private void Llenando_ComboboxMateriaprima()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "SELECT dbo.Tb_MateriaPrima.Nombre, dbo.Tb_TipoPieza.Nombre AS Tipo_Pieza FROM dbo.Tb_MateriaPrima INNER JOIN dbo.Tb_TipoPieza ON dbo.Tb_MateriaPrima.Id_TipoPieza = dbo.Tb_TipoPieza.Id_TipoPieza WHERE (dbo.Tb_MateriaPrima.Activo = 'S')";
            coman.CommandType = CommandType.Text;
            con.Open();
            comboBox_Materiaprima.Items.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Declarando Variables y obteniendo los valores correspondiente
                string NombreN = dr.GetString(dr.GetOrdinal("Nombre"));
                string Tipo_PiezaN = dr.GetString(dr.GetOrdinal("Tipo_Pieza"));
                string NombreMP = NombreN +" "+Tipo_PiezaN;
                comboBox_Materiaprima.Items.Add(NombreMP);
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
        private void Llenando_ComboboxConcepto()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "Select Nombre from Tb_Concepto";
            coman.CommandType = CommandType.Text;
            con.Open();
            comboBox_Concepto.Items.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Declarando Variables y obteniendo los valores correspondiente
                string Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                comboBox_Concepto.Items.Add(Nombre);
            }
            con.Close();
        }
        private void Llenando_DataGridViewInventario()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "SELECT Tb_Inventariomateriaprima.Lote,Tb_MateriaPrima.Id_MateriaPrima, Tb_MateriaPrima.Nombre, Tb_MateriaPrima.Descripcion, Tb_TipoPieza.Nombre AS Tipopieza, Tb_Tipomateriaprima.Nombre AS Tipomateriaprima, Tb_Inventariomateriaprimadetalle.Cantidad_Actual, Tb_Nivelmateriaprima.N_Max, Tb_Nivelmateriaprima.N_Min FROM Tb_MateriaPrima INNER JOIN Tb_Nivelmateriaprima ON Tb_MateriaPrima.Id_MateriaPrima = Tb_Nivelmateriaprima.Id_MateriaPrima INNER JOIN Tb_TipoPieza ON Tb_MateriaPrima.Id_TipoPieza = Tb_TipoPieza.Id_TipoPieza INNER JOIN Tb_Tipomateriaprima ON Tb_MateriaPrima.Id_Tipomateriaprima = Tb_Tipomateriaprima.Id_Tipomateriaprima INNER JOIN Tb_Inventariomateriaprimadetalle ON Tb_MateriaPrima.Id_MateriaPrima = Tb_Inventariomateriaprimadetalle.Id_MateriaPrima INNER JOIN Tb_Inventariomateriaprima ON Tb_Inventariomateriaprimadetalle.Id_Inventariomateriaprima = Tb_Inventariomateriaprima.Id_Inventariomateriaprima";
            coman.CommandType = CommandType.Text;
            con.Open();
            dataGridViewInventario.Rows.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Creando y obteniendo el indice para un nuevo renglon
                int Indice = dataGridViewInventario.Rows.Add();
                dataGridViewInventario.Rows[Indice].Cells["Id"].Value = dr.GetInt32(dr.GetOrdinal("Id_MateriaPrima"));
                dataGridViewInventario.Rows[Indice].Cells["Materiaprima"].Value = dr.GetString(dr.GetOrdinal("Nombre"));
                dataGridViewInventario.Rows[Indice].Cells["Descripción"].Value = dr.GetString(dr.GetOrdinal("Descripcion"));
                dataGridViewInventario.Rows[Indice].Cells["Lote"].Value = dr.GetString(dr.GetOrdinal("Lote"));
                dataGridViewInventario.Rows[Indice].Cells["Tipopieza"].Value = dr.GetString(dr.GetOrdinal("Tipopieza"));
                dataGridViewInventario.Rows[Indice].Cells["Tipomateriaprima"].Value = dr.GetString(dr.GetOrdinal("Tipomateriaprima"));
                dataGridViewInventario.Rows[Indice].Cells["Cantidad"].Value = dr.GetDecimal(dr.GetOrdinal("Cantidad_Actual")).ToString("N");
                dataGridViewInventario.Rows[Indice].Cells["Cantidad_Maxima"].Value = dr.GetDecimal(dr.GetOrdinal("N_Max")).ToString("N");
                dataGridViewInventario.Rows[Indice].Cells["Cantidad_Minima"].Value = dr.GetDecimal(dr.GetOrdinal("N_Min")).ToString("N");
            }
            con.Close();
        }
        //-------------------------------------------------------------
        //----------------CONFIGURACION DE CONTROLES-------------------
        //-------------------------------------------------------------
        #region Funciones A, B y C
        // ALTAS, BAJAS Y CAMBIOS
        #region Guardar
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool i = Verificar_CamposVacios();
            bool ic = Verificar_CamposNoSeleccionados();
            if (i == true && ic == true)
                MessageBox.Show("Inserta todos los datos marcados", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                //Generando el saldo
                decimal p, c, r;
                p = Convert.ToDecimal(txt_PrecioCompra.Text);
                c = Convert.ToDecimal(txt_Cantidad.Text);
                r = p * c;
                txt_Saldo.Text = r.ToString("N");
                //Primer procedimiento
                OleDbConnection conexion = null;
                OleDbTransaction transaccion = null;
                try
                {
                    conexion = new OleDbConnection(ObtenerString());
                    conexion.Open();
                    transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                    OleDbCommand comando = new OleDbCommand("SP_InventarioMateriaprima_Alta", conexion, transaccion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@Id_Almacen", comboBox_Almacen.SelectedIndex + 1);
                    comando.Parameters.AddWithValue("@Lote", txt_Lote.Text);
                    comando.Parameters.AddWithValue("@Id_Concepto", comboBox_Concepto.SelectedIndex + 1);
                    comando.Parameters.AddWithValue("@Id_Materiaprima", comboBox_Materiaprima.SelectedIndex + 1);
                    comando.Parameters.AddWithValue("@Id_Unidadmedida", comboBox_Unidad.SelectedIndex + 1);
                    comando.Parameters.AddWithValue("@Cantidad_Actual", Convert.ToDecimal(txt_Cantidad.Text));
                    comando.Parameters.AddWithValue("@Precio_Compra", Convert.ToDecimal(txt_PrecioCompra.Text));
                    comando.Parameters.AddWithValue("@Precio_Venta", Convert.ToDecimal(txt_PrecioVenta.Text));
                    comando.Parameters.AddWithValue("@Saldo_Articulos", Convert.ToDecimal(txt_Saldo.Text));
                    comando.Parameters.AddWithValue("@Fecha_Modificacion", dateTimePicker_Fecha.Value);
                    comando.ExecuteNonQuery();
                    transaccion.Commit();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error inesperado", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    transaccion.Rollback();
                }
                finally
                {
                    conexion.Close();
                    MessageBox.Show("Datos guardados con éxito", "Solicitud procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
            }
        }
        #endregion
        #region Cambios
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool i = Verificar_CamposVacios();
            bool ic = Verificar_CamposNoSeleccionados();
            if (i == true && ic == true)
                MessageBox.Show("Inserta todos los datos marcados", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                //Generando el saldo
                decimal p, c, r;
                p = Convert.ToDecimal(txt_PrecioCompra.Text);
                c = Convert.ToDecimal(txt_Cantidad.Text);
                r = p * c;
                txt_Saldo.Text = r.ToString("N");
                OleDbConnection con = null;
                OleDbTransaction tran = null;
                try
                {
                    con = new OleDbConnection(ObtenerString());
                    con.Open();
                    tran = con.BeginTransaction(System.Data.IsolationLevel.Serializable);
                    OleDbCommand comando = new OleDbCommand("SP_InventarioMateriaprima_Cambios", con, tran);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@Id_InventarioMateriaprima", Idp);
                    comando.Parameters.AddWithValue("@Id_Almacen", comboBox_Almacen.SelectedIndex + 1);
                    comando.Parameters.AddWithValue("@Lote", txt_Lote.Text);
                    comando.Parameters.AddWithValue("@Id_Concepto", comboBox_Concepto.SelectedIndex + 1);
                    comando.Parameters.AddWithValue("@Id_Materiaprima", comboBox_Materiaprima.SelectedIndex + 1);
                    comando.Parameters.AddWithValue("@Id_Unidadmedida", comboBox_Unidad.SelectedIndex + 1);
                    comando.Parameters.AddWithValue("@Cantidad_Actual", Convert.ToDecimal(txt_Cantidad.Text));
                    comando.Parameters.AddWithValue("@Precio_Compra", Convert.ToDecimal(txt_PrecioCompra.Text));
                    comando.Parameters.AddWithValue("@Precio_Venta", Convert.ToDecimal(txt_PrecioVenta.Text));
                    comando.Parameters.AddWithValue("@Saldo_Articulos", Convert.ToDecimal(txt_Saldo.Text));
                    comando.Parameters.AddWithValue("@Fecha_Modificacion", dateTimePicker_Fecha.Value);
                    comando.ExecuteNonQuery();
                    tran.Commit();
                    MessageBox.Show("Datos Modificados con éxito", "Solicitud procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error inesperado", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tran.Rollback();
                }
                finally
                {
                    con.Close();
                }
            }
        }
        #endregion
        #region Eliminar
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection conexion = null;
            OleDbTransaction transaccion = null;
            try
            {
                conexion = new OleDbConnection(ObtenerString());
                conexion.Open();
                transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                OleDbCommand comando = new OleDbCommand("SP_Inventariomateriaprima_Bajas", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Id_InventarioMateriaprima", Idp);
                comando.ExecuteNonQuery();
                transaccion.Commit();
                MessageBox.Show("Datos Modificados con éxito", "Solicitud procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error inesperado", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                transaccion.Rollback();
            }
            finally
            {
                conexion.Close();
                
            }
        }
        #endregion
        #endregion
        #region Funciones N, A y S
        //NUEVO, ABRIR Y SALIR
        #region Nuevo
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            comboBox_Almacen.ResetText();
            txt_Lote.Clear();
            comboBox_Concepto.ResetText();
            comboBox_Materiaprima.ResetText();
            dataGridViewInventario.Rows.Clear();
            txt_Cantidad.Clear();
            txt_PrecioCompra.Clear();
            txt_PrecioVenta.Clear();
            txt_Saldo.Clear();
            comboBox_Unidad.ResetText();
            dateTimePicker_Fecha.ResetText();
            Llenando_DataGridViewInventario();
            eliminarToolStripMenuItem.Enabled = false;
            modificarToolStripMenuItem.Enabled = false;
            //errorProvider1.Clear();
            try //Quita el panel de control en caso de que ya se haya utilizado
            {
                //Quito el panel de busqueda
                Controls.Remove(panel_Busqueda);
            }
            catch (Exception)
            {
                //En caso de que no existe todavia el panel de busqueda
                //omite la instrucción de quitar dicho control
            }
            try //Limpia el textbox de busqueda por si ya se utilizo
            {
                //Quito el panel de busqueda
                txt_Busqueda.Clear();
            }
            catch (Exception)
            {
                //En caso de que no existe todavia el texbox
                //omite la instrucción de quitar dicho control
            }
        }
        #endregion
        #region Abrir
        #region Declarando controles
        //Creando controles
        private DataGridView data_resultado;
        private TextBox txt_Busqueda;
        private PictureBox pic_Lupa;
        private Button bttn_Busqueda;
        private Panel panel_Busqueda;
        private Label lbl_Etiqueta;
        //Creando Columnas del DATAGRID
        private DataGridViewTextBoxColumn Descripcionb;
        private DataGridViewTextBoxColumn TipoPiezab;
        private DataGridViewTextBoxColumn Nombreb;
        private DataGridViewTextBoxColumn Idb;
        //private DataGridViewTextBoxColumn Cantidadb;
        #endregion
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Creando controles
            //INICIALIZANDO CONTROLES
            txt_Busqueda = new System.Windows.Forms.TextBox();
            panel_Busqueda = new System.Windows.Forms.Panel();
            data_resultado = new System.Windows.Forms.DataGridView();
            pic_Lupa = new System.Windows.Forms.PictureBox();
            bttn_Busqueda = new System.Windows.Forms.Button();
            lbl_Etiqueta = new System.Windows.Forms.Label();
            //groupBoxfoto.SuspendLayout();
            //INICIALIZANDO COLUMNAS
            Descripcionb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TipoPiezab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombreb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Idb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            //Cantidadb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            #endregion
            #region Diseño de controles
            //DISEÑOS DE A LOS CONTROLES
            txt_Busqueda.Location = new System.Drawing.Point(130, 57);
            txt_Busqueda.Name = "txt_Busqueda";
            txt_Busqueda.Size = new System.Drawing.Size(124, 20);
            txt_Busqueda.TabIndex = 0;
            txt_Busqueda.MaxLength = 9;
            txt_Busqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_Busqueda_KeyPress);
            // 
            // pic_Lupa
            // 
            pic_Lupa.BackgroundImage = ((System.Drawing.Image)(global::Sistema_Shajobe.Properties.Resources.lupa));
            pic_Lupa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pic_Lupa.Location = new System.Drawing.Point(21, 19);
            pic_Lupa.Name = "pic_Lupa";
            pic_Lupa.Size = new System.Drawing.Size(100, 101);
            pic_Lupa.TabIndex = 1;
            pic_Lupa.TabStop = false;
            // 
            // data_resultado
            // 
            data_resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_resultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Idb,
            Nombreb,TipoPiezab,
            Descripcionb});//, Cantidadb});
            data_resultado.Location = new System.Drawing.Point(11, 126);
            data_resultado.Name = "data_resultado";
            data_resultado.RowHeadersWidth = 25;
            data_resultado.RowTemplate.Height = 25;
            data_resultado.Size = new System.Drawing.Size(340, 100);
            data_resultado.TabIndex = 2;
            data_resultado.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(data_resultado_MouseDoubleClick);
            data_resultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            //
            // Cantidadb
            // 
            //Cantidadb.HeaderText = "Cantidad";
            //Cantidadb.Name = "Cantidadb";
            //
            // Descripcion
            // 
            Descripcionb.HeaderText = "Descripcion";
            Descripcionb.Name = "Descripcionb";
            //
            // TipoPiezab
            // 
            TipoPiezab.HeaderText = "Tipo de pieza";
            TipoPiezab.Name = "TipoPiezab";
            // 
            // Nombre
            // 
            Nombreb.HeaderText = "Nombre";
            Nombreb.Name = "Nombreb";
            // 
            // Id
            // 
            Idb.HeaderText = "Id";
            Idb.Name = "Idb";
            Idb.Visible = false;
            // 
            // lbl_Etiqueta
            // 
            lbl_Etiqueta.AutoSize = true;
            lbl_Etiqueta.Location = new System.Drawing.Point(100, 16);
            lbl_Etiqueta.Name = "lbl_Etiqueta";
            lbl_Etiqueta.Size = new System.Drawing.Size(419, 13);
            lbl_Etiqueta.TabIndex = 3;
            lbl_Etiqueta.Text = "Escriba el nombre de la Materiaprima a buscar";
            // 
            // bttn_Busqueda
            // 
            bttn_Busqueda.BackgroundImage = ((System.Drawing.Image)(global::Sistema_Shajobe.Properties.Resources.Siguiente));
            bttn_Busqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            bttn_Busqueda.Location = new System.Drawing.Point(274, 48);
            bttn_Busqueda.Name = "bttn_Busqueda";
            bttn_Busqueda.Size = new System.Drawing.Size(62, 54);
            bttn_Busqueda.TabIndex = 4;
            bttn_Busqueda.UseVisualStyleBackColor = true;
            bttn_Busqueda.Click += new System.EventHandler(bttn_Busqueda_Click);
            // 
            // panel_Busqueda
            // 
            panel_Busqueda.Controls.Add(bttn_Busqueda);
            panel_Busqueda.Controls.Add(lbl_Etiqueta);
            panel_Busqueda.Controls.Add(data_resultado);
            panel_Busqueda.Controls.Add(pic_Lupa);
            panel_Busqueda.Controls.Add(txt_Busqueda);
            panel_Busqueda.Enabled = false;
            panel_Busqueda.Location = new System.Drawing.Point(250, 200);
            panel_Busqueda.Name = "panel_Busqueda";
            panel_Busqueda.Size = new System.Drawing.Size(370, 235);
            panel_Busqueda.TabIndex = 35;
            panel_Busqueda.BorderStyle = BorderStyle.FixedSingle;
            panel_Busqueda.Visible = false;
            //CARACTERISTICA DE AUTOCOMPLETADO EN TXT_BUSQUEDA
            txt_Busqueda.AutoCompleteCustomSource = Autocomplete();
            txt_Busqueda.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_Busqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Controls.Add(panel_Busqueda);
            panel_Busqueda.Visible = true;
            panel_Busqueda.Enabled = true;
            panel_Busqueda.BringToFront();
            txt_Busqueda.Focus();
            #endregion
        }
        #endregion
        #region Salir
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
        #endregion
        //-------------------------------------------------------------
        //---------------CONTROL DE ESPACIOS VACIOS--------------------
        //-------------------------------------------------------------
        #region Verificar campos vacios
        //METODOS PARA INDICAR ERROR DE CAMPOS VACIOS
        private bool Verificar_CamposVacios()
        {
            //Se introduce los textbox en un arreglo con el fin de identificar espacios vacios
            Campos[0] = txt_Lote;
            Campos[1] = txt_Cantidad;
            Campos[2] = txt_PrecioCompra;
            Campos[3] = txt_PrecioVenta;
            //Campos[4] = txt_Saldo;
            //Reinicio el error provider para volver a reemarcar
            errorProvider_Textbox.Clear();
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
                    errorProvider_Textbox.SetError(txt_Lote, "No puedes dejar el campo vacio");
                    break;
                case 1:
                    errorProvider_Textbox.SetError(txt_Cantidad, "No puedes dejar el campo vacio");
                    break;
                case 2:
                    errorProvider_Textbox.SetError(txt_PrecioCompra, "No puedes dejar el campo vacio");
                    break;
                case 3:
                    errorProvider_Textbox.SetError(txt_PrecioVenta, "No puedes dejar el campo vacio");
                    break;
                //case 4:
                //    errorProvider_Textbox.SetError(txt_Saldo, "No puedes dejar el campo vacio");
                //    break;
                default:
                    break;
            }
        }
        #endregion
        #region Verificar campos no seleccionados
        private bool Verificar_CamposNoSeleccionados()
        {
            //Se introduce los textbox en un arreglo con el fin de identificar espacios vacios
            CamposC[0] = comboBox_Almacen;
            CamposC[1] = comboBox_Concepto;
            CamposC[2] = comboBox_Materiaprima;
            CamposC[3] = comboBox_Unidad;
            //Reinicio el error provider para volver a reemarcar
            errorProvider_Combobox.Clear();
            Espacios_Vacios = false;
            for (int i = 0; i < CamposC.Length; i++)
            {
                if (CamposC[i].Text.Trim() == "")
                {
                    Indicador_CamposNoSeleccionados(i);
                    Espacios_NoSeleccionados = true;
                }
            }
            return Espacios_NoSeleccionados;
        }
        private void Indicador_CamposNoSeleccionados(int i)
        {
            switch (i)
            {

                case 0:
                    errorProvider_Combobox.SetError(comboBox_Almacen, "No puedes dejar el campo vacio");
                    break;
                case 1:
                    errorProvider_Combobox.SetError(comboBox_Concepto, "No puedes dejar el campo vacio");
                    break;
                case 2:
                    errorProvider_Combobox.SetError(comboBox_Materiaprima, "No puedes dejar el campo vacio");
                    break;
                case 3:
                    errorProvider_Combobox.SetError(comboBox_Unidad, "No puedes dejar el campo vacio");
                    break;
                default:
                    break;
            }
        }
        #endregion
        //-------------------------------------------------------------
        //----------------------AUTO COMPLETAR-------------------------
        //-------------------------------------------------------------
        #region Funcion Autocompletar
        //metodo para cargar la coleccion de datos para el autocomplete
        public static DataTable Datos()
        {
            DataTable dt = new DataTable();
            OleDbConnection conexion = new OleDbConnection(ObtenerString());//cadena conexion
            string consulta = "SELECT Tb_MateriaPrima.Nombre, Tb_TipoPieza.Nombre AS Tipopieza, Tb_MateriaPrima.Id_MateriaPrima FROM Tb_MateriaPrima INNER JOIN Tb_TipoPieza ON Tb_MateriaPrima.Id_TipoPieza = Tb_TipoPieza.Id_TipoPieza INNER JOIN Tb_Inventariomateriaprimadetalle ON Tb_MateriaPrima.Id_MateriaPrima = Tb_Inventariomateriaprimadetalle.Id_MateriaPrima INNER JOIN Tb_Inventariomateriaprima ON Tb_Inventariomateriaprimadetalle.Id_Inventariomateriaprima = Tb_Inventariomateriaprima.Id_Inventariomateriaprima";
            OleDbCommand comando = new OleDbCommand(consulta, conexion);
            OleDbDataAdapter adap = new OleDbDataAdapter(comando);
            adap.Fill(dt);
            return dt;
        }
        public static AutoCompleteStringCollection Autocomplete()
        {
            DataTable dt = Datos();

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row["Nombre"]));
                coleccion.Add(Convert.ToString(row["Tipopieza"]));
            }

            return coleccion;
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
        //-------------------Validacion de campos----------------------
        //-------------------------------------------------------------
        #region Validacion de campos
        private void txt_Busqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47) && (e.KeyChar < 31 || e.KeyChar > 33))
            {
                MessageBox.Show("Solo se aceptan letras y numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void txt_Lote_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de numeros-----------------------------------------------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto-------------------------- Uso del espacio
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 97 || e.KeyChar > 122) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47) && (e.KeyChar < 31 || e.KeyChar > 33))
            {
                MessageBox.Show("Solo se aceptan numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de letras-----------------------------------------------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto-------------------------- Uso del espacio
            if ((e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47) && (e.KeyChar < 31 || e.KeyChar > 33))
            {
                MessageBox.Show("Solo se aceptan letras", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void txt_Descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47) && (e.KeyChar < 31 || e.KeyChar > 33))
            {
                MessageBox.Show("Solo se aceptan letras y numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
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
