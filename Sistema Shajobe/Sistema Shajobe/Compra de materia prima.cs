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
    public partial class CompraMateriaPrima : Form
    {
        public CompraMateriaPrima()
        {
            InitializeComponent();
        }
        #region Diseño de la forma
        #region Declarando Controles
        private System.Windows.Forms.GroupBox groupBox_DatosProveedor;
        private System.Windows.Forms.Button btt_Buscar;
        private System.Windows.Forms.TextBox txt_Proveedor;
        private System.Windows.Forms.DataGridView dataGridView_Proveedor;
        private System.Windows.Forms.Label lbl_Proveedor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vistapreviadeimpresiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercadeToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_ListaCompra;
        private System.Windows.Forms.DataGridView dataGridView_ListaCompra;
        private System.Windows.Forms.Button bttn_Generar;
        private System.Windows.Forms.TextBox txt_Inversion;
        private System.Windows.Forms.Label lbl_Inversion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_PC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_MC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_MateriaPrima;
        private System.Windows.Forms.DataGridViewTextBoxColumn MateriaPrima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.GroupBox groupBox_MateriaPrima;
        private System.Windows.Forms.Button bttn_BuscarMateriaPrima;
        private System.Windows.Forms.TextBox txt_MateriaPrima;
        private System.Windows.Forms.DataGridView dataGridView_MateriaPrima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_MateriaPrimaL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MateriaPrimaL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Encargo;
        private System.Windows.Forms.TextBox txt_Encargo;
        private System.Windows.Forms.Button bttn_Agregar;
        private System.Windows.Forms.Button bttn_Quitar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider_Textbox;
        private System.Windows.Forms.ComboBox Combo_Unidad;
        private System.Windows.Forms.Label lbl_Unidad;
        #endregion
        private void Diseño_Forma()
        {
            #region Creando controles
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompraMateriaPrima));
            this.groupBox_DatosProveedor = new System.Windows.Forms.GroupBox();
            this.btt_Buscar = new System.Windows.Forms.Button();
            this.txt_Proveedor = new System.Windows.Forms.TextBox();
            this.dataGridView_Proveedor = new System.Windows.Forms.DataGridView();
            this.lbl_Proveedor = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vistapreviadeimpresiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_ListaCompra = new System.Windows.Forms.GroupBox();
            this.dataGridView_ListaCompra = new System.Windows.Forms.DataGridView();
            this.bttn_Generar = new System.Windows.Forms.Button();
            this.txt_Inversion = new System.Windows.Forms.TextBox();
            this.lbl_Inversion = new System.Windows.Forms.Label();
            this.Id_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_PC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_MC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_MateriaPrima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MateriaPrima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_MateriaPrima = new System.Windows.Forms.GroupBox();
            this.bttn_BuscarMateriaPrima = new System.Windows.Forms.Button();
            this.txt_MateriaPrima = new System.Windows.Forms.TextBox();
            this.dataGridView_MateriaPrima = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Id_MateriaPrimaL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MateriaPrimaL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Encargo = new System.Windows.Forms.Label();
            this.txt_Encargo = new System.Windows.Forms.TextBox();
            this.bttn_Agregar = new System.Windows.Forms.Button();
            this.bttn_Quitar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Unidad = new System.Windows.Forms.Label();
            this.Combo_Unidad = new System.Windows.Forms.ComboBox();
            this.groupBox_DatosProveedor.SuspendLayout();
            this.errorProvider_Textbox = new System.Windows.Forms.ErrorProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Proveedor)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox_ListaCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListaCompra)).BeginInit();
            this.groupBox_MateriaPrima.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MateriaPrima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(errorProvider_Textbox)).EndInit();
            ResumeLayout(false);
            this.SuspendLayout();
            #endregion
            #region Diseño de controles
            // 
            // lbl_Unidad
            // 
            lbl_Unidad.AutoSize = true;
            lbl_Unidad.Location = new System.Drawing.Point(376, 84);
            lbl_Unidad.Name = "lbl_Unidad";
            lbl_Unidad.Size = new System.Drawing.Size(41, 13);
            lbl_Unidad.TabIndex = 17;
            lbl_Unidad.Text = "Unidad";
            // 
            // comboBox_Unidad
            // 
            Combo_Unidad.FormattingEnabled = true;
            Combo_Unidad.Location = new System.Drawing.Point(379, 101);
            Combo_Unidad.Name = "comboBox_Unidad";
            Combo_Unidad.Size = new System.Drawing.Size(79, 21);
            Combo_Unidad.KeyPress += new KeyPressEventHandler(NoescrituracomboBox_KeyPress);
            Combo_Unidad.TabIndex = 3;
            // 
            // groupBox_DatosProveedor
            // 
            this.groupBox_DatosProveedor.Controls.Add(this.btt_Buscar);
            this.groupBox_DatosProveedor.Controls.Add(this.txt_Proveedor);
            this.groupBox_DatosProveedor.Controls.Add(this.dataGridView_Proveedor);
            this.groupBox_DatosProveedor.Controls.Add(this.lbl_Proveedor);
            this.groupBox_DatosProveedor.Location = new System.Drawing.Point(12, 29);
            this.groupBox_DatosProveedor.Name = "groupBox_DatosProveedor";
            this.groupBox_DatosProveedor.Size = new System.Drawing.Size(335, 171);
            this.groupBox_DatosProveedor.TabIndex = 1;
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
            this.btt_Buscar.Click += new System.EventHandler(bttn_BusquedaProveedor_Click);
            // 
            // txt_Proveedor
            // 
            this.txt_Proveedor.Location = new System.Drawing.Point(81, 22);
            this.txt_Proveedor.MaxLength = 25;
            this.txt_Proveedor.Name = "txt_Proveedor";
            this.txt_Proveedor.Size = new System.Drawing.Size(116, 20);
            this.txt_Proveedor.TabIndex = 4;
            this.txt_Proveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_Proveedor_KeyPress);
            // 
            // dataGridView_Proveedor
            // 
            this.dataGridView_Proveedor.AllowUserToDeleteRows = false;
            this.dataGridView_Proveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Proveedor,
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
            // lbl_Proveedor
            // 
            this.lbl_Proveedor.AutoSize = true;
            this.lbl_Proveedor.Location = new System.Drawing.Point(19, 28);
            this.lbl_Proveedor.Name = "lbl_Proveedor";
            this.lbl_Proveedor.Size = new System.Drawing.Size(56, 13);
            this.lbl_Proveedor.TabIndex = 2;
            this.lbl_Proveedor.Text = "Proveedor";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(186)))), ((int)(((byte)(82)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(840, 24);
            this.menuStrip1.TabIndex = 4;
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.toolStripSeparator,
            this.guardarToolStripMenuItem,
            this.toolStripSeparator1,
            this.imprimirToolStripMenuItem,
            this.vistapreviadeimpresiónToolStripMenuItem,
            this.toolStripSeparator2,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            this.nuevoToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Nuevo;
            this.nuevoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.nuevoToolStripMenuItem.Text = "&Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripMenuItem.Image")));
            this.abrirToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Abrir;
            this.abrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.abrirToolStripMenuItem.Text = "&Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(abrirToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(203, 6);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripMenuItem.Image")));
            this.guardarToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Guardar;
            this.guardarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.guardarToolStripMenuItem.Text = "&Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(guardarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(203, 6);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimirToolStripMenuItem.Image")));
            this.imprimirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.imprimirToolStripMenuItem.Text = "&Imprimir";
            // 
            // vistapreviadeimpresiónToolStripMenuItem
            // 
            this.vistapreviadeimpresiónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vistapreviadeimpresiónToolStripMenuItem.Image")));
            this.vistapreviadeimpresiónToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.vistapreviadeimpresiónToolStripMenuItem.Name = "vistapreviadeimpresiónToolStripMenuItem";
            this.vistapreviadeimpresiónToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.vistapreviadeimpresiónToolStripMenuItem.Text = "&Vista previa de impresión";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(203, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            salirToolStripMenuItem.Click += new System.EventHandler(salirToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModificarToolStripMenuItem,
            this.EliminarToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "&Editar";
            // 
            // ModificarToolStripMenuItem
            // 
            this.ModificarToolStripMenuItem.Enabled = false;
            this.ModificarToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Modificar;
            this.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem";
            this.ModificarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.ModificarToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ModificarToolStripMenuItem.Text = "&Modificar";
            // 
            // EliminarToolStripMenuItem
            // 
            this.EliminarToolStripMenuItem.Enabled = false;
            this.EliminarToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Borrar;
            this.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem";
            this.EliminarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.EliminarToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.EliminarToolStripMenuItem.Text = "&Eliminar";
            this.EliminarToolStripMenuItem.Click += new System.EventHandler(eliminarToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercadeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ay&uda";
            // 
            // acercadeToolStripMenuItem
            // 
            this.acercadeToolStripMenuItem.Name = "acercadeToolStripMenuItem";
            this.acercadeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.acercadeToolStripMenuItem.Text = "&Acerca de...";
            // 
            // groupBox_ListaCompra
            // 
            this.groupBox_ListaCompra.Controls.Add(this.dataGridView_ListaCompra);
            this.groupBox_ListaCompra.Location = new System.Drawing.Point(12, 206);
            this.groupBox_ListaCompra.Name = "groupBox_ListaCompra";
            this.groupBox_ListaCompra.Size = new System.Drawing.Size(518, 277);
            this.groupBox_ListaCompra.TabIndex = 6;
            this.groupBox_ListaCompra.TabStop = false;
            this.groupBox_ListaCompra.Text = "Lista de Compra";
            // 
            // dataGridView_ListaCompra
            // 
            this.dataGridView_ListaCompra.AllowUserToDeleteRows = false;
            this.dataGridView_ListaCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ListaCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListaCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_MateriaPrima,
            this.MateriaPrima,
            this.Cantidad,
            this.Precio});
            this.dataGridView_ListaCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ListaCompra.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_ListaCompra.Name = "dataGridView_ListaCompra";
            this.dataGridView_ListaCompra.ReadOnly = true;
            this.dataGridView_ListaCompra.Size = new System.Drawing.Size(512, 258);
            this.dataGridView_ListaCompra.TabIndex = 6;
            // 
            // bttn_Generar
            // 
            this.bttn_Generar.Location = new System.Drawing.Point(718, 456);
            this.bttn_Generar.Name = "bttn_Generar";
            this.bttn_Generar.Size = new System.Drawing.Size(109, 23);
            this.bttn_Generar.TabIndex = 17;
            this.bttn_Generar.Text = "Generar pedido";
            this.bttn_Generar.UseVisualStyleBackColor = true;
            // 
            // txt_Inversion
            // 
            this.txt_Inversion.Enabled = false;
            this.txt_Inversion.Location = new System.Drawing.Point(727, 415);
            this.txt_Inversion.Name = "txt_Inversion";
            this.txt_Inversion.Size = new System.Drawing.Size(100, 20);
            this.txt_Inversion.TabIndex = 15;
            this.txt_Inversion.Text = "0.00";
            // 
            // lbl_Inversion
            // 
            this.lbl_Inversion.AutoSize = true;
            this.lbl_Inversion.Location = new System.Drawing.Point(654, 422);
            this.lbl_Inversion.Name = "lbl_Inversion";
            this.lbl_Inversion.Size = new System.Drawing.Size(50, 13);
            this.lbl_Inversion.TabIndex = 13;
            this.lbl_Inversion.Text = "Inversion";
            // 
            // Id_Proveedor
            // 
            this.Id_Proveedor.HeaderText = "Id_Proveedor";
            this.Id_Proveedor.Name = "Id_Proveedor";
            this.Id_Proveedor.ReadOnly = true;
            this.Id_Proveedor.Visible = false;
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
            // Id_MateriaPrima
            // 
            this.Id_MateriaPrima.HeaderText = "Id_MateriaPrima";
            this.Id_MateriaPrima.Name = "Id_MateriaPrima";
            this.Id_MateriaPrima.ReadOnly = true;
            this.Id_MateriaPrima.Visible = false;
            // 
            // MateriaPrima
            // 
            this.MateriaPrima.HeaderText = "Materia prima";
            this.MateriaPrima.Name = "MateriaPrima";
            this.MateriaPrima.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // groupBox_MateriaPrima
            // 
            this.groupBox_MateriaPrima.Controls.Add(this.bttn_BuscarMateriaPrima);
            this.groupBox_MateriaPrima.Controls.Add(this.txt_MateriaPrima);
            this.groupBox_MateriaPrima.Controls.Add(this.dataGridView_MateriaPrima);
            this.groupBox_MateriaPrima.Controls.Add(this.label1);
            this.groupBox_MateriaPrima.Location = new System.Drawing.Point(493, 29);
            this.groupBox_MateriaPrima.Name = "groupBox_MateriaPrima";
            this.groupBox_MateriaPrima.Size = new System.Drawing.Size(335, 171);
            this.groupBox_MateriaPrima.TabIndex = 20;
            this.groupBox_MateriaPrima.TabStop = false;
            this.groupBox_MateriaPrima.Text = "Datos de materia prima";
            // 
            // bttn_BuscarMateriaPrima
            // 
            this.bttn_BuscarMateriaPrima.Location = new System.Drawing.Point(226, 18);
            this.bttn_BuscarMateriaPrima.Name = "bttn_BuscarMateriaPrima";
            this.bttn_BuscarMateriaPrima.Size = new System.Drawing.Size(75, 23);
            this.bttn_BuscarMateriaPrima.TabIndex = 5;
            this.bttn_BuscarMateriaPrima.Text = "Buscar";
            this.bttn_BuscarMateriaPrima.UseVisualStyleBackColor = true;
            this.bttn_BuscarMateriaPrima.Click += new EventHandler(bttn_BusquedaMateriaPrima_Click);
            // 
            // txt_MateriaPrima
            // 
            this.txt_MateriaPrima.Location = new System.Drawing.Point(95, 19);
            this.txt_MateriaPrima.MaxLength = 25;
            this.txt_MateriaPrima.Name = "txt_MateriaPrima";
            this.txt_MateriaPrima.Size = new System.Drawing.Size(116, 20);
            this.txt_MateriaPrima.TabIndex = 4;
            // 
            // dataGridView_MateriaPrima
            // 
            this.dataGridView_MateriaPrima.AllowUserToDeleteRows = false;
            this.dataGridView_MateriaPrima.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_MateriaPrima.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_MateriaPrimaL,
            this.MateriaPrimaL,
            this.Descripcion});
            this.dataGridView_MateriaPrima.Location = new System.Drawing.Point(2, 62);
            this.dataGridView_MateriaPrima.MultiSelect = false;
            this.dataGridView_MateriaPrima.Name = "dataGridView_MateriaPrima";
            this.dataGridView_MateriaPrima.ReadOnly = true;
            this.dataGridView_MateriaPrima.Size = new System.Drawing.Size(332, 104);
            this.dataGridView_MateriaPrima.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Materia prima";
            // 
            // Id_MateriaPrimaL
            // 
            this.Id_MateriaPrimaL.HeaderText = "Id_MateriaPrimaL";
            this.Id_MateriaPrimaL.Name = "Id_MateriaPrimaL";
            this.Id_MateriaPrimaL.ReadOnly = true;
            this.Id_MateriaPrimaL.Visible = false;
            // 
            // MateriaPrimaL
            // 
            this.MateriaPrimaL.HeaderText = "Materia prima";
            this.MateriaPrimaL.Name = "MateriaPrimaL";
            this.MateriaPrimaL.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // lbl_Encargo
            // 
            this.lbl_Encargo.AutoSize = true;
            this.lbl_Encargo.Location = new System.Drawing.Point(376, 44);
            this.lbl_Encargo.Name = "lbl_Encargo";
            this.lbl_Encargo.Size = new System.Drawing.Size(103, 13);
            this.lbl_Encargo.TabIndex = 6;
            this.lbl_Encargo.Text = "Cantidad a encargar";
            // 
            // txt_Encargo
            // 
            this.txt_Encargo.Location = new System.Drawing.Point(379, 61);
            this.txt_Encargo.Name = "txt_Encargo";
            this.txt_Encargo.Size = new System.Drawing.Size(100, 20);
            this.txt_Encargo.TabIndex = 21;
            // 
            // bttn_Agregar
            // 
            this.bttn_Agregar.Location = new System.Drawing.Point(379, 128);
            this.bttn_Agregar.Name = "bttn_Agregar";
            this.bttn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.bttn_Agregar.TabIndex = 22;
            this.bttn_Agregar.Text = "Agregar";
            this.bttn_Agregar.UseVisualStyleBackColor = true;
            this.bttn_Agregar.Click += new EventHandler(bttn_Agregar_Click);
            // 
            // bttn_Quitar
            // 
            this.bttn_Quitar.Location = new System.Drawing.Point(379, 157);
            this.bttn_Quitar.Name = "bttn_Quitar";
            this.bttn_Quitar.Size = new System.Drawing.Size(75, 23);
            this.bttn_Quitar.TabIndex = 23;
            this.bttn_Quitar.Text = "Quitar";
            this.bttn_Quitar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_Shajobe.Properties.Resources.Pedidos_Shajobe;
            this.pictureBox1.Location = new System.Drawing.Point(564, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // CompraMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 491);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(196)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bttn_Quitar);
            this.Controls.Add(this.bttn_Agregar);
            this.Controls.Add(this.txt_Encargo);
            this.Controls.Add(this.lbl_Encargo);
            this.Controls.Add(this.groupBox_MateriaPrima);
            this.Controls.Add(this.bttn_Generar);
            this.Controls.Add(this.txt_Inversion);
            this.Controls.Add(this.lbl_Inversion);
            this.Controls.Add(this.groupBox_ListaCompra);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox_DatosProveedor);
            this.Controls.Add(this.lbl_Unidad);
            this.Controls.Add(this.Combo_Unidad);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(Compra_FormClosing);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(856, 529);
            this.MinimumSize = new System.Drawing.Size(856, 529);
            this.Icon = global::Sistema_Shajobe.Properties.Resources.Pedidos_ICO;
            this.Name = "CompraMateriaPrima";
            this.Text = "Compra de materia prima";
            this.groupBox_DatosProveedor.ResumeLayout(false);
            this.groupBox_DatosProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Proveedor)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_ListaCompra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListaCompra)).EndInit();
            this.groupBox_MateriaPrima.ResumeLayout(false);
            this.groupBox_MateriaPrima.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MateriaPrima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            #endregion
        }
        #endregion
        private void CompraMateriaPrima_Load(object sender, EventArgs e)
        {
            #region Animacion
            AnimateWindow(Handle, 350, AnimateWindowFlags.AW_CENTER);
            AnimateWindow(Handle, 450, AnimateWindowFlags.AW_CENTER | AnimateWindowFlags.AW_SLIDE);
            ResumeLayout(false);
            PerformLayout();
            #endregion
            Diseño_Forma();
            //Llenando Controles
            Llenando_ComboboxUnidadMedida();
            //CARACTERISTICA DE AUTOCOMPLETADO EN TXT_CLIENTE
            txt_Proveedor.AutoCompleteCustomSource = Autocomplete();
            txt_Proveedor.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_Proveedor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //CARACTERISTICA DE AUTOCOMPLETADO EN TXT_MATERIA PRIMA
            txt_MateriaPrima.AutoCompleteCustomSource = Autocomplete_MateriaPrima();
            txt_MateriaPrima.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_MateriaPrima.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        #region Eventos
        private bool Espacios_Vacios = false;
        private int Idp;
        //-------------------------------------------------------------
        //------------------BUSQUEDA DEL SISTEMA-----------------------
        //-------------------------------------------------------------
        #region Busqueda Proveedor
        #region Busqueda Cliente
        private void bttn_BusquedaProveedor_Click(object sender, EventArgs e)
        {
            Busqueda_Cliente();
        }
        private void Busqueda_Cliente()
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
                coman.CommandText = "SELECT Id_Proveedor, Nombre, Apellido_P, Apellido_M, RFC FROM Tb_Proveedor WHERE (Tb_Proveedor.Activo = 'S') and (Tb_Proveedor.Nombre='" + busqueda.ToUpper() + "'OR Tb_Proveedor.Apellido_P='" + busqueda.ToUpper() + "'OR Tb_Proveedor.Apellido_M='" + busqueda.ToUpper() + "'OR Tb_Proveedor.RFC='" + busqueda.ToUpper() + "')";
                coman.CommandType = CommandType.Text;
                con.Open();
                dataGridView_Proveedor.Rows.Clear();
                dr = coman.ExecuteReader();
                while (dr.Read())
                { 
                    int Renglon = dataGridView_Proveedor.Rows.Add();
                    Idp = dr.GetInt32(dr.GetOrdinal("Id_Proveedor"));
                    dataGridView_Proveedor.Rows[Renglon].Cells["Id_Proveedor"].Value = dr.GetInt32(dr.GetOrdinal("Id_Proveedor"));
                    dataGridView_Proveedor.Rows[Renglon].Cells["NombreC"].Value = dr.GetString(dr.GetOrdinal("Nombre"));
                    dataGridView_Proveedor.Rows[Renglon].Cells["Apellido_PC"].Value = dr.GetString(dr.GetOrdinal("Apellido_P"));
                    dataGridView_Proveedor.Rows[Renglon].Cells["Apellido_MC"].Value = dr.GetString(dr.GetOrdinal("Apellido_M"));
                }
                con.Close();
            }
        }
        //-------------------------------------------------------------
        //----------------------AUTO COMPLETAR-------------------------
        //-------------------------------------------------------------
        //metodo para cargar la coleccion de datos para el autocomplete
        public static DataTable Datos_Proveedor()
        {
            DataTable dt = new DataTable();
            OleDbConnection conexion = new OleDbConnection(ObtenerString());//cadena conexion
            string consulta = "SELECT * FROM Tb_Proveedor where Activo='S'"; //consulta a la tabla de proveedores
            OleDbCommand comando = new OleDbCommand(consulta, conexion);
            OleDbDataAdapter adap = new OleDbDataAdapter(comando);
            adap.Fill(dt);
            return dt;
        }
        //metodo para cargar la coleccion de datos para el autocomplete
        public static AutoCompleteStringCollection Autocomplete_Cliente()
        {
            DataTable dt = Datos_Proveedor();
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row["Nombre"]));
                coleccion.Add(Convert.ToString(row["Apellido_P"]));
                coleccion.Add(Convert.ToString(row["Apellido_M"]));
                coleccion.Add(Convert.ToString(row["RFC"]));
            }
            return coleccion;
        }
        //-------------------------------------------------------------
        //------------VALIDACION DEL CAMPO TXT_PROVEEDOR---------------
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
        #endregion
        #endregion
        #region Busqueda Materia prima
        private void data_resultado_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Idp = Convert.ToInt32(dataGridView_MateriaPrima.CurrentRow.Cells["Id"].Value);
        }
        private void Busqueda()
        {
            string Tipo, NombreTipo, Nombre;
            if (txt_MateriaPrima.Text.Trim() == "")
            {
                errorProvider_Textbox.SetError(txt_MateriaPrima, "No puedes dejar el campo vacio");
                MessageBox.Show("Inserta todos los datos marcados", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            { 
                OleDbConnection con = new OleDbConnection();
                OleDbCommand coman = new OleDbCommand();
                OleDbDataReader dr;
                con.ConnectionString = ObtenerString();
                coman.Connection = con;
                string busqueda = txt_MateriaPrima.Text;
                txt_MateriaPrima.Text = busqueda.ToUpper();
                coman.CommandText = "SELECT Tb_MateriaPrima.Nombre, Tb_MateriaPrima.Descripcion, Tb_MateriaPrima.Id_MateriaPrima, Tb_TipoPieza.Nombre AS Tipo_Pieza FROM Tb_MateriaPrima INNER JOIN Tb_TipoPieza ON Tb_MateriaPrima.Id_TipoPieza = Tb_TipoPieza.Id_TipoPieza WHERE (Tb_MateriaPrima.Activo = 'S') and (Tb_MateriaPrima.Nombre='" + busqueda.ToUpper() + "')";
                coman.CommandType = CommandType.Text;
                con.Open();
                dataGridView_MateriaPrima.Rows.Clear();
                dr = coman.ExecuteReader();
                while (dr.Read())
                {
                    int Renglon = dataGridView_MateriaPrima.Rows.Add();
                    Idp = dr.GetInt32(dr.GetOrdinal("Id_MateriaPrima"));
                    Tipo = dr.GetString(dr.GetOrdinal("Tipo_Pieza"));
                    Nombre= dr.GetString(dr.GetOrdinal("Nombre"));
                    NombreTipo= Nombre+ " "+ Tipo;
                    dataGridView_MateriaPrima.Rows[Renglon].Cells["Id_MateriaPrimaL"].Value = dr.GetInt32(dr.GetOrdinal("Id_MateriaPrima"));
                    dataGridView_MateriaPrima.Rows[Renglon].Cells["MateriaPrimaL"].Value = NombreTipo;
                    dataGridView_MateriaPrima.Rows[Renglon].Cells["Descripcion"].Value = dr.GetString(dr.GetOrdinal("Descripcion"));
                }
                con.Close();
            }
        }
        private void bttn_BusquedaMateriaPrima_Click(object sender, EventArgs e)
        {
            Busqueda();
        }
        #endregion
        //-------------------------------------------------------------
        //-------------------LLENANDO CONTROLES------------------------
        //-------------------------------------------------------------
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
            Combo_Unidad.Items.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Declarando Variables y obteniendo los valores correspondiente
                string Simbolo = dr.GetString(dr.GetOrdinal("Simbolo"));
                Combo_Unidad.Items.Add(Simbolo);
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
 
        }
        #endregion
        #region Cambios
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        { 
        }
        #endregion
        #region Eliminar
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
        }
        #endregion
        #endregion
        #region Funciones N, A y S
        #region Nuevo
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Limpiar();
        }
        #endregion
        #region Abrir
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
        }
        #endregion
        #region Salir
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
            Application.OpenForms["Menu_principal"].Activate();
            Close();
        }
        #endregion
        #endregion
        #region Funcion Agregar y Quitar
        #region Agregar
        private decimal _Precio;
        private void bttn_Agregar_Click(object sender, EventArgs e)
        {
            bool ic = Verificar_CamposVacios();
            if (ic == true)
            {
                MessageBox.Show("Inserta todos los datos marcados", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (dataGridView_MateriaPrima.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione una materia prima de la lista el cual se va a gregar a la lista", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    if (dataGridView_MateriaPrima.RowCount > 0)
                    {

                        Idp = Convert.ToInt32(dataGridView_MateriaPrima.CurrentRow.Cells["Id_MateriaPrimaL"].Value);
                        #region Busqueda de datos de la materia prima
                        OleDbConnection con = new OleDbConnection();
                        OleDbCommand coman = new OleDbCommand();
                        OleDbDataReader dr;
                        con.ConnectionString = ObtenerString();
                        coman.Connection = con;
                        coman.CommandText = "SELECT Precio_Compra FROM Tb_Inventariomateriaprimadetalle WHERE (Id_MateriaPrima = '"+Idp+ "')";
                        coman.CommandType = CommandType.Text;
                        con.Open();
                        Combo_Unidad.Items.Clear();
                        dr = coman.ExecuteReader();
                        while (dr.Read())
                        {
                            //Declarando Variables y obteniendo los valores correspondiente
                            _Precio = dr.GetDecimal(dr.GetOrdinal("Precio_Compra"));
                        }
                        con.Close();
                        #endregion
                        int Lista = dataGridView_ListaCompra.Rows.Add();
                        dataGridView_ListaCompra.Rows[Lista].Cells["Id_MateriaPrima"].Value = Convert.ToInt32(dataGridView_MateriaPrima.CurrentRow.Cells["Id_MateriaPrimaL"].Value);
                        dataGridView_ListaCompra.Rows[Lista].Cells["MateriaPrima"].Value = Convert.ToString(dataGridView_MateriaPrima.CurrentRow.Cells["MateriaPrimaL"].Value);
                        dataGridView_ListaCompra.Rows[Lista].Cells["Cantidad"].Value = txt_Encargo.Text;
                        dataGridView_ListaCompra.Rows[Lista].Cells["Precio"].Value = _Precio;
                        //SUMANDO EL DINERO A INVERTIR
                        decimal inversion = Convert.ToDecimal(txt_Inversion.Text);
                        inversion += _Precio;
                        txt_Inversion.Text = inversion.ToString();                        
                    }
                }
            }
        }
        #endregion
        #region Quitar
        private void bttn_Quitar_Click(object sender, EventArgs e)
        {
            if (dataGridView_ListaCompra.RowCount > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Deseas realmente quitar este permiso", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    dataGridView_ListaCompra.Rows.RemoveAt(dataGridView_ListaCompra.CurrentRow.Index);
                }
            }
        }
        #endregion
        #endregion
        //-------------------------------------------------------------
        //----------------------AUTO COMPLETAR-------------------------
        //-------------------------------------------------------------
        #region Funcion Autocompletar Proveedores
        //metodo para cargar la coleccion de datos para el autocomplete
        public static DataTable Datos()
        {
            DataTable dt = new DataTable();
            OleDbConnection conexion = new OleDbConnection(ObtenerString());//cadena conexion
            string consulta = "SELECT Nombre, Apellido_P, Apellido_M, RFC FROM Tb_Proveedor WHERE (Activo = 'S')";//Se trae todos los registros de proveedores
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
                coleccion.Add(Convert.ToString(row["Apellido_P"]));
                coleccion.Add(Convert.ToString(row["Apellido_M"]));
                coleccion.Add(Convert.ToString(row["RFC"]));
            }
            return coleccion;
        }
        #endregion
        #region Funcion Autocompletar Materia prima
        //metodo para cargar la coleccion de datos para el autocomplete
        public static DataTable Datos_MateriaPrima()
        {
            DataTable dt = new DataTable();
            OleDbConnection conexion = new OleDbConnection(ObtenerString());//cadena conexion
            string consulta = "SELECT * FROM Tb_MateriaPrima where Activo='S'"; //consulta a la tabla paises
            OleDbCommand comando = new OleDbCommand(consulta, conexion);
            OleDbDataAdapter adap = new OleDbDataAdapter(comando);
            adap.Fill(dt);
            return dt;
        }
        //metodo para cargar la coleccion de datos para el autocomplete
        public static AutoCompleteStringCollection Autocomplete_MateriaPrima()
        {
            DataTable dt = Datos_MateriaPrima();
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
        //OBTIENE LA CADENA DE CONEXION
        public static string ObtenerString()
        {
            return Settings.Default.SHAJOBEConnectionString;
        }
        #endregion
        //-------------------------------------------------------------
        //-------------------Validacion de campos----------------------
        //-------------------------------------------------------------
        #region Verificar campos vacios
        //METODOS PARA INDICAR ERROR DE CAMPOS VACIOS
        private TextBox[] Campos = new TextBox[1];
        private bool Verificar_CamposVacios()
        { 
            //Se introduce los textbox en un arreglo con el fin de identificar espacios vacios
            Campos[0] = txt_MateriaPrima;
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
                    errorProvider_Textbox.SetError(txt_MateriaPrima, "No puedes dejar el campo vacio");
                    break;
                default:
                    break;
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
        //-------------------AL CERRAR LA VENTANA----------------------
        //-------------------------------------------------------------
        private void Compra_FormClosing(object sender, FormClosingEventArgs e)
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
