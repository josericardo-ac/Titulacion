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
            groupBox_DatosPelado = new System.Windows.Forms.GroupBox();
            groupBox_Historial = new System.Windows.Forms.GroupBox();
            comboBox_Almacen = new System.Windows.Forms.ComboBox();
            comboBox_Materiaprima = new System.Windows.Forms.ComboBox();
            comboBox_Tipopieza = new System.Windows.Forms.ComboBox();
            comboBox_Unidad = new System.Windows.Forms.ComboBox();
            txt_Lote = new System.Windows.Forms.TextBox();
            txt_Cantidad = new System.Windows.Forms.TextBox();
            txt_Preciocompra = new System.Windows.Forms.TextBox();
            txt_Precioventa = new System.Windows.Forms.TextBox();
            lbl_Almacen = new System.Windows.Forms.Label();
            lbl_Lote = new System.Windows.Forms.Label();
            lbl_IdMateriaprima = new System.Windows.Forms.Label();
            lbl_Id_Tipopieza = new System.Windows.Forms.Label();
            lbl_Cantidad = new System.Windows.Forms.Label();
            lbl_Preciocompra = new System.Windows.Forms.Label();
            lbl_Precioventa = new System.Windows.Forms.Label();
            lbl_Fecha = new System.Windows.Forms.Label();
            lbl_Unidad = new System.Windows.Forms.Label();
            dateTimePicker_Fecha = new System.Windows.Forms.DateTimePicker();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Materia_Prima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Tipo_Pieza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBox_DatosPelado.SuspendLayout();
            groupBox_Historial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).BeginInit();
            SuspendLayout();
            #endregion
            // 
            // groupBox_DatosPelado
            // 
            groupBox_DatosPelado.Controls.Add(dateTimePicker_Fecha);
            groupBox_DatosPelado.Controls.Add(lbl_Unidad);
            groupBox_DatosPelado.Controls.Add(lbl_Fecha);
            groupBox_DatosPelado.Controls.Add(lbl_Precioventa);
            groupBox_DatosPelado.Controls.Add(lbl_Preciocompra);
            groupBox_DatosPelado.Controls.Add(lbl_Cantidad);
            groupBox_DatosPelado.Controls.Add(lbl_Id_Tipopieza);
            groupBox_DatosPelado.Controls.Add(lbl_IdMateriaprima);
            groupBox_DatosPelado.Controls.Add(lbl_Lote);
            groupBox_DatosPelado.Controls.Add(lbl_Almacen);
            groupBox_DatosPelado.Controls.Add(txt_Precioventa);
            groupBox_DatosPelado.Controls.Add(txt_Preciocompra);
            groupBox_DatosPelado.Controls.Add(txt_Cantidad);
            groupBox_DatosPelado.Controls.Add(txt_Lote);
            groupBox_DatosPelado.Controls.Add(comboBox_Unidad);
            groupBox_DatosPelado.Controls.Add(comboBox_Tipopieza);
            groupBox_DatosPelado.Controls.Add(comboBox_Materiaprima);
            groupBox_DatosPelado.Controls.Add(comboBox_Almacen);
            groupBox_DatosPelado.Location = new System.Drawing.Point(6, 28);
            groupBox_DatosPelado.Name = "groupBox_DatosPelado";
            groupBox_DatosPelado.Size = new System.Drawing.Size(314, 293);
            groupBox_DatosPelado.TabIndex = 0;
            groupBox_DatosPelado.TabStop = false;
            groupBox_DatosPelado.Text = "Datos de orden de pelado";
            // 
            // groupBox_Historial
            // 
            groupBox_Historial.Controls.Add(dataGridView1);
            groupBox_Historial.Location = new System.Drawing.Point(326, 28);
            groupBox_Historial.Name = "groupBox_Historial";
            groupBox_Historial.Size = new System.Drawing.Size(573, 476);
            groupBox_Historial.TabIndex = 0;
            groupBox_Historial.TabStop = false;
            groupBox_Historial.Text = "Historial de orden de pelado";
            // 
            // comboBox_Almacen
            // 
            comboBox_Almacen.FormattingEnabled = true;
            comboBox_Almacen.Location = new System.Drawing.Point(101, 34);
            comboBox_Almacen.Name = "comboBox_Almacen";
            comboBox_Almacen.Size = new System.Drawing.Size(121, 21);
            comboBox_Almacen.TabIndex = 0;
            // 
            // comboBox_Materiaprima
            // 
            comboBox_Materiaprima.FormattingEnabled = true;
            comboBox_Materiaprima.Location = new System.Drawing.Point(101, 97);
            comboBox_Materiaprima.Name = "comboBox_Materiaprima";
            comboBox_Materiaprima.Size = new System.Drawing.Size(121, 21);
            comboBox_Materiaprima.TabIndex = 1;
            // 
            // comboBox_Tipopieza
            // 
            comboBox_Tipopieza.FormattingEnabled = true;
            comboBox_Tipopieza.Location = new System.Drawing.Point(101, 129);
            comboBox_Tipopieza.Name = "comboBox_Tipopieza";
            comboBox_Tipopieza.Size = new System.Drawing.Size(121, 21);
            comboBox_Tipopieza.TabIndex = 2;
            // 
            // comboBox_Unidad
            // 
            comboBox_Unidad.FormattingEnabled = true;
            comboBox_Unidad.Location = new System.Drawing.Point(207, 161);
            comboBox_Unidad.Name = "comboBox_Unidad";
            comboBox_Unidad.Size = new System.Drawing.Size(79, 21);
            comboBox_Unidad.TabIndex = 3;
            // 
            // txt_Lote
            // 
            txt_Lote.Location = new System.Drawing.Point(101, 66);
            txt_Lote.Name = "txt_Lote";
            txt_Lote.Size = new System.Drawing.Size(100, 20);
            txt_Lote.TabIndex = 4;
            // 
            // txt_Cantidad
            // 
            txt_Cantidad.Location = new System.Drawing.Point(101, 161);
            txt_Cantidad.Name = "txt_Cantidad";
            txt_Cantidad.Size = new System.Drawing.Size(100, 20);
            txt_Cantidad.TabIndex = 5;
            // 
            // txt_Preciocompra
            // 
            txt_Preciocompra.Location = new System.Drawing.Point(101, 192);
            txt_Preciocompra.Name = "txt_Preciocompra";
            txt_Preciocompra.Size = new System.Drawing.Size(100, 20);
            txt_Preciocompra.TabIndex = 6;
            // 
            // txt_Precioventa
            // 
            txt_Precioventa.Location = new System.Drawing.Point(101, 223);
            txt_Precioventa.Name = "txt_Precioventa";
            txt_Precioventa.Size = new System.Drawing.Size(100, 20);
            txt_Precioventa.TabIndex = 7;
            // 
            // lbl_Almacen
            // 
            lbl_Almacen.AutoSize = true;
            lbl_Almacen.Location = new System.Drawing.Point(20, 42);
            lbl_Almacen.Name = "lbl_Almacen";
            lbl_Almacen.Size = new System.Drawing.Size(48, 13);
            lbl_Almacen.TabIndex = 9;
            lbl_Almacen.Text = "Almacén";
            // 
            // lbl_Lote
            // 
            lbl_Lote.AutoSize = true;
            lbl_Lote.Location = new System.Drawing.Point(20, 73);
            lbl_Lote.Name = "lbl_Lote";
            lbl_Lote.Size = new System.Drawing.Size(28, 13);
            lbl_Lote.TabIndex = 10;
            lbl_Lote.Text = "Lote";
            // 
            // lbl_IdMateriaprima
            // 
            lbl_IdMateriaprima.AutoSize = true;
            lbl_IdMateriaprima.Location = new System.Drawing.Point(20, 105);
            lbl_IdMateriaprima.Name = "lbl_IdMateriaprima";
            lbl_IdMateriaprima.Size = new System.Drawing.Size(70, 13);
            lbl_IdMateriaprima.TabIndex = 11;
            lbl_IdMateriaprima.Text = "Materia prima";
            // 
            // lbl_Id_Tipopieza
            // 
            lbl_Id_Tipopieza.AutoSize = true;
            lbl_Id_Tipopieza.Location = new System.Drawing.Point(20, 137);
            lbl_Id_Tipopieza.Name = "lbl_Id_Tipopieza";
            lbl_Id_Tipopieza.Size = new System.Drawing.Size(71, 13);
            lbl_Id_Tipopieza.TabIndex = 12;
            lbl_Id_Tipopieza.Text = "Tipo de pieza";
            // 
            // lbl_Cantidad
            // 
            lbl_Cantidad.AutoSize = true;
            lbl_Cantidad.Location = new System.Drawing.Point(20, 169);
            lbl_Cantidad.Name = "lbl_Cantidad";
            lbl_Cantidad.Size = new System.Drawing.Size(49, 13);
            lbl_Cantidad.TabIndex = 13;
            lbl_Cantidad.Text = "Cantidad";
            // 
            // lbl_Preciocompra
            // 
            lbl_Preciocompra.AutoSize = true;
            lbl_Preciocompra.Location = new System.Drawing.Point(20, 199);
            lbl_Preciocompra.Name = "lbl_Preciocompra";
            lbl_Preciocompra.Size = new System.Drawing.Size(75, 13);
            lbl_Preciocompra.TabIndex = 14;
            lbl_Preciocompra.Text = "Precio compra";
            // 
            // lbl_Precioventa
            // 
            lbl_Precioventa.AutoSize = true;
            lbl_Precioventa.Location = new System.Drawing.Point(20, 230);
            lbl_Precioventa.Name = "lbl_Precioventa";
            lbl_Precioventa.Size = new System.Drawing.Size(67, 13);
            lbl_Precioventa.TabIndex = 15;
            lbl_Precioventa.Text = "Precio venta";
            // 
            // lbl_Fecha
            // 
            lbl_Fecha.AutoSize = true;
            lbl_Fecha.Location = new System.Drawing.Point(20, 261);
            lbl_Fecha.Name = "lbl_Fecha";
            lbl_Fecha.Size = new System.Drawing.Size(37, 13);
            lbl_Fecha.TabIndex = 16;
            lbl_Fecha.Text = "Fecha";
            // 
            // lbl_Unidad
            // 
            lbl_Unidad.AutoSize = true;
            lbl_Unidad.Location = new System.Drawing.Point(245, 145);
            lbl_Unidad.Name = "lbl_Unidad";
            lbl_Unidad.Size = new System.Drawing.Size(41, 13);
            lbl_Unidad.TabIndex = 17;
            lbl_Unidad.Text = "Unidad";
            // 
            // dateTimePicker_Fecha
            // 
            dateTimePicker_Fecha.Location = new System.Drawing.Point(101, 254);
            dateTimePicker_Fecha.Name = "dateTimePicker_Fecha";
            dateTimePicker_Fecha.Size = new System.Drawing.Size(200, 20);
            dateTimePicker_Fecha.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Id,
            Materia_Prima,
            Tipo_Pieza,
            Cantidad,
            Unidad,
            Fecha});
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(3, 16);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(567, 457);
            dataGridView1.TabIndex = 19;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // Materia_Prima
            // 
            Materia_Prima.HeaderText = "Materia prima";
            Materia_Prima.Name = "Materia_Prima";
            // 
            // Tipo_Pieza
            // 
            Tipo_Pieza.HeaderText = "Tipo de pieza";
            Tipo_Pieza.Name = "Tipo_Pieza";
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
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            // 
            // Orden_de_pelado
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(196)))));
            ClientSize = new System.Drawing.Size(906, 508);
            Controls.Add(groupBox_Historial);
            Controls.Add(groupBox_DatosPelado);
            MaximumSize = new System.Drawing.Size(922, 546);
            MinimumSize = new System.Drawing.Size(922, 546);
            MaximizeBox = false;
            Name = "Orden_de_pelado";
            Text = "Orden de pelado";
            groupBox_DatosPelado.ResumeLayout(false);
            groupBox_DatosPelado.PerformLayout();
            groupBox_Historial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).EndInit();
            ResumeLayout(false);
        }
        #endregion
        private void Orden_Pelado_Load(object sender, EventArgs e)
        {
            Diseño_Forma();
        }
    }
}
