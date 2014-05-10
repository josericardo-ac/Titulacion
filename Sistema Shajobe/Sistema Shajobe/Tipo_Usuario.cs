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
    public partial class Tipo_Usuario : Form
    {
        public Tipo_Usuario()
        {
            InitializeComponent();
        }
        #region Diseño de la forma
        #region Declarando controles de la forma
        private System.Windows.Forms.GroupBox groupBoxdatos;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label lbl_Nombre;
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
        private System.Windows.Forms.ToolStripMenuItem PermisosToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pic_TipoUsuario;
        private PictureBox pic_Logo;
        #endregion
        private void Diseño_Forma()
        {
            #region Creando controles de la forma
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tipo_pieza));
            groupBoxdatos = new System.Windows.Forms.GroupBox();
            txt_Descripcion = new System.Windows.Forms.TextBox();
            txt_Nombre = new System.Windows.Forms.TextBox();
            lbl_Descripcion = new System.Windows.Forms.Label();
            lbl_Nombre = new System.Windows.Forms.Label();
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
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            pic_TipoUsuario = new System.Windows.Forms.PictureBox();
            PermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            groupBoxdatos.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pic_TipoUsuario)).BeginInit();
            SuspendLayout();
            pic_Logo = new System.Windows.Forms.PictureBox();
            components = new System.ComponentModel.Container();
            groupBoxdatos = new System.Windows.Forms.GroupBox();
            txt_Descripcion = new System.Windows.Forms.TextBox();
            txt_Nombre = new System.Windows.Forms.TextBox();
            lbl_Descripcion = new System.Windows.Forms.Label();
            lbl_Nombre = new System.Windows.Forms.Label();
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
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            pic_TipoUsuario = new System.Windows.Forms.PictureBox();
            groupBoxdatos.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pic_TipoUsuario)).BeginInit();
            SuspendLayout();
            #endregion
            // 
            // groupBoxdatos
            // 
            groupBoxdatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            groupBoxdatos.Controls.Add(txt_Descripcion);
            groupBoxdatos.Controls.Add(txt_Nombre);
            groupBoxdatos.Controls.Add(lbl_Descripcion);
            groupBoxdatos.Controls.Add(lbl_Nombre);
            groupBoxdatos.Location = new System.Drawing.Point(11, 60);
            groupBoxdatos.Name = "groupBoxdatos";
            groupBoxdatos.Size = new System.Drawing.Size(418, 150);
            groupBoxdatos.TabIndex = 75;
            groupBoxdatos.TabStop = false;
            groupBoxdatos.Text = "Datos de Tipo de cargos";
            // 
            // txt_Descripcion
            // 
            txt_Descripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            txt_Descripcion.Location = new System.Drawing.Point(126, 87);
            txt_Descripcion.MaxLength = 35;
            txt_Descripcion.Name = "txt_Descripcion";
            txt_Descripcion.Size = new System.Drawing.Size(270, 40);
            txt_Descripcion.TabIndex = 73;
            txt_Descripcion.Multiline = true;
            txt_Descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_Descripcion_KeyPress);
            // 
            // txt_Nombre
            // 
            txt_Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            txt_Nombre.Location = new System.Drawing.Point(126, 62);
            txt_Nombre.MaxLength = 25;
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new System.Drawing.Size(127, 20);
            txt_Nombre.TabIndex = 72;
            txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_Nombre_KeyPress);
            // 
            // lbl_Descripcion
            // 
            lbl_Descripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            lbl_Descripcion.AutoSize = true;
            lbl_Descripcion.Location = new System.Drawing.Point(27, 91);
            lbl_Descripcion.Name = "lbl_Descripcion";
            lbl_Descripcion.Size = new System.Drawing.Size(34, 13);
            lbl_Descripcion.TabIndex = 71;
            lbl_Descripcion.Text = "Descripción";
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Location = new System.Drawing.Point(27, 66);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            lbl_Nombre.TabIndex = 69;
            lbl_Nombre.Text = "Nombre";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(186)))), ((int)(((byte)(82)))));
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            archivoToolStripMenuItem,
            editarToolStripMenuItem,
            PermisosToolStripMenuItem,
            ayudaToolStripMenuItem});
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(448, 24);
            menuStrip1.TabIndex = 77;
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
            // PermisosToolStripMenuItem
            // 
            PermisosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            PermisosToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            PermisosToolStripMenuItem.Name = "PermisosToolStripMenuItem";
            PermisosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            PermisosToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            PermisosToolStripMenuItem.Text = "&Permisos";
            PermisosToolStripMenuItem.Click += new System.EventHandler(PermisosToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            nuevoToolStripMenuItem.Image = global::Sistema_Shajobe.Properties.Resources.Nuevo;
            nuevoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            nuevoToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
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
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // pic_TipoUsuario
            // 
            pic_TipoUsuario.BackgroundImage = global::Sistema_Shajobe.Properties.Resources.Usuario;
            pic_TipoUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pic_TipoUsuario.Location = new System.Drawing.Point(351, 25);
            pic_TipoUsuario.Name = "pic_TipoUsuario";
            pic_TipoUsuario.Size = new System.Drawing.Size(85, 67);
            pic_TipoUsuario.TabIndex = 79;
            pic_TipoUsuario.TabStop = false;
            // 
            // pic_Logo
            // 
            pic_Logo.BackgroundImage = global::Sistema_Shajobe.Properties.Resources.Logo_Shajobe;
            pic_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pic_Logo.Location = new System.Drawing.Point(280, 200);
            pic_Logo.Name = "pic_Logo";
            pic_Logo.Size = new System.Drawing.Size(152, 70);
            pic_Logo.TabIndex = 13;
            pic_Logo.TabStop = false;
            pic_Logo.SendToBack();
            // 
            // Tipo de MateriaPrima
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(448, 284);
            Controls.Add(pic_TipoUsuario);
            Controls.Add(menuStrip1);
            Controls.Add(pic_Logo);
            Controls.Add(groupBoxdatos);
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(196)))));
            Icon = global::Sistema_Shajobe.Properties.Resources.MateriaPrima_ICO;
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(454, 306);
            MinimumSize = new System.Drawing.Size(454, 306);
            Name = "Tipo_Usuario";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Tipo de usuarios";
            Load += new System.EventHandler(Tipo_Usuario_Load);
            groupBoxdatos.ResumeLayout(false);
            groupBoxdatos.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pic_TipoUsuario)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private void Tipo_Usuario_Load(object sender, EventArgs e)
        {
            #region Animacion
            AnimateWindow(Handle, 350, AnimateWindowFlags.AW_CENTER);
            AnimateWindow(Handle, 450, AnimateWindowFlags.AW_CENTER | AnimateWindowFlags.AW_SLIDE);
            ResumeLayout(false);
            PerformLayout();
            #endregion
            Diseño_Forma();
        }
        #region Eventos
        //-------------------------------------------------------------
        //------------------Variables y Arreglos-----------------------
        //-------------------------------------------------------------
        private int Idp;//LO USO PARA OBTENER EL ID COMO RESULTADO DE LA BUSQUEDA
        private bool Espacios_Vacios = false;
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
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "Select * from Tb_Tipomateriaprima where Id_Tipomateriaprima='" + Idp + "'";
            coman.CommandType = CommandType.Text;
            con.Open();
            data_resultado.Rows.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                txt_Nombre.Text = dr.GetString(dr.GetOrdinal("Nombre"));
                txt_Descripcion.Text = dr.GetString(dr.GetOrdinal("Descripcion"));
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
                coman.CommandText = "Select * from Tb_Tipomateriaprima  where (Nombre='" + busqueda.ToUpper() + "') AND Activo='S'";
                coman.CommandType = CommandType.Text;
                con.Open();
                data_resultado.Rows.Clear();
                dr = coman.ExecuteReader();
                while (dr.Read())
                {
                    int Renglon = data_resultado.Rows.Add();
                    Idp = dr.GetInt32(dr.GetOrdinal("Id_Tipomateriaprima"));
                    data_resultado.Rows[Renglon].Cells["Id"].Value = dr.GetInt32(dr.GetOrdinal("Id_Tipomateriaprima"));
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
            comboBox_TipoUsuario.Items.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Declarando Variables y obteniendo los valores correspondiente
                string Tipo = dr.GetString(dr.GetOrdinal("Nombre"));
                comboBox_TipoUsuario.Items.Add(Tipo);
            }
            con.Close();
        }
        private void Llenando_DataGridViewMenus()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "SELECT * FROM V_Menu";
            coman.CommandType = CommandType.Text;
            con.Open();
            dataGridView_Menu.Rows.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Creando y obteniendo el indice para un nuevo renglon
                int Indice = dataGridView_Menu.Rows.Add();
                dataGridView_Menu.Rows[Indice].Cells["Id_Menu"].Value = dr.GetInt32(dr.GetOrdinal("Id_Menu"));
                dataGridView_Menu.Rows[Indice].Cells["Menu1"].Value = dr.GetString(dr.GetOrdinal("Concepto"));
            }
            con.Close();
        }
        private void Permisos_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "SELECT Tb_Menus.Id_Menu, Tb_Menus.Concepto FROM Tb_Menus INNER JOIN Tb_Permisos ON Tb_Menus.Id_Menu = Tb_Permisos.Id_Menu INNER JOIN Tb_TipoUsuario ON Tb_Permisos.Id_Tipo_Usuario = Tb_TipoUsuario.Id_Tipo_Usuario WHERE (Tb_TipoUsuario.Id_Tipo_Usuario ='" + comboBox_TipoUsuario.SelectedIndex+1 + "')";
            coman.CommandType = CommandType.Text;
            con.Open();
            dataGridView_Permisos.Rows.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Creando y obteniendo el indice para un nuevo renglon
                int Indice = dataGridView_Permisos.Rows.Add();
                dataGridView_Permisos.Rows[Indice].Cells["Id_MenuP"].Value = dr.GetInt32(dr.GetOrdinal("Id_Menu"));
                dataGridView_Permisos.Rows[Indice].Cells["Permiso"].Value = dr.GetString(dr.GetOrdinal("Concepto"));
            }
            con.Close();
        }
        //-------------------------------------------------------------
        //----------------CONFIGURACION DE CONTROLES-------------------
        //-------------------------------------------------------------
        #region Funciones A, B y C
        // ALTAS, BAJAS Y CAMBIOS
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
                    conexion = new OleDbConnection(ObtenerString());
                    conexion.Open();
                    transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                    OleDbCommand comando = new OleDbCommand("SP_Tipomateriaprima_Alta", conexion, transaccion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@Nombre", txt_Nombre.Text);
                    comando.Parameters.AddWithValue("@Descripcion", txt_Descripcion.Text);
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
                    OleDbCommand comando = new OleDbCommand("SP_Tipomateriaprima_Cambios", con, tran);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@Id_Tipomateriaprima", Idp);
                    comando.Parameters.AddWithValue("@Nombre", txt_Nombre.Text);
                    comando.Parameters.AddWithValue("@Descripcion", txt_Descripcion.Text);
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
                OleDbCommand comando = new OleDbCommand("SP_Tipomateriaprima_Bajas", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Id_Tipomateriaprima", Idp);
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
            eliminarToolStripMenuItem.Enabled = false;
            modificarToolStripMenuItem.Enabled = false;
            errorProvider1.Clear();
            groupBoxdatos.Visible = true;
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
                //Limpio el control 
                txt_Busqueda.Clear();
            }
            catch (Exception)
            {
                //En caso de que no existe todavia el texbox
                //omite la instrucción de quitar dicho control
            }
            try
            {
                //Quito el panel de busqueda
                Controls.Remove(panel_Permisos);
            }
            catch (Exception)
            {
                //En caso de que no existe todavia el panel de busqueda
                //omite la instrucción de quitar dicho control
            }
            try
            {
                //Limpio el control
                comboBox_TipoUsuario.ResetText();
            }
            catch (Exception)
            {
                //En caso de que no existe todavia el panel de busqueda
                //omite la instrucción de quitar dicho control
            }
        }
        #endregion
        #region Abrir
        #region Declarando controles
        //Creando controles
        private DataGridView data_resultado;
        private TextBox txt_Busqueda;
        private PictureBox pic_Lupa;
        private Button bttn_Busqueda;
        private Panel panel_Busqueda;
        private Label lbl_Etiqueta;
        //Creando Columnas del DATAGRID
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Id;
        #endregion
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Creando controles
            //INICIALIZANDO CONTROLES
            txt_Busqueda = new System.Windows.Forms.TextBox();
            panel_Busqueda = new System.Windows.Forms.Panel();
            data_resultado = new System.Windows.Forms.DataGridView();
            pic_Lupa = new System.Windows.Forms.PictureBox();
            bttn_Busqueda = new System.Windows.Forms.Button();
            lbl_Etiqueta = new System.Windows.Forms.Label();
            //groupBoxfoto.SuspendLayout();
            //INICIALIZANDO COLUMNAS
            Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            #endregion
            #region Diseño de controles
            //DISEÑOS DE A LOS CONTROLES
            txt_Busqueda.Location = new System.Drawing.Point(130, 57);
            txt_Busqueda.Name = "txt_Busqueda";
            txt_Busqueda.Size = new System.Drawing.Size(124, 20);
            txt_Busqueda.TabIndex = 0;
            txt_Busqueda.MaxLength = 25;
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
            data_resultado.Location = new System.Drawing.Point(11, 126);
            data_resultado.Name = "data_resultado";
            data_resultado.RowHeadersWidth = 25;
            data_resultado.RowTemplate.Height = 25;
            data_resultado.Size = new System.Drawing.Size(340, 100);
            data_resultado.TabIndex = 2;
            data_resultado.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(data_resultado_MouseDoubleClick);
            data_resultado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
            lbl_Etiqueta.Location = new System.Drawing.Point(110, 26);
            lbl_Etiqueta.Name = "lbl_Etiqueta";
            lbl_Etiqueta.Size = new System.Drawing.Size(419, 13);
            lbl_Etiqueta.TabIndex = 3;
            lbl_Etiqueta.Text = "Escriba el nombre del tipo de materia prima a buscar";
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
            panel_Busqueda.Size = new System.Drawing.Size(370, 235);
            panel_Busqueda.TabIndex = 35;
            panel_Busqueda.BorderStyle = BorderStyle.FixedSingle;
            panel_Busqueda.Visible = false;
            //CARACTERISTICA DE AUTOCOMPLETADO EN TXT_BUSQUEDA
            txt_Busqueda.AutoCompleteCustomSource = Autocomplete();
            txt_Busqueda.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_Busqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Controls.Add(panel_Busqueda);
            groupBoxdatos.Visible = false;
            panel_Busqueda.Visible = true;
            panel_Busqueda.Enabled = true;
            panel_Busqueda.BringToFront();
            #endregion
        }
        #endregion
        #region Salir
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
        #endregion
        #region Funcion de permisos
        #region Declarando controles de panel de permisos
        private System.Windows.Forms.Panel panel_Permisos;
        private System.Windows.Forms.DataGridView dataGridView_Permisos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_MenuP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Permiso;
        private System.Windows.Forms.DataGridView dataGridView_Menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menu1;
        private System.Windows.Forms.Button bttn_Quitar;
        private System.Windows.Forms.Button bttn_Agregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_STipo_Usuario;
        private System.Windows.Forms.ComboBox comboBox_TipoUsuario;
        #endregion
        private void PermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Creando controles de panel de permisos
            panel_Permisos = new System.Windows.Forms.Panel();
            bttn_Agregar = new System.Windows.Forms.Button();
            bttn_Quitar = new System.Windows.Forms.Button();
            dataGridView_Menu = new System.Windows.Forms.DataGridView();
            dataGridView_Permisos = new System.Windows.Forms.DataGridView();
            Id_Menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Menu1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Id_MenuP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Permiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            comboBox_TipoUsuario = new System.Windows.Forms.ComboBox();
            lbl_STipo_Usuario = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            panel_Permisos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridView_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dataGridView_Permisos)).BeginInit();
            SuspendLayout();
            // 
            // panel_Permisos
            // 
            panel_Permisos.Controls.Add(label1);
            panel_Permisos.Controls.Add(lbl_STipo_Usuario);
            panel_Permisos.Controls.Add(comboBox_TipoUsuario);
            panel_Permisos.Controls.Add(dataGridView_Permisos);
            panel_Permisos.Controls.Add(dataGridView_Menu);
            panel_Permisos.Controls.Add(bttn_Quitar);
            panel_Permisos.Controls.Add(bttn_Agregar);
            panel_Permisos.Location = new System.Drawing.Point(33, 21);
            panel_Permisos.Name = "panel_Permisos";
            panel_Permisos.Size = new System.Drawing.Size(370, 247);
            panel_Permisos.TabIndex = 0;
            // 
            // bttn_Agregar
            // 
            bttn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            bttn_Agregar.Location = new System.Drawing.Point(148, 89);
            bttn_Agregar.Name = "bttn_Agregar";
            bttn_Agregar.Size = new System.Drawing.Size(75, 23);
            bttn_Agregar.TabIndex = 0;
            bttn_Agregar.Text = ">>";
            bttn_Agregar.UseVisualStyleBackColor = true;
            // 
            // bttn_Quitar
            // 
            bttn_Quitar.Location = new System.Drawing.Point(148, 118);
            bttn_Quitar.Name = "bttn_Quitar";
            bttn_Quitar.Size = new System.Drawing.Size(75, 23);
            bttn_Quitar.TabIndex = 1;
            bttn_Quitar.Text = "<<";
            bttn_Quitar.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Menu
            // 
            dataGridView_Menu.AllowUserToAddRows = false;
            dataGridView_Menu.AllowUserToDeleteRows = false;
            dataGridView_Menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Menu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Id_Menu,
            Menu1});
            dataGridView_Menu.Location = new System.Drawing.Point(3, 36);
            dataGridView_Menu.Name = "dataGridView_Menu";
            dataGridView_Menu.ReadOnly = true;
            dataGridView_Menu.Size = new System.Drawing.Size(133, 205);
            dataGridView_Menu.TabIndex = 2;
            // 
            // dataGridView_Permisos
            // 
            dataGridView_Permisos.AllowUserToAddRows = false;
            dataGridView_Permisos.AllowUserToDeleteRows = false;
            dataGridView_Permisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Permisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Id_MenuP,
            Permiso});
            dataGridView_Permisos.Location = new System.Drawing.Point(234, 36);
            dataGridView_Permisos.Name = "dataGridView_Permisos";
            dataGridView_Permisos.ReadOnly = true;
            dataGridView_Permisos.Size = new System.Drawing.Size(133, 205);
            dataGridView_Permisos.TabIndex = 3;
            // 
            // Id_Menu
            // 
            Id_Menu.HeaderText = "Id_Menu";
            Id_Menu.Name = "Id_Menu";
            Id_Menu.ReadOnly = true;
            Id_Menu.Visible = false;
            // 
            // Menu
            // 
            Menu1.HeaderText = "Menu";
            Menu1.Name = "Menu1";
            Menu1.ReadOnly = true;
            // 
            // Id_MenuP
            // 
            Id_MenuP.HeaderText = "Id_MenuP";
            Id_MenuP.Name = "Id_MenuP";
            Id_MenuP.ReadOnly = true;
            Id_MenuP.Visible = false;
            // 
            // Permiso
            // 
            Permiso.HeaderText = "Permiso";
            Permiso.Name = "Permiso";
            Permiso.ReadOnly = true;
            // 
            // comboBox_TipoUsuario
            // 
            comboBox_TipoUsuario.FormattingEnabled = true;
            comboBox_TipoUsuario.Location = new System.Drawing.Point(82, 10);
            comboBox_TipoUsuario.Name = "comboBox_TipoUsuario";
            comboBox_TipoUsuario.Size = new System.Drawing.Size(121, 21);
            comboBox_TipoUsuario.KeyPress += new KeyPressEventHandler(NoescrituracomboBox_KeyPress);
            comboBox_TipoUsuario.SelectedIndexChanged += new System.EventHandler(Permisos_SelectedIndexChanged);
            comboBox_TipoUsuario.TabIndex = 4;
            // 
            // lbl_STipo_Usuario
            // 
            lbl_STipo_Usuario.AutoSize = true;
            lbl_STipo_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.System;
            lbl_STipo_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_STipo_Usuario.Location = new System.Drawing.Point(3, 13);
            lbl_STipo_Usuario.Name = "lbl_STipo_Usuario";
            lbl_STipo_Usuario.Size = new System.Drawing.Size(80, 13);
            lbl_STipo_Usuario.TabIndex = 5;
            lbl_STipo_Usuario.Text = "Tipo de usuario";
            // 
            // label1
            // 
            label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(235, 3);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(132, 33);
            label1.TabIndex = 6;
            label1.Text = "Panel de asignación de permisos";
            // 
            // Form1
            // 
            Controls.Add(panel_Permisos);
            panel_Permisos.ResumeLayout(false);
            panel_Permisos.PerformLayout();
            panel_Permisos.BorderStyle = BorderStyle.FixedSingle;
            //groupBoxdatos.SendToBack();
            //pic_Logo.SendToBack();
            //pic_TipoUsuario.SendToBack();
            panel_Permisos.BringToFront();
            #endregion
            //Llenando controles
            Llenando_DataGridViewMenus();
            Llenando_ComboboxTipoUsuario();
        }
        #endregion
        #region Funcion Agregar y Quitar
        #region Agregar
        private void bttn_Agregar_Click(object sender, EventArgs e)
        {
            if (dataGridView_Menu.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto para agregar al carrito", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                int Lista = dataGridView_Permisos.Rows.Add();
                dataGridView_Permisos.Rows[Lista].Cells["Id_MenuP"].Value = Convert.ToInt32(dataGridView_Menu.CurrentRow.Cells["Id_Menu"].Value);
                dataGridView_Permisos.Rows[Lista].Cells["Permiso"].Value = Convert.ToString(dataGridView_Menu.CurrentRow.Cells["Menu1"].Value);           
            }
        }
        #endregion
        #region Quitar
        private void bttn_Quitar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseas realmente quitar este permiso", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                dataGridView_Permisos.Rows.RemoveAt(dataGridView_Permisos.CurrentRow.Index);
            }
        }
        #endregion
        #endregion
        //-------------------------------------------------------------
        //---------------CONTROL DE ESPACIOS VACIOS--------------------
        //-------------------------------------------------------------
        #region Verificar campos vacios
        //METODOS PARA INDICAR ERROR DE CAMPOS VACIOS
        private TextBox[] Campos = new TextBox[2];
        private bool Verificar_CamposVacios()
        {
            //Se introduce los textbox en un arreglo con el fin de identificar espacios vacios
            Campos[0] = txt_Nombre;
            Campos[1] = txt_Descripcion;
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
                    errorProvider1.SetError(txt_Nombre, "No puedes dejar el campo vacio");
                    break;
                case 1:
                    errorProvider1.SetError(txt_Descripcion, "No puedes dejar el campo vacio");
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
            string consulta = "SELECT * FROM V_TiposmateriaPrima "; //consulta a la tabla paises
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
        #region Cadena de conexión
        //OBTIENE LA CADENA DE CONEXION
        public static string ObtenerString()
        {
            return Settings.Default.SHAJOBEConnectionString;
        }
        #endregion
        //-------------------------------------------------------------
        //-------------------Validacion de campos----------------------
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
