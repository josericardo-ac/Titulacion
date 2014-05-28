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
    public partial class Caja : Form
    {
        public Caja()
        {
            InitializeComponent();
        }
        #region Diseño de la forma
        #region Creando controles de la forma
        private PictureBox pic_Logo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercadeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pic_Caja;
        private System.Windows.Forms.GroupBox groupBoxdatos;
        private System.Windows.Forms.ComboBox combo_Concepto;
        private System.Windows.Forms.Label lbl_Unidad;
        private System.Windows.Forms.TextBox txt_DineroActual;
        private System.Windows.Forms.TextBox txt_Movimiento;
        private System.Windows.Forms.TextBox txt_DineroCaja;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label lbl_Concepto;
        private System.Windows.Forms.Label lbl_Movimiento;
        private System.Windows.Forms.Label lbl_MontoInicial;
        private System.Windows.Forms.DateTimePicker dateTime_Fecha;
        private System.Windows.Forms.ToolStripMenuItem movimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retirarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarCorteToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        #endregion
        private void Diseño_Forma()
        {
            pic_Logo = new System.Windows.Forms.PictureBox();
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caja));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            movimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            retirarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ingresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            realizarCorteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            acercadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pic_Caja = new System.Windows.Forms.PictureBox();
            groupBoxdatos = new System.Windows.Forms.GroupBox();
            dateTime_Fecha = new System.Windows.Forms.DateTimePicker();
            combo_Concepto = new System.Windows.Forms.ComboBox();
            lbl_Unidad = new System.Windows.Forms.Label();
            txt_DineroActual = new System.Windows.Forms.TextBox();
            txt_Movimiento = new System.Windows.Forms.TextBox();
            txt_DineroCaja = new System.Windows.Forms.TextBox();
            lbl_Fecha = new System.Windows.Forms.Label();
            lbl_Concepto = new System.Windows.Forms.Label();
            lbl_Movimiento = new System.Windows.Forms.Label();
            lbl_MontoInicial = new System.Windows.Forms.Label();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pic_Caja)).BeginInit();
            groupBoxdatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(errorProvider1)).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(186)))), ((int)(((byte)(82)))));
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            archivoToolStripMenuItem,
            movimientoToolStripMenuItem,
            ayudaToolStripMenuItem});
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(572, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            nuevoToolStripMenuItem,
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
            // movimientoToolStripMenuItem
            // 
            movimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            retirarToolStripMenuItem,
            ingresarToolStripMenuItem,
            realizarCorteToolStripMenuItem});
            movimientoToolStripMenuItem.Name = "movimientoToolStripMenuItem";
            movimientoToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            movimientoToolStripMenuItem.Text = "Movimiento";
            // 
            // retirarToolStripMenuItem
            // 
            retirarToolStripMenuItem.Name = "retirarToolStripMenuItem";
            retirarToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Retirar;
            retirarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            retirarToolStripMenuItem.Text = "Retirar";
            retirarToolStripMenuItem.Click += new System.EventHandler(retirarToolStripMenuItem_Click);
            // 
            // ingresarToolStripMenuItem
            // 
            ingresarToolStripMenuItem.Name = "ingresarToolStripMenuItem";
            ingresarToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Ingresar;
            ingresarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            ingresarToolStripMenuItem.Text = "Ingresar";
            ingresarToolStripMenuItem.Click += new System.EventHandler(ingresarToolStripMenuItem_Click);
            // 
            // realizarCorteToolStripMenuItem
            // 
            realizarCorteToolStripMenuItem.Name = "realizarCorteToolStripMenuItem";
            realizarCorteToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Calcular;
            realizarCorteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            realizarCorteToolStripMenuItem.Text = "Realizar corte";
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
            // pic_Caja
            // 
            pic_Caja.BackgroundImage = global::Sistema_Shajobe.Properties.Resources.Caja;
            pic_Caja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pic_Caja.Location = new System.Drawing.Point(473, 25);
            pic_Caja.Name = "pic_Caja";
            pic_Caja.Size = new System.Drawing.Size(85, 67);
            pic_Caja.TabIndex = 23;
            pic_Caja.TabStop = false;
            // 
            // groupBoxdatos
            // 
            groupBoxdatos.Controls.Add(dateTime_Fecha);
            groupBoxdatos.Controls.Add(pic_Logo);
            groupBoxdatos.Controls.Add(combo_Concepto);
            groupBoxdatos.Controls.Add(lbl_Unidad);
            groupBoxdatos.Controls.Add(txt_DineroActual);
            groupBoxdatos.Controls.Add(txt_Movimiento);
            groupBoxdatos.Controls.Add(txt_DineroCaja);
            groupBoxdatos.Controls.Add(lbl_Fecha);
            groupBoxdatos.Controls.Add(lbl_Concepto);
            groupBoxdatos.Controls.Add(lbl_Movimiento);
            groupBoxdatos.Controls.Add(lbl_MontoInicial);
            groupBoxdatos.Location = new System.Drawing.Point(4, 43);
            groupBoxdatos.Name = "groupBoxdatos";
            groupBoxdatos.Size = new System.Drawing.Size(555, 186);
            groupBoxdatos.TabIndex = 22;
            groupBoxdatos.TabStop = false;
            groupBoxdatos.Text = "Datos del producto";
            // 
            // dateTime_Fecha
            // 
            dateTime_Fecha.Location = new System.Drawing.Point(126, 89);
            dateTime_Fecha.Name = "dateTime_Fecha";
            dateTime_Fecha.Size = new System.Drawing.Size(200, 20);
            dateTime_Fecha.TabIndex = 58;
            // 
            // combo_Concepto
            // 
            combo_Concepto.FormattingEnabled = true;
            combo_Concepto.Location = new System.Drawing.Point(126, 116);
            combo_Concepto.Name = "combo_Concepto";
            combo_Concepto.Size = new System.Drawing.Size(156, 21);
            combo_Concepto.TabIndex = 57;
            // 
            // lbl_Unidad
            // 
            lbl_Unidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            lbl_Unidad.AutoSize = true;
            lbl_Unidad.Location = new System.Drawing.Point(27, 151);
            lbl_Unidad.Name = "lbl_Unidad";
            lbl_Unidad.Size = new System.Drawing.Size(70, 13);
            lbl_Unidad.TabIndex = 55;
            lbl_Unidad.Text = "Dinero actual";
            // 
            // txt_DineroActual
            // 
            txt_DineroActual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            txt_DineroActual.Enabled = false;
            txt_DineroActual.Location = new System.Drawing.Point(126, 144);
            txt_DineroActual.MaxLength = 9;
            txt_DineroActual.Name = "txt_DineroActual";
            txt_DineroActual.Size = new System.Drawing.Size(127, 20);
            txt_DineroActual.TabIndex = 53;
            // 
            // txt_Movimiento
            // 
            txt_Movimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            txt_Movimiento.Enabled = false;
            txt_Movimiento.Location = new System.Drawing.Point(126, 62);
            txt_Movimiento.MaxLength = 25;
            txt_Movimiento.Name = "txt_Movimiento";
            txt_Movimiento.Size = new System.Drawing.Size(127, 20);
            txt_Movimiento.TabIndex = 46;
            // 
            // txt_DineroCaja
            // 
            txt_DineroCaja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            txt_DineroCaja.Enabled = false;
            txt_DineroCaja.Location = new System.Drawing.Point(126, 35);
            txt_DineroCaja.MaxLength = 8;
            txt_DineroCaja.Name = "txt_DineroCaja";
            txt_DineroCaja.Size = new System.Drawing.Size(127, 20);
            txt_DineroCaja.TabIndex = 37;
            // 
            // lbl_Fecha
            // 
            lbl_Fecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            lbl_Fecha.AutoSize = true;
            lbl_Fecha.Location = new System.Drawing.Point(27, 96);
            lbl_Fecha.Name = "lbl_Fecha";
            lbl_Fecha.Size = new System.Drawing.Size(37, 13);
            lbl_Fecha.TabIndex = 44;
            lbl_Fecha.Text = "Fecha";
            // 
            // lbl_Concepto
            // 
            lbl_Concepto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            lbl_Concepto.AutoSize = true;
            lbl_Concepto.Location = new System.Drawing.Point(27, 124);
            lbl_Concepto.Name = "lbl_Concepto";
            lbl_Concepto.Size = new System.Drawing.Size(53, 13);
            lbl_Concepto.TabIndex = 38;
            lbl_Concepto.Text = "Concepto";
            // 
            // lbl_Movimiento
            // 
            lbl_Movimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            lbl_Movimiento.AutoSize = true;
            lbl_Movimiento.Location = new System.Drawing.Point(27, 69);
            lbl_Movimiento.Name = "lbl_Movimiento";
            lbl_Movimiento.Size = new System.Drawing.Size(61, 13);
            lbl_Movimiento.TabIndex = 36;
            lbl_Movimiento.Text = "Movimiento";
            // 
            // lbl_MontoInicial
            // 
            lbl_MontoInicial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            lbl_MontoInicial.AutoSize = true;
            lbl_MontoInicial.Location = new System.Drawing.Point(27, 42);
            lbl_MontoInicial.Name = "lbl_MontoInicial";
            lbl_MontoInicial.Size = new System.Drawing.Size(76, 13);
            lbl_MontoInicial.TabIndex = 35;
            lbl_MontoInicial.Text = "Dinero en caja";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // pic_Logo
            // 
            pic_Logo.BackgroundImage = global::Sistema_Shajobe.Properties.Resources.Logo_Shajobe;
            pic_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pic_Logo.Location = new System.Drawing.Point(380, 80);
            pic_Logo.Name = "pic_Logo";
            pic_Logo.Size = new System.Drawing.Size(166, 84);
            pic_Logo.TabIndex = 13;
            pic_Logo.TabStop = false;
            // 
            // Caja
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(196)))));
            ClientSize = new System.Drawing.Size(572, 238);
            Controls.Add(pic_Caja);
            Controls.Add(groupBoxdatos);
            Controls.Add(menuStrip1);
            Icon = global::Sistema_Shajobe.Properties.Resources.Caja_ICO;
            MaximizeBox = false;
            Name = "Caja";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Caja";
            Load += new System.EventHandler(Caja_Load);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pic_Caja)).EndInit();
            groupBoxdatos.ResumeLayout(false);
            groupBoxdatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(errorProvider1)).EndInit();
            AnimateWindow(Handle, 350, AnimateWindowFlags.AW_CENTER);
            AnimateWindow(Handle, 350, AnimateWindowFlags.AW_CENTER | AnimateWindowFlags.AW_SLIDE);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        #region Eventos
        private TextBox[] Campos = new TextBox[3];
        private bool Espacios_Vacios = false;
        private void Caja_Load(object sender, EventArgs e)
        {
            //Diseño de la forma
            Diseño_Forma();
            //LLENANDO DE DATOS EL COMBOBOX CON LOS CONCEPTOS DISPONIBLES
            Llenando_Combobox();
            Ultimo_Fondo();
        }
        private void Ultimo_Fondo()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "Select Monto_Final from Tb_Caja where Id_Caja=(Select MAX(Id_Caja) From Tb_Caja where Monto_Final!=0 and Monto_Movimiento!=0)";
            coman.CommandType = CommandType.Text;
            con.Open();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                txt_DineroCaja.Text = Convert.ToString(dr.GetDecimal(dr.GetOrdinal("Monto_Final")).ToString("N"));
            }
            con.Close();
        }
        //METODO PARA LLENAR EL COMBOBOX
        private void Llenando_Combobox()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "Select Concepto from Tb_ConceptoCaja";
            coman.CommandType = CommandType.Text;
            con.Open();
            combo_Concepto.Items.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Declarando Variables y obteniendo los valores correspondiente
                string Concepto = dr.GetString(dr.GetOrdinal("Concepto"));
                combo_Concepto.Items.Add(Concepto);

            }
            con.Close();
        }
        //-------------------------------------------------------------
        //------Obtiene la cadena de conexion desde la app Config------
        //-------------------------------------------------------------
        public static string ObtenerString()
        {
            return Settings.Default.SHAJOBEConnectionString;
        }
        //Controles que van a usar los movimientos de caja
        Panel panel_Ingresar;
        Panel panel_Retirar;
        TextBox txt_Retiro;
        TextBox txt_Ingresar;
        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Ingresar = new System.Windows.Forms.Panel();
            PictureBox pic_DineroI = new System.Windows.Forms.PictureBox();
            txt_Ingresar = new System.Windows.Forms.TextBox();
            Label lbl_Ingresar = new System.Windows.Forms.Label();
            Button bttn_Ingresar = new System.Windows.Forms.Button();
            // 
            // panel_Ingresar
            // 
            panel_Ingresar.Controls.Add(pic_DineroI);
            panel_Ingresar.Controls.Add(txt_Ingresar);
            panel_Ingresar.Controls.Add(lbl_Ingresar);
            panel_Ingresar.Controls.Add(bttn_Ingresar);
            panel_Ingresar.BorderStyle = BorderStyle.FixedSingle;
            panel_Ingresar.Location = new System.Drawing.Point(130, 50);
            panel_Ingresar.Name = "panel_Ingresar";
            panel_Ingresar.Size = new System.Drawing.Size(319, 131);
            panel_Ingresar.TabIndex = 0;
            // 
            // pic_DineroI
            // 
            pic_DineroI.BackgroundImage = global::Sistema_Shajobe.Properties.Resources.Dinero;
            pic_DineroI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pic_DineroI.Location = new System.Drawing.Point(3, 3);
            pic_DineroI.Name = "pic_DineroI";
            pic_DineroI.Size = new System.Drawing.Size(62, 55);
            pic_DineroI.TabIndex = 32;
            pic_DineroI.TabStop = false;
            // 
            // txt_Ingresar
            // 
            txt_Ingresar.Location = new System.Drawing.Point(89, 68);
            txt_Ingresar.Name = "txt_Ingresar";
            txt_Ingresar.Size = new System.Drawing.Size(100, 20);
            txt_Ingresar.TabIndex = 2;
            txt_Ingresar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_Ingresar_KeyPress);
            // 
            // lbl_Ingresar
            // 
            lbl_Ingresar.AutoSize = true;
            lbl_Ingresar.Location = new System.Drawing.Point(86, 52);
            lbl_Ingresar.Name = "lbl_Ingresar";
            lbl_Ingresar.Size = new System.Drawing.Size(87, 13);
            lbl_Ingresar.TabIndex = 1;
            lbl_Ingresar.Text = "Dinero a ingresar";
            // 
            // bttn_Ingresar
            // 
            bttn_Ingresar.BackgroundImage = global::Sistema_Shajobe.Properties.Resources.Agregar;
            bttn_Ingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            bttn_Ingresar.Location = new System.Drawing.Point(208, 47);
            bttn_Ingresar.Name = "bttn_Ingresar";
            bttn_Ingresar.Size = new System.Drawing.Size(60, 60);
            bttn_Ingresar.TabIndex = 0;
            bttn_Ingresar.Click += new System.EventHandler(bttn_Ingresa);
            bttn_Ingresar.UseVisualStyleBackColor = true;
            //Agregar el control a la forma
            groupBoxdatos.Visible = false;
            this.Controls.Add(panel_Ingresar);
        }
        private void retirarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Creando_PanelRetiro
            panel_Retirar = new System.Windows.Forms.Panel();
            PictureBox pic_Dinero = new System.Windows.Forms.PictureBox();
            txt_Retiro = new System.Windows.Forms.TextBox();
            Label lbl_Retiro = new System.Windows.Forms.Label();
            Button bttn_Retiro = new System.Windows.Forms.Button();
            // 
            // panel_Retirar
            // 
            panel_Retirar.Controls.Add(pic_Dinero);
            panel_Retirar.Controls.Add(txt_Retiro);
            panel_Retirar.Controls.Add(lbl_Retiro);
            panel_Retirar.Controls.Add(bttn_Retiro);
            panel_Retirar.BorderStyle = BorderStyle.FixedSingle;
            panel_Retirar.Location = new System.Drawing.Point(130, 50);
            panel_Retirar.Name = "panel_Retirar";
            panel_Retirar.Size = new System.Drawing.Size(319, 131);
            panel_Retirar.TabIndex = 33;
            // 
            // pic_Dinero
            // 
            pic_Dinero.BackgroundImage = global::Sistema_Shajobe.Properties.Resources.Dinero;
            pic_Dinero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pic_Dinero.Location = new System.Drawing.Point(3, 3);
            pic_Dinero.Name = "pic_Dinero";
            pic_Dinero.Size = new System.Drawing.Size(62, 55);
            pic_Dinero.TabIndex = 32;
            pic_Dinero.TabStop = false;
            // 
            // txt_Retiro
            // 
            txt_Retiro.Location = new System.Drawing.Point(89, 68);
            txt_Retiro.Name = "txt_Retiro";
            txt_Retiro.Size = new System.Drawing.Size(100, 20);
            txt_Retiro.TabIndex = 2;
            txt_Retiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_Ingresar_KeyPress);
            // 
            // lbl_Retiro
            // 
            lbl_Retiro.AutoSize = true;
            lbl_Retiro.Location = new System.Drawing.Point(86, 52);
            lbl_Retiro.Name = "lbl_Retiro";
            lbl_Retiro.Size = new System.Drawing.Size(76, 13);
            lbl_Retiro.TabIndex = 1;
            lbl_Retiro.Text = "Dinero a retirar";
            // 
            // bttn_Retiro
            // 
            bttn_Retiro.BackgroundImage = global::Sistema_Shajobe.Properties.Resources.Quitar;
            bttn_Retiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            bttn_Retiro.Location = new System.Drawing.Point(208, 47);
            bttn_Retiro.Name = "bttn_Retiro";
            bttn_Retiro.Size = new System.Drawing.Size(60, 60);
            bttn_Retiro.TabIndex = 0;
            bttn_Retiro.Click += new System.EventHandler(bttn_Retirar);
            bttn_Retiro.UseVisualStyleBackColor = true;
            groupBoxdatos.Visible = false;
            #endregion
            //Agregar el control a la forma
            this.Controls.Add(panel_Retirar);
        }
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Menu_principal"].Activate();
            this.Close();
        }
        private void txt_Ingresar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de numeros-------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47))
            {
                MessageBox.Show("Solo se aceptan numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void bttn_Ingresa(object sender, EventArgs e)
        {
            groupBoxdatos.Visible = true;// Habilito el control oculto
            this.Controls.Remove(panel_Ingresar);//Quito el panel que cree al momento de ejecucion
            decimal cantidad, caja, resultado;//Creo variables para realizar una operacion de ingresar
            if (txt_Ingresar.Text.Trim() == "")//Valido el campo que no tenga un campo vacio
            {
                txt_Ingresar.Text = "0.00";//Asigno un valor de cero                
            }
            if (txt_DineroCaja.Text.Trim() == "")//Valido el campo que no tenga un campo vacio
            {
                txt_DineroCaja.Text = "0.00";//Asigno un valor de cero 
            }
            cantidad = Convert.ToDecimal(txt_Ingresar.Text);//Obtengo los valores contenidos del textbox
            caja = Convert.ToDecimal(txt_DineroCaja.Text);//Obtengo los valores contenidos del textbox
            //Operacion
            txt_Movimiento.Text = txt_Ingresar.Text;
            resultado = cantidad + caja;
            txt_DineroActual.Text = Convert.ToString(resultado);

        }
        private void bttn_Retirar(object sender, EventArgs e)
        {
            groupBoxdatos.Visible = true;// Habilito el control oculto
            this.Controls.Remove(panel_Retirar);//Quito el panel que cree al momento de ejecucion
            decimal cantidad, caja, resultado;//Creo variables para realizar una operacion de retiro
            if (txt_Retiro.Text.Trim() == "")//Valido el campo que no tenga un campo vacio
            {
                txt_Retiro.Text = "0.00";//Asigno un valor de cero                
            }
            if (txt_DineroCaja.Text.Trim() == "")//Valido el campo que no tenga un campo vacio
            {
                txt_DineroCaja.Text = "0.00";//Asigno un valor de cero 
            }
            cantidad = Convert.ToDecimal(txt_Retiro.Text);//Obtengo los valores contenidos del textbox
            caja = Convert.ToDecimal(txt_DineroCaja.Text);//Obtengo los valores contenidos del textbox
            if (cantidad != 0)//Valido que sean diferentes a cero para poder entrar a realizar la operacion
            {
                if (caja > cantidad)//Valido que haya fondos para realizar la operacion
                {
                    //Operacion
                    txt_Movimiento.Text = txt_Retiro.Text;
                    resultado = caja - cantidad;
                    txt_DineroActual.Text = Convert.ToString(resultado);
                }
                else
                {
                    MessageBox.Show("No hay suficientes fondos para realizar la operación", "No se puede realizar la acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Movimiento.Text = "0.00";
                    txt_DineroActual.Text = "0.00";
                }
            }

        }
        private void Limpiar()
        {
            groupBoxdatos.Visible = true;
            txt_DineroActual.Clear();
            txt_DineroCaja.Clear();
            txt_Movimiento.Clear();
            combo_Concepto.ResetText();
            Ultimo_Fondo();
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
                    conexion = new OleDbConnection(ObtenerString());
                    conexion.Open();
                    transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                    OleDbCommand comando = new OleDbCommand("SP_Caja_Alta", conexion, transaccion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@Monto_Inicial", Convert.ToDecimal(txt_DineroCaja.Text));
                    comando.Parameters.AddWithValue("@Fecha", dateTime_Fecha.Value);
                    comando.Parameters.AddWithValue("@Monto_Movimiento", Convert.ToDecimal(txt_Movimiento.Text));
                    int concepto = combo_Concepto.SelectedIndex;
                    concepto++;
                    comando.Parameters.AddWithValue("@Id_Concepto", concepto);
                    comando.Parameters.AddWithValue("@Monto_Final", Convert.ToDecimal(txt_DineroActual.Text));
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
        private bool Verificar_CamposVacios()
        {
            //Se introduce los textbox en un arreglo con el fin de identificar espacios vacios
            Campos[0] = txt_DineroCaja;
            Campos[1] = txt_Movimiento;
            Campos[2] = txt_DineroActual;
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
                    errorProvider1.SetError(txt_DineroCaja, "No puedes dejar el campo vacio");
                    break;
                case 1:
                    errorProvider1.SetError(txt_Movimiento, "No puedes dejar el campo vacio");
                    break;
                case 2:
                    errorProvider1.SetError(txt_DineroActual, "No puedes dejar el campo vacio");
                    break;
                default:
                    break;
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
