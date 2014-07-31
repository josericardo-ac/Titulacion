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
        private System.Windows.Forms.DataGridView dataGridView_HistorialAbonos;
        private System.Windows.Forms.Button bttn_Generar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Abono;
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
            this.dataGridView_HistorialAbonos = new System.Windows.Forms.DataGridView();
            this.bttn_Generar = new System.Windows.Forms.Button();
            this.maskedTextBox_Abono = new System.Windows.Forms.MaskedTextBox();
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
            this.groupBox_DatosProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Proveedor)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox_ListaCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HistorialAbonos)).BeginInit();
            this.groupBox_MateriaPrima.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MateriaPrima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            #endregion
            #region Diseño de controles
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
            // 
            // txt_Proveedor
            // 
            this.txt_Proveedor.Location = new System.Drawing.Point(81, 22);
            this.txt_Proveedor.MaxLength = 25;
            this.txt_Proveedor.Name = "txt_Proveedor";
            this.txt_Proveedor.Size = new System.Drawing.Size(116, 20);
            this.txt_Proveedor.TabIndex = 4;
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
            this.nuevoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.nuevoToolStripMenuItem.Text = "&Nuevo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripMenuItem.Image")));
            this.abrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.abrirToolStripMenuItem.Text = "&Abrir";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(203, 6);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripMenuItem.Image")));
            this.guardarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.guardarToolStripMenuItem.Text = "&Guardar";
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
            this.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem";
            this.ModificarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.ModificarToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ModificarToolStripMenuItem.Text = "&Modificar";
            // 
            // EliminarToolStripMenuItem
            // 
            this.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem";
            this.EliminarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.EliminarToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.EliminarToolStripMenuItem.Text = "&Eliminar";
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
            this.groupBox_ListaCompra.Controls.Add(this.dataGridView_HistorialAbonos);
            this.groupBox_ListaCompra.Location = new System.Drawing.Point(12, 206);
            this.groupBox_ListaCompra.Name = "groupBox_ListaCompra";
            this.groupBox_ListaCompra.Size = new System.Drawing.Size(518, 277);
            this.groupBox_ListaCompra.TabIndex = 6;
            this.groupBox_ListaCompra.TabStop = false;
            this.groupBox_ListaCompra.Text = "Lista de Compra";
            // 
            // dataGridView_HistorialAbonos
            // 
            this.dataGridView_HistorialAbonos.AllowUserToDeleteRows = false;
            this.dataGridView_HistorialAbonos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_HistorialAbonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HistorialAbonos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_MateriaPrima,
            this.MateriaPrima,
            this.Cantidad,
            this.Precio});
            this.dataGridView_HistorialAbonos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_HistorialAbonos.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_HistorialAbonos.Name = "dataGridView_HistorialAbonos";
            this.dataGridView_HistorialAbonos.ReadOnly = true;
            this.dataGridView_HistorialAbonos.Size = new System.Drawing.Size(512, 258);
            this.dataGridView_HistorialAbonos.TabIndex = 6;
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
            // maskedTextBox_Abono
            // 
            this.maskedTextBox_Abono.Enabled = false;
            this.maskedTextBox_Abono.Location = new System.Drawing.Point(727, 415);
            this.maskedTextBox_Abono.Mask = "$9999.00";
            this.maskedTextBox_Abono.Name = "maskedTextBox_Abono";
            this.maskedTextBox_Abono.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_Abono.TabIndex = 15;
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
            this.lbl_Encargo.Location = new System.Drawing.Point(376, 74);
            this.lbl_Encargo.Name = "lbl_Encargo";
            this.lbl_Encargo.Size = new System.Drawing.Size(103, 13);
            this.lbl_Encargo.TabIndex = 6;
            this.lbl_Encargo.Text = "Cantidad a encargar";
            // 
            // txt_Encargo
            // 
            this.txt_Encargo.Location = new System.Drawing.Point(379, 91);
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
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bttn_Quitar);
            this.Controls.Add(this.bttn_Agregar);
            this.Controls.Add(this.txt_Encargo);
            this.Controls.Add(this.lbl_Encargo);
            this.Controls.Add(this.groupBox_MateriaPrima);
            this.Controls.Add(this.bttn_Generar);
            this.Controls.Add(this.maskedTextBox_Abono);
            this.Controls.Add(this.lbl_Inversion);
            this.Controls.Add(this.groupBox_ListaCompra);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox_DatosProveedor);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HistorialAbonos)).EndInit();
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
            Diseño_Forma();
        }
    }
}
