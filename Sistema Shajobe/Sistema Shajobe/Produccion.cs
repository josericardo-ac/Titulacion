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
    public partial class Produccion : Form
    {
        public Produccion()
        {
            InitializeComponent();
        }
        #region Diseño de la forma
        #region Declarando controles de la forma
        private System.Windows.Forms.DataGridView dataGridView_Composicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Materiaprima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materiaprima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Unidad;
        private System.Windows.Forms.GroupBox groupBox_Composicion;
        private System.Windows.Forms.GroupBox groupBox_Producto;
        private System.Windows.Forms.Label lbl_UnidadM;
        private System.Windows.Forms.Label lbl_CantidadM;
        private System.Windows.Forms.Label lbl_Unidad;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label lbl_Producto;
        private System.Windows.Forms.Label lbl_Lote;
        private System.Windows.Forms.ComboBox comboBox_Unidad;
        private System.Windows.Forms.Button bttn_Quitar;
        private System.Windows.Forms.Button bttn_Agregar;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Fecha;
        private System.Windows.Forms.DataGridView dataGridView_Materiaprima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia_prima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Pieza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Materiaprima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.TextBox txt_CantidadM;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.ComboBox comboBox_UnidadM;
        private System.Windows.Forms.ComboBox comboBox_Producto;
        private System.Windows.Forms.TextBox txt_Lote;
        #endregion
        private void Diseño_Forma()
        {
            #region Creando controles de la forma
            dataGridView_Composicion = new System.Windows.Forms.DataGridView();
            Id_Materiaprima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Materiaprima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Id_Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBox_Composicion = new System.Windows.Forms.GroupBox();
            groupBox_Producto = new System.Windows.Forms.GroupBox();
            bttn_Quitar = new System.Windows.Forms.Button();
            bttn_Agregar = new System.Windows.Forms.Button();
            dateTimePicker_Fecha = new System.Windows.Forms.DateTimePicker();
            dataGridView_Materiaprima = new System.Windows.Forms.DataGridView();
            Id_Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Materia_prima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Tipo_Pieza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Tipo_Materiaprima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txt_CantidadM = new System.Windows.Forms.TextBox();
            txt_Cantidad = new System.Windows.Forms.TextBox();
            comboBox_UnidadM = new System.Windows.Forms.ComboBox();
            comboBox_Producto = new System.Windows.Forms.ComboBox();
            txt_Lote = new System.Windows.Forms.TextBox();
            comboBox_Unidad = new System.Windows.Forms.ComboBox();
            lbl_Lote = new System.Windows.Forms.Label();
            lbl_Producto = new System.Windows.Forms.Label();
            lbl_Fecha = new System.Windows.Forms.Label();
            lbl_Cantidad = new System.Windows.Forms.Label();
            lbl_Unidad = new System.Windows.Forms.Label();
            lbl_CantidadM = new System.Windows.Forms.Label();
            lbl_UnidadM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(dataGridView_Composicion)).BeginInit();
            groupBox_Composicion.SuspendLayout();
            groupBox_Producto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridView_Materiaprima)).BeginInit();
            SuspendLayout();
            #endregion
            // 
            // dataGridView_Composicion
            // 
            dataGridView_Composicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Composicion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Id_Materiaprima,
            Materiaprima,
            Cantidad,
            Unidad,
            Id_Unidad});
            dataGridView_Composicion.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView_Composicion.Location = new System.Drawing.Point(3, 16);
            dataGridView_Composicion.Name = "dataGridView_Composicion";
            dataGridView_Composicion.Size = new System.Drawing.Size(849, 237);
            dataGridView_Composicion.TabIndex = 8;
            // 
            // Id_Materiaprima
            // 
            Id_Materiaprima.HeaderText = "Id_Materiaprima";
            Id_Materiaprima.Name = "Id_Materiaprima";
            Id_Materiaprima.Visible = false;
            // 
            // Materiaprima
            // 
            Materiaprima.HeaderText = "Materia prima";
            Materiaprima.Name = "Materiaprima";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Unidad
            // 
            Unidad.HeaderText = "Unidad";
            Unidad.Name = "Unidad";
            // 
            // Id_Unidad
            // 
            Id_Unidad.HeaderText = "Id_Unidad";
            Id_Unidad.Name = "Id_Unidad";
            Id_Unidad.Visible = false;
            // 
            // groupBox_Composicion
            // 
            groupBox_Composicion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            groupBox_Composicion.Controls.Add(dataGridView_Composicion);
            groupBox_Composicion.Location = new System.Drawing.Point(9, 272);
            groupBox_Composicion.Name = "groupBox_Composicion";
            groupBox_Composicion.Size = new System.Drawing.Size(855, 256);
            groupBox_Composicion.TabIndex = 12;
            groupBox_Composicion.TabStop = false;
            groupBox_Composicion.Text = "Composicion";
            // 
            // groupBox_Producto
            // 
            groupBox_Producto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            groupBox_Producto.Controls.Add(lbl_UnidadM);
            groupBox_Producto.Controls.Add(lbl_CantidadM);
            groupBox_Producto.Controls.Add(lbl_Unidad);
            groupBox_Producto.Controls.Add(lbl_Cantidad);
            groupBox_Producto.Controls.Add(lbl_Fecha);
            groupBox_Producto.Controls.Add(lbl_Producto);
            groupBox_Producto.Controls.Add(lbl_Lote);
            groupBox_Producto.Controls.Add(comboBox_Unidad);
            groupBox_Producto.Controls.Add(bttn_Quitar);
            groupBox_Producto.Controls.Add(bttn_Agregar);
            groupBox_Producto.Controls.Add(dateTimePicker_Fecha);
            groupBox_Producto.Controls.Add(dataGridView_Materiaprima);
            groupBox_Producto.Controls.Add(txt_CantidadM);
            groupBox_Producto.Controls.Add(txt_Cantidad);
            groupBox_Producto.Controls.Add(comboBox_UnidadM);
            groupBox_Producto.Controls.Add(comboBox_Producto);
            groupBox_Producto.Controls.Add(txt_Lote);
            groupBox_Producto.Location = new System.Drawing.Point(9, 46);
            groupBox_Producto.Name = "groupBox_Producto";
            groupBox_Producto.Size = new System.Drawing.Size(855, 220);
            groupBox_Producto.TabIndex = 13;
            groupBox_Producto.TabStop = false;
            groupBox_Producto.Text = "Producción de producto";
            // 
            // bttn_Quitar
            // 
            bttn_Quitar.Location = new System.Drawing.Point(392, 133);
            bttn_Quitar.Name = "bttn_Quitar";
            bttn_Quitar.Size = new System.Drawing.Size(75, 23);
            bttn_Quitar.TabIndex = 21;
            bttn_Quitar.Text = "Quitar";
            bttn_Quitar.UseVisualStyleBackColor = true;
            // 
            // bttn_Agregar
            // 
            bttn_Agregar.Location = new System.Drawing.Point(392, 104);
            bttn_Agregar.Name = "bttn_Agregar";
            bttn_Agregar.Size = new System.Drawing.Size(75, 23);
            bttn_Agregar.TabIndex = 20;
            bttn_Agregar.Text = "Agregar";
            bttn_Agregar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_Fecha
            // 
            dateTimePicker_Fecha.Location = new System.Drawing.Point(71, 88);
            dateTimePicker_Fecha.Name = "dateTimePicker_Fecha";
            dateTimePicker_Fecha.Size = new System.Drawing.Size(200, 20);
            dateTimePicker_Fecha.TabIndex = 19;
            // 
            // dataGridView_Materiaprima
            // 
            dataGridView_Materiaprima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Materiaprima.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Id_Materia,
            Materia_prima,
            Tipo_Pieza,
            Tipo_Materiaprima,
            Descripcion});
            dataGridView_Materiaprima.Location = new System.Drawing.Point(473, 28);
            dataGridView_Materiaprima.Name = "dataGridView_Materiaprima";
            dataGridView_Materiaprima.Size = new System.Drawing.Size(376, 186);
            dataGridView_Materiaprima.TabIndex = 18;
            // 
            // Id_Materia
            // 
            Id_Materia.HeaderText = "Id_Materia";
            Id_Materia.Name = "Id_Materia";
            Id_Materia.Visible = false;
            // 
            // Materia_prima
            // 
            Materia_prima.HeaderText = "Materia prima";
            Materia_prima.Name = "Materia_prima";
            // 
            // Tipo_Pieza
            // 
            Tipo_Pieza.HeaderText = "Tipo pieza";
            Tipo_Pieza.Name = "Tipo_Pieza";
            // 
            // Tipo_Materiaprima
            // 
            Tipo_Materiaprima.HeaderText = "Tipo de materia prima";
            Tipo_Materiaprima.Name = "Tipo_Materiaprima";
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            // 
            // txt_CantidadM
            // 
            txt_CantidadM.Location = new System.Drawing.Point(367, 35);
            txt_CantidadM.Name = "txt_CantidadM";
            txt_CantidadM.Size = new System.Drawing.Size(100, 20);
            txt_CantidadM.TabIndex = 16;
            // 
            // txt_Cantidad
            // 
            txt_Cantidad.Location = new System.Drawing.Point(71, 117);
            txt_Cantidad.Name = "txt_Cantidad";
            txt_Cantidad.Size = new System.Drawing.Size(100, 20);
            txt_Cantidad.TabIndex = 15;
            // 
            // comboBox_UnidadM
            // 
            comboBox_UnidadM.FormattingEnabled = true;
            comboBox_UnidadM.Location = new System.Drawing.Point(367, 69);
            comboBox_UnidadM.Name = "comboBox_UnidadM";
            comboBox_UnidadM.Size = new System.Drawing.Size(68, 21);
            comboBox_UnidadM.TabIndex = 14;
            // 
            // comboBox_Producto
            // 
            comboBox_Producto.FormattingEnabled = true;
            comboBox_Producto.Location = new System.Drawing.Point(71, 56);
            comboBox_Producto.Name = "comboBox_Producto";
            comboBox_Producto.Size = new System.Drawing.Size(121, 21);
            comboBox_Producto.TabIndex = 13;
            // 
            // txt_Lote
            // 
            txt_Lote.Location = new System.Drawing.Point(71, 28);
            txt_Lote.Name = "txt_Lote";
            txt_Lote.Size = new System.Drawing.Size(100, 20);
            txt_Lote.TabIndex = 12;
            // 
            // comboBox_Unidad
            // 
            comboBox_Unidad.FormattingEnabled = true;
            comboBox_Unidad.Location = new System.Drawing.Point(224, 116);
            comboBox_Unidad.Name = "comboBox_Unidad";
            comboBox_Unidad.Size = new System.Drawing.Size(68, 21);
            comboBox_Unidad.TabIndex = 22;
            // 
            // lbl_Lote
            // 
            lbl_Lote.AutoSize = true;
            lbl_Lote.Location = new System.Drawing.Point(13, 35);
            lbl_Lote.Name = "lbl_Lote";
            lbl_Lote.Size = new System.Drawing.Size(28, 13);
            lbl_Lote.TabIndex = 24;
            lbl_Lote.Text = "Lote";
            // 
            // lbl_Producto
            // 
            lbl_Producto.AutoSize = true;
            lbl_Producto.Location = new System.Drawing.Point(13, 64);
            lbl_Producto.Name = "lbl_Producto";
            lbl_Producto.Size = new System.Drawing.Size(50, 13);
            lbl_Producto.TabIndex = 25;
            lbl_Producto.Text = "Producto";
            // 
            // lbl_Fecha
            // 
            lbl_Fecha.AutoSize = true;
            lbl_Fecha.Location = new System.Drawing.Point(13, 95);
            lbl_Fecha.Name = "lbl_Fecha";
            lbl_Fecha.Size = new System.Drawing.Size(37, 13);
            lbl_Fecha.TabIndex = 26;
            lbl_Fecha.Text = "Fecha";
            // 
            // lbl_Cantidad
            // 
            lbl_Cantidad.AutoSize = true;
            lbl_Cantidad.Location = new System.Drawing.Point(13, 124);
            lbl_Cantidad.Name = "lbl_Cantidad";
            lbl_Cantidad.Size = new System.Drawing.Size(49, 13);
            lbl_Cantidad.TabIndex = 27;
            lbl_Cantidad.Text = "Cantidad";
            // 
            // lbl_Unidad
            // 
            lbl_Unidad.AutoSize = true;
            lbl_Unidad.Location = new System.Drawing.Point(177, 124);
            lbl_Unidad.Name = "lbl_Unidad";
            lbl_Unidad.Size = new System.Drawing.Size(41, 13);
            lbl_Unidad.TabIndex = 28;
            lbl_Unidad.Text = "Unidad";
            // 
            // lbl_CantidadM
            // 
            lbl_CantidadM.AutoSize = true;
            lbl_CantidadM.Location = new System.Drawing.Point(305, 42);
            lbl_CantidadM.Name = "lbl_CantidadM";
            lbl_CantidadM.Size = new System.Drawing.Size(49, 13);
            lbl_CantidadM.TabIndex = 29;
            lbl_CantidadM.Text = "Cantidad";
            // 
            // lbl_UnidadM
            // 
            lbl_UnidadM.AutoSize = true;
            lbl_UnidadM.Location = new System.Drawing.Point(305, 77);
            lbl_UnidadM.Name = "lbl_UnidadM";
            lbl_UnidadM.Size = new System.Drawing.Size(41, 13);
            lbl_UnidadM.TabIndex = 30;
            lbl_UnidadM.Text = "Unidad";
            // 
            // Produccion
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(872, 535);
            Controls.Add(groupBox_Producto);
            Controls.Add(groupBox_Composicion);
            Name = "Produccion";
            Text = "Produccion";
            ((System.ComponentModel.ISupportInitialize)(dataGridView_Composicion)).EndInit();
            groupBox_Composicion.ResumeLayout(false);
            groupBox_Producto.ResumeLayout(false);
            groupBox_Producto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridView_Materiaprima)).EndInit();
            ResumeLayout(false);
        }
        #endregion
        private void Produccion_Load(object sender, EventArgs e)
        {
            #region Animacion
            AnimateWindow(Handle, 350, AnimateWindowFlags.AW_CENTER);
            AnimateWindow(Handle, 450, AnimateWindowFlags.AW_CENTER | AnimateWindowFlags.AW_SLIDE);
            ResumeLayout(false);
            PerformLayout();
            #endregion
            Diseño_Forma();
        }
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
