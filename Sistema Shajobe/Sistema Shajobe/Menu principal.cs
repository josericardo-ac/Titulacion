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
        private System.Windows.Forms.ToolStripMenuItem tipoDePiezasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TipodeMateriaPrimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator tool_Separador_Tipos;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiaPrimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator tool_Separator;
        private System.Windows.Forms.ToolStripMenuItem almacénToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem UsuarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem RespaldoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Tipo_UsuarioToolStripMenuItem1;
        private System.Windows.Forms.Button Capturar_Imagenes;
        private System.Windows.Forms.Button Codigo_Barra;
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
            tipoDePiezasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            TipodeMateriaPrimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            Tipo_UsuarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            almacénToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            materiaPrimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            UsuarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            RespaldoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            tool_Separador_Tipos = new System.Windows.Forms.ToolStripSeparator();
            tool_Separator = new System.Windows.Forms.ToolStripSeparator();
            pic_Logo = new System.Windows.Forms.PictureBox();
            Capturar_Imagenes = new System.Windows.Forms.Button();
            Codigo_Barra = new System.Windows.Forms.Button();
            statusStrip1.SuspendLayout();
            Barra_menu.SuspendLayout();
            SuspendLayout();
            #endregion
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
            bttn_split_Reportes.Image = global::Sistema_Shajobe.Properties.Resources.Reportes;
            bttn_split_Reportes.ImageTransparentColor = System.Drawing.Color.Magenta;
            bttn_split_Reportes.Name = "bttn_split_Reportes";
            bttn_split_Reportes.Size = new System.Drawing.Size(85, 22);
            bttn_split_Reportes.Text = "&Reportes";
            bttn_split_Reportes.Enabled = false;
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
            ventasPedidosToolStripMenuItem});
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
            UsuarioToolStripMenuItem1, RespaldoToolStripMenuItem1});
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
            ClientSize = new System.Drawing.Size(848, 430);
            Controls.Add(Barra_menu);
            Controls.Add(statusStrip1);
            Controls.Add(Capturar_Imagenes);
            Controls.Add(Codigo_Barra);
            Controls.Add(pic_Logo);
            ControlBox = false;
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
