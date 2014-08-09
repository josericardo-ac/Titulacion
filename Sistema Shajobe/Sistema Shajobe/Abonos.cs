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
    public partial class Abonos : Form
    {
        public Abonos()
        {
            InitializeComponent();
        }
        #region Diseño de la forma
        #region Creando controles de la forma
        private System.Windows.Forms.GroupBox groupBox_DatosCliente;
        private System.Windows.Forms.Button btt_Buscar;
        private System.Windows.Forms.TextBox txt_Cliente;
        private System.Windows.Forms.DataGridView dataGridView_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_ClienteC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_PC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_MC;
        private System.Windows.Forms.Label lbl_Clientes;
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
        private System.Windows.Forms.GroupBox groupBox_Abonos;
        private System.Windows.Forms.DataGridView dataGridView_HistorialAbonos;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Pendiente;
        private System.Windows.Forms.Label lbl_Pendiente;
        private System.Windows.Forms.Button bttn_Pagar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Total;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Abono;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_Abono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Abono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_Abono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Prox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo_Anterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo_Actual;
        private System.Windows.Forms.ErrorProvider errorProvider_Textbox;
        #endregion
        private void Diseña_Forma()
        {
            #region Declarando controles de la forma
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Abonos));
            this.groupBox_DatosCliente = new System.Windows.Forms.GroupBox();
            this.btt_Buscar = new System.Windows.Forms.Button();
            this.txt_Cliente = new System.Windows.Forms.TextBox();
            this.dataGridView_Cliente = new System.Windows.Forms.DataGridView();
            this.Id_ClienteC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_PC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_MC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Clientes = new System.Windows.Forms.Label();
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
            this.groupBox_Abonos = new System.Windows.Forms.GroupBox();
            this.dataGridView_HistorialAbonos = new System.Windows.Forms.DataGridView();
            this.maskedTextBox_Pendiente = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Pendiente = new System.Windows.Forms.Label();
            this.bttn_Pagar = new System.Windows.Forms.Button();
            this.maskedTextBox_Total = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_Abono = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_Abono = new System.Windows.Forms.Label();
            this.Id_Abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N_Abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Prox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo_Anterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo_Actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider_Textbox = new System.Windows.Forms.ErrorProvider();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Textbox)).BeginInit();
            this.groupBox_DatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cliente)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox_Abonos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HistorialAbonos)).BeginInit();

            this.SuspendLayout();
            #endregion
            #region Diseñando controles
            // 
            // groupBox_DatosCliente
            // 
            this.groupBox_DatosCliente.Controls.Add(this.btt_Buscar);
            this.groupBox_DatosCliente.Controls.Add(this.txt_Cliente);
            this.groupBox_DatosCliente.Controls.Add(this.dataGridView_Cliente);
            this.groupBox_DatosCliente.Controls.Add(this.lbl_Clientes);
            this.groupBox_DatosCliente.Location = new System.Drawing.Point(12, 29);
            this.groupBox_DatosCliente.Name = "groupBox_DatosCliente";
            this.groupBox_DatosCliente.Size = new System.Drawing.Size(335, 171);
            this.groupBox_DatosCliente.TabIndex = 1;
            this.groupBox_DatosCliente.TabStop = false;
            this.groupBox_DatosCliente.Text = "Datos del cliente";
            // 
            // btt_Buscar
            // 
            this.btt_Buscar.Location = new System.Drawing.Point(226, 18);
            this.btt_Buscar.Name = "btt_Buscar";
            this.btt_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btt_Buscar.TabIndex = 5;
            this.btt_Buscar.Text = "Buscar";
            this.btt_Buscar.UseVisualStyleBackColor = true;
            this.btt_Buscar.Click += new System.EventHandler(bttn_BusquedaCliente_Click);
            // 
            // txt_Cliente
            // 
            this.txt_Cliente.Location = new System.Drawing.Point(81, 22);
            this.txt_Cliente.MaxLength = 25;
            this.txt_Cliente.Name = "txt_Cliente";
            this.txt_Cliente.Size = new System.Drawing.Size(116, 20);
            this.txt_Cliente.TabIndex = 4;
            // 
            // dataGridView_Cliente
            // 
            this.dataGridView_Cliente.AllowUserToDeleteRows = false;
            this.dataGridView_Cliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_ClienteC,
            this.NombreC,
            this.Apellido_PC,
            this.Apellido_MC});
            this.dataGridView_Cliente.Location = new System.Drawing.Point(2, 62);
            this.dataGridView_Cliente.MultiSelect = false;
            this.dataGridView_Cliente.Name = "dataGridView_Cliente";
            this.dataGridView_Cliente.ReadOnly = true;
            this.dataGridView_Cliente.Size = new System.Drawing.Size(332, 104);
            this.dataGridView_Cliente.TabIndex = 3;
            this.dataGridView_Cliente.Click += new EventHandler(HistorialAbonos_Click);
            // 
            // Id_ClienteC
            // 
            this.Id_ClienteC.HeaderText = "Id_ClienteC";
            this.Id_ClienteC.Name = "Id_ClienteC";
            this.Id_ClienteC.ReadOnly = true;
            this.Id_ClienteC.Visible = false;
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
            // lbl_Clientes
            // 
            this.lbl_Clientes.AutoSize = true;
            this.lbl_Clientes.Location = new System.Drawing.Point(31, 28);
            this.lbl_Clientes.Name = "lbl_Clientes";
            this.lbl_Clientes.Size = new System.Drawing.Size(44, 13);
            this.lbl_Clientes.TabIndex = 2;
            this.lbl_Clientes.Text = "Clientes";
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
            this.menuStrip1.Size = new System.Drawing.Size(543, 24);
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
            this.imprimirToolStripMenuItem.Click+=new EventHandler(imprimirToolStripMenuItem_Click);
            // 
            // vistapreviadeimpresiónToolStripMenuItem
            // 
            this.vistapreviadeimpresiónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vistapreviadeimpresiónToolStripMenuItem.Image")));
            this.vistapreviadeimpresiónToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.vistapreviadeimpresiónToolStripMenuItem.Name = "vistapreviadeimpresiónToolStripMenuItem";
            this.vistapreviadeimpresiónToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.vistapreviadeimpresiónToolStripMenuItem.Text = "&Vista previa de impresión";
            this.vistapreviadeimpresiónToolStripMenuItem.Visible = false;
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
            // groupBox_Abonos
            // 
            this.groupBox_Abonos.Controls.Add(this.dataGridView_HistorialAbonos);
            this.groupBox_Abonos.Location = new System.Drawing.Point(12, 206);
            this.groupBox_Abonos.Name = "groupBox_Abonos";
            this.groupBox_Abonos.Size = new System.Drawing.Size(518, 277);
            this.groupBox_Abonos.TabIndex = 6;
            this.groupBox_Abonos.TabStop = false;
            this.groupBox_Abonos.Text = "Lista de Abonos";
            // 
            // dataGridView_HistorialAbonos
            // 
            this.dataGridView_HistorialAbonos.AllowUserToDeleteRows = false;
            this.dataGridView_HistorialAbonos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_HistorialAbonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HistorialAbonos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Abono,
            this.Fecha,
            this.Cantidad,
            this.N_Abono,
            this.Fecha_Prox,
            this.Saldo_Anterior,
            this.Saldo_Actual});
            this.dataGridView_HistorialAbonos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_HistorialAbonos.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_HistorialAbonos.Name = "dataGridView_HistorialAbonos";
            this.dataGridView_HistorialAbonos.ReadOnly = true;
            this.dataGridView_HistorialAbonos.Size = new System.Drawing.Size(512, 258);
            this.dataGridView_HistorialAbonos.TabIndex = 6;
            // 
            // maskedTextBox_Pendiente
            // 
            this.maskedTextBox_Pendiente.Location = new System.Drawing.Point(430, 110);
            this.maskedTextBox_Pendiente.Mask = "$9999.00";
            this.maskedTextBox_Pendiente.Name = "maskedTextBox_Pendiente";
            this.maskedTextBox_Pendiente.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_Pendiente.TabIndex = 19;
            // 
            // lbl_Pendiente
            // 
            this.lbl_Pendiente.AutoSize = true;
            this.lbl_Pendiente.Location = new System.Drawing.Point(357, 117);
            this.lbl_Pendiente.Name = "lbl_Pendiente";
            this.lbl_Pendiente.Size = new System.Drawing.Size(55, 13);
            this.lbl_Pendiente.TabIndex = 18;
            this.lbl_Pendiente.Text = "Pendiente";
            // 
            // bttn_Pagar
            // 
            this.bttn_Pagar.Location = new System.Drawing.Point(430, 154);
            this.bttn_Pagar.Name = "bttn_Pagar";
            this.bttn_Pagar.Size = new System.Drawing.Size(75, 23);
            this.bttn_Pagar.TabIndex = 17;
            this.bttn_Pagar.Text = "Pagar";
            this.bttn_Pagar.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox_Total
            // 
            this.maskedTextBox_Total.Enabled = false;
            this.maskedTextBox_Total.Location = new System.Drawing.Point(430, 74);
            this.maskedTextBox_Total.Mask = "$9999.00";
            this.maskedTextBox_Total.Name = "maskedTextBox_Total";
            this.maskedTextBox_Total.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_Total.TabIndex = 16;
            // 
            // maskedTextBox_Abono
            // 
            this.maskedTextBox_Abono.Enabled = false;
            this.maskedTextBox_Abono.Location = new System.Drawing.Point(430, 41);
            this.maskedTextBox_Abono.Mask = "$9999.00";
            this.maskedTextBox_Abono.Name = "maskedTextBox_Abono";
            this.maskedTextBox_Abono.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_Abono.TabIndex = 15;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(357, 81);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(31, 13);
            this.lbl_Total.TabIndex = 14;
            this.lbl_Total.Text = "Total";
            // 
            // lbl_Abono
            // 
            this.lbl_Abono.AutoSize = true;
            this.lbl_Abono.Location = new System.Drawing.Point(357, 48);
            this.lbl_Abono.Name = "lbl_Abono";
            this.lbl_Abono.Size = new System.Drawing.Size(38, 13);
            this.lbl_Abono.TabIndex = 13;
            this.lbl_Abono.Text = "Abono";
            // 
            // Id_Abono
            // 
            this.Id_Abono.HeaderText = "Id_Abono";
            this.Id_Abono.Name = "Id_Abono";
            this.Id_Abono.ReadOnly = true;
            this.Id_Abono.Visible = false;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // N_Abono
            // 
            this.N_Abono.HeaderText = "No. Abono";
            this.N_Abono.Name = "N_Abono";
            this.N_Abono.ReadOnly = true;
            // 
            // Fecha_Prox
            // 
            this.Fecha_Prox.HeaderText = "Fecha prox ";
            this.Fecha_Prox.Name = "Fecha_Prox";
            this.Fecha_Prox.ReadOnly = true;
            // 
            // Saldo_Anterior
            // 
            this.Saldo_Anterior.HeaderText = "Saldo anterior";
            this.Saldo_Anterior.Name = "Saldo_Anterior";
            this.Saldo_Anterior.ReadOnly = true;
            // 
            // Saldo_Actual
            // 
            this.Saldo_Actual.HeaderText = "Saldo actual";
            this.Saldo_Actual.Name = "Saldo_Actual";
            this.Saldo_Actual.ReadOnly = true;
            // 
            // errorProvider_Textbox
            // 
            this.errorProvider_Textbox.ContainerControl = this;
            // 
            // Abonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(543, 491);
            this.Controls.Add(this.maskedTextBox_Pendiente);
            this.Controls.Add(this.lbl_Pendiente);
            this.Controls.Add(this.bttn_Pagar);
            this.Controls.Add(this.maskedTextBox_Total);
            this.Controls.Add(this.maskedTextBox_Abono);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_Abono);
            this.Controls.Add(this.groupBox_Abonos);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox_DatosCliente);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(Abono_FormClosing);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(559, 529);
            this.MinimumSize = new System.Drawing.Size(559, 529);
            this.Name = "Abonos";
            this.Text = "Abonos";
            this.groupBox_DatosCliente.ResumeLayout(false);
            this.groupBox_DatosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cliente)).EndInit();
            this.Icon = global::Sistema_Shajobe.Properties.Resources.Dinero_ICO;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_Abonos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HistorialAbonos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Textbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            #endregion
        }
        #endregion
        private void Abonos_Load(object sender, EventArgs e)
        {
            #region Animacion
            AnimateWindow(Handle, 350, AnimateWindowFlags.AW_CENTER);
            AnimateWindow(Handle, 450, AnimateWindowFlags.AW_CENTER | AnimateWindowFlags.AW_SLIDE);
            ResumeLayout(false);
            PerformLayout();
            #endregion
            Diseña_Forma();
            //GENERANDO EL AUTOCOMPLETAR DE TXT_CLIENTE
            txt_Cliente.AutoCompleteCustomSource = Autocomplete_Cliente();
            txt_Cliente.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_Cliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        #region Eventos
        //-------------------------------------------------------------
        //------------------Variables y Arreglos-----------------------
        //-------------------------------------------------------------
        private int Idp;//LO USO PARA OBTENER EL ID COMO RESULTADO DE LA BUSQUEDA
        //-------------------------------------------------------------
        //---------------CONFIGURACION DE CONTROLES--------------------
        //-------------------------------------------------------------
        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView_Cliente.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente al cual se va a realizar la consulta", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (dataGridView_Cliente.RowCount > 0)
                {
                    int dato = Convert.ToInt32(dataGridView_Cliente.CurrentRow.Cells["Id_ClienteC"].Value);
                    Reporte_Abono_Cliente rc = new Reporte_Abono_Cliente();
                    rc.recibe(dato);
                    rc.Show();
                }
            }
        }
        //-------------------------------------------------------------
        //------------------BUSQUEDA DEL SISTEMA-----------------------
        //-------------------------------------------------------------
        #region Busqueda Cliente
        private void bttn_BusquedaCliente_Click(object sender, EventArgs e)
        {
            Busqueda_Cliente();
        }
        private void Busqueda_Cliente()
        {
            errorProvider_Textbox.Clear();
            if (txt_Cliente.Text.Trim() == "")
            {
                errorProvider_Textbox.SetError(txt_Cliente, "No puedes dejar el campo vacio");
                MessageBox.Show("Inserta todos los datos marcados", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OleDbConnection con = new OleDbConnection();
                OleDbCommand coman = new OleDbCommand();
                OleDbDataReader dr;
                con.ConnectionString = ObtenerString();
                coman.Connection = con;
                string busqueda = txt_Cliente.Text;
                txt_Cliente.Text = busqueda.ToUpper();
                coman.CommandText = "SELECT Id_Cliente, Nombre, Apellido_P, Apellido_M FROM Tb_Cliente WHERE (Tb_Cliente.Activo = 'S') and (Tb_Cliente.Nombre='" + busqueda.ToUpper() + "'OR Tb_Cliente.Apellido_P='" + busqueda.ToUpper() + "'OR Tb_Cliente.Apellido_M='" + busqueda.ToUpper() + "')";
                coman.CommandType = CommandType.Text;
                con.Open();
                dataGridView_Cliente.Rows.Clear();
                dr = coman.ExecuteReader();
                while (dr.Read())
                {
                    int Renglon = dataGridView_Cliente.Rows.Add();
                    Idp = dr.GetInt32(dr.GetOrdinal("Id_Cliente"));
                    dataGridView_Cliente.Rows[Renglon].Cells["Id_ClienteC"].Value = dr.GetInt32(dr.GetOrdinal("Id_Cliente"));
                    dataGridView_Cliente.Rows[Renglon].Cells["NombreC"].Value = dr.GetString(dr.GetOrdinal("Nombre"));
                    dataGridView_Cliente.Rows[Renglon].Cells["Apellido_PC"].Value = dr.GetString(dr.GetOrdinal("Apellido_P"));
                    dataGridView_Cliente.Rows[Renglon].Cells["Apellido_MC"].Value = dr.GetString(dr.GetOrdinal("Apellido_M"));
                }
                con.Close();
            }
        }
        //-------------------------------------------------------------
        //----------------------AUTO COMPLETAR-------------------------
        //-------------------------------------------------------------
        //metodo para cargar la coleccion de datos para el autocomplete
        public static DataTable Datos_Cliente()
        {
            DataTable dt = new DataTable();
            OleDbConnection conexion = new OleDbConnection(ObtenerString());//cadena conexion
            //string consulta = "SELECT * FROM Tb_Cliente where Activo='S'"; 
            string consulta = "SELECT Nombre, Apellido_P, Apellido_M FROM Tb_Cliente WHERE (Activo = 'S') AND (Saldo > 0)"; //SOLO SE TRAE CLIENTES QUE TENGAN SALDO MAYOR >0
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
        //-------------VALIDACION DEL CAMPO TXT_CLIENTE----------------
        //-------------------------------------------------------------
        private void txt_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de letras-----------------------------------------------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto-------------------------- Uso del espacio
            if ((e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47) && (e.KeyChar < 31 || e.KeyChar > 33))
            {
                MessageBox.Show("Solo se aceptan letras", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        #endregion
        #region Historial de Abonos
        private void HistorialAbonos_Click(object sender, EventArgs e)
        {
            try
            {
                int HCliente = Convert.ToInt32(dataGridView_Cliente.CurrentRow.Cells["Id_ClienteC"].Value);
                OleDbConnection con = new OleDbConnection();
                OleDbCommand coman = new OleDbCommand();
                OleDbDataReader dr;
                con.ConnectionString = ObtenerString();
                coman.Connection = con;
                coman.CommandText = "SELECT Tb_Abono.* FROM Tb_Abono WHERE (Id_Cliente = '" + HCliente + "') AND (Activo = 'S')";
                coman.CommandType = CommandType.Text;
                con.Open();
                dataGridView_HistorialAbonos.Rows.Clear();
                dr = coman.ExecuteReader();
                while (dr.Read())
                {
                    int Renglon = dataGridView_HistorialAbonos.Rows.Add();
                    dataGridView_HistorialAbonos.Rows[Renglon].Cells["Id_Abono"].Value = dr.GetInt32(dr.GetOrdinal("Id_Abono"));
                    dataGridView_HistorialAbonos.Rows[Renglon].Cells["Fecha"].Value = (dr.GetDateTime(dr.GetOrdinal("Fecha_Abono"))).ToShortDateString();
                    dataGridView_HistorialAbonos.Rows[Renglon].Cells["Cantidad"].Value = (dr.GetDecimal(dr.GetOrdinal("Cantidad"))).ToString("N");
                    dataGridView_HistorialAbonos.Rows[Renglon].Cells["N_Abono"].Value = dr.GetInt32(dr.GetOrdinal("N_Abono"));
                    dataGridView_HistorialAbonos.Rows[Renglon].Cells["Fecha_Prox"].Value = (dr.GetDateTime(dr.GetOrdinal("Prox_Fecha"))).ToShortDateString();
                    dataGridView_HistorialAbonos.Rows[Renglon].Cells["Saldo_Anterior"].Value = (dr.GetDecimal(dr.GetOrdinal("Saldo_Anterior"))).ToString("N");
                    dataGridView_HistorialAbonos.Rows[Renglon].Cells["Saldo_Actual"].Value = (dr.GetDecimal(dr.GetOrdinal("Saldo_Actual"))).ToString("N");
                }
                con.Close();
            }
            catch (Exception)
            {
                //EN CASO DE NO HABER DATOS NO REALIZAR NADA
            }
            
        }
        #endregion
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
