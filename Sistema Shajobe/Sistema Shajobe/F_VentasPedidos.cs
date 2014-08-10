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
        private TextBox txt_BusquedaProducto;
        private PictureBox pic_Lupa;
        private Button bttn_Busqueda;
        private Panel panel_BusquedaProducto;
        private Label lbl_Etiqueta;
        //Declarando Columnas del DATAGRID
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Id;
        #endregion
        #region Diseño del panel de Busqueda Producto
        private void Diseño_PanelBusqueda()
        {
            #region Creando Controles
            //INICIALIZANDO CONTROLES
            panel_BusquedaProducto = new System.Windows.Forms.Panel();
            txt_BusquedaProducto = new System.Windows.Forms.TextBox();
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
            txt_BusquedaProducto.Location = new System.Drawing.Point(130, 57);
            txt_BusquedaProducto.Name = "txt_BusquedaProducto";
            txt_BusquedaProducto.Size = new System.Drawing.Size(124, 20);
            txt_BusquedaProducto.TabIndex = 0;
            txt_BusquedaProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_BusquedaProducto_KeyPress);
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
            data_resultado.RowTemplate.Height = 25;
            data_resultado.Size = new System.Drawing.Size(390, 170);
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
            // panel_BusquedaProducto
            // 
            panel_BusquedaProducto.Controls.Add(bttn_Busqueda);
            panel_BusquedaProducto.Controls.Add(lbl_Etiqueta);
            panel_BusquedaProducto.Controls.Add(data_resultado);
            panel_BusquedaProducto.Controls.Add(pic_Lupa);
            panel_BusquedaProducto.Controls.Add(txt_BusquedaProducto);
            panel_BusquedaProducto.BorderStyle = BorderStyle.FixedSingle;
            panel_BusquedaProducto.Enabled = true;
            panel_BusquedaProducto.Location = new System.Drawing.Point(40, 120);
            panel_BusquedaProducto.Name = "panel_BusquedaProducto";
            panel_BusquedaProducto.Size = new System.Drawing.Size(435, 321);
            panel_BusquedaProducto.TabIndex = 35;
            panel_BusquedaProducto.Visible = true;
            txt_BusquedaProducto.Clear();
            data_resultado.Rows.Clear();
            Controls.Add(panel_BusquedaProducto);
            panel_BusquedaProducto.BringToFront();
            #endregion
            #region Autocompletar Producto
            //CARACTERISTICA DE AUTOCOMPLETADO EN txt_BusquedaProducto
            txt_BusquedaProducto.AutoCompleteCustomSource = Autocomplete();
            txt_BusquedaProducto.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_BusquedaProducto.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_BusquedaProducto.Focus();
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
            string consulta = "SELECT Tb_Producto.Nombre, Tb_Producto.Codigo_Barra FROM Tb_Producto INNER JOIN Tb_Inventarioproductodetalle ON Tb_Producto.Id_Producto = Tb_Inventarioproductodetalle.Id_Producto WHERE (Tb_Producto.Activo = 'S')";
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
        private System.Windows.Forms.TextBox TextBox_CambioP;
        private System.Windows.Forms.Button bttn_PagarP;
        private System.Windows.Forms.Label lbl_Cambio;
        private System.Windows.Forms.TextBox TextBox_TotalP;
        private System.Windows.Forms.TextBox TextBox_EfectivoP;
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
            this.TextBox_CambioP = new System.Windows.Forms.TextBox();
            this.radioButtonVenta = new System.Windows.Forms.RadioButton();
            this.bttn_PagarP = new System.Windows.Forms.Button();
            this.lbl_Cambio = new System.Windows.Forms.Label();
            this.TextBox_TotalP = new System.Windows.Forms.TextBox();
            this.TextBox_EfectivoP = new System.Windows.Forms.TextBox();
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
            this.groupBox_Pagar.Controls.Add(this.TextBox_CambioP);
            this.groupBox_Pagar.Controls.Add(this.radioButtonVenta);
            this.groupBox_Pagar.Controls.Add(this.bttn_PagarP);
            this.groupBox_Pagar.Controls.Add(this.lbl_Cambio);
            this.groupBox_Pagar.Controls.Add(this.TextBox_TotalP);
            this.groupBox_Pagar.Controls.Add(this.TextBox_EfectivoP);
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
            // TextBox_CambioP
            // 
            this.TextBox_CambioP.Enabled = false;
            this.TextBox_CambioP.Location = new System.Drawing.Point(104, 80);
            this.TextBox_CambioP.Name = "TextBox_CambioP";
            this.TextBox_CambioP.Size = new System.Drawing.Size(100, 20);
            this.TextBox_CambioP.TabIndex = 5;
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
            // TextBox_TotalP
            // 
            this.TextBox_TotalP.Enabled = false;
            this.TextBox_TotalP.Location = new System.Drawing.Point(104, 28);
            this.TextBox_TotalP.Name = "TextBox_TotalP";
            this.TextBox_TotalP.Size = new System.Drawing.Size(100, 20);
            this.TextBox_TotalP.TabIndex = 0;
            // 
            // TextBox_EfectivoP
            // 
            this.TextBox_EfectivoP.Location = new System.Drawing.Point(104, 54);
            this.TextBox_EfectivoP.Name = "TextBox_EfectivoP";
            this.TextBox_EfectivoP.Size = new System.Drawing.Size(100, 20);
            this.TextBox_EfectivoP.TabIndex = 1;
            this.TextBox_EfectivoP.Focus();
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
            OleDbConnection conexion = null;
            OleDbTransaction transaccion = null;
            if (radioButtonPedido.Checked==true)
            {
                
            }
            else if(radioButtonVenta.Checked==true)
            {
                bool i = Verificar_CamposVacios();
                if (i == true)
                    MessageBox.Show("Inserta todos los datos marcados", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    try
                    {
                        conexion = new OleDbConnection(ObtenerString());
                        conexion.Open();
                        transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                        OleDbCommand comando = new OleDbCommand("SP_Venta_Alta", conexion, transaccion);
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@Id_Cliente", Convert.ToInt32(dataGridView_Cliente.CurrentRow.Cells["Id_ClienteC"].Value));
                        comando.Parameters.AddWithValue("@Cantidad_Articulos", Convert.ToDecimal(TextBox_TotalP.Text));//Corregir este campo
                        comando.Parameters.AddWithValue("@Total", Convert.ToDecimal(TextBox_TotalP.Text));
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
        private System.Windows.Forms.TextBox TextBox_Subtotal;
        private System.Windows.Forms.TextBox TextBox_Total;
        private System.Windows.Forms.Button bttn_Pagar;
        private System.Windows.Forms.TextBox TextBox_Descuento;
        private System.Windows.Forms.Label lbl_Descuento;
        private System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.ErrorProvider errorProvider_Textbox;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
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
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.TextBox_Subtotal = new System.Windows.Forms.TextBox();
            this.TextBox_Total = new System.Windows.Forms.TextBox();
            this.bttn_Pagar = new System.Windows.Forms.Button();
            this.TextBox_Descuento = new System.Windows.Forms.TextBox();
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
            this.btt_Buscar.Click += new System.EventHandler(bttn_BusquedaCliente_Click);
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
            this.dataGridView_Cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(dataGridView_ClienteKeyPress);
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
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(186)))), ((int)(((byte)(82)))));
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
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
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
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
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
            this.EliminarToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "&Editar";
            // 
            // EliminarToolStripMenuItem
            // 
            this.EliminarToolStripMenuItem.Enabled = false;
            this.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem";
            this.EliminarToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Borrar;
            this.EliminarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.EliminarToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.EliminarToolStripMenuItem.Text = "&Devolución";
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
            this.buscarProductoToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.lupa;
            this.buscarProductoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.buscarProductoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
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
            // TextBox_Subtotal
            // 
            this.TextBox_Subtotal.Enabled = false;
            this.TextBox_Subtotal.Location = new System.Drawing.Point(298, 504);
            this.TextBox_Subtotal.Name = "TextBox_Subtotal";
            this.TextBox_Subtotal.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Subtotal.TabIndex = 8;
            // 
            // TextBox_Total
            // 
            this.TextBox_Total.Enabled = false;
            this.TextBox_Total.Location = new System.Drawing.Point(298, 537);
            this.TextBox_Total.Name = "TextBox_Total";
            this.TextBox_Total.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Total.TabIndex = 9;
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
            // TextBox_Descuento
            // 
            this.TextBox_Descuento.Location = new System.Drawing.Point(298, 573);
            this.TextBox_Descuento.Name = "TextBox_Descuento";
            this.TextBox_Descuento.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Descuento.TabIndex = 12;
            this.TextBox_Descuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Descuento_KeyPress);
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
            this.Controls.Add(this.TextBox_Descuento);
            this.Controls.Add(this.lbl_Descuento);
            this.Controls.Add(this.bttn_Pagar);
            this.Controls.Add(this.TextBox_Total);
            this.Controls.Add(this.TextBox_Subtotal);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_Subtotal);
            this.Controls.Add(this.groupBox_Productos);
            this.Controls.Add(this.groupBox_CodigoBarra);
            this.Controls.Add(this.groupBox_DatosCliente);
            this.Controls.Add(this.menuStrip1);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(196)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(F_VentasPedidos_FormClosing);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(530, 645);
            this.MinimumSize = new System.Drawing.Size(530, 645);
            this.Icon = global::Sistema_Shajobe.Properties.Resources.Compra_ICO;
            this.Name = "F_VentasPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas - Pedidos ";
            this.Load += new System.EventHandler(this.F_VentasPedidos_Load);
            //this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.F_VentasPedidos_KeyPress);
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
        private bool Espacios_Vacios = false;
        private ComboBox[] CamposC = new ComboBox[3];
        //-------------------------------------------------------------
        //------------------BUSQUEDA DEL SISTEMA-----------------------
        //-------------------------------------------------------------
        #region Busquedas del sistema
        #region Busqueda Producto
        private void buscarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Metodo para llamar el diseño del panel de Busqueda de producto
            Diseño_PanelBusqueda();
        }
        private void data_resultado_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Idp = Convert.ToInt32(data_resultado.CurrentRow.Cells["Id"].Value);
            BusquedaDatos(Idp);
            //Quito el panel de busqueda
            panel_BusquedaProducto.Dispose();
            Controls.Remove(panel_BusquedaProducto);
            txt_CodigoBarra.Focus();
        }
        private void Busqueda()
        {
            if (txt_BusquedaProducto.Text.Trim() == "")
            {
                errorProvider_Textbox.SetError(txt_BusquedaProducto, "No puedes dejar el campo vacio");
                MessageBox.Show("Inserta todos los datos marcados", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OleDbConnection con = new OleDbConnection();
                OleDbCommand coman = new OleDbCommand();
                OleDbDataReader dr;
                con.ConnectionString = ObtenerString();
                coman.Connection = con;
                string busqueda = txt_BusquedaProducto.Text;
                txt_BusquedaProducto.Text = busqueda.ToUpper();
                coman.CommandText = "SELECT Tb_Inventarioproductodetalle.Id_Producto, Tb_Producto.Nombre, Tb_Producto.Descripcion, Tb_Producto.Codigo_Barra FROM Tb_Producto INNER JOIN Tb_Inventarioproductodetalle ON Tb_Producto.Id_Producto = Tb_Inventarioproductodetalle.Id_Producto WHERE (Tb_Producto.Nombre = '" + busqueda.ToUpper() + "') OR (Tb_Producto.Codigo_Barra = '" + busqueda.ToUpper() + "') AND (Tb_Producto.Activo = 'S')";
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
        public void BusquedaDatos(int Idp)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "SELECT Tb_Inventarioproductodetalle.Id_Producto, Tb_Producto.Nombre, Tb_Producto.Descripcion, Tb_Inventarioproductodetalle.Precio_Venta FROM Tb_Producto INNER JOIN Tb_Inventarioproductodetalle ON Tb_Producto.Id_Producto = Tb_Inventarioproductodetalle.Id_Producto WHERE (Tb_Producto.Activo = 'S') AND (Tb_Inventarioproductodetalle.Id_Producto = '" + Idp + "')";
            coman.CommandType = CommandType.Text;
            con.Open();
            //dataGridView_Carrito.Rows.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                int Renglon = dataGridView_Carrito.Rows.Add();
                Idp = dr.GetInt32(dr.GetOrdinal("Id_Producto"));
                dataGridView_Carrito.Rows[Renglon].Cells["Id_Producto"].Value = dr.GetInt32(dr.GetOrdinal("Id_Producto"));
                dataGridView_Carrito.Rows[Renglon].Cells["Producto"].Value = dr.GetString(dr.GetOrdinal("Nombre"));
                dataGridView_Carrito.Rows[Renglon].Cells["Cantidad"].Value = 1;
                dataGridView_Carrito.Rows[Renglon].Cells["Precio"].Value = dr.GetDecimal(dr.GetOrdinal("Precio_Venta")).ToString("N");
            }
            con.Close();
        }
        #endregion
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
            string consulta = "SELECT * FROM Tb_Cliente where Activo='S'"; //consulta a la tabla paises
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
        #endregion
        //-------------------------------------------------------------
        //------------------DATAGRIDVIEW BUSQUEDA----------------------
        //-------------------------------------------------------------       

        //-------------------------------------------------------------
        //----------------CONFIGURACION DE CONTROLES-------------------
        //-------------------------------------------------------------
        #region Funcion B
        private void EliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarToolStripMenuItem.Enabled = false;
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
            TextBox_Descuento.Clear();
            TextBox_Subtotal.Clear();
            TextBox_Total.Clear();
            dataGridView_Carrito.Rows.Clear();
            txt_Cliente.Clear();
            dataGridView_Cliente.Rows.Clear();
            errorProvider_Textbox.Clear();
            groupBox_CodigoBarra.Visible = true;
            groupBox_Productos.Visible = true;
            groupBox_DatosCliente.Visible = true;
            #region Quitar panel de Busqueda de Productos
            try
            {
                Controls.Remove(panel_BusquedaProducto);
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
                Controls.Remove(panel_Pago);
            }
            catch (Exception)
            {
                //En caso de que no exista se omite esta instrucción
                throw;
            }
            #endregion
            #region Quitar el panel de Devolucion
            try
            {
                Controls.Remove(panel_Devolucion);
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
        private System.Windows.Forms.Panel panel_Devolucion;
        private System.Windows.Forms.GroupBox groupBox_ListadeVentas;
        private System.Windows.Forms.DataGridView dataGridView_ListaVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Ventab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fechab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Articulosb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totalb;
        private System.Windows.Forms.GroupBox groupBox_DatosClienteb;
        private System.Windows.Forms.Button btt_Buscarb;
        private System.Windows.Forms.TextBox txt_Clienteb;
        private System.Windows.Forms.DataGridView dataGridView_ClienteBusq;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_ClienteCb;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_PCb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_MCb;
        private System.Windows.Forms.Label lbl_Clientesb;
        private System.Windows.Forms.Label lbl_Titulob;
        #endregion
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Creando controles
            this.panel_Devolucion = new System.Windows.Forms.Panel();
            this.groupBox_ListadeVentas = new System.Windows.Forms.GroupBox();
            this.dataGridView_ListaVentas = new System.Windows.Forms.DataGridView();
            this.groupBox_DatosClienteb = new System.Windows.Forms.GroupBox();
            this.btt_Buscarb = new System.Windows.Forms.Button();
            this.txt_Clienteb = new System.Windows.Forms.TextBox();
            this.dataGridView_ClienteBusq = new System.Windows.Forms.DataGridView();
            this.Id_ClienteCb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_PCb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_MCb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Clientesb = new System.Windows.Forms.Label();
            this.Id_Ventab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fechab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Articulosb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totalb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Titulob = new System.Windows.Forms.Label();
            this.panel_Devolucion.SuspendLayout();
            this.groupBox_ListadeVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListaVentas)).BeginInit();
            this.groupBox_DatosClienteb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ClienteBusq)).BeginInit();
            this.SuspendLayout();
            #endregion
            #region Diseñando controles
            // 
            // panel_Devolucion
            // 
            this.panel_Devolucion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Devolucion.Controls.Add(this.lbl_Titulob);
            this.panel_Devolucion.Controls.Add(this.groupBox_ListadeVentas);
            this.panel_Devolucion.Controls.Add(this.groupBox_DatosClienteb);
            this.panel_Devolucion.Location = new System.Drawing.Point(26, 30);
            this.panel_Devolucion.Name = "panel_Devolucion";
            this.panel_Devolucion.Size = new System.Drawing.Size(461, 457);
            this.panel_Devolucion.TabIndex = 0;
            this.panel_Devolucion.BringToFront();
            // 
            // groupBox_ListadeVentas
            // 
            this.groupBox_ListadeVentas.Controls.Add(this.dataGridView_ListaVentas);
            this.groupBox_ListadeVentas.Location = new System.Drawing.Point(5, 206);
            this.groupBox_ListadeVentas.Name = "groupBox_ListadeVentas";
            this.groupBox_ListadeVentas.Size = new System.Drawing.Size(451, 246);
            this.groupBox_ListadeVentas.TabIndex = 7;
            this.groupBox_ListadeVentas.TabStop = false;
            this.groupBox_ListadeVentas.Text = "Lista de compras";
            // 
            // dataGridView_ListaVentas
            // 
            this.dataGridView_ListaVentas.AllowUserToDeleteRows = false;
            this.dataGridView_ListaVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ListaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListaVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Ventab,
            this.Fechab,
            this.Cantidad_Articulosb,
            this.Totalb});
            this.dataGridView_ListaVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ListaVentas.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_ListaVentas.Name = "dataGridView_ListaVentas";
            this.dataGridView_ListaVentas.ReadOnly = true;
            this.dataGridView_ListaVentas.Size = new System.Drawing.Size(445, 228);
            this.dataGridView_ListaVentas.TabIndex = 6;
            // 
            // groupBox_DatosClienteb
            // 
            this.groupBox_DatosClienteb.Controls.Add(this.btt_Buscarb);
            this.groupBox_DatosClienteb.Controls.Add(this.txt_Clienteb);
            this.groupBox_DatosClienteb.Controls.Add(this.dataGridView_ClienteBusq);
            this.groupBox_DatosClienteb.Controls.Add(this.lbl_Clientesb);
            this.groupBox_DatosClienteb.Location = new System.Drawing.Point(7, 29);
            this.groupBox_DatosClienteb.Name = "groupBox_DatosClienteb";
            this.groupBox_DatosClienteb.Size = new System.Drawing.Size(450, 171);
            this.groupBox_DatosClienteb.TabIndex = 6;
            this.groupBox_DatosClienteb.TabStop = false;
            this.groupBox_DatosClienteb.Text = "Datos del cliente";
            // 
            // btt_Buscarb
            // 
            this.btt_Buscarb.Location = new System.Drawing.Point(226, 18);
            this.btt_Buscarb.Name = "btt_Buscarb";
            this.btt_Buscarb.Size = new System.Drawing.Size(73, 23);
            this.btt_Buscarb.TabIndex = 5;
            this.btt_Buscarb.Text = "Buscar";
            this.btt_Buscarb.UseVisualStyleBackColor = true;
            // 
            // txt_Clienteb
            // 
            this.txt_Clienteb.Location = new System.Drawing.Point(81, 22);
            this.txt_Clienteb.MaxLength = 25;
            this.txt_Clienteb.Name = "txt_Clienteb";
            this.txt_Clienteb.Size = new System.Drawing.Size(116, 20);
            this.txt_Clienteb.TabIndex = 4;
            // 
            // dataGridView_ClienteBusq
            // 
            this.dataGridView_ClienteBusq.AllowUserToDeleteRows = false;
            this.dataGridView_ClienteBusq.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ClienteBusq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_ClienteCb,
            this.NombreCb,
            this.Apellido_PCb,
            this.Apellido_MCb});
            this.dataGridView_ClienteBusq.Location = new System.Drawing.Point(2, 62);
            this.dataGridView_ClienteBusq.MultiSelect = false;
            this.dataGridView_ClienteBusq.Name = "dataGridView_ClienteBusq";
            this.dataGridView_ClienteBusq.ReadOnly = true;
            this.dataGridView_ClienteBusq.Size = new System.Drawing.Size(445, 104);
            this.dataGridView_ClienteBusq.TabIndex = 3;
            // 
            // Id_ClienteCb
            // 
            this.Id_ClienteCb.HeaderText = "Id_ClienteC";
            this.Id_ClienteCb.Name = "Id_ClienteCb";
            this.Id_ClienteCb.ReadOnly = true;
            this.Id_ClienteCb.Visible = false;
            // 
            // NombreCb
            // 
            this.NombreCb.HeaderText = "Nombre";
            this.NombreCb.Name = "NombreCb";
            this.NombreCb.ReadOnly = true;
            // 
            // Apellido_PCb
            // 
            this.Apellido_PCb.HeaderText = "Apellido Paterno";
            this.Apellido_PCb.Name = "Apellido_PCb";
            this.Apellido_PCb.ReadOnly = true;
            // 
            // Apellido_MCb
            // 
            this.Apellido_MCb.HeaderText = "Apellido Materno";
            this.Apellido_MCb.Name = "Apellido_MCb";
            this.Apellido_MCb.ReadOnly = true;
            // 
            // lbl_Clientesb
            // 
            this.lbl_Clientesb.AutoSize = true;
            this.lbl_Clientesb.Location = new System.Drawing.Point(31, 28);
            this.lbl_Clientesb.Name = "lbl_Clientesb";
            this.lbl_Clientesb.Size = new System.Drawing.Size(44, 13);
            this.lbl_Clientesb.TabIndex = 2;
            this.lbl_Clientesb.Text = "Clientes";
            // 
            // Id_Ventab
            // 
            this.Id_Ventab.HeaderText = "Id_Venta";
            this.Id_Ventab.Name = "Id_Ventab";
            this.Id_Ventab.ReadOnly = true;
            this.Id_Ventab.Visible = false;
            // 
            // Fechab
            // 
            this.Fechab.HeaderText = "Fecha";
            this.Fechab.Name = "Fechab";
            this.Fechab.ReadOnly = true;
            // 
            // Cantidad_Articulosb
            // 
            this.Cantidad_Articulosb.HeaderText = "Cantidad Articulos";
            this.Cantidad_Articulosb.Name = "Cantidad_Articulosb";
            this.Cantidad_Articulosb.ReadOnly = true;
            // 
            // Totalb
            // 
            this.Totalb.HeaderText = "Total";
            this.Totalb.Name = "Totalb";
            this.Totalb.ReadOnly = true;
            // 
            // lbl_Titulob
            // 
            this.lbl_Titulob.AutoSize = true;
            this.lbl_Titulob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulob.Location = new System.Drawing.Point(180, 6);
            this.lbl_Titulob.Name = "lbl_Titulob";
            this.lbl_Titulob.Size = new System.Drawing.Size(116, 20);
            this.lbl_Titulob.TabIndex = 8;
            this.lbl_Titulob.Text = "Devoluciones";
            #endregion
            // 
            // Panel_Ventas_Pedido
            // 
            this.Controls.Add(this.panel_Devolucion);
            //OCULTANDO LOS CONTROLES DE ABAJO
            groupBox_CodigoBarra.Visible = false;
            groupBox_Productos.Visible = false;
            groupBox_DatosCliente.Visible = false;
            EliminarToolStripMenuItem.Enabled = true;
        }
        #endregion
        #region Salir
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
            Application.OpenForms["Menu_principal"].Activate();
            this.Close();
        }
        #endregion
        #region Calcular porcentaje
        private void TextBox_Descuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                //Conversion de porcentaje en decimal
                string Valor = TextBox_Descuento.Text;
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
            if ((int)e.KeyChar == (int)Keys.Back)
            {
                DialogResult dialogResult = MessageBox.Show("Deseas realmente quitar este producto del carrito", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        dataGridView_Carrito.Rows.RemoveAt(dataGridView_Carrito.CurrentRow.Index);
                        txt_CodigoBarra.Focus();
                    }
                    catch (Exception)
                    {
                        //EN CASO DE QUE NO HAYA ELEMENTOS EN LA LISTA OMITE LA INSTRUCCION ANTERIOR
                        txt_CodigoBarra.Focus();
                    }
                }
            }
        }
        #endregion
        #region Quitar cliente
        private void dataGridView_ClienteKeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Back)
            {
                DialogResult dialogResult = MessageBox.Show("Deseas realmente quitar este cliente", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        dataGridView_Cliente.Rows.RemoveAt(dataGridView_Cliente.CurrentRow.Index);
                        txt_Cliente.Clear();
                        txt_Cliente.Focus();
                    }
                    catch (Exception)
                    {
                        //EN CASO DE QUE NO HAYA ELEMENTOS EN LA LISTA OMITE LA INSTRUCCION ANTERIOR
                        txt_Cliente.Focus();
                    }
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
        private void txt_BusquedaProducto_KeyPress(object sender, KeyPressEventArgs e)
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
            if (e.KeyChar == (char)Keys.Enter) //FUNCION PARA AGREGAR PRODUCTOS AL CARRITO
            { 
                #region Busqueda del producto para agregar al carrito mediante el codigo de barra
                if (txt_CodigoBarra.Text.Trim() == "")
                {
                    errorProvider_Textbox.SetError(txt_CodigoBarra, "No puedes dejar el campo vacio");
                    MessageBox.Show("Inserta todos los datos marcados", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    OleDbConnection con = new OleDbConnection();
                    OleDbCommand coman = new OleDbCommand();
                    OleDbDataReader dr;
                    con.ConnectionString = ObtenerString();
                    coman.Connection = con;
                    coman.CommandText = "SELECT Tb_Inventarioproductodetalle.Id_Producto, Tb_Inventarioproductodetalle.Precio_Venta, Tb_Producto.Nombre FROM Tb_Inventarioproductodetalle INNER JOIN Tb_Producto ON Tb_Inventarioproductodetalle.Id_Producto = Tb_Producto.Id_Producto WHERE (Tb_Producto.Codigo_Barra = '"+ txt_CodigoBarra.Text +"') AND (Tb_Producto.Activo='S')";
                    coman.CommandType = CommandType.Text;
                    con.Open();
                    //dataGridView_Carrito.Rows.Clear();
                    dr = coman.ExecuteReader();
                    while (dr.Read())
                    {
                        int Renglon = dataGridView_Carrito.Rows.Add();
                        Idp = dr.GetInt32(dr.GetOrdinal("Id_Producto"));
                        dataGridView_Carrito.Rows[Renglon].Cells["Id_Producto"].Value = dr.GetInt32(dr.GetOrdinal("Id_Producto"));
                        dataGridView_Carrito.Rows[Renglon].Cells["Producto"].Value = dr.GetString(dr.GetOrdinal("Nombre"));

                        dataGridView_Carrito.Rows[Renglon].Cells["Cantidad"].Value = "1";
                        dataGridView_Carrito.Rows[Renglon].Cells["Precio"].Value = dr.GetDecimal(dr.GetOrdinal("Precio_Venta")).ToString("N");
                        txt_CodigoBarra.Clear();
                    }
                    con.Close();
                }
                #endregion
            }
            //---------Apartado de numeros-------------Apartado de teclas especiales Retroceso y suprimir
            else if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128))
            {
                MessageBox.Show("Solo se aceptan numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        //-------------------------------------------------------------
        //---------------CONTROL DE ESPACIOS VACIOS--------------------
        //-------------------------------------------------------------
        #region Verificar campos vacios
        //METODOS PARA INDICAR ERROR DE CAMPOS VACIOS
        private TextBox[] Campos = new TextBox[2];
        private bool Verificar_CamposVacios()
        {
            //Se introduce los textbox en un arreglo con el fin de identificar espacios vacios
            Campos[0] = TextBox_CambioP;
            Campos[1] = TextBox_TotalP;
            Campos[2] = TextBox_EfectivoP;
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
                    errorProvider_Textbox.SetError(TextBox_CambioP, "No puedes dejar el campo vacio");
                    break;
                case 1:
                    errorProvider_Textbox.SetError(TextBox_TotalP, "No puedes dejar el campo vacio");
                    break;
                case 2:
                    errorProvider_Textbox.SetError(TextBox_EfectivoP, "No puedes dejar el campo vacio");
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
        private void F_VentasPedidos_FormClosing(object sender, FormClosingEventArgs e)
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
