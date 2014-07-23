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

namespace Sistema_Shajobe
{
    public partial class F_VentasPedidos : Form
    {
        public F_VentasPedidos()
        {
            InitializeComponent();
        }
        #region Diseños de la forma
        #region Diseño del panel de Busqueda del producto
        #region Declarando Controles
        //Declarando controles
        private DataGridView data_resultado;
        private TextBox txt_Busqueda;
        private PictureBox pic_Lupa;
        private Button bttn_Busqueda;
        private Panel panel_Busqueda;
        private Label lbl_Etiqueta;
        //Declarando Columnas del DATAGRID
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Id;
        #endregion
        #region Diseño del panel de Busqueda
        private void Diseño_PanelBusqueda()
        {
            #region Creando Controles
            //INICIALIZANDO CONTROLES
            panel_Busqueda = new System.Windows.Forms.Panel();
            txt_Busqueda = new System.Windows.Forms.TextBox();
            data_resultado = new System.Windows.Forms.DataGridView();
            pic_Lupa = new System.Windows.Forms.PictureBox();
            bttn_Busqueda = new System.Windows.Forms.Button();
            lbl_Etiqueta = new System.Windows.Forms.Label();
            //groupBoxNivel.SuspendLayout();
            #endregion
            #region Dando diseño a los controles
            //INICIALIZANDO COLUMNAS
            Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            //DISEÑOS DE A LOS CONTROLES
            txt_Busqueda.Location = new System.Drawing.Point(130, 57);
            txt_Busqueda.Name = "txt_Busqueda";
            txt_Busqueda.Size = new System.Drawing.Size(124, 20);
            txt_Busqueda.TabIndex = 0;
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
            Id,
            Nombre,
            Descripcion});
            data_resultado.Location = new System.Drawing.Point(21, 136);
            data_resultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            data_resultado.Name = "data_resultado";
            data_resultado.RowHeadersWidth = 25;
            data_resultado.RowTemplate.Height = 50;
            data_resultado.Size = new System.Drawing.Size(470, 150);
            data_resultado.TabIndex = 2;
            data_resultado.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(data_resultado_MouseDoubleClick);
            //
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Visible = false;
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
            panel_Busqueda.BringToFront();
            #endregion
            #region Autocompletar
            //CARACTERISTICA DE AUTOCOMPLETADO EN TXT_BUSQUEDA
            txt_Busqueda.AutoCompleteCustomSource = Autocomplete();
            txt_Busqueda.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_Busqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;
            #endregion
        }
        #endregion
        #region Autocompletar Busqueda
        //-------------------------------------------------------------
        //----------------------AUTO COMPLETAR-------------------------
        //-------------------------------------------------------------
        #region Funcion Autocompletar
        //metodo para cargar la coleccion de datos para el autocomplete
        public static DataTable Datos()
        {
            DataTable dt = new DataTable();

            OleDbConnection conexion = new OleDbConnection(ObtenerString());//cadena conexion
            string consulta = "SELECT Nombre, Codigo_Barra  FROM Tb_Producto where Activo='S'";
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
        #endregion
        #endregion
        #region Diseño del panel de Pago
        #region Declarando controles para panel de Pago
        private System.Windows.Forms.Panel panel_Pago;
        private System.Windows.Forms.GroupBox groupBox_Pagar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_CambioP;
        private System.Windows.Forms.Button bttn_PagarP;
        private System.Windows.Forms.Label lbl_Cambio;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_TotalP;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_EfectivoP;
        private System.Windows.Forms.Label lbl_TotalP;
        private System.Windows.Forms.Label lbl_EfectivoP;
        private System.Windows.Forms.RadioButton radioButtonPedido;
        private System.Windows.Forms.RadioButton radioButtonVenta;
        #endregion
        private void bttn_Pagar_Click(object sender, EventArgs e)
        {
            #region Creando Panel de pago
            this.panel_Pago = new System.Windows.Forms.Panel();
            this.groupBox_Pagar = new System.Windows.Forms.GroupBox();
            this.radioButtonPedido = new System.Windows.Forms.RadioButton();
            this.maskedTextBox_CambioP = new System.Windows.Forms.MaskedTextBox();
            this.radioButtonVenta = new System.Windows.Forms.RadioButton();
            this.bttn_PagarP = new System.Windows.Forms.Button();
            this.lbl_Cambio = new System.Windows.Forms.Label();
            this.maskedTextBox_TotalP = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_EfectivoP = new System.Windows.Forms.MaskedTextBox();
            this.lbl_TotalP = new System.Windows.Forms.Label();
            this.lbl_EfectivoP = new System.Windows.Forms.Label();
            this.panel_Pago.SuspendLayout();
            this.groupBox_Pagar.SuspendLayout();
            this.SuspendLayout();
            #endregion
            #region Diseñando el panel de Pago
            // 
            // panel_Pago
            // 
            this.panel_Pago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Pago.Controls.Add(this.groupBox_Pagar);
            this.panel_Pago.Location = new System.Drawing.Point(94, 182);
            this.panel_Pago.Name = "panel_Pago";
            this.panel_Pago.Size = new System.Drawing.Size(327, 185);
            this.panel_Pago.TabIndex = 0;
            // 
            // groupBox_Pagar
            // 
            this.groupBox_Pagar.Controls.Add(this.radioButtonPedido);
            this.groupBox_Pagar.Controls.Add(this.maskedTextBox_CambioP);
            this.groupBox_Pagar.Controls.Add(this.radioButtonVenta);
            this.groupBox_Pagar.Controls.Add(this.bttn_PagarP);
            this.groupBox_Pagar.Controls.Add(this.lbl_Cambio);
            this.groupBox_Pagar.Controls.Add(this.maskedTextBox_TotalP);
            this.groupBox_Pagar.Controls.Add(this.maskedTextBox_EfectivoP);
            this.groupBox_Pagar.Controls.Add(this.lbl_TotalP);
            this.groupBox_Pagar.Controls.Add(this.lbl_EfectivoP);
            this.groupBox_Pagar.Location = new System.Drawing.Point(9, 7);
            this.groupBox_Pagar.Name = "groupBox_Pagar";
            this.groupBox_Pagar.Size = new System.Drawing.Size(306, 167);
            this.groupBox_Pagar.TabIndex = 7;
            this.groupBox_Pagar.TabStop = false;
            this.groupBox_Pagar.Text = "Realizar Venta ó Pedido";
            // 
            // radioButtonPedido
            // 
            this.radioButtonPedido.AutoSize = true;
            this.radioButtonPedido.Location = new System.Drawing.Point(19, 142);
            this.radioButtonPedido.Name = "radioButtonPedido";
            this.radioButtonPedido.Size = new System.Drawing.Size(114, 17);
            this.radioButtonPedido.TabIndex = 3;
            this.radioButtonPedido.TabStop = true;
            this.radioButtonPedido.Text = "Generar un Pedido";
            this.radioButtonPedido.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox_CambioP
            // 
            this.maskedTextBox_CambioP.Enabled = false;
            this.maskedTextBox_CambioP.Location = new System.Drawing.Point(104, 80);
            this.maskedTextBox_CambioP.Mask = "$999.99";
            this.maskedTextBox_CambioP.Name = "maskedTextBox_CambioP";
            this.maskedTextBox_CambioP.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_CambioP.TabIndex = 5;
            // 
            // radioButtonVenta
            // 
            this.radioButtonVenta.AutoSize = true;
            this.radioButtonVenta.Location = new System.Drawing.Point(19, 119);
            this.radioButtonVenta.Name = "radioButtonVenta";
            this.radioButtonVenta.Size = new System.Drawing.Size(94, 17);
            this.radioButtonVenta.TabIndex = 2;
            this.radioButtonVenta.TabStop = true;
            this.radioButtonVenta.Text = "Generar Venta";
            this.radioButtonVenta.UseVisualStyleBackColor = true;
            this.radioButtonVenta.Checked = true;
            // 
            // bttn_PagarP
            // 
            this.bttn_PagarP.Location = new System.Drawing.Point(225, 138);
            this.bttn_PagarP.Name = "bttn_PagarP";
            this.bttn_PagarP.Size = new System.Drawing.Size(75, 23);
            this.bttn_PagarP.TabIndex = 4;
            this.bttn_PagarP.Text = "Continuar";
            this.bttn_PagarP.UseVisualStyleBackColor = true;
            this.bttn_PagarP.Click += new System.EventHandler(this.bttn_PagarP_Click);
            // 
            // lbl_Cambio
            // 
            this.lbl_Cambio.AutoSize = true;
            this.lbl_Cambio.Location = new System.Drawing.Point(16, 87);
            this.lbl_Cambio.Name = "lbl_Cambio";
            this.lbl_Cambio.Size = new System.Drawing.Size(42, 13);
            this.lbl_Cambio.TabIndex = 6;
            this.lbl_Cambio.Text = "Cambio";
            // 
            // maskedTextBox_TotalP
            // 
            this.maskedTextBox_TotalP.Enabled = false;
            this.maskedTextBox_TotalP.Location = new System.Drawing.Point(104, 28);
            this.maskedTextBox_TotalP.Mask = "$999.99";
            this.maskedTextBox_TotalP.Name = "maskedTextBox_TotalP";
            this.maskedTextBox_TotalP.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_TotalP.TabIndex = 0;
            // 
            // maskedTextBox_EfectivoP
            // 
            this.maskedTextBox_EfectivoP.Location = new System.Drawing.Point(104, 54);
            this.maskedTextBox_EfectivoP.Mask = "$999.99";
            this.maskedTextBox_EfectivoP.Name = "maskedTextBox_EfectivoP";
            this.maskedTextBox_EfectivoP.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_EfectivoP.TabIndex = 1;
            this.maskedTextBox_EfectivoP.Focus();
            // 
            // lbl_TotalP
            // 
            this.lbl_TotalP.AutoSize = true;
            this.lbl_TotalP.Location = new System.Drawing.Point(16, 35);
            this.lbl_TotalP.Name = "lbl_TotalP";
            this.lbl_TotalP.Size = new System.Drawing.Size(31, 13);
            this.lbl_TotalP.TabIndex = 2;
            this.lbl_TotalP.Text = "Total";
            // 
            // lbl_EfectivoP
            // 
            this.lbl_EfectivoP.AutoSize = true;
            this.lbl_EfectivoP.Location = new System.Drawing.Point(16, 61);
            this.lbl_EfectivoP.Name = "lbl_EfectivoP";
            this.lbl_EfectivoP.Size = new System.Drawing.Size(46, 13);
            this.lbl_EfectivoP.TabIndex = 3;
            this.lbl_EfectivoP.Text = "Efectivo";
            // 
            // PanelPago
            // 
            this.Controls.Add(this.panel_Pago);
            this.Name = "PanelPago";
            this.Text = "PanelPago";
            this.panel_Pago.ResumeLayout(false);
            this.groupBox_Pagar.ResumeLayout(false);
            this.groupBox_Pagar.PerformLayout();
            panel_Pago.BringToFront();
            #endregion
        }
        private void bttn_PagarP_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Diseño de la ventana
        #region Declarando Controles
        private System.Windows.Forms.GroupBox groupBox_DatosCliente;
        private System.Windows.Forms.Label lbl_Clientes;
        private System.Windows.Forms.Label lbl_CodigoBarra;
        private System.Windows.Forms.TextBox txt_CodigoBarra;
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
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercadeToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_CodigoBarra;
        private System.Windows.Forms.GroupBox groupBox_Productos;
        private System.Windows.Forms.DataGridView dataGridView_Carrito;
        private System.Windows.Forms.Label lbl_Subtotal;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Subtotal;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Total;
        private System.Windows.Forms.Button bttn_Pagar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Descuento;
        private System.Windows.Forms.Label lbl_Descuento;
        private System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.ErrorProvider errorProvider_Textbox;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EliminarToolStripMenuItem;
        private System.Windows.Forms.Button btt_Buscar;
        private System.Windows.Forms.TextBox txt_Cliente;
        private System.Windows.Forms.DataGridView dataGridView_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_ClienteC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_PC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_MC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        #endregion
        private void Diseño_Forma()
        {
            #region Creando controles
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_VentasPedidos));
            this.groupBox_DatosCliente = new System.Windows.Forms.GroupBox();
            this.btt_Buscar = new System.Windows.Forms.Button();
            this.txt_Cliente = new System.Windows.Forms.TextBox();
            this.dataGridView_Cliente = new System.Windows.Forms.DataGridView();
            this.Id_ClienteC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_PC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_MC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Clientes = new System.Windows.Forms.Label();
            this.lbl_CodigoBarra = new System.Windows.Forms.Label();
            this.txt_CodigoBarra = new System.Windows.Forms.TextBox();
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
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_CodigoBarra = new System.Windows.Forms.GroupBox();
            this.groupBox_Productos = new System.Windows.Forms.GroupBox();
            this.dataGridView_Carrito = new System.Windows.Forms.DataGridView();
            this.Id_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Subtotal = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.maskedTextBox_Subtotal = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_Total = new System.Windows.Forms.MaskedTextBox();
            this.bttn_Pagar = new System.Windows.Forms.Button();
            this.maskedTextBox_Descuento = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Descuento = new System.Windows.Forms.Label();
            this.errorProvider_Textbox = new System.Windows.Forms.ErrorProvider(this.components);
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.groupBox_DatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cliente)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox_CodigoBarra.SuspendLayout();
            this.groupBox_Productos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Carrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Textbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
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
            this.groupBox_DatosCliente.Location = new System.Drawing.Point(12, 44);
            this.groupBox_DatosCliente.Name = "groupBox_DatosCliente";
            this.groupBox_DatosCliente.Size = new System.Drawing.Size(335, 171);
            this.groupBox_DatosCliente.TabIndex = 0;
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
            // 
            // txt_Cliente
            // 
            this.txt_Cliente.Location = new System.Drawing.Point(81, 22);
            this.txt_Cliente.MaxLength = 25;
            this.txt_Cliente.Name = "txt_Cliente";
            this.txt_Cliente.Size = new System.Drawing.Size(116, 20);
            this.txt_Cliente.TabIndex = 4;
            this.txt_Cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cliente_KeyPress);
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
            // lbl_CodigoBarra
            // 
            this.lbl_CodigoBarra.AutoSize = true;
            this.lbl_CodigoBarra.Location = new System.Drawing.Point(22, 29);
            this.lbl_CodigoBarra.Name = "lbl_CodigoBarra";
            this.lbl_CodigoBarra.Size = new System.Drawing.Size(82, 13);
            this.lbl_CodigoBarra.TabIndex = 1;
            this.lbl_CodigoBarra.Text = "Codigo de barra";
            // 
            // txt_CodigoBarra
            // 
            this.txt_CodigoBarra.Location = new System.Drawing.Point(22, 51);
            this.txt_CodigoBarra.MaxLength = 14;
            this.txt_CodigoBarra.Name = "txt_CodigoBarra";
            this.txt_CodigoBarra.Size = new System.Drawing.Size(100, 20);
            this.txt_CodigoBarra.TabIndex = 2;
            this.txt_CodigoBarra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CodigoBarra_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(514, 24);
            this.menuStrip1.TabIndex = 3;
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
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripMenuItem.Image")));
            this.abrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.abrirToolStripMenuItem.Text = "&Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
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
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
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
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // vistapreviadeimpresiónToolStripMenuItem
            // 
            this.vistapreviadeimpresiónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vistapreviadeimpresiónToolStripMenuItem.Image")));
            this.vistapreviadeimpresiónToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.vistapreviadeimpresiónToolStripMenuItem.Name = "vistapreviadeimpresiónToolStripMenuItem";
            this.vistapreviadeimpresiónToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.vistapreviadeimpresiónToolStripMenuItem.Text = "&Vista previa de impresión";
            this.vistapreviadeimpresiónToolStripMenuItem.Click += new System.EventHandler(this.vistapreviadeimpresiónToolStripMenuItem_Click);
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
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
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
            this.ModificarToolStripMenuItem.Click += new System.EventHandler(this.ModificarToolStripMenuItem_Click);
            // 
            // EliminarToolStripMenuItem
            // 
            this.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem";
            this.EliminarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.EliminarToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.EliminarToolStripMenuItem.Text = "&Eliminar";
            this.EliminarToolStripMenuItem.Click += new System.EventHandler(this.EliminarToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarProductoToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "&Herramientas";
            // 
            // buscarProductoToolStripMenuItem
            // 
            this.buscarProductoToolStripMenuItem.Name = "buscarProductoToolStripMenuItem";
            this.buscarProductoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.buscarProductoToolStripMenuItem.Text = "&Buscar producto";
            this.buscarProductoToolStripMenuItem.Click += new System.EventHandler(this.buscarProductoToolStripMenuItem_Click);
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
            this.acercadeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.acercadeToolStripMenuItem.Text = "&Acerca de...";
            // 
            // groupBox_CodigoBarra
            // 
            this.groupBox_CodigoBarra.Controls.Add(this.txt_CodigoBarra);
            this.groupBox_CodigoBarra.Controls.Add(this.lbl_CodigoBarra);
            this.groupBox_CodigoBarra.Location = new System.Drawing.Point(353, 44);
            this.groupBox_CodigoBarra.Name = "groupBox_CodigoBarra";
            this.groupBox_CodigoBarra.Size = new System.Drawing.Size(145, 100);
            this.groupBox_CodigoBarra.TabIndex = 4;
            this.groupBox_CodigoBarra.TabStop = false;
            this.groupBox_CodigoBarra.Text = "Codigo de barra";
            // 
            // groupBox_Productos
            // 
            this.groupBox_Productos.Controls.Add(this.dataGridView_Carrito);
            this.groupBox_Productos.Location = new System.Drawing.Point(13, 221);
            this.groupBox_Productos.Name = "groupBox_Productos";
            this.groupBox_Productos.Size = new System.Drawing.Size(489, 277);
            this.groupBox_Productos.TabIndex = 5;
            this.groupBox_Productos.TabStop = false;
            this.groupBox_Productos.Text = "Lista de productos dentro del carrito";
            // 
            // dataGridView_Carrito
            // 
            this.dataGridView_Carrito.AllowUserToDeleteRows = false;
            this.dataGridView_Carrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Carrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Carrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Producto,
            this.Producto,
            this.Cantidad,
            this.Precio});
            this.dataGridView_Carrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Carrito.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_Carrito.Name = "dataGridView_Carrito";
            this.dataGridView_Carrito.ReadOnly = true;
            this.dataGridView_Carrito.Size = new System.Drawing.Size(483, 258);
            this.dataGridView_Carrito.TabIndex = 6;
            this.dataGridView_Carrito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView_Carrito_KeyPress);
            // 
            // Id_Producto
            // 
            this.Id_Producto.HeaderText = "Id_Producto";
            this.Id_Producto.Name = "Id_Producto";
            this.Id_Producto.ReadOnly = true;
            this.Id_Producto.Visible = false;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
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
            // lbl_Subtotal
            // 
            this.lbl_Subtotal.AutoSize = true;
            this.lbl_Subtotal.Location = new System.Drawing.Point(225, 511);
            this.lbl_Subtotal.Name = "lbl_Subtotal";
            this.lbl_Subtotal.Size = new System.Drawing.Size(46, 13);
            this.lbl_Subtotal.TabIndex = 6;
            this.lbl_Subtotal.Text = "Subtotal";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(225, 544);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(31, 13);
            this.lbl_Total.TabIndex = 7;
            this.lbl_Total.Text = "Total";
            // 
            // maskedTextBox_Subtotal
            // 
            this.maskedTextBox_Subtotal.Enabled = false;
            this.maskedTextBox_Subtotal.Location = new System.Drawing.Point(298, 504);
            this.maskedTextBox_Subtotal.Mask = "$9999.00";
            this.maskedTextBox_Subtotal.Name = "maskedTextBox_Subtotal";
            this.maskedTextBox_Subtotal.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_Subtotal.TabIndex = 8;
            // 
            // maskedTextBox_Total
            // 
            this.maskedTextBox_Total.Enabled = false;
            this.maskedTextBox_Total.Location = new System.Drawing.Point(298, 537);
            this.maskedTextBox_Total.Mask = "$9999.00";
            this.maskedTextBox_Total.Name = "maskedTextBox_Total";
            this.maskedTextBox_Total.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_Total.TabIndex = 9;
            // 
            // bttn_Pagar
            // 
            this.bttn_Pagar.Location = new System.Drawing.Point(426, 573);
            this.bttn_Pagar.Name = "bttn_Pagar";
            this.bttn_Pagar.Size = new System.Drawing.Size(75, 23);
            this.bttn_Pagar.TabIndex = 10;
            this.bttn_Pagar.Text = "Pagar";
            this.bttn_Pagar.UseVisualStyleBackColor = true;
            this.bttn_Pagar.Click += new System.EventHandler(this.bttn_Pagar_Click);
            // 
            // maskedTextBox_Descuento
            // 
            this.maskedTextBox_Descuento.Location = new System.Drawing.Point(298, 573);
            this.maskedTextBox_Descuento.Mask = "99%";
            this.maskedTextBox_Descuento.Name = "maskedTextBox_Descuento";
            this.maskedTextBox_Descuento.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_Descuento.TabIndex = 12;
            this.maskedTextBox_Descuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBox_Descuento_KeyPress);
            // 
            // lbl_Descuento
            // 
            this.lbl_Descuento.AutoSize = true;
            this.lbl_Descuento.Location = new System.Drawing.Point(225, 580);
            this.lbl_Descuento.Name = "lbl_Descuento";
            this.lbl_Descuento.Size = new System.Drawing.Size(59, 13);
            this.lbl_Descuento.TabIndex = 11;
            this.lbl_Descuento.Text = "Descuento";
            // 
            // errorProvider_Textbox
            // 
            this.errorProvider_Textbox.ContainerControl = this;
            // 
            // pic_Logo
            // 
            this.pic_Logo.BackgroundImage = global::Sistema_Shajobe.Properties.Resources.Logo_Shajobe;
            this.pic_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Logo.Location = new System.Drawing.Point(15, 511);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(181, 85);
            this.pic_Logo.TabIndex = 13;
            this.pic_Logo.TabStop = false;
            // 
            // F_VentasPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 607);
            this.Controls.Add(this.pic_Logo);
            this.Controls.Add(this.maskedTextBox_Descuento);
            this.Controls.Add(this.lbl_Descuento);
            this.Controls.Add(this.bttn_Pagar);
            this.Controls.Add(this.maskedTextBox_Total);
            this.Controls.Add(this.maskedTextBox_Subtotal);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_Subtotal);
            this.Controls.Add(this.groupBox_Productos);
            this.Controls.Add(this.groupBox_CodigoBarra);
            this.Controls.Add(this.groupBox_DatosCliente);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(530, 645);
            this.MinimumSize = new System.Drawing.Size(530, 645);
            this.Name = "F_VentasPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas - Pedidos ";
            this.Load += new System.EventHandler(this.F_VentasPedidos_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.F_VentasPedidos_KeyPress);
            this.groupBox_DatosCliente.ResumeLayout(false);
            this.groupBox_DatosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cliente)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_CodigoBarra.ResumeLayout(false);
            this.groupBox_CodigoBarra.PerformLayout();
            this.groupBox_Productos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Carrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Textbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            #endregion
        }
        #endregion
        #endregion
        private void F_VentasPedidos_Load(object sender, EventArgs e)
        {
            #region Animacion
            AnimateWindow(Handle, 350, AnimateWindowFlags.AW_CENTER);
            AnimateWindow(Handle, 450, AnimateWindowFlags.AW_CENTER | AnimateWindowFlags.AW_SLIDE);
            ResumeLayout(false);
            PerformLayout();
            #endregion
            Diseño_Forma();
            //LLENANDO DE DATOS EL COMBOBOX
            txt_CodigoBarra.Focus();
            groupBox_Productos.SendToBack();
            txt_CodigoBarra.Focus();
        }
        #region Eventos
        //-------------------------------------------------------------
        //------------------Variables y Arreglos-----------------------
        //-------------------------------------------------------------
        private TextBox[] Campos = new TextBox[5];
        private ComboBox[] CamposC = new ComboBox[1];
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
            coman.CommandText = "SELECT Tb_Producto.Nombre, Tb_Producto.Descripcion,  Tb_Producto.Codigo_Barra,  Tb_NivelProducto.Id_Unidadmedida AS Id_UnidadmedidaN, Tb_NivelProducto.N_Max, Tb_NivelProducto.N_Min FROM Tb_Producto INNER JOIN Tb_NivelProducto ON Tb_Producto.Id_Producto = Tb_NivelProducto.Id_Producto where Tb_Producto.Id_Producto='" + Idp + "'";
            coman.CommandType = CommandType.Text;
            con.Open();
            data_resultado.Rows.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {

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
                coman.CommandText = "SELECT Id_Producto, Nombre, Descripcion FROM Tb_Producto WHERE (Tb_Producto.Activo = 'S') and (Tb_Producto.Nombre='" + busqueda.ToUpper() + "'OR Tb_Producto.Codigo_Barra='" + busqueda.ToUpper() + "')";
                coman.CommandType = CommandType.Text;
                con.Open();
                data_resultado.Rows.Clear();
                dr = coman.ExecuteReader();
                while (dr.Read())
                {
                    int Renglon = data_resultado.Rows.Add();
                    Idp = dr.GetInt32(dr.GetOrdinal("Id_Producto"));
                    data_resultado.Rows[Renglon].Cells["Id"].Value = dr.GetInt32(dr.GetOrdinal("Id_Producto"));
                    data_resultado.Rows[Renglon].Cells["Nombre"].Value = dr.GetString(dr.GetOrdinal("Nombre"));
                    data_resultado.Rows[Renglon].Cells["Descripcion"].Value = dr.GetString(dr.GetOrdinal("Descripcion"));

                }
                con.Close();
            }
        }
        private void bttn_Busqueda_Click(object sender, EventArgs e)
        {
            Busqueda();
        }
        #region Busqueda Abrir

        private void data_resultadoV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Idp = Convert.ToInt32(data_resultado.CurrentRow.Cells["Id"].Value);
            Limpiar();
            BusquedaDatosV(Idp);
            //Quito el panel de busqueda
            Controls.Remove(panel_Busqueda);
        }
        public void BusquedaDatosV(int Idp)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "SELECT Tb_Producto.Nombre, Tb_Producto.Descripcion,  Tb_Producto.Codigo_Barra,  Tb_NivelProducto.Id_Unidadmedida AS Id_UnidadmedidaN, Tb_NivelProducto.N_Max, Tb_NivelProducto.N_Min FROM Tb_Producto INNER JOIN Tb_NivelProducto ON Tb_Producto.Id_Producto = Tb_NivelProducto.Id_Producto where Tb_Producto.Id_Producto='" + Idp + "'";
            coman.CommandType = CommandType.Text;
            con.Open();
            data_resultadoV.Rows.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {

            }
            con.Close();
        }
        private void BusquedaV()
        {
            if (txt_BusquedaV.Text.Trim() == "")
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
                string busqueda = txt_BusquedaV.Text;
                txt_BusquedaV.Text = busqueda.ToUpper();
                coman.CommandText = "SELECT Id_Producto, Nombre, Descripcion FROM Tb_Producto WHERE (Tb_Producto.Activo = 'S') and (Tb_Producto.Nombre='" + busqueda.ToUpper() + "'OR Tb_Producto.Codigo_Barra='" + busqueda.ToUpper() + "')";
                coman.CommandType = CommandType.Text;
                con.Open();
                data_resultadoV.Rows.Clear();
                dr = coman.ExecuteReader();
                while (dr.Read())
                {
                    int Renglon = data_resultadoV.Rows.Add();
                    Idp = dr.GetInt32(dr.GetOrdinal("Id_Producto"));
                    data_resultadoV.Rows[Renglon].Cells["Id"].Value = dr.GetInt32(dr.GetOrdinal("Id_Producto"));
                    data_resultadoV.Rows[Renglon].Cells["Nombre"].Value = dr.GetString(dr.GetOrdinal("Nombre"));
                    data_resultadoV.Rows[Renglon].Cells["Descripcion"].Value = dr.GetString(dr.GetOrdinal("Descripcion"));

                }
                con.Close();
            }
        }
        private void bttn_BusquedaV_Click(object sender, EventArgs e)
        {
            BusquedaV();
        }
        #endregion
        #endregion
        //-------------------------------------------------------------
        //----------------CONFIGURACION DE CONTROLES-------------------
        //-------------------------------------------------------------
        #region Funcion A, B y C
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void ModificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void EliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region  Funciones N, A, S, D
        #region Nuevo
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Se manda a llamar el metodo de Limpiar para restrablecer los campos de la forma
            Limpiar();
        }
        private void Limpiar()
        {
            txt_CodigoBarra.Clear();
            maskedTextBox_Descuento.Clear();
            maskedTextBox_Subtotal.Clear();
            maskedTextBox_Total.Clear();
            dataGridView_Carrito.Rows.Clear();
            #region Quitar panel de Busqueda de Productos
            try
            {
                //Controls.RemoveAt();
            }
            catch (Exception)
            {
                //En caso de que no exista se omite esta instrucción
                throw;
            }
            #endregion
            #region Quitar el panel de Pagar
            try
            {
                //Controls.RemoveAt();
            }
            catch (Exception)
            {
                //En caso de que no exista se omite esta instrucción
                throw;
            }
            #endregion
        }
        #endregion
        #region Abrir
        #region Declarando Controles
        private DataGridView data_resultadoV;
        private TextBox txt_BusquedaV;
        private PictureBox pic_LupaV;
        private Button bttn_BusquedaV;
        private Panel panel_BusquedaV;
        private Label lbl_EtiquetaV;
        //Creando Columnas del DATAGRID
        private DataGridViewTextBoxColumn RFCV;
        private DataGridViewTextBoxColumn Nombre_ContactoV;
        private DataGridViewTextBoxColumn Apellido_MV;
        private DataGridViewTextBoxColumn Apellido_PV;
        private DataGridViewTextBoxColumn NombreV;
        private DataGridViewTextBoxColumn IdV;
        #endregion
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //INICIALIZANDO CONTROLES
            panel_BusquedaV = new System.Windows.Forms.Panel();
            txt_BusquedaV = new System.Windows.Forms.TextBox();
            data_resultadoV = new System.Windows.Forms.DataGridView();
            pic_LupaV = new System.Windows.Forms.PictureBox();
            bttn_BusquedaV = new System.Windows.Forms.Button();
            lbl_EtiquetaV = new System.Windows.Forms.Label();
            //groupBoxfoto.SuspendLayout();
            //INICIALIZANDO COLUMNAS
            RFCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombre_ContactoV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Apellido_MV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Apellido_PV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NombreV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            IdV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            //DISEÑOS DE A LOS CONTROLES
            txt_BusquedaV.Location = new System.Drawing.Point(130, 57);
            txt_BusquedaV.Name = "txt_Busqueda";
            txt_BusquedaV.Size = new System.Drawing.Size(124, 20);
            txt_BusquedaV.TabIndex = 0;
            txt_BusquedaV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_BusquedaV_KeyPress);
            // 
            // pic_Lupa
            // 
            //pic_LupaV.BackgroundImage = ((System.Drawing.Image)(global::Sistema_Shajobe.Properties.Resources.lupa));
            pic_LupaV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pic_LupaV.Location = new System.Drawing.Point(21, 19);
            pic_LupaV.Name = "pic_Lupa";
            pic_LupaV.Size = new System.Drawing.Size(100, 101);
            pic_LupaV.TabIndex = 1;
            pic_LupaV.TabStop = false;
            // 
            // data_resultado
            // 
            data_resultadoV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_resultadoV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            IdV,
            NombreV,
            Apellido_PV,
            Apellido_MV,
            Nombre_ContactoV,
            RFCV});
            data_resultadoV.Location = new System.Drawing.Point(21, 136);
            data_resultadoV.Name = "data_resultado";
            data_resultadoV.RowHeadersWidth = 25;
            data_resultadoV.RowTemplate.Height = 50;
            data_resultadoV.Size = new System.Drawing.Size(526, 339);
            data_resultadoV.TabIndex = 2;
            data_resultadoV.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(data_resultadoV_MouseDoubleClick);
            // 
            // RFC
            // 
            RFCV.HeaderText = "RFC";
            RFCV.Name = "RFC";
            // 
            // Nombre_Contacto
            // 
            Nombre_ContactoV.HeaderText = "Nombre_Contacto";
            Nombre_ContactoV.Name = "Nombre_Contacto";
            // 
            // Apellido_M
            // 
            Apellido_MV.HeaderText = "Apellido_M";
            Apellido_MV.Name = "Apellido_M";
            // 
            // Apellido_P
            // 
            Apellido_PV.HeaderText = "Apellido_P";
            Apellido_PV.Name = "Apellido_P";
            // 
            // Nombre
            // 
            NombreV.HeaderText = "Nombre";
            NombreV.Name = "Nombre";
            // 
            // Id
            // 
            IdV.HeaderText = "Id";
            IdV.Name = "Id";
            IdV.Visible = false;
            // 
            // lbl_Etiqueta
            // 
            lbl_EtiquetaV.AutoSize = true;
            lbl_EtiquetaV.Location = new System.Drawing.Point(127, 26);
            lbl_EtiquetaV.Name = "lbl_Etiqueta";
            lbl_EtiquetaV.Size = new System.Drawing.Size(419, 13);
            lbl_EtiquetaV.TabIndex = 3;
            lbl_EtiquetaV.Text = "Escriba el nombre, uno de los apellidos, nombre de contacto ó RFC del cliente" +
                "a buscar";
            // 
            // bttn_Busqueda
            // 
            //bttn_BusquedaV.BackgroundImage = ((System.Drawing.Image)(global::Sistema_Shajobe.Properties.Resources.Siguiente));
            bttn_BusquedaV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            bttn_BusquedaV.Location = new System.Drawing.Point(274, 48);
            bttn_BusquedaV.Name = "bttn_Busqueda";
            bttn_BusquedaV.Size = new System.Drawing.Size(62, 54);
            bttn_BusquedaV.TabIndex = 4;
            bttn_BusquedaV.UseVisualStyleBackColor = true;
            bttn_BusquedaV.Click += new System.EventHandler(bttn_Busqueda_Click);
            // 
            // panel_Busqueda
            // 
            panel_BusquedaV.Controls.Add(bttn_Busqueda);
            panel_BusquedaV.Controls.Add(lbl_Etiqueta);
            panel_BusquedaV.Controls.Add(data_resultado);
            panel_BusquedaV.Controls.Add(pic_Lupa);
            panel_BusquedaV.Controls.Add(txt_Busqueda);
            panel_BusquedaV.Enabled = false;
            panel_BusquedaV.Location = new System.Drawing.Point(12, 88);
            panel_BusquedaV.Name = "panel_Busqueda";
            panel_BusquedaV.Size = new System.Drawing.Size(568, 496);
            panel_BusquedaV.TabIndex = 35;
            panel_BusquedaV.Visible = false;
            //CARACTERISTICA DE AUTOCOMPLETADO EN TXT_BUSQUEDA
            txt_BusquedaV.AutoCompleteCustomSource = Autocomplete();
            txt_BusquedaV.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_BusquedaV.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Controls.Add(panel_BusquedaV);
            panel_BusquedaV.Visible = true;
            panel_BusquedaV.Enabled = true;
        }
        #endregion
        #region Salir
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Calcular porcentaje
        private void maskedTextBox_Descuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                //Conversion de porcentaje en decimal
                string Valor = maskedTextBox_Descuento.Text;
                Valor = Valor.Substring(0, 2);
                decimal Porcentaje = Convert.ToDecimal(Valor);
                decimal Resultado = Porcentaje / 100;
                txt_CodigoBarra.Focus();
                MessageBox.Show("Descuento de la compra del: " + Resultado.ToString());
            }
        }
        #endregion
        #endregion
        #region Quitar elementos de carrito
        private void dataGridView_Carrito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Delete)
            {
                DialogResult dialogResult = MessageBox.Show("Deseas realmente quitar este producto del carrito", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    dataGridView_Carrito.Rows.RemoveAt(dataGridView_Carrito.CurrentRow.Index);
                }
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
        //-------------------VALIDACION DE CAMPOS----------------------
        //-------------------------------------------------------------
        private void txt_Busqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de letras-----------------------------------------------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto-------------------------- Uso del espacio
            if ((e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47) && (e.KeyChar < 31 || e.KeyChar > 33))
            {
                MessageBox.Show("Solo se aceptan letras", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void txt_BusquedaV_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de letras-----------------------------------------------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto-------------------------- Uso del espacio
            if ((e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47) && (e.KeyChar < 31 || e.KeyChar > 33))
            {
                MessageBox.Show("Solo se aceptan letras", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void txt_CodigoBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de numeros-------------Apartado de teclas especiales Retroceso y suprimir
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128))
            {
                MessageBox.Show("Solo se aceptan numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
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
        private void buscarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Metodo para llamar el diseño del panel de Busqueda de producto
            Diseño_PanelBusqueda();
        }
        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void vistapreviadeimpresiónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void txt_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void F_VentasPedidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.F10)//FUNCION DE BUSQUEDA DE PRODUCTOS 
            {
                #region Codigo para Generar el panel de Busqueda del producto

                #endregion
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