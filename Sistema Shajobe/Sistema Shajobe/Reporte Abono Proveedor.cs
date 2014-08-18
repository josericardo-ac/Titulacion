using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//LIBRERIAS DE REPORTES
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Sistema_Shajobe.Properties;//Nos permite tener acceso y control sobre las propiedades del proyecto en este caso la direccion del appconfig y entre otros


namespace Sistema_Shajobe
{
    public partial class Reporte_Abono_Proveedor : Form
    {
        public Reporte_Abono_Proveedor()
        {
            InitializeComponent();
        }
        public int Id_Proveedor;
        public int recibe(int dato)
        {
            this.Id_Proveedor = dato;
            return Id_Proveedor;
        }
        private void Reporte_Abono_Proveedor_Load(object sender, EventArgs e)
        {
            //Diseño de la ventana
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(196)))));
            this.Icon = global::Sistema_Shajobe.Properties.Resources.Proveedores_ICO;
            //REPORTE CRISTAL REPORT
            ReportDocument reporte = new ReportDocument();
            ParameterField parametro = new ParameterField();
            ParameterFields parametros = new ParameterFields();
            ParameterDiscreteValue discretos = new ParameterDiscreteValue();
            parametro.Name = "@Dato_Proveedor";
            discretos.Value = Id_Proveedor;
            parametro.CurrentValues.Add(discretos);
            parametros.Add(parametro);
            crystalReportViewer1.ParameterFieldInfo = parametros;
            //reporte.Load(@"Titulacion\Sistema Shajobe\Sistema Shajobe\RCliente.rpt");
            crystalReportViewer1.ReportSource = RAbonoProveedor1;
        }

        private void Reporte_Abono_Proveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            //-------------------------------------------------------------
            //-------------------AL CERRAR LA VENTANA----------------------
            //-------------------------------------------------------------
            Dispose();
            Application.OpenForms["Abono_Proveedor"].Activate();
        }
    }
}
