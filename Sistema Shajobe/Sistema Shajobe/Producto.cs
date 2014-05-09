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
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }
        #region Diseño de la forma
        #region Declarando controles de la forma
        private PictureBox pic_Logo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercadeToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider_Textbox;
        private System.Windows.Forms.ErrorProvider errorProvider_Combobox;
        private System.Windows.Forms.PictureBox pic_Producto;
        private System.Windows.Forms.GroupBox groupBoxdatos;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.TextBox txt_CodigoBarra;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.Label lbl_CodigoBarra;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.GroupBox groupBoxNivel;
        private System.Windows.Forms.ComboBox comboBox_Unidad;
        private System.Windows.Forms.ComboBox comboBox_UnidadProducto;
        private System.Windows.Forms.Label lbl_Unidad;
        private System.Windows.Forms.Label lbl_UnidadProducto;
        // Seccion de nivel de materia prima
        private System.Windows.Forms.Label lbl_NMin;
        private System.Windows.Forms.Label lbl_NMax;
        private System.Windows.Forms.TextBox txt_NMin;
        private System.Windows.Forms.TextBox txt_NMax;
        #endregion
        private void Diseño_Forma()
        {
            #region Creando controles de la forma
            pic_Logo = new System.Windows.Forms.PictureBox();
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producto));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            acercadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            errorProvider_Textbox = new System.Windows.Forms.ErrorProvider(components);
            errorProvider_Combobox = new System.Windows.Forms.ErrorProvider(components);
            pic_Producto = new System.Windows.Forms.PictureBox();
            groupBoxdatos = new System.Windows.Forms.GroupBox();
            lbl_Cantidad = new System.Windows.Forms.Label();
            lbl_CodigoBarra = new System.Windows.Forms.Label();
            txt_Cantidad = new System.Windows.Forms.TextBox();
            txt_CodigoBarra = new System.Windows.Forms.TextBox();
            txt_Descripcion = new System.Windows.Forms.TextBox();
            txt_Nombre = new System.Windows.Forms.TextBox();
            lbl_Descripcion = new System.Windows.Forms.Label();
            lbl_Nombre = new System.Windows.Forms.Label();
            groupBoxNivel = new System.Windows.Forms.GroupBox();
            comboBox_Unidad = new System.Windows.Forms.ComboBox();
            comboBox_UnidadProducto = new System.Windows.Forms.ComboBox();
            lbl_UnidadProducto = new System.Windows.Forms.Label();
            lbl_Unidad = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(errorProvider_Textbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pic_Producto)).BeginInit();
            groupBoxdatos.SuspendLayout();
            groupBoxNivel.SuspendLayout();
            SuspendLayout();
            // Seccion de Nivel de materia prima
            lbl_NMin = new System.Windows.Forms.Label();
            lbl_NMax = new System.Windows.Forms.Label();
            txt_NMin = new System.Windows.Forms.TextBox();
            txt_NMax = new System.Windows.Forms.TextBox();
            #endregion
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
            menuStrip1.Size = new System.Drawing.Size(594, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            nuevoToolStripMenuItem,
            abrirToolStripMenuItem,
            toolStripSeparator,
            guardarToolStripMenuItem,
            toolStripSeparator1,
            salirToolStripMenuItem});
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            nuevoToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Nuevo;
            nuevoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            nuevoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            abrirToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            abrirToolStripMenuItem.Text = "&Abrir";
            abrirToolStripMenuItem.Click += new System.EventHandler(abrirToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new System.Drawing.Size(148, 6);
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripMenuItem.Image")));
            guardarToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Guardar;
            guardarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            guardarToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            guardarToolStripMenuItem.Text = "&Guardar";
            guardarToolStripMenuItem.Click += new System.EventHandler(guardarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            salirToolStripMenuItem.Text = "&Salir";
            salirToolStripMenuItem.Click += new System.EventHandler(salirToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            modificarToolStripMenuItem,
            eliminarToolStripMenuItem});
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            editarToolStripMenuItem.Text = "&Editar";
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.Enabled = false;
            modificarToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Modificar;
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            modificarToolStripMenuItem.Text = "Modificar";
            modificarToolStripMenuItem.Click += new System.EventHandler(modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Enabled = false;
            eliminarToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Borrar;
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += new System.EventHandler(eliminarToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            acercadeToolStripMenuItem});
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            ayudaToolStripMenuItem.Text = "Ay&uda";
            // 
            // acercadeToolStripMenuItem
            // 
            acercadeToolStripMenuItem.Name = "acercadeToolStripMenuItem";
            acercadeToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            acercadeToolStripMenuItem.Text = "&Acerca de...";
            // 
            // errorProvider_Textbox
            // 
            errorProvider_Textbox.ContainerControl = this;
            // 
            // errorProvider_Combobox
            // 
            errorProvider_Combobox.ContainerControl = this;
            // 
            // pic_Producto
            // 
            pic_Producto.BackgroundImage = global::Sistema_Shajobe.Properties.Resources.Producto;
            pic_Producto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pic_Producto.Location = new System.Drawing.Point(493, 25);
            pic_Producto.Name = "pic_Producto";
            pic_Producto.Size = new System.Drawing.Size(85, 67);
            pic_Producto.TabIndex = 23;
            pic_Producto.TabStop = false;
            // 
            // groupBoxdatos
            // 
            groupBoxdatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            groupBoxdatos.Controls.Add(pic_Logo);
            groupBoxdatos.Controls.Add(txt_Descripcion);
            groupBoxdatos.Controls.Add(txt_Nombre);
            groupBoxdatos.Controls.Add(lbl_Descripcion);
            groupBoxdatos.Controls.Add(lbl_Nombre);
            groupBoxdatos.Controls.Add(lbl_Cantidad);
            groupBoxdatos.Controls.Add(lbl_CodigoBarra);
            groupBoxdatos.Controls.Add(txt_Cantidad);
            groupBoxdatos.Controls.Add(txt_CodigoBarra);
            groupBoxdatos.Controls.Add(groupBoxNivel);
            groupBoxdatos.Controls.Add(comboBox_UnidadProducto);
            groupBoxdatos.Controls.Add(lbl_UnidadProducto);
            groupBoxdatos.Location = new System.Drawing.Point(7, 49);
            groupBoxdatos.Name = "groupBoxdatos";
            groupBoxdatos.Size = new System.Drawing.Size(570, 330);
            groupBoxdatos.TabIndex = 22;
            groupBoxdatos.TabStop = false;
            groupBoxdatos.Text = "Datos del producto";
            // 
            // txt_CodigoBarra
            // 
            txt_CodigoBarra.Location = new System.Drawing.Point(122, 177);
            txt_CodigoBarra.MaxLength = 13;
            txt_CodigoBarra.Multiline = true;
            txt_CodigoBarra.Name = "txt_CodigoBarra";
            txt_CodigoBarra.Size = new System.Drawing.Size(127, 20);
            // 
            // txt_Cantidad
            // 
            txt_Cantidad.Location = new System.Drawing.Point(122, 147);
            txt_Cantidad.MaxLength = 9;
            txt_Cantidad.Multiline = true;
            txt_Cantidad.Name = "txt_Cantidad";
            txt_Cantidad.Size = new System.Drawing.Size(127, 20);
            //txt_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_Descripcion_KeyPress);
            // 
            // txt_Descripcion
            // 
            txt_Descripcion.Location = new System.Drawing.Point(122, 57);
            txt_Descripcion.MaxLength = 50;
            txt_Descripcion.Multiline = true;
            txt_Descripcion.Name = "txt_Descripcion";
            txt_Descripcion.Size = new System.Drawing.Size(127, 81);
            txt_Descripcion.TabIndex = 53;
            txt_Descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_Descripcion_KeyPress);
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new System.Drawing.Point(122, 31);
            txt_Nombre.MaxLength = 25;
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new System.Drawing.Size(127, 20);
            txt_Nombre.TabIndex = 47;
            txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_Nombre_KeyPress);
            // 
            // lbl_CodigoBarra
            // 
            lbl_CodigoBarra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            lbl_CodigoBarra.AutoSize = true;
            lbl_CodigoBarra.Location = new System.Drawing.Point(23, 181);
            lbl_CodigoBarra.Name = "lbl_CodigoBarra";
            lbl_CodigoBarra.Size = new System.Drawing.Size(63, 13);
            lbl_CodigoBarra.TabIndex = 44;
            lbl_CodigoBarra.Text = "Codigo de barra";
            // 
            // lbl_Cantidad
            // 
            lbl_Cantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            lbl_Cantidad.AutoSize = true;
            lbl_Cantidad.Location = new System.Drawing.Point(23, 149);
            lbl_Cantidad.Name = "lbl_Cantidad";
            lbl_Cantidad.Size = new System.Drawing.Size(63, 13);
            lbl_Cantidad.TabIndex = 44;
            lbl_Cantidad.Text = "Cantidad";
            // 
            // lbl_Descripcion
            // 
            lbl_Descripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            lbl_Descripcion.AutoSize = true;
            lbl_Descripcion.Location = new System.Drawing.Point(23, 61);
            lbl_Descripcion.Name = "lbl_Descripcion";
            lbl_Descripcion.Size = new System.Drawing.Size(63, 13);
            lbl_Descripcion.TabIndex = 44;
            lbl_Descripcion.Text = "Descripción";
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Location = new System.Drawing.Point(23, 35);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            lbl_Nombre.TabIndex = 38;
            lbl_Nombre.Text = "Nombre";
            // 
            // comboBox_UnidadProducto
            // 
            comboBox_UnidadProducto.FormattingEnabled = true;
            comboBox_UnidadProducto.Location = new System.Drawing.Point(122, 207);
            comboBox_UnidadProducto.Name = "comboBox_UnidadProducto";
            comboBox_UnidadProducto.Size = new System.Drawing.Size(100, 21);
            // 
            // lbl_UnidadProducto
            // 
            lbl_UnidadProducto.AutoSize = true;
            lbl_UnidadProducto.Location = new System.Drawing.Point(23, 211);
            lbl_UnidadProducto.Name = "lbl_Unidad";
            lbl_UnidadProducto.Size = new System.Drawing.Size(86, 13);
            lbl_UnidadProducto.Text = "Unidad de medida";
            // 
            // groupBoxNivelProducto
            // 
            groupBoxNivel.Controls.Add(txt_NMin);
            groupBoxNivel.Controls.Add(txt_NMax);
            groupBoxNivel.Controls.Add(lbl_NMin);
            groupBoxNivel.Controls.Add(lbl_NMax);
            groupBoxNivel.Controls.Add(lbl_Unidad);
            groupBoxNivel.Controls.Add(comboBox_Unidad);
            groupBoxNivel.Location = new System.Drawing.Point(301, 31);
            groupBoxNivel.Name = "groupBoxNivelproducto";
            groupBoxNivel.Size = new System.Drawing.Size(237, 236);
            groupBoxNivel.TabIndex = 31;
            groupBoxNivel.TabStop = false;
            groupBoxNivel.Text = "Nivel de producto";
            // 
            // lbl_NMax
            // 
            lbl_NMax.AutoSize = true;
            lbl_NMax.Location = new System.Drawing.Point(20, 65);
            lbl_NMax.Name = "lbl_NMax";
            lbl_NMax.Size = new System.Drawing.Size(87, 13);
            lbl_NMax.TabIndex = 3;
            lbl_NMax.Text = "Cantidad máxima";
            // 
            // lbl_NMin
            // 
            lbl_NMin.AutoSize = true;
            lbl_NMin.Location = new System.Drawing.Point(20, 35);
            lbl_NMin.Name = "lbl_NMin";
            lbl_NMin.Size = new System.Drawing.Size(86, 13);
            lbl_NMin.TabIndex = 2;
            lbl_NMin.Text = "Cantidad mínima";
            // 
            // txt_NMax
            // 
            txt_NMax.Location = new System.Drawing.Point(121, 60);
            txt_NMax.Name = "txt_NMax";
            txt_NMax.Size = new System.Drawing.Size(100, 20);
            txt_NMax.KeyPress += new KeyPressEventHandler(txt_MinMax_KeyPress);
            txt_NMax.TabIndex = 7;
            txt_NMax.MaxLength = 9;
            // 
            // txt_NMin
            // 
            txt_NMin.Location = new System.Drawing.Point(121, 30);
            txt_NMin.Name = "txt_NMin";
            txt_NMin.Size = new System.Drawing.Size(100, 20);
            txt_NMin.KeyPress += new KeyPressEventHandler(txt_MinMax_KeyPress);
            txt_NMin.TabIndex = 6;
            txt_NMin.MaxLength = 9;
            // 
            // comboBox_Unidad
            // 
            comboBox_Unidad.FormattingEnabled = true;
            comboBox_Unidad.Location = new System.Drawing.Point(121, 90);
            comboBox_Unidad.Name = "comboBox_Unidad";
            comboBox_Unidad.Size = new System.Drawing.Size(100, 21);
            // 
            // lbl_Unidad
            // 
            lbl_Unidad.AutoSize = true;
            lbl_Unidad.Location = new System.Drawing.Point(20, 95);
            lbl_Unidad.Name = "lbl_Unidad";
            lbl_Unidad.Size = new System.Drawing.Size(86, 13);
            lbl_Unidad.Text = "Unidad de medida";
            // 
            // pic_Logo
            // 
            pic_Logo.BackgroundImage = global::Sistema_Shajobe.Properties.Resources.Logo_Shajobe;
            pic_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pic_Logo.Location = new System.Drawing.Point(80, 230);
            pic_Logo.Name = "pic_Logo";
            pic_Logo.Size = new System.Drawing.Size(166, 84);
            pic_Logo.TabIndex = 13;
            pic_Logo.TabStop = false;
            // 
            // Producto
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(196)))));
            ClientSize = new System.Drawing.Size(594, 404);
            Controls.Add(pic_Producto);
            Controls.Add(groupBoxdatos);
            Controls.Add(menuStrip1);
            Icon = global::Sistema_Shajobe.Properties.Resources.Producto_ICO;
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(600, 426);
            MinimumSize = new System.Drawing.Size(600, 426);
            Name = "Producto";
            Text = "Producto";
            Load += new System.EventHandler(Producto_Load);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(errorProvider_Textbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(errorProvider_Combobox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pic_Producto)).EndInit();
            groupBoxdatos.ResumeLayout(false);
            groupBoxdatos.PerformLayout();
            groupBoxNivel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        #region Eventos
        //-------------------------------------------------------------
        //------------------Variables y Arreglos-----------------------
        //-------------------------------------------------------------
        private TextBox[] Campos = new TextBox[6];
        private ComboBox[] CamposC = new ComboBox[2];
        private int Idp;//LO USO PARA OBTENER EL ID COMO RESULTADO DE LA BUSQUEDA
        private bool Espacios_Vacios = false, Espacios_NoSeleccionados = false;
        private void Producto_Load(object sender, EventArgs e)
        {
            #region Animacion
            AnimateWindow(Handle, 350, AnimateWindowFlags.AW_CENTER);
            AnimateWindow(Handle, 450, AnimateWindowFlags.AW_CENTER | AnimateWindowFlags.AW_SLIDE);
            ResumeLayout(false);
            PerformLayout();
            #endregion
            Diseño_Forma();
            //LLENANDO DE DATOS EL COMBOBOX
            Llenando_ComboboxUnidad();
            Llenando_ComboboxUnidadProducto();
            txt_Nombre.Focus();
        }
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
            coman.CommandText = "SELECT Tb_Producto.Nombre, Tb_Producto.Descripcion, Tb_Producto.Cantidad, Tb_Producto.Codigo_Barra, Tb_Producto.Id_Unidadmedida, Tb_NivelProducto.Id_Unidadmedida AS Id_UnidadmedidaN, Tb_NivelProducto.N_Max, Tb_NivelProducto.N_Min FROM Tb_Producto INNER JOIN Tb_NivelProducto ON Tb_Producto.Id_Producto = Tb_NivelProducto.Id_Producto where Tb_Producto.Id_Producto='" + Idp + "'";
            coman.CommandType = CommandType.Text;
            con.Open();
            data_resultado.Rows.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                txt_Nombre.Text = dr.GetString(dr.GetOrdinal("Nombre"));
                txt_Descripcion.Text = dr.GetString(dr.GetOrdinal("Descripcion"));
                txt_Cantidad.Text = dr.GetDecimal(dr.GetOrdinal("Cantidad")).ToString("N"); ;
                txt_CodigoBarra.Text = dr.GetString(dr.GetOrdinal("Codigo_Barra"));
                int seleccion = dr.GetInt32(dr.GetOrdinal("Id_Unidadmedida"));
                seleccion = seleccion - 1;
                comboBox_Unidad.SelectedIndex= seleccion;
                int seleccion1 = dr.GetInt32(dr.GetOrdinal("Id_UnidadmedidaN"));
                seleccion1 = seleccion1 - 1;
                comboBox_UnidadProducto.SelectedIndex = seleccion1;
                txt_NMin.Text = dr.GetDecimal(dr.GetOrdinal("N_Min")).ToString("N"); ;
                txt_NMax.Text = dr.GetDecimal(dr.GetOrdinal("N_Max")).ToString("N"); ;
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
                coman.CommandText = "SELECT Id_Producto, Nombre, Descripcion FROM Tb_Producto WHERE (Tb_Producto.Activo = 'S' and Tb_Producto.Nombre='" + busqueda.ToUpper() + "')";
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
        #endregion
        //-------------------------------------------------------------
        //----------------CONFIGURACION DE CONTROLES-------------------
        //-------------------------------------------------------------
        #region Funciones A, B y C
        #region Guardar
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool i = Verificar_CamposVacios();
            bool ic = Verificar_CamposNoSeleccionados();
            if (i == true && ic == true)
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
                    OleDbCommand comando = new OleDbCommand("SP_Producto_Alta", conexion, transaccion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@Id_Unidadmedida", comboBox_Unidad.SelectedIndex + 1);
                    comando.Parameters.AddWithValue("@Nombre", txt_Nombre.Text);
                    comando.Parameters.AddWithValue("@Descripcion", txt_Descripcion.Text);
                    comando.Parameters.AddWithValue("@Cantidad", Convert.ToDecimal(txt_Cantidad.Text));
                    comando.Parameters.AddWithValue("@Codigo_Barra", txt_CodigoBarra.Text);
                    comando.Parameters.AddWithValue("@Id_UnidadmedidaN", comboBox_UnidadProducto.SelectedIndex+1);
                    comando.Parameters.AddWithValue("@N_Max", Convert.ToDecimal(txt_NMax.Text));
                    comando.Parameters.AddWithValue("@N_Min", Convert.ToDecimal(txt_NMin.Text));
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
        #endregion
        #region Cambios
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool i = Verificar_CamposVacios();
            bool ic = Verificar_CamposNoSeleccionados();
            if (i == true && ic == true)
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
                    OleDbCommand comando = new OleDbCommand("SP_Producto_Cambios", con, tran);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@Id_Producto", Idp);
                    comando.Parameters.AddWithValue("@Id_Unidadmedida", comboBox_Unidad.SelectedIndex + 1);
                    comando.Parameters.AddWithValue("@Nombre", txt_Nombre.Text);
                    comando.Parameters.AddWithValue("@Descripcion", txt_Descripcion.Text);
                    comando.Parameters.AddWithValue("@Cantidad", Convert.ToDecimal(txt_Cantidad.Text));
                    comando.Parameters.AddWithValue("@Codigo_Barra", txt_CodigoBarra.Text);
                    comando.Parameters.AddWithValue("@Id_UnidadmedidaN", comboBox_UnidadProducto.SelectedIndex + 1);
                    comando.Parameters.AddWithValue("@N_Max", Convert.ToDecimal(txt_NMax.Text));
                    comando.Parameters.AddWithValue("@N_Min", Convert.ToDecimal(txt_NMin.Text));
                    comando.ExecuteNonQuery();
                    tran.Commit();
                    MessageBox.Show("Datos Modificados con éxito", "Solicitud procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error inesperado", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tran.Rollback();
                }
                finally
                {
                    con.Close();
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
                OleDbCommand comando = new OleDbCommand("SP_Producto_Bajas", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Id_Producto", Idp);
                comando.ExecuteNonQuery();
                transaccion.Commit();
                MessageBox.Show("Datos Modificados con éxito", "Solicitud procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txt_Nombre.Clear();
            txt_Descripcion.Clear();
            groupBoxdatos.Visible = true;
            comboBox_Unidad.ResetText();
            comboBox_UnidadProducto.ResetText();
            txt_CodigoBarra.Clear();
            txt_Cantidad.Clear();
            txt_NMax.Clear();
            txt_NMin.Clear();
            modificarToolStripMenuItem.Enabled = false;
            eliminarToolStripMenuItem.Enabled = false;
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
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //INICIALIZANDO CONTROLES
            panel_Busqueda = new System.Windows.Forms.Panel();
            txt_Busqueda = new System.Windows.Forms.TextBox();
            data_resultado = new System.Windows.Forms.DataGridView();
            pic_Lupa = new System.Windows.Forms.PictureBox();
            bttn_Busqueda = new System.Windows.Forms.Button();
            lbl_Etiqueta = new System.Windows.Forms.Label();
            //groupBoxNivel.SuspendLayout();
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
            groupBoxdatos.Visible = false;
            panel_Busqueda.Visible = true;
            panel_Busqueda.Enabled = true;
            //CARACTERISTICA DE AUTOCOMPLETADO EN TXT_BUSQUEDA
            txt_Busqueda.AutoCompleteCustomSource = Autocomplete();
            txt_Busqueda.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_Busqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        #endregion
        #region Salir
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            Campos[0] = txt_Nombre;
            Campos[1] = txt_Descripcion;
            Campos[2] = txt_Cantidad;
            Campos[3] = txt_CodigoBarra;
            Campos[4] = txt_NMin;
            Campos[5] = txt_NMax;
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
                    errorProvider_Textbox.SetError(txt_Nombre, "No puedes dejar el campo vacio");
                    break;
                case 1:
                    errorProvider_Textbox.SetError(txt_Descripcion, "No puedes dejar el campo vacio");
                    break;
                case 2:
                    errorProvider_Textbox.SetError(txt_Cantidad, "No puedes dejar el campo vacio");
                    break;
                case 3:
                    errorProvider_Textbox.SetError(txt_CodigoBarra, "No puedes dejar el campo vacio");
                    break;
                case 4:
                    errorProvider_Textbox.SetError(txt_NMin, "No puedes dejar el campo vacio");
                    break;
                case 5:
                    errorProvider_Textbox.SetError(txt_NMax, "No puedes dejar el campo vacio");
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
            CamposC[0] = comboBox_Unidad;
            CamposC[1] = comboBox_UnidadProducto;
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
                    errorProvider_Combobox.SetError(comboBox_Unidad, "No puedes dejar el campo vacio");
                    break;
                case 1:
                    errorProvider_Combobox.SetError(comboBox_UnidadProducto, "No puedes dejar el campo vacio");
                    break;
                default:
                    break;
            }
        }
        #endregion
        //-------------------------------------------------------------
        //----------------------AUTO COMPLETAR-------------------------
        //-------------------------------------------------------------
        #region Funcion Autocompletar
        //metodo para cargar la coleccion de datos para el autocomplete
        public static DataTable Datos()
        {
            DataTable dt = new DataTable();

            OleDbConnection conexion = new OleDbConnection(ObtenerString());//cadena conexion
            string consulta = "SELECT Nombre FROM Tb_Producto where Activo='S'"; 
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
            }
            return coleccion;
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
        #region Validacion de campos
        private void txt_Busqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de letras-----------------------------------------------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto-------------------------- Uso del espacio
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
        private void txt_Descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47) && (e.KeyChar < 31 || e.KeyChar > 33))
            {
                MessageBox.Show("Solo se aceptan letras y numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void txt_MinMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de numeros-------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47))
            {
                MessageBox.Show("Solo se aceptan numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        #endregion
        //-------------------------------------------------------------
        //-------------LLENADO DE CONTROLES DEL SISTEMA----------------
        //-------------------------------------------------------------
        #region Llenado de los combobox
        private void Llenando_ComboboxUnidad()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "Select *  from V_Unidadmedida";
            coman.CommandType = CommandType.Text;
            con.Open();
            comboBox_Unidad.Items.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Declarando Variables y obteniendo los valores correspondiente
                string Simbolo = dr.GetString(dr.GetOrdinal("Simbolo"));
                comboBox_Unidad.Items.Add(Simbolo);
            }
            con.Close();
        }
        private void Llenando_ComboboxUnidadProducto()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "Select *  from V_Unidadmedida";
            coman.CommandType = CommandType.Text;
            con.Open();
            comboBox_UnidadProducto.Items.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Declarando Variables y obteniendo los valores correspondiente
                string Simbolo = dr.GetString(dr.GetOrdinal("Simbolo"));
                comboBox_UnidadProducto.Items.Add(Simbolo);
            }
            con.Close();
        }
        #endregion
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
