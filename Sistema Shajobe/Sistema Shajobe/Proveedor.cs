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
    public partial class Proveedor : Form
    {
        public Proveedor()
        {
            InitializeComponent();
        }
        #region Diseño de la forma
        #region Creando controles de la forma
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercadeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pic_Proveedor;
        private System.Windows.Forms.GroupBox groupBoxdatos;
        private System.Windows.Forms.GroupBox groupBoxfoto;
        private System.Windows.Forms.Button btn_BuscarI;
        private System.Windows.Forms.TextBox txt_Diascredito;
        private System.Windows.Forms.TextBox txt_LimiteCredito;
        private System.Windows.Forms.TextBox txt_Saldo;
        private System.Windows.Forms.TextBox txt_NombreContacto;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.TextBox txt_CP;
        private System.Windows.Forms.TextBox txt_Estado;
        private System.Windows.Forms.TextBox txt_Ciudad;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.TextBox txt_ApellidoM;
        private System.Windows.Forms.TextBox txt_ApellidoP;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_RazonSocial;
        private System.Windows.Forms.TextBox txt_RFC;
        private System.Windows.Forms.Label lbl_Dias;
        private System.Windows.Forms.Label lbl_LimiteCredito;
        private System.Windows.Forms.Label lbl_Saldo;
        private System.Windows.Forms.Label lbl_NombreContacto;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Label lbl_CP;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.Label lbl_Ciudad;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.Label lbl_ApellidoM;
        private System.Windows.Forms.Label lbl_ApellidoP;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Razon_Social;
        private System.Windows.Forms.Label lbl_RFC;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private PictureBox pic_Logo;
        #endregion
        private void Diseño_Forma()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            acercadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pic_Proveedor = new System.Windows.Forms.PictureBox();
            groupBoxdatos = new System.Windows.Forms.GroupBox();
            groupBoxfoto = new System.Windows.Forms.GroupBox();
            btn_BuscarI = new System.Windows.Forms.Button();
            txt_Diascredito = new System.Windows.Forms.TextBox();
            txt_LimiteCredito = new System.Windows.Forms.TextBox();
            txt_Saldo = new System.Windows.Forms.TextBox();
            txt_NombreContacto = new System.Windows.Forms.TextBox();
            txt_Email = new System.Windows.Forms.TextBox();
            txt_Telefono = new System.Windows.Forms.TextBox();
            txt_CP = new System.Windows.Forms.TextBox();
            txt_Estado = new System.Windows.Forms.TextBox();
            txt_Ciudad = new System.Windows.Forms.TextBox();
            txt_Direccion = new System.Windows.Forms.TextBox();
            txt_ApellidoM = new System.Windows.Forms.TextBox();
            txt_ApellidoP = new System.Windows.Forms.TextBox();
            txt_Nombre = new System.Windows.Forms.TextBox();
            txt_RazonSocial = new System.Windows.Forms.TextBox();
            txt_RFC = new System.Windows.Forms.TextBox();
            lbl_Dias = new System.Windows.Forms.Label();
            lbl_LimiteCredito = new System.Windows.Forms.Label();
            lbl_Saldo = new System.Windows.Forms.Label();
            lbl_NombreContacto = new System.Windows.Forms.Label();
            lbl_Email = new System.Windows.Forms.Label();
            lbl_Telefono = new System.Windows.Forms.Label();
            lbl_CP = new System.Windows.Forms.Label();
            lbl_Estado = new System.Windows.Forms.Label();
            lbl_Ciudad = new System.Windows.Forms.Label();
            lbl_Direccion = new System.Windows.Forms.Label();
            lbl_ApellidoM = new System.Windows.Forms.Label();
            lbl_ApellidoP = new System.Windows.Forms.Label();
            lbl_Nombre = new System.Windows.Forms.Label();
            lbl_Razon_Social = new System.Windows.Forms.Label();
            lbl_RFC = new System.Windows.Forms.Label();
            pic_Logo = new System.Windows.Forms.PictureBox();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pic_Proveedor)).BeginInit();
            groupBoxdatos.SuspendLayout();
            groupBoxfoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(errorProvider1)).BeginInit();
            SuspendLayout();
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
            menuStrip1.Size = new System.Drawing.Size(604, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            nuevoToolStripMenuItem,
            abrirToolStripMenuItem,
            toolStripSeparator,
            guardarToolStripMenuItem,
            toolStripSeparator2,
            salirToolStripMenuItem});
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            nuevoToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Nuevo;
            nuevoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            nuevoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
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
            abrirToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            abrirToolStripMenuItem.Text = "&Abrir";
            abrirToolStripMenuItem.Click += new System.EventHandler(abrirToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new System.Drawing.Size(153, 6);
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripMenuItem.Image")));
            guardarToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Guardar;
            guardarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            guardarToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            guardarToolStripMenuItem.Text = "&Guardar";
            guardarToolStripMenuItem.Click += new System.EventHandler(guardarToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(153, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            salirToolStripMenuItem.Text = "&Salir";
            salirToolStripMenuItem.Click += new System.EventHandler(salirToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripSeparator3,
            modificarToolStripMenuItem,
            eliminarToolStripMenuItem});
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            editarToolStripMenuItem.Text = "&Editar";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(122, 6);
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.Enabled = false;
            modificarToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Modificar;
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            modificarToolStripMenuItem.Text = "Modificar";
            modificarToolStripMenuItem.Click += new System.EventHandler(modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Enabled = false;
            eliminarToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Borrar;
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += new System.EventHandler(eliminarToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            acercadeToolStripMenuItem});
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            ayudaToolStripMenuItem.Text = "Ay&uda";
            // 
            // acercadeToolStripMenuItem
            // 
            acercadeToolStripMenuItem.Name = "acercadeToolStripMenuItem";
            acercadeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            acercadeToolStripMenuItem.Text = "&Acerca de...";
            // 
            // pic_Logo
            // 
            pic_Logo.BackgroundImage = global::Sistema_Shajobe.Properties.Resources.Logo_Shajobe;
            pic_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pic_Logo.Location = new System.Drawing.Point(380, 380);
            pic_Logo.Name = "pic_Logo";
            pic_Logo.Size = new System.Drawing.Size(166, 84);
            pic_Logo.TabIndex = 13;
            pic_Logo.TabStop = false;
            // 
            // pic_Proveedor
            // 
            pic_Proveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Proveedor.BackgroundImage")));
            pic_Proveedor.BackgroundImage = global::Sistema_Shajobe.Properties.Resources.Proveedores;
            pic_Proveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pic_Proveedor.Location = new System.Drawing.Point(493, 25);
            pic_Proveedor.Name = "pic_Proveedor";
            pic_Proveedor.Size = new System.Drawing.Size(85, 67);
            pic_Proveedor.TabIndex = 7;
            pic_Proveedor.TabStop = false;
            // 
            // groupBoxdatos
            // 
            groupBoxdatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            groupBoxdatos.Controls.Add(groupBoxfoto);
            groupBoxdatos.Controls.Add(pic_Logo);
            groupBoxdatos.Controls.Add(txt_Diascredito);
            groupBoxdatos.Controls.Add(txt_LimiteCredito);
            groupBoxdatos.Controls.Add(txt_Saldo);
            groupBoxdatos.Controls.Add(txt_NombreContacto);
            groupBoxdatos.Controls.Add(txt_Email);
            groupBoxdatos.Controls.Add(txt_Telefono);
            groupBoxdatos.Controls.Add(txt_CP);
            groupBoxdatos.Controls.Add(txt_Estado);
            groupBoxdatos.Controls.Add(txt_Ciudad);
            groupBoxdatos.Controls.Add(txt_Direccion);
            groupBoxdatos.Controls.Add(txt_ApellidoM);
            groupBoxdatos.Controls.Add(txt_ApellidoP);
            groupBoxdatos.Controls.Add(txt_Nombre);
            groupBoxdatos.Controls.Add(txt_RazonSocial);
            groupBoxdatos.Controls.Add(txt_RFC);
            groupBoxdatos.Controls.Add(lbl_Dias);
            groupBoxdatos.Controls.Add(lbl_LimiteCredito);
            groupBoxdatos.Controls.Add(lbl_Saldo);
            groupBoxdatos.Controls.Add(lbl_NombreContacto);
            groupBoxdatos.Controls.Add(lbl_Email);
            groupBoxdatos.Controls.Add(lbl_Telefono);
            groupBoxdatos.Controls.Add(lbl_CP);
            groupBoxdatos.Controls.Add(lbl_Estado);
            groupBoxdatos.Controls.Add(lbl_Ciudad);
            groupBoxdatos.Controls.Add(lbl_Direccion);
            groupBoxdatos.Controls.Add(lbl_ApellidoM);
            groupBoxdatos.Controls.Add(lbl_ApellidoP);
            groupBoxdatos.Controls.Add(lbl_Nombre);
            groupBoxdatos.Controls.Add(lbl_Razon_Social);
            groupBoxdatos.Controls.Add(lbl_RFC);
            groupBoxdatos.Location = new System.Drawing.Point(8, 52);
            groupBoxdatos.Name = "groupBoxdatos";
            groupBoxdatos.Size = new System.Drawing.Size(578, 533);
            groupBoxdatos.TabIndex = 6;
            groupBoxdatos.TabStop = false;
            groupBoxdatos.Text = "Datos del proveedor";
            // 
            // groupBoxfoto
            // 
            groupBoxfoto.Controls.Add(btn_BuscarI);
            groupBoxfoto.Location = new System.Drawing.Point(301, 31);
            groupBoxfoto.Name = "groupBoxfoto";
            groupBoxfoto.Size = new System.Drawing.Size(237, 236);
            groupBoxfoto.TabIndex = 31;
            groupBoxfoto.TabStop = false;
            groupBoxfoto.Text = "Foto de contacto";
            // 
            // btn_BuscarI
            // 
            btn_BuscarI.Location = new System.Drawing.Point(156, 207);
            btn_BuscarI.Name = "btn_BuscarI";
            btn_BuscarI.Size = new System.Drawing.Size(75, 23);
            btn_BuscarI.TabIndex = 33;
            btn_BuscarI.Text = "Añadir imagen";
            btn_BuscarI.UseVisualStyleBackColor = true;
            btn_BuscarI.Click += new System.EventHandler(btn_BuscarI_Click);
            // 
            // txt_Diascredito
            // 
            txt_Diascredito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            txt_Diascredito.Location = new System.Drawing.Point(127, 473);
            txt_Diascredito.MaxLength = 3;
            txt_Diascredito.Name = "txt_Diascredito";
            txt_Diascredito.Size = new System.Drawing.Size(127, 20);
            txt_Diascredito.TabIndex = 30;
            txt_Diascredito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_Diascredito_KeyPress);
            // 
            // txt_LimiteCredito
            // 
            txt_LimiteCredito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            txt_LimiteCredito.Location = new System.Drawing.Point(127, 448);
            txt_LimiteCredito.MaxLength = 9;
            txt_LimiteCredito.Name = "txt_LimiteCredito";
            txt_LimiteCredito.Size = new System.Drawing.Size(127, 20);
            txt_LimiteCredito.TabIndex = 29;
            txt_LimiteCredito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_LimiteCredito_KeyPress);
            // 
            // txt_Saldo
            // 
            txt_Saldo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            txt_Saldo.Location = new System.Drawing.Point(127, 423);
            txt_Saldo.MaxLength = 9;
            txt_Saldo.Name = "txt_Saldo";
            txt_Saldo.Size = new System.Drawing.Size(127, 20);
            txt_Saldo.TabIndex = 28;
            txt_Saldo.Text = "0.00";
            txt_Saldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_Saldo_KeyPress);
            // 
            // txt_NombreContacto
            // 
            txt_NombreContacto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            txt_NombreContacto.Location = new System.Drawing.Point(127, 398);
            txt_NombreContacto.Name = "txt_NombreContacto";
            txt_NombreContacto.Size = new System.Drawing.Size(127, 20);
            txt_NombreContacto.TabIndex = 27;
            txt_NombreContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_NombreContacto_KeyPress);
            // 
            // txt_Email
            // 
            txt_Email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            txt_Email.Location = new System.Drawing.Point(127, 373);
            txt_Email.MaxLength = 30;
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new System.Drawing.Size(127, 20);
            txt_Email.TabIndex = 26;
            // 
            // txt_Telefono
            // 
            txt_Telefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            txt_Telefono.Location = new System.Drawing.Point(127, 348);
            txt_Telefono.MaxLength = 10;
            txt_Telefono.Name = "txt_Telefono";
            txt_Telefono.Size = new System.Drawing.Size(127, 20);
            txt_Telefono.TabIndex = 25;
            txt_Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_Telefono_KeyPress);
            // 
            // txt_CP
            // 
            txt_CP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            txt_CP.Location = new System.Drawing.Point(127, 323);
            txt_CP.MaxLength = 5;
            txt_CP.Name = "txt_CP";
            txt_CP.Size = new System.Drawing.Size(127, 20);
            txt_CP.TabIndex = 24;
            txt_CP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_CP_KeyPress);
            // 
            // txt_Estado
            // 
            txt_Estado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            txt_Estado.Location = new System.Drawing.Point(127, 298);
            txt_Estado.MaxLength = 30;
            txt_Estado.Name = "txt_Estado";
            txt_Estado.Size = new System.Drawing.Size(127, 20);
            txt_Estado.TabIndex = 23;
            txt_Estado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_Estado_KeyPress);
            // 
            // txt_Ciudad
            // 
            txt_Ciudad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            txt_Ciudad.Location = new System.Drawing.Point(127, 273);
            txt_Ciudad.MaxLength = 30;
            txt_Ciudad.Name = "txt_Ciudad";
            txt_Ciudad.Size = new System.Drawing.Size(127, 20);
            txt_Ciudad.TabIndex = 22;
            txt_Ciudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_Ciudad_KeyPress);
            // 
            // txt_Direccion
            // 
            txt_Direccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            txt_Direccion.Location = new System.Drawing.Point(127, 163);
            txt_Direccion.MaxLength = 200;
            txt_Direccion.Multiline = true;
            txt_Direccion.Name = "txt_Direccion";
            txt_Direccion.Size = new System.Drawing.Size(127, 103);
            txt_Direccion.TabIndex = 21;
            // 
            // txt_ApellidoM
            // 
            txt_ApellidoM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            txt_ApellidoM.Location = new System.Drawing.Point(127, 138);
            txt_ApellidoM.MaxLength = 15;
            txt_ApellidoM.Name = "txt_ApellidoM";
            txt_ApellidoM.Size = new System.Drawing.Size(127, 20);
            txt_ApellidoM.TabIndex = 20;
            txt_ApellidoM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_ApellidoM_KeyPress);
            // 
            // txt_ApellidoP
            // 
            txt_ApellidoP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            txt_ApellidoP.Location = new System.Drawing.Point(127, 113);
            txt_ApellidoP.MaxLength = 15;
            txt_ApellidoP.Name = "txt_ApellidoP";
            txt_ApellidoP.Size = new System.Drawing.Size(127, 20);
            txt_ApellidoP.TabIndex = 19;
            txt_ApellidoP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_ApellidoP_KeyPress);
            // 
            // txt_Nombre
            // 
            txt_Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            txt_Nombre.Location = new System.Drawing.Point(127, 88);
            txt_Nombre.MaxLength = 25;
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new System.Drawing.Size(127, 20);
            txt_Nombre.TabIndex = 18;
            txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_Nombre_KeyPress);
            // 
            // txt_RazonSocial
            // 
            txt_RazonSocial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            txt_RazonSocial.Location = new System.Drawing.Point(127, 63);
            txt_RazonSocial.MaxLength = 100;
            txt_RazonSocial.Name = "txt_RazonSocial";
            txt_RazonSocial.Size = new System.Drawing.Size(127, 20);
            txt_RazonSocial.TabIndex = 17;
            txt_RazonSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_RazonSocial_KeyPress);
            // 
            // txt_RFC
            // 
            txt_RFC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            txt_RFC.Location = new System.Drawing.Point(127, 38);
            txt_RFC.MaxLength = 13;
            txt_RFC.Name = "txt_RFC";
            txt_RFC.Size = new System.Drawing.Size(127, 20);
            txt_RFC.TabIndex = 16;
            txt_RFC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_RFC_KeyPress);
            // 
            // lbl_Dias
            // 
            lbl_Dias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            lbl_Dias.AutoSize = true;
            lbl_Dias.Location = new System.Drawing.Point(28, 478);
            lbl_Dias.Name = "lbl_Dias";
            lbl_Dias.Size = new System.Drawing.Size(80, 13);
            lbl_Dias.TabIndex = 15;
            lbl_Dias.Text = "Días de crédito";
            // 
            // lbl_LimiteCredito
            // 
            lbl_LimiteCredito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            lbl_LimiteCredito.AutoSize = true;
            lbl_LimiteCredito.Location = new System.Drawing.Point(28, 453);
            lbl_LimiteCredito.Name = "lbl_LimiteCredito";
            lbl_LimiteCredito.Size = new System.Drawing.Size(84, 13);
            lbl_LimiteCredito.TabIndex = 14;
            lbl_LimiteCredito.Text = "Limite de crédito";
            // 
            // lbl_Saldo
            // 
            lbl_Saldo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            lbl_Saldo.AutoSize = true;
            lbl_Saldo.Location = new System.Drawing.Point(28, 428);
            lbl_Saldo.Name = "lbl_Saldo";
            lbl_Saldo.Size = new System.Drawing.Size(34, 13);
            lbl_Saldo.TabIndex = 13;
            lbl_Saldo.Text = "Saldo";
            // 
            // lbl_NombreContacto
            // 
            lbl_NombreContacto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            lbl_NombreContacto.AutoSize = true;
            lbl_NombreContacto.Location = new System.Drawing.Point(28, 403);
            lbl_NombreContacto.Name = "lbl_NombreContacto";
            lbl_NombreContacto.Size = new System.Drawing.Size(89, 13);
            lbl_NombreContacto.TabIndex = 12;
            lbl_NombreContacto.Text = "Nombre contacto";
            // 
            // lbl_Email
            // 
            lbl_Email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            lbl_Email.AutoSize = true;
            lbl_Email.Location = new System.Drawing.Point(28, 378);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new System.Drawing.Size(32, 13);
            lbl_Email.TabIndex = 11;
            lbl_Email.Text = "Email";
            // 
            // lbl_Telefono
            // 
            lbl_Telefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            lbl_Telefono.AutoSize = true;
            lbl_Telefono.Location = new System.Drawing.Point(28, 353);
            lbl_Telefono.Name = "lbl_Telefono";
            lbl_Telefono.Size = new System.Drawing.Size(49, 13);
            lbl_Telefono.TabIndex = 10;
            lbl_Telefono.Text = "Teléfono";
            // 
            // lbl_CP
            // 
            lbl_CP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            lbl_CP.AutoSize = true;
            lbl_CP.Location = new System.Drawing.Point(28, 328);
            lbl_CP.Name = "lbl_CP";
            lbl_CP.Size = new System.Drawing.Size(27, 13);
            lbl_CP.TabIndex = 9;
            lbl_CP.Text = "C.P.";
            // 
            // lbl_Estado
            // 
            lbl_Estado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            lbl_Estado.AutoSize = true;
            lbl_Estado.Location = new System.Drawing.Point(28, 303);
            lbl_Estado.Name = "lbl_Estado";
            lbl_Estado.Size = new System.Drawing.Size(40, 13);
            lbl_Estado.TabIndex = 8;
            lbl_Estado.Text = "Estado";
            // 
            // lbl_Ciudad
            // 
            lbl_Ciudad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            lbl_Ciudad.AutoSize = true;
            lbl_Ciudad.Location = new System.Drawing.Point(28, 278);
            lbl_Ciudad.Name = "lbl_Ciudad";
            lbl_Ciudad.Size = new System.Drawing.Size(40, 13);
            lbl_Ciudad.TabIndex = 7;
            lbl_Ciudad.Text = "Ciudad";
            // 
            // lbl_Direccion
            // 
            lbl_Direccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            lbl_Direccion.AutoSize = true;
            lbl_Direccion.Location = new System.Drawing.Point(28, 167);
            lbl_Direccion.Name = "lbl_Direccion";
            lbl_Direccion.Size = new System.Drawing.Size(52, 13);
            lbl_Direccion.TabIndex = 6;
            lbl_Direccion.Text = "Dirección";
            // 
            // lbl_ApellidoM
            // 
            lbl_ApellidoM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            lbl_ApellidoM.AutoSize = true;
            lbl_ApellidoM.Location = new System.Drawing.Point(28, 142);
            lbl_ApellidoM.Name = "lbl_ApellidoM";
            lbl_ApellidoM.Size = new System.Drawing.Size(85, 13);
            lbl_ApellidoM.TabIndex = 5;
            lbl_ApellidoM.Text = "Apellido materno";
            // 
            // lbl_ApellidoP
            // 
            lbl_ApellidoP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            lbl_ApellidoP.AutoSize = true;
            lbl_ApellidoP.Location = new System.Drawing.Point(28, 117);
            lbl_ApellidoP.Name = "lbl_ApellidoP";
            lbl_ApellidoP.Size = new System.Drawing.Size(83, 13);
            lbl_ApellidoP.TabIndex = 4;
            lbl_ApellidoP.Text = "Apellido paterno";
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Location = new System.Drawing.Point(28, 92);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new System.Drawing.Size(47, 13);
            lbl_Nombre.TabIndex = 3;
            lbl_Nombre.Text = "Nombre ";
            // 
            // lbl_Razon_Social
            // 
            lbl_Razon_Social.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            lbl_Razon_Social.AutoSize = true;
            lbl_Razon_Social.Location = new System.Drawing.Point(28, 67);
            lbl_Razon_Social.Name = "lbl_Razon_Social";
            lbl_Razon_Social.Size = new System.Drawing.Size(68, 13);
            lbl_Razon_Social.TabIndex = 2;
            lbl_Razon_Social.Text = "Razon social";
            // 
            // lbl_RFC
            // 
            lbl_RFC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            lbl_RFC.AutoSize = true;
            lbl_RFC.Location = new System.Drawing.Point(28, 42);
            lbl_RFC.Name = "lbl_RFC";
            lbl_RFC.Size = new System.Drawing.Size(31, 13);
            lbl_RFC.TabIndex = 1;
            lbl_RFC.Text = "RFC ";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Proveedor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(604, 606);
            Controls.Add(pic_Proveedor);
            Controls.Add(groupBoxdatos);
            Controls.Add(menuStrip1);
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(196)))));
            Icon = global::Sistema_Shajobe.Properties.Resources.Proveedores_ICO;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(610, 630);
            MinimumSize = new System.Drawing.Size(610, 630);
            Name = "Proveedor";
            Text = "Proveedor";
            Load += new System.EventHandler(Proveedor_Load);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pic_Proveedor)).EndInit();
            groupBoxdatos.ResumeLayout(false);
            groupBoxdatos.PerformLayout();
            groupBoxfoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(errorProvider1)).EndInit();
            AnimateWindow(this.Handle, 350, AnimateWindowFlags.AW_CENTER);
            AnimateWindow(this.Handle, 350, AnimateWindowFlags.AW_CENTER | AnimateWindowFlags.AW_SLIDE);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        #region Eventos
        //-------------------------------------------------------------
        //------------------Variables y Arreglos-----------------------
        //-------------------------------------------------------------
        private String Direccion_Imagen = "";
        private TextBox[] Campos = new TextBox[11];
        private int Idp;//LO USO PARA OBTENER EL ID COMO RESULTADO DE LA BUSQUEDA
        private bool Espacios_Vacios = false;
        private void Proveedor_Load(object sender, EventArgs e)
        {
            Diseño_Forma();
        }
        //-------------------------------------------------------------
        //----------------Limpia y restablece controles----------------
        //-------------------------------------------------------------
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txt_RFC.Clear();
            txt_RazonSocial.Clear();
            txt_Nombre.Clear();
            txt_ApellidoP.Clear();
            txt_ApellidoM.Clear();
            txt_Direccion.Clear();
            txt_Ciudad.Clear();
            txt_Estado.Clear();
            txt_CP.Clear();
            txt_Telefono.Clear();
            txt_Email.Clear();
            txt_NombreContacto.Clear();
            txt_Saldo.Clear();
            txt_LimiteCredito.Clear();
            txt_Diascredito.Clear();
            Direccion_Imagen = "";
            groupBoxdatos.Visible = true;
            //RELLENO POR DEFECTO
            txt_Saldo.Text = "0.00";
            eliminarToolStripMenuItem.Enabled = false;
            modificarToolStripMenuItem.Enabled = false;
            groupBoxdatos.Visible = true;
            errorProvider1.Clear();
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
            try
            {
                //Quito el panel de busqueda
                groupBoxfoto.Controls.Remove(pic_ImagenContacto);
            }
            catch (Exception)
            {
                //En caso de que no existe todavia picturebox
                //omite la instrucción de quitar dicho control
            }

        }
        //-------------------------------------------------------------
        //----------------CONFIGURACION DE CONTROLES-------------------
        //-------------------------------------------------------------
        //Creando controles
        DataGridView data_resultado;
        TextBox txt_Busqueda;
        PictureBox pic_Lupa;
        Button bttn_Busqueda;
        Panel panel_Busqueda;
        Label lbl_Etiqueta;
        //Creando Columnas del DATAGRID
        DataGridViewTextBoxColumn RFC;
        DataGridViewTextBoxColumn Nombre_Contacto;
        DataGridViewTextBoxColumn Apellido_M;
        DataGridViewTextBoxColumn Apellido_P;
        DataGridViewTextBoxColumn Nombre;
        DataGridViewImageColumn Foto;
        DataGridViewTextBoxColumn Id;
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //INICIALIZANDO CONTROLES
            panel_Busqueda = new System.Windows.Forms.Panel();
            txt_Busqueda = new System.Windows.Forms.TextBox();
            data_resultado = new System.Windows.Forms.DataGridView();
            pic_Lupa = new System.Windows.Forms.PictureBox();
            bttn_Busqueda = new System.Windows.Forms.Button();
            lbl_Etiqueta = new System.Windows.Forms.Label();
            //groupBoxfoto.SuspendLayout();
            //INICIALIZANDO COLUMNAS
            RFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombre_Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Apellido_M = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Apellido_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Foto = new System.Windows.Forms.DataGridViewImageColumn();
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
            Foto,
            Nombre,
            Apellido_P,
            Apellido_M,
            Nombre_Contacto,
            RFC});
            data_resultado.Location = new System.Drawing.Point(21, 136);
            data_resultado.Name = "data_resultado";
            data_resultado.RowHeadersWidth = 25;
            data_resultado.RowTemplate.Height = 50;
            data_resultado.Size = new System.Drawing.Size(526, 339);
            data_resultado.TabIndex = 2;
            data_resultado.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(data_resultado_MouseDoubleClick);
            // 
            // RFC
            // 
            RFC.HeaderText = "RFC";
            RFC.Name = "RFC";
            // 
            // Nombre_Contacto
            // 
            Nombre_Contacto.HeaderText = "Nombre_Contacto";
            Nombre_Contacto.Name = "Nombre_Contacto";
            // 
            // Apellido_M
            // 
            Apellido_M.HeaderText = "Apellido_M";
            Apellido_M.Name = "Apellido_M";
            // 
            // Apellido_P
            // 
            Apellido_P.HeaderText = "Apellido_P";
            Apellido_P.Name = "Apellido_P";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Foto
            // 
            Foto.HeaderText = "Foto";
            Foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            Foto.Name = "Foto";
            Foto.Visible = false;
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
            lbl_Etiqueta.Text = "Escriba el nombre, uno de los apellidos, nombre de contacto ó RFC del proveedor" +
                "a buscar";
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
            panel_Busqueda.Location = new System.Drawing.Point(12, 88);
            panel_Busqueda.Name = "panel_Busqueda";
            panel_Busqueda.Size = new System.Drawing.Size(568, 496);
            panel_Busqueda.TabIndex = 35;
            panel_Busqueda.Visible = false;
            //CARACTERISTICA DE AUTOCOMPLETADO EN TXT_BUSQUEDA
            txt_Busqueda.AutoCompleteCustomSource = Autocomplete();
            txt_Busqueda.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_Busqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Controls.Add(panel_Busqueda);
            groupBoxdatos.Visible = false;
            panel_Busqueda.Visible = true;
            panel_Busqueda.Enabled = true;
        }
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool i = Verificar_CamposVacios();
            if (i == true)
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
                    OleDbCommand comando = new OleDbCommand("SP_Proveedor_Cambios", con, tran);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@Id_Proveedor", Idp);
                    comando.Parameters.AddWithValue("@RFC", txt_RFC.Text);
                    comando.Parameters.AddWithValue("@Razon_Social", txt_RazonSocial.Text);
                    comando.Parameters.AddWithValue("@Nombre", txt_Nombre.Text);
                    comando.Parameters.AddWithValue("@Apellido_P", txt_ApellidoP.Text);
                    comando.Parameters.AddWithValue("@Apellido_M", txt_ApellidoM.Text);
                    comando.Parameters.AddWithValue("@Direccion", txt_Direccion.Text);
                    comando.Parameters.AddWithValue("@Ciudad", txt_Ciudad.Text);
                    comando.Parameters.AddWithValue("@Estado", txt_Estado.Text);
                    comando.Parameters.AddWithValue("@CP", txt_CP.Text);
                    comando.Parameters.AddWithValue("@Telefono", txt_Telefono.Text);
                    comando.Parameters.AddWithValue("@Correo", txt_Email.Text);
                    comando.Parameters.AddWithValue("@Nombre_Contacto", txt_NombreContacto.Text);
                    comando.Parameters.AddWithValue("@Saldo", Convert.ToDecimal(txt_Saldo.Text));
                    comando.Parameters.AddWithValue("@Limite_Credito", Convert.ToDecimal(txt_LimiteCredito.Text));
                    comando.Parameters.AddWithValue("@Dias_Credito", txt_Diascredito.Text);
                    comando.Parameters.AddWithValue("@Foto", Direccion_Imagen);
                    comando.ExecuteNonQuery();
                    tran.Commit();
                    con.Close();
                    MessageBox.Show("Datos Modificados con éxito", "Solicitud procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error inesperado", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool i = Verificar_CamposVacios();
            if (i == true)
                MessageBox.Show("Inserta todos los datos marcados", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                OleDbConnection conexion = null;
                OleDbTransaction transaccion = null;
                try
                {
                    if (Direccion_Imagen == "")//LO UTILIZO EN CASO DE NO ESPECIFICAR UNA IMAGEN COMO FOTO AGREGUE UNA POR DEFECTO
                    {
                        Direccion_Imagen = @"C:\Shajobe\Imagenes\Proveedores.PNG";
                    }
                    conexion = new OleDbConnection(ObtenerString());
                    conexion.Open();
                    transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                    OleDbCommand comando = new OleDbCommand("SP_Proveedor_Alta", conexion, transaccion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@RFC", txt_RFC.Text);
                    comando.Parameters.AddWithValue("@Razon_Social", txt_RazonSocial.Text);
                    comando.Parameters.AddWithValue("@Nombre", txt_Nombre.Text);
                    comando.Parameters.AddWithValue("@Apellido_P", txt_ApellidoP.Text);
                    comando.Parameters.AddWithValue("@Apellido_M", txt_ApellidoM.Text);
                    comando.Parameters.AddWithValue("@Direccion", txt_Direccion.Text);
                    comando.Parameters.AddWithValue("@Ciudad", txt_Ciudad.Text);
                    comando.Parameters.AddWithValue("@Estado", txt_Estado.Text);
                    comando.Parameters.AddWithValue("@CP", txt_CP.Text);
                    comando.Parameters.AddWithValue("@Telefono", txt_Telefono.Text);
                    comando.Parameters.AddWithValue("@Correo", txt_Email.Text);
                    comando.Parameters.AddWithValue("@Nombre_Contacto", txt_NombreContacto.Text);
                    comando.Parameters.AddWithValue("@Saldo", Convert.ToDecimal(txt_Saldo.Text));
                    comando.Parameters.AddWithValue("@Limite_Credito", Convert.ToDecimal(txt_LimiteCredito.Text));
                    comando.Parameters.AddWithValue("@Dias_Credito", txt_Diascredito.Text);
                    comando.Parameters.AddWithValue("@Foto", Direccion_Imagen);
                    comando.ExecuteNonQuery();
                    transaccion.Commit();
                    conexion.Close();
                    MessageBox.Show("Datos guardados con éxito", "Solicitud procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error inesperado", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection conexion = null;
            OleDbTransaction transaccion = null;
            try
            {
                conexion = new OleDbConnection(ObtenerString());
                conexion.Open();
                transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                OleDbCommand comando = new OleDbCommand("SP_Proveedor_Bajas", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Id_Proveedor", Idp);
                comando.ExecuteNonQuery();
                transaccion.Commit();
                conexion.Close();
                MessageBox.Show("Datos Modificados con éxito", "Solicitud procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error inesperado", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        //-------------------------------------------------------------
        //------------------Busqueda del sistema-----------------------
        //-------------------------------------------------------------
        public void BusquedaDatos(int Idp)
        {
            pic_ImagenContacto = new PictureBox();
            pic_ImagenContacto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pic_ImagenContacto.ErrorImage = global::Sistema_Shajobe.Properties.Resources.Proveedores;
            pic_ImagenContacto.Location = new System.Drawing.Point(6, 19);
            pic_ImagenContacto.Name = "pic_ImagenContacto";
            pic_ImagenContacto.Size = new System.Drawing.Size(225, 183);
            pic_ImagenContacto.TabIndex = 32;
            pic_ImagenContacto.TabStop = false;
            groupBoxfoto.Controls.Add(pic_ImagenContacto);

            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "Select Id_Proveedor,Numero_Proveedor,RFC,Razon_Social,Nombre,Apellido_P,Apellido_M,Direccion,Ciudad,Estado,CP,Telefono,Correo,Nombre_Contacto,Saldo,Limite_Credito,Dias_Credito, Foto from Tb_Proveedor where Id_Proveedor='" + Idp + "'";
            coman.CommandType = CommandType.Text;
            con.Open();
            data_resultado.Rows.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                txt_RFC.Text = dr.GetString(dr.GetOrdinal("RFC"));
                txt_RazonSocial.Text = dr.GetString(dr.GetOrdinal("Razon_Social"));
                txt_Nombre.Text = dr.GetString(dr.GetOrdinal("Nombre"));
                txt_ApellidoP.Text = dr.GetString(dr.GetOrdinal("Apellido_P"));
                txt_ApellidoM.Text = dr.GetString(dr.GetOrdinal("Apellido_M"));
                txt_Direccion.Text = dr.GetString(dr.GetOrdinal("Direccion"));
                txt_Ciudad.Text = dr.GetString(dr.GetOrdinal("Ciudad"));
                txt_Estado.Text = dr.GetString(dr.GetOrdinal("Estado"));
                txt_CP.Text = dr.GetString(dr.GetOrdinal("CP"));
                txt_Telefono.Text = dr.GetString(dr.GetOrdinal("Telefono"));
                txt_Email.Text = dr.GetString(dr.GetOrdinal("Correo"));
                txt_NombreContacto.Text = dr.GetString(dr.GetOrdinal("Nombre_Contacto"));
                txt_Saldo.Text = dr.GetDecimal(dr.GetOrdinal("Saldo")).ToString("N");
                txt_LimiteCredito.Text = dr.GetDecimal(dr.GetOrdinal("Limite_Credito")).ToString("N");
                txt_Diascredito.Text = (dr.GetInt32(dr.GetOrdinal("Dias_Credito"))).ToString();
                pic_ImagenContacto.BackgroundImage = Image.FromFile(dr.GetString(dr.GetOrdinal("Foto")));
                Direccion_Imagen = dr.GetString(dr.GetOrdinal("Foto"));
                eliminarToolStripMenuItem.Enabled = true;
                modificarToolStripMenuItem.Enabled = true;
            }
            con.Close();
        }
        private void Busqueda()
        {
            if (txt_Busqueda.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_Busqueda, "No puedes dejar el campo vacio");
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
                Foto.Dispose();
                coman.CommandText = "Select Id_Proveedor,Foto,Nombre,Apellido_P,Apellido_M,Nombre_Contacto,RFC from Tb_Proveedor where (Nombre='" + busqueda.ToUpper() + "'OR Apellido_P='" + busqueda.ToUpper() + "'OR Apellido_M='" + busqueda.ToUpper() + "'OR Nombre_Contacto='" + busqueda.ToUpper() + "'OR RFC='" + busqueda.ToUpper() + "') AND Activo='S'";
                coman.CommandType = CommandType.Text;
                con.Open();
                data_resultado.Rows.Clear();
                dr = coman.ExecuteReader();
                while (dr.Read())
                {
                    int Renglon = data_resultado.Rows.Add();
                    Idp = dr.GetInt32(dr.GetOrdinal("Id_Proveedor"));
                    data_resultado.Rows[Renglon].Cells["Id"].Value = dr.GetInt32(dr.GetOrdinal("Id_Proveedor"));
                    Foto.Image = Image.FromFile(dr.GetString(dr.GetOrdinal("Foto")));
                    data_resultado.Rows[Renglon].Cells["Nombre"].Value = dr.GetString(dr.GetOrdinal("Nombre"));
                    data_resultado.Rows[Renglon].Cells["Apellido_P"].Value = dr.GetString(dr.GetOrdinal("Apellido_P"));
                    data_resultado.Rows[Renglon].Cells["Apellido_M"].Value = dr.GetString(dr.GetOrdinal("Apellido_M"));
                    data_resultado.Rows[Renglon].Cells["Nombre_Contacto"].Value = dr.GetString(dr.GetOrdinal("Nombre_Contacto"));
                    data_resultado.Rows[Renglon].Cells["RFC"].Value = dr.GetString(dr.GetOrdinal("RFC"));
                }
                con.Close();
            }
        }
        OpenFileDialog BuscarImagen;
        PictureBox pic_ImagenContacto;
        private void btn_BuscarI_Click(object sender, EventArgs e)
        {
            BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Archivos de imagen (*.png, *.jpg)|*.png;*.jpg";
            //Aquí incluiremos los filtros que queramos.
            BuscarImagen.FileName = "";
            BuscarImagen.Title = "Buscar Imagen ó Foto";
            BuscarImagen.InitialDirectory = @"C:\Shajobe\Imagenes";
            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //Quito el panel de busqueda
                    groupBoxfoto.Controls.Remove(pic_ImagenContacto);
                }
                catch (Exception)
                {
                    //En caso de que no existe todavia picturebox
                    //omite la instrucción de quitar dicho control
                }

                pic_ImagenContacto = new PictureBox();
                pic_ImagenContacto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                pic_ImagenContacto.ErrorImage = global::Sistema_Shajobe.Properties.Resources.Clientes;
                pic_ImagenContacto.Location = new System.Drawing.Point(6, 19);
                pic_ImagenContacto.Name = "pic_ImagenContacto";
                pic_ImagenContacto.Size = new System.Drawing.Size(225, 183);
                pic_ImagenContacto.TabIndex = 32;
                pic_ImagenContacto.TabStop = false;
                groupBoxfoto.Controls.Add(pic_ImagenContacto);

                Direccion_Imagen = BuscarImagen.FileName;
                pic_ImagenContacto.ImageLocation = Direccion_Imagen;
                pic_ImagenContacto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void bttn_Busqueda_Click(object sender, EventArgs e)
        {
            Busqueda();
        }
        //-------------------------------------------------------------
        //------Obtiene la cadena de conexion desde la app Config------
        //-------------------------------------------------------------
        public static string ObtenerString()
        {
            return Settings.Default.SHAJOBEConnectionString;
        }
        //-------------------------------------------------------------
        //-------------------Validacion de campos----------------------
        //-------------------------------------------------------------
        private bool Verificar_CamposVacios()
        {
            //Se introduce los textbox en un arreglo con el fin de identificar espacios vacios
            Campos[0] = txt_RFC;
            Campos[1] = txt_RazonSocial;
            Campos[2] = txt_Nombre;
            Campos[3] = txt_ApellidoP;
            Campos[4] = txt_ApellidoM;
            Campos[5] = txt_Direccion;
            Campos[6] = txt_Ciudad;
            Campos[7] = txt_Estado;
            Campos[8] = txt_CP;
            Campos[9] = txt_LimiteCredito;
            Campos[10] = txt_Diascredito;
            //Reinicio el error provider para volver a reemarcar
            errorProvider1.Clear();
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
                    errorProvider1.SetError(txt_RFC, "No puedes dejar el campo vacio");
                    break;
                case 1:
                    errorProvider1.SetError(txt_RazonSocial, "No puedes dejar el campo vacio");
                    break;
                case 2:
                    errorProvider1.SetError(txt_Nombre, "No puedes dejar el campo vacio");
                    break;
                case 3:
                    errorProvider1.SetError(txt_ApellidoP, "No puedes dejar el campo vacio");
                    break;
                case 4:
                    errorProvider1.SetError(txt_ApellidoM, "No puedes dejar el campo vacio");
                    break;
                case 5:
                    errorProvider1.SetError(txt_Direccion, "No puedes dejar el campo vacio");
                    break;
                case 6:
                    errorProvider1.SetError(txt_Ciudad, "No puedes dejar el campo vacio");
                    break;
                case 7:
                    errorProvider1.SetError(txt_Estado, "No puedes dejar el campo vacio");
                    break;
                case 8:
                    errorProvider1.SetError(txt_CP, "No puedes dejar el campo vacio");
                    break;
                case 9:
                    errorProvider1.SetError(txt_LimiteCredito, "No puedes dejar el campo vacio");
                    break;
                case 10:
                    errorProvider1.SetError(txt_Diascredito, "No puedes dejar el campo vacio");
                    break;
                default:
                    break;
            }
        }
        //-------------------------------------------------------------
        //----------------------AUTO COMPLETAR-------------------------
        //-------------------------------------------------------------
        //metodo para cargar la coleccion de datos para el autocomplete
        public static DataTable Datos()
        {
            DataTable dt = new DataTable();

            OleDbConnection conexion = new OleDbConnection(ObtenerString());//cadena conexion
            string consulta = "SELECT * FROM Tb_Proveedor where Activo='S'"; //consulta a la tabla paises
            OleDbCommand comando = new OleDbCommand(consulta, conexion);
            OleDbDataAdapter adap = new OleDbDataAdapter(comando);
            adap.Fill(dt);
            return dt;
        }
        //metodo para cargar la coleccion de datos para el autocomplete
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
                coleccion.Add(Convert.ToString(row["Nombre_Contacto"]));
                coleccion.Add(Convert.ToString(row["RFC"]));
            }

            return coleccion;
        }
        //-------------------------------------------------------------
        //-------------------Validacion de campos----------------------
        //-------------------------------------------------------------
        private void txt_CP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de numeros------------Apartado de teclas especiales Retroceso y suprimir
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128))
            {
                MessageBox.Show("Solo se aceptan numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de numeros------------Apartado de teclas especiales Retroceso y suprimir
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128))
            {
                MessageBox.Show("Solo se aceptan numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void txt_Diascredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de numeros------------Apartado de teclas especiales Retroceso y suprimir
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128))
            {
                MessageBox.Show("Solo se aceptan numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void txt_LimiteCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de numeros-------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47))
            {
                MessageBox.Show("Solo se aceptan numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void txt_Saldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de numeros-------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47))
            {
                MessageBox.Show("Solo se aceptan numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void txt_RazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de letras-----------------------------------------------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto---------------------------uso del espacio
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
        private void txt_ApellidoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de letras-----------------------------------------------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto
            if ((e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47))
            {
                MessageBox.Show("Solo se aceptan letras", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void txt_ApellidoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de letras-----------------------------------------------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto
            if ((e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47))
            {
                MessageBox.Show("Solo se aceptan letras", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void txt_Ciudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de letras-----------------------------------------------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto---------------------------uso del espacio
            if ((e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47) && (e.KeyChar < 31 || e.KeyChar > 33))
            {
                MessageBox.Show("Solo se aceptan letras", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void txt_Estado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de letras-----------------------------------------------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto
            if ((e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47))
            {
                MessageBox.Show("Solo se aceptan letras", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void txt_NombreContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de letras-----------------------------------------------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto---------------------------Uso del espacio
            if ((e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47) && (e.KeyChar < 31 || e.KeyChar > 33))
            {
                MessageBox.Show("Solo se aceptan letras", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void txt_RFC_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---Apartado de numeros-------------------Apartado de letras------------------------------------------------------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47))
            {
                MessageBox.Show("Solo se aceptan letras y numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void txt_Busqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47) && (e.KeyChar < 31 || e.KeyChar > 33))
            {
                MessageBox.Show("Solo se aceptan letras y numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        //-------------------------------------------------------------
        //------------------DATAGRIDVIEW BUSQUEDA----------------------
        //-------------------------------------------------------------
        //ACCION QUE REALIZA CUANDO SE DA DOBLE CLIC SOBRE EL DATAGRIDVIEW DE BUSQUEDA
        private void data_resultado_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Idp = Convert.ToInt32(data_resultado.CurrentRow.Cells["Id"].Value);
            Limpiar();
            BusquedaDatos(Idp);
            //Quito el panel de busqueda
            Controls.Remove(panel_Busqueda);
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
