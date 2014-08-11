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
    public partial class Clientes_deudores : Form
    {
        public Clientes_deudores()
        {
            InitializeComponent();
        }
        private void Clientes_deudores_Load(object sender, EventArgs e)
        {
            //Diseño de la ventana
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(196)))));
            this.Icon = global::Sistema_Shajobe.Properties.Resources.Clientes_ICO;
            crystalReportViewer1.ReportSource = RClientesDeudores1;
        }
        private void Clientes_deudores_FormClosing(object sender, FormClosingEventArgs e)
        {
            //-------------------------------------------------------------
            //-------------------AL CERRAR LA VENTANA----------------------
            //-------------------------------------------------------------
            Dispose();
            Application.OpenForms["Menu_principal"].Activate();
        }
    }
}
