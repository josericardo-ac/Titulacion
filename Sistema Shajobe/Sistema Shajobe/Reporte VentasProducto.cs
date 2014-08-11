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
    public partial class Reporte_VentasProducto : Form
    {
        public Reporte_VentasProducto()
        {
            InitializeComponent();
        }
        public string _Apartir;
        public string _Hasta;
        public string recibe_DatoH(string Hasta)
        {
            this._Hasta = Hasta;
            return _Hasta;
        }
        public string recibe_DatoA(string Apartir)
        {
            this._Apartir = Apartir;
            return _Apartir;
        }
        private void Reporte_VentasProducto_Load(object sender, EventArgs e)
        {
            //Diseño de la ventana
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(196)))));
            this.Icon = global::Sistema_Shajobe.Properties.Resources.Caja_ICO;
            //REPORTE CRISTAL REPORT
            //PRIMER PARAMETRO
            ReportDocument reporte = new ReportDocument();
            ParameterField parametro = new ParameterField();
            ParameterFields parametros = new ParameterFields();
            ParameterDiscreteValue discretos = new ParameterDiscreteValue();
            parametro.Name = "@Apartir";
            discretos.Value = Convert.ToDateTime(_Apartir);
            parametro.CurrentValues.Add(discretos);
            parametros.Add(parametro);
            //SEGUNDO PARAMETRO
            ParameterField parametro1 = new ParameterField();
            ParameterDiscreteValue discretos1 = new ParameterDiscreteValue();
            parametro1.Name = "@Hasta";
            discretos1.Value = Convert.ToDateTime(_Hasta);
            parametro1.CurrentValues.Add(discretos1);
            parametros.Add(parametro1);
            crystalReportViewer1.ParameterFieldInfo = parametros;
            crystalReportViewer1.ReportSource = RVentas1;
        }

        private void Reporte_VentasProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            //-------------------------------------------------------------
            //-------------------AL CERRAR LA VENTANA----------------------
            //-------------------------------------------------------------
            Dispose();
            Application.OpenForms["Busqueda_de_promedio_de_ventas"].Activate();
        }
    }
}
