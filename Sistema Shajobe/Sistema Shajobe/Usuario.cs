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
    public partial class Usuario : Form
    {
        public Usuario()
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
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercadeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pic_Usuario;
        private System.Windows.Forms.GroupBox groupBoxdatos;
        private System.Windows.Forms.GroupBox groupBoxfoto;
        private System.Windows.Forms.Button btn_BuscarI;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.TextBox txt_CP;
        private System.Windows.Forms.TextBox txt_Estado;
        private System.Windows.Forms.TextBox txt_Ciudad;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.TextBox txt_ApellidoM;
        private System.Windows.Forms.TextBox txt_ApellidoP;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.TextBox txt_Nom_User;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Label lbl_CP;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.Label lbl_Ciudad;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.Label lbl_ApellidoM;
        private System.Windows.Forms.Label lbl_ApellidoP;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Contraseña;
        private System.Windows.Forms.Label lbl_Nom_User;
        private System.Windows.Forms.ErrorProvider errorProvider_Textbox;
        private System.Windows.Forms.ErrorProvider errorProvider_Combobox;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ComboBox Combobox_TipoUsuario;
        private System.Windows.Forms.Label lbl_TipoUsuario;
        private PictureBox pic_Logo;
        #endregion
        private void Diseño_Forma()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            acercadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            Combobox_TipoUsuario = new System.Windows.Forms.ComboBox();
            lbl_TipoUsuario = new System.Windows.Forms.Label();
            pic_Usuario = new System.Windows.Forms.PictureBox();
            groupBoxdatos = new System.Windows.Forms.GroupBox();
            groupBoxfoto = new System.Windows.Forms.GroupBox();
            btn_BuscarI = new System.Windows.Forms.Button();
            txt_Email = new System.Windows.Forms.TextBox();
            txt_Telefono = new System.Windows.Forms.TextBox();
            txt_CP = new System.Windows.Forms.TextBox();
            txt_Estado = new System.Windows.Forms.TextBox();
            txt_Ciudad = new System.Windows.Forms.TextBox();
            txt_Direccion = new System.Windows.Forms.TextBox();
            txt_ApellidoM = new System.Windows.Forms.TextBox();
            txt_ApellidoP = new System.Windows.Forms.TextBox();
            txt_Nombre = new System.Windows.Forms.TextBox();
            txt_Contraseña = new System.Windows.Forms.TextBox();
            txt_Nom_User = new System.Windows.Forms.TextBox();
            lbl_Email = new System.Windows.Forms.Label();
            lbl_Telefono = new System.Windows.Forms.Label();
            lbl_CP = new System.Windows.Forms.Label();
            lbl_Estado = new System.Windows.Forms.Label();
            lbl_Ciudad = new System.Windows.Forms.Label();
            lbl_Direccion = new System.Windows.Forms.Label();
            lbl_ApellidoM = new System.Windows.Forms.Label();
            lbl_ApellidoP = new System.Windows.Forms.Label();
            lbl_Nombre = new System.Windows.Forms.Label();
            lbl_Contraseña = new System.Windows.Forms.Label();
            lbl_Nom_User = new System.Windows.Forms.Label();
            pic_Logo = new System.Windows.Forms.PictureBox();
            errorProvider_Textbox = new System.Windows.Forms.ErrorProvider(components);
            errorProvider_Combobox = new System.Windows.Forms.ErrorProvider(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pic_Usuario)).BeginInit();
            groupBoxdatos.SuspendLayout();
            groupBoxfoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(errorProvider_Textbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(errorProvider_Combobox)).BeginInit();
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
            modificarToolStripMenuItem,
            eliminarToolStripMenuItem});
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            editarToolStripMenuItem.Text = "&Editar";
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
            pic_Logo.Location = new System.Drawing.Point(380, 310);
            pic_Logo.Name = "pic_Logo";
            pic_Logo.Size = new System.Drawing.Size(166, 84);
            pic_Logo.TabIndex = 13;
            pic_Logo.TabStop = false;
            // 
            // pic_Usuario
            // 
            pic_Usuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Usuario.BackgroundImage")));
            pic_Usuario.BackgroundImage = global::Sistema_Shajobe.Properties.Resources.Usuario;
            pic_Usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pic_Usuario.Location = new System.Drawing.Point(493, 25);
            pic_Usuario.Name = "pic_Usuario";
            pic_Usuario.Size = new System.Drawing.Size(85, 67);
            pic_Usuario.TabIndex = 7;
            pic_Usuario.TabStop = false;
            // 
            // groupBoxdatos
            // 
            groupBoxdatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            groupBoxdatos.Controls.Add(groupBoxfoto);
            groupBoxdatos.Controls.Add(pic_Logo);
            groupBoxdatos.Controls.Add(txt_Email);
            groupBoxdatos.Controls.Add(txt_Telefono);
            groupBoxdatos.Controls.Add(txt_CP);
            groupBoxdatos.Controls.Add(txt_Estado);
            groupBoxdatos.Controls.Add(txt_Ciudad);
            groupBoxdatos.Controls.Add(txt_Direccion);
            groupBoxdatos.Controls.Add(txt_ApellidoM);
            groupBoxdatos.Controls.Add(txt_ApellidoP);
            groupBoxdatos.Controls.Add(txt_Nombre);
            groupBoxdatos.Controls.Add(txt_Contraseña);
            groupBoxdatos.Controls.Add(txt_Nom_User);
            groupBoxdatos.Controls.Add(lbl_Email);
            groupBoxdatos.Controls.Add(lbl_Telefono);
            groupBoxdatos.Controls.Add(lbl_CP);
            groupBoxdatos.Controls.Add(lbl_Estado);
            groupBoxdatos.Controls.Add(lbl_Ciudad);
            groupBoxdatos.Controls.Add(lbl_Direccion);
            groupBoxdatos.Controls.Add(lbl_ApellidoM);
            groupBoxdatos.Controls.Add(lbl_ApellidoP);
            groupBoxdatos.Controls.Add(lbl_Nombre);
            groupBoxdatos.Controls.Add(lbl_Contraseña);
            groupBoxdatos.Controls.Add(lbl_Nom_User);
            groupBoxdatos.Controls.Add(lbl_TipoUsuario);
            groupBoxdatos.Controls.Add(Combobox_TipoUsuario);
            groupBoxdatos.Location = new System.Drawing.Point(8, 52);
            groupBoxdatos.Name = "groupBoxdatos";
            groupBoxdatos.Size = new System.Drawing.Size(568, 450);
            groupBoxdatos.TabIndex = 6;
            groupBoxdatos.TabStop = false;
            groupBoxdatos.Text = "Datos del usuario";
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
            // txt_Email
            // 
            txt_Email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            txt_Email.Location = new System.Drawing.Point(127, 397);
            txt_Email.MaxLength = 30;
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new System.Drawing.Size(127, 20);
            txt_Email.TabIndex = 26;
            // 
            // txt_Telefono
            // 
            txt_Telefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            txt_Telefono.Location = new System.Drawing.Point(127, 372);
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
            txt_CP.Location = new System.Drawing.Point(127, 347);
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
            txt_Estado.Location = new System.Drawing.Point(127, 322);
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
            txt_Ciudad.Location = new System.Drawing.Point(127, 297);
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
            txt_Direccion.Location = new System.Drawing.Point(127, 188);
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
            txt_ApellidoM.Location = new System.Drawing.Point(127, 163);
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
            txt_ApellidoP.Location = new System.Drawing.Point(127, 138);
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
            txt_Nombre.Location = new System.Drawing.Point(127, 113);
            txt_Nombre.MaxLength = 25;
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new System.Drawing.Size(127, 20);
            txt_Nombre.TabIndex = 18;
            txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_Nombre_KeyPress);
            // 
            // txt_Contraseña
            // 
            txt_Contraseña.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            txt_Contraseña.Location = new System.Drawing.Point(127, 88);
            txt_Contraseña.MaxLength = 13;
            txt_Contraseña.Name = "txt_Contraseña";
            txt_Contraseña.Size = new System.Drawing.Size(127, 20);
            txt_Contraseña.TabIndex = 17;
            txt_Contraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_Contraseña_KeyPress);
            // 
            // txt_Nom_User
            // 
            txt_Nom_User.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            txt_Nom_User.Location = new System.Drawing.Point(127, 63);
            txt_Nom_User.MaxLength = 13;
            txt_Nom_User.Name = "txt_Nom_User";
            txt_Nom_User.Size = new System.Drawing.Size(127, 20);
            txt_Nom_User.TabIndex = 16;
            txt_Nom_User.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_Nom_User_KeyPress);
            //
            // Combobox_TipoUsuario
            //
            Combobox_TipoUsuario.Location = new System.Drawing.Point(127,38);
            Combobox_TipoUsuario.Name = "Combobox_TipoUsuario";
            Combobox_TipoUsuario.KeyPress += new KeyPressEventHandler(NoescrituracomboBox_KeyPress);
            //
            //  lbl_TipoUsuario
            //
            lbl_TipoUsuario.Name = "lbl_TipoUsuario";
            lbl_TipoUsuario.Location = new System.Drawing.Point(28, 38);
            lbl_TipoUsuario.Text = "Tipo de usuario";
            // 
            // lbl_Email
            // 
            lbl_Email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            lbl_Email.AutoSize = true;
            lbl_Email.Location = new System.Drawing.Point(28, 401);
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
            lbl_Telefono.Location = new System.Drawing.Point(28, 376);
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
            lbl_CP.Location = new System.Drawing.Point(28, 351);
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
            lbl_Estado.Location = new System.Drawing.Point(28, 326);
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
            lbl_Ciudad.Location = new System.Drawing.Point(28, 301);
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
            lbl_Direccion.Location = new System.Drawing.Point(28, 192);
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
            lbl_ApellidoM.Location = new System.Drawing.Point(28, 167);
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
            lbl_ApellidoP.Location = new System.Drawing.Point(28, 142);
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
            lbl_Nombre.Location = new System.Drawing.Point(28, 117);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new System.Drawing.Size(47, 13);
            lbl_Nombre.TabIndex = 3;
            lbl_Nombre.Text = "Nombre ";
            // 
            // lbl_Contraseña
            // 
            lbl_Contraseña.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            lbl_Contraseña.AutoSize = true;
            lbl_Contraseña.Location = new System.Drawing.Point(28, 92);
            lbl_Contraseña.Name = "lbl_Contraseña";
            lbl_Contraseña.Size = new System.Drawing.Size(68, 13);
            lbl_Contraseña.TabIndex = 2;
            lbl_Contraseña.Text = "Contraseña";
            // 
            // lbl_Nom_User
            // 
            lbl_Nom_User.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            lbl_Nom_User.AutoSize = true;
            lbl_Nom_User.Location = new System.Drawing.Point(28, 67);
            lbl_Nom_User.Name = "lbl_Nom_User";
            lbl_Nom_User.Size = new System.Drawing.Size(31, 13);
            lbl_Nom_User.TabIndex = 1;
            lbl_Nom_User.Text = "Nombre de usuario";
            // 
            // errorProvider_Textbox
            // 
            errorProvider_Textbox.ContainerControl = this;
            // 
            // Cliente
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(604, 560);
            Controls.Add(pic_Usuario);
            Controls.Add(groupBoxdatos);
            Controls.Add(menuStrip1);
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(196)))));
            Icon = global::Sistema_Shajobe.Properties.Resources.Usuario_ICO;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(600, 560);
            MinimumSize = new System.Drawing.Size(600, 560);
            Name = "Usuario";
            Text = "Usuario";
            Load += new System.EventHandler(Usuario_Load);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pic_Usuario)).EndInit();
            groupBoxdatos.ResumeLayout(false);
            groupBoxdatos.PerformLayout();
            groupBoxfoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(errorProvider_Textbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(errorProvider_Combobox)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private void Usuario_Load(object sender, EventArgs e)
        {
            #region Animacion
            AnimateWindow(Handle, 350, AnimateWindowFlags.AW_CENTER);
            AnimateWindow(Handle, 450, AnimateWindowFlags.AW_CENTER | AnimateWindowFlags.AW_SLIDE);
            ResumeLayout(false);
            PerformLayout();
            #endregion
            Diseño_Forma();
            Llenando_ComboboxTipoUsuario();
        }
        #region Eventos
        //-------------------------------------------------------------
        //------------------Variables y Arreglos-----------------------
        //-------------------------------------------------------------
        private String Direccion_Imagen = "";
        private TextBox[] Campos = new TextBox[9];
        private ComboBox[] CamposC = new ComboBox[1];
        private int Idp;//LO USO PARA OBTENER EL ID COMO RESULTADO DE LA BUSQUEDA
        private bool Espacios_Vacios = false, Espacios_NoSeleccionados = false;
        //-------------------------------------------------------------
        //------------------Busqueda del sistema-----------------------
        //-------------------------------------------------------------
        #region Busquedas del sistema
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
        public void BusquedaDatos(int Idp)
        {
            pic_ImagenContacto = new PictureBox();
            pic_ImagenContacto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pic_ImagenContacto.ErrorImage = global::Sistema_Shajobe.Properties.Resources.Clientes;
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
            coman.CommandText = "SELECT Id_Usuario, Nom_User,Foto, Correo, Telefono, CP, Estado, Ciudad, Direccion, Apellido_M, Apellido_P, Nombre, Id_Tipo_Usuario, Contraseña FROM Tb_Usuario WHERE (Id_Usuario = '" + Idp + "')";
            coman.CommandType = CommandType.Text;
            con.Open();
            data_resultado.Rows.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                txt_Nom_User.Text = dr.GetString(dr.GetOrdinal("Nom_User"));
                txt_Contraseña.Text = dr.GetString(dr.GetOrdinal("Contraseña"));
                txt_Nombre.Text = dr.GetString(dr.GetOrdinal("Nombre"));
                txt_ApellidoP.Text = dr.GetString(dr.GetOrdinal("Apellido_P"));
                txt_ApellidoM.Text = dr.GetString(dr.GetOrdinal("Apellido_M"));
                txt_Direccion.Text = dr.GetString(dr.GetOrdinal("Direccion"));
                txt_Ciudad.Text = dr.GetString(dr.GetOrdinal("Ciudad"));
                txt_Estado.Text = dr.GetString(dr.GetOrdinal("Estado"));
                txt_CP.Text = dr.GetString(dr.GetOrdinal("CP"));
                txt_Telefono.Text = dr.GetString(dr.GetOrdinal("Telefono"));
                txt_Email.Text = dr.GetString(dr.GetOrdinal("Correo"));
                pic_ImagenContacto.BackgroundImage = Image.FromFile(dr.GetString(dr.GetOrdinal("Foto")));
                Direccion_Imagen = dr.GetString(dr.GetOrdinal("Foto"));
                int seleccion = dr.GetInt32(dr.GetOrdinal("Id_Tipo_Usuario"));
                seleccion = seleccion - 1;
                Combobox_TipoUsuario.SelectedIndex = seleccion;
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
                coman.CommandText = "Select Id_Usuario,Nombre,Apellido_P,Apellido_M from Tb_Usuario where (Nombre='" + busqueda.ToUpper() + "'OR Apellido_P='" + busqueda.ToUpper() + "'OR Apellido_M='" + busqueda.ToUpper() + "') AND Activo='S'";
                coman.CommandType = CommandType.Text;
                con.Open();
                data_resultado.Rows.Clear();
                dr = coman.ExecuteReader();
                while (dr.Read())
                {
                    int Renglon = data_resultado.Rows.Add();
                    Idp = dr.GetInt32(dr.GetOrdinal("Id_Usuario"));
                    data_resultado.Rows[Renglon].Cells["Id"].Value = dr.GetInt32(dr.GetOrdinal("Id_Usuario"));
                    data_resultado.Rows[Renglon].Cells["Nombre"].Value = dr.GetString(dr.GetOrdinal("Nombre"));
                    data_resultado.Rows[Renglon].Cells["Apellido_P"].Value = dr.GetString(dr.GetOrdinal("Apellido_P"));
                    data_resultado.Rows[Renglon].Cells["Apellido_M"].Value = dr.GetString(dr.GetOrdinal("Apellido_M"));
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
        #endregion
        //-------------------------------------------------------------
        //-------------------LLENANDO CONTROLES------------------------
        //-------------------------------------------------------------
        private void Llenando_ComboboxTipoUsuario()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "SELECT Nombre FROM Tb_TipoUsuario where Activo='S'";
            coman.CommandType = CommandType.Text;
            con.Open();
            Combobox_TipoUsuario.Items.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Declarando Variables y obteniendo los valores correspondiente
                string Tipo = dr.GetString(dr.GetOrdinal("Nombre"));
                Combobox_TipoUsuario.Items.Add(Tipo);
            }
            con.Close();
        }
        //-------------------------------------------------------------
        //----------------CONFIGURACION DE CONTROLES-------------------
        //-------------------------------------------------------------
        #region Funciones A, B y C
        #region Guardar
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
                        Direccion_Imagen = @"C:\Shajobe\Imagenes\Usuario.PNG";
                    }
                    conexion = new OleDbConnection(ObtenerString());
                    conexion.Open();
                    transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                    OleDbCommand comando = new OleDbCommand("SP_Usuario_Alta", conexion, transaccion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@Id_Tipo_Usuario", Combobox_TipoUsuario.SelectedIndex+1);
                    comando.Parameters.AddWithValue("@Nom_User", txt_Nom_User.Text);
                    comando.Parameters.AddWithValue("@Contraseña", txt_Contraseña.Text);
                    comando.Parameters.AddWithValue("@Nombre", txt_Nombre.Text);
                    comando.Parameters.AddWithValue("@Apellido_P", txt_ApellidoP.Text);
                    comando.Parameters.AddWithValue("@Apellido_M", txt_ApellidoM.Text);
                    comando.Parameters.AddWithValue("@Direccion", txt_Direccion.Text);
                    comando.Parameters.AddWithValue("@Ciudad", txt_Ciudad.Text);
                    comando.Parameters.AddWithValue("@Estado", txt_Estado.Text);
                    comando.Parameters.AddWithValue("@CP", txt_CP.Text);
                    comando.Parameters.AddWithValue("@Telefono", txt_Telefono.Text);
                    comando.Parameters.AddWithValue("@Correo", txt_Email.Text);
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
        #endregion
        #region Cambios
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
                    OleDbCommand comando = new OleDbCommand("SP_Usuario_Cambios", con, tran);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@Id_Usuario", Idp);
                    comando.Parameters.AddWithValue("@Id_Tipo_Usuario", Combobox_TipoUsuario.SelectedIndex + 1);
                    comando.Parameters.AddWithValue("@Nom_User", txt_Nom_User.Text);
                    comando.Parameters.AddWithValue("@Contraseña", txt_Contraseña.Text);
                    comando.Parameters.AddWithValue("@Nombre", txt_Nombre.Text);
                    comando.Parameters.AddWithValue("@Apellido_P", txt_ApellidoP.Text);
                    comando.Parameters.AddWithValue("@Apellido_M", txt_ApellidoM.Text);
                    comando.Parameters.AddWithValue("@Direccion", txt_Direccion.Text);
                    comando.Parameters.AddWithValue("@Ciudad", txt_Ciudad.Text);
                    comando.Parameters.AddWithValue("@Estado", txt_Estado.Text);
                    comando.Parameters.AddWithValue("@CP", txt_CP.Text);
                    comando.Parameters.AddWithValue("@Telefono", txt_Telefono.Text);
                    comando.Parameters.AddWithValue("@Correo", txt_Email.Text);
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
                OleDbCommand comando = new OleDbCommand("SP_Usuario_Bajas", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Id_Usuario", Idp);
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
            txt_Nom_User.Clear();
            txt_Contraseña.Clear();
            txt_Nombre.Clear();
            txt_ApellidoP.Clear();
            txt_ApellidoM.Clear();
            txt_Direccion.Clear();
            txt_Ciudad.Clear();
            txt_Estado.Clear();
            txt_CP.Clear();
            txt_Telefono.Clear();
            txt_Email.Clear();
            Direccion_Imagen = "";
            Combobox_TipoUsuario.ResetText();
            groupBoxdatos.Visible = true;
            //RELLENO POR DEFECTO
            eliminarToolStripMenuItem.Enabled = false;
            modificarToolStripMenuItem.Enabled = false;
            groupBoxdatos.Visible = true;
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
        #region Declarando Controles
         //Creando controles
        private DataGridView data_resultado;
        private TextBox txt_Busqueda;
        private PictureBox pic_Lupa;
        private Button bttn_Busqueda;
        private Panel panel_Busqueda;
        private Label lbl_Etiqueta;
        //Creando Columnas del DATAGRID
        private DataGridViewTextBoxColumn Apellido_M;
        private DataGridViewTextBoxColumn Apellido_P;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Id;
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
            //groupBoxfoto.SuspendLayout();
            //INICIALIZANDO COLUMNAS
            Apellido_M = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Apellido_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            Apellido_P,
            Apellido_M});
            data_resultado.Location = new System.Drawing.Point(21, 136);
            data_resultado.Name = "data_resultado";
            data_resultado.RowHeadersWidth = 25;
            data_resultado.RowTemplate.Height = 50;
            data_resultado.Size = new System.Drawing.Size(526, 239);
            data_resultado.TabIndex = 2;
            data_resultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            data_resultado.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(data_resultado_MouseDoubleClick);
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
            lbl_Etiqueta.Text = "Escriba el nombre, uno de los apellidos, del usuario a buscar";
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
            panel_Busqueda.BorderStyle = BorderStyle.FixedSingle;
            panel_Busqueda.Controls.Add(bttn_Busqueda);
            panel_Busqueda.Controls.Add(lbl_Etiqueta);
            panel_Busqueda.Controls.Add(data_resultado);
            panel_Busqueda.Controls.Add(pic_Lupa);
            panel_Busqueda.Controls.Add(txt_Busqueda);
            panel_Busqueda.Enabled = false;
            panel_Busqueda.Location = new System.Drawing.Point(12, 88);
            panel_Busqueda.Name = "panel_Busqueda";
            panel_Busqueda.Size = new System.Drawing.Size(568, 396);
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
            txt_Busqueda.Focus();
        }
        #endregion
        #region Salir
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Menu_principal"].Activate();
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
            Campos[0] = txt_Nom_User;
            Campos[1] = txt_Contraseña;
            Campos[2] = txt_Nombre;
            Campos[3] = txt_ApellidoP;
            Campos[4] = txt_ApellidoM;
            Campos[5] = txt_Direccion;
            Campos[6] = txt_Ciudad;
            Campos[7] = txt_Estado;
            Campos[8] = txt_CP;
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
                    errorProvider_Textbox.SetError(txt_Nom_User, "No puedes dejar el campo vacio");
                    break;
                case 1:
                    errorProvider_Textbox.SetError(txt_Contraseña, "No puedes dejar el campo vacio");
                    break;
                case 2:
                    errorProvider_Textbox.SetError(txt_Nombre, "No puedes dejar el campo vacio");
                    break;
                case 3:
                    errorProvider_Textbox.SetError(txt_ApellidoP, "No puedes dejar el campo vacio");
                    break;
                case 4:
                    errorProvider_Textbox.SetError(txt_ApellidoM, "No puedes dejar el campo vacio");
                    break;
                case 5:
                    errorProvider_Textbox.SetError(txt_Direccion, "No puedes dejar el campo vacio");
                    break;
                case 6:
                    errorProvider_Textbox.SetError(txt_Ciudad, "No puedes dejar el campo vacio");
                    break;
                case 7:
                    errorProvider_Textbox.SetError(txt_Estado, "No puedes dejar el campo vacio");
                    break;
                case 8:
                    errorProvider_Textbox.SetError(txt_CP, "No puedes dejar el campo vacio");
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
            CamposC[0] = Combobox_TipoUsuario;
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
                    errorProvider_Combobox.SetError(Combobox_TipoUsuario, "No puedes dejar el campo vacio");
                    break;
                default:
                    break;
            }
        }
        #endregion
        //-------------------------------------------------------------
        //----------------------AUTO COMPLETAR-------------------------
        //-------------------------------------------------------------
        //metodo para cargar la coleccion de datos para el autocomplete
        public static DataTable Datos()
        {
            DataTable dt = new DataTable();

            OleDbConnection conexion = new OleDbConnection(ObtenerString());//cadena conexion
            string consulta = "SELECT * FROM Tb_Usuario where Activo='S'"; //consulta a la tabla paises
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
            }

            return coleccion;
        }
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
        #region Validacion de campos
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
        private void txt_Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---Apartado de numeros-------------------Apartado de letras------------------------------------------------------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47))
            {
                MessageBox.Show("Solo se aceptan letras y numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
        private void txt_Nom_User_KeyPress(object sender, KeyPressEventArgs e)
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
        #endregion
        //-------------------------------------------------------------
        //-----------------NO ESCRITURA EN LOS COMBOBOX----------------
        //-------------------------------------------------------------
        private void NoescrituracomboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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
