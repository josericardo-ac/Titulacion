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
    public partial class Produccion : Form
    {
        public Produccion()
        {
            InitializeComponent();
        }
        #region Diseño de la forma
        #region Declarando controles de la forma
        private System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.Label lbl_Almacen;
        private System.Windows.Forms.ComboBox comboBox_Almacen;
        private System.Windows.Forms.DataGridView dataGridView_Composicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Materiaprima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materiaprima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Unidad;
        private System.Windows.Forms.GroupBox groupBox_Composicion;
        private System.Windows.Forms.GroupBox groupBox_Producto;
        private System.Windows.Forms.Label lbl_UnidadM;
        private System.Windows.Forms.Label lbl_CantidadM;
        private System.Windows.Forms.Label lbl_Unidad;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label lbl_Producto;
        private System.Windows.Forms.Label lbl_Lote;
        private System.Windows.Forms.ComboBox comboBox_Unidad;
        private System.Windows.Forms.Button bttn_Quitar;
        private System.Windows.Forms.Button bttn_Agregar;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Fecha;
        private System.Windows.Forms.DataGridView dataGridView_Materiaprima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia_prima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Pieza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Materiaprima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.TextBox txt_CantidadM;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.ComboBox comboBox_UnidadM;
        private System.Windows.Forms.ComboBox comboBox_Producto;
        private System.Windows.Forms.TextBox txt_Lote;
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
            pic_Logo = new System.Windows.Forms.PictureBox();
            lbl_Almacen = new System.Windows.Forms.Label();
            comboBox_Almacen = new System.Windows.Forms.ComboBox();
            dataGridView_Composicion = new System.Windows.Forms.DataGridView();
            Id_Materiaprima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Materiaprima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Id_Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBox_Composicion = new System.Windows.Forms.GroupBox();
            groupBox_Producto = new System.Windows.Forms.GroupBox();
            bttn_Quitar = new System.Windows.Forms.Button();
            bttn_Agregar = new System.Windows.Forms.Button();
            dateTimePicker_Fecha = new System.Windows.Forms.DateTimePicker();
            dataGridView_Materiaprima = new System.Windows.Forms.DataGridView();
            Id_Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Materia_prima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Tipo_Pieza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Tipo_Materiaprima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txt_CantidadM = new System.Windows.Forms.TextBox();
            txt_Cantidad = new System.Windows.Forms.TextBox();
            comboBox_UnidadM = new System.Windows.Forms.ComboBox();
            comboBox_Producto = new System.Windows.Forms.ComboBox();
            txt_Lote = new System.Windows.Forms.TextBox();
            comboBox_Unidad = new System.Windows.Forms.ComboBox();
            lbl_Lote = new System.Windows.Forms.Label();
            lbl_Producto = new System.Windows.Forms.Label();
            lbl_Fecha = new System.Windows.Forms.Label();
            lbl_Cantidad = new System.Windows.Forms.Label();
            lbl_Unidad = new System.Windows.Forms.Label();
            lbl_CantidadM = new System.Windows.Forms.Label();
            lbl_UnidadM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(dataGridView_Composicion)).BeginInit();
            groupBox_Composicion.SuspendLayout();
            groupBox_Producto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridView_Materiaprima)).BeginInit();
            //MENU
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produccion));
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
            SuspendLayout();
            #endregion
            // 
            // pic_Logo
            // 
            pic_Logo.BackgroundImage = global::Sistema_Shajobe.Properties.Resources.Logo_Shajobe;
            pic_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pic_Logo.Location = new System.Drawing.Point(680, 455);
            pic_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right))));
            pic_Logo.Name = "pic_Logo";
            pic_Logo.Size = new System.Drawing.Size(175, 75);
            pic_Logo.TabIndex = 33;
            pic_Logo.TabStop = false;
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
            // dataGridView_Composicion
            // 
            dataGridView_Composicion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Composicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Composicion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Id_Materiaprima,
            Materiaprima,
            Cantidad,
            Unidad,
            Id_Unidad});
            dataGridView_Composicion.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView_Composicion.Location = new System.Drawing.Point(3, 16);
            dataGridView_Composicion.Name = "dataGridView_Composicion";
            dataGridView_Composicion.Size = new System.Drawing.Size(450, 237);
            dataGridView_Composicion.TabIndex = 8;
            // 
            // Id_Materiaprima
            // 
            Id_Materiaprima.HeaderText = "Id_Materiaprima";
            Id_Materiaprima.Name = "Id_Materiaprima";
            Id_Materiaprima.Visible = false;
            // 
            // Materiaprima
            // 
            Materiaprima.HeaderText = "Materia prima";
            Materiaprima.Name = "Materiaprima";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Unidad
            // 
            Unidad.HeaderText = "Unidad";
            Unidad.Name = "Unidad";
            // 
            // Id_Unidad
            // 
            Id_Unidad.HeaderText = "Id_Unidad";
            Id_Unidad.Name = "Id_Unidad";
            Id_Unidad.Visible = false;
            // 
            // groupBox_Composicion
            // 
            groupBox_Composicion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            groupBox_Composicion.Controls.Add(dataGridView_Composicion);
            groupBox_Composicion.Location = new System.Drawing.Point(9, 272);
            groupBox_Composicion.Name = "groupBox_Composicion";
            groupBox_Composicion.Size = new System.Drawing.Size(455, 256);
            groupBox_Composicion.TabIndex = 12;
            groupBox_Composicion.TabStop = false;
            groupBox_Composicion.Text = "Composicion";
            // 
            // groupBox_Producto
            // 
            groupBox_Producto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            groupBox_Producto.Controls.Add(lbl_UnidadM);
            groupBox_Producto.Controls.Add(lbl_CantidadM);
            groupBox_Producto.Controls.Add(lbl_Unidad);
            groupBox_Producto.Controls.Add(lbl_Cantidad);
            groupBox_Producto.Controls.Add(lbl_Fecha);
            groupBox_Producto.Controls.Add(lbl_Producto);
            groupBox_Producto.Controls.Add(lbl_Lote);
            groupBox_Producto.Controls.Add(comboBox_Unidad);
            groupBox_Producto.Controls.Add(bttn_Quitar);
            groupBox_Producto.Controls.Add(bttn_Agregar);
            groupBox_Producto.Controls.Add(dateTimePicker_Fecha);
            groupBox_Producto.Controls.Add(dataGridView_Materiaprima);
            groupBox_Producto.Controls.Add(txt_CantidadM);
            groupBox_Producto.Controls.Add(txt_Cantidad);
            groupBox_Producto.Controls.Add(comboBox_UnidadM);
            groupBox_Producto.Controls.Add(comboBox_Producto);
            groupBox_Producto.Controls.Add(txt_Lote);
            groupBox_Producto.Controls.Add(lbl_Almacen);
            groupBox_Producto.Controls.Add(comboBox_Almacen);
            groupBox_Producto.Location = new System.Drawing.Point(9, 46);
            groupBox_Producto.Name = "groupBox_Producto";
            groupBox_Producto.Size = new System.Drawing.Size(855, 220);
            groupBox_Producto.TabIndex = 13;
            groupBox_Producto.TabStop = false;
            groupBox_Producto.Text = "Producción de producto";
            // 
            // lbl_Almacen
            // 
            lbl_Almacen.AutoSize = true;
            lbl_Almacen.Location = new System.Drawing.Point(13, 152);
            lbl_Almacen.Name = "lbl_Almacen";
            lbl_Almacen.Size = new System.Drawing.Size(48, 13);
            lbl_Almacen.TabIndex = 10;
            lbl_Almacen.Text = "Almacén";
            // 
            // comboBox_Almacen
            // 
            comboBox_Almacen.FormattingEnabled = true;
            comboBox_Almacen.Location = new System.Drawing.Point(71, 145);
            comboBox_Almacen.KeyPress += new KeyPressEventHandler(NoescrituracomboBox_KeyPress);
            comboBox_Almacen.Name = "comboBox_Almacen";
            comboBox_Almacen.Size = new System.Drawing.Size(121, 21);
            comboBox_Almacen.TabIndex = 0;
            // 
            // bttn_Quitar
            // 
            bttn_Quitar.Location = new System.Drawing.Point(392, 133);
            bttn_Quitar.Name = "bttn_Quitar";
            bttn_Quitar.Size = new System.Drawing.Size(75, 23);
            bttn_Quitar.Click += new System.EventHandler(bttn_Quitar_Click);
            bttn_Quitar.TabIndex = 21;
            bttn_Quitar.Text = "Quitar";
            bttn_Quitar.UseVisualStyleBackColor = true;
            // 
            // bttn_Agregar
            // 
            bttn_Agregar.Location = new System.Drawing.Point(392, 104);
            bttn_Agregar.Name = "bttn_Agregar";
            bttn_Agregar.Size = new System.Drawing.Size(75, 23);
            bttn_Agregar.Click += new System.EventHandler(bttn_Agregar_Click);
            bttn_Agregar.TabIndex = 20;
            bttn_Agregar.Text = "Agregar";
            bttn_Agregar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_Fecha
            // 
            dateTimePicker_Fecha.Location = new System.Drawing.Point(71, 88);
            dateTimePicker_Fecha.Name = "dateTimePicker_Fecha";
            dateTimePicker_Fecha.Size = new System.Drawing.Size(200, 20);
            dateTimePicker_Fecha.TabIndex = 19;
            // 
            // dataGridView_Materiaprima
            // 
            dataGridView_Materiaprima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Materiaprima.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Id_Materia,
            Materia_prima,
            Tipo_Pieza,
            Tipo_Materiaprima,
            Descripcion});
            dataGridView_Materiaprima.Location = new System.Drawing.Point(473, 28);
            dataGridView_Materiaprima.Name = "dataGridView_Materiaprima";
            dataGridView_Materiaprima.Size = new System.Drawing.Size(376, 186);
            dataGridView_Materiaprima.TabIndex = 18;
            // 
            // Id_Materia
            // 
            Id_Materia.HeaderText = "Id_Materia";
            Id_Materia.Name = "Id_Materia";
            Id_Materia.Visible = false;
            // 
            // Materia_prima
            // 
            Materia_prima.HeaderText = "Materia prima";
            Materia_prima.Name = "Materia_prima";
            // 
            // Tipo_Pieza
            // 
            Tipo_Pieza.HeaderText = "Tipo pieza";
            Tipo_Pieza.Name = "Tipo_Pieza";
            // 
            // Tipo_Materiaprima
            // 
            Tipo_Materiaprima.HeaderText = "Tipo de materia prima";
            Tipo_Materiaprima.Name = "Tipo_Materiaprima";
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            // 
            // txt_CantidadM
            // 
            txt_CantidadM.Location = new System.Drawing.Point(367, 35);
            txt_CantidadM.Name = "txt_CantidadM";
            txt_CantidadM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_Numeros_KeyPress);
            txt_CantidadM.Size = new System.Drawing.Size(100, 20);
            txt_CantidadM.TabIndex = 16;
            txt_CantidadM.MaxLength = 9;
            // 
            // txt_Cantidad
            // 
            txt_Cantidad.Location = new System.Drawing.Point(71, 117);
            txt_Cantidad.Name = "txt_Cantidad";
            txt_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_Numeros_KeyPress);
            txt_Cantidad.Size = new System.Drawing.Size(100, 20);
            txt_Cantidad.TabIndex = 15;
            txt_Cantidad.MaxLength = 9;
            // 
            // comboBox_UnidadM
            // 
            comboBox_UnidadM.FormattingEnabled = true;
            comboBox_UnidadM.Location = new System.Drawing.Point(367, 69);
            comboBox_UnidadM.KeyPress += new KeyPressEventHandler(NoescrituracomboBox_KeyPress);
            comboBox_UnidadM.Name = "comboBox_UnidadM";
            comboBox_UnidadM.Size = new System.Drawing.Size(68, 21);
            comboBox_UnidadM.TabIndex = 14;
            // 
            // comboBox_Producto
            // 
            comboBox_Producto.FormattingEnabled = true;
            comboBox_Producto.Location = new System.Drawing.Point(71, 56);
            comboBox_Producto.KeyPress += new KeyPressEventHandler(NoescrituracomboBox_KeyPress);
            comboBox_Producto.Name = "comboBox_Producto";
            comboBox_Producto.Size = new System.Drawing.Size(121, 21);
            comboBox_Producto.TabIndex = 13;
            // 
            // txt_Lote
            // 
            txt_Lote.Location = new System.Drawing.Point(71, 28);
            txt_Lote.Name = "txt_Lote";
            txt_Lote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_Numeros_KeyPress);
            txt_Lote.Size = new System.Drawing.Size(100, 20);
            txt_Lote.TabIndex = 12;
            txt_Lote.MaxLength = 14;
            // 
            // comboBox_Unidad
            // 
            comboBox_Unidad.FormattingEnabled = true;
            comboBox_Unidad.Location = new System.Drawing.Point(224, 116);
            comboBox_Unidad.KeyPress += new KeyPressEventHandler(NoescrituracomboBox_KeyPress);
            comboBox_Unidad.Name = "comboBox_Unidad";
            comboBox_Unidad.Size = new System.Drawing.Size(68, 21);
            comboBox_Unidad.TabIndex = 22;
            // 
            // lbl_Lote
            // 
            lbl_Lote.AutoSize = true;
            lbl_Lote.Location = new System.Drawing.Point(13, 35);
            lbl_Lote.Name = "lbl_Lote";
            lbl_Lote.Size = new System.Drawing.Size(28, 13);
            lbl_Lote.TabIndex = 24;
            lbl_Lote.Text = "Lote";
            // 
            // lbl_Producto
            // 
            lbl_Producto.AutoSize = true;
            lbl_Producto.Location = new System.Drawing.Point(13, 64);
            lbl_Producto.Name = "lbl_Producto";
            lbl_Producto.Size = new System.Drawing.Size(50, 13);
            lbl_Producto.TabIndex = 25;
            lbl_Producto.Text = "Producto";
            // 
            // lbl_Fecha
            // 
            lbl_Fecha.AutoSize = true;
            lbl_Fecha.Location = new System.Drawing.Point(13, 95);
            lbl_Fecha.Name = "lbl_Fecha";
            lbl_Fecha.Size = new System.Drawing.Size(37, 13);
            lbl_Fecha.TabIndex = 26;
            lbl_Fecha.Text = "Fecha";
            // 
            // lbl_Cantidad
            // 
            lbl_Cantidad.AutoSize = true;
            lbl_Cantidad.Location = new System.Drawing.Point(13, 124);
            lbl_Cantidad.Name = "lbl_Cantidad";
            lbl_Cantidad.Size = new System.Drawing.Size(49, 13);
            lbl_Cantidad.TabIndex = 27;
            lbl_Cantidad.Text = "Cantidad";
            // 
            // lbl_Unidad
            // 
            lbl_Unidad.AutoSize = true;
            lbl_Unidad.Location = new System.Drawing.Point(177, 124);
            lbl_Unidad.Name = "lbl_Unidad";
            lbl_Unidad.Size = new System.Drawing.Size(41, 13);
            lbl_Unidad.TabIndex = 28;
            lbl_Unidad.Text = "Unidad";
            // 
            // lbl_CantidadM
            // 
            lbl_CantidadM.AutoSize = true;
            lbl_CantidadM.Location = new System.Drawing.Point(305, 42);
            lbl_CantidadM.Name = "lbl_CantidadM";
            lbl_CantidadM.Size = new System.Drawing.Size(49, 13);
            lbl_CantidadM.TabIndex = 29;
            lbl_CantidadM.Text = "Cantidad";
            // 
            // lbl_UnidadM
            // 
            lbl_UnidadM.AutoSize = true;
            lbl_UnidadM.Location = new System.Drawing.Point(305, 77);
            lbl_UnidadM.Name = "lbl_UnidadM";
            lbl_UnidadM.Size = new System.Drawing.Size(41, 13);
            lbl_UnidadM.TabIndex = 30;
            lbl_UnidadM.Text = "Unidad";
            // 
            // Produccion
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(196)))));
            ClientSize = new System.Drawing.Size(900, 580);
            Controls.Add(groupBox_Producto);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox_Composicion);
            Controls.Add(pic_Logo);
            Icon = global::Sistema_Shajobe.Properties.Resources.produccion1;
            MaximumSize = new System.Drawing.Size(900, 580);
            MaximizeBox = false;
            MinimumSize = new System.Drawing.Size(900, 580);
            Name = "Produccion";
            Text = "Produccion";
            ((System.ComponentModel.ISupportInitialize)(dataGridView_Composicion)).EndInit();
            groupBox_Composicion.ResumeLayout(false);
            groupBox_Producto.ResumeLayout(false);
            groupBox_Producto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridView_Materiaprima)).EndInit();
            ResumeLayout(false);
        }
        #endregion
        private void Produccion_Load(object sender, EventArgs e)
        {
            #region Animacion
            AnimateWindow(Handle, 350, AnimateWindowFlags.AW_CENTER);
            AnimateWindow(Handle, 450, AnimateWindowFlags.AW_CENTER | AnimateWindowFlags.AW_SLIDE);
            ResumeLayout(false);
            PerformLayout();
            #endregion
            Diseño_Forma();
            //Llenando controles
            Llenando_ComboboxProducto();
            Llenando_ComboboxUnidadMedida();
            Llenando_DataGridViewMateriaprima();
            Llenando_ComboboxAlmacen();
        }
        //-------------------------------------------------------------
        //------------------VARIABLES Y ARREGLOS-----------------------
        //-------------------------------------------------------------
        private TextBox[] Campos = new TextBox[3];
        private ComboBox[] CamposC = new ComboBox[4];
        private int Idp;//LO USO PARA OBTENER EL ID COMO RESULTADO DE LA BUSQUEDA
        private decimal Existencia;
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
            coman.CommandText = "SELECT Tb_Inventarioproducto.Lote, Tb_Inventarioproducto.Id_Almacen, Tb_Inventarioproductodetalle.Id_Concepto, Tb_Producto.Id_Producto, Tb_Inventarioproductodetalle.Cantidad_Actual, Tb_Inventarioproductodetalle.Precio_Compra, Tb_Inventarioproductodetalle.Precio_Venta, Tb_Inventarioproductodetalle.Saldo_Articulos, Tb_Inventarioproductodetalle.Id_Unidadmedida, Tb_Inventarioproductodetalle.Fecha_Modificacion FROM Tb_Producto INNER JOIN Tb_Inventarioproductodetalle ON Tb_Producto.Id_Producto = Tb_Inventarioproductodetalle.Id_Producto INNER JOIN Tb_Inventarioproducto ON Tb_Inventarioproductodetalle.Id_Inventarioproducto = Tb_Inventarioproducto.Id_Inventarioproducto where Tb_Inventarioproducto.Id_Inventarioproducto='" + Idp + "'";
            coman.CommandType = CommandType.Text;
            con.Open();
            data_resultado.Rows.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                
                //Txt Lote
                txt_Lote.Text = dr.GetString(dr.GetOrdinal("Lote"));
                
                //Combobox producto
                int seleccion2 = dr.GetInt32(dr.GetOrdinal("Id_Producto"));
                seleccion2 = seleccion2 - 1;
                comboBox_Producto.SelectedIndex = seleccion2;
                //txt cantidad
                txt_Cantidad.Text = dr.GetDecimal(dr.GetOrdinal("Cantidad_Actual")).ToString("N");
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
                //coman.CommandText = "Select * from Tb_Producto  where (Nombre='" + busqueda.ToUpper() + "'OR Codigo_Barra='" + busqueda.ToUpper() + "') AND Activo='S'";
                coman.CommandText = "SELECT Tb_Inventarioproductodetalle.Id_Inventarioproducto,Tb_Producto.Cantidad, Tb_Producto.Nombre, Tb_Producto.Descripcion FROM Tb_Inventarioproducto INNER JOIN Tb_Inventarioproductodetalle ON Tb_Inventarioproducto.Id_Inventarioproducto = Tb_Inventarioproductodetalle.Id_Inventarioproducto INNER JOIN Tb_Producto ON Tb_Inventarioproductodetalle.Id_Producto = Tb_Producto.Id_Producto WHERE (Tb_Producto.Nombre='" + busqueda.ToUpper() + "') OR (Tb_Producto.Codigo_Barra = '" + busqueda.ToUpper() + "')";
                coman.CommandType = CommandType.Text;
                con.Open();
                data_resultado.Rows.Clear();
                dr = coman.ExecuteReader();
                while (dr.Read())
                {
                    int Renglon = data_resultado.Rows.Add();
                    Idp = dr.GetInt32(dr.GetOrdinal("Id_Inventarioproducto"));
                    data_resultado.Rows[Renglon].Cells["Idb"].Value = dr.GetInt32(dr.GetOrdinal("Id_Inventarioproducto"));
                    data_resultado.Rows[Renglon].Cells["Nombreb"].Value = dr.GetString(dr.GetOrdinal("Nombre"));
                    data_resultado.Rows[Renglon].Cells["Descripcionb"].Value = dr.GetString(dr.GetOrdinal("Descripcion"));
                    data_resultado.Rows[Renglon].Cells["Cantidadb"].Value = dr.GetDecimal(dr.GetOrdinal("Cantidad")).ToString("N");
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
            comboBox_UnidadM.Items.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Declarando Variables y obteniendo los valores correspondiente
                string Simbolo = dr.GetString(dr.GetOrdinal("Simbolo"));
                comboBox_Unidad.Items.Add(Simbolo);
                comboBox_UnidadM.Items.Add(Simbolo);
            }
            con.Close();
        }
        private void Llenando_DataGridViewMateriaprima()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "SELECT Tb_Almacen.Nombre, Tb_Inventariomateriaprimadetalle.Id_MateriaPrima, Tb_Inventariomateriaprimadetalle.Cantidad_Actual, Tb_MateriaPrima.Nombre AS Materia_prima, Tb_Tipomateriaprima.Nombre AS Tipo_Materiaprima, Tb_TipoPieza.Nombre AS Tipo_Pieza, Tb_Unidadmedida.Simbolo, Tb_MateriaPrima.Descripcion FROM Tb_Almacen INNER JOIN Tb_Inventariomateriaprima ON Tb_Almacen.Id_Almacen = Tb_Inventariomateriaprima.Id_Almacen INNER JOIN Tb_Inventariomateriaprimadetalle ON  Tb_Inventariomateriaprima.Id_Inventariomateriaprima = Tb_Inventariomateriaprimadetalle.Id_Inventariomateriaprima INNER JOIN Tb_MateriaPrima ON Tb_Inventariomateriaprimadetalle.Id_MateriaPrima = Tb_MateriaPrima.Id_MateriaPrima INNER JOIN Tb_Tipomateriaprima ON Tb_MateriaPrima.Id_Tipomateriaprima = Tb_Tipomateriaprima.Id_Tipomateriaprima INNER JOIN Tb_TipoPieza ON Tb_MateriaPrima.Id_TipoPieza = Tb_TipoPieza.Id_TipoPieza INNER JOIN Tb_Unidadmedida ON Tb_Inventariomateriaprimadetalle.Id_Unidadmedida = Tb_Unidadmedida.Id_Unidadmedida where (Tb_Inventariomateriaprimadetalle.Cantidad_Actual>0)";
            coman.CommandType = CommandType.Text;
            con.Open();
            dataGridView_Materiaprima.Rows.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Creando y obteniendo el indice para un nuevo renglon
                int Indice = dataGridView_Materiaprima.Rows.Add();
                dataGridView_Materiaprima.Rows[Indice].Cells["Id_Materia"].Value = dr.GetInt32(dr.GetOrdinal("Id_MateriaPrima"));
                dataGridView_Materiaprima.Rows[Indice].Cells["Materia_prima"].Value = dr.GetString(dr.GetOrdinal("Materia_prima"));
                dataGridView_Materiaprima.Rows[Indice].Cells["Tipo_Pieza"].Value = dr.GetString(dr.GetOrdinal("Tipo_Pieza"));
                dataGridView_Materiaprima.Rows[Indice].Cells["Tipo_Materiaprima"].Value = dr.GetString(dr.GetOrdinal("Tipo_Materiaprima"));
                dataGridView_Materiaprima.Rows[Indice].Cells["Descripcion"].Value = dr.GetString(dr.GetOrdinal("Descripcion"));
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
                //Primer procedimiento
                OleDbConnection conexion = null;
                OleDbTransaction transaccion = null;
                //Segundo procedimiento
                OleDbConnection conexion1 = null;
                OleDbTransaction transaccion1 = null;
                try
                {
                    //Id Ultimo registro de Id de produccion variable de salida
                    OleDbParameter UltimoRegistro = new OleDbParameter("@Id_Registro",OleDbType.Integer);
                    UltimoRegistro.Direction = ParameterDirection.Output;
                    conexion = new OleDbConnection(ObtenerString());
                    conexion.Open();
                    transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                    OleDbCommand comando = new OleDbCommand("SP_Produccion_Alta", conexion, transaccion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@Id_Producto", comboBox_Producto.SelectedIndex + 1);
                    comando.Parameters.AddWithValue("@Id_Unidadmedida", comboBox_Unidad.SelectedIndex + 1);
                    comando.Parameters.AddWithValue("@Id_Almacen", comboBox_Almacen.SelectedIndex + 1);
                    comando.Parameters.AddWithValue("@Lote", txt_Lote.Text);
                    comando.Parameters.AddWithValue("@Cantidad", Convert.ToDecimal(txt_Cantidad.Text));
                    comando.Parameters.AddWithValue("@Fecha", dateTimePicker_Fecha.Value);
                    comando.Parameters.Add(UltimoRegistro);//ENTRADA Y SALIDA DEL FLUJO DE SALIDA DEL ULTIMO REGISTRO
                    comando.ExecuteNonQuery();
                    transaccion.Commit();
                    conexion.Close();
                    Idp = Convert.ToInt32(UltimoRegistro.Value);//RECIBO LA VARIABLE DE SALIDA
                    #region GUARDAR MATERIA PRIMA A PROCESAR
                        try
                        {
                            for (int Lista = 0; Lista < dataGridView_Composicion.RowCount-1; Lista++)
                            {
                                conexion1 = new OleDbConnection(ObtenerString());
                                conexion1.Open();
                                transaccion1 = conexion1.BeginTransaction(System.Data.IsolationLevel.Serializable);
                                OleDbCommand comando1 = new OleDbCommand("SP_Produccion_Detalle_Alta", conexion1, transaccion1);
                                comando1.CommandType = CommandType.StoredProcedure;
                                comando1.Parameters.Clear();
                                comando1.Parameters.AddWithValue("@Id_Produccion", Idp);
                                comando1.Parameters.AddWithValue("@Id_MateriaPrima", dataGridView_Composicion.Rows[Lista].Cells["Id_Materiaprima"].Value);
                                comando1.Parameters.AddWithValue("@Id_Unidadmedida", dataGridView_Composicion.Rows[Lista].Cells["Id_Unidad"].Value);
                                comando1.Parameters.AddWithValue("@Cantidad", Convert.ToDecimal(dataGridView_Composicion.Rows[Lista].Cells["Cantidad"].Value));
                                comando1.ExecuteNonQuery();
                                transaccion1.Commit();
                                conexion1.Close();
                            }
                        }
                        catch (Exception)
                        {
                            transaccion1.Rollback();
                        }
                        finally
                        {

                        }
                    //}
                    #endregion
                }
                catch (Exception)
                {
                    transaccion1.Rollback();
                    transaccion.Rollback();
                    MessageBox.Show("Ha ocurrido un error inesperado", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    //conexion.Close();
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
                OleDbConnection con = null;
                OleDbTransaction tran = null;
                try
                {
                    con = new OleDbConnection(ObtenerString());
                    con.Open();
                    tran = con.BeginTransaction(System.Data.IsolationLevel.Serializable);
                    OleDbCommand comando = new OleDbCommand("SP_Produccion_Cambios", con, tran);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@Id_Produccion", Idp);
                    comando.Parameters.AddWithValue("@Id_Producto", comboBox_Producto.SelectedIndex + 1);
                    comando.Parameters.AddWithValue("@Id_Unidadmedida", comboBox_Unidad.SelectedIndex + 1);
                    comando.Parameters.AddWithValue("@Id_Almacen", comboBox_Almacen.SelectedIndex + 1);
                    comando.Parameters.AddWithValue("@Lote", txt_Lote.Text);
                    comando.Parameters.AddWithValue("@Cantidad", Convert.ToDecimal(txt_Cantidad.Text));
                    comando.Parameters.AddWithValue("@Fecha", dateTimePicker_Fecha.Value);
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
                OleDbCommand comando = new OleDbCommand("SP_Produccion_Baja", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Id_Produccion", Idp);
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
                MessageBox.Show("Datos Modificados con éxito", "Solicitud procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
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
            txt_Lote.Clear();
            comboBox_Producto.ResetText();
            txt_Cantidad.Clear();
            txt_CantidadM.Clear();
            comboBox_Unidad.ResetText();
            comboBox_UnidadM.ResetText();
            comboBox_Almacen.ResetText();
            comboBox_Producto.ResetText();
            dateTimePicker_Fecha.ResetText();
            Llenando_DataGridViewMateriaprima();
            dataGridView_Composicion.Rows.Clear();
            errorProvider_Combobox.Clear();
            errorProvider_Textbox.Clear();
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
            //Actualizando la lista de Materia prima
            Llenando_DataGridViewMateriaprima();
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
        private DataGridViewTextBoxColumn Nombreb;
        private DataGridViewTextBoxColumn Idb;
        private DataGridViewTextBoxColumn Cantidadb;
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
            Nombreb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Idb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cantidadb = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            Nombreb,
            Descripcionb, Cantidadb});
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
            Cantidadb.HeaderText = "Cantidad";
            Cantidadb.Name = "Cantidadb";
            //
            // Descripcion
            // 
            Descripcionb.HeaderText = "Descripcion";
            Descripcionb.Name = "Descripcionb";
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
            lbl_Etiqueta.Text = "Escriba el nombre 'o codigo de barra \n del producto a buscar";
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
        #region Funcion de Agregar y Quitar
        private void bttn_Agregar_Click(object sender, EventArgs e)
        {
            errorProvider_Combobox.Clear();
            errorProvider_Textbox.Clear();
            if (dataGridView_Materiaprima.CurrentRow == null)
            {
                MessageBox.Show("Seleccione la materia prima", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (txt_CantidadM.Text.Trim() == "")
                {
                    MessageBox.Show("Introduzca la cantidad de materia prima que se va a emplear", "Error con la cantidad de materia prima introducida", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    errorProvider_Textbox.SetError(txt_CantidadM, "Introduce la cantidad solicitada");
                }
                else if (comboBox_UnidadM.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione una unidad de medida", "Error con el la unidad de medida", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    errorProvider_Combobox.SetError(comboBox_UnidadM, "Seleccione una unidad de medida");
                }
                else
                {
                    #region Obteniendo_Existencia
                    int SMateriaprima = Convert.ToInt32(dataGridView_Materiaprima.CurrentRow.Cells["Id_Materia"].Value);
                    //Opteniendo Informacion de productos disponibles
                    OleDbConnection con = new OleDbConnection();
                    OleDbCommand coman = new OleDbCommand();
                    OleDbDataReader dr;
                    con.ConnectionString = ObtenerString();
                    coman.Connection = con;
                    coman.CommandText = "SELECT SUM(Cantidad_Actual)As Existencia FROM Tb_Inventariomateriaprimadetalle WHERE (Id_MateriaPrima = '" + SMateriaprima + "')";
                    coman.CommandType = CommandType.Text;
                    con.Open();
                    dr = coman.ExecuteReader();
                    while (dr.Read())
                    {
                        //Declarando Variables y obteniendo los valores correspondiente
                        Existencia = dr.GetDecimal(dr.GetOrdinal("Existencia"));
                    }
                    con.Close();
                    #endregion
                    #region Agregar_Carrito
                    if (Convert.ToDecimal(txt_CantidadM.Text) < Existencia)
                    {
                        int Lista = dataGridView_Composicion.Rows.Add();
                        dataGridView_Composicion.Rows[Lista].Cells["Id_Materiaprima"].Value = Convert.ToInt32(dataGridView_Materiaprima.CurrentRow.Cells["Id_Materia"].Value);
                        //Concatenar el nombre de materia prima con el tipo de pieza
                        string Nombre = Convert.ToString(dataGridView_Materiaprima.CurrentRow.Cells["Materia_prima"].Value);
                        string Tipo = Convert.ToString(dataGridView_Materiaprima.CurrentRow.Cells["Tipo_Pieza"].Value);
                        string NCompleto = Nombre +" " +Tipo;
                        dataGridView_Composicion.Rows[Lista].Cells["Materiaprima"].Value = NCompleto;
                        dataGridView_Composicion.Rows[Lista].Cells["Cantidad"].Value = txt_CantidadM.Text;
                        dataGridView_Composicion.Rows[Lista].Cells["Unidad"].Value = comboBox_UnidadM.SelectedItem;
                        dataGridView_Composicion.Rows[Lista].Cells["Id_Unidad"].Value = comboBox_UnidadM.SelectedIndex+1;
                        //Metodo para sumar el subtotal
                        //Suma_Subtotal(Convert.ToInt32(txt_Cantidad.Text), Convert.ToDecimal(dataGridView_Materiaprima.CurrentRow.Cells["Precio_VentaP"].Value));
                    }
                    else
                    {
                        MessageBox.Show("No se cuenta con la cantidad solicitada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    #endregion
                }
            }
        }
        private void bttn_Quitar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseas realmente quitar este producto del carrito", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                //Resta_Subtotal(Convert.ToInt32(dataGridView_Composicion.CurrentRow.Cells["Cantidad"].Value), Convert.ToDecimal(dataGridView_Composicion.CurrentRow.Cells["Precio"].Value));
                dataGridView_Composicion.Rows.RemoveAt(dataGridView_Composicion.CurrentRow.Index);
            }
        }
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
            Campos[2] = txt_CantidadM;
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
                    errorProvider_Textbox.SetError(txt_CantidadM, "No puedes dejar el campo vacio");
                    break;
                default:
                    break;
            }
        }
        #endregion
        #region Verificar campos no seleccionados
        private bool Verificar_CamposNoSeleccionados()
        {
            //Se introduce los textbox en un arreglo con el fin de identificar espacios vacios
            CamposC[0] = comboBox_Producto;
            CamposC[1] = comboBox_Unidad;
            CamposC[2] = comboBox_Almacen;
            CamposC[3] = comboBox_UnidadM;
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
                    errorProvider_Combobox.SetError(comboBox_Producto, "No puedes dejar el campo vacio");
                    break;
                case 1:
                    errorProvider_Combobox.SetError(comboBox_Unidad, "No puedes dejar el campo vacio");
                    break;
                case 2:
                    errorProvider_Combobox.SetError(comboBox_Almacen, "No puedes dejar el campo vacio");
                    break;
                case 3:
                    errorProvider_Combobox.SetError(comboBox_UnidadM, "No puedes dejar el campo vacio");
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
            string consulta = "SELECT Tb_Producto.Nombre, Tb_Producto.Descripcion, Tb_Producto.Codigo_Barra, Tb_Inventarioproductodetalle.Id_Producto FROM Tb_Inventarioproducto INNER JOIN Tb_Inventarioproductodetalle ON Tb_Inventarioproducto.Id_Inventarioproducto = Tb_Inventarioproductodetalle.Id_Inventarioproducto INNER JOIN Tb_Producto ON Tb_Inventarioproductodetalle.Id_Producto = Tb_Producto.Id_Producto"; //consulta a la tabla Tipos de piezas
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
                coleccion.Add(Convert.ToString(row["Codigo_Barra"]));
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
        private void txt_Numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de numeros-------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47))
            {
                MessageBox.Show("Solo se aceptan numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        #endregion
        //-------------------------------------------------------------
        //-----------------NO ESCRITURA EN LOS COMBOBOX----------------
        //-------------------------------------------------------------
        private void NoescrituracomboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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
