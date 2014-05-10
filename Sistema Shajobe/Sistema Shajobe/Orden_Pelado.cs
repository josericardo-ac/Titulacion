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
    public partial class Orden_Pelado : Form
    {
        public Orden_Pelado()
        {
            InitializeComponent();
        }
        #region Diseño de la forma
        #region Declarando controles de la forma
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
        private System.Windows.Forms.GroupBox groupBox_DatosPelado;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Fecha;
        private System.Windows.Forms.Label lbl_Unidad;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label lbl_Precioventa;
        private System.Windows.Forms.Label lbl_Preciocompra;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.Label lbl_Id_Tipopieza;
        private System.Windows.Forms.Label lbl_IdMateriaprima;
        private System.Windows.Forms.Label lbl_Lote;
        private System.Windows.Forms.Label lbl_Almacen;
        private System.Windows.Forms.TextBox txt_Precioventa;
        private System.Windows.Forms.TextBox txt_Preciocompra;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.TextBox txt_Lote;
        private System.Windows.Forms.ComboBox comboBox_Unidad;
        private System.Windows.Forms.ComboBox comboBox_Tipopieza;
        private System.Windows.Forms.ComboBox comboBox_Materiaprima;
        private System.Windows.Forms.ComboBox comboBox_Almacen;
        private System.Windows.Forms.GroupBox groupBox_Historial;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia_Prima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Pieza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        #endregion
        private void Diseño_Forma()
        {
            #region Creando controles de la forma
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orden_Pelado));
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
            groupBox_DatosPelado = new System.Windows.Forms.GroupBox();
            groupBox_Historial = new System.Windows.Forms.GroupBox();
            comboBox_Almacen = new System.Windows.Forms.ComboBox();
            comboBox_Materiaprima = new System.Windows.Forms.ComboBox();
            comboBox_Tipopieza = new System.Windows.Forms.ComboBox();
            comboBox_Unidad = new System.Windows.Forms.ComboBox();
            txt_Lote = new System.Windows.Forms.TextBox();
            txt_Cantidad = new System.Windows.Forms.TextBox();
            txt_Preciocompra = new System.Windows.Forms.TextBox();
            txt_Precioventa = new System.Windows.Forms.TextBox();
            lbl_Almacen = new System.Windows.Forms.Label();
            lbl_Lote = new System.Windows.Forms.Label();
            lbl_IdMateriaprima = new System.Windows.Forms.Label();
            lbl_Id_Tipopieza = new System.Windows.Forms.Label();
            lbl_Cantidad = new System.Windows.Forms.Label();
            lbl_Preciocompra = new System.Windows.Forms.Label();
            lbl_Precioventa = new System.Windows.Forms.Label();
            lbl_Fecha = new System.Windows.Forms.Label();
            lbl_Unidad = new System.Windows.Forms.Label();
            dateTimePicker_Fecha = new System.Windows.Forms.DateTimePicker();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Materia_Prima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Tipo_Pieza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            errorProvider_Textbox = new System.Windows.Forms.ErrorProvider(components);
            errorProvider_Combobox = new System.Windows.Forms.ErrorProvider(components);
            groupBox_DatosPelado.SuspendLayout();
            groupBox_Historial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).BeginInit();
            SuspendLayout();
            #endregion
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(186)))), ((int)(((byte)(82)))));
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            archivoToolStripMenuItem,
            editarToolStripMenuItem,
            ayudaToolStripMenuItem});
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(594, 24);
            menuStrip1.TabIndex = 3;
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
            nuevoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            // errorProvider_Textbox
            // 
            errorProvider_Textbox.ContainerControl = this;
            // 
            // errorProvider_Combobox
            // 
            errorProvider_Combobox.ContainerControl = this;
            // 
            // groupBox_DatosPelado
            // 
            groupBox_DatosPelado.Controls.Add(dateTimePicker_Fecha);
            groupBox_DatosPelado.Controls.Add(lbl_Unidad);
            groupBox_DatosPelado.Controls.Add(lbl_Fecha);
            groupBox_DatosPelado.Controls.Add(lbl_Precioventa);
            groupBox_DatosPelado.Controls.Add(lbl_Preciocompra);
            groupBox_DatosPelado.Controls.Add(lbl_Cantidad);
            groupBox_DatosPelado.Controls.Add(lbl_Id_Tipopieza);
            groupBox_DatosPelado.Controls.Add(lbl_IdMateriaprima);
            groupBox_DatosPelado.Controls.Add(lbl_Lote);
            groupBox_DatosPelado.Controls.Add(lbl_Almacen);
            groupBox_DatosPelado.Controls.Add(txt_Precioventa);
            groupBox_DatosPelado.Controls.Add(txt_Preciocompra);
            groupBox_DatosPelado.Controls.Add(txt_Cantidad);
            groupBox_DatosPelado.Controls.Add(txt_Lote);
            groupBox_DatosPelado.Controls.Add(comboBox_Unidad);
            groupBox_DatosPelado.Controls.Add(comboBox_Tipopieza);
            groupBox_DatosPelado.Controls.Add(comboBox_Materiaprima);
            groupBox_DatosPelado.Controls.Add(comboBox_Almacen);
            groupBox_DatosPelado.Location = new System.Drawing.Point(6, 28);
            groupBox_DatosPelado.Name = "groupBox_DatosPelado";
            groupBox_DatosPelado.Size = new System.Drawing.Size(314, 293);
            groupBox_DatosPelado.TabIndex = 0;
            groupBox_DatosPelado.TabStop = false;
            groupBox_DatosPelado.Text = "Datos de orden de pelado";
            // 
            // groupBox_Historial
            // 
            groupBox_Historial.Controls.Add(dataGridView1);
            groupBox_Historial.Location = new System.Drawing.Point(326, 28);
            groupBox_Historial.Name = "groupBox_Historial";
            groupBox_Historial.Size = new System.Drawing.Size(573, 476);
            groupBox_Historial.TabIndex = 0;
            groupBox_Historial.TabStop = false;
            groupBox_Historial.Text = "Historial de orden de pelado";
            // 
            // comboBox_Almacen
            // 
            comboBox_Almacen.FormattingEnabled = true;
            comboBox_Almacen.Location = new System.Drawing.Point(101, 34);
            comboBox_Almacen.Name = "comboBox_Almacen";
            comboBox_Almacen.Size = new System.Drawing.Size(121, 21);
            comboBox_Almacen.KeyPress += new KeyPressEventHandler(NoescrituracomboBox_KeyPress);
            comboBox_Almacen.TabIndex = 0;
            // 
            // comboBox_Materiaprima
            // 
            comboBox_Materiaprima.FormattingEnabled = true;
            comboBox_Materiaprima.Location = new System.Drawing.Point(101, 97);
            comboBox_Materiaprima.Name = "comboBox_Materiaprima";
            comboBox_Materiaprima.Size = new System.Drawing.Size(191, 21);
            comboBox_Materiaprima.KeyPress += new KeyPressEventHandler(NoescrituracomboBox_KeyPress);
            comboBox_Materiaprima.TabIndex = 1;
            // 
            // comboBox_Tipopieza
            // 
            comboBox_Tipopieza.FormattingEnabled = true;
            comboBox_Tipopieza.Location = new System.Drawing.Point(101, 129);
            comboBox_Tipopieza.Name = "comboBox_Tipopieza";
            comboBox_Tipopieza.Size = new System.Drawing.Size(121, 21);
            comboBox_Tipopieza.KeyPress += new KeyPressEventHandler(NoescrituracomboBox_KeyPress);
            comboBox_Tipopieza.TabIndex = 2;
            // 
            // comboBox_Unidad
            // 
            comboBox_Unidad.FormattingEnabled = true;
            comboBox_Unidad.Location = new System.Drawing.Point(207, 161);
            comboBox_Unidad.Name = "comboBox_Unidad";
            comboBox_Unidad.Size = new System.Drawing.Size(79, 21);
            comboBox_Unidad.KeyPress += new KeyPressEventHandler(NoescrituracomboBox_KeyPress);
            comboBox_Unidad.TabIndex = 3;
            // 
            // txt_Lote
            // 
            txt_Lote.Location = new System.Drawing.Point(101, 66);
            txt_Lote.Name = "txt_Lote";
            txt_Lote.Size = new System.Drawing.Size(100, 20);
            txt_Lote.KeyPress += new KeyPressEventHandler(txt_MinMax_KeyPress);
            txt_Lote.MaxLength = 10;
            txt_Lote.TabIndex = 4;
            // 
            // txt_Cantidad
            // 
            txt_Cantidad.Location = new System.Drawing.Point(101, 161);
            txt_Cantidad.Name = "txt_Cantidad";
            txt_Cantidad.Size = new System.Drawing.Size(100, 20);
            txt_Cantidad.KeyPress += new KeyPressEventHandler(txt_MinMax_KeyPress);
            txt_Cantidad.MaxLength = 9;
            txt_Cantidad.TabIndex = 5;
            // 
            // txt_Preciocompra
            // 
            txt_Preciocompra.Location = new System.Drawing.Point(101, 192);
            txt_Preciocompra.Name = "txt_Preciocompra";
            txt_Preciocompra.Size = new System.Drawing.Size(100, 20);
            txt_Preciocompra.KeyPress += new KeyPressEventHandler(txt_MinMax_KeyPress);
            txt_Preciocompra.MaxLength = 9;
            txt_Preciocompra.TabIndex = 6;
            // 
            // txt_Precioventa
            // 
            txt_Precioventa.Location = new System.Drawing.Point(101, 223);
            txt_Precioventa.Name = "txt_Precioventa";
            txt_Precioventa.Size = new System.Drawing.Size(100, 20);
            txt_Precioventa.KeyPress += new KeyPressEventHandler(txt_MinMax_KeyPress);
            txt_Precioventa.MaxLength = 9;
            txt_Precioventa.TabIndex = 7;
            // 
            // lbl_Almacen
            // 
            lbl_Almacen.AutoSize = true;
            lbl_Almacen.Location = new System.Drawing.Point(20, 42);
            lbl_Almacen.Name = "lbl_Almacen";
            lbl_Almacen.Size = new System.Drawing.Size(48, 13);
            lbl_Almacen.TabIndex = 9;
            lbl_Almacen.Text = "Almacén";
            // 
            // lbl_Lote
            // 
            lbl_Lote.AutoSize = true;
            lbl_Lote.Location = new System.Drawing.Point(20, 73);
            lbl_Lote.Name = "lbl_Lote";
            lbl_Lote.Size = new System.Drawing.Size(28, 13);
            lbl_Lote.TabIndex = 10;
            lbl_Lote.Text = "Lote";
            // 
            // lbl_IdMateriaprima
            // 
            lbl_IdMateriaprima.AutoSize = true;
            lbl_IdMateriaprima.Location = new System.Drawing.Point(20, 105);
            lbl_IdMateriaprima.Name = "lbl_IdMateriaprima";
            lbl_IdMateriaprima.Size = new System.Drawing.Size(70, 13);
            lbl_IdMateriaprima.TabIndex = 11;
            lbl_IdMateriaprima.Text = "Materia prima";
            // 
            // lbl_Id_Tipopieza
            // 
            lbl_Id_Tipopieza.AutoSize = true;
            lbl_Id_Tipopieza.Location = new System.Drawing.Point(20, 137);
            lbl_Id_Tipopieza.Name = "lbl_Id_Tipopieza";
            lbl_Id_Tipopieza.Size = new System.Drawing.Size(71, 13);
            lbl_Id_Tipopieza.TabIndex = 12;
            lbl_Id_Tipopieza.Text = "Tipo de pieza";
            // 
            // lbl_Cantidad
            // 
            lbl_Cantidad.AutoSize = true;
            lbl_Cantidad.Location = new System.Drawing.Point(20, 169);
            lbl_Cantidad.Name = "lbl_Cantidad";
            lbl_Cantidad.Size = new System.Drawing.Size(49, 13);
            lbl_Cantidad.TabIndex = 13;
            lbl_Cantidad.Text = "Cantidad";
            // 
            // lbl_Preciocompra
            // 
            lbl_Preciocompra.AutoSize = true;
            lbl_Preciocompra.Location = new System.Drawing.Point(20, 199);
            lbl_Preciocompra.Name = "lbl_Preciocompra";
            lbl_Preciocompra.Size = new System.Drawing.Size(75, 13);
            lbl_Preciocompra.TabIndex = 14;
            lbl_Preciocompra.Text = "Precio compra";
            // 
            // lbl_Precioventa
            // 
            lbl_Precioventa.AutoSize = true;
            lbl_Precioventa.Location = new System.Drawing.Point(20, 230);
            lbl_Precioventa.Name = "lbl_Precioventa";
            lbl_Precioventa.Size = new System.Drawing.Size(67, 13);
            lbl_Precioventa.TabIndex = 15;
            lbl_Precioventa.Text = "Precio venta";
            // 
            // lbl_Fecha
            // 
            lbl_Fecha.AutoSize = true;
            lbl_Fecha.Location = new System.Drawing.Point(20, 261);
            lbl_Fecha.Name = "lbl_Fecha";
            lbl_Fecha.Size = new System.Drawing.Size(37, 13);
            lbl_Fecha.TabIndex = 16;
            lbl_Fecha.Text = "Fecha";
            // 
            // lbl_Unidad
            // 
            lbl_Unidad.AutoSize = true;
            lbl_Unidad.Location = new System.Drawing.Point(245, 145);
            lbl_Unidad.Name = "lbl_Unidad";
            lbl_Unidad.Size = new System.Drawing.Size(41, 13);
            lbl_Unidad.TabIndex = 17;
            lbl_Unidad.Text = "Unidad";
            // 
            // dateTimePicker_Fecha
            // 
            dateTimePicker_Fecha.Location = new System.Drawing.Point(101, 254);
            dateTimePicker_Fecha.Name = "dateTimePicker_Fecha";
            dateTimePicker_Fecha.Size = new System.Drawing.Size(200, 20);
            dateTimePicker_Fecha.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Id,
            Materia_Prima,
            Tipo_Pieza,
            Cantidad,
            Unidad,
            Fecha});
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(3, 16);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(567, 457);
            dataGridView1.TabIndex = 19;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // Materia_Prima
            // 
            Materia_Prima.HeaderText = "Materia prima";
            Materia_Prima.Name = "Materia_Prima";
            // 
            // Tipo_Pieza
            // 
            Tipo_Pieza.HeaderText = "Tipo de pieza";
            Tipo_Pieza.Name = "Tipo_Pieza";
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
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            // 
            // Orden_de_pelado
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(196)))));
            ClientSize = new System.Drawing.Size(906, 508);
            Controls.Add(groupBox_Historial);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox_DatosPelado);
            MaximumSize = new System.Drawing.Size(922, 546);
            MinimumSize = new System.Drawing.Size(922, 546);
            MaximizeBox = false;
            Name = "Orden_de_pelado";
            Text = "Orden de pelado";
            groupBox_DatosPelado.ResumeLayout(false);
            groupBox_DatosPelado.PerformLayout();
            groupBox_Historial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(errorProvider_Textbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(errorProvider_Combobox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).EndInit();
            ResumeLayout(false);
        }
        #endregion
        private void Orden_Pelado_Load(object sender, EventArgs e)
        {
            #region Animacion
            AnimateWindow(Handle, 350, AnimateWindowFlags.AW_CENTER);
            AnimateWindow(Handle, 450, AnimateWindowFlags.AW_CENTER | AnimateWindowFlags.AW_SLIDE);
            ResumeLayout(false);
            PerformLayout();
            #endregion
            Diseño_Forma();
            #region Llenado de controles del sistema
            Llenando_ComboboxTipo();
            Llenando_ComboboxMateria();
            Llenando_ComboboxUnidad();
            Llenando_ComboboxAlmacen();
            #endregion
        }
        #region Eventos
        //-------------------------------------------------------------
        //------------------Variables y Arreglos-----------------------
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
        private void data_resultado_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Idp = Convert.ToInt32(data_resultado.CurrentRow.Cells["Id"].Value);
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
            coman.CommandText = "SELECT Tb_MateriaPrima.Id_TipoPieza, Tb_MateriaPrima.Id_Tipomateriaprima, Tb_MateriaPrima.Nombre, Tb_MateriaPrima.Descripcion, Tb_Nivelmateriaprima.Id_Unidadmedida, Tb_Nivelmateriaprima.N_Max, Tb_Nivelmateriaprima.N_Min FROM Tb_MateriaPrima INNER JOIN Tb_Nivelmateriaprima ON Tb_MateriaPrima.Id_MateriaPrima = Tb_Nivelmateriaprima.Id_MateriaPrima WHERE (Tb_MateriaPrima.Activo = 'S' and Tb_MateriaPrima.Id_MateriaPrima='" + Idp + "')";
            coman.CommandType = CommandType.Text;
            con.Open();
            data_resultado.Rows.Clear();
            //comboBox_TipoPieza.ResetText();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //txt_Nombre.Text = dr.GetString(dr.GetOrdinal("Nombre"));
                //txt_Descripcion.Text = dr.GetString(dr.GetOrdinal("Descripcion"));
                int seleccion = dr.GetInt32(dr.GetOrdinal("Id_TipoPieza"));
                seleccion = seleccion - 1;
                //comboBox_TipoPieza.SelectedIndex = seleccion;
                int seleccion2 = dr.GetInt32(dr.GetOrdinal("Id_Tipomateriaprima"));
                seleccion2 = seleccion2 - 1;
                //comboBox_TipoMateriaprima.SelectedIndex = seleccion2;
                //txt_NMax.Text = dr.GetDecimal(dr.GetOrdinal("N_Max")).ToString("N");
                //txt_NMin.Text = dr.GetDecimal(dr.GetOrdinal("N_Min")).ToString("N");
                int seleccion3 = dr.GetInt32(dr.GetOrdinal("Id_Unidadmedida"));
                seleccion3 = seleccion3 - 1;
                comboBox_Unidad.SelectedIndex = seleccion3;
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
                coman.CommandText = "SELECT Tb_MateriaPrima.Id_MateriaPrima, Tb_MateriaPrima.Nombre AS Nombre_MateriaPrima, Tb_MateriaPrima.Descripcion, Tb_TipoPieza.Nombre AS Nombre_TipoPieza FROM Tb_MateriaPrima INNER JOIN Tb_TipoPieza ON Tb_MateriaPrima.Id_TipoPieza = Tb_TipoPieza.Id_TipoPieza where Tb_MateriaPrima.Nombre='" + busqueda.ToUpper() + "'AND Tb_MateriaPrima.Activo='S'";
                coman.CommandType = CommandType.Text;
                con.Open();
                data_resultado.Rows.Clear();
                dr = coman.ExecuteReader();
                while (dr.Read())
                {
                    int Renglon = data_resultado.Rows.Add();
                    Idp = dr.GetInt32(dr.GetOrdinal("Id_MateriaPrima"));
                    data_resultado.Rows[Renglon].Cells["Id"].Value = dr.GetInt32(dr.GetOrdinal("Id_MateriaPrima"));
                    //CRENADO UNA CONCATENACION DEL NOMBRE CON EL TIPO DE LA MATERIA PRIMA
                    string Tipo = dr.GetString(dr.GetOrdinal("Nombre_TipoPieza"));
                    string Nombre = dr.GetString(dr.GetOrdinal("Nombre_MateriaPrima"));
                    string nombretipo = Nombre + " " + Tipo;
                    data_resultado.Rows[Renglon].Cells["Nombre"].Value = nombretipo;
                    data_resultado.Rows[Renglon].Cells["Descripcion"].Value = dr.GetString(dr.GetOrdinal("Descripcion"));
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
        //----------------CONFIGURACION DE CONTROLES-------------------
        //-------------------------------------------------------------
        #region Funciones A, B y C
        #region Guardar
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool i = Verificar_CamposVacios();
            bool ic = Verificar_CamposNoSeleccionados();
            if (i == true && ic == true)
                MessageBox.Show("Inserta todos los datos marcados", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                OleDbConnection conexion = null;
                OleDbTransaction transaccion = null;
                try
                {
                    conexion = new OleDbConnection(ObtenerString());
                    conexion.Open();
                    transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                    OleDbCommand comando = new OleDbCommand("SP_MateriaPrima_Alta", conexion, transaccion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    //comando.Parameters.AddWithValue("@Id_TipoPieza", comboBox_TipoPieza.SelectedIndex + 1);
                    //comando.Parameters.AddWithValue("@Id_Tipomateriaprima", comboBox_TipoMateriaprima.SelectedIndex + 1);
                    //comando.Parameters.AddWithValue("@Nombre", txt_Nombre.Text);
                    //comando.Parameters.AddWithValue("@Descripcion", txt_Descripcion.Text);
                    comando.Parameters.AddWithValue("@Id_Unidadmedida", comboBox_Unidad.SelectedIndex + 1);
                    //comando.Parameters.AddWithValue("@N_Max", Convert.ToDecimal(txt_NMax.Text));
                    //comando.Parameters.AddWithValue("@N_Min", Convert.ToDecimal(txt_NMin.Text));
                    comando.ExecuteNonQuery();
                    transaccion.Commit();
                    MessageBox.Show("Datos guardados con éxito", "Solicitud procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    OleDbCommand comando = new OleDbCommand("SP_MateriaPrima_Cambios", con, tran);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@Id_MateriaPrima", Idp);
                    //comando.Parameters.AddWithValue("@Id_TipoPieza", comboBox_TipoPieza.SelectedIndex + 1);
                    //comando.Parameters.AddWithValue("@Id_Tipomateriaprima", comboBox_TipoMateriaprima.SelectedIndex + 1);
                    //comando.Parameters.AddWithValue("@Nombre", txt_Nombre.Text);
                    //comando.Parameters.AddWithValue("@Descripcion", txt_Descripcion.Text);
                    //comando.Parameters.AddWithValue("@Id_Unidadmedida", comboBox_Unidad.SelectedIndex + 1);
                    //comando.Parameters.AddWithValue("@N_Max", Convert.ToDecimal(txt_NMax.Text));
                    //comando.Parameters.AddWithValue("@N_Min", Convert.ToDecimal(txt_NMin.Text));
                    comando.ExecuteNonQuery();
                    tran.Commit();
                    con.Close();
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
                OleDbCommand comando = new OleDbCommand("SP_MateriaPrima_Bajas", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Id_MateriaPrima", Idp);
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
        #region Nuevo
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            //txt_Nombre.Clear();
            //txt_Descripcion.Clear();
            //txt_NMax.Clear();
            //txt_NMin.Clear();
            //groupBoxdatos.Visible = true;
            //comboBox_TipoPieza.ResetText();
            //comboBox_TipoMateriaprima.ResetText();
            comboBox_Unidad.ResetText();
            modificarToolStripMenuItem.Enabled = false;
            eliminarToolStripMenuItem.Enabled = false;
            errorProvider_Textbox.Clear();
            try
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
        //Declarando controles
        private DataGridView data_resultado;
        private TextBox txt_Busqueda;
        private PictureBox pic_Lupa;
        private Button bttn_Busqueda;
        private Panel panel_Busqueda;
        private Label lbl_Etiqueta;
        //Declarando Columnas del DATAGRID
        private DataGridViewTextBoxColumn Descripcionb;
        private DataGridViewTextBoxColumn Nombreb;
        private DataGridViewTextBoxColumn Idb;
        #endregion
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //INICIALIZANDO CONTROLES
            panel_Busqueda = new System.Windows.Forms.Panel();
            txt_Busqueda = new System.Windows.Forms.TextBox();
            data_resultado = new System.Windows.Forms.DataGridView();
            pic_Lupa = new System.Windows.Forms.PictureBox();
            bttn_Busqueda = new System.Windows.Forms.Button();
            lbl_Etiqueta = new System.Windows.Forms.Label();
            //groupBoxNivel.SuspendLayout();
            //INICIALIZANDO COLUMNAS
            Descripcionb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombreb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Idb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            //DISEÑOS DE A LOS CONTROLES
            txt_Busqueda.Location = new System.Drawing.Point(130, 57);
            txt_Busqueda.Name = "txt_Busqueda";
            txt_Busqueda.Size = new System.Drawing.Size(124, 20);
            txt_Busqueda.TabIndex = 0;
            txt_Busqueda.MaxLength = 25;
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
            Descripcionb});
            data_resultado.Location = new System.Drawing.Point(21, 136);
            data_resultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            data_resultado.Name = "data_resultado";
            data_resultado.RowHeadersWidth = 25;
            data_resultado.RowTemplate.Height = 50;
            data_resultado.Size = new System.Drawing.Size(470, 150);
            data_resultado.TabIndex = 2;
            data_resultado.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(data_resultado_MouseDoubleClick);
            //
            // Descripcionb
            // 
            Descripcionb.HeaderText = "Descripcion";
            Descripcionb.Name = "Descripcion";
            // 
            // Nombreb
            // 
            Nombreb.HeaderText = "Nombre";
            Nombreb.Name = "Nombre";
            // 
            // Idb
            // 
            Idb.HeaderText = "Id";
            Idb.Name = "Id";
            Idb.Visible = false;
            // 
            // lbl_Etiqueta
            // 
            lbl_Etiqueta.AutoSize = true;
            lbl_Etiqueta.Location = new System.Drawing.Point(127, 26);
            lbl_Etiqueta.Name = "lbl_Etiqueta";
            lbl_Etiqueta.Size = new System.Drawing.Size(419, 13);
            lbl_Etiqueta.TabIndex = 3;
            lbl_Etiqueta.Text = "Escriba el nombre del producto a buscar";
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
            panel_Busqueda.Location = new System.Drawing.Point(40, 30);
            panel_Busqueda.Name = "panel_Busqueda";
            panel_Busqueda.Size = new System.Drawing.Size(570, 321);
            panel_Busqueda.TabIndex = 35;
            panel_Busqueda.Visible = false;
            txt_Busqueda.Clear();
            data_resultado.Rows.Clear();
            Controls.Add(panel_Busqueda);
            //groupBoxdatos.Visible = false;
            panel_Busqueda.Visible = true;
            panel_Busqueda.Enabled = true;
            //CARACTERISTICA DE AUTOCOMPLETADO EN TXT_BUSQUEDA
            txt_Busqueda.AutoCompleteCustomSource = Autocomplete();
            txt_Busqueda.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_Busqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
        private bool Verificar_CamposVacios()
        {
            //Se introduce los textbox en un arreglo con el fin de identificar espacios vacios
            Campos[0] = txt_Lote;
            Campos[1] = txt_Cantidad;
            Campos[2] = txt_Preciocompra;
            Campos[3] = txt_Precioventa;
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
                    errorProvider_Textbox.SetError(txt_Preciocompra, "No puedes dejar el campo vacio");
                    break;
                case 3:
                    errorProvider_Textbox.SetError(txt_Precioventa, "No puedes dejar el campo vacio");
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
            CamposC[0] = comboBox_Almacen;
            CamposC[1] = comboBox_Materiaprima;
            CamposC[2] = comboBox_Tipopieza;
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
                    errorProvider_Combobox.SetError(comboBox_Materiaprima, "No puedes dejar el campo vacio");
                    break;
                case 2:
                    errorProvider_Combobox.SetError(comboBox_Tipopieza, "No puedes dejar el campo vacio");
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
            string consulta = "Select *  from V_Materiaprima"; //consulta a la tabla paises
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
            }
            return coleccion;
        }
        #endregion
        //-------------------------------------------------------------
        //-------------------------CONEXION----------------------------
        //-------------------------------------------------------------
        #region Cadena de conexión
        public static string ObtenerString()
        {
            return Settings.Default.SHAJOBEConnectionString;
        }
        #endregion
        //-------------------------------------------------------------
        //-------------------VALIDACION DE CAMPOS----------------------
        //-------------------------------------------------------------
        #region Validacion de campos
        private void txt_Busqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de letras-----------------------------------------------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto-------------------------- Uso del espacio
            if ((e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47) && (e.KeyChar < 31 || e.KeyChar > 33))
            {
                MessageBox.Show("Solo se aceptan letras", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
        private void txt_MinMax_KeyPress(object sender, KeyPressEventArgs e)
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
        //-------------------------------------------------------------
        //-------------LLENADO DE CONTROLES DEL SISTEMA----------------
        //-------------------------------------------------------------
        #region Llenado de los combobox
        private void Llenando_ComboboxTipo()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "select * from V_TiposPiezas";
            coman.CommandType = CommandType.Text;
            con.Open();
            comboBox_Tipopieza.Items.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Declarando Variables y obteniendo los valores correspondiente
                string Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                comboBox_Tipopieza.Items.Add(Nombre);
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
        private void Llenando_ComboboxMateria()
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
                string NombreMP = NombreN + " " + Tipo_PiezaN;
                comboBox_Materiaprima.Items.Add(NombreMP);
            }
            con.Close();
        }
        private void Llenando_ComboboxUnidad()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "Select *  from V_Unidadmedida";
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
