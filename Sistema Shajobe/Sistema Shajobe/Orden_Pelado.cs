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
    public partial class Orden_Pelado : Form
    {
        public Orden_Pelado()
        {
            InitializeComponent();
        }
        #region Diseño de la forma
        #region Declarando controles de la forma
        private System.Windows.Forms.GroupBox groupBox_DatosPelado;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Fecha;
        private System.Windows.Forms.Label lbl_Unidad;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label lbl_Precioventa;
        private System.Windows.Forms.Label lbl_Preciocompra;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.Label lbl_Id_Tipopieza;
        private System.Windows.Forms.Label lbl_IdMateriaprima;
        private System.Windows.Forms.Label lbl_Lote;
        private System.Windows.Forms.Label lbl_Almacen;
        private System.Windows.Forms.TextBox txt_Precioventa;
        private System.Windows.Forms.TextBox txt_Preciocompra;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.TextBox txt_Lote;
        private System.Windows.Forms.ComboBox comboBox_Unidad;
        private System.Windows.Forms.ComboBox comboBox_Tipopieza;
        private System.Windows.Forms.ComboBox comboBox_Materiaprima;
        private System.Windows.Forms.ComboBox comboBox_Almacen;
        private System.Windows.Forms.GroupBox groupBox_Historial;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia_Prima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Pieza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        #endregion
        private void Diseño_Forma()
        {
            #region Creando controles de la forma
            this.groupBox_DatosPelado = new System.Windows.Forms.GroupBox();
            this.groupBox_Historial = new System.Windows.Forms.GroupBox();
            this.comboBox_Almacen = new System.Windows.Forms.ComboBox();
            this.comboBox_Materiaprima = new System.Windows.Forms.ComboBox();
            this.comboBox_Tipopieza = new System.Windows.Forms.ComboBox();
            this.comboBox_Unidad = new System.Windows.Forms.ComboBox();
            this.txt_Lote = new System.Windows.Forms.TextBox();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.txt_Preciocompra = new System.Windows.Forms.TextBox();
            this.txt_Precioventa = new System.Windows.Forms.TextBox();
            this.lbl_Almacen = new System.Windows.Forms.Label();
            this.lbl_Lote = new System.Windows.Forms.Label();
            this.lbl_IdMateriaprima = new System.Windows.Forms.Label();
            this.lbl_Id_Tipopieza = new System.Windows.Forms.Label();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.lbl_Preciocompra = new System.Windows.Forms.Label();
            this.lbl_Precioventa = new System.Windows.Forms.Label();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.lbl_Unidad = new System.Windows.Forms.Label();
            this.dateTimePicker_Fecha = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia_Prima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Pieza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_DatosPelado.SuspendLayout();
            this.groupBox_Historial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            #endregion
            // 
            // groupBox_DatosPelado
            // 
            this.groupBox_DatosPelado.Controls.Add(this.dateTimePicker_Fecha);
            this.groupBox_DatosPelado.Controls.Add(this.lbl_Unidad);
            this.groupBox_DatosPelado.Controls.Add(this.lbl_Fecha);
            this.groupBox_DatosPelado.Controls.Add(this.lbl_Precioventa);
            this.groupBox_DatosPelado.Controls.Add(this.lbl_Preciocompra);
            this.groupBox_DatosPelado.Controls.Add(this.lbl_Cantidad);
            this.groupBox_DatosPelado.Controls.Add(this.lbl_Id_Tipopieza);
            this.groupBox_DatosPelado.Controls.Add(this.lbl_IdMateriaprima);
            this.groupBox_DatosPelado.Controls.Add(this.lbl_Lote);
            this.groupBox_DatosPelado.Controls.Add(this.lbl_Almacen);
            this.groupBox_DatosPelado.Controls.Add(this.txt_Precioventa);
            this.groupBox_DatosPelado.Controls.Add(this.txt_Preciocompra);
            this.groupBox_DatosPelado.Controls.Add(this.txt_Cantidad);
            this.groupBox_DatosPelado.Controls.Add(this.txt_Lote);
            this.groupBox_DatosPelado.Controls.Add(this.comboBox_Unidad);
            this.groupBox_DatosPelado.Controls.Add(this.comboBox_Tipopieza);
            this.groupBox_DatosPelado.Controls.Add(this.comboBox_Materiaprima);
            this.groupBox_DatosPelado.Controls.Add(this.comboBox_Almacen);
            this.groupBox_DatosPelado.Location = new System.Drawing.Point(6, 28);
            this.groupBox_DatosPelado.Name = "groupBox_DatosPelado";
            this.groupBox_DatosPelado.Size = new System.Drawing.Size(314, 293);
            this.groupBox_DatosPelado.TabIndex = 0;
            this.groupBox_DatosPelado.TabStop = false;
            this.groupBox_DatosPelado.Text = "Datos de orden de pelado";
            // 
            // groupBox_Historial
            // 
            this.groupBox_Historial.Controls.Add(this.dataGridView1);
            this.groupBox_Historial.Location = new System.Drawing.Point(326, 28);
            this.groupBox_Historial.Name = "groupBox_Historial";
            this.groupBox_Historial.Size = new System.Drawing.Size(573, 476);
            this.groupBox_Historial.TabIndex = 0;
            this.groupBox_Historial.TabStop = false;
            this.groupBox_Historial.Text = "Historial de orden de pelado";
            // 
            // comboBox_Almacen
            // 
            this.comboBox_Almacen.FormattingEnabled = true;
            this.comboBox_Almacen.Location = new System.Drawing.Point(101, 34);
            this.comboBox_Almacen.Name = "comboBox_Almacen";
            this.comboBox_Almacen.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Almacen.TabIndex = 0;
            // 
            // comboBox_Materiaprima
            // 
            this.comboBox_Materiaprima.FormattingEnabled = true;
            this.comboBox_Materiaprima.Location = new System.Drawing.Point(101, 97);
            this.comboBox_Materiaprima.Name = "comboBox_Materiaprima";
            this.comboBox_Materiaprima.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Materiaprima.TabIndex = 1;
            // 
            // comboBox_Tipopieza
            // 
            this.comboBox_Tipopieza.FormattingEnabled = true;
            this.comboBox_Tipopieza.Location = new System.Drawing.Point(101, 129);
            this.comboBox_Tipopieza.Name = "comboBox_Tipopieza";
            this.comboBox_Tipopieza.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Tipopieza.TabIndex = 2;
            // 
            // comboBox_Unidad
            // 
            this.comboBox_Unidad.FormattingEnabled = true;
            this.comboBox_Unidad.Location = new System.Drawing.Point(207, 161);
            this.comboBox_Unidad.Name = "comboBox_Unidad";
            this.comboBox_Unidad.Size = new System.Drawing.Size(79, 21);
            this.comboBox_Unidad.TabIndex = 3;
            // 
            // txt_Lote
            // 
            this.txt_Lote.Location = new System.Drawing.Point(101, 66);
            this.txt_Lote.Name = "txt_Lote";
            this.txt_Lote.Size = new System.Drawing.Size(100, 20);
            this.txt_Lote.TabIndex = 4;
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(101, 161);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_Cantidad.TabIndex = 5;
            // 
            // txt_Preciocompra
            // 
            this.txt_Preciocompra.Location = new System.Drawing.Point(101, 192);
            this.txt_Preciocompra.Name = "txt_Preciocompra";
            this.txt_Preciocompra.Size = new System.Drawing.Size(100, 20);
            this.txt_Preciocompra.TabIndex = 6;
            // 
            // txt_Precioventa
            // 
            this.txt_Precioventa.Location = new System.Drawing.Point(101, 223);
            this.txt_Precioventa.Name = "txt_Precioventa";
            this.txt_Precioventa.Size = new System.Drawing.Size(100, 20);
            this.txt_Precioventa.TabIndex = 7;
            // 
            // lbl_Almacen
            // 
            this.lbl_Almacen.AutoSize = true;
            this.lbl_Almacen.Location = new System.Drawing.Point(20, 42);
            this.lbl_Almacen.Name = "lbl_Almacen";
            this.lbl_Almacen.Size = new System.Drawing.Size(48, 13);
            this.lbl_Almacen.TabIndex = 9;
            this.lbl_Almacen.Text = "Almacén";
            // 
            // lbl_Lote
            // 
            this.lbl_Lote.AutoSize = true;
            this.lbl_Lote.Location = new System.Drawing.Point(20, 73);
            this.lbl_Lote.Name = "lbl_Lote";
            this.lbl_Lote.Size = new System.Drawing.Size(28, 13);
            this.lbl_Lote.TabIndex = 10;
            this.lbl_Lote.Text = "Lote";
            // 
            // lbl_IdMateriaprima
            // 
            this.lbl_IdMateriaprima.AutoSize = true;
            this.lbl_IdMateriaprima.Location = new System.Drawing.Point(20, 105);
            this.lbl_IdMateriaprima.Name = "lbl_IdMateriaprima";
            this.lbl_IdMateriaprima.Size = new System.Drawing.Size(70, 13);
            this.lbl_IdMateriaprima.TabIndex = 11;
            this.lbl_IdMateriaprima.Text = "Materia prima";
            // 
            // lbl_Id_Tipopieza
            // 
            this.lbl_Id_Tipopieza.AutoSize = true;
            this.lbl_Id_Tipopieza.Location = new System.Drawing.Point(20, 137);
            this.lbl_Id_Tipopieza.Name = "lbl_Id_Tipopieza";
            this.lbl_Id_Tipopieza.Size = new System.Drawing.Size(71, 13);
            this.lbl_Id_Tipopieza.TabIndex = 12;
            this.lbl_Id_Tipopieza.Text = "Tipo de pieza";
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Location = new System.Drawing.Point(20, 169);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(49, 13);
            this.lbl_Cantidad.TabIndex = 13;
            this.lbl_Cantidad.Text = "Cantidad";
            // 
            // lbl_Preciocompra
            // 
            this.lbl_Preciocompra.AutoSize = true;
            this.lbl_Preciocompra.Location = new System.Drawing.Point(20, 199);
            this.lbl_Preciocompra.Name = "lbl_Preciocompra";
            this.lbl_Preciocompra.Size = new System.Drawing.Size(75, 13);
            this.lbl_Preciocompra.TabIndex = 14;
            this.lbl_Preciocompra.Text = "Precio compra";
            // 
            // lbl_Precioventa
            // 
            this.lbl_Precioventa.AutoSize = true;
            this.lbl_Precioventa.Location = new System.Drawing.Point(20, 230);
            this.lbl_Precioventa.Name = "lbl_Precioventa";
            this.lbl_Precioventa.Size = new System.Drawing.Size(67, 13);
            this.lbl_Precioventa.TabIndex = 15;
            this.lbl_Precioventa.Text = "Precio venta";
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Location = new System.Drawing.Point(20, 261);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(37, 13);
            this.lbl_Fecha.TabIndex = 16;
            this.lbl_Fecha.Text = "Fecha";
            // 
            // lbl_Unidad
            // 
            this.lbl_Unidad.AutoSize = true;
            this.lbl_Unidad.Location = new System.Drawing.Point(245, 145);
            this.lbl_Unidad.Name = "lbl_Unidad";
            this.lbl_Unidad.Size = new System.Drawing.Size(41, 13);
            this.lbl_Unidad.TabIndex = 17;
            this.lbl_Unidad.Text = "Unidad";
            // 
            // dateTimePicker_Fecha
            // 
            this.dateTimePicker_Fecha.Location = new System.Drawing.Point(101, 254);
            this.dateTimePicker_Fecha.Name = "dateTimePicker_Fecha";
            this.dateTimePicker_Fecha.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_Fecha.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Materia_Prima,
            this.Tipo_Pieza,
            this.Cantidad,
            this.Unidad,
            this.Fecha});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(567, 457);
            this.dataGridView1.TabIndex = 19;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Materia_Prima
            // 
            this.Materia_Prima.HeaderText = "Materia prima";
            this.Materia_Prima.Name = "Materia_Prima";
            // 
            // Tipo_Pieza
            // 
            this.Tipo_Pieza.HeaderText = "Tipo de pieza";
            this.Tipo_Pieza.Name = "Tipo_Pieza";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Unidad
            // 
            this.Unidad.HeaderText = "Unidad";
            this.Unidad.Name = "Unidad";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Orden_de_pelado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 508);
            this.Controls.Add(this.groupBox_Historial);
            this.Controls.Add(this.groupBox_DatosPelado);
            this.MaximumSize = new System.Drawing.Size(922, 546);
            this.MinimumSize = new System.Drawing.Size(922, 546);
            this.Name = "Orden_de_pelado";
            this.Text = "Orden de pelado";
            this.groupBox_DatosPelado.ResumeLayout(false);
            this.groupBox_DatosPelado.PerformLayout();
            this.groupBox_Historial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion
        private void Orden_Pelado_Load(object sender, EventArgs e)
        {
            Diseño_Forma();
        }
    }
}
