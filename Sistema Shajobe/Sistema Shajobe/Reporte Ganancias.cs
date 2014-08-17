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
//LIBRERIAS DE REPORTES
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Sistema_Shajobe.Properties;//Nos permite tener acceso y control sobre las propiedades del proyecto en este caso la direccion del appconfig y entre otros

namespace Sistema_Shajobe
{
    public partial class Reporte_Ganancias : Form
    {
        public Reporte_Ganancias()
        {
            InitializeComponent();
        }
        public string _Apartir;
        public string _Hasta;
        private decimal p;
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
        private void Reporte_Ganancias_Load(object sender, EventArgs e)
        {
            //Diseño de la ventana
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(196)))));
            this.Icon = global::Sistema_Shajobe.Properties.Resources.Caja_ICO;
            //PROCEDIMIENTO ALMACENADO PARA OBTENER LA GANANCIA
            OleDbConnection conexion = null;
            OleDbTransaction transaccion = null;
            try
            {
                //Declarando variables de retorno
                OleDbParameter verificar = new OleDbParameter("@Ganancia", OleDbType.Decimal);
                verificar.Direction = ParameterDirection.Output;
                //
                conexion = new OleDbConnection(ObtenerString());
                conexion.Open();
                transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                OleDbCommand comando = new OleDbCommand("USP_CalculoGanancias", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Apartir",Convert.ToDateTime( _Apartir));
                comando.Parameters.AddWithValue("@Hasta",Convert.ToDateTime( _Hasta));//Corregir este campo
                comando.Parameters.Add(verificar);
                comando.ExecuteNonQuery();
                transaccion.Commit();
                p = Convert.ToDecimal(verificar.Value);
            }
            catch (Exception)
            {
                transaccion.Rollback();
            }
            finally
            {
                conexion.Close();
            }
            
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

            ParameterField parametro2 = new ParameterField();
            ParameterDiscreteValue discretos2 = new ParameterDiscreteValue();
            parametro2.Name = "@Ganancia";
            discretos2.Value = Convert.ToDecimal(p) ;
            parametro2.CurrentValues.Add(discretos2);
            parametros.Add(parametro2);

            crystalReportViewer1.ParameterFieldInfo = parametros;
            crystalReportViewer1.ReportSource = RHistorialGanancias1;
        }
        private void Reporte_Ganancias_FormClosing(object sender, FormClosingEventArgs e)
        {
            //-------------------------------------------------------------
            //-------------------AL CERRAR LA VENTANA----------------------
            //-------------------------------------------------------------
            Dispose();
            Application.OpenForms["Busqueda_de_Ganancias"].Activate();
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
    }
}
