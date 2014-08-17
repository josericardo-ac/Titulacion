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
    public partial class Menu_principal : Form
    {
        public Menu_principal()
        {
            InitializeComponent();
        }
        #region Diseño de la forma
        #region Declarando controles de la forma
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip Barra_menu;
        private System.Windows.Forms.ToolStripButton Bttn_Cliente;
        private System.Windows.Forms.ToolStripSeparator toolStripC;
        private System.Windows.Forms.ToolStripButton bttn_Proveedores;
        private System.Windows.Forms.ToolStripSeparator toolStripP;
        private System.Windows.Forms.ToolStripSplitButton bttn_split_Reportes;
        //
        //REPORTES
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financieroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promedioDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consumoDelClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gananciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deudoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muestrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gastosIndirectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cortesDeCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasDeCadaProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrativoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosPendientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDePedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem producciónToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem producciónDeProductoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem HistorialDeProduccionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem DeudaaProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HistorialDeAbonosClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeudaaClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HistorialDeAbonosProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ComprarInventToolStripMenuItem;
        //
        private System.Windows.Forms.ToolStripSeparator toolStripR;
        private System.Windows.Forms.ToolStripSplitButton bttn_split_Inventarios;
        private System.Windows.Forms.ToolStripSplitButton bttn_split_Financiero;
        private System.Windows.Forms.ToolStripSeparator toolStripI;
        private System.Windows.Forms.ToolStripSeparator toolStripF;
        private System.Windows.Forms.ToolStripSplitButton bttn_split_Mantenimiento;
        private System.Windows.Forms.ToolStripSeparator toolStripM;
        private System.Windows.Forms.ToolStripSeparator toolStripTU;
        private System.Windows.Forms.ToolStripSplitButton bttn_split_Seguridad;
        private System.Windows.Forms.ToolStripStatusLabel tool_Label_Usuario;
        private System.Windows.Forms.ToolStripStatusLabel tool_label_Hora;
        private System.Windows.Forms.ToolStripStatusLabel tool_label_Fecha;
        private System.Windows.Forms.ToolStripSeparator toolStripS;
        private System.Windows.Forms.ToolStripButton bttn_Cerrarsesion;
        private System.Windows.Forms.ToolStripMenuItem inventariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventariosMateriaPrimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventariosProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem producciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenDePeladoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AbonosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Abonos_ProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDePiezasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TipodeMateriaPrimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator tool_Separador_Tipos;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiaPrimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator tool_Separator;
        private System.Windows.Forms.ToolStripMenuItem almacénToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem UsuarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem RespaldoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem InformacionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Tipo_UsuarioToolStripMenuItem1;
        private System.Windows.Forms.Button Capturar_Imagenes;
        private System.Windows.Forms.Button Codigo_Barra;
        private System.Windows.Forms.Button Pedidos_Clientes;
        private System.Windows.Forms.Button Pedidos_Proveedores;
        private System.Windows.Forms.PictureBox pic_Logo;
        #endregion
        private void Diseño_Forma()
        {
            #region Creando controles de la forma
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_principal));
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            Barra_menu = new System.Windows.Forms.ToolStrip();
            toolStripC = new System.Windows.Forms.ToolStripSeparator();
            toolStripP = new System.Windows.Forms.ToolStripSeparator();
            toolStripR = new System.Windows.Forms.ToolStripSeparator();
            toolStripI = new System.Windows.Forms.ToolStripSeparator();
            toolStripF = new System.Windows.Forms.ToolStripSeparator();
            toolStripM = new System.Windows.Forms.ToolStripSeparator();
            toolStripS = new System.Windows.Forms.ToolStripSeparator();
            Bttn_Cliente = new System.Windows.Forms.ToolStripButton();
            toolStripTU = new System.Windows.Forms.ToolStripSeparator();
            bttn_Proveedores = new System.Windows.Forms.ToolStripButton();
            bttn_split_Reportes = new System.Windows.Forms.ToolStripSplitButton();
            bttn_split_Inventarios = new System.Windows.Forms.ToolStripSplitButton();
            bttn_split_Financiero = new System.Windows.Forms.ToolStripSplitButton();
            bttn_split_Mantenimiento = new System.Windows.Forms.ToolStripSplitButton();
            bttn_split_Seguridad = new System.Windows.Forms.ToolStripSplitButton();
            bttn_Cerrarsesion = new System.Windows.Forms.ToolStripButton();
            tool_Label_Usuario = new System.Windows.Forms.ToolStripStatusLabel();
            tool_label_Hora = new System.Windows.Forms.ToolStripStatusLabel();
            tool_label_Fecha = new System.Windows.Forms.ToolStripStatusLabel();
            inventariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            inventariosMateriaPrimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            inventariosProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            producciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ordenDePeladoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ventasPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            AbonosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            Abonos_ProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            PedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tipoDePiezasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            TipodeMateriaPrimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            Tipo_UsuarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            almacénToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            materiaPrimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            UsuarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            RespaldoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            InformacionToolStripMenuItem1= new System.Windows.Forms.ToolStripMenuItem();
            tool_Separador_Tipos = new System.Windows.Forms.ToolStripSeparator();
            tool_Separator = new System.Windows.Forms.ToolStripSeparator();
            pic_Logo = new System.Windows.Forms.PictureBox();
            Capturar_Imagenes = new System.Windows.Forms.Button();
            Codigo_Barra = new System.Windows.Forms.Button();
            Pedidos_Clientes = new System.Windows.Forms.Button();
            Pedidos_Proveedores = new System.Windows.Forms.Button();
            //
            //REPORTES
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financieroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promedioDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consumoDelClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gananciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deudoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muestrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gastosIndirectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cortesDeCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasDeCadaProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosPendientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDePedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.producciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.producciónDeProductoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.HistorialDeProduccionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DeudaaProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HistorialDeAbonosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeudaaClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HistorialDeAbonosProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComprarInventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            //
            statusStrip1.SuspendLayout();
            Barra_menu.SuspendLayout();
            SuspendLayout();
            #endregion
            //
            // Pedidos_Clientes
            //
            Pedidos_Clientes.BackgroundImage = global::Sistema_Shajobe.Properties.Resources.Pedidos_clientes;
            Pedidos_Clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Pedidos_Clientes.Click += new System.EventHandler(Historial_PedidosStripMenuItem_Click);
            Pedidos_Clientes.Location = new System.Drawing.Point(20, 205);
            Pedidos_Clientes.Name = "Pedidos_Clientes";
            Pedidos_Clientes.Size = new System.Drawing.Size(75, 75);
            Pedidos_Clientes.Enabled = false;
            //
            // Pedidos_Proveedores
            //
            Pedidos_Proveedores.BackgroundImage = global::Sistema_Shajobe.Properties.Resources.Pedidos_proveedor;
            Pedidos_Proveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Pedidos_Proveedores.Click += new System.EventHandler(Historial_PedidosProveedoresStripMenuItem_Click);
            Pedidos_Proveedores.Location = new System.Drawing.Point(20, 285);
            Pedidos_Proveedores.Name = "Pedidos_Proveedores";
            Pedidos_Proveedores.Size = new System.Drawing.Size(75, 75);
            Pedidos_Proveedores.Enabled = false;
            //
            // Capturar_Imagenes
            //
            Capturar_Imagenes.BackgroundImage = global::Sistema_Shajobe.Properties.Resources.Pictures_Folder;
            Capturar_Imagenes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Capturar_Imagenes.Click += new System.EventHandler(Captura_FotoToolStripMenuItem_Click);
            Capturar_Imagenes.Location = new System.Drawing.Point(20, 45);
            Capturar_Imagenes.Name = "Capturar_Imagenes";
            Capturar_Imagenes.Size = new System.Drawing.Size(75, 75);
            Capturar_Imagenes.Enabled = false;
            //
            // Codigo_Barra
            //
            Codigo_Barra.BackgroundImage = global::Sistema_Shajobe.Properties.Resources.Boton_Codigobarra_copia;
            Codigo_Barra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Codigo_Barra.Click += new System.EventHandler(Codigo_BarraToolStripMenuItem_Click);
            Codigo_Barra.Location = new System.Drawing.Point(20, 125);
            Codigo_Barra.Name = "Codigo_Barra";
            Codigo_Barra.Size = new System.Drawing.Size(75, 75);
            Codigo_Barra.Enabled = false;
            // 
            // pic_Logo
            // 
            pic_Logo.BackgroundImage = global::Sistema_Shajobe.Properties.Resources.Logo_Shajobe;
            pic_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pic_Logo.Location = new System.Drawing.Point(650, 45);
            pic_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right))));
            pic_Logo.Name = "pic_Logo";
            pic_Logo.Size = new System.Drawing.Size(175, 75);
            pic_Logo.TabIndex = 33;
            pic_Logo.TabStop = false;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(186)))), ((int)(((byte)(82)))));
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            tool_Label_Usuario,
            tool_label_Hora,
            tool_label_Fecha});
            statusStrip1.Location = new System.Drawing.Point(0, 408);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(848, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // Barra_menu
            // 
            Barra_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(186)))), ((int)(((byte)(82)))));
            Barra_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            Bttn_Cliente,
            toolStripC,
            bttn_Proveedores,
            toolStripP,
            bttn_split_Reportes,
            toolStripR,
            bttn_split_Inventarios,
            toolStripI,
            bttn_split_Financiero,
            toolStripF,
            bttn_split_Mantenimiento,
            toolStripM,
            bttn_split_Seguridad,
            toolStripS,
            bttn_Cerrarsesion});
            Barra_menu.Location = new System.Drawing.Point(0, 0);
            Barra_menu.Name = "Barra_menu";
            Barra_menu.Size = new System.Drawing.Size(848, 25);
            Barra_menu.TabIndex = 2;
            Barra_menu.Text = "Barra_menu";
            // 
            // toolStripC
            // 
            toolStripC.Name = "toolStripC";
            toolStripC.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripP
            // 
            toolStripP.Name = "toolStripP";
            toolStripP.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripR
            // 
            toolStripR.Name = "toolStripR";
            toolStripR.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripI
            // 
            toolStripI.Name = "toolStripI";
            toolStripI.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripF
            // 
            toolStripF.Name = "toolStripF";
            toolStripF.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripM
            // 
            toolStripM.Name = "toolStripM";
            toolStripM.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripS
            // 
            toolStripS.Name = "toolStripS";
            toolStripS.Size = new System.Drawing.Size(6, 25);
            // 
            // Bttn_Cliente
            // 
            Bttn_Cliente.Image = global::Sistema_Shajobe.Properties.Resources.Clientes;
            Bttn_Cliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            Bttn_Cliente.Name = "Bttn_Cliente";
            Bttn_Cliente.Size = new System.Drawing.Size(69, 22);
            Bttn_Cliente.Text = "&Clientes";
            Bttn_Cliente.Enabled = false;
            Bttn_Cliente.Click += new System.EventHandler(ClienteToolStripMenuItem_Click);
            // 
            // bttn_Proveedores
            // 
            bttn_Proveedores.Image = global::Sistema_Shajobe.Properties.Resources.Proveedores;
            bttn_Proveedores.ImageTransparentColor = System.Drawing.Color.Magenta;
            bttn_Proveedores.Name = "bttn_Proveedores";
            bttn_Proveedores.Size = new System.Drawing.Size(92, 22);
            bttn_Proveedores.Text = "&Proveedores";
            bttn_Proveedores.Enabled = false;
            bttn_Proveedores.Click += new System.EventHandler(ProveedorToolStripMenuItem_Click);
            // 
            // bttn_split_Reportes
            // 
            this.bttn_split_Reportes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bttn_split_Reportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.financieroToolStripMenuItem,
            this.administrativoToolStripMenuItem,
            this.producciónToolStripMenuItem1});
            this.bttn_split_Reportes.Image = global::Sistema_Shajobe.Properties.Resources.Financiero;
            this.bttn_split_Reportes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttn_split_Reportes.Name = "bttn_split_Reportes";
            this.bttn_split_Reportes.Size = new System.Drawing.Size(69, 22);
            this.bttn_split_Reportes.Enabled = false;
            this.bttn_split_Reportes.Text = "&Reportes";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.proveedoresToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Image = global::Sistema_Shajobe.Properties.Resources.Listas_de_reportes;
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "Listas";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Clientes; 
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clientesToolStripMenuItem.Text = "&Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(ClienteReporteToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Proveedores;
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.proveedoresToolStripMenuItem.Text = "&Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(ProveedorReporteToolStripMenuItem_Click);
            // 
            // financieroToolStripMenuItem
            // 
            this.financieroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.promedioDeVentasToolStripMenuItem,
            this.consumoDelClienteToolStripMenuItem,
            this.gananciasToolStripMenuItem,
            this.deudoresToolStripMenuItem,
            this.muestrasToolStripMenuItem,
            this.gastosIndirectosToolStripMenuItem,
            this.cortesDeCajaToolStripMenuItem,
            this.ventasDeCadaProductoToolStripMenuItem,
            //this.DeudaaClientesToolStripMenuItem,
            this.HistorialDeAbonosClientesToolStripMenuItem,
            this.DeudaaProveedoresToolStripMenuItem,
            this.HistorialDeAbonosProveedoresToolStripMenuItem});
            this.financieroToolStripMenuItem.Name = "financieroToolStripMenuItem";
            this.financieroToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Financiero;
            this.financieroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.financieroToolStripMenuItem.Text = "Financiero";
            // 
            // promedioDeVentasToolStripMenuItem
            // 
            this.promedioDeVentasToolStripMenuItem.Name = "promedioDeVentasToolStripMenuItem";
            this.promedioDeVentasToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.promedioDeVentasToolStripMenuItem.Text = "&Promedio de Ventas";
            this.promedioDeVentasToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Compra;
            this.promedioDeVentasToolStripMenuItem.Click+=new EventHandler(promedioDeVentasToolStripMenuItem_Click);
            // 
            // consumoDelClienteToolStripMenuItem
            // 
            this.consumoDelClienteToolStripMenuItem.Name = "consumoDelClienteToolStripMenuItem";
            this.consumoDelClienteToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.consumoDelClienteToolStripMenuItem.Text = "&Consumo del cliente";
            this.consumoDelClienteToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Clientes;
            this.consumoDelClienteToolStripMenuItem.Click+=new EventHandler(consumoDelClienteToolStripMenuItem_Click);
            // 
            // gananciasToolStripMenuItem
            // 
            this.gananciasToolStripMenuItem.Name = "gananciasToolStripMenuItem";
            this.gananciasToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.gananciasToolStripMenuItem.Text = "&Ganancias";
            this.gananciasToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Dinero;
            // 
            // DeudaaProveedoresToolStripMenuItem
            // DeudaaClientesToolStripMenuItem
            this.DeudaaProveedoresToolStripMenuItem.Name = "DeudaaProveedoresToolStripMenuItem";
            this.DeudaaProveedoresToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.DeudaaProveedoresToolStripMenuItem.Text = "&Deuda a Proveedores";
            this.DeudaaProveedoresToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Proveedores;
            this.DeudaaProveedoresToolStripMenuItem.Click+=new EventHandler(DeudaaProveedoresToolStripMenuItem_Click);
            // 
            // HistorialDeAbonosClientesToolStripMenuItem
            // 
            this.HistorialDeAbonosClientesToolStripMenuItem.Name = "HistorialDeAbonosClientesToolStripMenuItem";
            this.HistorialDeAbonosClientesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.HistorialDeAbonosClientesToolStripMenuItem.Text = "&Historial de abonos Clientes";
            this.HistorialDeAbonosClientesToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Clientes;
            // 
            // HistorialDeAbonosProveedoresToolStripMenuItem
            // 
            this.HistorialDeAbonosProveedoresToolStripMenuItem.Name = "HistorialDeAbonosProveedoresToolStripMenuItem";
            this.HistorialDeAbonosProveedoresToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.HistorialDeAbonosProveedoresToolStripMenuItem.Text = "&Historial de abonos Proveedores";
            this.HistorialDeAbonosProveedoresToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Proveedores;
            // 
            // deudoresToolStripMenuItem
            // 
            this.deudoresToolStripMenuItem.Name = "deudoresToolStripMenuItem";
            this.deudoresToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.deudoresToolStripMenuItem.Text = "&Deudores";
            this.deudoresToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Clientes;
            this.deudoresToolStripMenuItem.Click+=new EventHandler(deudoresToolStripMenuItem_Click);
            // 
            // muestrasToolStripMenuItem
            // 
            this.muestrasToolStripMenuItem.Name = "muestrasToolStripMenuItem";
            this.muestrasToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.muestrasToolStripMenuItem.Text = "&Muestras";
            this.muestrasToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Producto;
            this.muestrasToolStripMenuItem.Click += new EventHandler(MuestraToolStripMenuItem_Click);
            // 
            // gastosIndirectosToolStripMenuItem
            // 
            this.gastosIndirectosToolStripMenuItem.Name = "gastosIndirectosToolStripMenuItem";
            this.gastosIndirectosToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.gastosIndirectosToolStripMenuItem.Text = "&Gastos de Inventarios";
            this.gastosIndirectosToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Retirar;
            // 
            // cortesDeCajaToolStripMenuItem
            // 
            this.cortesDeCajaToolStripMenuItem.Name = "cortesDeCajaToolStripMenuItem";
            this.cortesDeCajaToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.cortesDeCajaToolStripMenuItem.Text = "&Cortes de caja";
            this.cortesDeCajaToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Caja;
            this.cortesDeCajaToolStripMenuItem.Click+=new EventHandler(cortesDeCajaToolStripMenuItem_Click);
            // 
            // ventasDeCadaProductoToolStripMenuItem
            // 
            this.ventasDeCadaProductoToolStripMenuItem.Name = "ventasDeCadaProductoToolStripMenuItem";
            this.ventasDeCadaProductoToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.ventasDeCadaProductoToolStripMenuItem.Text = "&Ventas de cada producto";
            this.ventasDeCadaProductoToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Producto;
            this.ventasDeCadaProductoToolStripMenuItem.Click+=new EventHandler(ventasDeCadaProductoToolStripMenuItem_Click);
            // 
            // administrativoToolStripMenuItem
            // 
            this.administrativoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosPendientesToolStripMenuItem,
            this.historialDePedidosToolStripMenuItem,
            this.ComprarInventToolStripMenuItem});
            this.administrativoToolStripMenuItem.Name = "administrativoToolStripMenuItem";
            this.administrativoToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Administrativo;
            this.administrativoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.administrativoToolStripMenuItem.Text = "Administrativo";
            // 
            // pedidosPendientesToolStripMenuItem
            // 
            this.pedidosPendientesToolStripMenuItem.Name = "pedidosPendientesToolStripMenuItem";
            this.pedidosPendientesToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.pedidosPendientesToolStripMenuItem.Text = "&Pedidos pendientes";
            this.pedidosPendientesToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Pedidos;
            this.pedidosPendientesToolStripMenuItem.Click += new EventHandler(ReportePedidos_PendientesToolStripMenuItem_Click);
            // 
            // historialDePedidosToolStripMenuItem
            // 
            this.historialDePedidosToolStripMenuItem.Name = "historialDePedidosToolStripMenuItem";
            this.historialDePedidosToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.historialDePedidosToolStripMenuItem.Text = "&Historial de pedidos";
            this.historialDePedidosToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Pedidos_clientes;
            this.historialDePedidosToolStripMenuItem.Click+=new EventHandler(historialDePedidosToolStripMenuItem_Click);
            // 
            // producciónToolStripMenuItem
            // 
            this.producciónToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.producciónDeProductoToolStripMenuItem1,
            this.HistorialDeProduccionToolStripMenuItem1});
            this.producciónToolStripMenuItem1.Name = "producciónToolStripMenuItem";
            this.producciónToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.producciónToolStripMenuItem1.Text = "Producción";
            this.producciónToolStripMenuItem1.Image = global::Sistema_Shajobe.Properties.Resources._3444158;
            // 
            // producciónDeProductoToolStripMenuItem
            // 
            this.producciónDeProductoToolStripMenuItem1.Name = "producciónDeProductoToolStripMenuItem";
            this.producciónDeProductoToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.producciónDeProductoToolStripMenuItem1.Text = "Producción de producto";
            this.producciónDeProductoToolStripMenuItem1.Image = global::Sistema_Shajobe.Properties.Resources.produccion;
            // 
            // HistorialDeProduccionToolStripMenuItem1
            // 
            this.HistorialDeProduccionToolStripMenuItem1.Name = "HistorialDeProduccionToolStripMenuItem1";
            this.HistorialDeProduccionToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.HistorialDeProduccionToolStripMenuItem1.Text = "Historial de producción";
            this.HistorialDeProduccionToolStripMenuItem1.Image = global::Sistema_Shajobe.Properties.Resources.Apps_iCal_Metro_icon;
            // 
            // ComprarInventToolStripMenuItem
            // 
            this.ComprarInventToolStripMenuItem.Name = "ComprarInventToolStripMenuItem";
            this.ComprarInventToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.ComprarInventToolStripMenuItem.Text = "&Información de inventario";
            this.ComprarInventToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Dinero;
            this.ComprarInventToolStripMenuItem.Click += new EventHandler(OpcionInventariosToolStripMenuItem_Click);
            // 
            // bttn_split_Inventarios
            // 
            bttn_split_Inventarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            inventariosToolStripMenuItem,
            producciónToolStripMenuItem,
            ordenDePeladoToolStripMenuItem});
            bttn_split_Inventarios.Image = global::Sistema_Shajobe.Properties.Resources.Inventario;
            bttn_split_Inventarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            bttn_split_Inventarios.Name = "bttn_split_Inventarios";
            bttn_split_Inventarios.Size = new System.Drawing.Size(97, 22);
            bttn_split_Inventarios.Text = "&Inventarios";
            bttn_split_Inventarios.Enabled = false;
            // 
            // bttn_split_Financiero
            // 
            bttn_split_Financiero.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            cajaToolStripMenuItem,
            ventasPedidosToolStripMenuItem, AbonosToolStripMenuItem,Abonos_ProveedorToolStripMenuItem,PedidosToolStripMenuItem});
            bttn_split_Financiero.Image = global::Sistema_Shajobe.Properties.Resources.Dinero;
            bttn_split_Financiero.ImageTransparentColor = System.Drawing.Color.Magenta;
            bttn_split_Financiero.Name = "bttn_split_Financiero";
            bttn_split_Financiero.Size = new System.Drawing.Size(94, 22);
            bttn_split_Financiero.Text = "&Financiero";
            bttn_split_Financiero.Enabled = false;
            // 
            // bttn_split_Mantenimiento
            // 
            bttn_split_Mantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            tipoDePiezasToolStripMenuItem,
            TipodeMateriaPrimaToolStripMenuItem,
            tool_Separador_Tipos,
            productosToolStripMenuItem,
            materiaPrimaToolStripMenuItem,
            tool_Separator,
            almacénToolStripMenuItem1,
            toolStripTU,
            Tipo_UsuarioToolStripMenuItem1});
            bttn_split_Mantenimiento.Image = global::Sistema_Shajobe.Properties.Resources.icon_47203_640;
            bttn_split_Mantenimiento.ImageTransparentColor = System.Drawing.Color.Magenta;
            bttn_split_Mantenimiento.Name = "bttn_split_Mantenimiento";
            bttn_split_Mantenimiento.Size = new System.Drawing.Size(121, 22);
            bttn_split_Mantenimiento.Text = "&Mantenimiento";
            bttn_split_Mantenimiento.Enabled = false;
            // 
            // bttn_split_Seguridad
            // 
            bttn_split_Seguridad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            UsuarioToolStripMenuItem1, RespaldoToolStripMenuItem1,InformacionToolStripMenuItem1});
            bttn_split_Seguridad.Image = global::Sistema_Shajobe.Properties.Resources.Vista__180_;
            bttn_split_Seguridad.ImageTransparentColor = System.Drawing.Color.Magenta;
            bttn_split_Seguridad.Name = "bttn_split_Seguridad";
            bttn_split_Seguridad.Size = new System.Drawing.Size(92, 22);
            bttn_split_Seguridad.Text = "&Seguridad";
            bttn_split_Seguridad.Enabled = false;
            // 
            // bttn_Cerrarsesion
            // 
            bttn_Cerrarsesion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            bttn_Cerrarsesion.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bttn_Cerrarsesion.Image = ((System.Drawing.Image)(resources.GetObject("bttn_Cerrarsesion.Image")));
            bttn_Cerrarsesion.ImageTransparentColor = System.Drawing.Color.Magenta;
            bttn_Cerrarsesion.Name = "bttn_Cerrarsesion";
            bttn_Cerrarsesion.Size = new System.Drawing.Size(83, 22);
            bttn_Cerrarsesion.Text = "Cerrar sesión";
            bttn_Cerrarsesion.Click += new System.EventHandler(Menu_Principal_FormClosing);
            // 
            // tool_Label_Usuario
            // 
            tool_Label_Usuario.Image = global::Sistema_Shajobe.Properties.Resources.Usuario;
            tool_Label_Usuario.Name = "tool_Label_Usuario";
            tool_Label_Usuario.Size = new System.Drawing.Size(66, 17);
            tool_Label_Usuario.Text = "Usuario:";
            // 
            // tool_label_Hora
            // 
            tool_label_Hora.Image = global::Sistema_Shajobe.Properties.Resources.kalarm;
            tool_label_Hora.Name = "tool_label_Hora";
            tool_label_Hora.Size = new System.Drawing.Size(52, 17);
            tool_label_Hora.Text = "Hora:";
            // 
            // tool_label_Fecha
            // 
            tool_label_Fecha.Image = global::Sistema_Shajobe.Properties.Resources.cal;
            tool_label_Fecha.Name = "tool_label_Fecha";
            tool_label_Fecha.Size = new System.Drawing.Size(57, 17);
            tool_label_Fecha.Text = "Fecha:";
            // 
            // inventariosToolStripMenuItem
            // 
            inventariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            inventariosMateriaPrimaToolStripMenuItem,
            inventariosProductoToolStripMenuItem});
            inventariosToolStripMenuItem.Name = "inventariosToolStripMenuItem";
            inventariosToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Inventario;
            inventariosToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            inventariosToolStripMenuItem.Text = "Inventarios";
            // 
            // inventariosMateriaPrimaToolStripMenuItem
            // 
            inventariosMateriaPrimaToolStripMenuItem.Name = "inventariosMateriaPrimaToolStripMenuItem";
            inventariosMateriaPrimaToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Materia_prima;
            inventariosMateriaPrimaToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            inventariosMateriaPrimaToolStripMenuItem.Text = "Inventarios materia prima";
            inventariosMateriaPrimaToolStripMenuItem.Click += new System.EventHandler(inventariosMateriaPrimaToolStripMenuItem_Click);
            // 
            // inventariosProductoToolStripMenuItem
            // 
            inventariosProductoToolStripMenuItem.Name = "inventariosProductoToolStripMenuItem";
            inventariosProductoToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Producto;
            inventariosProductoToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            inventariosProductoToolStripMenuItem.Text = "Inventarios producto";
            inventariosProductoToolStripMenuItem.Click += new System.EventHandler(inventariosProductoToolStripMenuItem_Click);
            // 
            // producciónToolStripMenuItem
            // 
            producciónToolStripMenuItem.Name = "producciónToolStripMenuItem";
            producciónToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            producciónToolStripMenuItem.Text = "Producción";
            producciónToolStripMenuItem.Click += new System.EventHandler(producciónToolStripMenuItem_Click);
            producciónToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.produccion;
            // 
            // ordenDePeladoToolStripMenuItem
            // 
            ordenDePeladoToolStripMenuItem.Name = "ordenDePeladoToolStripMenuItem";
            ordenDePeladoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            ordenDePeladoToolStripMenuItem.Text = "Orden de pelado";
            ordenDePeladoToolStripMenuItem.Click += new System.EventHandler(ordenDePeladoToolStripMenuItem_Click);
            ordenDePeladoToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Orden_de_pelado;
            // 
            // UsuarioToolStripMenuItem1
            // 
            UsuarioToolStripMenuItem1.Name = "UsuarioToolStripMenuItem1";
            UsuarioToolStripMenuItem1.Image = global::Sistema_Shajobe.Properties.Resources.Usuario;
            UsuarioToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            UsuarioToolStripMenuItem1.Text = "Usuario";
            UsuarioToolStripMenuItem1.Click += new System.EventHandler(UsuarioToolStripMenuItem_Click);
            // 
            // RespaldoToolStripMenuItem1
            // 
            RespaldoToolStripMenuItem1.Name = "RespaldoToolStripMenuItem1";
            RespaldoToolStripMenuItem1.Image = global::Sistema_Shajobe.Properties.Resources.Copia;
            RespaldoToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            RespaldoToolStripMenuItem1.Text = "Copia de seguridad y Restauración";
            RespaldoToolStripMenuItem1.Click += new System.EventHandler(RespaldoToolStripMenuItem_Click);
            // 
            // InformacionToolStripMenuItem1
            // 
            InformacionToolStripMenuItem1.Name = "InformacionToolStripMenuItem1";
            InformacionToolStripMenuItem1.Image = global::Sistema_Shajobe.Properties.Resources.Vista__180_;
            InformacionToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            InformacionToolStripMenuItem1.Text = "Informacion del sistema";
            InformacionToolStripMenuItem1.Click += new System.EventHandler(InformacionToolStripMenuItem1_Click);
            // 
            // cajaToolStripMenuItem
            // 
            cajaToolStripMenuItem.Name = "cajaToolStripMenuItem";
            cajaToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Caja;
            cajaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            cajaToolStripMenuItem.Text = "Caja";
            cajaToolStripMenuItem.Click += new System.EventHandler(CajaToolStripMenuItem_Click);
            // 
            // ventasPedidosToolStripMenuItem
            // 
            ventasPedidosToolStripMenuItem.Name = "ventasPedidosToolStripMenuItem";
            ventasPedidosToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Compra;
            ventasPedidosToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            ventasPedidosToolStripMenuItem.Text = "Ventas-Pedidos";
            ventasPedidosToolStripMenuItem.Click += new System.EventHandler(VentasToolStripMenuItem_Click);
            // 
            // AbonosToolStripMenuItem
            // 
            AbonosToolStripMenuItem.Name = "AbonosToolStripMenuItem";
            AbonosToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Dinero;
            AbonosToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            AbonosToolStripMenuItem.Text = "Abonos";
            AbonosToolStripMenuItem.Click += new System.EventHandler(AbonosToolStripMenuItem_Click);
            // 
            // Abonos_ProveedorToolStripMenuItem
            // 
            Abonos_ProveedorToolStripMenuItem.Name = "Abonos_ProveedorToolStripMenuItem";
            Abonos_ProveedorToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Dinero;
            Abonos_ProveedorToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            Abonos_ProveedorToolStripMenuItem.Text = "Abonos Proveedores";
            Abonos_ProveedorToolStripMenuItem.Click += new System.EventHandler(Abonos_ProveedorToolStripMenuItem_Click);
            // 
            // PedidosToolStripMenuItem
            // 
            PedidosToolStripMenuItem.Name = "PedidosToolStripMenuItem";
            PedidosToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Pedidos;
            PedidosToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            PedidosToolStripMenuItem.Text = "Pedido de materia prima";
            PedidosToolStripMenuItem.Click += new System.EventHandler(PedidosToolStripMenuItem_Click);
            // 
            // tipoDePiezasToolStripMenuItem
            // 
            tipoDePiezasToolStripMenuItem.Name = "tipoDePiezasToolStripMenuItem";
            tipoDePiezasToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Materia_prima;
            tipoDePiezasToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            tipoDePiezasToolStripMenuItem.Text = "Tipo de piezas";
            tipoDePiezasToolStripMenuItem.Click += new System.EventHandler(tipoDePiezasToolStripMenuItem_Click);
            // 
            // TipodeMateriaPrimaToolStripMenuItem
            // 
            TipodeMateriaPrimaToolStripMenuItem.Name = "TipodeMateriaPrimaToolStripMenuItem";
            TipodeMateriaPrimaToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Materia_prima;
            TipodeMateriaPrimaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            TipodeMateriaPrimaToolStripMenuItem.Text = "Tipo de materias primas";
            TipodeMateriaPrimaToolStripMenuItem.Click += new System.EventHandler(TipodeMateriaPrimaToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Producto;
            productosToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += new System.EventHandler(productosToolStripMenuItem_Click);
            // 
            // almacénToolStripMenuItem1
            // 
            almacénToolStripMenuItem1.Name = "almacénToolStripMenuItem1";
            almacénToolStripMenuItem1.Image = global::Sistema_Shajobe.Properties.Resources.Almacen;
            almacénToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            almacénToolStripMenuItem1.Text = "Almacén";
            almacénToolStripMenuItem1.Click += new System.EventHandler(almacénToolStripMenuItem1_Click);
            // 
            // Tipo_UsuarioToolStripMenuItem1
            // 
            Tipo_UsuarioToolStripMenuItem1.Name = "Tipo_UsuarioToolStripMenuItem1";
            Tipo_UsuarioToolStripMenuItem1.Image = global::Sistema_Shajobe.Properties.Resources.Usuario;
            Tipo_UsuarioToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            Tipo_UsuarioToolStripMenuItem1.Text = "Tipo de Usuarios";
            Tipo_UsuarioToolStripMenuItem1.Click += new System.EventHandler(Tipo_UsuarioToolStripMenuItem_Click);
            // 
            // materiaPrimaToolStripMenuItem
            // 
            materiaPrimaToolStripMenuItem.Name = "materiaPrimaToolStripMenuItem";
            materiaPrimaToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Materia_prima;
            materiaPrimaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            materiaPrimaToolStripMenuItem.Text = "Materia prima";
            materiaPrimaToolStripMenuItem.Click += new System.EventHandler(materiaPrimaToolStripMenuItem_Click);
            // 
            // tool_Separador_Tipos
            // 
            tool_Separador_Tipos.Name = "tool_Separador_Tipos";
            tool_Separador_Tipos.Size = new System.Drawing.Size(168, 6);
            // 
            // tool_Separator
            // 
            tool_Separator.Name = "tool_Separator";
            tool_Separator.Size = new System.Drawing.Size(168, 6);
            // 
            // Menu_principal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(196)))));
            ClientSize = new System.Drawing.Size(848, 650);
            Controls.Add(Barra_menu);
            Controls.Add(statusStrip1);
            Controls.Add(Capturar_Imagenes);
            Controls.Add(Codigo_Barra);
            Controls.Add(Pedidos_Clientes);
            Controls.Add(Pedidos_Proveedores);
            Controls.Add(pic_Logo);
            ControlBox = false;
            MaximumSize = new System.Drawing.Size(886, 650);
            MinimumSize = new System.Drawing.Size(886, 650);
            MaximizeBox = false;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = global::Sistema_Shajobe.Properties.Resources.Shajobe_ICO;
            Name = "Menu_principal";
            Text = "Sistema Shajobe";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            Barra_menu.ResumeLayout(false);
            Barra_menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        #region Eventos
        private void Menu_principal_Load(object sender, EventArgs e)
        {
            #region Animacion
            AnimateWindow(Handle, 350, AnimateWindowFlags.AW_CENTER);
            AnimateWindow(Handle, 450, AnimateWindowFlags.AW_CENTER | AnimateWindowFlags.AW_SLIDE);
            ResumeLayout(false);
            PerformLayout();
            #endregion
            Verificar_Creardirectorio();
            Diseño_Forma();//Diseño de la ventana
            #region Creando Controles de Descripcion
            ToolTip toolTip_Descripcion = new ToolTip();
            #endregion
            #region Generando y dando diseño al control
            // GENERANDO TIEMPOS DEL CONTROL
            toolTip_Descripcion.AutoPopDelay = 5000;
            toolTip_Descripcion.InitialDelay = 1000;
            toolTip_Descripcion.ReshowDelay = 500;
            // ACTIVANDO LA DESCRIPCION DEL CONTROL
            toolTip_Descripcion.ShowAlways = true;
            // ASIGNANDO LA DESCRIPCION A CADA CONTROL
            toolTip_Descripcion.SetToolTip(Capturar_Imagenes, "TOMA FOTOGRAFIAS MEDIANTE LA CAMARA WEB");
            toolTip_Descripcion.SetToolTip(Codigo_Barra, "GENERA UN CODIGO DE BARRA PARA USAR COMO ETIQUETAS");
            toolTip_Descripcion.SetToolTip(Pedidos_Clientes, "MUESTRA UNA LISTA DE LOS PEDIDOS DE LOS CLIENTES");
            toolTip_Descripcion.SetToolTip(Pedidos_Proveedores, "MUESTRA UNA LISTA DE LOS PEDIDOS A LOS PROVEEDORES");
            #endregion
            //Muestra la fecha y la hora en que inicio sesión
            Fecha();
            Hora();
            Usuario_Login();
            Carga_Permisos();
        }
        private void producciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Produccion"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Produccion"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Produccion P = new Produccion();
                P.Show();
            }
        }
        private void ordenDePeladoToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Orden_Pelado"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Orden_Pelado"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Orden_Pelado O = new Orden_Pelado();
                O.Show();
            }
        }
        private void inventariosMateriaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Inventario_Materiaprima"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Inventario_Materiaprima"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Inventario_Materiaprima A = new Inventario_Materiaprima();
                A.Show();
            }
        }
        private void inventariosProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["InventarioProducto"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["InventarioProducto"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Inventario_Producto IP = new Inventario_Producto();
                IP.Show();
            }
        }
        private void tipoDePiezasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["TipoPieza"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["TipoPieza"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Tipo_pieza Tp = new Tipo_pieza();
                Tp.Show();
            }
        }
        private void TipodeMateriaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Tipo_MateriaPrima"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Tipo_MateriaPrima"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Tipo_de_materia_prima Tm = new Tipo_de_materia_prima();
                Tm.Show();
            }
        }
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Producto"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Producto"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Producto P = new Producto();
                P.Show();
            }
        }
        private void materiaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Materia_Prima"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Materia_Prima"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Materia_prima Mp = new Materia_prima();
                Mp.Show();
            }
        }
        private void almacénToolStripMenuItem1_Click(object sender, EventArgs e)
        { 
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Almacen"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Almacen"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Almacen A = new Almacen();
                A.Show();
            }
        }
        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Cliente"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Cliente"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Cliente C = new Cliente();
                C.Show();
            }
        }
        private void ProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Proveedor"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Proveedor"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Proveedor P = new Proveedor();
                P.Show();
            }
        }
        private void CajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Caja"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Caja"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Caja C = new Caja();
                C.Show();
            }
        }
        private void UsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Usuario"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Usuario"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Usuario U = new Usuario();
                U.Show();
            }
        }
        private void RespaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Respaldo"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Respaldo"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Respaldo r = new Respaldo();
                r.Show();
            }
        }
        private void InformacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Informacion"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Informacion"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Informacion I = new Informacion();
                I.Show();
            }
        }
        private void Tipo_UsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Tipo_Usuario"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Tipo_Usuario"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Tipo_Usuario U = new Tipo_Usuario();
                U.Show();
            }
        }
        private void VentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["F_VentasPedidos"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["F_VentasPedidos"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                F_VentasPedidos U = new F_VentasPedidos();
                U.Show();
            }
        }
        private void AbonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Abonos"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Abonos"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Abonos A = new Abonos();
                A.Show();
            }
        }
        private void Abonos_ProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Abono_Proveedor"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Abono_Proveedor"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Abono_Proveedor A = new Abono_Proveedor();
                A.Show();
            }
        }
        private void PedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["CompraMateriaPrima"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["CompraMateriaPrima"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                CompraMateriaPrima CM = new CompraMateriaPrima();
                CM.Show();
            }
        }
        private void ClienteReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Busqueda_Reporte_Cliente"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Busqueda_Reporte_Cliente"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Busqueda_Reporte_Cliente CM = new Busqueda_Reporte_Cliente();
                CM.Show();
            }
        }
        private void ProveedorReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Busqueda_Reporte_Proveedor"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Busqueda_Reporte_Proveedor"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Busqueda_Reporte_Proveedor CM = new Busqueda_Reporte_Proveedor();
                CM.Show();
            }
        }
        private void cortesDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Busqueda_de_cortes_de_caja"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Busqueda_de_cortes_de_caja"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Busqueda_de_cortes_de_caja CM = new Busqueda_de_cortes_de_caja();
                CM.Show();
            }
        }
        private void promedioDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Busqueda_de_promedio_de_ventas"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Busqueda_de_promedio_de_ventas"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Busqueda_de_promedio_de_ventas CM = new Busqueda_de_promedio_de_ventas();
                CM.Show();
            }
        }
        private void consumoDelClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Busqueda_de_consumo_del_cliente"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Busqueda_de_consumo_del_cliente"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Busqueda_de_consumo_del_cliente CM = new Busqueda_de_consumo_del_cliente();
                CM.Show();
            }
        }
        private void deudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Clientes_deudores"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Clientes_deudores"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Clientes_deudores CM = new Clientes_deudores();
                CM.Show();
            }
        }
        private void MuestraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Busqueda_de_Historial_de_Muestras"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Busqueda_de_Historial_de_Muestras"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Busqueda_de_Historial_de_Muestras CM = new Busqueda_de_Historial_de_Muestras();
                CM.Show();
            }
        }
        private void ventasDeCadaProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Busqueda_de_ventas_x_producto"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Busqueda_de_ventas_x_producto"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Busqueda_de_ventas_x_producto CM = new Busqueda_de_ventas_x_producto();
                CM.Show();
            }
        }
        private void ReportePedidos_PendientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["ReportePedidos_Pendientes"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["ReportePedidos_Pendientes"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                ReportePedidos_Pendientes CM = new ReportePedidos_Pendientes();
                CM.Show();
            }
        }
        private void historialDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Busqueda_Historial_de_pedidos"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Busqueda_Historial_de_pedidos"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Busqueda_Historial_de_pedidos CM = new Busqueda_Historial_de_pedidos();
                CM.Show();
            }
        }
        private void OpcionInventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Opcion_Inventario"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Opcion_Inventario"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Opcion_Inventario CM = new Opcion_Inventario();
                CM.Show();
            }
        }
        private void DeudaaProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Deuda_proveedores"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Deuda_proveedores"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Deuda_proveedores CM = new Deuda_proveedores();
                CM.Show();
            }
        }
        //-------------------------------------------------------------
        //-------------LLENADO DE CONTROLES DEL SISTEMA----------------
        //-------------------------------------------------------------
        //Seccion de fecha y hora
        #region Fecha
        private void Fecha()
        {
            tool_label_Fecha.Text = DateTime.Now.ToLongDateString(); 
        }
        #endregion
        #region Hora
        private void Hora()
        {
              tool_label_Hora.Text = DateTime.Now.ToLongTimeString(); 
        }
        #endregion
        #region Usuario
        private int I = 0;
        private void Usuario_Login()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "SELECT * FROM V_UsuarioLogin";
            coman.CommandType = CommandType.Text;
            con.Open();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Declarando Variables y obteniendo los valores correspondiente
                I = dr.GetInt32(dr.GetOrdinal("Id_Usuario"));
                string N = dr.GetString(dr.GetOrdinal("Nombre"));
                string AP = dr.GetString(dr.GetOrdinal("Apellido_P"));
                string AM = dr.GetString(dr.GetOrdinal("Apellido_M"));
                tool_Label_Usuario.Text = N + " " + AP + " " + AM;
            }
            con.Close();
        }
        #endregion
        //-------------------------------------------------------------
        //---------------SECCION DE CONTROLES EXTERNOS-----------------
        //-------------------------------------------------------------
        private void Captura_FotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Captura_Foto"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Captura_Foto"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Captura_Foto C = new Captura_Foto();
                C.Show();
            }
        }
        private void Codigo_BarraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["CodigoBarra"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["CodigoBarra"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                CodigoBarra C = new CodigoBarra();
                C.Show();
            }
        }
        #region Pedidos Clientes
        private void Historial_PedidosStripMenuItem_Click(object sender, EventArgs e)
        {
            try //Quita el panel de control en caso de que ya se haya utilizado
            {
                //Quito el panel de busqueda
                Controls.Remove(panel_PedidoProveedores);
            }
            catch (Exception)
            {
                //En caso de que no existe todavia el panel panel_PedidoProveedores
                //omite la instrucción de quitar dicho control
            }
            Control_Historial_Clientes();
        }
        //  CREANDO CONTROLES PARA EL HISTORIAL DE PEDIDOS DE CLIENTES
        #region Diseños Control_Historial_Clientes
        #region Declarando controles para el panel de historial de clientes
            private System.Windows.Forms.Panel panel_PedidoClientes;
            private System.Windows.Forms.DataGridView dataGridView_Pedidos;
            private System.Windows.Forms.DataGridViewTextBoxColumn Id_Pedido;
            private System.Windows.Forms.DataGridViewTextBoxColumn Id_Cliente;
            private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
            private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Pedido;
            private System.Windows.Forms.Button bttn_CerrarPanelCLIENTES;
            private System.Windows.Forms.Label lbl_PedidoClientes;
        #endregion
        private void Control_Historial_Clientes()
        {            
            #region Creando controles para el panel de historial de clientes
            this.panel_PedidoClientes = new System.Windows.Forms.Panel();
            this.dataGridView_Pedidos = new System.Windows.Forms.DataGridView();
            this.Id_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttn_CerrarPanelCLIENTES = new System.Windows.Forms.Button();
            this.lbl_PedidoClientes = new System.Windows.Forms.Label();
            this.panel_PedidoClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pedidos)).BeginInit();
            this.SuspendLayout();
            #endregion
            #region Agregando diseño para el panel de historial de clientes
                // 
                // panel_PedidoClientes
                // 
                this.panel_PedidoClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.panel_PedidoClientes.Controls.Add(this.lbl_PedidoClientes);
                this.panel_PedidoClientes.Controls.Add(this.bttn_CerrarPanelCLIENTES);
                this.panel_PedidoClientes.Controls.Add(this.dataGridView_Pedidos);
                this.panel_PedidoClientes.Location = new System.Drawing.Point(100, 174);
                this.panel_PedidoClientes.Name = "panel_PedidoClientes";
                this.panel_PedidoClientes.Size = new System.Drawing.Size(719, 387);
                this.panel_PedidoClientes.TabIndex = 1;
                this.panel_PedidoClientes.SendToBack();
                // 
                // dataGridView_Pedidos
                // 
                this.dataGridView_Pedidos.AllowUserToAddRows = false;
                this.dataGridView_Pedidos.AllowUserToDeleteRows = false;
                this.dataGridView_Pedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                            | System.Windows.Forms.AnchorStyles.Left)
                            | System.Windows.Forms.AnchorStyles.Right)));
                this.dataGridView_Pedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                this.dataGridView_Pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                this.dataGridView_Pedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.Id_Pedido,
                this.Id_Cliente,
                this.Cliente,
                this.Fecha_Pedido});
                this.dataGridView_Pedidos.Location = new System.Drawing.Point(3, 32);
                this.dataGridView_Pedidos.Name = "dataGridView_Pedidos";
                this.dataGridView_Pedidos.ReadOnly = true;
                this.dataGridView_Pedidos.Size = new System.Drawing.Size(712, 350);
                this.dataGridView_Pedidos.TabIndex = 1;
                this.dataGridView_Pedidos.Click += new EventHandler(this.dataGridView_Pedidos_Click);
                // 
                // Id_Pedido
                // 
                this.Id_Pedido.HeaderText = "Id_Pedido";
                this.Id_Pedido.Name = "Id_Pedido";
                this.Id_Pedido.ReadOnly = true;
                this.Id_Pedido.Visible = false;
                // 
                // Id_Cliente
                // 
                this.Id_Cliente.HeaderText = "Id_Cliente";
                this.Id_Cliente.Name = "Id_Cliente";
                this.Id_Cliente.ReadOnly = true;
                this.Id_Cliente.Visible = false;
                // 
                // Cliente
                // 
                this.Cliente.HeaderText = "Cliente";
                this.Cliente.Name = "Cliente";
                this.Cliente.ReadOnly = true;
                // 
                // Fecha_Pedido
                // 
                this.Fecha_Pedido.HeaderText = "Fecha Pedido";
                this.Fecha_Pedido.Name = "Fecha_Pedido";
                this.Fecha_Pedido.ReadOnly = true;
                // 
                // bttn_CerrarPanelCLIENTES
                // 
                this.bttn_CerrarPanelCLIENTES.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                            | System.Windows.Forms.AnchorStyles.Right)));
                this.bttn_CerrarPanelCLIENTES.BackColor = System.Drawing.Color.Red;
                this.bttn_CerrarPanelCLIENTES.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.bttn_CerrarPanelCLIENTES.ForeColor = System.Drawing.Color.White;
                this.bttn_CerrarPanelCLIENTES.Location = new System.Drawing.Point(690, 3);
                this.bttn_CerrarPanelCLIENTES.MaximumSize = new System.Drawing.Size(23, 23);
                this.bttn_CerrarPanelCLIENTES.MinimumSize = new System.Drawing.Size(23, 23);
                this.bttn_CerrarPanelCLIENTES.Name = "bttn_CerrarPanelCLIENTES";
                this.bttn_CerrarPanelCLIENTES.Size = new System.Drawing.Size(23, 23);
                this.bttn_CerrarPanelCLIENTES.TabIndex = 4;
                this.bttn_CerrarPanelCLIENTES.Text = "X";
                this.bttn_CerrarPanelCLIENTES.UseVisualStyleBackColor = false;
                this.bttn_CerrarPanelCLIENTES.Click += new System.EventHandler(this.bttn_CerrarPanelCLIENTES_Click);
                // 
                // lbl_PedidoClientes
                // 
                this.lbl_PedidoClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                            | System.Windows.Forms.AnchorStyles.Left)));
                this.lbl_PedidoClientes.AutoSize = true;
                this.lbl_PedidoClientes.Location = new System.Drawing.Point(269, 9);
                this.lbl_PedidoClientes.Name = "lbl_PedidoClientes";
                this.lbl_PedidoClientes.Size = new System.Drawing.Size(179, 13);
                this.lbl_PedidoClientes.TabIndex = 5;
                this.lbl_PedidoClientes.Text = "LISTA DE PEDIDOS DE CLIENTES";
                this.lbl_PedidoClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                //
                // MENU PRINCIPAL
                //
                this.Controls.Add(this.panel_PedidoClientes);
            #endregion
            LLenando_PedidosClientes();
            dataGridView_Pedidos.Focus();
        }
        //  EVENTOS DEL PANEL DE PEDIDOS CLIENTES
        #region Boton Cerrar Panel Clientes
        private void bttn_CerrarPanelCLIENTES_Click(object sender, EventArgs e)
        {
            try //Quita el panel de control en caso de que ya se haya utilizado
            {
                //Quito el panel de busqueda
                Controls.Remove(panel_PedidoClientes);
            }
            catch (Exception)
            {
                //En caso de que no existe todavia el panel panel_PedidoClientes
                //omite la instrucción de quitar dicho control
            }
        }
        #endregion
        #region Desgloce de productos pedidos por clientes
        #region Declarando controles
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_Historial;
        private System.Windows.Forms.TextBox txt_ClienteD;
        private System.Windows.Forms.Label lbl_ClienteD;
        private System.Windows.Forms.Button bttn_CerrarPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_PedidoD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_ClienteD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_ProductoD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadD;
        private System.Windows.Forms.Button bttn_Cancelarpedido_Cliente;
        private System.Windows.Forms.Button bttn_Entregarpedido_Cliente;
        #endregion
        private int idpend;
        private void dataGridView_Pedidos_Click(object sender, EventArgs e)
        {
                #region Creando controles
                this.panel1 = new System.Windows.Forms.Panel();
                this.lbl_ClienteD = new System.Windows.Forms.Label();
                this.txt_ClienteD = new System.Windows.Forms.TextBox();
                this.dataGridView_Historial = new System.Windows.Forms.DataGridView();
                this.Id_PedidoD = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.Id_ClienteD = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.Id_ProductoD = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.ProductoD = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.CantidadD = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.bttn_Entregarpedido_Cliente = new System.Windows.Forms.Button();
                this.bttn_Cancelarpedido_Cliente = new System.Windows.Forms.Button();
                this.bttn_CerrarPanel = new System.Windows.Forms.Button();
                this.panel1.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Historial)).BeginInit();
                this.SuspendLayout();
                #endregion
                #region Dando diseño a los controles
                // 
                // panel1
                // 
                this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.panel1.Controls.Add(this.bttn_CerrarPanel);
                this.panel1.Controls.Add(this.bttn_Cancelarpedido_Cliente);
                this.panel1.Controls.Add(this.bttn_Entregarpedido_Cliente);
                this.panel1.Controls.Add(this.dataGridView_Historial);
                this.panel1.Controls.Add(this.txt_ClienteD);
                this.panel1.Controls.Add(this.lbl_ClienteD);
                this.panel1.Location = new System.Drawing.Point(188, 172);
                this.panel1.Name = "panel1";
                this.panel1.Size = new System.Drawing.Size(486, 355);
                this.panel1.TabIndex = 0;
                this.panel1.BringToFront();
                // 
                // lbl_ClienteD
                // 
                this.lbl_ClienteD.AutoSize = true;
                this.lbl_ClienteD.Location = new System.Drawing.Point(3, 11);
                this.lbl_ClienteD.Name = "lbl_ClienteD";
                this.lbl_ClienteD.Size = new System.Drawing.Size(42, 13);
                this.lbl_ClienteD.TabIndex = 0;
                this.lbl_ClienteD.Text = "Cliente:";
                // 
                // txt_ClienteD
                // 
                this.txt_ClienteD.Enabled = false;
                this.txt_ClienteD.Location = new System.Drawing.Point(51, 4);
                this.txt_ClienteD.Name = "txt_ClienteD";
                this.txt_ClienteD.Size = new System.Drawing.Size(225, 20);
                this.txt_ClienteD.TabIndex = 1;
                // 
                // dataGridView_Historial
                // 
                this.dataGridView_Historial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                            | System.Windows.Forms.AnchorStyles.Left)
                            | System.Windows.Forms.AnchorStyles.Right)));
                this.dataGridView_Historial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                this.dataGridView_Historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                this.dataGridView_Historial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_PedidoD,
            this.Id_ClienteD,
            this.Id_ProductoD,
            this.ProductoD,
            this.CantidadD});
                //this.UnidadD});
                this.dataGridView_Historial.Cursor = System.Windows.Forms.Cursors.Hand;
                this.dataGridView_Historial.Location = new System.Drawing.Point(6, 44);
                this.dataGridView_Historial.Name = "dataGridView_Historial";
                this.dataGridView_Historial.Size = new System.Drawing.Size(470, 264);
                this.dataGridView_Historial.TabIndex = 2;
                //this.dataGridView_Historial.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_Historial_MouseDoubleClick);
                // 
                // Id_PedidoD
                // 
                this.Id_PedidoD.HeaderText = "Id_Pedido";
                this.Id_PedidoD.Name = "Id_PedidoD";
                this.Id_PedidoD.Visible = false;
                // 
                // Id_ClienteD
                // 
                this.Id_ClienteD.HeaderText = "Id_ClienteD";
                this.Id_ClienteD.Name = "Id_ClienteD";
                this.Id_ClienteD.Visible = false;
                // 
                // Id_ProductoD
                // 
                this.Id_ProductoD.HeaderText = "Id_Producto";
                this.Id_ProductoD.Name = "Id_ProductoD";
                this.Id_ProductoD.Visible = false;
                // 
                // ProductoD
                // 
                this.ProductoD.HeaderText = "Producto";
                this.ProductoD.Name = "ProductoD";
                // 
                // CantidadD
                // 
                this.CantidadD.HeaderText = "Cantidad";
                this.CantidadD.Name = "CantidadD";
                // 
                // bttn_Entregarpedido_Cliente
                // 
                this.bttn_Entregarpedido_Cliente.Location = new System.Drawing.Point(19, 319);
                this.bttn_Entregarpedido_Cliente.Name = "bttn_Entregarpedido_Cliente";
                this.bttn_Entregarpedido_Cliente.Size = new System.Drawing.Size(105, 23);
                this.bttn_Entregarpedido_Cliente.TabIndex = 4;
                this.bttn_Entregarpedido_Cliente.Text = "Entregar pedido";
                this.bttn_Entregarpedido_Cliente.UseVisualStyleBackColor = true;
                this.bttn_Entregarpedido_Cliente.Click += new System.EventHandler(this.bttn_Entregarpedido_Cliente_Click);
                // 
                // bttn_Cancelarpedido_Cliente
                // 
                this.bttn_Cancelarpedido_Cliente.BackColor = System.Drawing.Color.Red;
                this.bttn_Cancelarpedido_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.bttn_Cancelarpedido_Cliente.ForeColor = System.Drawing.Color.White;
                this.bttn_Cancelarpedido_Cliente.Location = new System.Drawing.Point(343, 319);
                this.bttn_Cancelarpedido_Cliente.Name = "bttn_Cancelarpedido_Cliente";
                this.bttn_Cancelarpedido_Cliente.Size = new System.Drawing.Size(117, 23);
                this.bttn_Cancelarpedido_Cliente.TabIndex = 5;
                this.bttn_Cancelarpedido_Cliente.Text = "Cancelar pedido";
                this.bttn_Cancelarpedido_Cliente.UseVisualStyleBackColor = false;
                this.bttn_Cancelarpedido_Cliente.Click += new System.EventHandler(this.bttn_Cancelarpedido_Cliente_Click);
                // 
                // bttn_CerrarPanel
                // 
                this.bttn_CerrarPanel.BackColor = System.Drawing.Color.Red;
                this.bttn_CerrarPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.bttn_CerrarPanel.ForeColor = System.Drawing.Color.White;
                this.bttn_CerrarPanel.Location = new System.Drawing.Point(453, 1);
                this.bttn_CerrarPanel.Name = "bttn_CerrarPanel";
                this.bttn_CerrarPanel.Size = new System.Drawing.Size(23, 23);
                this.bttn_CerrarPanel.TabIndex = 3;
                this.bttn_CerrarPanel.Text = "X";
                this.bttn_CerrarPanel.UseVisualStyleBackColor = false;
                this.bttn_CerrarPanel.Click += new System.EventHandler(this.bttn_CerrarPanel_Click);
                #endregion
                #region Agreando panel al control
                this.Controls.Add(this.panel1);
                #endregion
                #region Llenando datos
                idpend = Convert.ToInt32(dataGridView_Pedidos.CurrentRow.Cells["Id_Pedido"].Value);
                LLenando_PedidosClientesDetalle();
                try
                {
                    panel_PedidoClientes.Dispose();         //   Libero de la memoria el panel de pedido para quitarlo
                    Controls.Remove(panel_PedidoClientes);  //   Quito el control de la ventana
                    Control_Historial_Clientes();           //   Vuelvo a crear el control con el fin de que aparesca en la parte de atras
                    dataGridView_Historial.Focus();
                }
                catch (Exception)
                {
                    //En caso de ocurrir un error omite la instrucción
                    throw;
                }
                #endregion
        }
        private void bttn_CerrarPanel_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Dispose();
                Controls.Remove(this.panel1);
            }
            catch (Exception)
            {
                //En caso de error se omite la instrucción
                throw;
            }
        }
        private void bttn_Entregarpedido_Cliente_Click(object sender, EventArgs e)
        {

        }

        private void bttn_Cancelarpedido_Cliente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Quieres cancelar realmente el pedido?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //EN CASO DE SER VERDADERO DARA DE BAJA EL PEDIDO
                int idpend = Convert.ToInt32(dataGridView_Pedidos.CurrentRow.Cells["Id_Pedido"].Value);
                #region Procedimiento para dar de baja el pedido
                OleDbConnection conexion = null;
                OleDbTransaction transaccion = null;
                try
                {
                    conexion = new OleDbConnection(ObtenerString());
                    conexion.Open();
                    transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                    OleDbCommand comando = new OleDbCommand("SP_Pedido_Cancelado", conexion, transaccion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@Id_Pedido", idpend);
                    comando.ExecuteNonQuery();
                    transaccion.Commit();
                    MessageBox.Show("Datos guardados con éxito", "Solicitud procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                #endregion
                try
                {
                    panel1.Dispose();
                    Controls.Remove(this.panel1);
                    LLenando_PedidosClientes();
                }
                catch (Exception)
                {
                    //En caso de error se omite la instrucción
                    throw;
                }
            }
        }
        //-------------------------------------------------------------
        //-----------SECCION DE LLENADO DE CONTROLES-------------------
        //-------------------------------------------------------------
        private void LLenando_PedidosClientes()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "SELECT Tb_Pedido.Id_Pedido, Tb_Pedido.Id_Cliente, Tb_Pedido.Cantidad_Articulos, Tb_Pedido.Total, Tb_Pedido.Fecha, Tb_Cliente.Nombre, Tb_Cliente.Apellido_P, Tb_Cliente.Apellido_M FROM Tb_Pedido INNER JOIN Tb_Cliente ON Tb_Pedido.Id_Cliente = Tb_Cliente.Id_Cliente WHERE (Tb_Pedido.Id_ConceptoPedido = 1)";
            coman.CommandType = CommandType.Text;
            con.Open();
            dataGridView_Pedidos.Rows.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Creando y obteniendo el indice para un nuevo renglon
                int Indice = dataGridView_Pedidos.Rows.Add();
                string Nombre=dr.GetString(dr.GetOrdinal("Nombre"));
                string Apellido_P=dr.GetString(dr.GetOrdinal("Apellido_P"));
                string Apellido_M=dr.GetString(dr.GetOrdinal("Apellido_M"));
                string Client=Nombre+" "+Apellido_P+" "+Apellido_M;
                dataGridView_Pedidos.Rows[Indice].Cells["Id_Pedido"].Value = dr.GetInt32(dr.GetOrdinal("Id_Pedido"));
                dataGridView_Pedidos.Rows[Indice].Cells["Id_Cliente"].Value = dr.GetInt32(dr.GetOrdinal("Id_Cliente"));
                dataGridView_Pedidos.Rows[Indice].Cells["Cliente"].Value = Client;
                dataGridView_Pedidos.Rows[Indice].Cells["Fecha_Pedido"].Value = dr.GetDateTime(dr.GetOrdinal("Fecha")).ToShortDateString();
            }
            con.Close();
        }
        private void LLenando_PedidosClientesDetalle()
        {
            //int idpend = Convert.ToInt32(dataGridView_Pedidos.CurrentRow.Cells["Id_Pedido"].Value);
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "SELECT Tb_Pedido_Detalle.Id_Pedido, Tb_Pedido_Detalle.Id_Producto, Tb_Pedido_Detalle.Cantidad_Articulos, Tb_Producto.Nombre AS Producto, Tb_Pedido.Id_Cliente FROM Tb_Pedido_Detalle INNER JOIN Tb_Producto ON Tb_Pedido_Detalle.Id_Producto = Tb_Producto.Id_Producto INNER JOIN Tb_Pedido ON Tb_Pedido_Detalle.Id_Pedido = Tb_Pedido.Id_Pedido WHERE (Tb_Pedido_Detalle.Id_Pedido ='" + idpend + "')";
            coman.CommandType = CommandType.Text;
            con.Open();
            dataGridView_Historial.Rows.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Creando y obteniendo el indice para un nuevo renglon
                int Indice = dataGridView_Historial.Rows.Add();
                dataGridView_Historial.Rows[Indice].Cells["Id_PedidoD"].Value = dr.GetInt32(dr.GetOrdinal("Id_Pedido"));
                dataGridView_Historial.Rows[Indice].Cells["Id_ClienteD"].Value = dr.GetInt32(dr.GetOrdinal("Id_Cliente"));
                dataGridView_Historial.Rows[Indice].Cells["Id_ProductoD"].Value = dr.GetInt32(dr.GetOrdinal("Id_Cliente"));
                dataGridView_Historial.Rows[Indice].Cells["ProductoD"].Value = dr.GetString(dr.GetOrdinal("Producto"));
                dataGridView_Historial.Rows[Indice].Cells["CantidadD"].Value = dr.GetDecimal(dr.GetOrdinal("Cantidad_Articulos")).ToString("N") ;
            }
            con.Close();
            txt_ClienteD.Text =Convert.ToString(dataGridView_Pedidos.CurrentRow.Cells["Cliente"].Value);
        }
        #endregion
        #endregion
        #endregion
        #region  Pedidos Proveedores
        private void Historial_PedidosProveedoresStripMenuItem_Click(object sender, EventArgs e)
        {
            try //Quita el panel de control en caso de que ya se haya utilizado
            {
                //Quito el panel de busqueda
                Controls.Remove(panel_PedidoClientes);
            }
            catch (Exception)
            {
                //En caso de que no existe todavia el panel panel_PedidoClientes
                //omite la instrucción de quitar dicho control
            }
            Control_Historial_Proveedores();
        }
        //  CREANDO CONTROLES PARA EL HISTORIAL DE PEDIDOS DE PROVEEDORES
        #region Diseños Control_Historial_Proveedores
        #region Declarando controles para el panel de historial de proveedores
            private System.Windows.Forms.Panel panel_PedidoProveedores;
            private System.Windows.Forms.DataGridView dataGridView_PedidosPROVEEDORES;
            private System.Windows.Forms.Button bttn_CerrarPanelPROVEEDORES;
            private System.Windows.Forms.Label lbl_PedidoProveedores;
            private System.Windows.Forms.DataGridViewTextBoxColumn Id_PedidoProveedor;
            private System.Windows.Forms.DataGridViewTextBoxColumn Id_Proveedor;
            private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
            private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_PedidoProveedor;
        #endregion
        private void Control_Historial_Proveedores()
            {
                #region Creando controles para el panl de historial de proveedores
                this.panel_PedidoProveedores = new System.Windows.Forms.Panel();
                this.lbl_PedidoProveedores = new System.Windows.Forms.Label();
                this.bttn_CerrarPanelPROVEEDORES = new System.Windows.Forms.Button();
                this.dataGridView_PedidosPROVEEDORES = new System.Windows.Forms.DataGridView();
                this.Id_PedidoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.Id_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.Fecha_PedidoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.panel_PedidoProveedores.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PedidosPROVEEDORES)).BeginInit();
                this.SuspendLayout();
                #endregion
                #region Agregando diseño para el panel de historial de proveedores
                    // 
                    // panel_PedidoProveedores
                    // 
                    this.panel_PedidoProveedores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    this.panel_PedidoProveedores.Controls.Add(this.lbl_PedidoProveedores);
                    this.panel_PedidoProveedores.Controls.Add(this.bttn_CerrarPanelPROVEEDORES);
                    this.panel_PedidoProveedores.Controls.Add(this.dataGridView_PedidosPROVEEDORES);
                    this.panel_PedidoProveedores.Location = new System.Drawing.Point(100, 174);
                    this.panel_PedidoProveedores.Name = "panel_PedidoProveedores";
                    this.panel_PedidoProveedores.Size = new System.Drawing.Size(719, 387);
                    this.panel_PedidoProveedores.TabIndex = 1;
                    // 
                    // lbl_PedidoProveedores
                    // 
                    this.lbl_PedidoProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                | System.Windows.Forms.AnchorStyles.Left)));
                    this.lbl_PedidoProveedores.AutoSize = true;
                    this.lbl_PedidoProveedores.Location = new System.Drawing.Point(269, 9);
                    this.lbl_PedidoProveedores.Name = "lbl_PedidoProveedores";
                    this.lbl_PedidoProveedores.Size = new System.Drawing.Size(209, 13);
                    this.lbl_PedidoProveedores.TabIndex = 5;
                    this.lbl_PedidoProveedores.Text = "LISTA DE PEDIDOS DE PROVEEDORES";
                    this.lbl_PedidoProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    // 
                    // bttn_CerrarPanelPROVEEDORES
                    // 
                    this.bttn_CerrarPanelPROVEEDORES.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                | System.Windows.Forms.AnchorStyles.Right)));
                    this.bttn_CerrarPanelPROVEEDORES.BackColor = System.Drawing.Color.Red;
                    this.bttn_CerrarPanelPROVEEDORES.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.bttn_CerrarPanelPROVEEDORES.ForeColor = System.Drawing.Color.White;
                    this.bttn_CerrarPanelPROVEEDORES.Location = new System.Drawing.Point(690, 3);
                    this.bttn_CerrarPanelPROVEEDORES.MaximumSize = new System.Drawing.Size(23, 23);
                    this.bttn_CerrarPanelPROVEEDORES.MinimumSize = new System.Drawing.Size(23, 23);
                    this.bttn_CerrarPanelPROVEEDORES.Name = "bttn_CerrarPanelPROVEEDORES";
                    this.bttn_CerrarPanelPROVEEDORES.Size = new System.Drawing.Size(23, 23);
                    this.bttn_CerrarPanelPROVEEDORES.TabIndex = 4;
                    this.bttn_CerrarPanelPROVEEDORES.Text = "X";
                    this.bttn_CerrarPanelPROVEEDORES.UseVisualStyleBackColor = false;
                    this.bttn_CerrarPanelPROVEEDORES.Click += new System.EventHandler(this.bttn_CerrarPanelPROVEEDORES_Click);
                    // 
                    // dataGridView_PedidosPROVEEDORES
                    // 
                    this.dataGridView_PedidosPROVEEDORES.AllowUserToAddRows = false;
                    this.dataGridView_PedidosPROVEEDORES.AllowUserToDeleteRows = false;
                    this.dataGridView_PedidosPROVEEDORES.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                | System.Windows.Forms.AnchorStyles.Left)
                                | System.Windows.Forms.AnchorStyles.Right)));
                    this.dataGridView_PedidosPROVEEDORES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                    this.dataGridView_PedidosPROVEEDORES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                    this.dataGridView_PedidosPROVEEDORES.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.Id_PedidoProveedor,
                this.Id_Proveedor,
                this.Proveedor,
                this.Fecha_PedidoProveedor});
                    this.dataGridView_PedidosPROVEEDORES.Location = new System.Drawing.Point(3, 32);
                    this.dataGridView_PedidosPROVEEDORES.Name = "dataGridView_PedidosPROVEEDORES";
                    this.dataGridView_PedidosPROVEEDORES.ReadOnly = true;
                    this.dataGridView_PedidosPROVEEDORES.Size = new System.Drawing.Size(712, 350);
                    this.dataGridView_PedidosPROVEEDORES.TabIndex = 1;
                    this.dataGridView_PedidosPROVEEDORES.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_PedidosPROVEEDORES_MouseDoubleClick);
                    // 
                    // Id_PedidoProveedor
                    // 
                    this.Id_PedidoProveedor.HeaderText = "Id_Pedido";
                    this.Id_PedidoProveedor.Name = "Id_PedidoProveedor";
                    this.Id_PedidoProveedor.ReadOnly = true;
                    this.Id_PedidoProveedor.Visible = false;
                    // 
                    // Id_Proveedor
                    // 
                    this.Id_Proveedor.HeaderText = "Id_Proveedor";
                    this.Id_Proveedor.Name = "Id_Proveedor";
                    this.Id_Proveedor.ReadOnly = true;
                    this.Id_Proveedor.Visible = false;
                    // 
                    // Proveedor
                    // 
                    this.Proveedor.HeaderText = "Proveedor";
                    this.Proveedor.Name = "Proveedor";
                    this.Proveedor.ReadOnly = true;
                    // 
                    // Fecha_PedidoProveedor
                    // 
                    this.Fecha_PedidoProveedor.HeaderText = "Fecha Pedido";
                    this.Fecha_PedidoProveedor.Name = "Fecha_PedidoProveedor";
                    this.Fecha_PedidoProveedor.ReadOnly = true;
                    // 
                    // MENU PRINCIPAL
                    // 
                    this.Controls.Add(this.panel_PedidoProveedores);
                #endregion
            }
        //  EVENTOS DEL PANEL DE PEDIDOS PROVEEDORES
        #region Boton Cerrar Panel Proveedores
        private void bttn_CerrarPanelPROVEEDORES_Click(object sender, EventArgs e)
        {
            try //Quita el panel de control en caso de que ya se haya utilizado
            {
                //Quito el panel de busqueda
                Controls.Remove(panel_PedidoProveedores);
            }
            catch (Exception)
            {
                //En caso de que no existe todavia el panel panel_PedidoProveedores
                //omite la instrucción de quitar dicho control
            }
        }
        #region Desgloce de productos pedidos por Proveedores
        private void dataGridView_PedidosPROVEEDORES_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        #endregion
        #endregion
        #endregion
        #endregion
        //-------------------------------------------------------------
        //---------------SECCION DE DIRECTORIOS------------------------
        //-------------------------------------------------------------
        #region Checar y crear directorios
        private void Verificar_Creardirectorio()
        {
            string ruta = @"C:\Shajobe\Imagenes";
            if (System.IO.Directory.Exists(ruta))
            {
                //En caso de que existe este directorio dentro de C: no hara nada
            }
            else
            {
                //En caso de que no exista este directorio se creara dicho directorio
                CrearDirectorioImagenes();
            }
        }
        public void CrearDirectorioImagenes()
        {
            //Indico la direccion donde quiero generar mi carpeta
            string Nombre_Carpeta = @"C:\Shajobe";
            //Creo mi carpeta y una subcarpeta dentro
            string DireccionString = System.IO.Path.Combine(Nombre_Carpeta, "Imagenes");
            System.IO.Directory.CreateDirectory(DireccionString);

        }
        #endregion
        //-------------------------------------------------------------
        //------  Cierra la sesión antes de cerrar la apliación  ------
        //-------------------------------------------------------------
        private void Menu_Principal_FormClosing(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quieres cerrar la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //OBTENIENDO EL ID DE LA CUENTA ACTIVA
                int Ultimo_Id = 0;
                OleDbConnection con = new OleDbConnection();
                OleDbCommand coman = new OleDbCommand();
                OleDbDataReader dr;
                con.ConnectionString = ObtenerString();
                coman.Connection = con;
                coman.CommandText = "select Id_Usuario from Tb_Usuarios_Login where Estado='A'";
                coman.CommandType = CommandType.Text;
                con.Open();
                dr = coman.ExecuteReader();
                while (dr.Read())
                {
                    Ultimo_Id = dr.GetInt32(dr.GetOrdinal("Id_Usuario"));
                }
                con.Close();
                //CREANDO REGISTRO DE DESLOGUEO
                OleDbConnection conexion = null;
                OleDbTransaction transaccion = null;
                conexion = new OleDbConnection(ObtenerString());
                conexion.Open();
                transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                OleDbCommand comando = new OleDbCommand("SP_Login_Desconectar", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@VId_Usuario", Ultimo_Id);
                comando.ExecuteNonQuery();
                transaccion.Commit();
                conexion.Close();
                Application.Exit();
            }

        }
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
        //------Obtiene los permisos y menus que tiene derecho ver-----
        //-------------------------------------------------------------
        public void Carga_Permisos()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbDataReader dr;
            OleDbCommand com = new OleDbCommand();
            con.ConnectionString = ObtenerString();
            com.Connection = con;
            com.CommandText = "Select Id_Menu From Tb_Permisos where Id_Tipo_Usuario=(Select Id_Tipo_Usuario From Tb_Usuario Where Id_Usuario='" + I + "')";
            com.CommandType = CommandType.Text;
            con.Open();
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                int Id_Menu = dr.GetInt32(dr.GetOrdinal("Id_Menu"));
                if (Id_Menu == 1) Bttn_Cliente.Enabled = true;
                if (Id_Menu == 2) bttn_Proveedores.Enabled = true;
                if (Id_Menu == 3) bttn_split_Reportes.Enabled = true;
                if (Id_Menu == 4) bttn_split_Inventarios.Enabled = true;
                if (Id_Menu == 5) bttn_split_Financiero.Enabled = true;
                if (Id_Menu == 6) bttn_split_Mantenimiento.Enabled = true;
                if (Id_Menu == 7) bttn_split_Seguridad.Enabled = true;
                if (Id_Menu == 8) Capturar_Imagenes.Enabled = true;
                if (Id_Menu == 9) Codigo_Barra.Enabled = true;
                if (Id_Menu == 10) Pedidos_Clientes.Enabled = true;
                if (Id_Menu == 11) Pedidos_Proveedores.Enabled = true;

            }
            con.Close();
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
